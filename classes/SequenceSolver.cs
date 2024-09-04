using System;
using System.Collections.Generic;

public class SequenceSolver
{
    public static int SolveSequenceA(List<int> sequence)
    {
        int difference = sequence[1] - sequence[0];
        return sequence[sequence.Count - 1] + difference;
    }


    public static int SolveSequenceB(List<int> sequence)
    {
        int ratio = sequence[1] / sequence[0];
        return sequence[sequence.Count - 1] * ratio;
    }


    public static int SolveSequenceC(List<int> sequence)
    {
        int nextNumber = (int)Math.Sqrt(sequence[sequence.Count - 1]) + 1;
        return nextNumber * nextNumber;
    }



    public static int SolveSequenceD(List<int> sequence)
    {
        int nextNumber = (int)Math.Sqrt(sequence[sequence.Count - 1]) + 2;
        return nextNumber * nextNumber;
    }


    public static int SolveSequenceE(List<int> sequence)
    {
        return sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
    }


    public static int SolveSequenceF(List<int> sequence)
    {
        return sequence[sequence.Count - 1] + 1;
    }

}
