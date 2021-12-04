using System;
using System.Collections.Generic;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            int dnaCount = 0;
            List<string> jobFields = new List<string> { Name, EmployerName.Value, EmployerLocation.Value, JobType.Value, JobCoreCompetency.Value };

            for (int i = 0; i < jobFields.Count; i++)
            {
                if (jobFields[i] == "")
                {
                    jobFields[i] = "Data not available";
                    dnaCount++;
                }
            }
            if (dnaCount == 5)
            {
                return "OOPS! This job does not seem to exist.";
            }
            

            return $"\nID: {Id}\nName: {jobFields[0]}\nEmployer: {jobFields[1]}\nLocation: {jobFields[2]}\nPosition Type: {jobFields[3]}\nCore Competency: {jobFields[4]}\n";

        }


    
        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
