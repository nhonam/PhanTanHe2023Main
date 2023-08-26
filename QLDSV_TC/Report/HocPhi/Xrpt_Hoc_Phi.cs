using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xrpt_Hoc_Phi : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_Hoc_Phi(string malop, string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
        }
        public Xrpt_Hoc_Phi()
        {
            InitializeComponent();
        }

    }
}
