using coin_jar.Contract;
using System;
using System.Threading;

public class CoinJar : ICoinJar
{
    private decimal _totalAmount;
    private readonly ReaderWriterLockSlim lockObject = new ReaderWriterLockSlim();

    public CoinJar()
    {
        _totalAmount = 0;
    }

    public void EmptyJar()
    {
        lockObject.EnterWriteLock();
        try
        {
            _totalAmount = 0;
        }
        finally
        {
            lockObject.ExitWriteLock();
        }
    }

    public void AddCoin(decimal coin)
    {
        lockObject.EnterWriteLock();
        try
        {
            _totalAmount += coin;
        }
        finally
        {
            lockObject.ExitWriteLock();
        }
    }

    public decimal GetCoinBalance()
    {
        lockObject.EnterReadLock();
        try
        {
            return _totalAmount;
        }
        finally
        {
            lockObject.ExitReadLock();
        }
    }
}


