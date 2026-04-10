// See https://aka.ms/new-console-template for more information
const string filename = "result.txt";

const string dirname = "FileCollection";
if (Directory.Exists(dirname))
{
    string curpath = Directory.GetCurrentDirectory();
    Console.WriteLine(curpath);

}

try
{
    FileInfo fi = new FileInfo(filename);
    string fiExtension = fi.Extension;
    Console.WriteLine(fiExtension);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e}");
}

if (!File.Exists(filename))
{
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("~~~~ Results ~~~~");
    }
}

using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine($"Total files:");
    sw.WriteLine($"Excel counts:");
    sw.WriteLine($"Word counts:");
    sw.WriteLine($"PowerPoint counts:");
    sw.WriteLine("----------");
    sw.WriteLine($"Total size:");
    sw.WriteLine($"Excel size:");
    sw.WriteLine($"Word size:");
    sw.WriteLine($"PowerPoint size:");
}