namespace nDEL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path to delete: "); var input = Console.ReadLine();
            var filePath = $"{input}";
            
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Delete file successfully!");
            } else
            {
                Console.WriteLine($"The file {filePath} does not exist!");
            }
        }
    }
}
