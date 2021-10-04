using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FactoryMethod.MonAn
{
    public abstract class MonAn
    {
      protected float Gia;
      protected string Loai;

      public abstract MonAn LuaChon();
      
    }
}