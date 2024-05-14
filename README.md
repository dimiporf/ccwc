# WordCountApp (ccwc)

WordCountApp (ccwc) is a simple command-line utility written in C# that mimics the functionality of the `wc` (word count) command found in Unix-like systems. It counts the number of lines, words, bytes, and characters in a given text file.
The name ccwc stands for Coding Challenges Word Count, inspired by https://codingchallenges.fyi/challenges/challenge-wc

## Installation and Build

1. Ensure you have [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

2. Clone the repository:
   
   git clone https://github.com/yourusername/WordCountApp.git
   cd WordCountApp

3. Build the project:
  dotnet build


### Step 3: Usage Instructions

Provide clear usage instructions and examples for running `WordCountApp` with different command-line options.


## Usage

Run `WordCountApp` using the `dotnet run` command with the following syntax:


dotnet run -- [-c | -l | -w | -m] <path_to_file>

Examples:

Count bytes in a file:
dotnet run -- -c path/to/your/file.txt

Count lines in a file:
dotnet run -- -l path/to/your/file.txt

Count words in a file:
dotnet run -- -w path/to/your/file.txt

Count characters in a file:
dotnet run -- -m path/to/your/file.txt

Default (lines, words, and bytes):
dotnet run -- path/to/your/file.txt

Replace <path_to_file> with the path to the text file you want to analyze.


## Contributing

Contributions are welcome! Feel free to submit issues or pull requests.

## Author

- Dimitrios Porfyropoulos
- GitHub: [dimiporf](https://github.com/dimiporf)


## Acknowledgements

This project was inspired by the `wc` command in Unix-like systems.







