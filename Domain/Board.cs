using CSharpFunctionalExtensions;


namespace Domain;

class Board
{
    int[][] _cells;

    private Board(int[][] numbers)
    {
        _cells = numbers;
    }

    public Result<Board> Create(int[][] numbers)
    {
        //validate board
        //Validate width, Validate height, 
        //Run isValid
        return Result.Success(new Board(numbers));
    }

    public bool IsAllCellsFilled()
    {
        return _cells.All(row => row.All(cell => cell != 0));
    }

    public Board Clone()
    {
        return new Board(this._cells);
    }

    public void DoMove(Move move)
    {
        _cells[move.Row][move.Col] = move.Value;
    }
    public bool IsValid()
    {
        //  No doubles in rows, cells, boxes
        return true;
    }
    public List<Move> GetValidMoves(int x, int y)
    {
        return new();
    }
}
