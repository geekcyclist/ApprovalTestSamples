﻿using System;
using System.IO;
using System.Linq;
using Xunit;
using ApprovalTests;
using ApprovalTests.Namers;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.Windows;

namespace CustomerFileParserTests
{
    [UseReporter(typeof(BeyondCompare4Reporter))]
    [UseApprovalSubdirectory("Approvals")]
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

        [Fact]
        public void ApproveParsedCustomerData()
        {
            StringReader reader = new StringReader(MockData.SampleRows);
            var parser = new CustomerFileParser.FileParser();
            
            var customers = parser.Parse(reader);

            Approvals.VerifyAll(customers, "Customer");
        }
    }
}
