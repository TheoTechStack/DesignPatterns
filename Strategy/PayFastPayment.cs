public class PayFastPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Implement PayFast payment processing here
        Console.WriteLine("Processing PayFast payment of $" + amount);
    }
}
