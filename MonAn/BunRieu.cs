using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  FactoryMethod.MonAn
{
    public class BunRieu : MonKho
    { 


        public BunRieu(){

        }

        public BunRieu(float _Gia){
            Gia = _Gia;
        }

        public BunRieu(string _Loai){
            Loai = _Loai;
        }

        public BunRieu(float _Gia, string _Loai){
            Loai = _Loai;
            Gia = _Gia;
        }

        public override string LuaChon()
        {
            //MonAn monan = new BunRieu();
            return "Bun Rieu";
        }
    }
}