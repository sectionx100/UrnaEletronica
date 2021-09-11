
namespace UrnaEletronica
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pref_20 = new System.Windows.Forms.RadioButton();
			this.pref_14 = new System.Windows.Forms.RadioButton();
			this.btn_ConfirmarVer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(295, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "Vote no Prefeito";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(435, 107);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(151, 106);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(471, 239);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(86, 132);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 12;
			this.pictureBox3.TabStop = false;
			// 
			// pref_20
			// 
			this.pref_20.AutoSize = true;
			this.pref_20.Location = new System.Drawing.Point(263, 302);
			this.pref_20.Name = "pref_20";
			this.pref_20.Size = new System.Drawing.Size(116, 17);
			this.pref_20.TabIndex = 11;
			this.pref_20.TabStop = true;
			this.pref_20.Text = "20 - Pedro Petróleo";
			this.pref_20.UseVisualStyleBackColor = true;
			// 
			// pref_14
			// 
			this.pref_14.AutoSize = true;
			this.pref_14.Location = new System.Drawing.Point(263, 156);
			this.pref_14.Name = "pref_14";
			this.pref_14.Size = new System.Drawing.Size(111, 17);
			this.pref_14.TabIndex = 10;
			this.pref_14.TabStop = true;
			this.pref_14.Text = "14 - Graziela Beira";
			this.pref_14.UseVisualStyleBackColor = true;
			// 
			// btn_ConfirmarVer
			// 
			this.btn_ConfirmarVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ConfirmarVer.Location = new System.Drawing.Point(692, 411);
			this.btn_ConfirmarVer.Name = "btn_ConfirmarVer";
			this.btn_ConfirmarVer.Size = new System.Drawing.Size(96, 27);
			this.btn_ConfirmarVer.TabIndex = 14;
			this.btn_ConfirmarVer.Text = "Confirmar";
			this.btn_ConfirmarVer.UseVisualStyleBackColor = true;
			this.btn_ConfirmarVer.Click += new System.EventHandler(this.btn_ConfirmarVer_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_ConfirmarVer);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pref_20);
			this.Controls.Add(this.pref_14);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Prefeito";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.RadioButton pref_20;
		private System.Windows.Forms.RadioButton pref_14;
		private System.Windows.Forms.Button btn_ConfirmarVer;
	}
}