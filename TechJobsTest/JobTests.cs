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

    }
}
