using System;

namespace DAL.EF6.Models
{
    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Status { get; set; }
    }
}