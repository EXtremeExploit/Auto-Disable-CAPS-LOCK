namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_ms = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enable = new System.Windows.Forms.RadioButton();
            this.disable = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDisableCAPSLOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoDisableCAPSLOCKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.timer_ms)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_ms
            // 
            this.timer_ms.AccessibleDescription = "Milliseconds that it will check if CAPS LOCK is enabled and disable it.";
            this.timer_ms.Location = new System.Drawing.Point(11, 32);
            this.timer_ms.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.timer_ms.Name = "timer_ms";
            this.timer_ms.Size = new System.Drawing.Size(156, 20);
            this.timer_ms.TabIndex = 2;
            this.timer_ms.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timer_ms.ValueChanged += new System.EventHandler(this.Timer_ms_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // enable
            // 
            this.enable.AutoSize = true;
            this.enable.Location = new System.Drawing.Point(25, 9);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(58, 17);
            this.enable.TabIndex = 3;
            this.enable.Text = "Enable";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.CheckedChanged += new System.EventHandler(this.Enable_CheckedChanged);
            // 
            // disable
            // 
            this.disable.AutoSize = true;
            this.disable.Checked = true;
            this.disable.Location = new System.Drawing.Point(89, 9);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(60, 17);
            this.disable.TabIndex = 4;
            this.disable.TabStop = true;
            this.disable.Text = "Disable";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.CheckedChanged += new System.EventHandler(this.Disable_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "TipText";
            this.notifyIcon1.BalloonTipTitle = "Title";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Auto Disable CAPS LOCK";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.showToolStripMenuItem,
            this.autoDisableCAPSLOCKToolStripMenuItem,
            this.toolStripSeparator1,
            this.autoDisableCAPSLOCKToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 120);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.EnableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Checked = true;
            this.disableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.DisableToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // autoDisableCAPSLOCKToolStripMenuItem
            // 
            this.autoDisableCAPSLOCKToolStripMenuItem.Name = "autoDisableCAPSLOCKToolStripMenuItem";
            this.autoDisableCAPSLOCKToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.autoDisableCAPSLOCKToolStripMenuItem.Text = "Exit";
            this.autoDisableCAPSLOCKToolStripMenuItem.Click += new System.EventHandler(this.AutoDisableCAPSLOCKToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // autoDisableCAPSLOCKToolStripMenuItem1
            // 
            this.autoDisableCAPSLOCKToolStripMenuItem1.Enabled = false;
            this.autoDisableCAPSLOCKToolStripMenuItem1.Name = "autoDisableCAPSLOCKToolStripMenuItem1";
            this.autoDisableCAPSLOCKToolStripMenuItem1.ShowShortcutKeys = false;
            this.autoDisableCAPSLOCKToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.autoDisableCAPSLOCKToolStripMenuItem1.Text = "Auto Disable CAPS LOCK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 63);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.timer_ms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Auto Disable CAPS LOCK";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.timer_ms)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timer_ms;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton enable;
        private System.Windows.Forms.RadioButton disable;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoDisableCAPSLOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem autoDisableCAPSLOCKToolStripMenuItem1;
    }
}

