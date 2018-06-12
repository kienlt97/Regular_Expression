namespace Ex_Regular_Expression
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
			this.txtPattern = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.txtContent = new System.Windows.Forms.RichTextBox();
			this.lsvThongTin = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtScreen = new System.Windows.Forms.TextBox();
			this.txtHDH = new System.Windows.Forms.TextBox();
			this.txtRam = new System.Windows.Forms.TextBox();
			this.txtPIN = new System.Windows.Forms.TextBox();
			this.txtCam = new System.Windows.Forms.TextBox();
			this.txtCPU = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtPattern
			// 
			this.txtPattern.Location = new System.Drawing.Point(32, 6);
			this.txtPattern.Name = "txtPattern";
			this.txtPattern.Size = new System.Drawing.Size(217, 20);
			this.txtPattern.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(312, 32);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(32, 106);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 5;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// txtFile
			// 
			this.txtFile.Location = new System.Drawing.Point(147, 109);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(217, 20);
			this.txtFile.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(32, 135);
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(566, 202);
			this.txtContent.TabIndex = 7;
			this.txtContent.Text = "";
			// 
			// lsvThongTin
			// 
			this.lsvThongTin.AllowColumnReorder = true;
			this.lsvThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.lsvThongTin.FullRowSelect = true;
			this.lsvThongTin.GridLines = true;
			this.lsvThongTin.HideSelection = false;
			this.lsvThongTin.Location = new System.Drawing.Point(2, 343);
			this.lsvThongTin.Name = "lsvThongTin";
			this.lsvThongTin.Size = new System.Drawing.Size(1098, 169);
			this.lsvThongTin.TabIndex = 9;
			this.lsvThongTin.UseCompatibleStateImageBehavior = false;
			this.lsvThongTin.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 50;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên Sản Phẩm";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Giá";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Màn Hình";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 200;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "HDH";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "CPU";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 150;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "RAM";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 150;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Camera";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 100;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "PIN";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 100;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Image";
			this.columnHeader10.Width = 100;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(32, 32);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(217, 20);
			this.txtPrice.TabIndex = 10;
			// 
			// txtScreen
			// 
			this.txtScreen.Location = new System.Drawing.Point(32, 58);
			this.txtScreen.Name = "txtScreen";
			this.txtScreen.Size = new System.Drawing.Size(217, 20);
			this.txtScreen.TabIndex = 11;
			// 
			// txtHDH
			// 
			this.txtHDH.Location = new System.Drawing.Point(32, 80);
			this.txtHDH.Name = "txtHDH";
			this.txtHDH.Size = new System.Drawing.Size(217, 20);
			this.txtHDH.TabIndex = 12;
			// 
			// txtRam
			// 
			this.txtRam.Location = new System.Drawing.Point(439, 6);
			this.txtRam.Name = "txtRam";
			this.txtRam.Size = new System.Drawing.Size(217, 20);
			this.txtRam.TabIndex = 13;
			// 
			// txtPIN
			// 
			this.txtPIN.Location = new System.Drawing.Point(439, 80);
			this.txtPIN.Name = "txtPIN";
			this.txtPIN.Size = new System.Drawing.Size(217, 20);
			this.txtPIN.TabIndex = 14;
			// 
			// txtCam
			// 
			this.txtCam.Location = new System.Drawing.Point(439, 35);
			this.txtCam.Name = "txtCam";
			this.txtCam.Size = new System.Drawing.Size(217, 20);
			this.txtCam.TabIndex = 15;
			// 
			// txtCPU
			// 
			this.txtCPU.Location = new System.Drawing.Point(439, 58);
			this.txtCPU.Name = "txtCPU";
			this.txtCPU.Size = new System.Drawing.Size(217, 20);
			this.txtCPU.TabIndex = 16;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(642, 314);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(93, 23);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(439, 108);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(217, 20);
			this.textBox1.TabIndex = 18;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(631, 175);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(217, 20);
			this.textBox2.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1108, 514);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtCPU);
			this.Controls.Add(this.txtCam);
			this.Controls.Add(this.txtPIN);
			this.Controls.Add(this.txtRam);
			this.Controls.Add(this.txtHDH);
			this.Controls.Add(this.txtScreen);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.lsvThongTin);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtPattern);
			this.Name = "Form1";
			this.Text = "Regular Expression";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPattern;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.RichTextBox txtContent;
		private System.Windows.Forms.ListView lsvThongTin;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox txtScreen;
		private System.Windows.Forms.TextBox txtHDH;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.TextBox txtRam;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.TextBox txtPIN;
		private System.Windows.Forms.TextBox txtCam;
		private System.Windows.Forms.TextBox txtCPU;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox textBox2;
	}
}

