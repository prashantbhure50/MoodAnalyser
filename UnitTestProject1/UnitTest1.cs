using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserCheck;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser("Sad");
            var result = moodanalyser.analyseMoodLive1();
            Assert.AreEqual(result, "SAD");
        }
        [TestMethod]
        public void TestMethod2()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser("I am in Sad Mood");
            var result = moodanalyser.analyseMoodLive1();
            Assert.AreEqual(result, "SAD");
        }
        [TestMethod]
        public void TestMethod3()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser("happy");
            var result = moodanalyser.analyseMoodLive1();
            Assert.AreEqual(result,"HAPPY");
        }
        [TestMethod]
        public void TestMethod4()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser();
            var result = moodanalyser.analyseMoodLive1();
            Assert.AreEqual(result, "SAD");
        }
        [TestMethod]
        public void TestMethod5()
        {
            MoodAnalyser moodanalyser = new MoodAnalyser("");
            var result = moodanalyser.analyseMoodLive1();
            Assert.AreEqual(result, "SAD");
        }
        [TestMethod]
        public void TestMethod6()
        {
            string message = null;
            object result = new MoodAnalyserFactory(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserCheck.MoodAnalyser", "MoodAnalyser");
            result.Equals(obj);


        }
        [TestMethod]
        public void TestMethod7()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserCheck.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }



    }
}