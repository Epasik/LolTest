using Labirint_Sharp;
using System;
namespace TestProject1
{
    public class Tests
    {
        class testing : Program.player
        {

            [Test]
            public void MoveW()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }
                test_igrok.current_player_pos.x = 2;
                test_igrok.current_player_pos.y = 2;


                test_igrok.movementPlayer(ConsoleKey.W, test_mazepol, test_igrok);

                int res = 0;
                if (test_igrok.current_player_pos.x == 1 && test_igrok.current_player_pos.y == 2)
                {
                    res = 1;
                }

                Assert.AreEqual(res, 1);
            }

            [Test]
            public void MoveD()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();
                char[,] maze = new char[11, 11];


                testing TestPlayer = new testing();

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            maze[i, j] = '#';
                        }
                        else maze[i, j] = ' ';
                    }
                }

                TestPlayer.current_player_pos.x = 2;
                TestPlayer.current_player_pos.y = 2;
                ConsoleKey key = ConsoleKey.D;

                TestPlayer.movementPlayer(key, maze, TestPlayer);
                int res = 0;
                if (TestPlayer.current_player_pos.x == 2 && TestPlayer.current_player_pos.y == 3)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }

            [Test]
            public void MoveS()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }

                test_igrok.current_player_pos.x = 2;
                test_igrok.current_player_pos.y = 2;
                ConsoleKey key = ConsoleKey.S;

                test_igrok.movementPlayer(key, test_mazepol, test_igrok);
                int res = 0;
                if (test_igrok.current_player_pos.x == 3 && test_igrok.current_player_pos.y == 2)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }

            [Test]
            public void MoveA()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }

                test_igrok.current_player_pos.x = 2;
                test_igrok.current_player_pos.y = 2;
                ConsoleKey key = ConsoleKey.A;

                test_igrok.movementPlayer(key, test_mazepol, test_igrok);
                int res = 0;
                if (test_igrok.current_player_pos.x == 2 && test_igrok.current_player_pos.y == 1)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }


            [Test]
            public void NegativeMovementW()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }

                test_igrok.current_player_pos.x = 1;
                test_igrok.current_player_pos.y = 1;
                ConsoleKey key = ConsoleKey.W;

                test_igrok.movementPlayer(key, test_mazepol, test_igrok);
                int res = 0;
                if (test_igrok.current_player_pos.x == 1 && test_igrok.current_player_pos.y == 1)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }

            [Test]
            public void NegativeMovementD()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }

                test_igrok.current_player_pos.x = 1;
                test_igrok.current_player_pos.y = 9;
                ConsoleKey key = ConsoleKey.D;

                test_igrok.movementPlayer(key, test_mazepol, test_igrok);
                int res = 0;
                if (test_igrok.current_player_pos.x == 1 && test_igrok.current_player_pos.y == 9)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }

            [Test]
            public void NegativeMovementS()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }

                test_igrok.current_player_pos.x = 9;
                test_igrok.current_player_pos.y = 9;
                ConsoleKey key = ConsoleKey.S;

                test_igrok.movementPlayer(key, test_mazepol, test_igrok);
                int res = 0;
                if (test_igrok.current_player_pos.x == 9 && test_igrok.current_player_pos.y == 9)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }

            [Test]
            public void NegativeMovementA()
            {
                char[,] test_mazepol = new char[11, 11];

                testing test_igrok = new testing();

                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (j == 0 || j == 10 || i == 0 || i == 10)
                        {
                            test_mazepol[i, j] = '#';
                        }
                        else test_mazepol[i, j] = ' ';
                    }
                }

                test_igrok.current_player_pos.x = 1;
                test_igrok.current_player_pos.y = 1;
                ConsoleKey key = ConsoleKey.A;

                test_igrok.movementPlayer(key, test_mazepol, test_igrok);
                int res = 0;
                if (test_igrok.current_player_pos.x == 1 && test_igrok.current_player_pos.y == 1)
                {
                    res = 1;
                }
                Assert.AreEqual(res, 1);
            }
        }

        public class MazeTesting : Program.Maze
        {
            [Test]
            public void init()
            {
                MazeTesting maze = new MazeTesting();

                char[,] mazeTrue =
                {
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                };

                char[,] mazeInit = new char[11, 11];
                maze.init(11, 11, mazeInit);
                bool res = true;
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (mazeInit[i, j] != mazeTrue[i, j])
                        {
                            res = false;
                        }
                    }
                }
                Assert.AreEqual(res, true);
            }

            [Test]
            public void initNegative()
            {
                MazeTesting maze = new MazeTesting();

                char[,] mazeNotTrue =
                {
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','#','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                        {'#','.','#','.','#','.','#','.','#','.','#'},
                        {'#','#','#','#','#','#','#','#','#','#','#'},
                };

                char[,] mazeInit = new char[11, 11];
                maze.init(11, 11, mazeInit);
                bool res = true;
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        if (mazeInit[i, j] != mazeNotTrue[i, j])
                        {
                            res = false;
                        }
                    }
                }
                Assert.AreEqual(res, false);
            }

            public class TestCellString : Program.cellString
            {
                [Test]
                public void test_RemoveWall()
                {


                    TestCellString cellString = new TestCellString();

                    Program.Cell firstCell = new Program.Cell();
                    Program.Cell secondCell = new Program.Cell();


                    char[,] maze =
                        {
                                    {'#','#','#','#','#','#','#','#','#','#','#'},
                                    {'#','.','#','.','#','.','#','.','#','.','#'},
                                    {'#','#','#','#','#','#','#','#','#','#','#'},
                                    {'#','.','#','.','#','.','#','.','#','.','#'},
                                    {'#','#','#','#','#','#','#','#','#','#','#'},
                                    {'#','.','#','.','#','.','#','.','#','.','#'},
                                    {'#','#','#','#','#','#','#','#','#','#','#'},
                                    {'#','.','#','.','#','.','#','.','#','.','#'},
                                    {'#','#','#','#','#','#','#','#','#','#','#'},
                                    {'#','.','#','.','#','.','#','.','#','.','#'},
                                    {'#','#','#','#','#','#','#','#','#','#','#'},

                            };

                    firstCell.x = 1;
                    firstCell.y = 1;

                    secondCell.x = 1;
                    secondCell.y = 3;

                    cellString.removeWall(firstCell, secondCell, maze);
                    bool res = false;
                    if (maze[2, 1] == ' ')
                        res = true;

                    Assert.AreEqual(res, true);

                }

                [Test]
                public void testNegative_RemoveWall()
                {


                    TestCellString cellString = new TestCellString();

                    Program.Cell firstCell = new Program.Cell();
                    Program.Cell secondCell = new Program.Cell();


                    char[,] maze =
                        {
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},

                                };

                    firstCell.x = 11;
                    firstCell.y = 1;

                    secondCell.x = 1;
                    secondCell.y = 3;
                    int res;
                    res = cellString.removeWall(firstCell, secondCell, maze);

                    Assert.AreEqual(res, -1);
                }

                [Test]
                public void test_GetNeighbours()
                {


                    TestCellString cellString = new TestCellString();

                    Program.cellString test = new Program.cellString();
                    Program.cellString test1 = new Program.cellString();

                    Program.Cell firstCell = new Program.Cell();
                    Program.Cell secondCell = new Program.Cell();
                    Program.Cell freeCell = new Program.Cell();


                    char[,] maze =
                        {
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},

                                };

                    firstCell.x = 1;
                    firstCell.y = 1;

                    secondCell.x = 1;
                    secondCell.y = 3;

                    freeCell.x = 3;
                    freeCell.y = 1;


                    test = cellString.getNeighbours(maze, firstCell);
                    test1.cells[0] = freeCell;
                    test1.cells[1] = secondCell;

                    bool res = true;

                    for (int i = 0; i < 2; i++)
                    {
                        if (test.cells[i].x != test1.cells[i].x || test.cells[i].y != test1.cells[i].y)
                        {
                            res = false;
                        }
                    }

                    if (test.size != 2)
                    {
                        res = false;
                    }

                    Assert.AreEqual(res, true);
                }

                [Test]
                public void testNegative_GetNeighbours()
                {
                    Program.cellString test = new Program.cellString();
                    Program.Cell firstCell = new Program.Cell();

                    char[,] maze =
                        {
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','#','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','#','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                };

                    firstCell.x = 1;
                    firstCell.y = 1;
                    test = getNeighbours(maze, firstCell);
                    bool res = true;
                    if (test.size != 0)
                    {
                        res = false;
                    }
                    Assert.AreEqual(res, true);
                }

                [Test]
                public void test_GenerateStep()
                {
                    TestCellString cellString = new TestCellString();

                    char[,] maze =
                        {
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},
                                        {'#','.','#','.','#','.','#','.','#','.','#'},
                                        {'#','#','#','#','#','#','#','#','#','#','#'},

                                };

                    cellString.generate_step(maze);
                    bool res = false;
                    if ((maze[1, 1] == ' ' && maze[1, 2] == ' ' && maze[1, 3] == ' ') || (maze[1, 1] == ' ' && maze[2, 1] == ' ' && maze[3, 1] == ' '))
                    {
                        res = true;
                    }
                    Assert.AreEqual(res, true);


                }


            }


        }

    }
}