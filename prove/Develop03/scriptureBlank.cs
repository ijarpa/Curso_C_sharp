using System.IO;
using System.Collections.Generic;

public class HideWords
{
    private Scripture scriptureClass = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");
    private List<string> scriptureList;
    private List<string> hiddenWords;

    
    //Constructor
    public HideWords()
    {
        scriptureList = scriptureClass.GetScriptureWords(); //list of scripture words

        hiddenWords = new List<string>();

        foreach (var word in scriptureList)
        {
            int wordLength = word.Length;
            string hiddenWord = new string('_', wordLength);
            hiddenWords.Add(hiddenWord);
        }
    }

    public List<string> GetHiddenScripture()
    {
        return hiddenWords;
    }

}