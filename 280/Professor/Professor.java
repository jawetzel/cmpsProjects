package Professor;

public abstract class Professor //name abstract class
{ //start abstract class
    String professorName; //constructor for professor name
    int professorID; //constructor for professor id
    String professorDepartment; //constructor for professor department
    String professorType; //constructor for professor type
    double professorStandardMonthPay; //constructor for professor standard month pay
    Boolean professorIsComputerScience; //constructor for professor boolean is in computer science dept
    String professorIntrest; //constructor for professor research intrest	
    int monthsPerYear; ////constructor for professor months paid per year
    
    double[] monthlyPay = new double[12]; //array to give each month a value of how much paid

    public Professor() //mp args constrctor
    { //start no args constructor	
    } //end no args constructor
    
    public void calculateNetPay(int Month, int Multiplier) //method to calculate a specific months net pay, using paramaters of which month 0-11, and multiplier for if professor recieves doubble pay for a month
    { //start calculate net pay
	double tax = .9; //variable to deduct 10% for taxes
	monthlyPay[Month] = (professorStandardMonthPay * Multiplier * tax); //multiplies professor month pay aginst tax code and then aginst if you have satandard or double pay	
    } //end calculate net pay
    
    public String getProfessorName() //method returns profesors name
    { //start method returns profesors name
	return professorName; //returns proffesors name
    } //end method returns profesors name
    
    public int getProfessorID() //method returns prof id
    { //method returns prof id
	return professorID; //returns prof id number
    } //method returns prof id
    
    public String getProfessorDepartment() //method to return prof department
    { //start method to return prof department
	return professorDepartment; //return prof department
    } //method to return prof department
    
    public String getProfessorType() //method to return prof rank
    { //start method to return prof rank
	return professorType; //returns prof rank
    } //end method to return prof rank
    
    public double getPay() //method to return the total of each months pay added together
    { //start getpay
	double YearlyPay = 0; //declares and assigns yearly pay to 0
	for (int i = 0; i < 12; i++) //loops through each month 
	{ //start loop each month
	    YearlyPay += monthlyPay[i]; //adds next month to current total
	} //end loop each month
	return YearlyPay;
    } //end getpay
  
    public String getProfessorIntrest() //method to return prof research intrest
    { //start method to return prof research intrest
	return professorIntrest; //returns prof research intrest
    } //end method to return prof research intrest
}//end abstract class
