using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.Windows;
using Xunit;

namespace CustomerFileParserTests
{
    [UseReporter(typeof(BeyondCompare4Reporter))]
    [UseApprovalSubdirectory("Approvals")]
    public class CustomerTests
    {
        [Fact]
        public void CanPopulateCustomer()
        {
            int expectedId = 1;
            string expectedFirst = "Homer";
            string expectedMiddle = null;
            string expectedLast = "Simpson";
            string expectedStreet = "742 Evergreen Terrace";
            string expectedCity = "Springfield";
            string expectedState = "IL";
            string expectedZip = "62704";
            string expectedZip4 = "7023";
            int expectedAge = 39;

            var homer = MockData.CreateHomer();
            Assert.Equal(expectedId, homer.Id);
            Assert.Equal(expectedFirst, homer.FirstName);
            Assert.Equal(expectedMiddle, homer.MiddleName);
            Assert.Equal(expectedLast, homer.LastName);
            Assert.Equal(expectedStreet, homer.Street);
            Assert.Equal(expectedCity, homer.City);
            Assert.Equal(expectedState, homer.State);
            Assert.Equal(expectedZip, homer.Zip);
            Assert.Equal(expectedZip4, homer.Zip4);
            Assert.Equal(expectedAge, homer.Age);
        }

        [Fact]
        public void ApproveCustomer()
        {
            Approvals.Verify(MockData.CreateHomer());
        }
    }
}
