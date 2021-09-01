using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Shared
{
    public static class Helper
    {
        public static bool VerificarCapitalCE(string cidade)
        {
            if (cidade == "fortaleza")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int VerificaSePar(int  n)
        {
            return n%2;
        }

    }
}
