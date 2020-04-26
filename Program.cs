using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory_game_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // full the matrix
            Console.WriteLine("welcome to memory game!");
            int[,] matrix = new int[4, 4];
            Random cards = new Random();
            int couples = 8;
            int x = 0;
            int line = 0;
            int column = 0;
            for (int i = 1; i <= couples; i++)
            {
                while (x <= 1)
                {
                    line = cards.Next(0, 4);
                    column = cards.Next(0, 4);
                    if (matrix[line, column] == 0)
                    {
                        matrix[line, column] = i;
                    }
                    else
                    {
                        continue;
                    }
                    x++;
                }
                x = 0;
            }
            //players
            Console.WriteLine("please enter a player 1 name:");
            string player_1_name = Console.ReadLine();
            Console.WriteLine("please enter a player 2 name:");
            string player_2_name = Console.ReadLine();
            int player_1_points = 0;
            int player_2_points = 0;
            string board = "x";
            while (player_1_points + player_2_points < couples)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        if (matrix[j,y] != 0)
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(player_1_name + " now");
                Console.WriteLine(player_1_name + " enter a line number (0-3)");
                int player_1_line = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(player_1_name + " enter a column number (0-3)");
                int player_1_column = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        if (player_1_line == j && player_1_column == y)
                        {
                            board = Convert.ToString(matrix[player_1_line, player_1_column]);
                            Console.Write(board);
                        }
                        if (matrix[j, y] != 0 && player_1_line + player_1_column != j + y)
                        {
                            Console.Write("x");
                        }
                        else if (matrix[j,y] == 0)
                        {
                            Console.Write("0");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(player_1_name + " enter a line number (0-3)");
                int player_1_second_line = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(player_1_name + " enter a column number (0-3)");
                int player_1_second_column = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        if (player_1_second_line == j && player_1_second_column == y)
                        {
                            board = Convert.ToString(matrix[player_1_second_line, player_1_second_column]);
                            Console.Write(board);
                        }
                        if (matrix[j, y] != 0 && player_1_second_line +player_1_second_column != j + y)
                        {
                            Console.Write("x");
                        }
                        else if (matrix[j, y] == 0)
                        {
                            Console.Write("0");
                        }
                    }
                    Console.WriteLine();
                }
                if (matrix[player_1_line, player_1_column] == matrix[player_1_second_line, player_1_second_column])
                {
                    matrix[player_1_line, player_1_column] = 0;
                    matrix[player_1_second_line, player_1_second_column] = 0;
                    Console.WriteLine("well done " + player_1_name);
                    player_1_points++;
                    Console.WriteLine(player_1_name + ": " + player_1_points + " points");
                    Console.WriteLine(player_2_name + ": " + player_2_points + " points");
                    continue;
                }
                if (matrix[player_1_line, player_1_column] != matrix[player_1_second_line, player_1_second_column])
                {
                    Console.WriteLine("no match!");
                }
                while (matrix[player_1_line, player_1_column] != matrix[player_1_second_line, player_1_second_column])
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        for (int y = 0; y < matrix.GetLength(1); y++)
                        {
                            if (matrix[j, y] != 0)
                            {
                                Console.Write("x");
                            }
                            else
                            {
                                Console.Write("0");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(player_2_name + " now");
                    Console.WriteLine(player_2_name + " enter a line number (0-3)");
                    int player_2_line = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(player_2_name + " enter a column number (0-3)");
                    int player_2_column = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        for (int y = 0; y < matrix.GetLength(1); y++)
                        {
                            if (player_2_line == j && player_2_column == y)
                            {
                                board = Convert.ToString(matrix[player_2_line, player_2_column]);
                                Console.Write(board);
                            }
                            if (matrix[j, y] != 0 && player_2_line + player_2_column != j + y)
                            {
                                Console.Write("x");
                            }
                            else if (matrix[j, y] == 0)
                            {
                                Console.Write("0");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(player_2_name + " enter a line number (0-3)");
                    int player_2_second_line = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(player_2_name + " enter a column number (0-3)");
                    int player_2_second_column = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        for (int y = 0; y < matrix.GetLength(1); y++)
                        {
                            if (player_2_second_line == j && player_2_second_column == y)
                            {
                                board = Convert.ToString(matrix[player_2_second_line, player_2_second_column]);
                                Console.Write(board);
                            }
                            if (matrix[j, y] != 0 && player_2_second_line + player_2_second_column != j+y)
                            {
                                Console.Write("x");
                            }
                            else if (matrix[j, y] == 0)
                            {
                                Console.Write("0");
                            }
                        }
                        Console.WriteLine();
                    }
                    if (matrix[player_2_line, player_2_column] == matrix[player_2_second_line, player_2_second_column])
                    {
                        matrix[player_2_line, player_2_column] = 0;
                        matrix[player_2_second_line, player_2_second_column] = 0;
                        Console.WriteLine("well done " + player_2_name);
                        player_2_points++;
                        Console.WriteLine(player_1_name + ": " + player_1_points + " points");
                        Console.WriteLine(player_2_name + ": " + player_2_points + " points");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("no match!");
                        break;
                    }
                }
                if (player_1_points + player_2_points == couples)
                {
                    break;
                }
            }
            if (player_1_points > player_2_points)
            {
                Console.WriteLine(player_1_name + " points is: " + player_1_points);
                Console.WriteLine(player_2_name + " points is: " + player_2_points);
                Console.WriteLine(player_1_name + " won!");
            }
            else if (player_1_points < player_2_points)
            {
                Console.WriteLine(player_1_name + " points is: " + player_1_points);
                Console.WriteLine(player_2_name + " points is: " + player_2_points);
                Console.WriteLine(player_2_name + " won!");
            }
            else
            {
                Console.WriteLine(player_1_name + " points is: " + player_1_points);
                Console.WriteLine(player_2_name + " points is: " + player_2_points);
                Console.WriteLine("it's a tie!");
            }
        }
    }
}
