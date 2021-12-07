using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobFields
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public CoreCompetency(string value) : base(value)
        {
            Value = value;
        }
    }
}
