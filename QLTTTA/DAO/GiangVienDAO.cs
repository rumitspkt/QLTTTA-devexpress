using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using QLTTTA.DTO;
namespace QLTTTA.DAO
{
   public class GiangVienDAO
   {
      private static GiangVienDAO instance;

      public static GiangVienDAO Instance
      {
         get { if (instance == null) instance = new GiangVienDAO(); return instance; }
         private set { instance = value; }
      }
      public GiangVienDAO() { }
      public bool them(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaGV", OracleDbType.Int32),
                new OracleParameter("v_TenGV", OracleDbType.Varchar2),
                new OracleParameter("v_NgaySinh", OracleDbType. Date),
                new OracleParameter("v_ThamNien", OracleDbType.Int32),
                new OracleParameter("v_HocVi", OracleDbType.Varchar2),
                new OracleParameter("v_Luong", OracleDbType.Int32),
                new OracleParameter("v_Mail", OracleDbType.Varchar2)};
            Object[] parameters = {maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail};
            DataProvider.Instance.ExecuteNonQuery("ThemGiangVien", oracleParams, parameters);
            return true;
         }
         
         catch
         {
            return false;
         }
      }
      public bool capNhat(int maGV, string tenGV, DateTime ngaySinh, int thamNien, string hocVi, int luong, string mail)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaGV", OracleDbType.Int32),
                new OracleParameter("v_TenGV", OracleDbType.Varchar2),
                new OracleParameter("v_NgaySinh", OracleDbType. Date),
                new OracleParameter("v_ThamNien", OracleDbType.Int32),
                new OracleParameter("v_HocVi", OracleDbType.Varchar2),
                new OracleParameter("v_Luong", OracleDbType.Int32),
                new OracleParameter("v_Mail", OracleDbType.Varchar2)};
            Object[] parameters = { maGV, tenGV, ngaySinh, thamNien, hocVi, luong, mail };
            DataProvider.Instance.ExecuteNonQuery("CapNhatGiangVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(int maGV)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaGV", OracleDbType.Int32) };
            Object[] parameters = { maGV };
            DataProvider.Instance.ExecuteNonQuery("XoaGiangVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }

      public DataTable getListGiangVien()
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadgiangvien"));
      }
      public DataTable getGiangVien(string mail)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from giangvien where mail = '{0}'", mail));
      }
      public DataTable getGiangVien(int maGV)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from giangvien where maGV = {0}", maGV.ToString()));
      }
   }
}
