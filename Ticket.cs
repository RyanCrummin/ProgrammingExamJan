using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public class Ticket
    {

        // DECLARING THE PROPERTIES
       public string Name { get; set; } // NAME OF THE PERSON ON THE TICKETS
       public decimal Price { get; set; }  // THE PRICE OF THE TICKETS
       public int AvailableTickets { get; set; }  // THE AMOUNT OF AVAILABLE TICKETS


    }
    public class VIPTicket : Ticket
    {
        public string AdditionalExtras { get; set; } // EXTRAS ON THE TICKET
        public decimal AdditionalCost { get; set; } // ADDITIONAL COST ON THE TICKET


    }
}
