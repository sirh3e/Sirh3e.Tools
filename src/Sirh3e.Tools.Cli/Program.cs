using M = Sirh3e.Tools.Lib.Math;

var distances = new[]
{
    "00000000",
    "01100110",
    "10011001",
    "11111111",
};

Console.WriteLine(M.Hamming.SolveDistances(distances));