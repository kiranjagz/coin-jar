using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_jar.Contract
{
    public interface ICoinJar
    {
        void AddCoin(decimal coin);
        void EmptyJar();
        decimal GetCoinBalance();
    }
}
