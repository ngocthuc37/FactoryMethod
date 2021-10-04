using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class PhoBo : MonAn
    { 


        public PhoBo() {

        }

        public PhoBo(float _Gia){
            Gia = _Gia;
        }

        public PhoBo(string _Loai){
            Loai = _Loai;
        }

        public PhoBo(float _Gia, string _Loai){
            Loai = _Loai;
            Gia = _Gia;
        }

        public override MonAn LuaChon()
        {
            MonAn monan = new PhoBo();
            return monan;
        }
    }
}