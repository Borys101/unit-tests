using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students.Implementations;

namespace Tests
{
    [TestClass]
    public class TeacherEntityTests
    {
        [TestMethod]
        public void TeacherEntity_AssignSubject_CorrectlyAssignsSubject()
        {
            var teacher = new TeacherEntity();

            teacher.AssignSubject("Math");

            Assert.AreEqual("Math", teacher.Subject);
        }
    }
}
