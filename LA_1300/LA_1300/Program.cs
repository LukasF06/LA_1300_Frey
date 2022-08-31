using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LA_1300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hallo und willkommen zum Zahlenerrater!");
            Console.WriteLine();
            Console.WriteLine("Es gibt 2 Modi:");
            Console.WriteLine("1. Modus: Spieler errät die Zahl des Computers");
            Console.WriteLine("2. Modus: Computer errät die Zahl des Spielers");
            
            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Wählen Sie den Modus: [1/2]");
            Console.ForegroundColor= ConsoleColor.White;

            string choiceinput = Console.ReadLine();
            int choice = Convert.ToInt32(choiceinput);

            if (choice == 2)
            {   
                int tries2 = 0;
                ArrayList rndlist = new ArrayList();

                Console.WriteLine("");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Geben Sie eine Zahl ein, welche der Computer erraten muss und klicken Sie 'Enter', um zu starten:");
                Console.ForegroundColor= ConsoleColor.White;

                string input2 = Console.ReadLine();
                int usernumber2 = Convert.ToInt32(input2);

                while (true) { 
                if (usernumber2 >= 50)
                    {
                        Random highrd = new Random();
                        int highsecretnumber2 = highrd.Next(50, 100);
                        rndlist.Add(highsecretnumber2);
                        if (rndlist.Contains(highsecretnumber2))
                        {
                            Random newhighrd = new Random();
                            int newhighsecretnumber2 = newhighrd.Next(50, 100);
                            Console.WriteLine("Die geratene Zahl des Computers ist: "+newhighsecretnumber2);
                        } else
                        {
                            Console.WriteLine("Die geratene Zahl des Computers ist: "+highsecretnumber2);
                        }
                        

                    } else
                    {
                        Random lowrd = new Random();
                        int lowsecretnumber2 = lowrd.Next(1, 50);
                        Console.WriteLine("Die geratene Zahl des Computers ist: "+lowsecretnumber2);
                    }
                       
                tries2++;
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hat der Computer die Zahl erraten? [y/n]");
                Console.ForegroundColor= ConsoleColor.White;
                string response2 = Console.ReadLine();
                string yes = "y";

                    if (response2 == yes)
                    {   
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der Computer hat die Zahl erfolgreich erraten!");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Der Computer hat "+tries2+" Versuche gebraucht.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Möchten Sie nochmals eine Runde spielen?");
                        Console.WriteLine("Wenn JA geben Sie die nächste Zahl ein, wenn NEIN geben Sie 'n' ein:");
                        tries2= 0;  

                        string endresponse = Console.ReadLine();
                        string no = "n";
                        if (endresponse == no)
                        {
                            Environment.Exit(0);
                        }
                        
                    }
                }
            }
            
            while (true) {
                Console.WriteLine("");
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("Jetzt wird eine zufällige Zahl zwischen 1 und 100 generiert und ihr Ziel ist es, diese Zahl zu erraten.");
                Console.WriteLine("Jedes Mal, wenn Sie falsch liegen, bekommen Sie einen Tipp ;)");
                Console.WriteLine("");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Geben Sie eine Zahl ein und klicken Sie 'Enter', um zu starten:");
                Console.ForegroundColor= ConsoleColor.White;
                try {
                    string input = Console.ReadLine();
                    int usernumber = Convert.ToInt32(input);
                    
                    Random rd = new Random();
                    int secretnumber = rd.Next(1, 100);

                    int tries = 0;

                    while (usernumber != secretnumber)
                    {
                        if (usernumber > secretnumber)
                        {   
                            Console.ForegroundColor=ConsoleColor.Red;    
                            Console.WriteLine("Falsch! Die geratene Zahl ist grösser, als die Geheimzahl...");
                            Console.ForegroundColor=ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor=ConsoleColor.Red;
                            Console.WriteLine("Falsch! Die geratene Zahl ist kleiner, als die Geheimzahl...");
                            Console.ForegroundColor=ConsoleColor.White;
                        }

                        Console.WriteLine("Geben Sie eine neue Zahl ein:");
                        string newinput = Console.ReadLine();
                        int newusernumber = Convert.ToInt32(newinput);
                        usernumber = newusernumber;
                        tries++;
                    }
                    tries++;
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gut Gemacht!");
                    Console.WriteLine("Sie haben die Zahl erraten :)");
                    Console.WriteLine(" ");
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Sie haben " + tries + " Versuche gebraucht.");
                    Console.WriteLine(" ");
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.WriteLine("Möchten Sie nochmals eine Runde spielen? [y/n]");
                
                } catch(Exception)
                {   
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("Geben Sie eine gültige Zahl ein...");
                    Console.ForegroundColor= ConsoleColor.White;
                }

                try {
                    string response = Console.ReadLine();
                    string no = "n";

                    if (response == no)
                    {
                        Environment.Exit(0);
                    }
                    Console.Clear();
                } catch (Exception)
                {
                    Console.WriteLine("Bitte geben Sie eine gülte Antwort an...: [y/n]");
                    string response = Console.ReadLine();
                    string no = "n";

                    if (response == no)
                    {
                        Environment.Exit(0);
                    }
                    Console.Clear();
                }


            }   
        }
    }
}
