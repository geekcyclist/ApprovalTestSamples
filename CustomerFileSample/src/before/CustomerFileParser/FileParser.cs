using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CustomerFileParser.Models;
using FlatFiles;
using FlatFiles.TypeMapping;

namespace CustomerFileParser
{
    public class FileParser
    {
        public List<Customer> Parse(StringReader stringReader)
        {
            var mapper = FixedLengthTypeMapper.Define<Customer>();
            mapper.Property(c => c.Id, new Window(10)).ColumnName(nameof(Customer.Id));
            mapper.Property(c => c.FirstName, new Window(20)).ColumnName(nameof(Customer.FirstName));
            mapper.Property(c => c.MiddleName, new Window(20)).ColumnName(nameof(Customer.MiddleName));
            mapper.Property(c => c.LastName, new Window(20)).ColumnName(nameof(Customer.LastName));
            mapper.Property(c => c.Suffix, new Window(8)).ColumnName(nameof(Customer.Suffix));
            mapper.Property(c => c.Street, new Window(40)).ColumnName(nameof(Customer.Street));
            mapper.Property(c => c.City, new Window(20)).ColumnName(nameof(Customer.City));
            mapper.Property(c => c.State, new Window(2)).ColumnName(nameof(Customer.State));
            mapper.Property(c => c.Zip, new Window(5)).ColumnName(nameof(Customer.Zip));
            mapper.Property(c => c.Zip4, new Window(4)).ColumnName(nameof(Customer.Zip4));
            mapper.Property(c => c.Age, new Window(3)).ColumnName(nameof(Customer.Age));

            var customers = mapper.Read(stringReader, null).ToList();
            return customers;
        }
    }
}
