using System;
namespace TechJobsOO
{
    public class PositionType : JobFields
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public PositionType(string value) : base(value)
        {
            Value = value;
        }
    }
}
