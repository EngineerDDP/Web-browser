using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五毛浏览器
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Btn_Enter_Click(object sender, EventArgs e)
		{
			try
			{
				if (TextBox_WebLink.Text != "")
				{
					WebBrowser_Main.Navigate(TextBox_WebLink.Text);
				}
			}
			catch (Exception)
			{ }
		}

		private void Btn_Forward_Click(object sender, EventArgs e)
		{
			WebBrowser_Main.GoForward();
		}

		private void Btn_backward_Click(object sender, EventArgs e)
		{
			WebBrowser_Main.GoBack();
		}

		private void WebBrowser_Main_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			Btn_backward.Enabled = WebBrowser_Main.CanGoBack;
			Btn_Forward.Enabled = WebBrowser_Main.CanGoForward;
			TextBox_WebLink.Text = WebBrowser_Main.Url.AbsoluteUri;
		}

		private void TextBox_WebLink_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Btn_Enter_Click(null, new EventArgs());
		}
	}
}
