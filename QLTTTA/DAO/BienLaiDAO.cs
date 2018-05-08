using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace QLTTTA.DAO
{
   public class BienLaiDAO
   {
      private static BienLaiDAO instance;

      public static BienLaiDAO Instance
      {
         get { if (instance == null) instance = new BienLaiDAO(); return instance; }
         private set { instance = value; }
      }
      public BienLaiDAO() { }
      public bool them(int maHV, int maLH, int maKH, string hoaDon)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaHocVien", OracleDbType.Int32),
                new OracleParameter("v_MaLopHoc", OracleDbType.Int32),
                new OracleParameter("v_MaKhoaHoc", OracleDbType.Int32),
                new OracleParameter("v_HoaDon", OracleDbType.Varchar2),
                };
            Object[] parameters = {maHV, maLH, maKH, hoaDon};
            DataProvider.Instance.ExecuteNonQuery("ThemBienLai", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool xoa(int maHV, int maLH, int maKH)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("v_MaHocVien", OracleDbType.Int32),
                new OracleParameter("v_MaLopHoc", OracleDbType.Int32),
                new OracleParameter("v_MaKhoaHoc", OracleDbType.Int32),
                };
            Object[] parameters = { maHV, maLH, maKH };
            DataProvider.Instance.ExecuteNonQuery("XoaBienLai", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public DataTable getListBienLai(int maKH)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from  bienlaihocphi where makhoahoc = {0}", maKH.ToString()));
      }
   }
}
