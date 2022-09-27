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
}