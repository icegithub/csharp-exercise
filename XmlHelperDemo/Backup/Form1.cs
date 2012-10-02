using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace XmlHelperDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuDemo1;
		private System.Windows.Forms.MenuItem mnuDemo2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuDemo1 = new System.Windows.Forms.MenuItem();
			this.mnuDemo2 = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuDemo1,
																					  this.mnuDemo2});
			this.menuItem1.Text = "Select Demo";
			// 
			// mnuDemo1
			// 
			this.mnuDemo1.Index = 0;
			this.mnuDemo1.Text = "Demo1";
			this.mnuDemo1.Click += new System.EventHandler(this.mnuDemo1_Click);
			// 
			// mnuDemo2
			// 
			this.mnuDemo2.Index = 1;
			this.mnuDemo2.Text = "Demo2";
			this.mnuDemo2.Click += new System.EventHandler(this.mnuDemo2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(760, 505);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private Demo1Controls demo1;
		private Demo2Controls demo2;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			demo1 = new Demo1Controls();
			Controls.Add(demo1);
			demo1.Hide();

			demo2 = new Demo2Controls();
			Controls.Add(demo2);
			demo2.Hide();

		}

		private void mnuDemo1_Click(object sender, System.EventArgs e)
		{
			demo2.Hide();
			demo1.Show();
		}

		private void mnuDemo2_Click(object sender, System.EventArgs e)
		{
			demo1.Hide();
			demo2.Show();
		}



	}
}
