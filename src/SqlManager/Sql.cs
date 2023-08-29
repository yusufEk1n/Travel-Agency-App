using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMimarisiProjeV2.SqlManager
{
    public class Sql
    {
        public string conStr { get; set; }
        public string cmdStr { get; set; }

        public Sql()
        {
            conStr = @"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True";
        }
    }
}
