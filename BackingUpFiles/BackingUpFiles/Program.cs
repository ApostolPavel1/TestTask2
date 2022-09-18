using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{

    public static void CopyFilesAndDirs(string path)
    {
        try
        {
            string copyPath = Path.Combine(AppSettings.Target, path.Split('/').Last());

            Directory.CreateDirectory(copyPath);

            var allDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var dir in allDirectories)
            {
                CopyFilesAndDirs(dir);
            }

            var allFiles = Directory.GetFiles(path, ".", SearchOption.TopDirectoryOnly);

            foreach (var file in allFiles)
            {
                var fileBytes = File.ReadAllBytes(file);

                string fileCopyPath = Path.Combine(copyPath, file.Split(new char[] { '\\', '/' }).Last());

                File.WriteAllBytes(fileCopyPath, fileBytes);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static AppSettings AppSettings = JsonSerializer.Deserialize<AppSettings>(new StreamReader($"{Directory.GetCurrentDirectory().Split("bin").First()}/jsconfig1.json").ReadToEnd());




    static void Main()
    {
        string[] currentPath = AppSettings.Scope;

        foreach (var path in currentPath)
        {
            CopyFilesAndDirs(path);
        }
    }

}
public class AppSettings
{
    public string[] Scope { get; set; }
    public string Target { get; set; }
}