using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_1.DAO
{
    internal class LopDao
    {
        public static DataTable ThongTinLop()
        {
            string sql = "select*from LOP";
            DataTable dt = new DataTable();
            dt = KNCSDL.DOCDULIEU(sql);
            return dt;
        }
    }
}
