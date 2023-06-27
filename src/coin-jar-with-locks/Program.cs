namespace coin_jar_with_locks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coinJar = new CoinJar();

            Thread threadOne = new Thread(() => coinJar.AddCoin(0.25m));
            Thread threadTwo = new Thread(() => coinJar.AddCoin(0.25m));
            Thread threadThree = new Thread(() => coinJar.AddCoin(0.25m));

            threadOne.Start();
            threadTwo.Start();
            threadThree.Start();

            threadOne.Join();
            threadTwo.Join();
            threadThree.Join();

            var totalBalance = coinJar.GetCoinBalance();

            Console.WriteLine(totalBalance);

            coinJar.EmptyJar();
        }
    }
}