using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class DuaXay : MonNuoc
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

        public override string LuaChon()
        {
            //MonAn monan = new DuaXay();
            return "Dua xay";
        }
    }
}