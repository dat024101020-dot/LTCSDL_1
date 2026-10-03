using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_1.DAO
{
    internal class LopDao
    {
        public static DataTable ThongTinLop()
        {
            SqlCommand cmd = new SqlCommand("select*from LOP");
            DataTable dt = new DataTable();
            dt = KNCSDL.DOCDULIEU(cmd);
            return dt;
        }
    }
}
