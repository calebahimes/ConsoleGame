using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ConsoleGame
{
    class ProgramUI
    {
        public void Run()
        {
            RunMenu();
        }
        string userName;
        public void RunMenu()
        {
            string title = @" _______         _______ ______  _ _______      _______ _______ _______ ________________
(  ____ \\     /(  ____ (  ___ \( |  ____ \    (  ____ (  ____ |  ____ (  ___  )__   __/
| (    \/ )   ( | (    \/ (   ) )/| (    \/    | (    \/ (    )| (    \/ (   ) |  ) (   
| |     | (___) | (__   | (__/ /  | (_____     | |     | (____)| (__   | (___) |  | |   
| | ____|  ___  |  __)  |  __ (   (_____  )    | | ____|     __)  __)  |  ___  |  | |   
| | \_  ) (   ) | (     | (  \ \        ) |    | | \_  ) (\ (  | (     | (   ) |  | |   
| (___) | )   ( | (____/\ )___) ) /\____) |    | (___) | ) \ \_| (____/\ )   ( |  | |   
(_______)/     \(_______// \___/  \_______)    (_______)/   \__(_______//     \|  )_(   
                                                                                        
       _______ ______          _______ _      _________        _______ _______          
      (  ___  |  __  \|\     /(  ____ ( (    /\__   __/\     /(  ____ |  ____ \         
      | (   ) | (  \  ) )   ( | (    \/  \  ( |  ) (  | )   ( | (    )| (    \/         
      | (___) | |   ) | |   | | (__   |   \ | |  | |  | |   | | (____)| (__             
      |  ___  | |   | ( (   ) )  __)  | (\ \) |  | |  | |   | |     __)  __)            
      | (   ) | |   ) |\ \_/ /| (     | | \   |  | |  | |   | | (\ (  | (               
      | )   ( | (__/  ) \   / | (____/\ )  \  |  | |  | (___) | ) \ \_| (____/\         
      |/     \(______/   \_/  (_______//    )_)  )_(  (_______)/   \__(_______/ ";
            Console.WriteLine(title);
            Console.ReadKey();

            Console.WriteLine("\n\nWelcome to Gheb's Great Adventure!\n" +
                "Gheb needs YOUR help to get through his most important mission yet.\n" +
                "But first, Gheb needs to know what to call you..\n" +
                "\n" +
                "Please enter your name.");
            userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine($"\n\n{userName}, huh? Mmm... yeah I think Gheb likes that name.\n" +
                $"Consider yourself lucky. Gheb doesn't take a liking to just anybody.");
            Console.ReadKey();
            Console.WriteLine("Oh, there's Gheb now! He's actually... running over here. Gheb never runs.. \n" +
                "Uhoh.. Brace for impact!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine($"\n\nAs Gheb finally nears the end of his sprint toward you, he trips on himself in front of you.\n" +
                $"He pulls himself off the ground using his giant Killer Axe as leverage..\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine($"\n\nHar har har! Did I hear yur name is {userName}??!\n" +
                $"irlylikeurname!\n" +
                $"But nevermind that. We have a long journey ahead of us!");
            Console.ReadKey();
            Console.WriteLine("My brother Zagan was on his way back to our gr8 and huge home at Fort Rigwald when mah minion Narshen\n" +
                "intercepted him and (for some reason) captured him and (somehow) was able to lug him off to his smaller and\n" +
                "nowhere near as cool fort that he unoriginally named Fort Narshen.");
            Console.ReadKey();
            Console.WriteLine("\nCan you believe that??! He ACTUALLY named his fort after his first name!\n" +
                "What an utter loser! Who names a fort such a dumb name?!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine($"\n\nAnyway, we gotta get going. We have to rescue Zagan and smash the traitor Narshen with my giant Killer Axe!\n" +
                $"Let's go {userName}!\n" +
                $"Gheb charges off outside the entrance to Fort Rigwald..");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine("\n\nYou stand there still stunned at all of the things you just witnessed, but agree to go along with Gheb.\n" +
                "You don't want to get smashed by his giant Killer Axe in Narshen's stead!");
            Console.ReadKey();
            RunGame();
        }

        public void RunGame()
        {
            Console.Clear();
            Console.WriteLine("Let's begin Gheb's Adventure!\n" +
                "Throughout the game, as you and Gheb move along you will come across Narshen's minions\n" +
                "They are prepared (although also scared) to impede Gheb's advance.\n" +
                "But nobody stops Gheb. Except Gheb himself. You will learn this soon.\n");
            Console.ReadKey();
            Console.WriteLine("Gheb: Narshen's minions are mere fodder. CHARRRRRRRGE!!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Alright. It appears that Gheb has laid his eyes on his first victim.\n" +
                "Let's use this opportunity for you to learn the menu.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Gheb: Arrrrg! You dare block the path to Zagan, scrub?!");
            Console.ReadKey();
            Console.WriteLine("Minion of Narshen: Uhhhhh...... Narshen never told us how big Gheb's axe was...\n" +
                "*The Minion of Narshen visibly trembles*");
            Console.ReadKey();
            Tutorial();
        }

        public void Tutorial()
        {
            Gheb gheb = new Gheb();
            bool continueToRun = true;
            Console.WriteLine("Below is your Gheb Menu. This displays your options when facing an enemy.\n\n");
            Console.WriteLine("Alright, first lets demonstrate what happens when you convince Gheb to use his Iron Axe\n" +
                " instead of his super awesome Killer Axe.\n" +
                "Please enter '2' to select Gheb's Iron Axe.");
            while (continueToRun)
            {
                if (gheb.HP > 0)
                {
                    Console.WriteLine($"HP: {gheb.HP}");
                    Console.WriteLine("Items:");
                    gheb.DisplayItems();
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "2":
                            Console.Clear();
                            gheb.HP -= 20;
                            Console.WriteLine("Gheb attacks the Minion of Narshen with his Iron Axe and immediately regrets his decision.\n" +
                                "Gheb overswings the puny Iron Axe, missing his target entirely.\n" +
                                "Gheb gets stabbed by the Minion of Narshen.");
                            Console.ReadKey();
                            Console.WriteLine("Gheb: ARRGGGGGGG *Visible Gheb Pain*\n" +
                                "Gheb: I knew I should've used my Killer Axe! Why did I ever listen to you?!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Gheb is probably pretty hungry for some crumpets after that.\n" +
                                "Let's heal Gheb up! This time, select 3 to choose 'Crumpets'.");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Clear();
                            gheb.HP -= 20;
                            Console.WriteLine("Gheb overheard us talking about how he should use his Iron Axe this time.\n" +
                                "Gheb thought to himself:\n" +
                                "'I heard them talking about how I should smash him with my Iron Axe..'\n" +
                                $"Gheb: {userName}, are you tryin to trick meh?!");
                            Console.ReadKey();
                            Console.WriteLine("Gheb attacks the Minion of Narshen with his Iron Axe and immediately regrets his decision.\n" +
                                "Gheb overswings the puny Iron Axe, missing his target entirely.\n" +
                                "Gheb gets stabbed by the Minion of Narshen.");
                            Console.ReadKey();
                            Console.WriteLine("Gheb: ARRGGGGGGG *Visible Gheb Pain*\n" +
                                "Gheb: I knew I should've used my Killer Axe! Why did I ever listen to you?!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Gheb is probably pretty hungry for some crumpets after that.\n" +
                                "Let's heal Gheb up! This time, select 3 to choose 'Crumpets'.");
                            Console.ReadKey();
                            break;
                    }
                    Console.WriteLine($"HP: {gheb.HP}");
                    Console.WriteLine("Items:");
                    gheb.DisplayItems();
                    string userInputTwo = Console.ReadLine();

                    switch (userInputTwo)
                    {
                        case "3":
                            Console.Clear();
                            gheb.HP += 10;
                            Console.WriteLine("Gheb: Ahhhh.. Crumpets. Beautiful tasty Crumpets.\n" +
                                $"You are redeemed in my eyes {userName}.");
                            Console.ReadKey();
                            Console.WriteLine("Minion of Narshen: Is.. is he stopping to eat Crumpets?\n" +
                                "In the middle of an armed battle?????\n" +
                                "I guess it'd be rude to interrupt..\n");
                            Console.ReadKey();
                            Console.WriteLine("(Normally a Minion of Narshen won't be so considerate.)");
                            Console.ReadKey();
                            Console.WriteLine("Gheb's HP rises by 10.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Let's just go ahead and finish off this Minion.\n" +
                                "His consideration for Gheb's meal shall be his undoing.\n" +
                                "This time, select '1' for Gheb to smash him with his Killer Axe.");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Clear();
                            gheb.HP += 10;
                            Console.WriteLine("Gheb is very hungry for some Crumpets and has ignored you.\n" +
                                "Rejoice that he did not turn his axe on you for such a foolish choice.\n");
                            Console.ReadKey();
                            Console.WriteLine("Gheb: Ahhhh.. Crumpets. Beautiful tasty Crumpets.\n");
                            Console.ReadKey();
                            Console.WriteLine("Minion of Narshen: Is.. is he stopping to eat Crumpets?\n" +
                                "In the middle of an armed battle?????\n" +
                                "I guess it'd be rude to interrupt..\n");
                            Console.ReadKey();
                            Console.WriteLine("(Normally a Minion of Narshen won't be so considerate.)");
                            Console.ReadKey();
                            Console.WriteLine("Gheb's HP rises by 10.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Let's just go ahead and finish off this Minion.\n" +
                                "His consideration for Gheb's meal shall be his undoing.\n" +
                                "This time, select '1' for Gheb to smash him with his Killer Axe.");
                            Console.ReadKey();
                            break;
                    }
                    Console.WriteLine($"HP: {gheb.HP}");
                    Console.WriteLine("Items:");
                    gheb.DisplayItems();

                    string userInputThree = Console.ReadLine();
                    switch (userInputThree)
                    {
                        case "1":
                            Console.WriteLine("Gheb: I should've done this all along!!!\n" +
                                "Gheb spins around and jumps in the air.\n" +
                                "He lands with his Killer Axe planted in the Minion of Narshen's head.");
                            Console.ReadKey();
                            Console.WriteLine("Minion of Narshen: ...... *Visible Death*");
                            Console.ReadKey();
                            continueToRun = false;
                            break;
                        default:
                            Console.WriteLine("Gheb glares violently in your direction and grasps his Killer Axe.\n" +
                                $"Gheb: {userName}, yur really dumb.\n");
                            Console.ReadKey();
                            Console.WriteLine("Gheb spins around and jumps in the air.\n" +
                            "He lands with his Killer Axe planted in the Minion of Narshen's head.");
                            Console.ReadKey();
                            Console.WriteLine("Minion of Narshen: ...... *Visible Death*");
                            Console.ReadKey();
                            continueToRun = false;
                            break;
                    }

                }
                else if (gheb.HP <= 0)
                {
                    GameOver();
                }
            }
            LevelOne();
        }

        public void GameOver()
        {

        }

        public void LevelOne()
        {
            Console.Clear();
            Console.WriteLine("Level One:\n" +
                "Unfinished......");
            Console.ReadKey();
        }
    }
}
