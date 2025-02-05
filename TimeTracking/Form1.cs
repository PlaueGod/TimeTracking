using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TimeTracking
{
    public partial class Form1 : Form
    {
        private string appPath;
        private CancellationTokenSource cts;
        private double remainingUsageTime;
        private DateTime blockEndTime;
        private bool isTimerRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableFormDragging(this);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable Files|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    appPath = openFileDialog.FileName;
                    textBox1.Text = appPath;
                }
            }
        }

        private void ClearTextBox_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            isTimerRunning = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label1.Text = "Time:";
            MessageBox.Show("Timer Clear.");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void GoBlock_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
                return;

            if (string.IsNullOrEmpty(appPath) || !File.Exists(appPath))
            {
                MessageBox.Show("Select the correct exe file.");
                return;
            }

            if (!double.TryParse(textBox2.Text, out double usageTime) || usageTime <= 0 ||
                !double.TryParse(textBox3.Text, out double blockTime) || blockTime <= 0)
            {
                MessageBox.Show("Enter the correct time in minutes.");
                return;
            }

            cts = new CancellationTokenSource();
            remainingUsageTime = usageTime;
            isTimerRunning = true;
            UpdateTimerDisplay();

            while (remainingUsageTime > 0)
            {
                if (cts.Token.IsCancellationRequested)
                {
                    isTimerRunning = false;
                    return;
                }

                if (IsAppRunning())
                {
                    remainingUsageTime -= 1.0 / 60;
                }

                UpdateTimerDisplay();
                await Task.Delay(1000); 
            }

            MessageBox.Show("The usage time is over. Block the application.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            blockEndTime = DateTime.Now.AddMinutes(blockTime);
            await BlockApp(blockTime, cts.Token);
            isTimerRunning = false;
        }
        private async Task BlockApp(double blockTime, CancellationToken token)
        {
            while (DateTime.Now < blockEndTime)
            {
                if (token.IsCancellationRequested)
                    return;

                var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(appPath));
                foreach (var process in processes)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch { }
                }
                UpdateTimerDisplay();
                await Task.Delay(1000);
            }

            MessageBox.Show("The blocking time has expired. You can start the application again.");
        }

        private bool IsAppRunning()
        {
            return Process.GetProcessesByName(Path.GetFileNameWithoutExtension(appPath)).Any();
        }

        private void UpdateTimerDisplay()
        {
            if (remainingUsageTime > 0)
            {
                label1.Text = $"Time left to use the app: {remainingUsageTime:F1} min";
            }
            else if (DateTime.Now < blockEndTime)
            {
                label1.Text = $"App lock time: {(blockEndTime - DateTime.Now).TotalMinutes:F1} min";

                if (blockEndTime < DateTime.Now)
                {
                    label1.Text = "You can run the application";
                }

            }
            else
            {
            }
        }



        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.BackColor = Color.PaleVioletRed;
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.BackColor = SystemColors.Control;
        }
        private static Point _lastPoint;
        public static void EnableFormDragging(Form form)
        {
            form.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _lastPoint = e.Location;
                }
            };

            form.MouseMove += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    form.Left += e.X - _lastPoint.X;
                    form.Top += e.Y - _lastPoint.Y;
                }
            };
        }

        private async void hideBut_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0; i -= 0.05)
            {
                this.Opacity = i;
                await Task.Delay(10);
            }
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1;

        }

        private void hideBut_MouseEnter(object sender, EventArgs e)
        {
            hideBut.BackColor = Color.SkyBlue;
        }

        private void hideBut_MouseLeave(object sender, EventArgs e)
        {
            hideBut.BackColor = SystemColors.Control;
        }

        private async void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            this.Opacity = 0; 
            this.Show();

            for (double i = 0; i <= 1; i += 0.05) 
            {
                this.Opacity = i;
                await Task.Delay(10);
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SHOWWINDOW = 0x18;

            base.WndProc(ref m);

            if (m.Msg == WM_SHOWWINDOW && m.WParam.ToInt32() == 0)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
