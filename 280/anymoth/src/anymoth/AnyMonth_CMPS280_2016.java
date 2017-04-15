package anymoth;

/*****************************************************************************
Author: Joshua Wetzel 
Last Date updated: 2/20/16 
Title: class1_280 
Version: 1.0 
Description: Class for object AnyMonth_CMPS280_2016, using Month number and month name
has methods to assign new value to month number, return month number, return month name, 
return bool value comparing two AnyMonth_CMPS280_2016 objects using equals, greater than, 
or less than.
*****************************************************************************/
class AnyMonth_CMPS280_2016
{
	
	int MonthNum; //Constructor setting up field for month number, defaulted at 1
	String monthName; //constructor setting up field for month name, defaulted at January
	String[] Months = {"" , "january" , "february" , "march" , "april", "may" , "june" , "july" , "august", "september" , "october" , "november" , "december"}; // creates array with months in order with jan in slot 1, and dec in month 12
    
	public AnyMonth_CMPS280_2016() //Base constructor
	{ // start base constructor
		MonthNum = 1; //assigns default value to month number
		monthName = Months[MonthNum]; //assigns default value to month name based on month number
	} //end base constructor
	
	public AnyMonth_CMPS280_2016(int initialNumInput) //constructor with allowance to take in a starting num month value
	{ // start base constructor
		if (initialNumInput >= 1 && initialNumInput <= 12) //input validation
		{ //begin Input validation if
			MonthNum = initialNumInput; //assigns month number to the user input
			monthName = Months[MonthNum]; //sets month name to corresponding month number
		
		} //end input validation if
		else //previous if was seen as false and will run validation failure code
		{ //set default if input validation not met
			MonthNum = 1; //set month num to default (1)
			System.out.println("Invalid user input, Month Has been set to 1(january)"); //alerts user input was not valid
			monthName = Months[MonthNum]; //sets month name to corresponding month number
		} //end set default if input validation not met
	} //end base constructor
	
	public AnyMonth_CMPS280_2016(String initialMonthStringInput) //Base constructor
	{ // start base constructor
		String validationOfMonthName = initialMonthStringInput; //adjusts user input to lower case and removes spaces to the side
		for (int i = 1; i < 14; i++) //loop that goes through months list with 13th slot for the error
		{ //starting for loop
        		if (i < 13) //if 1-12, in reference to month array
        			{ //start loop through month reference check
        			if ( validationOfMonthName == Months[i] ) //if user input == month name
        				{ //start if user input == month name statement true 
        				MonthNum = i; //assigns month number to current iteration
        				break; //leaves for loop since received answer
        				} //end if user input == month name statement true
        			} // end if 1-12, in reference to month array
        		else //if i is at 13, meaning we went past how many months there are
        			{ //begin if i is at 13, meaning we went past how many months there are
            			System.out.println("Invalid user input, Month Has been set to 1(january)"); //alerts user input was not valid
            			MonthNum = 1; //we didn't meet validation req, so month number set to 1
            			break; //breaks out of for loop because got an answer
        			} //end if i is at 13, meaning we went past how many months there are
		} //ending for loop
		monthName = Months[MonthNum]; //assigns month name based on month number
	} //end base constructor
	
	public void setMonthNum(int UserInputMonthNum) //method to set new month number
	{ //begin setMonthNum method
		if (UserInputMonthNum >= 1 && UserInputMonthNum <= 12) //input validation
		{ //begin Input validation if
			MonthNum = UserInputMonthNum; //assigns month number to the user input
			monthName = Months[MonthNum]; //sets month name to corresponding month number
		
		} //end input validation if
		else //previous if was seen as false and will run validation failure code
		{ //set default if input validation not met
			MonthNum = 1; //set month num to default (1)
			System.out.println("Invalid user input, Month Has been set to 1(january)"); //alerts user input was not valid
			monthName = Months[MonthNum]; //sets month name to corresponding month number
		} //end set default if input validation not met
	}
	
	public int getMonthNum() //method to return month number
	{ //begin method to return month number
		return MonthNum; //returns month number
	} //end method to return month number
	
	public void setMonthName(String monthNameInput) //Method Generates Month Name based on month num
	{ //begin method Generates Month Name based on month num
		String validationOfMonthName = monthNameInput.trim().toLowerCase(); //adjusts user input to lower case and removes spaces to the side
		for (int i = 1; i < 14; i++) //loop that goes through months list with 13th slot for the error
		{ //starting for loop
		if (i < 13) //if 1-12, in reference to month array
			{ //start loop through month reference check
			if (Months[i] == validationOfMonthName) //if user input == month name
				{ //start if user input == month name statement true 
				MonthNum = i; //assigns month number to current iteration
				break; //leaves for loop since received answer
				} //end if user input == month name statement true
			} // end if 1-12, in reference to month array
		else //if i is at 13, meaning we went past how many months there are
			{ //begin if i is at 13, meaning we went past how many months there are
			System.out.println("Invalid user input, Month Has been set to 1(january)"); //alerts user input was not valid
			MonthNum = 1; //we didn't meet validation req, so month number set to 1
			break; //breaks out of for loop because got an answer
			} //end if i is at 13, meaning we went past how many months there are
		} //ending for loop
		monthName = Months[MonthNum]; //assigns month name based on month number
	} //end method Generates Month Name based on month num
	
	public String GetMonthName() //method that returns month name
	{ //begin method that returns month name
		return monthName; //returns current month name
	} //end method that returns month name
	
	public boolean Equals(AnyMonth_CMPS280_2016 ObjectInput) //Method compares two Objects month Values
	{ //Start Method Compare two objects month value
		if (ObjectInput.MonthNum == MonthNum) //Compares the two objects month value
		{ //begin if meets requirements
			return true; //returns true because if requirements met
		} //ends if meets requirements
		else //if does not meet requirements
		{ //begin if does not meet requirements
			return false; //returns value because requirements not met
		}	//end if does not meet requirements
	}//End Method Compare two objects month value
	
	public boolean greaterThan (AnyMonth_CMPS280_2016 ObjectInput) //Method compares two Objects month Values
	{
		if (MonthNum > ObjectInput.MonthNum) //Compares the two objects month value
		{ //begin if meets requirements
			return true; //returns true because if requirements met
		} //ends if meets requirements
		else //if does not meet requirements
		{ //begin if does not meet requirements
			return false; //returns value because requirements not met
		}	//end if does not meet requirements	
	}
	
	public boolean lessThan (AnyMonth_CMPS280_2016 ObjectInput) //Method compares two Objects month Values
	{
		if (MonthNum < ObjectInput.MonthNum) //Compares the two objects month value
		{ //begin if meets requirements
			return true; //returns true because if requirements met
		} //ends if meets requirements
		else //if does not meet requirements
		{ //begin if does not meet requirements
			return false; //returns value because requirements not met
		}	//end if does not meet requirements	
	}
	
}
