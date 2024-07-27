namespace nDIR
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the path: "); var input = Console.ReadLine();
            var path = $"{input}";
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                var dir = directory.GetFileSystemInfos();
                foreach (var dirInfo in dir)
                {
                    var lastWriteDate = dirInfo.LastWriteTime.ToString("MM/dd/yyyy");
                    var lastWriteTime = dirInfo.LastWriteTime.ToString("hh:mm");
                    var dirType = "";
                    var dirLength = "";
                    var dirName = dirInfo.Name;

                    if (dirInfo is DirectoryInfo)
                    {
                        dirType = "<DIR>";
                    }

                    if (dirInfo is FileInfo)
                    {
                        var dirFileInfo = (FileInfo)dirInfo;
                        dirLength = $"{dirFileInfo.Length.ToString("#,###")}";
                    }

                    Console.WriteLine($"{lastWriteDate}  {lastWriteTime}  {dirType} \t {dirLength} \t {dirName}");
                }
            } else
            {
                Console.WriteLine("Directory not found with this path");
            }
        }
    }
}
