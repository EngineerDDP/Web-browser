namespace 五毛浏览器
{
	partial class MainForm
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
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.Btn_Enter = new System.Windows.Forms.ToolStripButton();
			this.TextBox_WebLink = new System.Windows.Forms.ToolStripTextBox();
			this.Btn_backward = new System.Windows.Forms.ToolStripButton();
			this.Btn_Forward = new System.Windows.Forms.ToolStripButton();
			this.Btn_Refrash = new System.Windows.Forms.ToolStripButton();
			this.Btn_Stop = new System.Windows.Forms.ToolStripButton();
			this.WebBrowser_Main = new System.Windows.Forms.WebBrowser();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_backward,
            this.Btn_Forward,
            this.TextBox_WebLink,
            this.Btn_Enter,
            this.Btn_Refrash,
            this.Btn_Stop});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1080, 27);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "控件栏";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.WebBrowser_Main);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1080, 513);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(1080, 540);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// Btn_Enter
			// 
			this.Btn_Enter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Btn_Enter.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Enter.Image")));
			this.Btn_Enter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Btn_Enter.Name = "Btn_Enter";
			this.Btn_Enter.Size = new System.Drawing.Size(23, 24);
			this.Btn_Enter.Text = "toolStripButton1";
			this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
			// 
			// TextBox_WebLink
			// 
			this.TextBox_WebLink.AutoSize = false;
			this.TextBox_WebLink.Margin = new System.Windows.Forms.Padding(1);
			this.TextBox_WebLink.Name = "TextBox_WebLink";
			this.TextBox_WebLink.Size = new System.Drawing.Size(500, 25);
			this.TextBox_WebLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_WebLink_KeyDown);
			// 
			// Btn_backward
			// 
			this.Btn_backward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Btn_backward.Enabled = false;
			this.Btn_backward.Image = ((System.Drawing.Image)(resources.GetObject("Btn_backward.Image")));
			this.Btn_backward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Btn_backward.Name = "Btn_backward";
			this.Btn_backward.Size = new System.Drawing.Size(23, 24);
			this.Btn_backward.Text = "toolStripButton1";
			this.Btn_backward.Click += new System.EventHandler(this.Btn_backward_Click);
			// 
			// Btn_Forward
			// 
			this.Btn_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Btn_Forward.Enabled = false;
			this.Btn_Forward.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Forward.Image")));
			this.Btn_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Btn_Forward.Name = "Btn_Forward";
			this.Btn_Forward.Size = new System.Drawing.Size(23, 24);
			this.Btn_Forward.Text = "toolStripButton2";
			this.Btn_Forward.Click += new System.EventHandler(this.Btn_Forward_Click);
			// 
			// Btn_Refrash
			// 
			this.Btn_Refrash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Btn_Refrash.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Refrash.Image")));
			this.Btn_Refrash.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Btn_Refrash.Name = "Btn_Refrash";
			this.Btn_Refrash.Size = new System.Drawing.Size(23, 24);
			this.Btn_Refrash.Text = "toolStripButton3";
			// 
			// Btn_Stop
			// 
			this.Btn_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Stop.Image")));
			this.Btn_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Btn_Stop.Name = "Btn_Stop";
			this.Btn_Stop.Size = new System.Drawing.Size(23, 24);
			this.Btn_Stop.Text = "toolStripButton4";
			// 
			// WebBrowser_Main
			// 
			this.WebBrowser_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WebBrowser_Main.Location = new System.Drawing.Point(0, 0);
			this.WebBrowser_Main.MinimumSize = new System.Drawing.Size(20, 20);
			this.WebBrowser_Main.Name = "WebBrowser_Main";
			this.WebBrowser_Main.Size = new System.Drawing.Size(1080, 513);
			this.WebBrowser_Main.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 540);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "MainForm";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripButton Btn_Enter;
		private System.Windows.Forms.ToolStripTextBox TextBox_WebLink;
		private System.Windows.Forms.ToolStripButton Btn_Forward;
		private System.Windows.Forms.ToolStripButton Btn_backward;
		private System.Windows.Forms.ToolStripButton Btn_Refrash;
		private System.Windows.Forms.ToolStripButton Btn_Stop;
		private System.Windows.Forms.WebBrowser WebBrowser_Main;
	}
}

