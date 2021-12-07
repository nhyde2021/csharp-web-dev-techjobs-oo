using System;
namespace TechJobsOO
{
    public class Location : JobFields
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public Location(string value) : base(value)
        {
            Value = value;
        }
    }
}
