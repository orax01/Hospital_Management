using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Management.CustomLogics
{
    public static class HMCustomLogics
    {
        public static string getAutoIncreamentId(int prevNo,string type)
        {
            if (type == "OT")
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

            if(type== "PT")
            {
                prevNo = prevNo + 1;
                string newNo = string.Empty;
                if (prevNo >= 0 && prevNo <= 9)
                {
                    newNo = "PT" + "0000" + prevNo;
                }
                else if (prevNo >= 10 && prevNo <= 99)
                {
                    newNo = "PT" + "000" + prevNo;
                }
                else if (prevNo >= 100 && prevNo <= 999)
                {
                    newNo = "PT" + "00" + prevNo;
                }
                else if (prevNo >= 1000 && prevNo <= 9999)
                {
                    newNo = "PT" + "0" + prevNo;
                }
                else if (prevNo >= 10000 && prevNo <= 9999)
                {
                    newNo = "PT" + prevNo.ToString();
                }
                return newNo;
            }

            if (type == "DOC")
            {
                prevNo = prevNo + 1;
                string newNo = string.Empty;
                if (prevNo >= 0 && prevNo <= 9)
                {
                    newNo = "DOC" + "0000" + prevNo;
                }
                else if (prevNo >= 10 && prevNo <= 99)
                {
                    newNo = "DOC" + "000" + prevNo;
                }
                else if (prevNo >= 100 && prevNo <= 999)
                {
                    newNo = "DOC" + "00" + prevNo;
                }
                else if (prevNo >= 1000 && prevNo <= 9999)
                {
                    newNo = "DOC" + "0" + prevNo;
                }
                else if (prevNo >= 10000 && prevNo <= 9999)
                {
                    newNo = "DOC" + prevNo.ToString();
                }
                return newNo;
            }

            else
            {
                return "some error occured";
            }
        }
        public static int getNumberOnly(string str, int extractGigit)
        {
            string num_string = str.Remove(0, extractGigit);
            return Convert.ToInt32(num_string);
        }
    }
}