﻿namespace Mastermind
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(355, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "*";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.GreenYellow;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(355, 256);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Highlight;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.Location = new System.Drawing.Point(401, 210);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.SandyBrown;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button4.Location = new System.Drawing.Point(401, 256);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(374, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Wybierz";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DarkGreen;
			this.button5.Location = new System.Drawing.Point(10, 29);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 5;
			this.button5.Text = "?";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DarkGreen;
			this.button6.Location = new System.Drawing.Point(55, 29);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 6;
			this.button6.Text = "?";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.DarkGreen;
			this.button7.Location = new System.Drawing.Point(100, 29);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 7;
			this.button7.Text = "?";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.DarkGreen;
			this.button8.Location = new System.Drawing.Point(145, 29);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 8;
			this.button8.Text = "?";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(355, 405);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(86, 118);
			this.button9.TabIndex = 9;
			this.button9.Text = "Sprawdź";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 558);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Mastermind";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
	}
}

