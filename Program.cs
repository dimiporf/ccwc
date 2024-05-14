using System;
using System.IO;
using System.Text;

namespace WordCountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ensure there are at least one or two arguments
            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("Usage: dimwc [-c | -l | -w | -m] <file>");
                return;
            }

            // Default file path and option
            string option = null;
            string filePath = null;

            // Handle different argument cases
            if (args.Length == 1)
            {
                // Only the file path is provided
                filePath = args[0];
            }
            else
            {
                // Both option and file path are provided
                option = args[0];
                filePath = args[1];
            }

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return;
            }

            try
            {
                // Read the file content
                byte[] fileBytes = File.ReadAllBytes(filePath);
                string text = Encoding.UTF8.GetString(fileBytes);

                // Process the text based on the specified option
                if (option == "-c")
                {
                    // Print the number of bytes
                    int byteCount = fileBytes.Length;
                    Console.WriteLine($"{byteCount,8} {filePath}");
                }
                else if (option == "-l")
                {
                    // Print the number of lines
                    int lineCount = text.Split('\n').Length;
                    Console.WriteLine($"{lineCount,8} {filePath}");
                }
                else if (option == "-w")
                {
                    // Print the number of words
                    int wordCount = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    Console.WriteLine($"{wordCount,8} {filePath}");
                }
                else if (option == "-m")
                {
                    // Print the number of characters
                    int charCount = text.Length;
                    Console.WriteLine($"{charCount,8} {filePath}");
                }
                else
                {
                    // Default case: Print lines, words, and bytes
                    int lineCount = text.Split('\n').Length;
                    int wordCount = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    int byteCount = fileBytes.Length;
                    Console.WriteLine($"{lineCount,8} {wordCount,8} {byteCount,8} {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
