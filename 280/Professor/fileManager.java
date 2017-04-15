package Professor;
import java.io.*;
import java.util.*; 

public class fileManager //class to create, read, write, send, and recieve data
{ //start class file manager
    int professorCounter; //counts how many prof objs been name
    private Scanner FileReader; //starts file reader
    private final int MONTH_OF_HOURS = 160; //multiplier to convert hourly pay into monthly, 40hours, 4 weeks
    
    Professor[] ProfessorsObjects = new Professor[4000]; //array of profers to soon exist
        
    public fileManager() //no args constructor
    { //start no args constructor
    } //end no args constructor
    
    public void openFile() //method to open file to read data from
    { //start open file
	try //to catch error if file not opened 
	{ //strt what to try, open file
	    FileReader = new Scanner(new File("Cloud_Computing_Profs.csv")); //reads file with name in string 
	} //end //what to try, open file
	catch(Exception e) //if failed to open file
	{ //start failed to open file
	    System.out.println("could not read file");
	} //end failed to open file
    } //end open file
   
    public void readFile() //method to read open file
    { //start read open file
	professorCounter = 0; //sets variable to count prof objects made to 0
	while (FileReader.hasNextLine()) //if there is another entry run
	{ //start if there is another entry, run
	    String fileEntryRead = FileReader.nextLine(); //assigns string of the next line to variable
	    String[] SplitData = fileEntryRead.split(",", 10); // breaks the string up on commas, into a array split data 
	    
	    /*Goes in order 0 -> n: name, id, department, payrate, isCS, interest, profitype,MonthsPerYear.*/	
	    String professorName = SplitData[0].trim(); //assigns prof name to data from position 1 and removes extra spaces
	    int professorID = Integer.parseInt(SplitData[1].trim()); //assigns prof id number data from position 2 and removes extra spaces 
	    String professorDepartment = SplitData[2].trim(); //assigns prof dept data in pos 3 and removes extra spaces 
	    double professorStandardMonthPay = ((Double.parseDouble(SplitData[3].trim())) * MONTH_OF_HOURS ); //assigns standard monthly pay to data entry position 4, then multiplies it by number of hours(160)  to get ammount earned monthly and removes extra spaces 
	    Boolean professorIsComputerScience = Boolean.parseBoolean(SplitData[4].trim().toLowerCase()); //assigns prod is comp science to 5th data field, and lower cases it  and removes extra spaces 
	    String professorInterest = SplitData[5].trim(); //assigns profesor research intrest to 6th data field, and removes extra spaces
	    String professorType = SplitData[6].trim().toLowerCase(); //assigns prof type or rank to data in field 6, and removes extra spaces 
	    int monthsPerYear = Integer.parseInt(SplitData[7].trim()); //assigns months prof works per year to 8th data field and removes extra spaces 
	    
	    ProfessorsObjects[professorCounter++] = CreateProfessorFromType(professorName, professorID, professorDepartment, professorType, professorStandardMonthPay, professorIsComputerScience, professorInterest, monthsPerYear); //calls method to create prof objects with above fields
	} //end if there is another entry, run 
    } //end read open file
    
    private Professor CreateProfessorFromType(String professorName, int professorID, String professorDepartment, String professorType, double professorStandardMonthPay, Boolean professorIsComputerScience, String professorInterest, int monthsPerYear) //method to create professor with fields
    { //start method to create profesor objects
	switch(professorType) //to choose which class object will be made out of based on prof rank
	{ //start choose which type object to make based on prof rank
		case "assistantprofessor": //if prof is assistantprofessor
		    return new AssistantProfessor(professorName, professorID, professorDepartment, professorType, professorStandardMonthPay, professorIsComputerScience, professorInterest, monthsPerYear); //creates assistant prof object with needed data fields
		case "associateprofessor": //if prof is associateprofessor
		    return new AssociateProfessor(professorName, professorID, professorDepartment, professorType, professorStandardMonthPay, professorIsComputerScience, professorInterest, monthsPerYear); //creates assoc prof object with needed data fields
		case "fullprofessor": //if prof is fullprofessor
		    return new FullProfessor(professorName, professorID, professorDepartment, professorType, professorStandardMonthPay, professorIsComputerScience, professorInterest, monthsPerYear); //creates full prof object with needed data fields
		default: //if data for which kind of prof is not correct
		    return new FullProfessor("brokename", 911, "brokedept", "broketype", 911, true, "brokeintrest", 6); //will create dud prof if type not provided
	} //end choose which type object to make based on prof rank
    } //end method to create profesor objects
    
    public void closeFile() // method to close the curent file
    { //start close file
	FileReader.close(); //closes file
    } //end close file
    
    public void printOutput() //method to print output to csv intended to be opened as text file
    { //start method to print output
	try //attempt to make file, or throw exception
	{ //start what to attempt	
	    double TotalPayToEmployeeForYear = 0; //starts var for value to total employees income
	    FileWriter newOutput = new FileWriter("ProfessorOutput.csv"); //creates new file writer object on file name
	    newOutput.write("Professor              ID           Rank                  Department   Yearly Pay Rate   Research Intrest\n"); //writes headder to file
	    newOutput.write("=================================================================================================================\n"); //writes headder line two to file
	    for(int j = 0; j < professorCounter; j++) //loops through each object of profesor
	    { //start loop each prof
		String profName = ProfessorsObjects[j].getProfessorName(); //pulls prof name from current object
		String profID = Integer.toString(ProfessorsObjects[j].getProfessorID()); //pulls prof id from current object
		String profType = ProfessorsObjects[j].getProfessorType(); //pulls prof type(rank) from current object
		String profDept = ProfessorsObjects[j].getProfessorDepartment(); //pulls prof department from current object
		String profYearlyPay = Double.toString(ProfessorsObjects[j].getPay()); //pulls prof yearly pay from current object
		String profIntrest = ProfessorsObjects[j].getProfessorIntrest(); //pulls prof research intrest from current object
		
		TotalPayToEmployeeForYear += ProfessorsObjects[j].getPay(); //adds this employees pay to total of employees pays 
		newOutput.write(String.format("%-22s %-12s %-21s %-12s %-17s %-25s%n", profName, profID, profType, profDept, profYearlyPay, profIntrest)); //writes line to file, formatted for text file reading
	    } //end loop each prof
	    newOutput.write("\nTotal pay to all employees professors listed: " + TotalPayToEmployeeForYear); //prints line of yearly total pay to prof 
	    newOutput.close(); //closes output created
	} //end what to attempt	  
	catch (IOException e) // if failed
	{ //start if failed
	    e.printStackTrace(); //what run if failed
	} //end if failed
    } //end method to print output

}
