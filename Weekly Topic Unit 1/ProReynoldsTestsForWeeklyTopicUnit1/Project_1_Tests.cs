using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace ProReynoldsTestsForWeeklyTopicUnit1
{
    [TestClass]
    public class Project_1_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // setup
            var winForm = new Project_1_Winform.Form1();

            // assert
            winForm.Text.Contains("Project").ShouldBeTrue();
            
            var btnExit = winForm.Controls["btnExit"];
            btnExit.ShouldNotBeNull();
            btnExit.Text.ShouldBe("Exit the Application");

            var btnMessage = winForm.Controls["btnMessage"];
            btnMessage.ShouldNotBeNull();
        }
    }
}
