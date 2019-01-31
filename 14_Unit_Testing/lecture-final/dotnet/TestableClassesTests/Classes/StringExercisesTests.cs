using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class StringExercisesTests
    {
        //Assert
        //.AreEqual() - compares expected and actual value for equality
        //.AreSame() - verifies two object variables refer to same object
        //.AreNotSame() - verifies two object variables refer to different objects
        //.Fail() - fails without checking conditions
        //.IsFalse()
        //.IsTrue()
        //.IsNotNull()
        //.IsNull()

        private StringExercises _exercises = new StringExercises();

        [TestMethod()]
        public void MakeAbbaTest()
        {
            Assert.AreEqual("HiByeByeHi", _exercises.MakeAbba("Hi", "Bye"), "Test 1: Input was \"Hi\", \"Bye\"");
            Assert.AreEqual("YoAliceAliceYo", _exercises.MakeAbba("Yo", "Alice"), "Test 2: Input was \"Yo\", \"Alice\"");
            Assert.AreEqual("WhatUpUpWhat", _exercises.MakeAbba("What", "Up"), "Test 3: Input was \"What\", \"Up\"");
        }

    }
}