using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Tab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
           
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }
    }
}
