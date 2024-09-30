using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    

    public Journal()
    {
    }

    public void AddEntry(Entry newEntry)
    {
    }

    public void DisplayAll()
    {
        foreach (Entry entrys in _entries)
        {
            entrys.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {   
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public void LoadFromFile(string file)
    {

    }
    

    
    
}