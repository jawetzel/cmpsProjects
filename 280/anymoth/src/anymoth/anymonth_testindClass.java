package anymoth;

public class anymonth_testindClass
{

    public anymonth_testindClass()
    {
    }

    public static void main(String[] args)
    {
	AnyMonth_CMPS280_2016 monthOne = new AnyMonth_CMPS280_2016();
	AnyMonth_CMPS280_2016 monthTwo = new AnyMonth_CMPS280_2016(2);
	AnyMonth_CMPS280_2016 monthThree = new AnyMonth_CMPS280_2016(15);
	AnyMonth_CMPS280_2016 monthFour = new AnyMonth_CMPS280_2016("may");
	AnyMonth_CMPS280_2016 monthFive = new AnyMonth_CMPS280_2016("Mays");
	
	AnyMonth_CMPS280_2016 monthSix = new AnyMonth_CMPS280_2016();
	AnyMonth_CMPS280_2016 monthSeven = new AnyMonth_CMPS280_2016();
	System.out.println("monthOne " + monthOne.MonthNum + " " + monthOne.monthName);
	System.out.println("monthTwo " + monthTwo.MonthNum + " " + monthTwo.monthName);
	System.out.println("monthThree " + monthThree.MonthNum + " " + monthThree.monthName);
	System.out.println("monthFour " + monthFour.MonthNum + " " + monthFour.monthName);
	System.out.println("monthFive " + monthFive.MonthNum + " " + monthFive.monthName);

	monthSix.setMonthNum(10);
	monthSeven.setMonthName("june");
	System.out.println("monthSix " + monthSix.MonthNum + " " + monthSix.monthName);
	System.out.println("monthSeven " + monthSeven.MonthNum + " " + monthSeven.monthName);
	boolean monthoneEqualsMonthThree = monthOne.Equals(monthThree);
	boolean greaterThan = monthSix.greaterThan(monthOne);
	boolean lessThan = monthSix.lessThan(monthOne);

	System.out.println("greaterThan = " + greaterThan);
	System.out.println("lessThan = " + lessThan);

	System.out.println("bool = " + monthoneEqualsMonthThree);




    }

}
