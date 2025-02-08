namespace Data_Structure_1;

using System;
using System.Collections.Generic;


class Reverse {
    public static int[] ReverseArray(int[] a) {
        var s=new Stack<int>();
        foreach(var b in a)
        {
            s.Push(b);
        }
        var a2=new int[a.Length];
        for(var i=0;i<a.Length;i++)
        {
            a2[i]=s.Pop();
        }
        return a2;
    }
}

public class Stack<T>
{
    private readonly List<T> _hold = [];

    public void Push(T item)
    {
        _hold.Add(item);
    }

    public T Top()
    {
        if (_hold.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return _hold[_hold.Count - 1];
    }

    public T Pop()
    {
        if (_hold.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        var top = _hold[_hold.Count - 1];
        _hold.RemoveAt(_hold.Count - 1);
        return top;
    }

    public int Size()
    {
        return _hold.Count;
    }

    public bool Empty()
    {
        return _hold.Count == 0;
    }
}
//Next Smaller Element
class Nse {
    public static int[] nse(int[] a) {
        int[] result = new int[a.Length];
        Stack<int> s = new Stack<int>();

        for (int i = 0; i < a.Length; i++)
        {
            while (!s.Empty() && s.Top() >= a[i])
            {
                s.Pop();
            }

            if (s.Empty())
            {
                result[i] = -1;
            }
            else
            {
                result[i] = s.Top();
            }

            s.Push(a[i]);
        }

        return result; 
    }
}

class Program
{
    
    static void Main(string[] args)
    {
        int[] x = { 1, 3, 5, 7, 9 };
        int[] y = Reverse.ReverseArray(x);
        foreach (var variable in y)
        {
            Console.WriteLine(variable);
        }
        int[] array = { 4, 5, 2, 10, 8 };
        int[] result = Nse.nse(array);
        Console.WriteLine(string.Join(", ", result));
    }
}