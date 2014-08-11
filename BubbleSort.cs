/*
Filename: BubbleSort.cs
Author: Rick Fogle
Creation Date: 15 May 2014 

Purpose:
Source code for the BubbleSort.exe command-line executable. I created this to help me learn two
things:
1. Sorting algorithms, specifically the bubble sort.
2. Coding in C#.

External Resources: 
System namespace, 

NOTES: 
15 May 2014: Version 0.0.1 puts all the functionality in the Main() function for simplicity and uses a fixed starting 
array. Later versions will be more modular, include modified bubblesort functionality and  encorporate a 
random number generator to load the array.

15 May 2014: Version 0.0.2 Modularizes the functionality to sort and display the arrays.

*/

// Declare external namespaces used.
using System;

// Load any external DLL's or files used.

class CL_BubbleSort{

	/*################################################################################
	// Main Method Definition.
	Inputs: None
	Outputs: None
	Returns: retcode (0/pass,1/fail)
	################################################################################*/
	static int Main(){
		int [] iNumbers = new int [10] {4, 6, 7, 3, 5, 8, 1, 10, 2, 9};
		int retcode = 0; // Initialize the return value to 0 (pass).
	
		//Write out the intial array
		retcode = PrintArray(iNumbers);

		//Sort the array.
		retcode = SortArray(iNumbers);

		//Write out the sorted array
		retcode = PrintArray(iNumbers);

	return(retcode); 
	} // End of Main() function.


	// Method Definitions.
	/*########################################
	SortArray()
	Sort the array numerically in low to high order.

	Inputs: integer array of numbers.
	Outputs: None
	Returns: retcode (0/pass,1/fail)

	NOTES: 
	Duplicate values are not swapped when detected since there's really no point in it.
	########################################*/
	static int SortArray(int[ ] iNumbers){
		int iTemp;
		int iPassCount, iCompCount;
		int retcode = 0;
		
		for (iPassCount = 0; iPassCount <= iNumbers.Length - 2; iPassCount++){
			for (iCompCount = 0; iCompCount <= iNumbers.Length - 2; iCompCount++){
				if (iNumbers[iCompCount] > iNumbers[iCompCount + 1]){
						iTemp = iNumbers[iCompCount +1];
						iNumbers[iCompCount +1] = iNumbers[iCompCount];
						iNumbers[iCompCount] = iTemp;
				} //end of swap logic.
			} // end of inner "comparison" loop.
		} // end of outer "Pass" loop.
		return(retcode);
	}

	/*########################################
	PrintArray()
	Sends the passed-in array elements to the console window..

	Inputs: integer array of numbers.
	Outputs: described above.
	Returns: retcode (0/pass,1/fail)

	NOTES:
	########################################*/
	static int PrintArray(int[ ] iNumbers){
		int iTemp;
		int retcode = 0;
		for (iTemp = 0; iTemp <= iNumbers.Length - 1; iTemp++){
			if(iTemp == iNumbers.Length - 1){
				Console.Write("{0} \n", iNumbers[iTemp]);
			}
			else{
				Console.Write("{0}, ", iNumbers[iTemp]);
			}
		}
		return(retcode);
	}

} // End of CL_BubbleSort class definition.

