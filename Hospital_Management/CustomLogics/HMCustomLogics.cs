using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Management.CustomLogics
{
    public static class HMCustomLogics
    {
        public static string getAutoIncreamentId(int prevNo)
        {
            prevNo = prevNo + 1;
            string newNo = string.Empty;
            if (prevNo >= 0 && prevNo <= 9)
            {
                newNo = "OT" + "0000" + prevNo;
            }
            else if (prevNo >= 10 && prevNo <= 99)
            {
                newNo = "OT" + "000" + prevNo;
            }
            else if (prevNo >= 100 && prevNo <= 999)
            {
                newNo = "OT" + "00" + prevNo;
            }
            else if (prevNo >= 1000 && prevNo <= 9999)
            {
                newNo = "OT" + "0" + prevNo;
            }
            else if (prevNo >= 10000 && prevNo <= 9999)
            {
                newNo = "OT" + prevNo.ToString();
            }
            return newNo;
        }
        public static int getNumberOnly(string str, int extractGigit)
        {
            string num_string = str.Remove(0, extractGigit);
            return Convert.ToInt32(num_string);
        }
    }
}