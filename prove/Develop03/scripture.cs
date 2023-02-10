using System.IO;
using System.Collections.Generic;

public class Scripture
{
    private static string scriptureText;
    private List<string> scriptureWords;
    public Scripture(string scriptText)
    {
        scriptureText = scriptText;
        scriptureWords = scriptureText.Split(' ').ToList();
    }
    public List<string> GetScriptureWords()
    {
        return scriptureWords;
    }
}
