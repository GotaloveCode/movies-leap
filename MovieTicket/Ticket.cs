using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicket
{
    public interface ITicket
    {
        public Ticket FetchTicket(String refNo);
        public List<Ticket> FetchTickets();
    }

    public class Ticket : TicketType, ITicket
    {
        private int id;
        public int user_id;
        public int movie_id;
        public string reference;
        private List<Ticket> _tickets;

        public static string GenerateReference()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            string reference = new string(Enumerable.Repeat(validChars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return reference;
        }

        public Ticket FetchTicket(String refNo)
        {
            return _tickets.First(t => t.reference == refNo);
        }

        public List<Ticket> FetchTickets()
        {
            return _tickets;
        }
    }
}