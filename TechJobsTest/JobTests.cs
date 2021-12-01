using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.IsTrue(testJob1.Id != testJob2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer testEmployer3 = new Employer("ACME");
            Location testLocation3 = new Location("Desert");
            PositionType testPositionType3 = new PositionType("Quality Control");
            CoreCompetency testCoreCompetency3 = new CoreCompetency("Persistence");
            Job testJob3 = new Job("Product tester", testEmployer3, testLocation3, testPositionType3, testCoreCompetency3);

            Assert.AreEqual("Product tester", testJob3.Name);
            Assert.AreEqual("ACME", testJob3.EmployerName.Value);
            Assert.AreEqual("Desert", testJob3.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", testJob3.JobType.Value);
            Assert.AreEqual("Persistence", testJob3.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer testEmployer4 = new Employer("Amazon");
            Location testLocation4 = new Location("Jeffy B's place");
            PositionType testPositionType4 = new PositionType("Management");
            CoreCompetency testCoreCompetency4 = new CoreCompetency("Smartness");
            Job testJob4 = new Job("Lead IT Guy", testEmployer4, testLocation4, testPositionType4, testCoreCompetency4);

            Employer testEmployer5 = new Employer("Amazon");
            Location testLocation5= new Location("Jeffy B's place");
            PositionType testPositionType5 = new PositionType("Management");
            CoreCompetency testCoreCompetency5 = new CoreCompetency("Smartness");
            Job testJob5 = new Job("Lead IT Guy", testEmployer5, testLocation5, testPositionType5, testCoreCompetency5);

            Assert.IsFalse(Equals(testJob4, testJob5));
        }

    }
}
