namespace AsyncProgramming;

public class BankAccount
{
    private readonly object locker = new();
    public int Balance { get; private set; }

    public async Task<int> Put(int sum)
    {
        //lock (locker)
        //{
            Balance += sum;
            Task.Delay(1000);
            Console.WriteLine($"{sum} was added to balance. {Balance}");

            return Balance;
        //}
    
    }
}