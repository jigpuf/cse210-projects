using System.IO; 

public class Display
{   
   private string[] _activeText;
   private string[] _words;
   public void SetActiveText(){
      string fileName="scripture.txt";
        _activeText = System.IO.File.ReadAllLines(fileName);
        _words = _activeText[0].Split(' ');
        Console.Write(_activeText[0]);
   }
   public void ChangeActiveText(){
       int length = _words.Length;
       Random rnd = new Random();
        int index =  rnd.Next(1,length);
        if (_words[index]!="_"){
         _words[index] = "_";
        } 
        else{
         while(_words[index]=="_"){
            Random advance = new Random();
            index =  advance.Next(1,length);
        } 
        //Try for loop here that stops after 1000 attemps and ends program
         _words[index] = "_";
        }
           
      foreach (string word in _words){
                Console.Write($"{word} ");
            }

   }
}
