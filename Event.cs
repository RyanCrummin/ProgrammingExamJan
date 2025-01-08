using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public enum EventType // EVENT TYPE
    {
        Music,
        Comedy,
        Theatre
    }
    public class Event : IComparable <Event>
    {
        public string Name { get; set; } // NAME
        public DateTime EventDate { get; set; } // EVENT DATE
        public List<Ticket> Tickets { get; set; } // LIST OF TICKETS
        public EventType TypeOfEvent { get; set; } // SETS EVENT


        // CONSTRUCTORS
        public Event()
        {

        }

        public Event(string name, DateTime eventDate, EventType typeOfEvent) // CONSTUCTOR FOR EVENT CREATION
        {
            Name = name;
            EventDate = eventDate;
            TypeOfEvent = typeOfEvent;
        }

        // METHODS
        public int CompareTo(Event other)
        {
            return EventDate.Day.CompareTo(other.EventDate.Day);
        }
        public override string ToString()
        {
            return $"{Name} - {EventDate:D2}";
        }
    }
}