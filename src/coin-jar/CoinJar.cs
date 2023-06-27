using coin_jar.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_jar
{
    internal class CoinJar : ICoinJar
    {
        private decimal _totalBalance;

        public CoinJar()
        {
            _totalBalance = 0;
        }

        public void AddCoin(decimal coin)
        {
            _totalBalance += coin;
        }

        public void EmptyJar()
        {
            _totalBalance = 0;
        }

        public decimal GetCoinBalance()
        {
            return _totalBalance;
        }
    }
}
