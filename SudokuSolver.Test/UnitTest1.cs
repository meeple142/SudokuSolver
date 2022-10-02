using Domain;
using Infrastructure;

namespace SudokuSolver.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var board = Board.Create(FileReader.BoardWithOneHole()).Value;

        }


    }
}