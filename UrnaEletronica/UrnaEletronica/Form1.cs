using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
	public partial class Form1 : Form
	{
		private Thread nt;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_ConfirmarVer_Click(object sender, EventArgs e)
		{
			if (ver14001.Checked == true)
			{
				var form3 = new Form3(ver14001.Text);
				//form3.Show();
				
			}
			this.Close();
			nt = new Thread(newForm);
			nt.SetApartmentState(ApartmentState.STA);
			nt.Start();
			
		}

		private void newForm()
		{
			Application.Run(new Form2());
		}

		private void ver14001_CheckedChanged(object sender, EventArgs e)
		{
			//var vereador = "14001 - Juninho do Ovo";
			//new Form3(vereador);
			
		}

		private void ver20001_CheckedChanged(object sender, EventArgs e)
		{
			var vereador = "20001 - Claudinho Mecânico";
		}

		private void ver14002_CheckedChanged(object sender, EventArgs e)
		{
			var vereador = "14002 - Janaina Padeira";
		}

		private void ver20002_CheckedChanged(object sender, EventArgs e)
		{
			var vereador = "20002 - Marília do Samba";
		}
	}
}
