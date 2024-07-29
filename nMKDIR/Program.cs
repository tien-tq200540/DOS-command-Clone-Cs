namespace nMKDIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the directory path to creat a new empty directory: "); var input = Console.ReadLine();
            var dirPath = $"{input}";
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("This directory already exists!");
            } else
            {
                Directory.CreateDirectory(dirPath);
                Console.WriteLine("Create a new empty directory successfully!");
            }
        }
    }
}
