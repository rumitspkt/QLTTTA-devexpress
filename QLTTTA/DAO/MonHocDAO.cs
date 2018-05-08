using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTTTA.DTO;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace QLTTTA.DAO
{
   public class MonHocDAO
   {
      private static MonHocDAO instance;

      public static MonHocDAO Instance
      {
         get { if (instance == null) instance = new MonHocDAO(); return instance; }
         private set { instance = value; }
      }
      public MonHocDAO() { }
      public bool them(int maMH, string tenMH, int soGioHoc)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaMH", OracleDbType.Int32),
                new OracleParameter("v_TenMH", OracleDbType.Varchar2),
                new OracleParameter("v_SoGioHoc", OracleDbType.Int32) };
            Object[] parameters = {maMH, tenMH, soGioHoc};
            DataProvider.Instance.ExecuteNonQuery("ThemMonHoc", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool capNhat(int maMH, string tenMH, int soGioHoc)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaMH", OracleDbType.Int32),
                new OracleParameter("v_TenMH", OracleDbType.Varchar2),
                new OracleParameter("v_SoGioHoc", OracleDbType.Int32) };
                //new OracleParameter("v_SoTien", OracleDbType.Int32)};
            Object[] parameters = { maMH, tenMH, soGioHoc};
            DataProvider.Instance.ExecuteNonQuery("CAPNHATMONHOC", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(int maMH)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaMH", OracleDbType.Int32) };
            Object[] parameters = { maMH };
            DataProvider.Instance.ExecuteNonQuery("XOAMONHOC", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }

      public DataTable getListMonHoc()
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadmonhoc"));
      }
      public DataTable getMonHoc(int maMH)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from monhoc where maMH = {0}", maMH));
         
      }
      
   }
}
