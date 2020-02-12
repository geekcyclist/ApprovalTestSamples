using System;
using System.IO;
using System.Linq;
using Xunit;
using ApprovalTests;

namespace CustomerFileParserTests
{
    public class FileParserTests
    {
        [Fact]
        public void CanParseCustomerData()
        {
            StringReader reader = new StringReader(MockData.SampleRows);
            var parser = new CustomerFileParser.FileParser();
            
            var customers = parser.Parse(reader);

            Assert.True(customers.Any());
        }

        [Fact(Skip = "Approval Test Stub")]
        public void ApproveParsedCustomerData()
        {
            // TODO: Implement approval of the a customer collection
            // do - create a parser and parse the file
            // verify - approve the collection
        }
    }
}
