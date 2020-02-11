using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiftTool;

namespace LiftTests
{
    [TestClass]
    public class ClassTests
    {
        int testStrength = 10;
        [TestMethod]
        public void HumanBody()
        {
            //Arrange
            HumanBody joe = new HumanBody(0);

            //Act
            joe.Traps.Strength = testStrength;

            //Assert
            Assert.AreEqual(joe.GetPhysicalScore(), testStrength/11);
        }
        [TestMethod]
        public void Lift()
        {
            //Arrange
            List<Muscle> testpressTargets = new List<Muscle>();
            Muscle testceps = new Muscle();
            testpressTargets.Add(testceps);
            int testplate = 45;
            Lift testPress = new Lift(testpressTargets, testplate);

            //Act
            testPress.Weight += 15;

            //Assert
            Assert.IsNotNull(testpressTargets[0]);
        }
        [TestMethod]
        public void Muscle()
        {
            //Arrange
            Muscle testceps = new Muscle();

            //Act
            testceps.Strength = testStrength;

            //Assert
            Assert.AreEqual(testceps.Strength, testStrength);
        }

    }
}
