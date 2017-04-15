package Professor;

public class AssociateProfessor extends Professor
{     //start assoc prof class
    public AssociateProfessor(String ProfName, int ProfID, String ProfDepartment, String ProfType, double ProfStandardMonthlyPay, Boolean ProfIsComputerScience, String ProfIntrest, int Months)//constructor for assoc professor, taking in all needed values from input
    { //start assoc prof constructor
	professorName = ProfName; //assigns class variable prof name to input prof name
	professorID = ProfID; //assigns class variable prof id to input prof id
	professorDepartment = ProfDepartment; //assigns class variable prof department to input prof department
	professorStandardMonthPay = ProfStandardMonthlyPay; //assigns class variable prof monthly pay to input prof monthly pay
	professorIsComputerScience = ProfIsComputerScience; //assigns class variable prof is in computer scicne to input prof is in computer science
	professorIntrest = ProfIntrest; //assigns class variable prof research intrest to input prof research intrest
	monthsPerYear = Months; //assigns class variable prof months worked per year to input prof months worked per year
	professorType = ProfType; //assigns class variable prof rank to input prof rank
	
	for(int i = 0;i < Months; i++) //loop to figure out the actual pay after tax and doubble pay of eacch month
	{ //start pay loop
	    calculateNetPay(i, 1); //runs method to figure out how much prof paid for current i month
	} //end pay loop
    } //end full prof constructor
} //end assoc prof class
