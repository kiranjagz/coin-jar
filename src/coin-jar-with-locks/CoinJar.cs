using coin_jar.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_jar_with_locks
{
    internal class CoinJar : ICoinJar
    {
        private decimal _totalBalance;
        private readonly object lockObject = new object();

        public CoinJar()
        { 
            _totalBalance = 0;
        }
        public void AddCoin(decimal coin)
        {
            lock(lockObject)
            {
                _totalBalance += coin;
            }
        }

        public void EmptyJar()
        {
            lock (lockObject)
            {
                _totalBalance = 0;
            }
        }

        public decimal GetCoinBalance()
        {
            lock (lockObject)
            {
                return _totalBalance;
            }
        }
    }
}
