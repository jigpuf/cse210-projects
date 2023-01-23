using System.IO; 

public class Display
{   
   private string[] _ActiveText;
   private string[] _Words;
   public void SetActiveText(){
      string fileName="scripture.txt";
        _ActiveText = System.IO.File.ReadAllLines(fileName);
        _Words = _ActiveText[0].Split(' ');
        Console.Write(_ActiveText[0]);
   }
   public void ChangeActiveText(){
       int length = _Words.Length;
       Random rnd = new Random();
        int index =  rnd.Next(1,length);
        if (_Words[index]!="_"){
         _Words[index] = "_";
        } 
        else{
         while(_Words[index]=="_"){
            Random advance = new Random();
            index =  advance.Next(1,length);
        } 
         _Words[index] = "_";
        }
           
      foreach (string word in _Words){
                Console.Write($"{word} ");
            }

   }
}
