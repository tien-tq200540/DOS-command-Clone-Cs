namespace nRENAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Note:
             * No extra whitespace at the beginning and end of the input string.
             * You cannot specify a new drive or path for the destination of a renamed file or directory.
             * For the new name:
                    * If you enter only a file name, the file's type will become 'File'.
                    * Enter full file name, such as newName.txt, if you want to formant the file's type.
            */
            Console.Write("Enter file or directory path: "); var pathInput = Console.ReadLine();
            Console.Write("Enter new name: "); var newNameInput = Console.ReadLine();

            var sourcePath = $"{pathInput}";
            var newName = $"{newNameInput}";

            var dirParentName = Path.GetDirectoryName(sourcePath) ?? "";
            var newNamePath = Path.Combine(dirParentName, newName);

            if (File.Exists(sourcePath))
            {
                Console.WriteLine("You enter a file path!");
                File.Move(sourcePath, newNamePath);
                Console.WriteLine("Rename file successfully!");

            } else if (Directory.Exists(sourcePath))
            {
                Console.WriteLine("You enter a directory path!");
                
                if (!string.IsNullOrEmpty(dirParentName))
                {
                    Directory.Move(sourcePath, newNamePath);
                    Console.WriteLine("Rename directory successfully!");
                } else
                {
                    Console.WriteLine($"The directory {sourcePath} cannot rename!");
                }
            } else
            {
                Console.WriteLine($"The file or directory {sourcePath} does not exist!");
            }
        }
    }
}
