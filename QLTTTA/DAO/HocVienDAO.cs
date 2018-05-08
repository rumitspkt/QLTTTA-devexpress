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
   public class HocVienDAO
   {
      private static HocVienDAO instance;

      public static HocVienDAO Instance
      {
         get { if (instance == null) instance = new HocVienDAO(); return instance; }
         private set { instance = value; }
      }
      public HocVienDAO() { }
      public bool them(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaHV", OracleDbType.Int32),
                new OracleParameter("v_HoTen", OracleDbType.Varchar2),
                new OracleParameter("v_NgaySinh", OracleDbType. Date),
                new OracleParameter("v_GioiTinh", OracleDbType.Varchar2),
                new OracleParameter("v_DiaChi", OracleDbType.Varchar2),
                new OracleParameter("v_SoDienThoai", OracleDbType.Varchar2) };
            Object[] parameters = { maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai };
            DataProvider.Instance.ExecuteNonQuery("ThemHocVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool capNhat(int maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string soDienThoai)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaHV", OracleDbType.Int32),
                new OracleParameter("v_HoTen", OracleDbType.Varchar2),
                new OracleParameter("v_NgaySinh", OracleDbType. Date),
                new OracleParameter("v_GioiTinh", OracleDbType.Varchar2),
                new OracleParameter("v_DiaChi", OracleDbType.Varchar2),
                new OracleParameter("v_SoDienThoai", OracleDbType.Varchar2) };
            Object[] parameters = { maHV, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai };
            DataProvider.Instance.ExecuteNonQuery("CapNhatHocVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(int maHV)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaHV", OracleDbType.Int32) };
            Object[] parameters = { maHV};
            DataProvider.Instance.ExecuteNonQuery("XoaHocVien", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }

      public DataTable getListHocVien()
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadhocvien"));
      }
      public DataTable getHocVien(int maHV)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from hocvien where maHV = {0}", maHV.ToString()));
         
      }
      public DataTable getListHocVien(int maKH, int maLH)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from hocvien where maHV  in   (Select mahocvien From bienlaihocphi Where makhoahoc = {0} And malophoc = {1})", maKH.ToString(), maLH.ToString()));
      }
   }
}
