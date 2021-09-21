using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryMethod
{
    public class MonAn
    {
        public Unit DatMon(string tenMon)
        { 
            if (tenMon == "MonKho")
                return new MonKho();
            else if (tenMon == "MonNuoc")
                return new MonNuoc();
            else if (tenMon == "TrangMieng")
                return new TrangMieng();
            return TimMonNangCao(tenMon);
        }

        private static void TimMonNangCao(string tenMon)
        {
            throw new NotImplementedException();
        }
    }
}