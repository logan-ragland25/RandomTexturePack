using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        Randomize();
        Console.WriteLine("\nSucess!\n");
    }

    public static void Randomize()
    {
        RandomizeMost();
        RandomizeGUI();
        RandomizeMobs();
    }
    public static void RandomizeMost()
    {
        List<string> paths = new List<string>{"block", "environment", "item", "map", "misc", "mob_effect", "models\\armor", "painting", 
        "particle", "trims\\color_palettes", "trims\\items", "trims\\models\\armor"};
        int position = 0;
        while (position < paths.Count)
        {
            try
            {
                //Initialize and Declare Variables
                string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\" + paths[position];


                List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));
                int randomIndex;
                Random rnd = new Random();
                string original = "";
                string transfer = "";
                string temp1 = "temp1.png";
                string temp2 = "temp2.png";

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
            //Initialize and Declare Variables
            string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\gui\";

            List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));
            int randomIndex;
            Random rnd = new Random();
            string original = "";
            string transfer = "";
            string temp1 = "temp1.png";
            string temp2 = "temp2.png";

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
    } 
    public static void RandomizeGUIFolders()
    {
        List<string> paths = new List<string>{"advancements", "advancements\\backgrounds", "container", "container\\creative_inventory", "hanging_signs", "title", "title\\background"};
        int position = 0;
        while (position < paths.Count)
        {
            try
            {
                //Initialize and Declare Variables
                string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\gui\" + paths[position];

                List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));
                int randomIndex;
                Random rnd = new Random();
                string original = "";
                string transfer = "";
                string temp1 = "temp1.png";
                string temp2 = "temp2.png";

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
            position++;
        }
    }

    public static void RandomizeMobs()
    {
        /************************************************/
        //Initialize and Declare Variables
        string docPath = @"C:\Minecraft\TexturePacks\RandomTextures\assets\minecraft\textures\entity";

        //List of all folders to search
        List<string> folders = new List<string>(Directory.EnumerateDirectories(docPath));

        //List of the names of all folders
        List<string> names = new List<string>();
       
       //Stores random numbers and selected folder/file names
        int randomIndex;
        Random rnd = new Random();
        string folderName = "";
        string fileName = "";
        
        //Move all files from folders to entity directory
        for (int position = 0; position < folders.Count; position++)
        {
            //Set name of current folder
            folderName = Path.GetFileName(folders[position]);

            //List of files in folder
            List<string> filesInDir = new List<string>(Directory.EnumerateFiles(docPath + "\\" + folderName));

            //Add name of folder to name list
            names.Add(folderName);

            //Move every file in folder to entity directory
            for (int subposition = 0; subposition < filesInDir.Count; subposition++)
            {
                //Set current file
                fileName = Path.GetFileName(filesInDir[subposition]);

                //Moves current file to entity directory with the name of folder + '-' to distinguish origin folder
                System.IO.File.Move(filesInDir[subposition], docPath + "\\" + folderName + "-" + fileName);
            }
            
        }
        
        //Set variables for randomizing
        string original = "";
        string transfer = "";
        string temp1 = "temp1.png";
        string temp2 = "temp2.png";

        //Get list of all files in entity
        List<string> dirs = new List<string>(Directory.EnumerateFiles(docPath));

        //Go through every index for which there is a file and switch name with another file
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

            //Delete temp files so it does not error out
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
        
            //Delete temp files again for safety
            System.IO.File.Delete(docPath + "\\" + temp1);
            System.IO.File.Delete(docPath + "\\" + temp2);

            
        }
        
        //Set variables for returning to origin folder
        string folder = "";
        string currentFile = "";
        string postfix = "";
        int lengthOfPrefix;
        
        //List of all directories post change
        List<string> changedDirs = new List<string>(Directory.EnumerateFiles(docPath));

        //Go through every name in the name list and see if it matches the prefix of the file
        for (int position = 0; position < names.Count; position++)
        {
            //Set folder equal to the name of the folder at the current index
            folder = names[position];

            //Iterate through every directory
            for (int subposition = 0; subposition < changedDirs.Count; subposition++)
            {
                //Set current file
                currentFile = Path.GetFileName(changedDirs[subposition]);

                //Get length of string before the '-'
                lengthOfPrefix = currentFile.IndexOf("-");

                //If '=' is found
                if (lengthOfPrefix != -1)
                {
                    //If prefix == folder name
                    if (currentFile.Substring(0, lengthOfPrefix) == folder)
                    {
                        //set postfix
                        postfix = currentFile.Substring(lengthOfPrefix + 1);
                        System.IO.File.Move(docPath + "\\" + currentFile, docPath + "\\" + folder + "\\" + postfix);
                    }
                }
            }
        }
    }
}