using System.Diagnostics.CodeAnalysis;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // 1. Create new double array that takes length as a parameter.
        // 2. Use a loop to generate each multiple.
        // 3. Store each multiple in the index of the multiples array.
        // 4. Return the array.

        double[] multiples = new double[length];
        for(int i = 0; i<length; i++){
            multiples[i] = number * (i+1);
        }
        
        
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create a loop that repeates for "amount" number of times.
        // 2. Get the last value in the list and assign it to a variable.
        // 3. Remove the last value in the list.
        // 4. Insert that variable in the beginning of the list.

        for(int i = 0; i<amount; i++)
        {
            int lastValue = data[data.Count -1];
            data.RemoveAt(data.Count - 1);
            data.Insert(0, lastValue);
        }

    }
}
