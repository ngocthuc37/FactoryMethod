using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class NuocMia : MonNuoc
    { 

         public NuocMia() {

         }

         public NuocMia(float _Gia){
             Gia = _Gia;
         }

         public NuocMia(string _Loai){
             Loai = _Loai;
         }

         public NuocMia(float _Gia, string _Loai){
             Loai = _Loai;
             Gia = _Gia;
         }

        public override string LuaChon()
        {
            //MonAn monan = new GoiCuon();
            return "Nuoc mia";
        }
    }
}