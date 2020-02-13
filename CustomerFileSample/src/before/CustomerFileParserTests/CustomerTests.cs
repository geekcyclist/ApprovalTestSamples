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

        [Fact(Skip = "Approval Test Stub")]
        public void ApproveCustomer()
        {
            //TODO: Implement an ApprovalTest for Customer
            // do - create a customer
            // approve - create the approval test
        }
    }
}
