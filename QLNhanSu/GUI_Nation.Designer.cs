
namespace QLNhanSu
{
    partial class GUI_Nation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Nation));
            this.gpDantoc = new System.Windows.Forms.GroupBox();
            this.btnthoat = new Syncfusion.WinForms.Controls.SfButton();
            this.btnHuy = new Syncfusion.WinForms.Controls.SfButton();
            this.btnLuu = new Syncfusion.WinForms.Controls.SfButton();
            this.btnXoa = new Syncfusion.WinForms.Controls.SfButton();
            this.btnSua = new Syncfusion.WinForms.Controls.SfButton();
            this.btnThem = new Syncfusion.WinForms.Controls.SfButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.dgDantoc = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpDantoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDantoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gpDantoc
            // 
            this.gpDantoc.AutoSize = true;
            this.gpDantoc.Controls.Add(this.btnthoat);
            this.gpDantoc.Controls.Add(this.btnHuy);
            this.gpDantoc.Controls.Add(this.btnLuu);
            this.gpDantoc.Controls.Add(this.btnXoa);
            this.gpDantoc.Controls.Add(this.btnSua);
            this.gpDantoc.Controls.Add(this.btnThem);
            this.gpDantoc.Location = new System.Drawing.Point(0, 2);
            this.gpDantoc.Name = "gpDantoc";
            this.gpDantoc.Size = new System.Drawing.Size(896, 96);
            this.gpDantoc.TabIndex = 0;
            this.gpDantoc.TabStop = false;
            this.gpDantoc.Text = "Function";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Snow;
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnthoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnthoat.Location = new System.Drawing.Point(776, 39);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 28);
            this.btnthoat.Style.BackColor = System.Drawing.Color.Snow;
            this.btnthoat.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Exit";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Snow;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(644, 39);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 28);
            this.btnHuy.Style.BackColor = System.Drawing.Color.Snow;
            this.btnHuy.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Snow;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(493, 39);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 28);
            this.btnLuu.Style.BackColor = System.Drawing.Color.Snow;
            this.btnLuu.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Save";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Snow;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(328, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 28);
            this.btnXoa.Style.BackColor = System.Drawing.Color.Snow;
            this.btnXoa.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Snow;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(163, 39);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 28);
            this.btnSua.Style.BackColor = System.Drawing.Color.Snow;
            this.btnSua.Style.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Snow;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(22, 39);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 28);
            this.btnThem.Style.BackColor = System.Drawing.Color.Snow;
            this.btnThem.Style.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Insert";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 104);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTenDT);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDantoc);
            this.splitContainer1.Size = new System.Drawing.Size(896, 460);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ethnic Name:";
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(304, 42);
            this.txtTenDT.Multiline = true;
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(285, 26);
            this.txtTenDT.TabIndex = 1;
            // 
            // dgDantoc
            // 
            this.dgDantoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDantoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgName});
            this.dgDantoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDantoc.Location = new System.Drawing.Point(0, 0);
            this.dgDantoc.Name = "dgDantoc";
            this.dgDantoc.RowHeadersWidth = 51;
            this.dgDantoc.RowTemplate.Height = 24;
            this.dgDantoc.Size = new System.Drawing.Size(896, 328);
            this.dgDantoc.TabIndex = 0;
            this.dgDantoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDantoc_CellClick);
            // 
            // dgID
            // 
            this.dgID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgID.HeaderText = "Nation ID";
            this.dgID.MinimumWidth = 6;
            this.dgID.Name = "dgID";
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.HeaderText = "Nation Name";
            this.dgName.MinimumWidth = 6;
            this.dgName.Name = "dgName";
            // 
            // GUI_Nation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 569);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gpDantoc);
            this.Name = "GUI_Nation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nation";
            this.Load += new System.EventHandler(this.GUI_Nation_Load);
            this.gpDantoc.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDantoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDantoc;
        private Syncfusion.WinForms.Controls.SfButton btnthoat;
        private Syncfusion.WinForms.Controls.SfButton btnHuy;
        private Syncfusion.WinForms.Controls.SfButton btnLuu;
        private Syncfusion.WinForms.Controls.SfButton btnXoa;
        private Syncfusion.WinForms.Controls.SfButton btnSua;
        private Syncfusion.WinForms.Controls.SfButton btnThem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDantoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
    }
}