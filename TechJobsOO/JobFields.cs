using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobFields
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobFields()
        {
            Id = nextId;
            nextId++;
        }

        public JobFields(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobFields type &&
                Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
