using FactoryMethod.MonAn;

namespace FactoryMethod.Factory
{
    class RanDomMonAnFactory : IMonAnFactory
    {
        public override MonAn createMonAn()
        { 
            Random random = new Random();
            int type = random.Next(0,3);
            if (type == 0){
                return new CamEp();
            }
            else if (type == 1){
                return new DuaXay();
            }
            else if (type == 2) {
                return new NuocMia();
            }
        }           
    }
}