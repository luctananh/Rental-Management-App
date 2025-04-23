using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCS
{
    public static class ID
    {
        public static string mk = null;
        public static string id=null;

        public static void setid(string a)
        {
            id = a;
        }
        public static void setmk(string a)
        {
            mk = a;
        }
        public static string getid()
        {
            return id;
        }
        public static string getmk()
        {
            return mk;
        }

    }
}
