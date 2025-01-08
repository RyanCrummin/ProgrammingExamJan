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
        string Name { get; set; } // NAME OF THE PERSON ON THE TICKETS
        decimal Price { get; set; }  // THE PRICE OF THE TICKETS
        int AvailableTickets { get; set; }  // THE AMOUNT OF AVAILABLE TICKETS


    }
    public class VIPTicket : Ticket
    {
        string AdditionalExtras { get; set; } // EXTRAS ON THE TICKET
        decimal AdditionalCost { get; set; } // ADDITIONAL COST ON THE TICKET


    }
}
