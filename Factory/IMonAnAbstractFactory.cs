using FactoryMethod.MonAn;
using System.Collections.Generic;
using System;
using System.Text;

namespace FactoryMethod.Factory
{ 
    abstract class AbstractMonAnFactory : IMonAnFactory
    {
        public abstract MonAn createMonAn();
    }
}
