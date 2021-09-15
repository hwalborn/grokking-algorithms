using System.Collections.Generic;

namespace grokking_algorithms.Classes
{
    public class GraphNode
    {
        public string Value { get; set; }
        public List<GraphNode> Neighbors { get; set; }
    }
}