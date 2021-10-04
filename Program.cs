using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonAnFactory factory;

            Random random = new Random();
            int type = random.NextInt(0,2);

            if (type == 0)
            { 
                factory = new MonKhoFactory();
            }
            else {
                factory = new MonNuocFactory();
            }

            // randow 4 mon an theo loai

            Console.WriteLine(factory.createMonAn().LuaChon());
            Console.WriteLine(factory.createMonAn().LuaChon());
            Console.WriteLine(factory.createMonAn().LuaChon());
            Console.WriteLine(factory.createMonAn().LuaChon());

        }
    }
}
