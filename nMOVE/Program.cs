namespace nMOVE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the source path: "); var input1 = Console.ReadLine();
            Console.Write("Enter the destination path: "); var input2 = Console.ReadLine();

            var sourcePath = $"{input1}";
            var destPath = $"{input2}";

            var dirParentSourcePathName = Path.GetDirectoryName(sourcePath) ?? "";
            var dirParentDestPathName = Path.GetDirectoryName(destPath) ?? "";

            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destPath)) 
                {
                    Console.WriteLine("s");
                }

                //Cannot move or rename directory like C:\, ...
                if (string.IsNullOrEmpty(dirParentSourcePathName))
                {
                    Console.WriteLine($"The path {sourcePath} cannot move or rename!");
                    return;
                }

                if (string.IsNullOrEmpty(dirParentDestPathName))
                {
                    //Can only move a file or directory to root directory
                }
            } else if (File.Exists(sourcePath))
            {

            } else
            {
                Console.WriteLine($"The path {sourcePath} does not exist!");
            }
        }
    }
}
