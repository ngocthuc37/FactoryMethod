using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class GoiCuon : MonAn
    { 

        public GoiCuon() {

        }

        public GoiCuon(float _Gia){
            Gia = _Gia;
        }

        public GoiCuon(string _Loai){
            Loai = _Loai;
        }

        public GoiCuon(float _Gia, string _Loai){
            Loai = _Loai;
            Gia = _Gia;
        }

        public override MonAn LuaChon()
        {
            MonAn monan = new GoiCuon();
            return monan;
        }
    }
}