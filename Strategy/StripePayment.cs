public class StripePayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        // Implement Stripe payment processing here
        Console.WriteLine("Processing Stripe payment of $" + amount);
    }
}
