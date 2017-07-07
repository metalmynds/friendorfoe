using System;

namespace FriendOrFoe.Model
{
    public class Person
    {
        public Guid Identifier { get; set; }
        public String Name { get; set; }
        public Status Status { get; set; }
    }
}
