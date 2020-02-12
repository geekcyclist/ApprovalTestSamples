# ApprovalTestSamples

## Collatz Series Calculator for demonstrating ApprovalTests

The set of projects in this repository are based around an "over-engineered" Collatz Series calculator

### The Collatz Conjecture

As found on [Wikipedia](https://en.wikipedia.org/wiki/Collatz_conjecture)
> The Collatz conjecture is a conjecture in mathematics that concerns a sequence defined as follows: start with any positive integer n.  Then each term is obtained from the previous term as follows: if the previous term is even, the next term is one half the previous term.  If the previous term is odd, the next term is 3 times the previous term plus 1. The conjecture is that no matter what value of n, the  sequence will always reach 1.

For Example, if you start with the value you end up with the series below:

| Value | Step |
|-------|------|
| 53    | 0    |
| 160   | 1    |
| 80    | 2    |
| 40    | 3    |
| 20    | 4    |
| 10    | 5    |
| 5     | 6    |
| 16    | 7    |
| 8     | 8    |
| 4     | 9    |
| 2     | 10   |
| 1     | 11   |

## Projects and Tasks

The source folder has `before` and `after` subdirectories. 

The `before` directory includes:

- Collatz.Core - A .NET Standard Class Library with the core objects used to build a Collatz Sequence.
- Collatz.Core.Tests - A .NET Core xUnit Test Project, with standard xUnit Assert-based tests. This project has:
  - the required references to the main ApprovalTests NuGet package;
  - using statements for ApprovalTests where required;
  - initial annotations to set the ApprovalTests Reporter type;
  - skipped test stubs with commented steps where ApprovalTests should be implemented. 
- Collatz.WinForms - A .NET Framework WinForms Application meant to simulate a "Legacy" application.
- Collatz.WinForms.Tests As MS Test Unit Test Project (.NET Framework). This project has:
  - the required references to the ApprovalTests and ApprovalTests.WinForms NuGet packages;
  - using statements for ApprovalTests and ApprovalTests.WinForms where required;
  - initial annotations to set the ApprovalTests Reporter type;
  - skipped test stubs with commented steps where ApprovalTests should be implemented. 

The intent is for a learner to clone the full repository, then use the source, solution and projects in `before` to complete the following tasks.

### Setup Tasks

- Build and run all projects and tests
- Verify that .gitignore has and entry for "&ast;.received.&ast;"
- (optional) Add an annotation to the test class or to Collatz.Core.Tests.AssemblyInfo.cs to set the `UseApprovalSubDirectory`
- (optional) Add an annotation to the test class or to Collatz.Core.Tests.AssemblyInfo.cs for `UseReporter` to set the desired default `Reporter` type.

### Collatz.Core & Collatz.Core.Tests Tasks

- Provide and appropriate override for ToString() for:
  - Collatz.Core.CollatzStep
  - Collatz.Core.CollatzSeries (include an enumeration of the steps)
- Implement the stubbed ApprovalTests

### Collatz.WinForms & Collatz.WinForms.Tests Tasks

- (optional) Add an annotation to the test class or to Collatz.WinForms.Tests.AssemblyInfo.cs to set the `UseApprovalSubDirectory`
- (optional) Add an annotation to the test class or to Collatz.WinForms.Tests.AssemblyInfo.cs for `UseReporter` to set the desired default `Reporter` type.
- Implement the `VerifyFormStartup()` test.
- Use ExtractMethod refactorings to introduce "seams" while implementing stubbed ApprovalTests for:
  - `VerifyScenario()`
  - `VerifyClear()`

### Reference Implementation

The `after` folder includes a completed reference implementation of the tutorial steps above. Like anything else in software development, there are myriad other possible implementations, and this one is far from perfect or "production ready". These completed projects are provided to give the learner hints in case they get stuck trying to implement their own tests.
