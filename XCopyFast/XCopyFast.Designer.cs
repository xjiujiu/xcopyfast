namespace XCopyFast
{
    partial class XCopyFast
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCopyFast));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectSrcRootDir = new System.Windows.Forms.Button();
            this.SelectDescDir = new System.Windows.Forms.Button();
            this.SrcRootDir = new System.Windows.Forms.TextBox();
            this.DescDir = new System.Windows.Forms.TextBox();
            this.SrcSubDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.StartCopyBtn = new System.Windows.Forms.Button();
            this.FBDBaseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.FBDDescDir = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIClose = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.SelectSrcRootDir);
            this.groupBox1.Controls.Add(this.SelectDescDir);
            this.groupBox1.Controls.Add(this.SrcRootDir);
            this.groupBox1.Controls.Add(this.DescDir);
            this.groupBox1.Controls.Add(this.SrcSubDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SelectSrcRootDir
            // 
            resources.ApplyResources(this.SelectSrcRootDir, "SelectSrcRootDir");
            this.SelectSrcRootDir.Name = "SelectSrcRootDir";
            this.SelectSrcRootDir.UseVisualStyleBackColor = true;
            this.SelectSrcRootDir.Click += new System.EventHandler(this.SelectSrcRootDir_Click);
            // 
            // SelectDescDir
            // 
            resources.ApplyResources(this.SelectDescDir, "SelectDescDir");
            this.SelectDescDir.Name = "SelectDescDir";
            this.SelectDescDir.UseVisualStyleBackColor = true;
            this.SelectDescDir.Click += new System.EventHandler(this.SelectDescDir_Click);
            // 
            // SrcRootDir
            // 
            resources.ApplyResources(this.SrcRootDir, "SrcRootDir");
            this.SrcRootDir.Name = "SrcRootDir";
            // 
            // DescDir
            // 
            resources.ApplyResources(this.DescDir, "DescDir");
            this.DescDir.Name = "DescDir";
            // 
            // SrcSubDir
            // 
            resources.ApplyResources(this.SrcSubDir, "SrcSubDir");
            this.SrcSubDir.Name = "SrcSubDir";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.LogTextBox);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // LogTextBox
            // 
            resources.ApplyResources(this.LogTextBox, "LogTextBox");
            this.LogTextBox.BackColor = System.Drawing.Color.White;
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.Name = "LogTextBox";
            // 
            // StartCopyBtn
            // 
            resources.ApplyResources(this.StartCopyBtn, "StartCopyBtn");
            this.StartCopyBtn.Name = "StartCopyBtn";
            this.StartCopyBtn.UseVisualStyleBackColor = true;
            this.StartCopyBtn.Click += new System.EventHandler(this.StartCopyBtn_Click);
            // 
            // FBDBaseDir
            // 
            resources.ApplyResources(this.FBDBaseDir, "FBDBaseDir");
            // 
            // FBDDescDir
            // 
            resources.ApplyResources(this.FBDDescDir, "FBDDescDir");
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.TSMIClose});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            resources.ApplyResources(this.选项ToolStripMenuItem, "选项ToolStripMenuItem");
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            // 
            // 帮助ToolStripMenuItem
            // 
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于本软件ToolStripMenuItem,
            this.联系作者ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            // 
            // 关于本软件ToolStripMenuItem
            // 
            resources.ApplyResources(this.关于本软件ToolStripMenuItem, "关于本软件ToolStripMenuItem");
            this.关于本软件ToolStripMenuItem.Name = "关于本软件ToolStripMenuItem";
            // 
            // 联系作者ToolStripMenuItem
            // 
            resources.ApplyResources(this.联系作者ToolStripMenuItem, "联系作者ToolStripMenuItem");
            this.联系作者ToolStripMenuItem.Name = "联系作者ToolStripMenuItem";
            // 
            // TSMIClose
            // 
            resources.ApplyResources(this.TSMIClose, "TSMIClose");
            this.TSMIClose.Name = "TSMIClose";
            this.TSMIClose.Click += new System.EventHandler(this.TSMIClose_Click);
            // 
            // XCopyFast
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartCopyBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "XCopyFast";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SelectDescDir;
        private System.Windows.Forms.TextBox DescDir;
        private System.Windows.Forms.TextBox SrcSubDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StartCopyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SrcRootDir;
        private System.Windows.Forms.Button SelectSrcRootDir;
        private System.Windows.Forms.FolderBrowserDialog FBDBaseDir;
        private System.Windows.Forms.FolderBrowserDialog FBDDescDir;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIClose;
        private System.Windows.Forms.ToolStripMenuItem 关于本软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系作者ToolStripMenuItem;
    }
}

