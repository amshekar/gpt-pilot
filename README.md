# gpt-pilot
Compare the gpt and co-pilot

### GPT Prompt 
//Generate an array of all the colors from the rainbow  and print out the colors  consider time and space complexity

### GPT Code
```
using System;

class Program
{
    static void Main()
    {
        string[] rainbowColors = GetRainbowColors();

        Console.WriteLine("Colors of the Rainbow:");

        foreach (string color in rainbowColors)
        {
            Console.WriteLine(color);
        }
    }

    static string[] GetRainbowColors()
    {
        string[] rainbowColors = new string[7]; // Array size is fixed

        rainbowColors[0] = "Red";
        rainbowColors[1] = "Orange";
        rainbowColors[2] = "Yellow";
        rainbowColors[3] = "Green";
        rainbowColors[4] = "Blue";
        rainbowColors[5] = "Indigo";
        rainbowColors[6] = "Violet";

        return rainbowColors;
    }
}
```


### co-pilot Prompt 
//Generate an array of all the colors from the rainbow  and print out the colors  consider time and space complexity
//Time complexity: O(1)
//Space complexity: O(1)
### co-pilot Code
```
using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static void Main()
    {
        string[] rainbow = new string[] { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
        Console.WriteLine(rainbow[0]);
        Console.WriteLine(rainbow[1]);
        Console.WriteLine(rainbow[2]);
        Console.WriteLine(rainbow[3]);
        Console.WriteLine(rainbow[4]);
        Console.WriteLine(rainbow[5]);
        Console.WriteLine(rainbow[6]);
    }
}
```
