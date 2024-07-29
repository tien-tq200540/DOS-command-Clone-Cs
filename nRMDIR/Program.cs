namespace nRMDIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the directory path to delete directory: "); var input = Console.ReadLine();
            var dirPath = $"{input}";
            if (Directory.Exists(dirPath))
            {
                Directory.Delete(dirPath, true);
                Console.WriteLine("Delete the directory successfully!");
            } else
            {
                Console.WriteLine($"The directory {dirPath} does not exists!");
            }
        }
    }
}
