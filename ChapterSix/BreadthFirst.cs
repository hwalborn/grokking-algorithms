using System;
using System.Collections.Generic;

namespace grokking_algorithms.ChapterSix
{
    public class BreadthFirst
    {
        private static Dictionary<string, List<string>> Graph => new Dictionary<string, List<string>>()
        {
            {"you", new List<string>() { "alice", "bob", "claire" }},
            {"bob", new List<string>() { "anuj", "peggy"}},
            {"alice", new List<string>() { "peggy"}},
            {"claire", new List<string>() { "thom", "jonny"}},
            {"anuj", new List<string>()},
            {"peggy", new List<string>()},
            {"thom", new List<string>()},
            {"jonny", new List<string>()},
        };

        public static bool Solution(string seller)
        {
            var searchQueue = new Queue<string>();
            EnqueueNeighbors(searchQueue, Graph["you"]);
            var notPersonOfInterest = new List<string>();
            while (searchQueue.Count != 0)
            {
                 var currentPerson = searchQueue.Dequeue();
                 if (notPersonOfInterest.Contains(currentPerson))
                 {
                     continue;
                 }
                 Console.WriteLine($"{currentPerson} searched in queue");
                 if (currentPerson == seller)
                 {
                     Console.WriteLine($"{seller} found in queue!");
                     return true;
                 }
                 notPersonOfInterest.Add(currentPerson);
                EnqueueNeighbors(searchQueue, Graph[currentPerson]);
            }
            return false;
        }

        private static void EnqueueNeighbors(Queue<string> searchQueue, List<string> vals)
        {
            vals.ForEach(val => searchQueue.Enqueue(val));
        }
    }
}