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
        double[] result = new double[length];

        // try to Loop.
        for (int i = 1; i <= length; i++)
        {
            // Calculate the multiple and store it in array.
            result[i - 1] = number * i;
        }

        // Step 5: Return the filled array.
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> numders, int amount)
    {
        int seprate = numders.Count - amount;

        //Get the right
        List<int> rightNum = numders.GetRange(seprate, amount);
        //Get the left .
        List<int> leftNum = numders.GetRange(0, seprate);

        // make list empty.
        numders.Clear();

        // join the numbers together into array.
        numders.AddRange(rightNum);
        numders.AddRange(leftNum);
    }
}

/*
    Explanatons

    1. For MultiplesOf, I multiply number by 1, 2, 3,down up to length and store each result.
    2. For RotateListRight, I cut the list into two parts then join them together after getting results*/