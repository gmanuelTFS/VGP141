using System.Collections.Generic;

namespace VGP141_22S.DataStructures
{
	public class DirectedGraph<Data>
	{
		public class Node
		{
			public Data Data { get; }
			public List<Node> Incoming { get; } = new();
			public List<Node> Outgoing { get; } = new();
			
			public Node(Data data)
			{
				Data = data;
			}
		}
		
		private readonly List<Node> _nodes;

		public DirectedGraph()
		{
			_nodes = new List<Node>();
		}

		public DirectedGraph(IEnumerable<Data> pData)
		{
			_nodes = new List<Node>();
			foreach (Data data in pData)
			{
				AddNode(data);
			}
		}

		public Node AddNode(Data pData)
		{
			Node node = new(pData);

			_nodes.Add(node);
			
			return node;
		}

		public Node FindNode(Data pData)
		{
			foreach (Node t in _nodes)
			{
				if (t.Data.Equals(pData))
				{
					return t;
				}
			}

			return null;
		}

		public void AddEdge(Node pSrcNode, Node pDstNode)
		{
			if (pSrcNode == null || pDstNode == null)
			{
				return;
			}

			pSrcNode.Outgoing.Add(pDstNode);
			pDstNode.Incoming.Add(pSrcNode);
		}

		public void AddEdge(Data pSrc, Data pDst)
		{
			AddEdge(FindNode(pSrc), FindNode(pDst));
		}
	}
}
