using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public enum EventType
    {
        Music,
        Comedy,
        Theatre
    }
    public class Event : IComparable<Event>
    {
       public string Name {  get; set; }
       public DateTime EventDate {  get; set; }
       public List<Ticket> Tickets { get; set; }
       public EventType TypeOfEvent { get; set; }


        public Event()
        {

        }

    }
