namespace nCOPY
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("No double-quote in path!");
            Console.Write("Enter the source file location: "); var input = Console.ReadLine();
            Console.Write("Enter the destination file location: "); var output = Console.ReadLine();
            var source = $"{input}";
            var dest = $"{output}";

            using var instream = File.OpenRead(source);
            using var outstream = File.OpenWrite(dest);

            if (instream != null)
            {
                var buffer = new byte[1024];
                int readLen = instream.Read(buffer, 0, buffer.Length);
                while (readLen > 0)
                {
                    outstream.Write(buffer, 0, readLen);
                    readLen = instream.Read(buffer, 0, buffer.Length);
                }

                Console.WriteLine("COPY Successfully!");
            } else
            {
                Console.WriteLine("Error! Source file doesn't exist");
            }
        }
    }
}
