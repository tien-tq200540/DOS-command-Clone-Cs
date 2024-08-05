namespace nDIR
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the directory path: "); var input = Console.ReadLine();
            var path = $"{input}";
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                var fileSystems = directory.GetFileSystemInfos();
                foreach (var fileSys in fileSystems)
                {
                    var lastWriteDate = fileSys.LastWriteTime.ToString("MM/dd/yyyy");
                    var lastWriteTime = fileSys.LastWriteTime.ToString("hh:mm");
                    var fileSysType = "";
                    var fileSysLength = "";
                    var fileSysName = fileSys.Name;

                    if (fileSys is DirectoryInfo)
                    {
                        fileSysType = "<DIR>";
                    } else if (fileSys is FileInfo)
                    {
                        var fileInfo = (FileInfo)fileSys;
                        fileSysLength = $"{fileInfo.Length.ToString("#,###")}";
                    }

                    Console.WriteLine($"{lastWriteDate}  {lastWriteTime}  {fileSysType} \t {fileSysLength} \t {fileSysName}");
                }
            } else
            {
                Console.WriteLine("Directory not found with this path");
            }
        }
    }
}
