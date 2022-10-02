// See https://aka.ms/new-console-template for more information
//https://github.com/commandlineparser/commandline
// read the args and then call application
using Domain;
using Infrastructure;


var board = Board.Create(FileReader.BoardWithOneHole()).Value;
board.Print();