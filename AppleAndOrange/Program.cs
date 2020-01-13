using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        var startHouse = s;
        var endHouse = t;
        var appleTree = a;
        var orangesTree = b;
        var countApples = 0;
        var countOranges = 0;

        foreach (var applesPosition in apples)
        {
            int position = appleTree + applesPosition;
            if (position >= startHouse && position <= endHouse)
            {
                countApples++;
            }
        }

        foreach (var orangePosition in oranges)
        {
            int position = orangesTree + orangePosition;
            if (position <= endHouse && position >= startHouse)
            {
                countOranges++;
            }
        }
        Console.WriteLine(countApples);
        Console.WriteLine(countOranges);
    }
}