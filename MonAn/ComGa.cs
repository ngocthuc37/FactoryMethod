using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class ComGa : MonKho
    { 


        public ComGa(){

        }

        public ComGa(float _Gia){
            Gia = _Gia;
        }

        public ComGa(string _Loai){
            Loai = _Loai;
        }

        public ComGa(float _Gia, string _Loai){
            Loai = _Loai;
            Gia = _Gia;
        }

        public override string LuaChon()
        {
            //MonAn monan = new ComGa();
            return "Com ga";
        }
    }
}