using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
namespace QLNhanSu
{
    public partial class GUI_Nation : Form
    {
        public GUI_Nation()
        {
            InitializeComponent();
        }
        BUS_Nation na = new BUS_Nation();
        bool _them;
        int _id;

        private void GUI_Nation_Load(object sender, EventArgs e)
        {
           _them = false;
           na = new BUS_Nation();
            _ShowHide(true);
            LoadData();
        }
        void _ShowHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnthoat.Enabled = kt;
            txtTenDT.Enabled = kt;
        }
        void LoadData()
        {

            var data = na.getList();
            dgDantoc.AutoGenerateColumns = false;
            dgDantoc.DataSource = data;

            dgDantoc.Columns.Clear(); 

            dgDantoc.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ID", 
                HeaderText = "Ethnic ID",
                Name = "colEthnicID"
            });

            dgDantoc.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TenDT",
                HeaderText = "Ethnic Name",
                Name = "colEthnicName"
            });
            dgDantoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            _ShowHide(false);
            _them = true;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            _ShowHide(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            LoadData();
            _them = false;
            _ShowHide(true);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _them = false;
            _ShowHide(true);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_them)
            {
                Dantoc dt = new Dantoc();
                dt.TenDT = txtTenDT.Text;
                na.Add(dt);
            }
            else
            {
                var dt = na.getID(_id);
                dt.TenDT = txtTenDT.Text;
                na.Update(dt);
            }
        }

        private void dgDantoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dgDantoc.Rows[e.RowIndex].Cells["colEthnicID"].Value);
            txtTenDT.Text = dgDantoc.Rows[e.RowIndex].Cells["colEthnicName"].Value.ToString();
        }
    }
}
