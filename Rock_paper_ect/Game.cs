using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_ect
{
    

    class Game
    {
        public Player playerone;
        public Player playertwo;
        public bool gameOn = true;
        
    
    public void NumberOfPlayers()
    {
        playerone = new Human();
        Console.WriteLine("Would you like to play against a friend or computer \n 1 = Friend \n 2 = Computer");
        string answer = Console.ReadLine();
        if (answer == "1")
        {
            playertwo = new Human();

        }
        else if (answer == "2")
        {
            playertwo = new Computer();

        }
        else{
            Console.Write("Please try again");
            Console.WriteLine();
            NumberOfPlayers();
        }
    }
        public void CheckScore()
        {
            if (playerone.score < 2 && playertwo.score < 2)
            {
                gameOn = true;
                Console.WriteLine($"{playerone.name} score= {playerone.score}  \n{playertwo.name} score= {playertwo.score}");
                
            }
            else if (playerone.score == 2)
            {
                Console.WriteLine(playerone.name + " Wins!");
                gameOn = false;
            }
            else if (playertwo.score == 2)
            {
                Console.WriteLine(playertwo.name + " Wins!");
                gameOn = false;
            }
        }
        public void rules()
        {
            if(playerone.gestureAnswer == playertwo.gestureAnswer)
            {
                Console.WriteLine("TIE");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "rock" && playertwo.gestureAnswer == "paper")
            {
                playertwo.score++;
                Console.WriteLine("Paper Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "rock" && playertwo.gestureAnswer == "scissors")
            {
                playerone.score++;
                Console.WriteLine("Rock Wins");
                Console.ReadLine();

            }
            else if (playerone.gestureAnswer == "rock" && playertwo.gestureAnswer == "lizard")
            {
                playerone.score++;
                Console.WriteLine("Rock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "rock" && playertwo.gestureAnswer == "spock") 
            {
                playertwo.score++;
                Console.WriteLine("Spock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "paper" && playertwo.gestureAnswer == "rock")
            {
                playerone.score++;
                Console.WriteLine("Paper Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "paper" && playertwo.gestureAnswer == "scissors")
            {
                playertwo.score++;
                Console.WriteLine("Scissors Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "paper" && playertwo.gestureAnswer == "lizard")
            {
                playertwo.score++;
                Console.WriteLine("Lizard Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "paper" && playertwo.gestureAnswer== "spock")
            {
                playerone.score++;
                Console.WriteLine("Paper Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "scissors" && playertwo.gestureAnswer == "rock")
            {
                playertwo.score++;
                Console.WriteLine("Rock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "scissors" && playertwo.gestureAnswer == "paper")
            {
                playerone.score++;
                Console.WriteLine("Scissors Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "scissors" && playertwo.gestureAnswer == "lizard")
            {
                playerone.score++;
                Console.WriteLine("Scissors Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "scissors" && playertwo.gestureAnswer == "spock")
            {
                playertwo.score++;
                Console.WriteLine("Spock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "lizard" && playertwo.gestureAnswer == "rock")
            {

                playertwo.score++;
                Console.WriteLine("Rock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "lizard" && playertwo.gestureAnswer == "paper")
            {
                playerone.score++;
                Console.WriteLine("Lizard Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "lizard" && playertwo.gestureAnswer == "scissors")
            {
                playertwo.score++;
                Console.WriteLine("Scissors Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "lizard" && playertwo.gestureAnswer == "spock")
            {
                playerone.score++;
                Console.WriteLine("Lizard Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "spock" && playertwo.gestureAnswer == "rock")
            {
                playerone.score++;
                Console.WriteLine("Spock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "spock" && playertwo.gestureAnswer == "paper")
            {
                playertwo.score++;
                Console.WriteLine("Paper Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "spock" && playertwo.gestureAnswer == "scissors")
            {
                playerone.score++;
                Console.WriteLine("Spock Wins");
                Console.ReadLine();
            }
            else if (playerone.gestureAnswer == "spock" && playertwo.gestureAnswer == "lizard")
            {
                playertwo.score++;
                Console.WriteLine("Lizard Wins");
                Console.ReadLine();
            }



        }
        public void PlayGame()
        {
            NumberOfPlayers();
            while (gameOn)
            {
                playerone.ChooseGesture();
                playertwo.ChooseGesture();
                rules();
                CheckScore();
            }
            Console.ReadLine();
        }
   
       


    }

}