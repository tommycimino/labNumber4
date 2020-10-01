using System;
using System.Collections.Generic;
using System.IO;


public class Value 
{
    public static int gemValue = 0;
    public static void StringValue(string userpath)
    {
        
        for (int i = 0; i < File.ReadAllText(userpath).Length; i++)
        {
            switch (userpath[i].ToString())
            {
                case "A":
                    gemValue += 1;
                    break;
                case "a":
                    gemValue += 1;
                    break;
                case "B":
                    gemValue += 2;
                    break;
                case "b":
                    gemValue += 2;
                    break;
                case "C":
                    gemValue += 3;
                    break;
                case "c":
                    gemValue += 3;
                    break;
                case "D":
                    gemValue += 4;
                    break;
                case "d":
                    gemValue += 4;
                    break;
                case "E":
                    gemValue += 5;
                    break;
                case "e":
                    gemValue += 5;
                    break;
                case "F":
                    gemValue += 6;
                    break;
                case "f":
                    gemValue += 6;
                    break;
                case "G":
                    gemValue += 7;
                    break;
                case "g":
                    gemValue += 7;
                    break;
                case "H":
                    gemValue += 8;
                    break;
                case "h":
                    gemValue += 8;
                    break;
                case "I":
                    gemValue += 9;
                    break;
                case "i":
                    gemValue += 9;
                    break;
                case "J":
                    gemValue += 10;
                    break;
                case "j":
                    gemValue += 10;
                    break;
                case "K":
                    gemValue += 11;
                    break;
                case "k":
                    gemValue += 11;
                    break;
                case "L":
                    gemValue += 12;
                    break;
                case "l":
                    gemValue += 12;
                    break;
                case "M":
                    gemValue += 13;
                    break;
                case "m":
                    gemValue += 13;
                    break;
                case "N":
                    gemValue += 14;
                    break;
                case "n":
                    gemValue += 14;
                    break;
                case "O":
                    gemValue += 15;
                    break;
                case "o":
                    gemValue += 15;
                    break;
                case "P":
                    gemValue += 16;
                    break;
                case "p":
                    gemValue += 16;
                    break;
                case "Q":
                    gemValue += 17;
                    break;
                case "q":
                    gemValue += 17;
                    break;
                case "R":
                    gemValue += 18;
                    break;
                case "r":
                    gemValue += 18;
                    break;
                case "S":
                    gemValue += 19;
                    break;
                case "s":
                    gemValue += 19;
                    break;
                case "T":
                    gemValue += 20;
                    break;
                case "t":
                    gemValue += 20;
                    break;
                case "U":
                    gemValue += 21;
                    break;
                case "u":
                    gemValue += 21;
                    break;
                case "V":
                    gemValue += 22;
                    break;
                case "v":
                    gemValue += 22;
                    break;
                case "W":
                    gemValue += 23;
                    break;
                case "w":
                    gemValue += 23;
                    break;
                case "X":
                    gemValue += 24;
                    break;
                case "x":
                    gemValue += 24;
                    break;
                case "Y":
                    gemValue += 25;
                    break;
                case "y":
                    gemValue += 25;
                    break;
                case "Z":
                    gemValue += 26;
                    break;
                case "z":
                    gemValue += 26;
                    break;
                default:
                    gemValue += 0;
                    break;
            }
        }
        Console.WriteLine("String Value: " + gemValue);
    }


}