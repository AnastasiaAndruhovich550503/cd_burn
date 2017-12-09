using System.Threading;
using System.Windows.Forms;
using IMAPI2;
using System;

namespace CDBurn
{
    public partial class BurnProgressWindow : Form
    {
        private readonly BurnController _burnController = BurnController.GetInstance();
        private readonly BurnWriteActionPublisher _burnWriteActionPublisher = new BurnWriteActionPublisher();

        public BurnProgressWindow()
        {
            InitializeComponent();
            PrepareToBurn();
            Burn();
        }

        private void PrepareToBurn()
        {
            _burnWriteActionPublisher.WriteActionChanged += WriteActionChanged;
            _burnController.UpdateBurn += UpdateBurningInformation;
        }

        private void UpdateBurningInformation(FormatWriteUpdateEventArgs e)
        {
            if (!InvokeRequired)
            {
                burnProgressBar.Value = (e.LastWrittenLba - e.StartLba + 1) * 100 / e.SectorCount;
                _burnWriteActionPublisher.WriteAction = e._currentAction;
            }
            else
            {
                Invoke(new Action<FormatWriteUpdateEventArgs>(UpdateBurningInformation), e);
            }
        }

        private void Burn()
        {
            new Thread(_burnController.Burn).Start();
        }

        private void TrayIconMouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
            ShowInTaskbar = true;
        }

        private void BurnProgressWindowResize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized != WindowState) return;
            trayIcon.Visible = true;
            ShowInTaskbar = false;
        }

        private void BurnProgressWindowFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_burnWriteActionPublisher.WriteAction == FormatDataWriteAction.Completed)
            {
                e.Cancel = false;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void WriteActionChanged(FormatDataWriteAction action)
        {
            if (!InvokeRequired)
            {
                progressLabel.Text = action.ToReadableString();
                if (FormWindowState.Minimized == WindowState)
                {
                    trayIcon.BalloonTipText = action.ToReadableString();
                    trayIcon.ShowBalloonTip(1);
                }
                if (action == FormatDataWriteAction.Completed)
                {
                    Close();
                }
            }
            else
            {
                Invoke(new Action<FormatDataWriteAction>(WriteActionChanged), action);

            }
        }
    }
}
