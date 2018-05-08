using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace QLTTTA.DAO
{
   public class KetQuaDAO
   {
      private static KetQuaDAO instance;

      public static KetQuaDAO Instance
      {
         get { if (instance == null) instance = new KetQuaDAO(); return instance; }
         private set { instance = value; }
      }
      public KetQuaDAO() { }
      
      public bool them(int maHV, int maLH, int maKH, float? diemGiuaKy, float? diemCuoiKy, float? diemTB)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("V_Mahocvien", OracleDbType.Int32),
                new OracleParameter("V_Malophoc", OracleDbType.Int32),
                new OracleParameter("V_Makhoahoc", OracleDbType.Int32),
                new OracleParameter("v_DiemGiuaKy", OracleDbType.Double),
                new OracleParameter("v_DiemCuoiKy", OracleDbType.Double),
                new OracleParameter("v_DiemTB", OracleDbType.Double) };
            Object[] parameters = { maHV, maLH, maKH, diemGiuaKy, diemCuoiKy, diemTB };
            DataProvider.Instance.ExecuteNonQuery("ThemKetQua", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public bool capNhat(int maHV, int maLH, int maKH, float? diemGiuaKy, float? diemCuoiKy, float? diemTB)
      {
         try
         {
            OracleParameter[] oracleParams = { new OracleParameter("V_Mahocvien", OracleDbType.Int32),
                new OracleParameter("V_Malophoc", OracleDbType.Int32),
                new OracleParameter("V_Makhoahoc", OracleDbType.Int32),
                new OracleParameter("v_DiemGiuaKy", OracleDbType.Double),
                new OracleParameter("v_DiemCuoiKy", OracleDbType.Double),
                new OracleParameter("v_DiemTB", OracleDbType.Double) };
            Object[] parameters = { maHV, maLH, maKH, diemGiuaKy, diemCuoiKy, diemTB };
            DataProvider.Instance.ExecuteNonQuery("CapNhatKetQua", oracleParams, parameters);
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
            OracleParameter[] oracleParams = { new OracleParameter("V_Mahocvien", OracleDbType.Int32),
                new OracleParameter("V_Malophoc", OracleDbType.Int32),
                new OracleParameter("V_Makhoahoc", OracleDbType.Int32) };
            Object[] parameters = { maHV, maLH, maKH};
            DataProvider.Instance.ExecuteNonQuery("XoaBienLai", oracleParams, parameters);
            return true;
         }
         catch
         {
            return false;
         }
      }
      public DataTable getKetQua(int maHV, int maLH, int maKH)
      {
         return DataProvider.Instance.ExecuteQuery(string.Format("select * from ketqua where mahocvien = {0} and malophoc = {1} and makhoahoc = {2}", maHV.ToString(), maLH.ToString(), maKH.ToString()));
      }
      public bool capNhatDiemTB(int maLH, int maKH)
      {
         return DataProvider.Instance.ExecuteNonQuery(string.Format("Update Ketqua Set Diemtb = (Diemgiuaky + Diemcuoiky) / 2 Where Malophoc = {0} And Makhoahoc = {1}", maLH.ToString(), maKH.ToString())) > 0;
      }
   }
}
