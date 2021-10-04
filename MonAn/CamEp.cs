using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class CamEp : MonAn
    { 


        public CamEp(){

        }

        public CamEp(float _Gia){
            Gia = _Gia;
        }

        public CamEp(string _Loai){
            Loai = _Loai;
        }

        public CamEp(float _Gia, string _Loai){
            Loai = _Loai;
            Gia = _Gia;
        }

        public override MonAn LuaChon()
        {
            MonAn monan = new CamEp();
            return monan;
        }
    }
}