using System;
namespace TechJobsOO
{
    public class Employer : JobFields
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }


        public Employer(string value) : base(value)
        {
            Value = value;
        }


       
    }
}
