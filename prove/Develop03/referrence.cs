using System;

public class ScriptureReference
{
    private string scripture;
    private string chapter;
    private string firstVerse;
    private string lastVerse;

    public ScriptureReference(string reference)
    {
        if (reference.Contains('-'))
        {
            var parts = reference.Split(' ', ':', '-');
            scripture = parts[0];
            chapter = parts[1];
            firstVerse = parts[2];
            lastVerse = parts[3];
        }
        else
        {
            var parts = reference.Split(' ', ':');
            scripture = parts[0];
            chapter = parts[1];
            firstVerse = parts[2];
            //lastVerse = parts[3];    
        }

    }

    public string GetScriptureReference()
    {
        if (string.IsNullOrEmpty(lastVerse))
        {
            return $"{scripture} {chapter}:{firstVerse}";
        }
        else
        {
            return $"{scripture} {chapter}:{firstVerse}-{lastVerse}";
        }
    }
}