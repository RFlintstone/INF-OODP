// namespace MSTestUnitTests
// {
//     // A class that contains MSTest unit tests. (Required)
//     [TestClass]
//     public class YourUnitTests
//     {
//         [ClassInitialize]
//         public static void TestFixtureSetup(TestContext context)
//         {
//             // Executes once for the test class. (Optional)
//         }
//         [TestInitialize]
//         public void Setup()
//         {
//             // Runs before each test. (Optional)
//         }
//         [ClassCleanup]
//         public static void TestFixtureTearDown()
//         {
//             // Runs once after all tests in this class are executed. (Optional)
//             // Not guaranteed that it executes instantly after all tests from the class.
//         }
//         [TestCleanup]
//         public void TearDown()
//         {
//             // Runs after each test. (Optional)
//         }
//         // Mark that this is a unit test method. (Required)
//         [TestMethod]
//         public void YourTestMethod()
//         {
//             // Your test code goes here.
//             Assert.AreEqual(28, _actualFuel); // Tests whether the specified values are equal. 
//             Assert.AreNotEqual(28, _actualFuel); // Tests whether the specified values are unequal. Same as AreEqual for numeric values.
//             Assert.AreSame(_expectedRocket, _actualRocket); // Tests whether the specified objects both refer to the same object
//             Assert.AreNotSame(_expectedRocket, _actualRocket); // Tests whether the specified objects refer to different objects
//             Assert.IsTrue(_isThereEnoughFuel); // Tests whether the specified condition is true
//             Assert.IsFalse(_isThereEnoughFuel); // Tests whether the specified condition is false
//             Assert.IsNull(_actualRocket); // Tests whether the specified object is null
//             Assert.IsNotNull(_actualRocket); // Tests whether the specified object is non-null
//             Assert.IsInstanceOfType(_actualRocket, typeof(Falcon9Rocket)); // Tests whether the specified object is an instance of the expected type
//             Assert.IsNotInstanceOfType(_actualRocket, typeof(Falcon9Rocket)); // Tests whether the specified object is not an instance of type
//             StringAssert.Contains(_expectedBellatrixTitle, "Bellatrix"); // Tests whether the specified string contains the specified substring
//             StringAssert.StartsWith(_expectedBellatrixTitle, "Bellatrix"); // Tests whether the specified string begins with the specified substring
//             StringAssert.Matches("(281)388-0388", @"(?d{3})?-? *d{3}-? *-?d{4}"); // Tests whether the specified string matches a regular expression
//             StringAssert.DoesNotMatch("281)388-0388", @"(?d{3})?-? *d{3}-? *-?d{4}"); // Tests whether the specified string does not match a regular expression
//             CollectionAssert.AreEqual(_expectedRockets, _actualRockets); // Tests whether the specified collections have the same elements in the same order and quantity.
//             CollectionAssert.AreNotEqual(_expectedRockets, _actualRockets); // Tests whether the specified collections does not have the same elements or the elements are in a different order and quantity.
//             CollectionAssert.AreEquivalent(_expectedRockets, _actualRockets); // Tests whether two collections contain the same elements.
//             CollectionAssert.AreNotEquivalent(_expectedRockets, _actualRockets); // Tests whether two collections contain different elements.
//             CollectionAssert.AllItemsAreInstancesOfType(_expectedRockets, _actualRockets); // Tests whether all elements in the specified collection are instances of the expected type
//             CollectionAssert.AllItemsAreNotNull(_expectedRockets); // Tests whether all items in the specified collection are non-null
//             CollectionAssert.AllItemsAreUnique(_expectedRockets); // Tests whether all items in the specified collection are unique
//             CollectionAssert.Contains(_actualRockets, falcon9); // Tests whether the specified collection contains the specified element
//             CollectionAssert.DoesNotContain(_actualRockets, falcon9); // Tests whether the specified collection does not contain the specified element
//             CollectionAssert.IsSubsetOf(_expectedRockets, _actualRockets); // Tests whether one collection is a subset of another collection
//             CollectionAssert.IsNotSubsetOf(_expectedRockets, _actualRockets); // Tests whether one collection is not a subset of another collection
//             Assert.ThrowsException<ArgumentNullException>(() => new Regex(null)); // Tests whether the code specified by delegate throws exact given exception of type T
//         }
//
//         [DataRow(0, 0)]
//         [DataRow(1, 1)]
//         [DataRow(2, 1)]
//         [DataRow(80, 23416728348467685)]
//         [DataTestMethod]
//         public void GivenDataFibonacciReturnsResultsOk(int number, int result)
//         {
//             var fib = new Fib();
//             var actual = fib.Fibonacci(number);
//             Assert.AreEqual(result, actual);
//         }
//     }
// }