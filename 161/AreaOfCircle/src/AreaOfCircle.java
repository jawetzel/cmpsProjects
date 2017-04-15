import java.util.Scanner;

public class AreaOfCircle
{

	public static void main(String[] args)
	{
		// TODO Auto-generated method stub
		// to find area of circle
		System.out.println("put in radius");
		//user enters radius
		
		
		Scanner inputs = new Scanner(System.in);
		int input = inputs.nextInt();
		//setup scanner
		
		double area = Math.pow(input, 2);
		// A = R*Pi
		////display area to user
		System.out.println(area);
	}

}
