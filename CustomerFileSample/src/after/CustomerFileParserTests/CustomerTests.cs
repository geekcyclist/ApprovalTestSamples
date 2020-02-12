using ApprovalTests;
using Xunit;

namespace CustomerFileParserTests
{
    public class CustomerTests
    {
        [Fact]
        public void CanPopulateCustomer()
        {
            int expectedId = 1;
            string expectedFirst = "Homer";
            string expectedMiddle = null;
            string expectedLast = "Simpson";
            //... and the rest of the properties

            var homer = MockData.CreateHomer();
            Assert.Equal(expectedId, homer.Id);
            Assert.Equal(expectedFirst, homer.FirstName);
            Assert.Equal(expectedMiddle, homer.MiddleName);
            Assert.Equal(expectedLast, homer.LastName);
        }

        [Fact(Skip = "Approval Test Stub")]
        public void ApproveCustomer()
        {
            //TODO: Implement an ApprovalTest for Customer
            // do - create a customer
            // approve - create the approval test
        }
    }
}
