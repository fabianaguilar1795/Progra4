using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Caso2
{
    public class Calculos
    {
        public static double MultiplicarNumeros(double n1)
        {
            return n1 * 2;
        }

        public static void bitacora(string guardar)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\Caso2\bitacora.txt", true))
            {
                objStrem.WriteLine(guardar);
                objStrem.Flush();
            }  
        }
    }
}