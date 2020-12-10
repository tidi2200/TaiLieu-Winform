using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;

namespace BAL
{
    public class BAL_DM_SINHVIEN
    {
        public DataTable LayDSSV()
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.Read("tbSINHVIEN A, tbLOP B");
            }
            catch(Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSL()
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.ReadDSL("tbLOP");
            }
            catch(Exception err)
            {
                throw;
            }
        }

        public DataTable LayDSSVTheoLop(string tenlop)
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.Read2(tenlop);
            }
            catch(Exception err)
            {
                throw;
            }
        }

        public bool XoaSV(string mssv)
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.Xoa(mssv);
            }
            catch(Exception err)
            {
                throw;
            }
        }

        public string LayMaLop(string malop)
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.LayMaLop(malop);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool KiemTraTonTai(string mssv)
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.KiemTraTonTai(mssv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool ThemSV(BEL_DM_SINHVIEN sv)
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.Them(sv);
            }
            catch (Exception err)
            {
                throw;
            }
        }

        public bool CapNhatSV(BEL_DM_SINHVIEN sv)
        {
            try
            {
                DAL_DM_SINHVIEN objdal = new DAL_DM_SINHVIEN();
                return objdal.CapNhat(sv);
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
