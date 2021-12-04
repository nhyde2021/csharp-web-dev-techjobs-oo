using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Job testJob2;

        Employer testEmployer3;
        Location testLocation3;
        PositionType testPositionType3;
        CoreCompetency testCoreCompetency3;
        Job testJob3;

        Employer testEmployer4;
        Location testLocation4;
        PositionType testPositionType4;
        CoreCompetency testCoreCompetency4;
        Job testJob4;

        Employer testEmployer5;
        Location testLocation5;
        PositionType testPositionType5;
        CoreCompetency testCoreCompetency5;
        Job testJob5;

        Employer testEmployer6;
        Location testLocation6;
        PositionType testPositionType6;
        CoreCompetency testCoreCompetency6;
        Job testJob6;

        Employer testEmployer7;
        Location testLocation7;
        PositionType testPositionType7;
        CoreCompetency testCoreCompetency7;
        Job testJob7;

        [TestInitialize]
        public void CreateJobObjects()
        {
            testJob1 = new Job();
            testJob2 = new Job();

            testEmployer3 = new Employer("ACME");
            testLocation3 = new Location("Desert");
            testPositionType3 = new PositionType("Quality Control");
            testCoreCompetency3 = new CoreCompetency("Persistence");
            testJob3 = new Job("Product tester", testEmployer3, testLocation3, testPositionType3, testCoreCompetency3);

            testEmployer4 = new Employer("Amazon");
            testLocation4 = new Location("Jeffy B's place");
            testPositionType4 = new PositionType("Management");
            testCoreCompetency4 = new CoreCompetency("Smartness");
            testJob4 = new Job("Lead IT Guy", testEmployer4, testLocation4, testPositionType4, testCoreCompetency4);

            testEmployer5 = new Employer("Amazon");
            testLocation5 = new Location("Jeffy B's place");
            testPositionType5 = new PositionType("Management");
            testCoreCompetency5 = new CoreCompetency("Smartness");
            testJob5 = new Job("Lead IT Guy", testEmployer5, testLocation5, testPositionType5, testCoreCompetency5);

            testEmployer6 = new Employer("Amazon");
            testLocation6 = new Location("Jeffy B's place");
            testPositionType6 = new PositionType("Management");
            testCoreCompetency6 = new CoreCompetency("Smartness");
            testJob6 = new Job("", testEmployer6, testLocation6, testPositionType6, testCoreCompetency6);

            testEmployer7 = new Employer("");
            testLocation7 = new Location("");
            testPositionType7 = new PositionType("");
            testCoreCompetency7 = new CoreCompetency("");
            testJob7 = new Job("", testEmployer7, testLocation7, testPositionType7, testCoreCompetency7);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(testJob1.Id != testJob2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", testJob3.Name);
            Assert.AreEqual("ACME", testJob3.EmployerName.Value);
            Assert.AreEqual("Desert", testJob3.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", testJob3.JobType.Value);
            Assert.AreEqual("Persistence", testJob3.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(Equals(testJob4, testJob5));
        }
        [TestMethod]
        public void TestToStringForEmptyFirstAndLastLines()
        {
            string testString = testJob3.ToString();
            Assert.AreEqual(testString[0], '\n');
            Assert.AreEqual(testString[testString.Length - 1], '\n');
        }
        [TestMethod]
        public void TestToStringFormat()
        {
            Assert.AreEqual($"\nID: 46\nName: Lead IT Guy\nEmployer: Amazon\nLocation: Jeffy B's place\nPosition Type: Management\nCore Competency: Smartness\n", testJob4.ToString());
        }
        [TestMethod]
        public void TestFieldNotFilled()
        {
            Assert.AreEqual($"\nID: 6\nName: Data not available\nEmployer: Amazon\nLocation: Jeffy B's place\nPosition Type: Management\nCore Competency: Smartness\n", testJob6.ToString());
        }
        [TestMethod]
        public void TestJobDoeNotExist()
        {
            Assert.AreEqual("OOPS! This job does not seem to exist.", testJob7.ToString());
        }
    }
}
