using FactoryMethod.MonAn;

namespace FactoryMethod.Factory
{
    class MonKhoFactory : AbstractMonAnFactory
    {
        public override MonAn createMonAn()
        { 
            Random random = new Random();
            int type = random.Next(0,3);
            if (type == 0){
                return new BunRieu();
            }
            else if (type == 1){
                return new ComGa();
            }
            else if (type == 2) {
                return new PhoBo();
            }
        }
        
    }
}