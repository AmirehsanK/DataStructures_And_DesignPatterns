namespace Data_Structure_1;

class BigO
{
    
    
    #region Big O1
    //Linear
    //RunTime complexity is same in every input
    //input size doesn't matter
    public void Log(int[] numbers)
    {
        Console.WriteLine(numbers[0]);
    }
    
    #endregion

    #region Big O(n)
    //Linear
    //runtime adds up linearly
    //for each input runtime complexity adds up linearly
    //input - > runtime Complexity ( 5x -> 5x | 1000x -> 1000x)
    public void Log2(int[] numbers)
    {
        foreach (var variable in numbers)
        {
            Console.WriteLine(variable);
        }
    }
    // if we have Big O1 in Big O(n) we dont consider the O1 because it has a very minimal effect
    // zarib dar Big O(n) ham tasiri rooye on nadarad va nadide gerefte mishavad
    // O(2m) ham manand O(n) Linear ast
    //example
    // agar dp voroodi ham dashte bashim baz ham n ra dar nazar migirim chon tasiri dar khati boodan an nadarad
    public void Log3(int[] numbers,string[] names)
    {
        foreach (var variable in numbers)// O(n)
        {
            Console.WriteLine(variable);
        }

        foreach (var variable in names)// O(m)
        {
            Console.WriteLine(variable);
        }
    }
    //O(n)
    //O(4 + n) -> O(n)
    //O(5n) -> O(n(
    //O(n + m) -> O(n)
    #endregion

    #region Big O(n^2)

    //Quadratic 
    //for each added input complexity rises quadratically 
    public void Log4(int[] numbers)
    {
        foreach(var number in numbers)
        {
            foreach (var variable in numbers)
            {
                Console.WriteLine(variable+" "+number);
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
        foreach(var number in numbers)
        {
            foreach (var variable in numbers)
            {
                Console.WriteLine(variable+" "+number);
            }
        }
    }
    //example
    //O(n^3)
    public void Log6(int[] numbers)
    {
        foreach(var number in numbers)
        {
            foreach (var variable in numbers)
            {
                foreach (var variable2 in numbers)
                {
                    Console.WriteLine(variable+" "+number+" "+variable2);
                }
            }
        }
    }
    #endregion
    
    #region Big O(log n)
    
    //Only works if the array is sorted
    //in 1 Milion input searching for one input in linear search we need 1 milion runtime complexity
    //but in log we need 19 runtime complexity at max
    
    #endregion

    #region Big O(2^n)

    //Exponential(Namayi)
    //Worst one in runtime complexity
    #endregion

    #region Runtime Complexity Ranking
   
    //Constant O(1)  1 -> 1
    //Logarithmic O(log n) 1 -> 2
    //Linear O(n) 10 -> 100
    //Quadratic O(n ^ 2) 100 -> 10000
    //Exponential O(2 ^ n) 1024 -> 1.2 * 10^30
    
    #endregion

    #region Space Complexity

    //Shows how much ram storage is used 
    //we cant have both space complexity and runtime complexity in ideal form 
    //we need to trade off 
    
    //example
    public void Log7(string[] names)
    {
        //SC(Space Complexity) -> O(1)
        var copy=new string[names.Length];
        foreach (var variable in names)
        {
            Console.WriteLine(variable);
        }
    }
    
    #endregion
}
