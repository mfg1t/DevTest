using System;
using System.IO;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //First check if there are any arguments entered
                if (args.Length == 0)
                {
                    Main(setArguments());
                }
                else
                {
                    //Added 1==1 as requirements say that file checking is not needed. This will force bypass
                    if (File.Exists($"{args[1]}") || 1 == 1)
                    {
                        //There should only ever be two arguments, if not then send them to set the values
                        if (args.Length != 2)
                        {
                            Console.WriteLine("Two arguments required. Please try again.");
                            Main(setArguments());
                        }
                        else
                        {
                            //So we have two arguments, just need to now execute correct method
                            if (args[0].fdVersionCheck())
                            {
                                Console.WriteLine($"Version: {new FileDetails().Version(args[1])}");
                            }
                            else if (args[0].fdSizeCheck())
                            {
                                Console.WriteLine($"Size: {new FileDetails().Size(args[1])}");
                            }
                            else
                            {
                                //If the first argument fails, it will print invalid and force the user to enter the arguments manually
                                Console.WriteLine("Invalid argument. Try again.");
                                Main(setArguments());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"The following error has occured: {e.Message}");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private static string[] setArguments()
        {
            try
            {
                //No arguments found, so lets set some
                string type = string.Empty;
                string filePath = string.Empty;

                //Give the user the options of what they can enter
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("Size (-s)  /  Version (-v)");
                //Set the type
                type = Console.ReadLine();
                //Check if the argument is valid by the extention method created in Extensions class
                while (!type.fdSizeCheck() && !type.fdVersionCheck())
                {
                    //If invalid, then let the user know it is incorrect and allow them to enter again
                    Console.WriteLine("Invalid input, please try again.");
                    type = Console.ReadLine();
                }
                Console.WriteLine("Now please specify the file (including path)");
                filePath = Console.ReadLine();
                return new string[] { type, filePath };
            }
            catch (Exception e)
            {
                Console.WriteLine($"The following error has occured: {e.Message}");
                Console.ReadLine();
                throw;
            }
        }
    }
}