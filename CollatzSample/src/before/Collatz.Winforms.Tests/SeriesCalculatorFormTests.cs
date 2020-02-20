using Microsoft.VisualStudio.TestTools.UnitTesting;
// Required references
using Collatz.WinForms;
using ApprovalTests.WinForms;
using ApprovalTests.Reporters;

namespace Collatz.WinForms.Tests
{
    [TestClass]
    //TODO: Add UseReporter annotation to set default reporter
    //TODO: Add UseReporter annotation for clipboard reporter
    //TODO: Add UseApprovalSubdirectory annotation to set file location
    public class SeriesCalculatorFormTests
    {
        [TestMethod]
        public void VerifyFormStartup()
        {
            // TODO: Implement VerifyFormStartup()
            // create a form instance
            // verify form appears correctly
            Assert.Inconclusive();
        }

        [TestMethod]
        public void VerifyScenario()
        {
            //TODO: Implement VerifyScenario
            // create a form instance
            // set a value for the text box
            // populate the grid
            // verify form appears correctly
            Assert.Inconclusive();
        }

        [TestMethod]
        public void VerifyClear()
        {
            // TODO: Implement VerifyClear()
            // create a form instance
            // set a value for the text box
            // populate the grid
            // ?? how can we verify that the data exists?
            // clear the form
            // verify form appears correctly
            Assert.Inconclusive();
        }
    }
}
