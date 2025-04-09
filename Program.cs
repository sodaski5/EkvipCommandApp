using System;
using System.Collections.Generic;

/// <summary>
/// Entry piont of EkvipCommandApp. This manages the input parsing, command execution, and exception handling. 
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        int result;

        try
        {
            // Command Line Argument validation: single integer criteria must be met
            if (args.Length != 1 || !int.TryParse(args[0], out result))
            {
                Console.WriteLine("Please input a valid Integer eg. '3' as the start value.");
                return;
            }

            // record initialisation for setback operations
            PreceptRecord record = new PreceptRecord();

            while (true)
            {
                Console.Write("\nPlease input a precept (increment, decrement, double, randadd, undo): ");
                string preceptInput = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(preceptInput))
                {
                    Console.WriteLine("Kindly note that an empty input is not valid. Kindly provide a value.");
                    continue;
                }

                IPrecept precept = null;

                try
                {
                    switch (preceptInput)
                    {
                        case "increment":
                            precept = new AugmentPrecept();
                            break;
                        case "decrement":
                            precept = new DecrementPrecept();
                            break;
                        case "double":
                            precept = new DoublePrecept();
                            break;
                        case "randadd":
                            precept = new RandAddPrecept();
                            break;
                        case "undo":
                            if (record.CheckSetback)
                            {
                                IPrecept latestPrecept = record.Pop();
                                result = latestPrecept.Setback(result);
                                Console.WriteLine($"Undo successful. New value: {result}");
                            }
                            else
                            {
                                Console.WriteLine("No setback value available.");
                            }
                            continue; // skip record a 'setback' precept
                        default:
                            Console.WriteLine("Unknown Precept.");
                            continue;
                    }

                    // application of the selected precept to the actual result
                    result = precept.Run(result);

                    // record the precept for possible setback operations
                    record.Push(precept);
                    Console.WriteLine($"New value: {result}");
                }
                catch (Exception ex)
                {
                    // exception handling for errors cause by individaul precept executions
                    Console.WriteLine($"An error occured during execution of the precept. Error Details: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            // Catch-all: Universal error hadnling for the entire program
            Console.WriteLine($"Fatal Error: {ex.Message}");
            Console.WriteLine("Termination of Program ...");
        }
    }
}