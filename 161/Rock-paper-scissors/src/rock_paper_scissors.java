import java.util.Random;
import java.util.Scanner;


public class rock_paper_scissors
{

	public static void main(String[] args)
	{
		System.out.println("Welcome To the Game: Rock, Paper, Scissors");
		System.out.println("to play enter a number 1, 2 or 3");
		System.out.println("1 stands for rock");
		System.out.println("2 stands for paper");
		System.out.println("3 stands for scissors");
	
		Scanner input = new Scanner(System.in);
		int intUserEntry = input.nextInt();
		Random random = new Random();
		int randomInt = random.nextInt(3) + 1;
		String strMessage = "";
		String strCmpChoice = "";
		String strYouChose = "";
		
		switch (intUserEntry)
		{
		case 1:
			{
				strYouChose = "Rock";
				if ( randomInt == 1 )
				{
					strCmpChoice = "Rock";
					strMessage = "we both had Rock, its a tie!";
					break;
				}
				if ( randomInt == 2 )
				{
					strCmpChoice = "Paper";
					strMessage = "paper beats rock, you lost :_(";
					break;
				}
				if ( randomInt == 3 )
				{
					strCmpChoice = "Scisors";
					strMessage = "Rock beats Scissors, Congratulations, you Won!";
					break;
				}
			}
		case 2:
			{
				strYouChose ="Paper";
				if ( randomInt == 1 )
				 {
					 strCmpChoice = "Rock";
					 strMessage = "Paper beats Rock, Congrats, you won!";
					 break;
				 }
				 if ( randomInt == 2 )
				 {
					 strCmpChoice = "Paper";
					 strMessage = "we both had Paper, its a tie!";
					 break;
				 }
				 if ( randomInt == 3 )
				 {
					 strCmpChoice = "Scisors";
					 strMessage = "Scissors beats papper. Sorry you lost";
					 break;
				 }
			
			}
		case 3:
			{
				strYouChose = "Scisors";
				if ( randomInt == 1 )
				 {
					 strCmpChoice = "Rock";
					 strMessage = "Rock beats Scisors, sorry, you lost.";
					 break;
				 }
				 if ( randomInt == 2 )
				 {
					 strCmpChoice = "Paper";
					 strMessage = "Scissors beat Paper, Congrats, you won!";
					 break;
				 }
				 if ( randomInt == 3 )
				 {
					 strCmpChoice = "Scisors";
					 strMessage = "we both had Scissors, its a tie!";
					 break;
				 }
				
			}
		}
		System.out.println("You Chose: " + strYouChose);
		System.out.println("The computer Chose: " + strCmpChoice);
		System.out.println(strMessage);
		// TODO Auto-generated meth1od stub

	}

}
