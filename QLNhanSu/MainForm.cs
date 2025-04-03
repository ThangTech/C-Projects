using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDantoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Nation na = new GUI_Nation();
            na.Show();
        }

        private void btnTongiao_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_Religion re = new GUI_Religion();
            re.Show();
        }
    }
}
