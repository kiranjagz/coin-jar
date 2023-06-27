namespace coin_jar_with_concurrent_reads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jar = new CoinJar();

            // Adding coins to the jar using multiple threads
            Thread thread1 = new Thread(() => jar.AddCoin(0.25m));
            Thread thread2 = new Thread(() => jar.AddCoin(0.1m));
            Thread thread3 = new Thread(() => jar.AddCoin(0.05m));
            Thread thread4 = new Thread(() => jar.AddCoin(0.5m));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();

            // Getting the total amount in the jar using multiple threads
            Thread thread5 = new Thread(() => Console.WriteLine("Total amount in the jar: $" + jar.GetCoinBalance()));
            Thread thread6 = new Thread(() => Console.WriteLine("Total amount in the jar: $" + jar.GetCoinBalance()));

            thread5.Start();
            thread6.Start();

            thread5.Join();
            thread6.Join();

            // Emptying the jar
            jar.EmptyJar();
            Console.WriteLine("Jar emptied. Total amount in the jar: $" + jar.GetCoinBalance());
        }
    }
}