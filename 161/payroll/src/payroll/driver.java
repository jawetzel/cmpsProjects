package payroll;
import java.util.Scanner;
public class driver
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		//get 1st name
		System.out.println("enter first name of employee");
		String strFirstName = input.next();
		//get hours
		System.out.println("enter number of hours " + strFirstName + " worked");
		double dblHours = input.nextDouble();
		//get hourly rate
		System.out.println("Enter " + strFirstName + "'s hourly payrate");
		double dblHourlyRate = input.nextDouble();
		//get taxes
		////federal %
		System.out.println("enter the federal tax percent in format xx.x");
		double dblFederalTaxPercent = input.nextDouble();
		////state %
		System.out.println("Enter the State tax Percent in format XX.X");
		double dblStateTaxPercent = input.nextDouble();
		
		//gross pay = hours * pay rate
		double dblGrossPay = dblHours * dblHourlyRate;
		//fed tax = 10%
		double dblFedTaxTaken = dblGrossPay * (dblFederalTaxPercent / 100);
		//state tax
		double dblStateTaxTaken = dblGrossPay * (dblStateTaxPercent / 100);
		//net pay
		double dblNetPay = dblGrossPay - dblFedTaxTaken - dblStateTaxTaken;
		System.out.println(strFirstName + " worked " + dblHours + " Hours at\n " + dblHourlyRate + "$");
		System.out.println("Gross pay: " + dblGrossPay + "$");
		System.out.println("Federal taxes taken: " + dblFedTaxTaken + "$");
		System.out.println("State Taxes Taken: " + dblStateTaxTaken + "$");
		System.out.println("Total Taxes Taken: " + (dblFedTaxTaken + dblStateTaxTaken) + "$");
		System.out.println(strFirstName + " took home " + dblNetPay + "$");
		
	}

}
