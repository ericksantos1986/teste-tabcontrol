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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciaFormAba(Form frm)
        {
            int index = -1;

            for (int i = 0; i < tbApp.TabCount; i++)
            {
                if (tbApp.TabPages[i].Text.Trim() == frm.Text.Trim())
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                tbApp.SelectedIndex = index;
            }
            else
            {
                TabPage tabForm = new TabPage { Text = frm.Text};
                
                tbApp.TabPages.Add(tabForm);
                
                    
                frm.TopLevel = false;
                frm.Parent = tabForm;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();

                // Seleciona a Tab
                tbApp.SelectedIndex = tbApp.TabPages.Count - 1;                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Usuário: " + Environment.UserName;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaFormAba(new Form4());
        }

        public void closeTab()
        {
            if(tbApp.TabPages.Count == 0)
            {

            }
            else
            {   
                tbApp.SelectedTab.Dispose();
            }            
        }

        private void tbApp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbApp_DoubleClick(object sender, EventArgs e)
        {
            closeTab();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaFormAba(new Form2());
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaFormAba(new Form3());
        }

        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
