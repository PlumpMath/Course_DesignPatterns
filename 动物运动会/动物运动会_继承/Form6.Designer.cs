﻿namespace 动物运动会
{
	partial class Form6
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
			this.btnShout = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShout
			// 
			this.btnShout.Location = new System.Drawing.Point(108, 43);
			this.btnShout.Name = "btnShout";
			this.btnShout.Size = new System.Drawing.Size(75, 23);
			this.btnShout.TabIndex = 3;
			this.btnShout.Text = "猫叫";
			this.btnShout.UseVisualStyleBackColor = true;
			this.btnShout.Click += new System.EventHandler(this.btnShout_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "狗叫";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnShout);
			this.Name = "Form6";
			this.Text = "Form6";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShout;
		private System.Windows.Forms.Button button1;
	}
}