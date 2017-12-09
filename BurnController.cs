using System;
using System.Collections.Generic;
using System.Linq;
using IMAPI2;

namespace CDBurn
{
    class BurnController
    {
        public delegate void UpdateBurnHandler(FormatWriteUpdateEventArgs e);
        public event UpdateBurnHandler UpdateBurn;

        private readonly ImageMaster _imageMaster = new ImageMaster();
        private static readonly BurnController Instance = new BurnController();

        private BurnController()
        {
            _imageMaster.FormatWriteUpdate += _imageMaster_FormatWriteUpdate;
        }

        private void _imageMaster_FormatWriteUpdate(ImageMaster sender, FormatWriteUpdateEventArgs e)
        {
            UpdateBurn?.Invoke(e);
        }

        public static BurnController GetInstance() => Instance;

        public Disc GetDiscInfo(DiscRecorder recorder)
        {
            try
            {
                _imageMaster.Recorders.SelectedIndex = _imageMaster.Recorders.ToList().FindIndex(x =>
                    x.VolumePath.Equals(recorder.VolumePath) && x.RecorderId.Equals(recorder.RecorderId));
                _imageMaster.LoadRecorder();
                _imageMaster.LoadMedia();
                return new Disc()
                {
                    DiscType = _imageMaster.Media,
                    DiscState = _imageMaster.MediaStates.Any(x => x == MediaState.Blank)
                        ? MediaState.Blank
                        : MediaState.Unknown,
                    DiscSize = _imageMaster.MediaCapacity
                };
            }
            catch (Exception)
            {
                return new Disc()
                {
                    DiscType = PhysicalMedia.Unknown,
                    DiscState = MediaState.Unknown,
                    DiscSize = 0
                };
            }
        }

        public DiscRecorder[] GetRecorders()
        {
            return _imageMaster.Recorders.ToArray();
        }

        public void PrepareFilesToBurn(List<FileNode> files)
        {
            _imageMaster.Nodes.Clear();
            _imageMaster.Nodes.AddRange(files);
        }

        public void Burn()
        {
            _imageMaster.WriteImage(BurnVerificationLevel.None, false, false);
        }

        public bool DiscAvailable()
        {
            try
            {
                _imageMaster.LoadMedia();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
