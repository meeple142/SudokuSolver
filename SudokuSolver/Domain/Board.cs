using CSharpFunctionalExtensions;


namespace Domain;

class Board
{
    int[][] _cells = new int[9][];

    private Board(int[][] numbers)
    {
        _cells = numbers;
    }

    public static Result<Board> Create(int[][] numbers)
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
        var numbers = this._cells.Clone() as int[][];
        if (numbers is null)
        {
            throw new Exception("Can not clone because numbers was null");
        }
        return new Board(numbers);
    }

    public void DoMove(Move move)
    {
        _cells[move.Row][move.Col] = move.Value;
    }

    public int[] GetRow(int index)
    {
        return _cells[index];
    }

    public int[] GetColumn(int index)
    {
        return _cells.Select(r => r[index]).ToArray();
    }

    public int[] GetBox(int index)
    {
        var list = new List<int>();
        int indexX = index % 3 * 3;
        int indexY = index / 3 * 3;

        for (int rowI = indexY; rowI < indexY + 3; rowI++)
        {
            for (int colJ = indexX; colJ < indexX + 3; colJ++)
            {
                list.Add(_cells[rowI][colJ]);
            }
        }
        return list.ToArray();
    }

    public List<Move> GetValidMoves(int x, int y)
    {
        return Enumerable.Range(1, 9).Select(i => new Move(x, y, i)).ToList();
    }

    public bool IsValid()
    {
        var numberLists = new List<int[]>();
        for (int i = 0; i < 9; i++)
        {
            numberLists.Add(GetRow(i));
            numberLists.Add(GetColumn(i));
            numberLists.Add(GetBox(i));
        }

        return numberLists.All(list => UniqueApartFromZero(list));
    }

    public bool AllCellsFull()
    {
        return _cells.SelectMany(row => row).All(cell => cell != 0);
    }

    private bool UniqueApartFromZero(int[] numbers)
    {
        var noZeros = numbers.Where(n => n > 0);
        var noZerosCount = noZeros.Count();
        var countAfterUnique = noZeros.Distinct().Count();
        return noZerosCount == countAfterUnique;
    }


}
