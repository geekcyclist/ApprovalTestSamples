using ApprovalTests.Namers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// Required references
using Collatz.WinForms;
using ApprovalTests.WinForms;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.Windows;

namespace Collatz.WinForms.Tests
{
    [TestClass]
    [UseReporter(typeof(BeyondCompare4Reporter), typeof(ClipboardReporter))]
    [UseApprovalSubdirectory("Approvals")]
    public class SeriesCalculatorFormTests
    {
        [TestMethod]
        public void VerifyFormStartup()
        {
            var frm = new SeriesCalculator();
            WinFormsApprovals.Verify(frm);
        }

        [TestMethod]
        public void VerifyScenario()
        {
            var frm = new SeriesCalculator();
            frm.PopulateForm(10);
            WinFormsApprovals.Verify(frm);
        }

        [TestMethod]
        public void VerifyClear()
        {
            var frm = new SeriesCalculator();
            frm.PopulateForm(10);
            frm.ClearForm();
            WinFormsApprovals.Verify(frm);
        }
    }
}
