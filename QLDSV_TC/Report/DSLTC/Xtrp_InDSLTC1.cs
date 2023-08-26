using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xtrp_InDSLTC1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_InDSLTC1(string nienkhoa, int hocky)
        {
            InitializeComponent();
       
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();
        }

    }
}
