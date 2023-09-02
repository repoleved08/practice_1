using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_MS.Requests
{
    public class AddUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public int PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
