# ApprovalTestSamples

## Flat-File Customer Data Parser for demonstrating ApprovalTests

The set of projects in this repository are based around a very stripped down flat-file processor. It is meant to highlight some of the advantages of using ApprovalTests.Net to verify complex objects and collection.

There is no console or UI, which would normally manage the code for retrieving or sending files to be parsed. There is no persistence layer either. The entire focus is on parsing data into a model/object, and testing the properties of that object. A **Feature Request** in the Projects and Tasks section below highlights the maintenance advantage of ApprovalTests over traditional asserts in *some situations*.

## Projects and Tasks ##

The source folder has `before` and `after` subdirectories

The `before` folder holds:
- CustomerFileParser - A .NET Core 3.0 Class library that represents the primary parsing library;
- CustomerFileParserTests - A .NET Core 3.0 xUnit test project. This test project has:

  - the required references to the main ApprovalTests NuGet package;
  - using statements for ApprovalTests where required;
  - skipped test stubs with commented steps where ApprovalTests should be implemented.

The intent is for a learner to clone the full repository, then use the source, solution and projects in `before` to complete the following tasks.

### Setup Tasks

- Build all projects and run tests
- Verify that .gitignore has and entry for "&ast;.received.&ast;"
- Add a UseReporter annotation to each test class to set the desired default Reporter type.
- (optional) Add an annotation to each test class to set the UseApprovalSubDirectory.

### Initial ApprovalTest Implementation Tasks

- Review the code in `CustomerFileParser.BaseModel`.
- Modify `CustomerFileParser.Customer` to inherit from `BaseModel`.
- Implement `CustomerTests.ApproveCustomer()` to verify the state of a single customer record.
- Implement `FileParserTests.ApproveParsedCustomerData()` to verify the state of a parsed collection.

### Feature Request Task

Due to changes to the API and UX that processes customer data, the business has asked that all fields in the `Customer` object that contain text be in UPPERCASE.

- Implement this feature request and run the tests.
- Make any required changes for any failing test to pass.

### Reference Implementation

The `after` folder includes a completed reference implementation of the tutorial steps above. Like anything else in software development, there are myriad other possible implementations, and this one is far from perfect or "production ready". These completed projects are provided to give the learner hints in case they get stuck trying to implement their own tests.
