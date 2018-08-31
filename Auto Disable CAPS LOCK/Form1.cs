using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
#pragma warning disable IDE1006 // Estilos de nombres
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
#pragma warning restore IDE1006 // Estilos de nombres
        UIntPtr dwExtraInfo);
        const int KEYEVENTF_EXTENDEDKEY = 0x1;
        const int KEYEVENTF_KEYUP = 0x2;
        const int CAPSLOCK = 0x14;

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
        }

        private void Enable_CheckedChanged(object sender, EventArgs e)
        {
            timer.Start();
            timer.Enabled = true;
        }

        private void Disable_CheckedChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
        }

        private void Timer_ms_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (enable.Checked == true && disable.Checked == false)
            {
                int ms = Convert.ToInt32(timer_ms.Value);
                timer.Interval = ms;
                if (IsKeyLocked(Keys.CapsLock))
                {
                    keybd_event(CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                    keybd_event(CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
                }
            }
            else if (enable.Checked == false && disable.Checked == true)
            {
                timer.Stop();
                timer.Enabled = false;
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
            }
        }

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enable.Checked = true;
            enableToolStripMenuItem.Checked = true;
            disableToolStripMenuItem.Checked = false;
            disable.Checked = false;
            timer.Start();
            timer.Enabled = true;
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enable.Checked = false;
            enableToolStripMenuItem.Checked = false;
            disableToolStripMenuItem.Checked = true;
            disable.Checked = true;
            timer.Stop();
            timer.Enabled = false;
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void AutoDisableCAPSLOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
