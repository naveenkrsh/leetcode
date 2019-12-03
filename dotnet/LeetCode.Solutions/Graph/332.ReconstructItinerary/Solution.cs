using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Graph.ReconstructItinerary
{
    public class Solution
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var graph = BuildGraph(tickets);

            var visted_itinerary = new HashSet<string>();

            var itinerary = new List<string>();
            List<List<string>> all_possiable_itr = new List<List<string>>();
            itinerary.Add("JFK");

            FindItineraryUtil("JFK", visted_itinerary, graph, itinerary, all_possiable_itr, tickets.Count);
            //all_possiable_itr = all_possiable_itr.OrderBy(s => string.Join(string.Empty, s)).ToList();
            return all_possiable_itr[0];
        }


        private void FindItineraryUtil(string source, HashSet<string> visted, Dictionary<string, List<string>> graph, List<string> itinerary, List<List<string>> all_possiable_itr, int total_ticket)
        {
            if (graph.ContainsKey(source))
            {
                foreach (var ticket_to in graph[source])
                {
                    var dest = ticket_to.Split("-")[0];
                    var itr = source + ticket_to;
                    if (!visted.Contains(itr))
                    {
                        itinerary.Add(dest);
                        visted.Add(itr);
                        if (visted.Count == total_ticket)
                        {
                            all_possiable_itr.Add(new List<string>(itinerary));
                        }

                        if (all_possiable_itr.Count > 0)
                            return;

                        FindItineraryUtil(dest, visted, graph, itinerary, all_possiable_itr, total_ticket);
                        //itinerary.Remove(dest);
                        itinerary.RemoveAt(itinerary.Count-1);
                        visted.Remove(itr);
                    }
                }
            }
        }

        private Dictionary<string, List<string>> BuildGraph(IList<IList<string>> tickets)
        {
            Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();

            Dictionary<string, int> multiple_ticket = new Dictionary<string, int>();

            foreach (var ticket in tickets)
            {
                var source = ticket[0];
                var dest = ticket[1];
                var itr = source + dest;
                if (!graph.ContainsKey(source))
                {
                    graph.Add(source, new List<string>());
                }
                if (!multiple_ticket.ContainsKey(itr))
                {
                    multiple_ticket.Add(itr, 0);
                }
                multiple_ticket[itr] = multiple_ticket[itr] + 1;
                graph[source].Add(dest + "-" + multiple_ticket[itr].ToString());
            }

            foreach (var v in graph)
            {
                v.Value.Sort();
            }
            return graph;
        }
    }
}
