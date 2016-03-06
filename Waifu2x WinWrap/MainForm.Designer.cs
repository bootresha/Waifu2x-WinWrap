/*
 * Created by SharpDevelop.
 * User: DVDLesher
 * Date: 06/03/2016
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Waifu2x_WinWrap
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.Label labelInput;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.Button buttonVersion;
		private System.Windows.Forms.Button buttonStartProcess;
		private System.Windows.Forms.Button buttonInput;
		private System.Windows.Forms.Button buttonOutput;
		private System.Windows.Forms.Label labelDescNoiseReduc;
		private System.Windows.Forms.CheckBox checkBoxNoiseReduc;
		private System.Windows.Forms.ComboBox comboBoxMode;
		private System.Windows.Forms.CheckBox checkBoxThread;
		private System.Windows.Forms.ComboBox comboBoxNoiseReduc;
		private System.Windows.Forms.ComboBox comboBoxThreadCount;
		private System.Windows.Forms.Label labelInputVal;
		private System.Windows.Forms.Label labelOutputVal;
		private System.Windows.Forms.CheckBox checkBoxOutputOpt;
		private System.Windows.Forms.Label labelEtc1;
		private System.Windows.Forms.Button buttonWaifu2xLoc;
		private System.Windows.Forms.Label labelWaifu2xLoc;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelMode = new System.Windows.Forms.Label();
			this.labelInput = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.buttonVersion = new System.Windows.Forms.Button();
			this.buttonStartProcess = new System.Windows.Forms.Button();
			this.buttonInput = new System.Windows.Forms.Button();
			this.buttonOutput = new System.Windows.Forms.Button();
			this.labelDescNoiseReduc = new System.Windows.Forms.Label();
			this.checkBoxNoiseReduc = new System.Windows.Forms.CheckBox();
			this.comboBoxMode = new System.Windows.Forms.ComboBox();
			this.checkBoxThread = new System.Windows.Forms.CheckBox();
			this.comboBoxNoiseReduc = new System.Windows.Forms.ComboBox();
			this.comboBoxThreadCount = new System.Windows.Forms.ComboBox();
			this.labelInputVal = new System.Windows.Forms.Label();
			this.labelOutputVal = new System.Windows.Forms.Label();
			this.checkBoxOutputOpt = new System.Windows.Forms.CheckBox();
			this.labelEtc1 = new System.Windows.Forms.Label();
			this.buttonWaifu2xLoc = new System.Windows.Forms.Button();
			this.labelWaifu2xLoc = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// labelMode
			// 
			this.labelMode.Location = new System.Drawing.Point(12, 9);
			this.labelMode.Name = "labelMode";
			this.labelMode.Size = new System.Drawing.Size(100, 23);
			this.labelMode.TabIndex = 3;
			this.labelMode.Text = "Choose Mode";
			// 
			// labelInput
			// 
			this.labelInput.Location = new System.Drawing.Point(12, 140);
			this.labelInput.Name = "labelInput";
			this.labelInput.Size = new System.Drawing.Size(100, 23);
			this.labelInput.TabIndex = 4;
			this.labelInput.Text = "Input Files: ";
			// 
			// labelOutput
			// 
			this.labelOutput.Location = new System.Drawing.Point(297, 140);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(177, 23);
			this.labelOutput.TabIndex = 5;
			this.labelOutput.Text = "Output Location:";
			// 
			// buttonVersion
			// 
			this.buttonVersion.Location = new System.Drawing.Point(500, 205);
			this.buttonVersion.Name = "buttonVersion";
			this.buttonVersion.Size = new System.Drawing.Size(85, 23);
			this.buttonVersion.TabIndex = 6;
			this.buttonVersion.Text = "Show Version";
			this.buttonVersion.UseVisualStyleBackColor = true;
			// 
			// buttonStartProcess
			// 
			this.buttonStartProcess.Enabled = false;
			this.buttonStartProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStartProcess.Location = new System.Drawing.Point(12, 185);
			this.buttonStartProcess.Name = "buttonStartProcess";
			this.buttonStartProcess.Size = new System.Drawing.Size(177, 33);
			this.buttonStartProcess.TabIndex = 7;
			this.buttonStartProcess.Text = "Start Process";
			this.buttonStartProcess.UseVisualStyleBackColor = true;
			// 
			// buttonInput
			// 
			this.buttonInput.Location = new System.Drawing.Point(12, 156);
			this.buttonInput.Name = "buttonInput";
			this.buttonInput.Size = new System.Drawing.Size(177, 23);
			this.buttonInput.TabIndex = 8;
			this.buttonInput.Text = "Input";
			this.buttonInput.UseVisualStyleBackColor = true;
			this.buttonInput.Click += new System.EventHandler(this.ButtonInputClick);
			// 
			// buttonOutput
			// 
			this.buttonOutput.Location = new System.Drawing.Point(297, 156);
			this.buttonOutput.Name = "buttonOutput";
			this.buttonOutput.Size = new System.Drawing.Size(177, 23);
			this.buttonOutput.TabIndex = 9;
			this.buttonOutput.Text = "Output";
			this.buttonOutput.UseVisualStyleBackColor = true;
			this.buttonOutput.Click += new System.EventHandler(this.ButtonOutputClick);
			// 
			// labelDescNoiseReduc
			// 
			this.labelDescNoiseReduc.Location = new System.Drawing.Point(230, 71);
			this.labelDescNoiseReduc.Name = "labelDescNoiseReduc";
			this.labelDescNoiseReduc.Size = new System.Drawing.Size(317, 19);
			this.labelDescNoiseReduc.TabIndex = 12;
			this.labelDescNoiseReduc.Text = "If enabled, choose 1 (lower reduction) or 2 (higher reduction)";
			// 
			// checkBoxNoiseReduc
			// 
			this.checkBoxNoiseReduc.Location = new System.Drawing.Point(12, 66);
			this.checkBoxNoiseReduc.Name = "checkBoxNoiseReduc";
			this.checkBoxNoiseReduc.Size = new System.Drawing.Size(111, 24);
			this.checkBoxNoiseReduc.TabIndex = 13;
			this.checkBoxNoiseReduc.Text = "Noise Reduction";
			this.checkBoxNoiseReduc.UseVisualStyleBackColor = true;
			this.checkBoxNoiseReduc.CheckedChanged += new System.EventHandler(this.CheckBoxNoiseReducCheckedChanged);
			// 
			// comboBoxMode
			// 
			this.comboBoxMode.FormattingEnabled = true;
			this.comboBoxMode.Location = new System.Drawing.Point(129, 9);
			this.comboBoxMode.Name = "comboBoxMode";
			this.comboBoxMode.Size = new System.Drawing.Size(95, 21);
			this.comboBoxMode.TabIndex = 14;
			this.comboBoxMode.Text = "Scale";
			// 
			// checkBoxThread
			// 
			this.checkBoxThread.Location = new System.Drawing.Point(12, 38);
			this.checkBoxThread.Name = "checkBoxThread";
			this.checkBoxThread.Size = new System.Drawing.Size(104, 24);
			this.checkBoxThread.TabIndex = 17;
			this.checkBoxThread.Text = "Thread Count";
			this.checkBoxThread.UseVisualStyleBackColor = true;
			this.checkBoxThread.CheckedChanged += new System.EventHandler(this.CheckBoxThreadCheckedChanged);
			// 
			// comboBoxNoiseReduc
			// 
			this.comboBoxNoiseReduc.Enabled = false;
			this.comboBoxNoiseReduc.FormattingEnabled = true;
			this.comboBoxNoiseReduc.Location = new System.Drawing.Point(129, 68);
			this.comboBoxNoiseReduc.Name = "comboBoxNoiseReduc";
			this.comboBoxNoiseReduc.Size = new System.Drawing.Size(95, 21);
			this.comboBoxNoiseReduc.TabIndex = 18;
			this.comboBoxNoiseReduc.Text = "2";
			// 
			// comboBoxThreadCount
			// 
			this.comboBoxThreadCount.Enabled = false;
			this.comboBoxThreadCount.FormattingEnabled = true;
			this.comboBoxThreadCount.Location = new System.Drawing.Point(129, 39);
			this.comboBoxThreadCount.Name = "comboBoxThreadCount";
			this.comboBoxThreadCount.Size = new System.Drawing.Size(95, 21);
			this.comboBoxThreadCount.TabIndex = 19;
			this.comboBoxThreadCount.Text = "4";
			// 
			// labelInputVal
			// 
			this.labelInputVal.Location = new System.Drawing.Point(65, 140);
			this.labelInputVal.Name = "labelInputVal";
			this.labelInputVal.Size = new System.Drawing.Size(100, 23);
			this.labelInputVal.TabIndex = 20;
			this.labelInputVal.Text = "0";
			// 
			// labelOutputVal
			// 
			this.labelOutputVal.Location = new System.Drawing.Point(378, 140);
			this.labelOutputVal.Name = "labelOutputVal";
			this.labelOutputVal.Size = new System.Drawing.Size(100, 23);
			this.labelOutputVal.TabIndex = 21;
			this.labelOutputVal.Text = "Not Set";
			// 
			// checkBoxOutputOpt
			// 
			this.checkBoxOutputOpt.Location = new System.Drawing.Point(481, 156);
			this.checkBoxOutputOpt.Name = "checkBoxOutputOpt";
			this.checkBoxOutputOpt.Size = new System.Drawing.Size(104, 24);
			this.checkBoxOutputOpt.TabIndex = 22;
			this.checkBoxOutputOpt.Text = "CustomName?";
			this.checkBoxOutputOpt.UseVisualStyleBackColor = true;
			// 
			// labelEtc1
			// 
			this.labelEtc1.Location = new System.Drawing.Point(12, 93);
			this.labelEtc1.Name = "labelEtc1";
			this.labelEtc1.Size = new System.Drawing.Size(143, 23);
			this.labelEtc1.TabIndex = 23;
			this.labelEtc1.Text = "Waifu2x.exe Location: ";
			// 
			// buttonWaifu2xLoc
			// 
			this.buttonWaifu2xLoc.Location = new System.Drawing.Point(12, 109);
			this.buttonWaifu2xLoc.Name = "buttonWaifu2xLoc";
			this.buttonWaifu2xLoc.Size = new System.Drawing.Size(177, 23);
			this.buttonWaifu2xLoc.TabIndex = 24;
			this.buttonWaifu2xLoc.Text = "Find Waifu2x.exe";
			this.buttonWaifu2xLoc.UseVisualStyleBackColor = true;
			// 
			// labelWaifu2xLoc
			// 
			this.labelWaifu2xLoc.Location = new System.Drawing.Point(129, 93);
			this.labelWaifu2xLoc.Name = "labelWaifu2xLoc";
			this.labelWaifu2xLoc.Size = new System.Drawing.Size(100, 23);
			this.labelWaifu2xLoc.TabIndex = 25;
			this.labelWaifu2xLoc.Text = "Not Found";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 230);
			this.Controls.Add(this.buttonWaifu2xLoc);
			this.Controls.Add(this.labelWaifu2xLoc);
			this.Controls.Add(this.labelEtc1);
			this.Controls.Add(this.checkBoxOutputOpt);
			this.Controls.Add(this.buttonOutput);
			this.Controls.Add(this.labelOutputVal);
			this.Controls.Add(this.buttonInput);
			this.Controls.Add(this.labelInputVal);
			this.Controls.Add(this.comboBoxThreadCount);
			this.Controls.Add(this.comboBoxNoiseReduc);
			this.Controls.Add(this.checkBoxThread);
			this.Controls.Add(this.comboBoxMode);
			this.Controls.Add(this.checkBoxNoiseReduc);
			this.Controls.Add(this.labelDescNoiseReduc);
			this.Controls.Add(this.buttonStartProcess);
			this.Controls.Add(this.buttonVersion);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.labelInput);
			this.Controls.Add(this.labelMode);
			this.Name = "MainForm";
			this.Text = "Waifu2x WinWrap";
			this.ResumeLayout(false);

		}
	}
}
