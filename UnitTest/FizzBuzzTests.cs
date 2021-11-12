using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System.Collections.Generic;

namespace UnitTest 
{
    [TestClass]
    public class FizzBuzzTests : Worker
    {
        [TestMethod]
        public void GetListOfNumbersAndReplacementText_Divisor1AndDivisor2ReturnReplacement1ConcatWithReplacement2_ReturnTrue()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            worker.addUpperBound(userInput, 100);
            worker.addFirstDivisorAndReplacement(userInput, 3, "Foo");
            worker.addSecondDivisorAndReplacement(userInput, 5, "Bar");
            var Result = worker.getListOfNumbersAndReplacementText(userInput);
            // Assert
            Assert.IsTrue((Result.IndexOf("Foo") + 1) % 3 == 0 && (Result.IndexOf("Bar") + 1) % 5 == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void AddingUpperBoundUserObj_UpperBoundInputNotANumber_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            var result = worker.addUpperBound(userInput, Convert.ToInt32("h"));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingUpperBoundUserObj_UpperBoundInputIsLessThanOne_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            var result = worker.addUpperBound(userInput, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingUpperBoundUserObj_UpperBoundInputGreaterThanTenThousand_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            var result = worker.addUpperBound(userInput, 10001);
        }

        [TestMethod]
        public void AddingUpperBoundUserObj_UserInputObjIntMaxGetsAdded_ReturnTrue()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addUpperBound(userInput, 10000);
            // Assert
            Assert.IsTrue((int)userInput["intMax"] == 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void AddingFirstDivisorAndReplacement_FirstDivisorNotAString_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addFirstDivisorAndReplacement(userInput, Convert.ToInt32("H"), "Foo");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingFirstDivisorAndReplacement_ReplacementWordNotAnInt_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addFirstDivisorAndReplacement(userInput, 3, Convert.ToString(3));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingFirstDivisorAndReplacement_FirstDivisorLessThanOne_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addFirstDivisorAndReplacement(userInput, 0, "Foo");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingFirstDivisorAndReplacement_FirstDivisorGreaterThanUpperBound_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            worker.addUpperBound(userInput, 100);
            userInput = worker.addFirstDivisorAndReplacement(userInput, 101, "Foo");
        }

        [TestMethod]
        public void AddingFirstDivisorAndReplacement_UserInputObjsFirstDivisorAndFirstDivisorReplacementWordGetsAdded_ReturnsTrue()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            worker.addUpperBound(userInput, 100);
            userInput = worker.addFirstDivisorAndReplacement(userInput, 3, "Foo");
            // Assert
            Assert.IsTrue((int)userInput["firstDivisor"] == 3 && (string)userInput["firstDivisorReplacement"] == "Foo");
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void AddingSecondDivisorAndReplacement_SecondDivisorNotAString_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addSecondDivisorAndReplacement(userInput, Convert.ToInt32("H"), "Foo");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingSecondDivisorAndReplacement_ReplacementWordNotAnInt_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addSecondDivisorAndReplacement(userInput, 3, Convert.ToString(3));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingSecondDivisorAndReplacement_SecondDivisorLessThanOne_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            userInput = worker.addSecondDivisorAndReplacement(userInput, 0, "Bar");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void AddingSecondDivisorAndReplacement_SecondDivisorGreaterThanUpperBound_ExceptionIsThrown()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            worker.addUpperBound(userInput, 100);
            userInput = worker.addSecondDivisorAndReplacement(userInput, 101, "Bar");
        }

        [TestMethod]
        public void AddingSecondDivisorAndReplacement_UserInputObjsSecondDivisorAndSecondDivisorReplacementWordGetsAdded_ReturnsTrue()
        {
            // Arrange
            var worker = new Worker();
            Dictionary<string, object> userInput = new Dictionary<string, object>();
            // Act 
            worker.addUpperBound(userInput, 100);
            userInput = worker.addSecondDivisorAndReplacement(userInput, 5, "Bar");
            // Assert
            Assert.IsTrue((int)userInput["secondDivisor"] == 5 && (string)userInput["secondDivisorReplacement"] == "Bar");
        }
    }
}
