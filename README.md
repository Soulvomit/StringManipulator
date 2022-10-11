# Assignment 2

2.1:
https://github.com/Soulvomit/StringManipulator

2.2:
https://github.com/Soulvomit/BowlingGame

3.1:

@Tag - Used to filter test for different test plans. Good when you dont need to execute every test in your project for a specific plan. A test plan could be 'integrity test plan' and every test that should be executed under that plan could be tagged '@itegrity'.

@Disabled - Used to disable a test or a group of tests that should not be run. Good when you are working on a test and that test is 'in-progress' when you commit.

@RepeatedTest - Used to repeat the same test multiple times. Good when you have code or test that is based on random data or if your code is time critical.

@BeforeEach, @AfterEach - Used to run code before or after each tests. Good when you need to do some setup before each test that is run.

@BeforeAll, @AfterAll - Used to run code before or after all tests. Good when you need to do some setup before all test are executed or some cleanup after all tests are done. 

@DisplayName - Used to change the display name of your test. Good when you need more detailed reporting of your test.

@Nested - Used to group test classes in smaller nested classes. Good when you have a big test class and need to 'cut' it up in smaller chunks for readability or maintainability.

3.2:

NSubstitute vs Moq

Similarities:
Both support mocking of the entire .Net framwork.

Differences:
Moq: Is a traditional mocking framework for .NET. Support for stubs, fakes, spies etc.
NSub: Does away with traditional mocking (stub, fake, spy, test double) for a more cleaner user experience that simply "substitutes".

Preference:
I prefer the simplicity of NSubstitute, but recognise that Moq is the more powerful and well supported framework.
