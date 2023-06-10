using System.Collections.Generic;
using VGP141_22S.DataStructures;

namespace VGP141_22S
{
    using BNode = DirectedGraph<BuildableData>.Node;
    public class TechTree
    {
        /// <summary>
        /// Holds the dependencies for each BuildableData
        /// </summary>
        private DirectedGraph<BuildableData> _dependencies;
        /// <summary>
        /// Tracks how many of each BuildableData is current in existence
        /// </summary>
        private Dictionary<BuildableData, uint> _buildCounts;

        public TechTree(IEnumerable<BuildableData> pBuildableData)
        {
            _dependencies = new DirectedGraph<BuildableData>(pBuildableData);
            _buildCounts = new Dictionary<BuildableData, uint>();
            
            // Nodes are created in the constructor above so all we need to do is create the edges
            //_dependencies.AddEdge();
        }

        // public bool buildStructure(BuildableData pBuildableData)
        // {
        //     
        // }
        //
        // public bool destroyStructure(BuildableData pBuildableData)
        // {
        //     
        // }
        //
        //
        // private bool checkDependencies(BNode node)
        // {
        //     
        // }

        private void printMissingDependencies(BNode node)
        {
            
        }
    }
}

