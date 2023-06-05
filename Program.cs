using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("*********************************************************");
            /************************************************/
            //Initialize and Declare Variables
            string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\block";
            List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));
            int randomIndex;
            Random rnd = new Random();
            string original = "";
            string transfer = "";
            string temp1 = "temp1.png";
            string temp2 = "temp2.png";

            Console.WriteLine(dirs.Count);
            for (int shuffle = 0; shuffle < dirs.Count; shuffle++)
            {
                /************************************************/
                //Set random number and save original texture names
                randomIndex = rnd.Next(0, dirs.Count);
                original = Path.GetFileName(dirs[shuffle]);
                transfer = Path.GetFileName(dirs[randomIndex]);

                /************************************************/
                //Print out results and variables for debugging
                Console.WriteLine();
                Console.WriteLine(shuffle);
                Console.WriteLine();
                
                Console.WriteLine();
                Console.WriteLine(original);
                Console.WriteLine(transfer);
                Console.WriteLine();

                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine(dirs[shuffle]);
                Console.WriteLine(docPath + "\\" + temp1);
                Console.WriteLine();
                
                Console.WriteLine("*****");
                Console.WriteLine(dirs[randomIndex]);
                Console.WriteLine(docPath + "\\" + temp2);
                Console.WriteLine();

                /************************************************/
                //Change both selected files to temporary names
                System.IO.File.Move(dirs[shuffle], docPath + "\\" + temp1);
                System.IO.File.Move(dirs[randomIndex], docPath + "\\" + temp2);
                
                //Change both selected files to other texture's name
                System.IO.File.Move(docPath + "\\" + temp1, docPath + "\\" + transfer);
                System.IO.File.Move(docPath + "\\" + temp2, docPath + "\\" + original);
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Success!");
    }
}