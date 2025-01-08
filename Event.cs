using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public class Event
    {
        string Name {  get; set; }
        DateTime EventDate {  get; set; }
        List<Ticket> Tickets { get; set; }
        enum EventType
        {
            Music,
            Comedy,
            Theatre
        }
    }
}
