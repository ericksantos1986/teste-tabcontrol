using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Tab
{
    static class Teste
    {
        static Form1 frm = (Form1)Application.OpenForms["Form1"];
        

        static public void altStatus(string status)
        {
            frm.toolStripStatusLabel1.Text = "";
            frm.toolStripStatusLabel1.Text = status;           
        }
    }
}
