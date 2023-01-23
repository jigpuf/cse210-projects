public class Scripture
{   private int _Index;
    private string[] _scriptures={
        "Moses_1:39 For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.",
        "Matthew_5:48 Be ye therefore perfect, even as your Father which is in heaven is perfect.",
        "3Nephi_27:19 And no unclean thing can enter into his kingdom; therefore nothing entereth into his rest save it be those who have washed their garments in my blood, because of their faith, and the repentance of all their sins, and their faithfulness unto the end."
    };


    public void SetActiveScripture()
    {        
        Random rnd = new Random();
        _Index =  rnd.Next(3);

    }
     public void WriteActiveScripturetoFile()
    {
        //write to file _sriptures[_index]
        using (StreamWriter outputFile = new StreamWriter("scripture.txt"))
        {
            outputFile.WriteLine($"{_scriptures[_Index]}");
        }
    }

}
