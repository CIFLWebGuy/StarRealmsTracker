using System.Runtime.InteropServices;

namespace StarRealmsTracker
{
    public partial class MainForm : Form
    {
        private Bitmap winImage;
        private Bitmap lossImage;
        private Bitmap offImage;

        private PictureBox[] winLights;
        private PictureBox[] lossLights;
        private const int WM_HOTKEY = 0x0312;

        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public MainForm()
        {
            InitializeComponent();

            winLights = new PictureBox[]
            {
                pictureBoxWin0,
                pictureBoxWin1,
                pictureBoxWin2,
                pictureBoxWin3,
                pictureBoxWin4,
                pictureBoxWin5
            };

            lossLights = new PictureBox[]
            {
                pictureBoxLoss0,
                pictureBoxLoss1
            };

            winImage = new Bitmap("Win.png");
            lossImage = new Bitmap("Loss.png");
            offImage = new Bitmap("Off.png");
        }

        private void UpdateRecord()
        {
            labelRecord.Text = $"{upDownTournamentWin.Value}-{upDownTournamentLoss.Value}";
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xffff);
                ModiferKey modifer = (ModiferKey)((int)m.LParam & 0xffff);

                switch (key)
                {
                    case Keys.Oemplus:
                        if (modifer == ModiferKey.Control)
                        {
                            if (upDownWin.Value < upDownWin.Maximum)
                                upDownWin.Value++;
                        }
                        else if (modifer == ModiferKey.Alt)
                        {
                            if (upDownWin.Value > upDownWin.Maximum)
                                upDownWin.Value--;
                        }

                        break;

                    case Keys.OemMinus:
                        if (modifer == ModiferKey.Control)
                        {
                            if (upDownLoss.Value < upDownLoss.Maximum)
                                upDownLoss.Value++;
                        }
                        else if (modifer != ModiferKey.Alt)
                        {
                            if (upDownLoss.Value > upDownLoss.Maximum)
                                upDownLoss.Value--;
                        }

                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 0, (uint)ModiferKey.Control, (uint)Keys.Oemplus);
            RegisterHotKey(this.Handle, 1, (uint)ModiferKey.Alt, (uint)Keys.Oemplus);
            RegisterHotKey(this.Handle, 2, (uint)ModiferKey.Control, (uint)Keys.OemMinus);
            RegisterHotKey(this.Handle, 3, (uint)ModiferKey.Alt, (uint)Keys.OemMinus);
        }

        private void numericUpDownWin_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i < (int)upDownWin.Value)
                {
                    winLights[i].Image = winImage;
                }
                else
                {
                    winLights[i].Image = offImage;
                }
            }
        }

        private void upDownLoss_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i < (int)upDownLoss.Value)
                {
                    lossLights[i].Image = lossImage;
                }
                else
                {
                    lossLights[i].Image = offImage;
                }
            }
        }

        private void textBoxTournament_Leave(object sender, EventArgs e)
        {
            labelTournamentName.Text = textBoxTournament.Text;
        }

        private void upDownTournamentWin_ValueChanged(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                upDownWin.Value = 0;
                upDownLoss.Value = 0;
            }
            else
            {
                upDownTournamentWin.Value = 0;
                upDownTournamentLoss.Value = 0;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                UnregisterHotKey(this.Handle, i);
            }
        }
    }
}
