// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


string[] tests = { "()", "()[]{}", "(]", "([)]" };
int[] n = [1, 2, 3, 4, 1];
List<int> array = [1, 2, 3, 4];
List<int> sequence = [1, 3, 4];

List<List<string>> competitions = [["HTML", "C#"], ["C#", "Python"], ["Python", "HTML"]];
List<int> results = [0, 0, 1];
// Correct traditional syntax: Nested curly braces
List<List<int>> myList = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 }
};


ArraysAndList arraysAndList = new ArraysAndList();

List<List<int>> tranMatrix = arraysAndList.transposedMatrix(myList);
