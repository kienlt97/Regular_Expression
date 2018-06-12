using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
using System.Net;

namespace Ex_Regular_Expression
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// lấy tên sản phẩm
			txtPattern.Text = @"((\\I|i)\w+e) (\w+|((\w+|\d+ \w+) \w+)) \d{1,3}\w+B";
			// lấy giá
			txtPrice.Text = @"(\d{1,3}.\d{3}.\d{3}[₫])";
			//lấy màn hình
			txtScreen.Text = @"(\d{1}.\d{1}\W[,]) ((R|S)\w+(a|r)) (((R|r)\w+a)|(HD))";
			//lấy cam
			txtCam.Text = @"(((\d{0,1}) ((\w+)|(\d{0})) ([1-2][v-x](\d{1,2})|(\d{1,2}))|(((\w+)|(\d{0})) ([1-2][v-x](\d{1,2})|(\d{1,2})))) (\w+[,]) (\w+[:]) ((\d{0,1})|(\d{0,1}[.]\d{0,1})) (\w+))";
 			// lấy hệ điều hành
			txtHDH.Text = @"(i\w+S) \d{1,2}";
			// CPU
			txtCPU.Text = @"(((((A|a)\w+e) (A(\d{1,2}))) (((\w+) (\d{0,1}) (\w+) ((\d{1,2}[-]\w+)))|((\w+) (\d{0,1}) (\w+))))|((((A|a)\w+e) (A(\d{1,2}))) (((\d{0,1}) (\w+) ((\d{1,2}[-]\w+)))|((\w+) (\d{0,1})))))";
			// lấy RAM
			txtRam.Text = @"(\d{0,1}) (\w+[,]) (\w+[:]) (\d{2,3}) (\w+)";
			//lấy PIN
			txtPIN.Text = @"((1|2)(\d{1,3})) (((mAh[,]) (\w+[:]) (\d{0,1}) (\w+))|(mAh))";
			textBox1.Text = @"(\\C|c\w+s)/\d{1}.(p\w+g)";
 		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtFile.Text = openFileDialog1.FileName;
				txtContent.Text = File.ReadAllText(txtFile.Text);
 			}
		}
 		int i = 1;
		int dem = 0;
		List<string> lstname = new List<string>();
		List<string> lstprice = new List<string>();
		List<string> oldname = new List<string>();
 		List<Infomation> list = new List<Infomation>();
		string str = null;
 		private void btnSearch_Click(object sender, EventArgs e)
		{

			LoadHTML();
			lsvThongTin.Items.Clear();
			//Match matchpr = Regex.Match(txtContent.Text, txtPrice.Text);
			//Match match = Regex.Match(txtContent.Text, txtPattern.Text);
			//Match matchscr = Regex.Match(txtContent.Text, txtScreen.Text);
			//Match matchHDH = Regex.Match(txtContent.Text, txtHDH.Text);
			//Match matchRAM = Regex.Match(txtContent.Text, txtRam.Text);
			//Match matchPIN = Regex.Match(txtContent.Text, txtPIN.Text);
			//Match matchCAM = Regex.Match(txtContent.Text, txtCam.Text);
			//Match matchCPU = Regex.Match(txtContent.Text, txtCPU.Text);
			Match _match = Regex.Match(txtContent.Text, textBox1.Text);
			//	while (match.Groups[0].Value !="" || matchpr.Groups[0].Value != "" || matchscr.Groups[0].Value != "" || matchHDH.Groups[0].Value != ""
			//|| _match.Groups[0].Value != "" || matchCPU.Groups[0].Value != "" || matchRAM.Groups[0].Value != "" || matchPIN.Groups[0].Value != "" || matchCAM.Groups[0].Value != "")
			while(_match.Groups[0].Value != "")
			{
				ListViewItem item = new ListViewItem((i++).ToString());
				//item.SubItems.Add(_match.Groups[0].Value);
				//MessageBox.Show(_match.Groups[0].Value);
				str += _match.Groups[0].Value + " - ";
			//	item.SubItems.Add(match.Groups[0].Value);
			//item.SubItems.Add(matchpr.Groups[0].Value);
			//item.SubItems.Add(matchscr.Groups[0].Value);
			//item.SubItems.Add(matchHDH.Groups[0].Value);
			//	item.SubItems.Add(matchCPU.Groups[0].Value);
			//item.SubItems.Add(matchRAM.Groups[0].Value);
			//item.SubItems.Add(matchCAM.Groups[0].Value);
			//item.SubItems.Add(matchPIN.Groups[0].Value);
			//
				lsvThongTin.Items.Add(item);
 				
				//string Name = match.Groups[0].Value;
				//string Price = matchpr.Groups[0].Value;
				//string Screen = matchscr.Groups[0].Value;
				//string RAM = matchRAM.Groups[0].Value;
				//string CPU = matchCPU.Groups[0].Value;
				//string PIN = matchPIN.Groups[0].Value;
				//string HDH = matchHDH.Groups[0].Value;
				//string Camera = matchCAM.Groups[0].Value;
				//Infomation info  = new Infomation(Name, Price, Screen, RAM, CPU, PIN, HDH, Camera);
				//list.Add(info);


				//// hight ligth chuỗi tìm kiếm
				//match = match.NextMatch();
				//matchpr = matchpr.NextMatch();
				//matchscr = matchscr.NextMatch();
				//matchHDH = matchHDH.NextMatch();
				//matchRAM = matchRAM.NextMatch();
				//matchPIN = matchPIN.NextMatch();
				//matchCAM = matchCAM.NextMatch();
				//matchCPU = matchCPU.NextMatch();

				//txtContent.Select(match.Index, match.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchpr.Index, matchpr.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchscr.Index, matchscr.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchHDH.Index, matchHDH.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchRAM.Index, matchRAM.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchPIN.Index, matchPIN.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchCAM.Index, matchCAM.Length);
				//txtContent.SelectionColor = Color.Red;

				//txtContent.Select(matchCPU.Index, matchCPU.Length);
				//txtContent.SelectionColor = Color.Red;
				dem++;
			}
 			i = 1;
		}
		string Strcon = @"Data Source=DESKTOP-2NN1U31\SQLEXPRESS;Initial Catalog=Phone Information;Integrated Security=True";
		public SqlConnection conn = null;
		
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (conn == null) // kiểm tra có kết nối chưa..chưa kết nối thì sẽ khởi tạo kết nối
				conn = new SqlConnection(Strcon);
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "AddInfomation";
			cmd.Connection = conn;
			int ret = 0;
			foreach (Infomation info in list)
			{
					cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = info.Name;
					cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = info.Price;
					cmd.Parameters.Add("@Screen", SqlDbType.VarChar).Value = info.Screen;
					cmd.Parameters.Add("@HDH", SqlDbType.VarChar).Value = info.HDH;
					cmd.Parameters.Add("@CPU ", SqlDbType.VarChar).Value = info.CPU;
					cmd.Parameters.Add("@RAM ", SqlDbType.VarChar).Value = info.RAM;
					cmd.Parameters.Add("@Camera ", SqlDbType.VarChar).Value = info.Camera;
					cmd.Parameters.Add("@PIN ", SqlDbType.VarChar).Value = info.PIN;
					cmd.Parameters.Add("@SL", SqlDbType.Int).Value = dem;
					ret = cmd.ExecuteNonQuery();
					cmd.Parameters.Clear();

			}
			if (ret > 0)
				MessageBox.Show("Lưu vào database thành công !");
		}
		private void LoadHTML()
		{
			// WebClient object
			WebClient client = new WebClient();

			// Retrieve resource as a stream
			Stream data = client.OpenRead(new Uri(txtFile.Text));

			// Retrive the text
			StreamReader reader = new StreamReader(data);
			string htmlContent = reader.ReadToEnd();

			txtContent.Text = htmlContent;

			// Call function to process HTML Content
			//	processHTML(htmlContent);

			// Cleanup
			data.Close();
			reader.Close();
		}

	}
}
