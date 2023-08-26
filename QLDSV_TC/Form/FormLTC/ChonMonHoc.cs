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
    public partial class ChonMonHoc : Form
    {
        public ChonMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SV1);

        }

        private void ChonMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SV1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_SV1.MONHOC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maMH = ((DataRowView)mONHOCBindingSource.Current)["MAMH"].ToString();
            FormLTC.mamh = maMH;
            this.Close();
        }
    }
}
