using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace QLTTTA.DAO
{
   public class KhoaHocDAO
   {
      private static KhoaHocDAO instance;

      public static KhoaHocDAO Instance
      {
         get { if (instance == null) instance = new KhoaHocDAO(); return instance; }
         private set { instance = value; }
      }
      public KhoaHocDAO() { }
      public bool them(int maKH, DateTime ngayBatDau, int soTuanHoc, string tinhTrang)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaKH", OracleDbType.Int32),
                new OracleParameter("v_NgayBatDau", OracleDbType.Date),
                new OracleParameter("v_SoTuanHoc", OracleDbType. Int32),
                new OracleParameter("v_TinhTrang", OracleDbType.Varchar2) };
            Object[] parameters = { maKH, ngayBatDau, soTuanHoc, tinhTrang };
            DataProvider.Instance.ExecuteNonQuery("ThemKhoaHoc", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool capNhat(int maKH, DateTime? ngayBatDau, int soTuanHoc, string tinhTrang)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaKH", OracleDbType.Int32),
                new OracleParameter("v_NgayBatDau", OracleDbType.Date),
                new OracleParameter("v_SoTuanHoc", OracleDbType. Int32),
                new OracleParameter("v_TinhTrang", OracleDbType.Varchar2) };
            Object[] parameters = { maKH, ngayBatDau, soTuanHoc, tinhTrang };
            DataProvider.Instance.ExecuteNonQuery("CapNhatKhoaHoc", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(int maKH)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaKH", OracleDbType.Int32) };
            Object[] parameters = { maKH };
            DataProvider.Instance.ExecuteNonQuery("XoaKhoaHoc", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public DataTable getKhoaHoc(int maKH)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from khoahoc where maKH = {0}", maKH));

      }

      public DataTable getListKhoaHoc()
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadkhoahoc"));
      }

      public DataTable getListKhoaHocByMaGV(int maGV)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("Select * From Khoahoc Where Makh in (select khoahoc from lophoc where giangvien = {0})", maGV.ToString()));
      }
   }
}
