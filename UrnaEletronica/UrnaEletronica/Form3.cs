using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		public Form3(string texto) : this()
		{
			InitializeComponent();
			//MessageBox.Show(texto);
			label3.Text = texto;
		}


	}
}
