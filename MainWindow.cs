using System;
using System.Linq;
using System.Windows.Forms;
using IMAPI2;

namespace CDBurn
{
    public partial class MainWindow : Form
    {
        private readonly BurnController _burnController = BurnController.GetInstance();
        private readonly DickSpacePublisher _dickSpacePublisher = new DickSpacePublisher();

        private const int BytesInMegabyte = 1024 * 1024;

        public MainWindow()
        {
            InitializeComponent();
            InitializeHandlers();
            InitializeGui();
        }

        private void InitializeHandlers()
        {
            _dickSpacePublisher.UsedSpaceChanged += UsedSpaceValueChanged;
        }

        private void InitializeGui()
        {
            cdDriverComboBox.Items.AddRange(_burnController.GetRecorders());
            filesListBox.Items.Clear();
            addFileButton.Enabled = false;
            discTypeLabel.Text = @"N / A";
            discSizeLabel.Text = @"0 MB";
            _dickSpacePublisher.UsedSpace = 0;
        }

        private void AddFileButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_burnController.DiscAvailable())
                {
                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        if (!filesListBox.Items.OfType<FileNode>().Any(x => x.Path.Equals(filePath)))
                        {
                            var file = new FileNode(filePath);
                            if (!((_dickSpacePublisher.UsedSpace + file.SizeOnDisc) > _dickSpacePublisher.TotalSpace))
                            {
                                filesListBox.Items.Add(file);
                                _dickSpacePublisher.UsedSpace += file.SizeOnDisc;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"Disk is not available.", @"Warning");
                    InitializeGui();
                }
            }
        }

        private void UsedSpaceValueChanged(long value)
        {
            burnButton.Enabled = _dickSpacePublisher.UsedSpace > 0;
            usedSpaceBar.Value = (int)(_dickSpacePublisher.UsedSpace / BytesInMegabyte);
            usedSpaceLabel.Text = $@"{_dickSpacePublisher.UsedSpace / BytesInMegabyte} MB";
        }

        private void CdDriverComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            var recorder = (DiscRecorder)e.ListItem;
            e.Value = $"{recorder.VolumePath} {recorder.RecorderId}";
        }

        private void CheckDiskButtonClick(object sender, EventArgs e)
        {
            InitializeGuiByDiscInfo(_burnController.GetDiscInfo((DiscRecorder)cdDriverComboBox.SelectedItem));
        }

        private void InitializeGuiByDiscInfo(Disc disc)
        {
            discTypeLabel.Text = disc.DiscType.ToString();
            discSizeLabel.Text = $@"{disc.DiscSize / BytesInMegabyte} MB";
            if (disc.DiscType == PhysicalMedia.Unknown)
            {
                MessageBox.Show(@"Disk is not support.", @"Warning");
            }
            else if (disc.DiscState != MediaState.Blank)
            {
                MessageBox.Show(@"Disk is not blank.", @"Warning");
            }
            else
            {
                addFileButton.Enabled = true;
                usedSpaceBar.Maximum = (int)(disc.DiscSize / BytesInMegabyte);
                _dickSpacePublisher.TotalSpace = disc.DiscSize;
            }
        }

        private void FilesListBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((FileNode)e.ListItem).Name;
        }

        private void FilesListBoxMouseClick(object sender, MouseEventArgs e)
        {
            removeFileButton.Enabled = filesListBox.SelectedIndex != -1;
        }

        private void RemoveFileButtonClick(object sender, EventArgs e)
        {
            if (filesListBox.SelectedIndex != -1)
            {
                var removedFile = (FileNode)filesListBox.Items[filesListBox.SelectedIndex];
                _dickSpacePublisher.UsedSpace -= removedFile.SizeOnDisc;
                filesListBox.Items.Remove(removedFile);
                removeFileButton.Enabled = false;
            }
        }

        private void BurnButtonClick(object sender, EventArgs e)
        {
            if (_burnController.DiscAvailable())
            {
                _burnController.PrepareFilesToBurn(filesListBox.Items.OfType<FileNode>().ToList());
                Hide();
                var progressWindow = new BurnProgressWindow();
                progressWindow.FormClosed += BurnProgressWindowFormClosed;
                progressWindow.Show();
            }
            else
            {
                MessageBox.Show(@"Disk is not available.", @"Warning");
                InitializeGui();
            }
        }

        private void BurnProgressWindowFormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeGui();
            Show();
        }
    }
}
