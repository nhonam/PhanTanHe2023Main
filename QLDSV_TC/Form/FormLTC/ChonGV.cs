using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class ChonGV : Form
    {
        public ChonGV()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIANGVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void ChonGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV1.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.dS_SV1.GIANGVIEN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maGV = ((DataRowView)gIANGVIENBindingSource.Current)["MAGV"].ToString();


            /*Cach nay phai tuy bien ban moi chay duoc*/
            //Program.formDonDatHang.txtMaKho.Text = maKhoHang;
            FormLTC.magv = maGV;
            this.Close();
        }
    }
}
