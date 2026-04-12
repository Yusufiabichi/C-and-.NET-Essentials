// See https://aka.ms/new-console-template for more information

const string result = "result.txt";
const string folder = "FileCollection";

long DOCCount = 0, XLSCount = 0, PPTCount = 0;
long DOCSize = 0, XLSSize = 0, PPTSize = 0;
long TotalFiles = 0;
long TotalSize = 0;


bool isOfficeFile(string filename)
{
    if (filename.EndsWith(".xls") || filename.EndsWith(".docs") || filename.EndsWith(".ppt"))
        return true;
    return false;
}

DirectoryInfo di = new DirectoryInfo(folder);

foreach (FileInfo fi in di.EnumerateFiles())
{
    if (isOfficeFile(fi.Name))
    {
        TotalFiles++;
        TotalSize += fi.Length;
        if (fi.Name.EndsWith(".xls"))
        {
            XLSCount++;
            XLSSize += fi.Length;
        }
        if (fi.Name.EndsWith(".docs"))
        {
            DOCCount++;
            DOCSize += fi.Length;
        }
        if (fi.Name.EndsWith(".ppt"))
        {
            PPTCount++;
            PPTSize += fi.Length;
        }
    }
}

using (StreamWriter sw = File.CreateText(result))
{
    sw.WriteLine($"~~~~ Results ~~~~");
    sw.WriteLine($"Total files: {TotalFiles}");
    sw.WriteLine($"Excel counts: {XLSCount}");
    sw.WriteLine($"Word counts: {DOCCount}");
    sw.WriteLine($"PowerPoint counts: {PPTCount}");
    sw.WriteLine("----------");
    sw.WriteLine($"Total size: {TotalSize:N0}");
    sw.WriteLine($"Excel size: {XLSSize:N0}");
    sw.WriteLine($"Word size: {DOCSize:N0}");
    sw.WriteLine($"PowerPoint size: {PPTSize:N0}");
}