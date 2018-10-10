﻿using System;
using System.Collections.Generic;
namespace Draw
{
	public class GridNode
	{
		private int x;
		private int y;
		private List<GridNode> childNodes = new List<GridNode>();

		public void GrindNode()
		{
		}

		public void setX(int x)
		{
			this.x = x;
		}

		public int getX()
		{
			return this.x;
		}

		public void setY(int y)
		{
			this.y = y;
		}

		public int getY()
		{
			return this.y;
		}

		public void addNode(GridNode node)
		{
			this.childNodes.Add(node);
		}

		public List<GridNode> getChildNodes()
		{
			return this.childNodes;
		}
	}
	public class GridMap
	{
		private Dictionary<int, List<GridNode>> grid = new Dictionary<int, List<GridNode>>();
		public GridMap()
		{
			this.fillMap();
		}

		public void fillMap()
		{
			for (int i = 5; i < 32; ++i)
			{
				if (i != 5 && i != 19)
				{
					continue;
				}
				List<GridNode> nodes = new List<GridNode>();
				int x = 0;
				int y = 0;
				for (int j = 0; j < i; ++j)
				{
					GridNode node = new GridNode();
					node.setX(0);
					node.setY(y);

					nodes.Add(node);
					y += 2;
				}
				switch (i)
				{
					case 5:
						GridNode node6 = new GridNode();
						node6.setX(1);
						//node6.setY(1);
						node6.addNode(nodes[0]);
						node6.addNode(nodes[1]);

						nodes.Add(node6);

						GridNode node7 = new GridNode();
						node7.setX(1);
						//node6.setY(7);
						node7.addNode(nodes[3]);
						node7.addNode(nodes[4]);

						nodes.Add(node7);

						GridNode node8 = new GridNode();
						node8.setX(2);
						//node6.setY(7);
						node8.addNode(node6);
						node8.addNode(nodes[2]);

						nodes.Add(node8);

						GridNode node9 = new GridNode();
						node9.setX(3);
						//node6.setY(7);
						node9.addNode(node8);
						node9.addNode(node7);

						nodes.Add(node9);

						GridNode node10 = new GridNode();
						node10.setX(4);
						//node6.setY(7);
						node10.addNode(node9);

						nodes.Add(node10);
						break;
                        case 19:
						GridNode node20 = new GridNode();
						node20.setX(1);
						node20.addNode(nodes[0]);
						node20.addNode(nodes[1]);
						nodes.Add(node20);
                        
                        GridNode node21 = new GridNode();
                        node21.setX(1);
                        node21.addNode(nodes[2]);
                        node21.addNode(nodes[3]);
                        nodes.Add(node21);
                        
                        GridNode node22 = new GridNode();
                        node22.setX(1);
                        node22.addNode(nodes[4]);
                        node22.addNode(nodes[5]);
                        nodes.Add(node22);
                        
                        GridNode node23 = new GridNode();
                        node23.setX(1);
                        node23.addNode(nodes[6]);
                        node23.addNode(nodes[7]);
                        nodes.Add(node23);
                        
                        GridNode node24 = new GridNode();
                        node24.setX(1);
                        node24.addNode(nodes[8]);
                        node24.addNode(nodes[9]);
                        nodes.Add(node24);
                        
                        GridNode node25 = new GridNode();
                        node25.setX(1);
                        node25.addNode(nodes[11]);
                        node25.addNode(nodes[12]);
                        nodes.Add(node25);
                        
                        GridNode node26 = new GridNode();
                        node26.setX(1);
                        node26.addNode(nodes[13]);
                        node26.addNode(nodes[14]);
                        nodes.Add(node26);
                        
                        GridNode node27 = new GridNode();
                        node27.setX(1);
                        node27.addNode(nodes[15]);
                        node27.addNode(nodes[16]);
                        nodes.Add(node27);
                        
                        GridNode node28 = new GridNode();
                        node28.setX(1);
                        node28.addNode(nodes[17]);
                        node28.addNode(nodes[18]);
                        nodes.Add(node28);
                        
                        GridNode node29 = new GridNode();
                        node29.setX(2);
                        node29.addNode(node23);
                        node29.addNode(node24);
                        nodes.Add(node29);
                        
                        GridNode node30 = new GridNode();
                        node30.setX(2);
                        node30.addNode(nodes[10]);
                        node30.addNode(node25);
                        nodes.Add(node30);
                        
                        GridNode node31 = new GridNode();
                        node31.setX(3);
                        node31.addNode(node20);
                        node31.addNode(node21);
                        nodes.Add(node31);
                        
                        GridNode node32 = new GridNode();
                        node32.setX(3);
                        node32.addNode(node22);
                        node32.addNode(node29);
                        nodes.Add(node32);
                        
                        GridNode node33 = new GridNode();
                        node33.setX(3);
                        node33.addNode(node30);
                        node33.addNode(node26);
                        nodes.Add(node33);
                        
                        GridNode node34 = new GridNode();
                        node34.setX(3);
                        node34.addNode(node27);
                        node34.addNode(node28);
                        nodes.Add(node34);
                        
                        GridNode node35 = new GridNode();
                        node35.setX(4);
                        node35.addNode(node31);
                        node35.addNode(node32);
                        nodes.Add(node35);
                        
                        GridNode node36 = new GridNode();
                        node36.setX(4);
                        node36.addNode(node33);
                        node36.addNode(node34);
                        nodes.Add(node36);
                        
                        GridNode node37 = new GridNode();
                        node37.setX(5);
                        node37.addNode(node35);
                        node37.addNode(node36);
                        nodes.Add(node37);

						GridNode node38 = new GridNode();
						node38.setX(6);
						node38.addNode(node37);
						nodes.Add(node38);
						break;
				}
				this.grid.Add(i, nodes);
			}
		}

		public List<GridNode> getMap(int count)
		{
			if (this.grid.ContainsKey(count))
			{
				foreach (GridNode node in this.grid[count])
				{
					if (node.getChildNodes().Count == 2)
					{
						node.setY((node.getChildNodes()[0].getY() + node.getChildNodes()[1].getY()) / 2);
					}
					else if (node.getChildNodes().Count == 1)
					{
						node.setY(node.getChildNodes()[0].getY());
					}
				}
				return this.grid[count];
			}
			else
			{
				return new List<GridNode>();
			}
		}
	}
}
