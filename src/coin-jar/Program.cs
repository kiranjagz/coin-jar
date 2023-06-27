namespace coin_jar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coinJar = new CoinJar();

            coinJar.AddCoin(0.25m);
            coinJar.AddCoin(0.25m);
            coinJar.AddCoin(0.50m);

            var totalBalance = coinJar.GetCoinBalance();

            Console.WriteLine(totalBalance);

            coinJar.EmptyJar();

            Console.WriteLine(coinJar.GetCoinBalance());
        }
    }
}