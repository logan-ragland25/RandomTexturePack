using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        /*TO DO:
            //Randomize Mobs, fonts
        */
        Randomize();
        RandomizeGUI();
    }

    public static void Randomize()
    {
        List<string> paths = new List<string>{"block", "environment", "item", "map", "misc", "mob_effect", "models\\armor", "painting", 
        "particle", "trims\\color_palettes", "trims\\items", "trims\\models\\armor"};
        int position = 0;
        while (position < paths.Count)
        {
            Console.WriteLine("Position: " + position);
            try
            {
                Console.WriteLine("*********************************************************");
                /************************************************/
                //Initialize and Declare Variables
                string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\" + paths[position];

                Console.WriteLine("DocPath: " + docPath);

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
                    while (randomIndex == shuffle)
                    {
                        randomIndex = rnd.Next(0, dirs.Count);
                    }
                    original = Path.GetFileName(dirs[shuffle]);
                    transfer = Path.GetFileName(dirs[randomIndex]);

                    /************************************************/
                    //Print out results and variables for debugging
                    Console.WriteLine();
                    Console.WriteLine("Position: " + shuffle);
                    Console.WriteLine();
                    
                    Console.WriteLine();
                    Console.WriteLine("File at Position: " + original);
                    Console.WriteLine("File to be Switched With: " + transfer);
                    Console.WriteLine();

                    Console.WriteLine("%%%%%%");
                    Console.WriteLine("Path to File at Position: " + dirs[shuffle]);
                    Console.WriteLine("Path to temp1 File: " + docPath + "\\" + temp1);
                    Console.WriteLine();
                    
                    Console.WriteLine("*****");
                    Console.WriteLine("Path to File at to be Switched: " + dirs[randomIndex]);
                    Console.WriteLine("Path to temp1 File: " + docPath + "\\" + temp2);
                    Console.WriteLine();

                    /************************************************/
                    System.IO.File.Delete(docPath + "\\" + temp1);
                    System.IO.File.Delete(docPath + "\\" + temp2);

                    //Make sure selected file is not a temp file
                    if (original.Equals("temp1.png") == false || transfer.Equals("temp2.png") == false)
                    {
                    //Change both selected files to temporary names
                    System.IO.File.Move(dirs[shuffle], docPath + "\\" + temp1);
                    System.IO.File.Move(dirs[randomIndex], docPath + "\\" + temp2);
                    
                    //Change both selected files to other texture's name
                    System.IO.File.Move(docPath + "\\" + temp1, docPath + "\\" + transfer);
                    System.IO.File.Move(docPath + "\\" + temp2, docPath + "\\" + original);  
                    }
                
                    System.IO.File.Delete(docPath + "\\" + temp1);
                    System.IO.File.Delete(docPath + "\\" + temp2);
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
            position++;
        }
    }

    public static void RandomizeGUI()
    {
        RandomizeGUIMain();
        RandomizeGUIFolders();
    }
    public static void RandomizeGUIMain()
    {
        try
        {
            Console.WriteLine("*********************************************************");
            /************************************************/
            //Initialize and Declare Variables
            string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\gui\";

            Console.WriteLine("DocPath: " + docPath);

            List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));
            int randomIndex;
            Random rnd = new Random();
            string original = "";
            string transfer = "";
            string temp1 = "temp1.png";
            string temp2 = "temp2.png";

            Console.WriteLine(dirs.Count);
            for (int shuffle = 5; shuffle < dirs.Count; shuffle++)
            {
                /************************************************/
                //Set random number and save original texture names
                randomIndex = rnd.Next(0, dirs.Count);
                while (randomIndex == shuffle)
                {
                    randomIndex = rnd.Next(0, dirs.Count);
                }
                original = Path.GetFileName(dirs[shuffle]);
                transfer = Path.GetFileName(dirs[randomIndex]);

                /************************************************/
                //Print out results and variables for debugging
                Console.WriteLine();
                Console.WriteLine("Position: " + shuffle);
                Console.WriteLine();
                
                Console.WriteLine();
                Console.WriteLine("File at Position: " + original);
                Console.WriteLine("File to be Switched With: " + transfer);
                Console.WriteLine();

                Console.WriteLine("%%%%%%");
                Console.WriteLine("Path to File at Position: " + dirs[shuffle]);
                Console.WriteLine("Path to temp1 File: " + docPath + "\\" + temp1);
                Console.WriteLine();
                
                Console.WriteLine("*****");
                Console.WriteLine("Path to File at to be Switched: " + dirs[randomIndex]);
                Console.WriteLine("Path to temp1 File: " + docPath + "\\" + temp2);
                Console.WriteLine();

                /************************************************/
                System.IO.File.Delete(docPath + "\\" + temp1);
                System.IO.File.Delete(docPath + "\\" + temp2);

                //Make sure selected file is not a temp file
                if (original.Equals("temp1.png") == false || transfer.Equals("temp2.png") == false)
                {
                //Change both selected files to temporary names
                System.IO.File.Move(dirs[shuffle], docPath + "\\" + temp1);
                System.IO.File.Move(dirs[randomIndex], docPath + "\\" + temp2);
                
                //Change both selected files to other texture's name
                System.IO.File.Move(docPath + "\\" + temp1, docPath + "\\" + transfer);
                System.IO.File.Move(docPath + "\\" + temp2, docPath + "\\" + original);  
                }
            
                System.IO.File.Delete(docPath + "\\" + temp1);
                System.IO.File.Delete(docPath + "\\" + temp2);
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

    public static void RandomizeGUIFolders()
    {
        List<string> paths = new List<string>{"advancements", "advancements\\backgrounds", "container", "container\\creative_inventory", "hanging_signs", "title", "title\\background"};
        int position = 0;
        while (position < paths.Count)
        {
            Console.WriteLine("Position: " + position);
            try
            {
                Console.WriteLine("*********************************************************");
                /************************************************/
                //Initialize and Declare Variables
                string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\gui\" + paths[position];

                Console.WriteLine("DocPath: " + docPath);

                List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));
                int randomIndex;
                Random rnd = new Random();
                string original = "";
                string transfer = "";
                string temp1 = "temp1.png";
                string temp2 = "temp2.png";

                Console.WriteLine(dirs.Count);
                int startPos;
                if (position != 2)
                {
                    startPos = 1;
                }
                else{
                    startPos = 0;
                }
                for (int shuffle = startPos; shuffle < dirs.Count; shuffle++)
                {
                    /************************************************/
                    //Set random number and save original texture names
                    randomIndex = rnd.Next(0, dirs.Count);
                    while (randomIndex == shuffle)
                    {
                        randomIndex = rnd.Next(0, dirs.Count);
                    }
                    original = Path.GetFileName(dirs[shuffle]);
                    transfer = Path.GetFileName(dirs[randomIndex]);

                    /************************************************/
                    //Print out results and variables for debugging
                    Console.WriteLine();
                    Console.WriteLine("Position: " + shuffle);
                    Console.WriteLine();
                    
                    Console.WriteLine();
                    Console.WriteLine("File at Position: " + original);
                    Console.WriteLine("File to be Switched With: " + transfer);
                    Console.WriteLine();

                    Console.WriteLine("%%%%%%");
                    Console.WriteLine("Path to File at Position: " + dirs[shuffle]);
                    Console.WriteLine("Path to temp1 File: " + docPath + "\\" + temp1);
                    Console.WriteLine();
                    
                    Console.WriteLine("*****");
                    Console.WriteLine("Path to File at to be Switched: " + dirs[randomIndex]);
                    Console.WriteLine("Path to temp1 File: " + docPath + "\\" + temp2);
                    Console.WriteLine();

                    /************************************************/
                    System.IO.File.Delete(docPath + "\\" + temp1);
                    System.IO.File.Delete(docPath + "\\" + temp2);

                    //Make sure selected file is not a temp file
                    if (original.Equals("temp1.png") == false || transfer.Equals("temp2.png") == false)
                    {
                    //Change both selected files to temporary names
                    System.IO.File.Move(dirs[shuffle], docPath + "\\" + temp1);
                    System.IO.File.Move(dirs[randomIndex], docPath + "\\" + temp2);
                    
                    //Change both selected files to other texture's name
                    System.IO.File.Move(docPath + "\\" + temp1, docPath + "\\" + transfer);
                    System.IO.File.Move(docPath + "\\" + temp2, docPath + "\\" + original);  
                    }
                
                    System.IO.File.Delete(docPath + "\\" + temp1);
                    System.IO.File.Delete(docPath + "\\" + temp2);
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
            position++;
        }
    }
}