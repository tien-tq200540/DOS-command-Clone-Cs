namespace nTYPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path you want to read it's content (no double - quotes and file's name must be in English):"); var input = Console.ReadLine();
            var filePath = $"{input}";
            var fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                var fileLength = fileInfo.Length;
                const long fileSizeThreshold = 10 * 1024 * 1024; //File size threshold = 10MB
                if (fileLength < fileSizeThreshold)
                {
                    //If file size < 10MB, use File.ReadAllText method
                    var output = File.ReadAllText(filePath);
                    Console.WriteLine(output);
                } else
                {
                    //If not, use Stream, StreamReader and buffer for better efficiency
                    using var instream = fileInfo.OpenRead();
                    using var streamReader = new StreamReader(instream);

                    var buffer = new char[1024];
                    int bytesReadLen = streamReader.Read(buffer, 0, buffer.Length);
                    while (bytesReadLen > 0)
                    {
                        foreach (var c in buffer) { Console.Write(c); }
                        bytesReadLen = streamReader.Read(buffer, 0, buffer.Length);
                    }
                }
                
            } else
            {
                Console.WriteLine($"The file {filePath} does not exist.");
            }         
        }
    }
}
