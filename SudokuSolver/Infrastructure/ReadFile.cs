//    Read file convert to int[][]
//        1-9, 0 = blank cell
//        Ignore white space, except \r or \n, so user can space how they want
namespace Infrastructure;
public static class FileReader
{
    public static int[][] Read(string path)
    {
        int[][] board = new int[][] {
             new int[] {0,0,0, 0,0,0, 0,0,0},
             new int[] {0,0,0, 0,0,0, 0,0,0},
             new int[] {0,0,0, 0,0,0, 0,0,0},

             new int[] {0,0,0, 0,0,0, 0,0,0},
             new int[] {0,0,0, 0,0,0, 0,0,0},
             new int[] {0,0,0, 0,0,0, 0,0,0},

             new int[] {0,0,0, 0,0,0, 0,0,0},
             new int[] {0,0,0, 0,0,0, 0,0,0},
             new int[] {0,0,0, 0,0,0, 0,0,0}
             };
        return board;
    }
    public static int[][] Read80()
    {
        int[][] board = new int[][] {
            new int[] {0,1,2, 3,4,5, 6,7,8},
            new int[] {9,10,11, 12,13,14, 15,16,17},
            new int[] {18,19,20, 21,22,23, 24,25,26},

            new int[] {27,28,29, 30,31,32, 33,34,35},
            new int[] {36,37,38, 39,40,41, 42,43,44},
            new int[] {45,46,47, 48,49,50, 51,52,53},

            new int[] {54,55,56, 57,58,59, 60,61,62},
            new int[] {63,64,65, 66,67,68, 69,70,71},
            new int[] {72,73,74, 75,76,77, 78,79,80}
            };
        return board;
    }
    public static int[][] ReadBox()
    {
        int[][] board = new int[][] {
            new int[] {0,0,0, 1,1,1, 2,2,2},
            new int[] {0,0,0, 1,1,1, 2,2,2},
            new int[] {0,0,0, 1,1,1, 2,2,2},

            new int[] {3,3,3, 4,4,4, 5,5,5},
            new int[] {3,3,3, 4,4,4, 5,5,5},
            new int[] {3,3,3, 4,4,4, 5,5,5},

            new int[] {6,6,6, 7,7,7, 8,8,8},
            new int[] {6,6,6, 7,7,7, 8,8,8},
            new int[] {6,6,6, 7,7,7, 8,8,8},
        };

        return board;
    }

    public static int[][] BoardWithOneHole()
    {
        List<List<int>> rows = new();

        for (int i = 0; i < 9; i++)
        {
            rows.Add(new List<int>());
            for (int j = i; j < i + 9; j++)
            {
                rows[i].Add((j % 9) + 1);
            }
        }

        //blank the top left cell
        rows[0][0] = 0;

        return rows.Select(row => row.ToArray()).ToArray();
    }
}