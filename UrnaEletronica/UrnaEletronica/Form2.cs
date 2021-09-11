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
	public partial class Form2 : Form
	{
		private Thread nt;

		public Form2()
		{
			InitializeComponent();
		}

		private void btn_ConfirmarVer_Click(object sender, EventArgs e)
		{
			this.Close();
			nt = new Thread(newForm);
			nt.SetApartmentState(ApartmentState.STA);
			nt.Start();
		}

		private void newForm()
		{
			Application.Run(new Form3());
		}
	}
}
