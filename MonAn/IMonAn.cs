using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryMethod.MonAn
{
    interface MonAn
    {
      protected float Gia;
      protected string Loai;

      string LuaChon();
      
    }
}