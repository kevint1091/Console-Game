using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string keyPress, out int xChange, out int yChange)
        {
            // Changes position based on keypress
            xChange = 0;
            yChange = 0;

            switch (keyPress)
            {
                case "LeftArrow":
                    xChange -= 1;
                    yChange += 0;
                    break;
                case "RightArrow":
                    xChange += 1;
                    yChange += 0;
                    break;
                case "UpArrow":
                    xChange += 0;
                    yChange -= 1;
                    break;
                case "DownArrow":
                    xChange += 0;
                    yChange += 1;
                    break;
                case "Spacebar":
                    xChange += 0;
                    yChange += 0;
                    break;
                default:
                    xChange += 0;
                    yChange += 0;
                    break;
            }
        }

    public new static char UpdateCursor (string keyPress)
        {
            // Displays different sprite based off keypress
            char sprite;
            switch (keyPress)
            {
                case "LeftArrow":
                    sprite = '<';
                    break;
                case "RightArrow":
                    sprite = '>';
                    break;
                case "UpArrow":
                    sprite  = '^';
                    break;
                case "DownArrow":
                    sprite  = 'V';
                    break;
                default:
                    sprite = '<';
                    break;
            }
            return sprite;
        }

    public new static int KeepInBounds (int coord, int maxValue)
        {
            // Ensures player can't pass boundaries
            if (coord > maxValue)
            {
                return maxValue;
            } else if (coord < 0)
            {
                return 0;
            } else
            {
                return coord;
            }
            
        }

    public new static bool DidScore (int playerX, int playerY, int fruitX, int fruitY)
        {
            // If player is in the same coordinate as the fruit, returns true
            if (playerX == fruitX && playerY == fruitY)
            {
                //increase scoreboard here?
                return true;
            } else
            {
                return false;
            }
        }

  }
}