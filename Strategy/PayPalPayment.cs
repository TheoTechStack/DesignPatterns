public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Implement PayPal payment processing here
        Console.WriteLine("Processing PayPal payment of $" + amount);
    }
}
