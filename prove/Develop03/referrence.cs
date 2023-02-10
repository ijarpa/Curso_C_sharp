using System;

public class ScriptureReference
{
    private string scripture;
    private string chapter;
    private string firstVerse;
    private string lastVerse;

    public ScriptureReference(string reference)
    {
        var parts = reference.Split(':', '-');
        scripture = parts[0];
        chapter = parts[1];
        firstVerse = parts[2];
        lastVerse = firstVerse;
    }

    public string ToString()
    {
        return $"{scripture} {chapter}:{firstVerse}";
    }
}
