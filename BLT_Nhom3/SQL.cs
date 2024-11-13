using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLT_Nhom3
{
    internal class SQL
    {
        private String chuoi = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\\do_an_sql.mdf;Integrated Security=True;Connect Timeout=30";
        public String getChuoi()
        {
            return chuoi;
        }
    }
}
