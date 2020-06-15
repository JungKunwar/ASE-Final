namespace Graphical_Programming_Language_Application
{
     partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtxt_console = new System.Windows.Forms.RichTextBox();
            this.btn_consolerun = new System.Windows.Forms.Button();
            this.btn_console1clear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtxt_errors = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtxt_history = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.drawareapanel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawareapanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Location = new System.Drawing.Point(-1, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 31);
            this.panel1.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.BackgroundImage")));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Minimize.Location = new System.Drawing.Point(1068, 5);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(29, 20);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Location = new System.Drawing.Point(1105, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 31);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_appname.Location = new System.Drawing.Point(333, 0);
            this.lbl_appname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(335, 34);
            this.lbl_appname.TabIndex = 2;
            this.lbl_appname.Text = "Graphical Design Software";
            this.lbl_appname.Click += new System.EventHandler(this.lbl_appname_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbl_appname);
            this.panel2.Controls.Add(this.lbl_StartPosX);
            this.panel2.Controls.Add(this.lbl_StartPosY);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Location = new System.Drawing.Point(-1, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 85);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(855, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start Position :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(992, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "X:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_StartPosX.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartPosX.Location = new System.Drawing.Point(1023, 21);
            this.lbl_StartPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(32, 17);
            this.lbl_StartPosX.TabIndex = 9;
            this.lbl_StartPosX.Text = "000";
            this.lbl_StartPosX.Click += new System.EventHandler(this.lbl_StartPosX_Click);
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_StartPosY.ForeColor = System.Drawing.Color.Black;
            this.lbl_StartPosY.Location = new System.Drawing.Point(1095, 21);
            this.lbl_StartPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(32, 17);
            this.lbl_StartPosY.TabIndex = 10;
            this.lbl_StartPosY.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1064, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Y:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1155, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // openTextToolStripMenuItem
            // 
            this.openTextToolStripMenuItem.Name = "openTextToolStripMenuItem";
            this.openTextToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.openTextToolStripMenuItem.Text = "Open Text";
            this.openTextToolStripMenuItem.Click += new System.EventHandler(this.openTextToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTextToolStripMenuItem});
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // saveTextToolStripMenuItem
            // 
            this.saveTextToolStripMenuItem.Name = "saveTextToolStripMenuItem";
            this.saveTextToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.saveTextToolStripMenuItem.Text = "Save Text";
            this.saveTextToolStripMenuItem.Click += new System.EventHandler(this.saveTextToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUSToolStripMenuItem,
            this.documentationToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutUSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.aboutUSToolStripMenuItem.Text = "About US";
            this.aboutUSToolStripMenuItem.Click += new System.EventHandler(this.aboutUSToolStripMenuItem_Click);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.documentationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.rtxt_console);
            this.panel4.Controls.Add(this.btn_consolerun);
            this.panel4.Controls.Add(this.btn_console1clear);
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Location = new System.Drawing.Point(881, 100);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 459);
            this.panel4.TabIndex = 4;
            // 
            // rtxt_console
            // 
            this.rtxt_console.BackColor = System.Drawing.Color.Silver;
            this.rtxt_console.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_console.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rtxt_console.Location = new System.Drawing.Point(4, 4);
            this.rtxt_console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_console.Name = "rtxt_console";
            this.rtxt_console.Size = new System.Drawing.Size(249, 219);
            this.rtxt_console.TabIndex = 1;
            this.rtxt_console.Text = "";
            this.rtxt_console.TextChanged += new System.EventHandler(this.rtxt_console_TextChanged);
            // 
            // btn_consolerun
            // 
            this.btn_consolerun.BackColor = System.Drawing.Color.Black;
            this.btn_consolerun.ForeColor = System.Drawing.Color.White;
            this.btn_consolerun.Location = new System.Drawing.Point(9, 231);
            this.btn_consolerun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consolerun.Name = "btn_consolerun";
            this.btn_consolerun.Size = new System.Drawing.Size(123, 28);
            this.btn_consolerun.TabIndex = 4;
            this.btn_consolerun.Text = "Run";
            this.btn_consolerun.UseVisualStyleBackColor = false;
            this.btn_consolerun.Click += new System.EventHandler(this.btn_consolerun_Click);
            // 
            // btn_console1clear
            // 
            this.btn_console1clear.BackColor = System.Drawing.Color.Black;
            this.btn_console1clear.ForeColor = System.Drawing.Color.White;
            this.btn_console1clear.Location = new System.Drawing.Point(144, 231);
            this.btn_console1clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_console1clear.Name = "btn_console1clear";
            this.btn_console1clear.Size = new System.Drawing.Size(112, 28);
            this.btn_console1clear.TabIndex = 3;
            this.btn_console1clear.Text = "Clear";
            this.btn_console1clear.UseVisualStyleBackColor = false;
            this.btn_console1clear.Click += new System.EventHandler(this.btn_console1clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 267);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 185);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Lime;
            this.tabPage4.Controls.Add(this.rtxt_errors);
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(243, 147);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Errors";
            // 
            // rtxt_errors
            // 
            this.rtxt_errors.BackColor = System.Drawing.Color.Red;
            this.rtxt_errors.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_errors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxt_errors.Location = new System.Drawing.Point(4, 4);
            this.rtxt_errors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_errors.Name = "rtxt_errors";
            this.rtxt_errors.ReadOnly = true;
            this.rtxt_errors.Size = new System.Drawing.Size(231, 144);
            this.rtxt_errors.TabIndex = 2;
            this.rtxt_errors.Text = "";
            this.rtxt_errors.TextChanged += new System.EventHandler(this.rtxt_errors_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.rtxt_history);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(243, 147);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            // 
            // rtxt_history
            // 
            this.rtxt_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxt_history.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxt_history.Location = new System.Drawing.Point(4, 4);
            this.rtxt_history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_history.Name = "rtxt_history";
            this.rtxt_history.ReadOnly = true;
            this.rtxt_history.Size = new System.Drawing.Size(231, 144);
            this.rtxt_history.TabIndex = 1;
            this.rtxt_history.Text = "";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.drawareapanel);
            this.panel5.Location = new System.Drawing.Point(56, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(817, 457);
            this.panel5.TabIndex = 5;
            // 
            // drawareapanel
            // 
            this.drawareapanel.BackColor = System.Drawing.Color.White;
            this.drawareapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawareapanel.Location = new System.Drawing.Point(0, 0);
            this.drawareapanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawareapanel.Name = "drawareapanel";
            this.drawareapanel.Size = new System.Drawing.Size(817, 457);
            this.drawareapanel.TabIndex = 0;
            this.drawareapanel.TabStop = false;
            this.drawareapanel.Click += new System.EventHandler(this.drawareapanel_Click);
            this.drawareapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.draw);
            this.drawareapanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseClick);
            this.drawareapanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseDown);
            this.drawareapanel.MouseLeave += new System.EventHandler(this.drawareapanel_MouseLeave);
            this.drawareapanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseMove);
            this.drawareapanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawareapanel_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1152, 571);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphical Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawareapanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btn_console1clear;
        private System.Windows.Forms.ToolStripMenuItem openTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToolStripMenuItem;
        private System.Windows.Forms.Button btn_consolerun;
        private System.Windows.Forms.RichTextBox rtxt_console;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtxt_history;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox drawareapanel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox rtxt_errors;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
    }
}

