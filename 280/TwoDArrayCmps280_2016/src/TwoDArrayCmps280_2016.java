/*
 Author: joshua wetzel 
 Last Date updated: 02/01/2016 
 Title: class1_280 
 Version: 1.0 
 Description: Evaluates two deminsional array 
*/
public class TwoDArrayCmps280_2016
{
    public static void main(String args[])
    {
	int Row = 1; //Defines row we are doing extra work to
	int Column = 1; //Defines Column we are doing extra work to
	
	float Array1[][] = new float[][]
		{
        	    {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
        	    {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
        	    {21, 22, 23, 24, 25, 26, 27, 28, 29, 30}
		};
	float TotalOfElements = Total_2DArray_Elements(Array1);
	System.out.println("The total value of elements in Array provided is: " + TotalOfElements );

	float AverageOfElements = Average_2DArray_Elements(Array1);
	System.out.println("The average of elements in Array provided is: " + AverageOfElements );

	float TotalOfElementsByRow = Total_2DArray_Elements_by_Certain_Row(Array1 , Row);
	System.out.println("The total of elements in Array's Row: " + Row + "  is: " + TotalOfElementsByRow );

	float TotalOfElementsByColumn = Total_2DArray_Elements_by_Certain_Column(Array1, Column);
	System.out.println("The total of elements in Array's Column: " + Column + "  is: " + TotalOfElementsByColumn );
	
	float LargestValueInRow = The_Largest_Value_In_Certain_Row(Array1, Row);
	System.out.println("The highest value in row: " + Row + "  is: " + LargestValueInRow );

	float LargestValueInColumn = The_Largest_Value_In_Certain_Column(Array1, Column);
	System.out.println("The highest value in Column: " + Column + "  is: " + LargestValueInColumn );

    }
    
    public static float Total_2DArray_Elements (float Array[][])
    {
	float Total = 0;
	for (int i = 0; i < Array.length; i++)
	{
	    for (int j = 0; j < Array[i].length; j++ )
	    {
		Total += Array[i][j];
	    }
	}
	return Total;
    }

    public static float Average_2DArray_Elements (float Array[][])
    {
	float Total = 0;
	int Counter = 0;
	for (int i = 0; i < Array.length; i++)
	{
	    for (int j = 0; j < Array[i].length; j++ )
	    {
		Total += Array[i][j];
		Counter++;
	    }
	}
	Total = (Total / Counter);
	return Total;
    }

    public static float Total_2DArray_Elements_by_Certain_Row (float Array[][], int Row)
    {
	float Total = 0;
	for (int i = 0; i < Array.length; i++)
	{
	    Total += Array[Row][i];
	}
	return Total;
    }

    public static float Total_2DArray_Elements_by_Certain_Column (float Array[][], int Column)
    {
	float Total = 0;
	for (int i = 0; i < Array.length; i++)
	{
	    Total += Array[i][Column];
	}
	return Total;
    }

    public static float The_Largest_Value_In_Certain_Row (float Array[][], int Row)
    {
	float Highest = 0;
	for (int i = 0; i < Array.length; i++)
	{
	   Highest = Array[i][Row] > Highest ? Array[Row][i] : Highest;
	}
	return Highest;
    }

    public static float The_Largest_Value_In_Certain_Column (float Array[][], int Column)
    {
	float Highest = 0;
	for (int i = 0; i < Array.length; i++)
	{
	    Highest = Array[i][Column] > Highest ? Array[i][Column] : Highest;
	}
	return Highest;
    }
}
