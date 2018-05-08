﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTTTA.DAO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace QLTTTA.GUI
{
   public partial class frmOracleConfig : Form
   {


      public frmOracleConfig()
      {
         InitializeComponent();
      }
      private void frmOracleConfig_Load(object sender, EventArgs e)
      {
         cbbHostname.Text = "localhost";
         cbbSid.Text = "test";
         cbbUser.Text = "rum123";
         tbPass.Text = "123";
      }

      private void frmOracleConfig_FormClosing(object sender, EventArgs e)
      {

      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void btnConnect_Click(object sender, EventArgs e)
      {
         DataProvider.Instance.setConnectionSTR(cbbHostname.Text, 1521, cbbSid.Text, cbbUser.Text, tbPass.Text);
         DataTable dt = null;
         dt = DataProvider.Instance.ExecuteQuery("Select table_name From all_tables where owner='" + cbbUser.Text.ToUpper() + "'");
         for (int i = 0; i < dt.Rows.Count; i++)
         {
            cbbTables.Items.Add(dt.Rows[i]["table_name"].ToString());
         }
         btnGoto.Enabled = true;

      }
      private void btnLoadData_Click(object sender, EventArgs e)
      {
         DataTable dt = null;
         dt = DataProvider.Instance.ExecuteQuery("select * from " + cbbTables.Text);
         gvLoadData.DataSource = dt;
      }

      private void btnGoto_Click(object sender, EventArgs e)
      {
         frmLogin frm = new frmLogin();
         frm.Show(this);
         this.Hide();
      }
   }
}
