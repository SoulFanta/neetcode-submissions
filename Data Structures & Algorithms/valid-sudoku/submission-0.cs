public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
HashSet<char>[] columns = new HashSet<char>[board[0].Length];
HashSet<char>[] square = new HashSet<char>[9];

for (int i = 0; i < columns.Length; i++)
{
    columns[i] = new HashSet<char>();
}
for (int i = 0; i < square.Length; i++)
{
    square[i] = new HashSet<char>();
}

for (int i = 0; i < board.Length; i++)
{

    HashSet<char> rowSet = new HashSet<char>();
    for (int j = 0; j < board[i].Length; j++)
    {
        char value = board[i][j];
        if (value == '.') continue;
        if (!columns[j].Add(value)) return false;
        if (!rowSet.Add(value)) return false;
        if (!square[(j / 3) * 3 + (i / 3)].Add(value)) return false;

    }
}
return true;

    }
}
