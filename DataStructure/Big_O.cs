namespace Data_Structure_1;

internal class BigO
{
    #region Big O(1)
    // Constant
    // Runtime complexity is the same for every input.
    // Input size does not affect runtime.
    public void Log(int[] numbers)
    {
        Console.WriteLine(numbers[0]);
    }
    
    #endregion

    #region Big O(n)
    // Linear
    // Runtime grows proportionally with input size.
    // Example: 5 items -> 5 steps, 1000 items -> 1000 steps.
    public void Log2(int[] numbers)
    {
        foreach (var variable in numbers)
        {
            Console.WriteLine(variable);
        }
    }
    // If an O(1) operation exists within O(n), the O(1) is ignored because its impact is minimal.
    // Constants do not affect O(n) and are dropped.
    // For example, O(2n) is still O(n).
    // Example with multiple inputs: treat each collection separately.
    // When a method has two inputs, the complexity becomes O(n + m).
    public void Log3(int[] numbers, string[] names)
    {
        foreach (var variable in numbers) // O(n)
        {
            Console.WriteLine(variable);
        }

        foreach (var variable in names) // O(m)
        {
            Console.WriteLine(variable);
        }
    }
    // Examples:
    // O(4 + n) -> O(n)
    // O(5n) -> O(n)
    // O(n + m)
    #endregion

    #region Big O(n^2)

    // Quadratic
    // Complexity rises quadratically with input size.
    public void Log4(int[] numbers)
    {
        foreach (var number in numbers)
        {
            foreach (var variable in numbers)
            {
                Console.WriteLine(variable + " " + number);
            }
        }
    }
    //example
    //O(n + n^2) -> O(n^2)
    public void Log5(int[] numbers)
    {
        foreach (var variable in numbers)
        {
            Console.WriteLine(variable);
        }
        foreach (var number in numbers)
        {
            foreach (var variable in numbers)
            {
                Console.WriteLine(variable + " " + number);
            }
        }
    }
    //example
    //O(n^3)
    public void Log6(int[] numbers)
    {
        foreach (var number in numbers)
        {
            foreach (var variable in numbers)
            {
                foreach (var variable2 in numbers)
                {
                    Console.WriteLine(variable + " " + number + " " + variable2);
                }
            }
        }
    }
    #endregion
    
    #region Big O(log n)

    // Only works if the array is sorted.
    // With one million items, linear search may require one million steps,
    // but binary search needs at most 19 steps.
    
    #endregion

    #region Big O(2^n)

    // Exponential
    // Extremely poor scalability.
    #endregion

    #region Runtime Complexity Ranking

    // Constant O(1): 1 -> 1
    // Logarithmic O(log n): 1 -> 2
    // Linear O(n): 10 -> 100
    // Quadratic O(n^2): 100 -> 10,000
    // Exponential O(2^n): 1024 -> 1.2 * 10^30
    
    #endregion

    #region Space Complexity

    // Indicates how much memory is used.
    // We cannot optimize both space and runtime perfectly.
    // A trade-off is often required.

    // Example
    public void Log7(string[] names)
    {
        // SC -> O(n)
        // A copy array of size n is allocated.
        var copy = new string[names.Length];
        foreach (var variable in names)
        {
            Console.WriteLine(variable);
        }
    }

    #endregion
}