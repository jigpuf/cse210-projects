using System;

public class MediaType
{

    private string _mediaChoice = "0";
    public void DisplayChoices(){
            Console.Clear();
            Console.WriteLine("What kind of media:"); 
            Console.WriteLine("  1. Video");
            Console.WriteLine("  2. Talk");
            Console.WriteLine("  3. Music");
            Console.WriteLine("  4. Standup");
            Console.WriteLine("  5. Cool Website");
            Console.Write("Select a choice from the menu:");
            _mediaChoice = Console.ReadLine();
            switch(_mediaChoice){
                    case "1":    
                        Videos video = new Videos();
                        video.GetData("video");
                        break;
                     case "2":
                        Talks talk = new Talks();
                        talk.GetData("talk");
                        break;
                    case "3":
                        Music music = new Music();
                        music.GetData("music");
                       break;
                    case "4":
                        Standup standup = new Standup();
                        standup.GetData("standup routine");
                        break;
                    case "5":
                        CoolSites site = new CoolSites();
                        site.GetData("website");
                       break;
                    default:
                        Console.WriteLine("Pick a real number!!!");
                        break;
            }
    }
}