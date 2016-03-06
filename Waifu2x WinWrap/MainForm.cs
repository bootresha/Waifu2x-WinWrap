/*
 * Created by SharpDevelop.
 * User: DVDLesher
 * Date: 06/03/2016
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Waifu2x_WinWrap
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CheckBoxThreadCheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxThread.Checked) {
				comboBoxThreadCount.Enabled = true;
			} else {
				comboBoxThreadCount.Enabled = false;
			}
		}
		void CheckBoxNoiseReducCheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxNoiseReduc.Checked) {
				comboBoxNoiseReduc.Enabled = true;
			} else {
				comboBoxNoiseReduc.Enabled = false;
			}
		}
		void TextBoxScaleTextChanged(object sender, EventArgs e)
		{
			//Enable Start Process button when everything else is good
		}
		void ButtonInputClick(object sender, EventArgs e)
		{
			//Create filedialog
			//Enable Start Process button when everything else is good
	
		}
		void ButtonOutputClick(object sender, EventArgs e)
		{
			//Create folderdialog
			//Enable Start Process button when everything else is good
		}
	}
}
