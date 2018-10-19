using System;
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
					case 20:
						GridNode node20_21 = new GridNode();
						node20_21.setX(1);
						node20_21.addNode(nodes[0]);
						node20_21.addNode(nodes[1]);
						nodes.Add(node20_21);

						GridNode node20_22 = new GridNode();
						node20_22.setX(1);
						node20_22.addNode(nodes[2]);
						node20_22.addNode(nodes[3]);
						nodes.Add(node20_22);

						GridNode node20_23 = new GridNode();
						node20_23.setX(1);
						node20_23.addNode(nodes[4]);
						node20_23.addNode(nodes[5]);
						nodes.Add(node20_23);

						GridNode node20_24 = new GridNode();
						node20_24.setX(1);
						node20_24.addNode(nodes[6]);
						node20_24.addNode(nodes[7]);
						nodes.Add(node20_24);

						GridNode node20_25 = new GridNode();
						node20_25.setX(1);
						node20_25.addNode(nodes[8]);
						node20_25.addNode(nodes[9]);
						nodes.Add(node20_25);

						GridNode node20_26 = new GridNode();
						node20_26.setX(1);
						node20_26.addNode(nodes[10]);
						node20_26.addNode(nodes[11]);
						nodes.Add(node20_26);

						GridNode node20_27 = new GridNode();
						node20_27.setX(1);
						node20_27.addNode(nodes[12]);
						node20_27.addNode(nodes[13]);
						nodes.Add(node20_27);

						GridNode node20_28 = new GridNode();
						node20_28.setX(1);
						node20_28.addNode(nodes[14]);
						node20_28.addNode(nodes[15]);
						nodes.Add(node20_28);

						GridNode node20_29 = new GridNode();
						node20_29.setX(1);
						node20_29.addNode(nodes[16]);
						node20_29.addNode(nodes[17]);
						nodes.Add(node20_29);

						GridNode node20_30 = new GridNode();
						node20_30.setX(1);
						node20_30.addNode(nodes[18]);
						node20_30.addNode(nodes[19]);
						nodes.Add(node20_30);

						GridNode node20_31 = new GridNode();
						node20_31.setX(2);
						node20_31.addNode(node20_24);
						node20_31.addNode(node20_25);
						nodes.Add(node20_31);

						GridNode node20_32 = new GridNode();
						node20_32.setX(2);
						node20_32.addNode(node20_26);
						node20_32.addNode(node20_27);
						nodes.Add(node20_32);

						GridNode node20_33 = new GridNode();
						node20_33.setX(3);
						node20_33.addNode(node20_21);
						node20_33.addNode(node20_22);
						nodes.Add(node20_33);

						GridNode node20_34 = new GridNode();
						node20_34.setX(3);
						node20_34.addNode(node20_23);
						node20_34.addNode(node20_31);
						nodes.Add(node20_34);

						GridNode node20_35 = new GridNode();
						node20_35.setX(3);
						node20_35.addNode(node20_32);
						node20_35.addNode(node20_28);
						nodes.Add(node20_35);

						GridNode node20_36 = new GridNode();
						node20_36.setX(3);
						node20_36.addNode(node20_29);
						node20_36.addNode(node20_30);
						nodes.Add(node20_36);

						GridNode node20_37 = new GridNode();
						node20_37.setX(4);
						node20_37.addNode(node20_33);
						node20_37.addNode(node20_34);
						nodes.Add(node20_37);

						GridNode node20_38 = new GridNode();
						node20_38.setX(4);
						node20_38.addNode(node20_35);
						node20_38.addNode(node20_36);
						nodes.Add(node20_38);

						GridNode node20_39 = new GridNode();
						node20_39.setX(5);
						node20_39.addNode(node20_37);
						node20_39.addNode(node20_38);
						nodes.Add(node20_39);

						GridNode node20_40 = new GridNode();
						node20_40.setX(6);
						node20_40.addNode(node20_39);
						nodes.Add(node20_40);
						break;
					case 21:
						this.addNode(1, nodes, 0, 1);//22
						this.addNode(1, nodes, 2, 3);//23
						this.addNode(1, nodes, 4, 5);//24
						this.addNode(1, nodes, 7, 8);//25
						this.addNode(1, nodes, 9, 10);//26
						this.addNode(1, nodes, 11, 12);//27
						this.addNode(1, nodes, 13, 14);//28
						this.addNode(1, nodes, 15, 16);//29
						this.addNode(1, nodes, 17, 18);//30
						this.addNode(1, nodes, 19, 20);//31
						this.addNode(2, nodes, 23, 6);//32
						this.addNode(2, nodes, 24, 25);//33
						this.addNode(2, nodes, 26, 27);//34
						this.addNode(3, nodes, 21, 22);//35
						this.addNode(3, nodes, 31, 32);//36
						this.addNode(3, nodes, 33, 28);//37
						this.addNode(3, nodes, 29, 30);//38
						this.addNode(4, nodes, 34, 35);//39
						this.addNode(4, nodes, 36, 37);//40
						this.addNode(5, nodes, 38, 39);//41
						this.addNode(6, nodes, 40);//42
						break;
					case 22:
						this.addNode(1, nodes, 0, 1);//23
						this.addNode(1, nodes, 2, 3);//24
						this.addNode(1, nodes, 4, 5);//25
						this.addNode(1, nodes, 7, 8);//26
						this.addNode(1, nodes, 9, 10);//27
						this.addNode(1, nodes, 11, 12);//28
						this.addNode(1, nodes, 13, 14);//29
						this.addNode(1, nodes, 16, 17);//30
						this.addNode(1, nodes, 18, 19);//31
						this.addNode(1, nodes, 20, 21);//32
						this.addNode(2, nodes, 24, 6);//33
						this.addNode(2, nodes, 25, 26);//34
						this.addNode(2, nodes, 27, 28);//35
						this.addNode(2, nodes, 15, 29);//36
						this.addNode(3, nodes, 22, 23);//37
						this.addNode(3, nodes, 32, 33);//38
						this.addNode(3, nodes, 34, 35);//39
						this.addNode(3, nodes, 30, 31);//40
						this.addNode(4, nodes, 36, 37);//41
						this.addNode(4, nodes, 38, 39);//42
						this.addNode(5, nodes, 40, 41);//43
						this.addNode(6, nodes, 42);//44
						break;
					case 23:
						this.addNode(1, nodes, 0, 1);//24
						this.addNode(1, nodes, 2, 3);//25
						this.addNode(1, nodes, 4, 5);//26
						this.addNode(1, nodes, 6, 7);//27
						this.addNode(1, nodes, 8, 9);//28
						this.addNode(1, nodes, 10, 11);//29
						this.addNode(1, nodes, 12, 13);//30
						this.addNode(1, nodes, 14, 15);//31
						this.addNode(1, nodes, 17, 18);//32
						this.addNode(1, nodes, 19, 20);//33
						this.addNode(1, nodes, 21, 22);//34
						this.addNode(2, nodes, 25, 26);//35
						this.addNode(2, nodes, 27, 28);//36
						this.addNode(2, nodes, 29, 30);//37
						this.addNode(2, nodes, 16, 31);//38
						this.addNode(3, nodes, 23, 24);//39
						this.addNode(3, nodes, 34, 35);//40
						this.addNode(3, nodes, 36, 37);//41
						this.addNode(3, nodes, 32, 33);//42
						this.addNode(4, nodes, 38, 39);//43
						this.addNode(4, nodes, 40, 41);//44
						this.addNode(5, nodes, 42, 43);//45
						this.addNode(6, nodes, 44);//46
						break;
					case 24:
						this.addNode(1, nodes, 0, 1);//25
						this.addNode(1, nodes, 2, 3);//26
						this.addNode(1, nodes, 4, 5);//27
						this.addNode(1, nodes, 6, 7);//28
						this.addNode(1, nodes, 8, 9);//29
						this.addNode(1, nodes, 10, 11);//30
						this.addNode(1, nodes, 12, 13);//31
						this.addNode(1, nodes, 14, 15);//32
						this.addNode(1, nodes, 16, 17);//33
						this.addNode(1, nodes, 18, 19);//34
						this.addNode(1, nodes, 20, 21);//35
						this.addNode(1, nodes, 22, 23);//36
						this.addNode(2, nodes, 26, 27);//37
						this.addNode(2, nodes, 28, 29);//38
						this.addNode(2, nodes, 30, 31);//39
						this.addNode(2, nodes, 32, 33);//40
						this.addNode(3, nodes, 24, 25);//41
						this.addNode(3, nodes, 36, 37);//42
						this.addNode(3, nodes, 38, 39);//43
						this.addNode(3, nodes, 34, 35);//44
						this.addNode(4, nodes, 40, 41);//45
						this.addNode(4, nodes, 42, 43);//46
						this.addNode(5, nodes, 44, 45);//47
						this.addNode(6, nodes, 46);//48
						break;
					case 25:
						this.addNode(1, nodes, 0, 1);//26
						this.addNode(1, nodes, 2, 3);//27
						this.addNode(1, nodes, 5, 6);//28
						this.addNode(1, nodes, 7, 8);//29
						this.addNode(1, nodes, 9, 10);//30
						this.addNode(1, nodes, 11, 12);//31
						this.addNode(1, nodes, 13, 14);//32
						this.addNode(1, nodes, 15, 16);//33
						this.addNode(1, nodes, 17, 18);//34
						this.addNode(1, nodes, 19, 20);//35
						this.addNode(1, nodes, 21, 22);//36
						this.addNode(1, nodes, 23, 24);//37
						this.addNode(2, nodes, 26, 4);//38
						this.addNode(2, nodes, 27, 28);//39
						this.addNode(2, nodes, 29, 30);//40
						this.addNode(2, nodes, 31, 32);//41
						this.addNode(2, nodes, 33, 34);//42
						this.addNode(3, nodes, 25, 37);//43
						this.addNode(3, nodes, 38, 39);//44
						this.addNode(3, nodes, 40, 41);//45
						this.addNode(3, nodes, 35, 36);//46
						this.addNode(4, nodes, 42, 43);//47
						this.addNode(4, nodes, 44, 45);//48
						this.addNode(5, nodes, 46, 47);//49
						this.addNode(6, nodes, 48);
						break;
					case 26:
						this.addNode(1, nodes, 0, 1);//27
						this.addNode(1, nodes, 2, 3);//28
						this.addNode(1, nodes, 5, 6);//29
						this.addNode(1, nodes, 7, 8);//30
						this.addNode(1, nodes, 9, 10);//31
						this.addNode(1, nodes, 11, 12);//32
						this.addNode(1, nodes, 13, 14);//33
						this.addNode(1, nodes, 15, 16);//34
						this.addNode(1, nodes, 17, 18);//35
						this.addNode(1, nodes, 19, 20);//36
						this.addNode(1, nodes, 22, 23);//37
						this.addNode(1, nodes, 24, 25);//38
						this.addNode(2, nodes, 27, 4);//39
						this.addNode(2, nodes, 28, 29);//40
						this.addNode(2, nodes, 30, 31);//41
						this.addNode(2, nodes, 32, 33);//42
						this.addNode(2, nodes, 34, 35);//43
						this.addNode(2, nodes, 21, 36);//44
						this.addNode(3, nodes, 26, 38);//45
						this.addNode(3, nodes, 39, 40);//46
						this.addNode(3, nodes, 41, 42);//47
						this.addNode(3, nodes, 43, 37);//48
						this.addNode(4, nodes, 44, 45);//49
						this.addNode(4, nodes, 46, 47);//50
						this.addNode(5, nodes, 48, 49);//51
						this.addNode(6, nodes, 50);
						break;
				}
				if (nodes.Count > i)
				{
					this.grid.Add(i, nodes);
				}
			}
		}

		private void addNode(int x, List<GridNode> nodes, int indexFirst, int indexSecond)
		{
			GridNode node = new GridNode();
			node.setX(x);
			node.addNode(nodes[indexFirst]);
			node.addNode(nodes[indexSecond]);
			nodes.Add(node);
		}

		private void addNode(int x, List<GridNode> nodes, int indexFirst)
		{
			GridNode node = new GridNode();
			node.setX(x);
			node.addNode(nodes[indexFirst]);
			nodes.Add(node);
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
