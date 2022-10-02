// See https://aka.ms/new-console-template for more information
// Console
//    Filename
using Domain;
using Infrastructure;

Console.WriteLine("Hello, World!");

//https://github.com/commandlineparser/commandline
// read the args and then call application

var board = Board.Create(FileReader.Read80("")).Value;

for (int i = 0; i < 9; i++)
{
    Console.WriteLine(String.Join(',',board.GetRow(i)));
}