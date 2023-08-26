using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class XtraReport_DiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DiemTongKet(string maLop)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maLop;
        }
        public XtraReport_DiemTongKet()
        {
            InitializeComponent();
        }

    }
}
