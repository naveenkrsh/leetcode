using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Graph.ReconstructItinerary;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LeetCode.Tests.Graph.ReconstructItinerary
{
    [TestClass]
    public class UnitTests
    {

        Solution sol;
        [TestInitialize]
        public void TestInit()
        {
            sol = new Solution();

        }

        [TestMethod]
        public void ShouldOutPutCorrectItineraryForSimplePlan()
        {
            //Input: [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]

            var input = new List<IList<string>>()
            {
                new List<string>(){ "MUC", "LHR" },
                new List<string>(){ "JFK", "MUC" },
                new List<string>(){ "SFO", "SJC" },
                new List<string>(){ "LHR", "SFO" }
            };


            var result = sol.FindItinerary(input);

            var expected = new List<string>() { "JFK", "MUC", "LHR", "SFO", "SJC" };

            CollectionAssert.AreEqual(expected, result as List<string>);

        }

        [TestMethod]
        public void ShouldOutPutCorrectItineraryForCyclicPlan()
        {
            //Input: [["JFK", "SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]

            var input = new List<IList<string>>()
            {
                new List<string>(){ "JFK", "SFO" },
                new List<string>(){ "JFK", "ATL" },
                new List<string>(){ "SFO", "ATL" },
                new List<string>(){ "ATL", "JFK" },
                new List<string>(){ "ATL", "SFO" }
            };


            var result = sol.FindItinerary(input);

            var expected = new List<string>() { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" };

            CollectionAssert.AreEqual(expected, result as List<string>);

        }


        [TestMethod]
        public void ShouldOutPutCorrectItineraryForTestCase1()
        {
            //Input: [["JFK","KUL"],["JFK","NRT"],["NRT","JFK"]]

            var input = new List<IList<string>>()
            {
                new List<string>(){ "JFK", "KUL" },
                new List<string>(){ "JFK", "NRT" },
                new List<string>(){ "NRT", "JFK" }
            };


            var result = sol.FindItinerary(input);

            var expected = new List<string>() { "JFK", "NRT", "JFK", "KUL" };

            CollectionAssert.AreEqual(expected, result as List<string>);

        }

        [TestMethod]
        public void ShouldOutPutCorrectItineraryForTestCase2()
        {
            //Input:  //[["EZE","AXA"],["TIA","ANU"],["ANU","JFK"],["JFK","ANU"],["ANU","EZE"],["TIA","ANU"],
            //["AXA","TIA"],["TIA","JFK"],["ANU","TIA"],["JFK","TIA"]]

            var input = new List<IList<string>>()
            {
                new List<string>(){ "EZE", "AXA" },
                new List<string>(){ "TIA", "ANU" },
                new List<string>(){ "ANU", "JFK" },

                new List<string>(){ "JFK","ANU" },
                new List<string>(){ "ANU","EZE" },
                new List<string>(){ "TIA","ANU" },

                new List<string>(){ "AXA","TIA" },
                new List<string>(){ "TIA","JFK" },
                new List<string>(){ "ANU","TIA" },
                new List<string>(){ "JFK", "TIA" }
            };


            var result = sol.FindItinerary(input);

            var expected = new List<string>() { "JFK", "ANU", "EZE", "AXA", "TIA", "ANU", "JFK", "TIA", "ANU", "TIA", "JFK"};

            CollectionAssert.AreEqual(expected, result as List<string>);

        }

        [TestMethod]
        public void ShouldOutPutCorrectItineraryForTestCase3()
        {
            //Input:  //[["EZE","AXA"],["TIA","ANU"],["ANU","JFK"],["JFK","ANU"],["ANU","EZE"],["TIA","ANU"],
            //["AXA","TIA"],["TIA","JFK"],["ANU","TIA"],["JFK","TIA"]]
            var inputString = "[[\"AXA\",\"EZE\"],[\"EZE\",\"AUA\"],[\"ADL\",\"JFK\"],[\"ADL\",\"TIA\"],[\"AUA\",\"AXA\"],[\"EZE\",\"TIA\"],[\"EZE\",\"TIA\"],[\"AXA\",\"EZE\"],[\"EZE\",\"ADL\"],[\"ANU\",\"EZE\"],[\"TIA\",\"EZE\"],[\"JFK\",\"ADL\"],[\"AUA\",\"JFK\"],[\"JFK\",\"EZE\"],[\"EZE\",\"ANU\"],[\"ADL\",\"AUA\"],[\"ANU\",\"AXA\"],[\"AXA\",\"ADL\"],[\"AUA\",\"JFK\"],[\"EZE\",\"ADL\"],[\"ANU\",\"TIA\"],[\"AUA\",\"JFK\"],[\"TIA\",\"JFK\"],[\"EZE\",\"AUA\"],[\"AXA\",\"EZE\"],[\"AUA\",\"ANU\"],[\"ADL\",\"AXA\"],[\"EZE\",\"ADL\"],[\"AUA\",\"ANU\"],[\"AXA\",\"EZE\"],[\"TIA\",\"AUA\"],[\"AXA\",\"EZE\"],[\"AUA\",\"SYD\"],[\"ADL\",\"JFK\"],[\"EZE\",\"AUA\"],[\"ADL\",\"ANU\"],[\"AUA\",\"TIA\"],[\"ADL\",\"EZE\"],[\"TIA\",\"JFK\"],[\"AXA\",\"ANU\"],[\"JFK\",\"AXA\"],[\"JFK\",\"ADL\"],[\"ADL\",\"EZE\"],[\"AXA\",\"TIA\"],[\"JFK\",\"AUA\"],[\"ADL\",\"EZE\"],[\"JFK\",\"ADL\"],[\"ADL\",\"AXA\"],[\"TIA\",\"AUA\"],[\"AXA\",\"JFK\"],[\"ADL\",\"AUA\"],[\"TIA\",\"JFK\"],[\"JFK\",\"ADL\"],[\"JFK\",\"ADL\"],[\"ANU\",\"AXA\"],[\"TIA\",\"AXA\"],[\"EZE\",\"JFK\"],[\"EZE\",\"AXA\"],[\"ADL\",\"TIA\"],[\"JFK\",\"AUA\"],[\"TIA\",\"EZE\"],[\"EZE\",\"ADL\"],[\"JFK\",\"ANU\"],[\"TIA\",\"AUA\"],[\"EZE\",\"ADL\"],[\"ADL\",\"JFK\"],[\"ANU\",\"AXA\"],[\"AUA\",\"AXA\"],[\"ANU\",\"EZE\"],[\"ADL\",\"AXA\"],[\"ANU\",\"AXA\"],[\"TIA\",\"ADL\"],[\"JFK\",\"ADL\"],[\"JFK\",\"TIA\"],[\"AUA\",\"ADL\"],[\"AUA\",\"TIA\"],[\"TIA\",\"JFK\"],[\"EZE\",\"JFK\"],[\"AUA\",\"ADL\"],[\"ADL\",\"AUA\"],[\"EZE\",\"ANU\"],[\"ADL\",\"ANU\"],[\"AUA\",\"AXA\"],[\"AXA\",\"TIA\"],[\"AXA\",\"TIA\"],[\"ADL\",\"AXA\"],[\"EZE\",\"AXA\"],[\"AXA\",\"JFK\"],[\"JFK\",\"AUA\"],[\"ANU\",\"ADL\"],[\"AXA\",\"TIA\"],[\"ANU\",\"AUA\"],[\"JFK\",\"EZE\"],[\"AXA\",\"ADL\"],[\"TIA\",\"EZE\"],[\"JFK\",\"AXA\"],[\"AXA\",\"ADL\"],[\"EZE\",\"AUA\"],[\"AXA\",\"ANU\"],[\"ADL\",\"EZE\"],[\"AUA\",\"EZE\"]]";
            var input = JsonConvert.DeserializeObject<List<IList<string>>>(inputString);


            var result = sol.FindItinerary(input);



            var expected = new List<string>() { "JFK", "ADL", "ANU", "ADL", "ANU", "AUA", "ADL", "AUA", "ADL", "AUA", "ANU", "AXA", "ADL", "AUA", "ANU", "AXA", "ADL", "AXA", "ADL", "AXA", "ANU", "AXA", "ANU", "AXA", "EZE", "ADL", "AXA", "EZE", "ADL", "AXA", "EZE", "ADL", "EZE", "ADL", "EZE", "ADL", "EZE", "ANU", "EZE", "ANU", "EZE", "AUA", "AXA", "EZE", "AUA", "AXA", "EZE", "AUA", "AXA", "JFK", "ADL", "EZE", "AUA", "EZE", "AXA", "JFK", "ADL", "JFK", "ADL", "JFK", "ADL", "JFK", "ADL", "TIA", "ADL", "TIA", "AUA", "JFK", "ANU", "TIA", "AUA", "JFK", "AUA", "JFK", "AUA", "TIA", "AUA", "TIA", "AXA", "TIA", "EZE", "AXA", "TIA", "EZE", "JFK", "AXA", "TIA", "EZE", "JFK", "AXA", "TIA", "JFK", "EZE", "TIA", "JFK", "EZE", "TIA", "JFK", "TIA", "JFK", "AUA", "SYD" };

            CollectionAssert.AreEqual(expected, result as List<string>);

        }
    }
}
