namespace HardwareMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.CPUcounter = new System.Diagnostics.PerformanceCounter();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.RAMcounter = new System.Diagnostics.PerformanceCounter();
            this.lblhddused = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblbaseclock = new System.Windows.Forms.Label();
            this.lblused = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.btnINFO = new System.Windows.Forms.Button();
            this.lblhddactivity = new System.Windows.Forms.Label();
            this.btncpu = new System.Windows.Forms.Button();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.rdbtneng = new System.Windows.Forms.RadioButton();
            this.rdbtnita = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CPUcounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMcounter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 100;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(850, 71);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Gainsboro;
            this.circularProgressBar1.ProgressWidth = 15;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(125, 125);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 6;
            this.circularProgressBar1.Text = "N/D%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // CPUcounter
            // 
            this.CPUcounter.CategoryName = "processor";
            this.CPUcounter.CounterName = "% processor time";
            this.CPUcounter.InstanceName = "_total";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 750;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(850, 238);
            this.circularProgressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.BlueViolet;
            this.circularProgressBar2.ProgressWidth = 15;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(125, 125);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 15;
            this.circularProgressBar2.Text = "N/D%";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // RAMcounter
            // 
            this.RAMcounter.CategoryName = "Memory";
            this.RAMcounter.CounterName = "% committed bytes in use";
            // 
            // lblhddused
            // 
            this.lblhddused.AutoSize = true;
            this.lblhddused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddused.Location = new System.Drawing.Point(151, 467);
            this.lblhddused.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhddused.Name = "lblhddused";
            this.lblhddused.Size = new System.Drawing.Size(58, 25);
            this.lblhddused.TabIndex = 17;
            this.lblhddused.Text = "Used";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impostazioniToolStripMenuItem,
            this.informazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 36);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impostazioniToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            this.impostazioniToolStripMenuItem.Click += new System.EventHandler(this.impostazioniToolStripMenuItem_Click);
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informazioniToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(136, 32);
            this.informazioniToolStripMenuItem.Text = "Informazioni";
            this.informazioniToolStripMenuItem.Click += new System.EventHandler(this.informazioniToolStripMenuItem_Click);
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(148, 111);
            this.lblmodel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(66, 25);
            this.lblmodel.TabIndex = 38;
            this.lblmodel.Text = "Model";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(151, 321);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(56, 25);
            this.lbltotal.TabIndex = 36;
            this.lbltotal.Text = "Total";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.Location = new System.Drawing.Point(143, 386);
            this.lblHDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(115, 51);
            this.lblHDD.TabIndex = 34;
            this.lblHDD.Text = "HDD";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(140, 60);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(113, 51);
            this.lblCPU.TabIndex = 30;
            this.lblCPU.Text = "CPU";
            // 
            // lblbaseclock
            // 
            this.lblbaseclock.AutoSize = true;
            this.lblbaseclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaseclock.Location = new System.Drawing.Point(148, 136);
            this.lblbaseclock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbaseclock.Name = "lblbaseclock";
            this.lblbaseclock.Size = new System.Drawing.Size(112, 25);
            this.lblbaseclock.TabIndex = 35;
            this.lblbaseclock.Text = "Base Clock";
            // 
            // lblused
            // 
            this.lblused.AutoSize = true;
            this.lblused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblused.Location = new System.Drawing.Point(152, 351);
            this.lblused.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblused.Name = "lblused";
            this.lblused.Size = new System.Drawing.Size(58, 25);
            this.lblused.TabIndex = 37;
            this.lblused.Text = "Used";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(140, 239);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(118, 51);
            this.lblRAM.TabIndex = 33;
            this.lblRAM.Text = "RAM";
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusage.Location = new System.Drawing.Point(146, 164);
            this.lblusage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(96, 32);
            this.lblusage.TabIndex = 31;
            this.lblusage.Text = "Usage";
            // 
            // lblavailable
            // 
            this.lblavailable.AutoSize = true;
            this.lblavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailable.Location = new System.Drawing.Point(151, 290);
            this.lblavailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(111, 29);
            this.lblavailable.TabIndex = 32;
            this.lblavailable.Text = "Available";
            // 
            // btnINFO
            // 
            this.btnINFO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFO.Location = new System.Drawing.Point(153, 198);
            this.btnINFO.Margin = new System.Windows.Forms.Padding(2);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(68, 28);
            this.btnINFO.TabIndex = 39;
            this.btnINFO.Text = "INFO";
            this.btnINFO.UseVisualStyleBackColor = false;
            this.btnINFO.Click += new System.EventHandler(this.btnINFO_Click);
            // 
            // lblhddactivity
            // 
            this.lblhddactivity.AutoSize = true;
            this.lblhddactivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhddactivity.Location = new System.Drawing.Point(152, 437);
            this.lblhddactivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhddactivity.Name = "lblhddactivity";
            this.lblhddactivity.Size = new System.Drawing.Size(74, 25);
            this.lblhddactivity.TabIndex = 8;
            this.lblhddactivity.Text = "Activity";
            // 
            // btncpu
            // 
            this.btncpu.Cursor = System.Windows.Forms.Cursors.Help;
            this.btncpu.Location = new System.Drawing.Point(878, 198);
            this.btncpu.Name = "btncpu";
            this.btncpu.Size = new System.Drawing.Size(69, 26);
            this.btncpu.TabIndex = 40;
            this.btncpu.Text = "Settings";
            this.btncpu.UseVisualStyleBackColor = true;
            this.btncpu.Click += new System.EventHandler(this.btncpu_Click);
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 100;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Cursor = System.Windows.Forms.Cursors.Default;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(850, 386);
            this.circularProgressBar3.Margin = new System.Windows.Forms.Padding(2);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.BlueViolet;
            this.circularProgressBar3.ProgressWidth = 15;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar3.Size = new System.Drawing.Size(125, 125);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = "";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 41;
            this.circularProgressBar3.Text = "N/D%";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar3.Value = 68;
            // 
            // rdbtneng
            // 
            this.rdbtneng.AutoSize = true;
            this.rdbtneng.Checked = true;
            this.rdbtneng.Location = new System.Drawing.Point(12, 60);
            this.rdbtneng.Name = "rdbtneng";
            this.rdbtneng.Size = new System.Drawing.Size(75, 21);
            this.rdbtneng.TabIndex = 42;
            this.rdbtneng.TabStop = true;
            this.rdbtneng.Text = "English";
            this.rdbtneng.UseVisualStyleBackColor = true;
            // 
            // rdbtnita
            // 
            this.rdbtnita.AutoSize = true;
            this.rdbtnita.Location = new System.Drawing.Point(12, 99);
            this.rdbtnita.Name = "rdbtnita";
            this.rdbtnita.Size = new System.Drawing.Size(74, 21);
            this.rdbtnita.TabIndex = 43;
            this.rdbtnita.TabStop = true;
            this.rdbtnita.Text = "Italiano";
            this.rdbtnita.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.rdbtnita);
            this.Controls.Add(this.rdbtneng);
            this.Controls.Add(this.circularProgressBar3);
            this.Controls.Add(this.btncpu);
            this.Controls.Add(this.btnINFO);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblHDD);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblbaseclock);
            this.Controls.Add(this.lblused);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.lblhddused);
            this.Controls.Add(this.lblhddactivity);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPUcounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMcounter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Diagnostics.PerformanceCounter CPUcounter;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Diagnostics.PerformanceCounter RAMcounter;
        private System.Windows.Forms.Label lblhddused;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblbaseclock;
        private System.Windows.Forms.Label lblused;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lblavailable;
        private System.Windows.Forms.Button btnINFO;
        private System.Windows.Forms.Label lblhddactivity;
        private System.Windows.Forms.Button btncpu;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private System.Windows.Forms.RadioButton rdbtneng;
        private System.Windows.Forms.RadioButton rdbtnita;
    }
}

