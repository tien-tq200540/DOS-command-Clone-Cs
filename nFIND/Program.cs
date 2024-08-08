namespace nFIND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string/paragraph you want to find: "); var inputString = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter the file path: "); var inputPath = Console.ReadLine();

            var inputFilePath = $"{inputPath}";

            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine($"File not found - {inputPath}");
            } else
            {
                var fileInfo = new FileInfo(inputFilePath);
                Console.WriteLine($"---------- {fileInfo.Name}");
                using var instream = fileInfo.OpenRead();
                using var streamRreader = new StreamReader(instream);
                var line = string.Empty;
                while ((line = streamRreader.ReadLine()) != null)
                {
                    if (line.Contains(inputString))
                    {
                        Console.WriteLine(line);
                    }
                }
            }  
        }
    }
}
