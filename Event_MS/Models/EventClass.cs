using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_MS.Models
{
    public class EventClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; } = 0;
        public int TicketAmount { get; set; } = 0;
        public DateTime dateTime{ get; set; }
        // Navigation
         public List<EventClass> Events { get; set; } = new List<EventClass>();
    }
}
