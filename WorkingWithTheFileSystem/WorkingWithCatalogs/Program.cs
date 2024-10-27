namespace WorkingWithCatalogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string dirName = @"C:\Users\dimba\source\repos";

            //if (Directory.Exists(dirName))
            //{
            //    Console.WriteLine("Подкаталоги: ");
            //    string[] dirs = Directory.GetDirectories(dirName);
            //    foreach (string dir in dirs)
            //        Console.WriteLine(dir);

            //    Console.WriteLine();
            //    Console.WriteLine("Files: ");
            //    string[] files = Directory.GetFiles(dirName);
            //    foreach (var item in files)                
            //        Console.WriteLine(item);

            //}

            //var directory = new DirectoryInfo(dirName);

            //if (directory.Exists)
            //{
            //    Console.WriteLine("Подкаталоги: ");
            //    DirectoryInfo[] dirs = directory.GetDirectories();
            //    foreach (DirectoryInfo dir in dirs)
            //        Console.WriteLine(dir);

            //    Console.WriteLine();
            //    Console.WriteLine("Files: ");
            //    FileInfo[] files = directory.GetFiles();
            //    foreach (FileInfo item in files)
            //        Console.WriteLine(item);
            //}





            //string dirName = @"C:\Users\dimba\source\repos";

            //string[] dirs = Directory.GetDirectories(dirName, "d*.");
            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //var dirInfo = new DirectoryInfo(dirName);
            //DirectoryInfo[] directoryInfo = dirInfo.GetDirectories("w*.");
            //foreach (var item in directoryInfo)
            //{
            //    Console.WriteLine(item);
            //}




            //string patch = @"C:\Users\dimba\source\repos";
            //string subpath = @"testVS2022";
            //DirectoryInfo directoryInfo = new DirectoryInfo(patch);

            //if (!directoryInfo.Exists)
            //{
            //    directoryInfo.Create();
            //}
            //directoryInfo.CreateSubdirectory(subpath);


            //patch = @"C:\Users\dimba\source\repos";
            //subpath = @"test";

            //if (!Directory.Exists(patch))
            //{
            //    Directory.CreateDirectory(patch);
            //}
            //Directory.CreateDirectory($"{patch}/{subpath}");





            //string patch = @"C:\Users\dimba\source\repos";

            //DirectoryInfo dirInfo = new(patch);
            //Console.WriteLine(dirInfo.Name);
            //Console.WriteLine(dirInfo.FullName);
            //Console.WriteLine(dirInfo.CreationTime);
            //Console.WriteLine(dirInfo.Root);






            //string patch = @"C:\Users\dimba\source\repos\test";
            //DirectoryInfo info = new(patch);
            //if (info.Exists)
            //{
            //    info.Delete();
            //    Console.WriteLine("delete");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exists");
            //}


            Console.WriteLine(Directory.GetCurrentDirectory());
        }
    }
}
