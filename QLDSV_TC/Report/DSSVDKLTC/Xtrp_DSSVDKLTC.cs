﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC
{
    public partial class Xtrp_DSSVDKLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_DSSVDKLTC(string nienkhoa, int hocky, int nhom, string monhoc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = monhoc;
            this.sqlDataSource1.Fill();
        }

    }
}
