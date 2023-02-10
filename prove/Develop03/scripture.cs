using System.IO;
using System.Collections.Generic;

public class Scripture
{
    private static string scriptureText;
    private List<string> scriptureWords;

    public List<string> GetScriptureWords()
    {
        scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life\n";
        scriptureWords = scriptureText.Split(' ').ToList();

        return scriptureWords;
    }

}
