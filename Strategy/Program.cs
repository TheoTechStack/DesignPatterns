
 PaymentContext paymentContext = new PaymentContext();

        // Use PayPal payment method
        paymentContext.SetPaymentStrategy(new PayPalPayment());
        paymentContext.ProcessPayment(100.0);

        // Use PayFast payment method
        paymentContext.SetPaymentStrategy(new PayFastPayment());
        paymentContext.ProcessPayment(75.0);

        // Use Stripe payment method
        paymentContext.SetPaymentStrategy(new StripePayment());
        paymentContext.ProcessPayment(120.0);