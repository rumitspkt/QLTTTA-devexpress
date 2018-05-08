using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using QLTTTA.DTO;
namespace QLTTTA.DAO
{
   public class NhanVienDAO
   {
      private static NhanVienDAO instance;

      public static NhanVienDAO Instance
      {
         get { if (instance == null) instance = new NhanVienDAO(); return instance; }
         private set { instance = value; }
      }
      public NhanVienDAO() { }
      public bool them(int maNV, string tenNV, DateTime? ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaNV", OracleDbType.Int32),
                new OracleParameter("v_TenNV", OracleDbType.Varchar2),
                new OracleParameter("v_NgaySinh", OracleDbType. Date),
                new OracleParameter("v_GioiTinh", OracleDbType.Varchar2),
                new OracleParameter("v_CMND", OracleDbType.Varchar2),
                new OracleParameter("v_Luong", OracleDbType.Int32), 
                new OracleParameter("v_Mail", OracleDbType.Varchar2)};
            Object[] parameters = { maNV, tenNV, ngaySinh, gioiTinh, cmnd, luong, mail };
            DataProvider.Instance.ExecuteNonQuery("ThemNhanVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool capNhat(int maNV, string tenNV, DateTime? ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaNV", OracleDbType.Int32),
                new OracleParameter("v_TenNV", OracleDbType.Varchar2),
                new OracleParameter("v_NgaySinh", OracleDbType. Date),
                new OracleParameter("v_GioiTinh", OracleDbType.Varchar2),
                new OracleParameter("v_CMND", OracleDbType.Varchar2),
                new OracleParameter("v_Luong", OracleDbType.Int32),
                new OracleParameter("v_Mail", OracleDbType.Varchar2)};
            Object[] parameters = { maNV, tenNV, ngaySinh, gioiTinh, cmnd, luong, mail };
            DataProvider.Instance.ExecuteNonQuery("CapNhatNhanVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(int maNV)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaNV", OracleDbType.Int32) };
            Object[] parameters = { maNV };
            DataProvider.Instance.ExecuteNonQuery("XoaNhanVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }

      public DataTable getListNhanVien()
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadnhanvien"));
      }
      public DataTable getNhanVien(string mail)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from nhanvien where mail = '{0}'", mail));
         
      }

   }
}
