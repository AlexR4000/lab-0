/*
 * CPRG 211 Lab 0 Activity
 * Author: Alex
 * When: Winter 2025
 */

using Lab0;

int lownum;
int highnum;
int difference;

// defining low and high numbers through user 
lownum = Utilities.GetPositiveInt("low number");
highnum = Utilities.GetIntInRange("high number", lownum + 1, Int32.MaxValue);
// where Int32 just indicates the limit of max numbers we can use.
// where lownum + 1 ensures that highnum is strictly greater than lownum

// difference between high numbers and low numbers
difference = highnum - lownum;
Console.WriteLine($"The difference between {lownum} and {highnum} is {difference}");

// create a place to store the numbers between low and high
int[] numbers = new int[difference + 1]; // size of the array
for (int i = 0; i <= difference; i++) // i is the index
{
    numbers[i] = lownum + i; // where index is strictly greater than lownum
}
Console.WriteLine("Numbers in the array:");
for (int i = 0; i <= difference; i++)
{
    Console.WriteLine(numbers[i]);
}

// create a file named "number.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt"); // located in the same folder as the .exe file
for (int i = numbers.Length - 1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close();// important to finalize the writing
Console.WriteLine("File written");
