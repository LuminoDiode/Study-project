using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Experementral
{
    public static void ToKick()
    {
        string[] input = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\names.txt").Split(Environment.NewLine);
        foreach (string s in input) Console.WriteLine(s);
        var ToKick = new List<string>();
        foreach (string s in input) if (s.Contains("неактив")) ToKick.Add(s.Substring(0, s.LastIndexOf('-') - 1));
        string outstr = "Кай Масскик ";
        foreach (string s in ToKick) outstr += "[" + s + "],";
        File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\out.txt", outstr);
        Console.ReadKey();
    }
}
