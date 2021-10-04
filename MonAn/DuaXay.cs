using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class DuaXay : MonAn
    { 


        public DuaXay() {

        }

        public DuaXay(float _Gia){
            Gia = _Gia;
        }

        public DuaXay(string _Loai){
            Loai = _Loai;
        }

        public DuaXay(float _Gia, string _Loai){
            Loai = _Loai;
            Gia = _Gia;
        }

        public override MonAn LuaChon()
        {
            MonAn monan = new DuaXay();
            return monan;
        }
    }
}