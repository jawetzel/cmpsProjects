package prog1_280;

import java.util.Scanner;
/*****************************************************************************/
/* Author: joshua wetzel */
/* Last Date updated: 02/1/2016 */
/* Title: class1_280 */
/* Version: 1.0 */
/* Description: grading dmv test */
/***************************************************************************/
public class DriverTest_2016
{
    public static void main(String[] args)
    {
	char AnswerKey[] = new char [15]; // = { "A", "A", "C" };
	AnswerKey[0] = 'A';
	AnswerKey[1] = 'A';
	AnswerKey[2] = 'C';
	AnswerKey[3] = 'B';
	AnswerKey[4] = 'D';
	AnswerKey[5] = 'D';
	AnswerKey[6] = 'A';
	AnswerKey[7] = 'A';
	AnswerKey[8] = 'C';
	AnswerKey[9] = 'B';
	AnswerKey[10] = 'D';
	AnswerKey[11] = 'B';
	AnswerKey[12] = 'A';
	AnswerKey[13] = 'A';
	AnswerKey[14] = 'C';
	
	char AnswersInput[] = new char [16];
	
	for( int counter = 0; counter < 15;)
	{
	    Scanner input = new Scanner(System.in);
	    System.out.println("please enter answer to question " + counter + "in the form A, B, C, or D");
	    String userInput = input.nextLine().toUpperCase().trim();
	    char answer;
	    if ( userInput.length() < 1 )
	    {
		answer = 'N';
	    }
	    else
	    {
		answer = userInput.charAt(0);
	    }
	 
	    // start input Validation
	    
	    switch (answer) 
	    {
	    
	    	case 'A':
	    	case 'B':
	    	case 'C':
	    	case 'D':
	    	{
	    	    System.out.println("Input successful, continue to question: " + (counter + 2 ) );
	    	    break;
	    	}
	    	default:
	    	{
	    	    System.out.println("Invalid entry, please re-enter answer");
	    	    counter = counter - 1;
	    	    break;
	    	}
	    	
	    }
	    //end input Validation
	    counter++;
	    AnswersInput[counter] = answer;
	    
	}
	boolean AnswerGraded[] = new boolean [15];
	for (int counter = 0; counter < 15; counter++)
	{
	    if (AnswerKey[counter] == AnswersInput[counter]) 
	    {
		AnswerGraded[counter] = true;
	    }
	    else
	    {
		AnswerGraded[counter] = false;
	    }
	}
	Passed(AnswerGraded);
    }
    
    public static void Passed (boolean graded[])
    {
	int totalCorrect = 0;
	for( int counter = 0; counter < 15; counter++)
	{
	    if (graded[counter] == true)
	    {
		totalCorrect = totalCorrect + 1;
	    }
	}
	if ( totalCorrect >= 12 )
	{
	    System.out.println("Congratulations, you passed the written exam");
	}
	else
	{
	    System.out.println("Sorry, you failed the written exam");
	}
	TotalCorrectAnswers (graded);
    }
    public static void TotalCorrectAnswers (boolean graded [])
    {
	int correctAnswers = 0;
	int wrongAnswers = 0;
	for (int counter = 0; counter < 15; counter++)
	{
	   if ( graded[counter] == true )
	   {
	       correctAnswers++; 
	   }
	   else
	   {
	       wrongAnswers++;
	   }
	}
	System.out.println("the total questions you answered correctly is: " + correctAnswers);
	TotalWrongAnswers(graded, wrongAnswers);
    }
    public static void TotalWrongAnswers (boolean[] graded, int wrongAnswers)
    {
	System.out.println("you answered " + wrongAnswers + " incorrectly");
	WhichQuestionsAnsweredIncorrectly(graded);
    }
    public static void WhichQuestionsAnsweredIncorrectly(boolean[] graded)
    {
	String WhichOnesWrong = "";
	for (int counter = 0; counter < 15; counter++)
	{
	    if(graded[counter] == false)
	    {
		WhichOnesWrong = WhichOnesWrong + ((counter + 1) + ", "); 
	    }
	}
	System.out.println("the following answers were answered incorrectly: " + WhichOnesWrong);
    }
}
