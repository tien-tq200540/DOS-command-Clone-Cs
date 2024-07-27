namespace nTREE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path you want to see directory tree: "); var input = Console.ReadLine();
            var path = $"{input}";
            var directory = new DirectoryInfo(path);
            var dirInfo = directory.GetDirectories();

            Console.WriteLine($"{path[0]}{path[1]}.");
            foreach ( var dir in dirInfo )
            {
                PrintSubDirTree(dir, 0);
            }
        }

        static void PrintSubDirTree(DirectoryInfo? dir, int childSubOrder)
        {
            if (dir == null) return;

            for (int i = 1; i <= childSubOrder; i++) Console.Write("   ");
            Console.WriteLine($"|--{dir.Name}");
            var dirChild = dir.GetDirectories();
            if (dirChild != null )
            {
                foreach (var child in dirChild) PrintSubDirTree(child, childSubOrder + 1);
            }
        }
    }
}
