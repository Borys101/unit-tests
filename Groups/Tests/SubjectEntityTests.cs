using Microsoft.VisualStudio.TestTools.UnitTesting;
using Groups.Implementations;

namespace Tests
{
    [TestClass]
    public class SubjectEntityTests
    {
        [TestMethod]
        public void SubjectEntity_ChangeName_ChangesNameCorrectly()
        {
            var subject = new SubjectEntity();
            var newName = "Ukrainian";

            subject.ChangeName(newName);

            Assert.AreEqual(newName, subject.Name);
        }
    }
}
