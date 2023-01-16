using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket
{
    public class Payment
    {
        public string reference;
        public int amount;
        public DateTime created_at;
        public List<Payment> _payments;

        Payment MakePayment(string reference, int amount)
        {
            var payment = new Payment()
            {
                reference = reference,
                amount = amount,
                created_at = DateTime.Now
            };
            
            _payments.Add(payment);

            return payment;
        }
        
        Payment VerifyPayment(string refNo)
        {
            var payment = _payments.First(x => x.reference == refNo);
            
            if (payment == null)
            {
                throw new Exception("Payment not found");
            }
            
            return payment;
        }
        
        
    }
}