using System;
using System.Threading;
using System.Collections.Generic;


struct Rock
{
    public int x;
    public int y;
    public char c;
    public int density;
    public ConsoleColor color;
}

class FallingRocksGame
{
    static int playfieldWidth = 30;
    static string gameTitle = "FALLING ROCKS CONSOLE";
    static int playerPositionX = (playfieldWidth / 2) - 1;
    static int playerPositionY = Console.WindowHeight - 1;
    static string playerCharacter = "(O)";
    static bool playerAlive = true;
    static ConsoleColor[] rockColor = new ConsoleColor[]
    {
        ConsoleColor.Cyan,
        ConsoleColor.Magenta,
        ConsoleColor.Green,
        ConsoleColor.Blue
    };
    static char[] rockSymbols = new char[]
    {
        '^',
        '@',
        '*',
        '&',
        '+',
        '%',
        '$',
        '#',
        '!',
        '.',
        ';'
    };
    static int counter = 0;
    static int playerMaxLives = 3;
    static int lives = playerMaxLives;
    static int playerScore = 0;
    static List<Rock> rocks = new List<Rock>();
    static Random randomGenerator = new Random();

    static void DrawEngine(int x, int y, string s, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }

    static void DrawRocks(int x, int y, char c, int density, ConsoleColor color)
    {
        for (int i = x; i < x + density; i++)
        {
            Console.SetCursorPosition(i, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
    }

    static void DrawPlayfield()
    {
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            DrawEngine(playfieldWidth + 1, i, "|", ConsoleColor.Yellow);
        }

        DrawEngine(playfieldWidth + 2, 2, new string('-', Console.WindowWidth - (playfieldWidth + 2)), ConsoleColor.Yellow);
        DrawEngine((Console.WindowWidth - playfieldWidth), 1, gameTitle, ConsoleColor.Cyan);
        DrawEngine((Console.WindowWidth - playfieldWidth), 3, "Lives: " + lives, ConsoleColor.Cyan);
        DrawEngine((Console.WindowWidth - playfieldWidth), 4, "Score: " + playerScore, ConsoleColor.Cyan);
        //DrawEngine(playfieldWidth + 16, 15, "SPECIALLY FOR TANYA :*", ConsoleColor.Red);
    }

    static void MovePlayer()
    {
        ConsoleKeyInfo pressedKey = Console.ReadKey();

        while (Console.KeyAvailable)
        {
            Console.ReadKey();
        }

        if (pressedKey.Key == ConsoleKey.LeftArrow && playerPositionX != 0)
        {
            playerPositionX--;
        }

        if (pressedKey.Key == ConsoleKey.RightArrow && playerPositionX != (playfieldWidth - 2))
        {
            playerPositionX++;
        }
    }

    static void MoveRocks()
    {
        List<Rock> rocksMovement = new List<Rock>();

        for (int i = 0; i < rocks.Count; i++)
        {
            Rock movedRock = new Rock();
            if (rocks[i].y < Console.WindowHeight - 1)
            {
                movedRock = rocks[i];
                movedRock.y++;
                rocksMovement.Add(movedRock);
                if (movedRock.y == Console.WindowHeight - 1)
                {
                    if ((movedRock.x >= playerPositionX && movedRock.x <= playerPositionX + (playerCharacter.Length - 1))
                        || movedRock.x + (movedRock.density - 1) >= playerPositionX && movedRock.x + movedRock.density
                        <= playerPositionX + (playerCharacter.Length - 1))
                    {
                        playerAlive = false;
                    }
                }
            }
            else
            {
                rocksMovement.Remove(movedRock);
                playerScore += 10;
            }
        }
        rocks = rocksMovement;
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        Console.CursorVisible = false;

        int difficulty;
        string userInput;
        do
        {
            Console.WriteLine("Select difficulty from 5 to 1 (1 = verry hard, 5 = verry easy)");
            Console.Write("(Default is 2): ");
            userInput = Console.ReadLine();
        } while (!int.TryParse(userInput, out difficulty));

        switch (difficulty)
        {
            case 1:
                difficulty = 1;
                break;
            case 2:
                difficulty = 2;
                break;
            case 3:
                difficulty = 3;
                break;
            case 4:
                difficulty = 4;
                break;
            case 5:
                difficulty = 5;
                break;
            default:
                difficulty = 2;
                break;
        }

        do
        {
            Console.Write("How much lives do you want to have?: ");
        }
        while (!int.TryParse(Console.ReadLine(), out playerMaxLives));
        lives = playerMaxLives;

        while (true)
        {
            if (counter % difficulty == 0)
            {
                Rock newRock = new Rock();
                newRock.x = randomGenerator.Next(0, playfieldWidth + 1);
                newRock.y = 0;
                newRock.c = rockSymbols[randomGenerator.Next(0, rockSymbols.Length)];
                newRock.density = randomGenerator.Next(1, 4);
                if (newRock.x + newRock.density > playfieldWidth + 1)
                {
                    newRock.density = playfieldWidth - newRock.x;
                }
                newRock.color = rockColor[randomGenerator.Next(0, rockColor.Length)];
                rocks.Add(newRock);
                counter = 0;
            }

            foreach (Rock rock in rocks)
            {
                DrawRocks(rock.x, rock.y, rock.c, rock.density, rock.color);
            }
            DrawPlayfield();
            DrawEngine(playerPositionX, playerPositionY, playerCharacter, ConsoleColor.Red);
            MoveRocks();

            if (Console.KeyAvailable)
            {
                MovePlayer();
            }

            if (playerAlive == false)
            {
                lives--;

                if (lives == 0)
                {
                    DrawEngine(playfieldWidth + 10, 6, "You have no more lives left!", ConsoleColor.Red);
                    DrawEngine(playfieldWidth + 10, 7, "Press any key to restart...", ConsoleColor.Red);
                    Console.ReadKey();
                    lives = playerMaxLives;
                    playerScore = 0;
                }
                rocks.Clear();
                playerAlive = true;
            }

            counter++;
            Thread.Sleep(150);
            Console.Clear();
        }
    }

}