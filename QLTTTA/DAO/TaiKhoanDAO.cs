﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.DTO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace QLTTTA.DAO
{
   public class TaiKhoanDAO
   {
      private static TaiKhoanDAO instance;

      public static TaiKhoanDAO Instance
      {
         get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
         private set { instance = value; }
      }

      private TaiKhoanDAO() { }

      public bool dangNhap(string mail, string matKhau, string quyenDangNhap)
      {
         string query = string.Format("select * from dangnhap where mail = '{0}' and matkhau = '{1}' and quyendangnhap = '{2}'", mail, matKhau, quyenDangNhap);
         DataTable table = DataProvider.Instance.ExecuteQuery(query); 
         return table.Rows.Count > 0;
      }

      public bool them(string mail, string matKhau, string quyenDangNhap)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_Mail", OracleDbType.Varchar2),
                new OracleParameter("v_MatKhau", OracleDbType.Varchar2),
                new OracleParameter("v_QuyenDangNhap", OracleDbType.Varchar2) };
            Object[] parameters = { mail, matKhau, quyenDangNhap};
            DataProvider.Instance.ExecuteNonQuery("ThemDangNhap", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool capNhat(string mail, string matKhau, string quyenDangNhap)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_Mail", OracleDbType.Varchar2),
                new OracleParameter("v_MatKhau", OracleDbType.Varchar2),
                new OracleParameter("v_QuyenDangNhap", OracleDbType.Varchar2) };
            Object[] parameters = { mail, matKhau, quyenDangNhap };
            DataProvider.Instance.ExecuteNonQuery("CapNhatDangNhap", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(string mail)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_Mail", OracleDbType.Varchar2) };
            Object[] parameters = { mail};
            DataProvider.Instance.ExecuteNonQuery("XoaDangNhap", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }

      public DataTable getTaiKhoan(string mail)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from dangnhap where mail = '{0}'", mail));
         
      } 

      public DataTable getListTaiKhoan()
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from loaddangnhap"));
      }
   }
}
