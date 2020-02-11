using System;
using System.IO;
using System.Linq;
using Xunit;

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
    }
}
