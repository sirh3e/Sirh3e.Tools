using M = Sirh3e.Tools.Lib.Math;

var distances = new[]
{
    "00110", "00101", "01110"
};

Console.WriteLine(M.Hamming.SolveDistances(distances));