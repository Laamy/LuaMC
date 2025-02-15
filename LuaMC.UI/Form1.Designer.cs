using LuaMC.UI.SDK;

namespace LuaMC.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.OutputConsole = new System.Windows.Forms.Panel();
            this.output = new LuaMC.UI.SDK.ControlTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlebar_MinBtn = new System.Windows.Forms.Label();
            this.Titlebar_MinMaxBtn = new System.Windows.Forms.Label();
            this.Titlebar_XBtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.OutputConsole.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.titlebarPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 27);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(902, 941);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // OutputConsole
            // 
            this.OutputConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.OutputConsole.Controls.Add(this.output);
            this.OutputConsole.Controls.Add(this.panel4);
            this.OutputConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputConsole.Location = new System.Drawing.Point(0, 968);
            this.OutputConsole.Name = "OutputConsole";
            this.OutputConsole.Size = new System.Drawing.Size(902, 108);
            this.OutputConsole.TabIndex = 3;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.output.HideSelection = false;
            this.output.Location = new System.Drawing.Point(0, 18);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(902, 90);
            this.output.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 18);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1076);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 18);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ready";
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.titlebarPanel.Controls.Add(this.menuStrip1);
            this.titlebarPanel.Controls.Add(this.panel2);
            this.titlebarPanel.Controls.Add(this.Titlebar_MinBtn);
            this.titlebarPanel.Controls.Add(this.Titlebar_MinMaxBtn);
            this.titlebarPanel.Controls.Add(this.Titlebar_XBtn);
            this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(902, 27);
            this.titlebarPanel.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(32, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem});
            this.debugToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.buildToolStripMenuItem.Text = "Build";
            this.buildToolStripMenuItem.Click += new System.EventHandler(this.buildToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.viewToolStripMenuItem.Text = "Windows";
            // 
            // viewGraphToolStripMenuItem
            // 
            this.viewGraphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputConsoleToolStripMenuItem});
            this.viewGraphToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.viewGraphToolStripMenuItem.Name = "viewGraphToolStripMenuItem";
            this.viewGraphToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.viewGraphToolStripMenuItem.Text = "View Graph..";
            // 
            // outputConsoleToolStripMenuItem
            // 
            this.outputConsoleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.outputConsoleToolStripMenuItem.Name = "outputConsoleToolStripMenuItem";
            this.outputConsoleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.outputConsoleToolStripMenuItem.Text = "Output Console";
            this.outputConsoleToolStripMenuItem.Click += new System.EventHandler(this.outputConsoleToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 27);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LuaMC.UI.Properties.Resources.Untitled;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Titlebar_MinBtn
            // 
            this.Titlebar_MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_MinBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 8F);
            this.Titlebar_MinBtn.ForeColor = System.Drawing.Color.Gray;
            this.Titlebar_MinBtn.Location = new System.Drawing.Point(812, 0);
            this.Titlebar_MinBtn.Name = "Titlebar_MinBtn";
            this.Titlebar_MinBtn.Size = new System.Drawing.Size(30, 27);
            this.Titlebar_MinBtn.TabIndex = 3;
            this.Titlebar_MinBtn.Text = "X";
            this.Titlebar_MinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titlebar_MinMaxBtn
            // 
            this.Titlebar_MinMaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_MinMaxBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 8F);
            this.Titlebar_MinMaxBtn.ForeColor = System.Drawing.Color.Gray;
            this.Titlebar_MinMaxBtn.Location = new System.Drawing.Point(842, 0);
            this.Titlebar_MinMaxBtn.Name = "Titlebar_MinMaxBtn";
            this.Titlebar_MinMaxBtn.Size = new System.Drawing.Size(30, 27);
            this.Titlebar_MinMaxBtn.TabIndex = 2;
            this.Titlebar_MinMaxBtn.Text = "X";
            this.Titlebar_MinMaxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titlebar_XBtn
            // 
            this.Titlebar_XBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Titlebar_XBtn.Font = new System.Drawing.Font("Segoe Fluent Icons", 8F);
            this.Titlebar_XBtn.ForeColor = System.Drawing.Color.Gray;
            this.Titlebar_XBtn.Location = new System.Drawing.Point(872, 0);
            this.Titlebar_XBtn.Name = "Titlebar_XBtn";
            this.Titlebar_XBtn.Size = new System.Drawing.Size(30, 27);
            this.Titlebar_XBtn.TabIndex = 1;
            this.Titlebar_XBtn.Text = "X";
            this.Titlebar_XBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(902, 1094);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.OutputConsole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebarPanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(768, 569);
            this.Name = "Form1";
            this.Text = "LuaMC Datapack Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.OutputConsole.ResumeLayout(false);
            this.OutputConsole.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel OutputConsole;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private ControlTextBox output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titlebar_XBtn;
        private System.Windows.Forms.Label Titlebar_MinBtn;
        private System.Windows.Forms.Label Titlebar_MinMaxBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputConsoleToolStripMenuItem;
    }
}

