namespace LeetCodeCs.ArraysAndHashing;

using System.Collections;

public static partial class Problem
{
    public static bool IsValidSudoku(char[][] board)
    {

        #region No Flattering + HashSet
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var squares = new HashSet<char>[9];

        for (var i = 0; i < 9; i++)
        {
            rows[i] = [];
            cols[i] = [];
            squares[i] = [];
        }

        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                var num = board[i][j];

                if (num == '.')
                {
                    continue;
                }

                // Check row
                if (rows[i].Contains(num))
                {
                    return false;
                }

                rows[i].Add(num);

                // Check column
                if (cols[j].Contains(num))
                {
                    return false;
                }

                cols[j].Add(num);

                // Check 3x3 square
                var squareIndex = (i / 3) * 3 + j / 3;
                if (squares[squareIndex].Contains(num))
                {
                    return false;
                }

                squares[squareIndex].Add(num);
            }
        }

        return true;
        #endregion

        /*
        #region No Flattening

        var rows = new Dictionary<int, HashSet<char>>
        {
            {0, []}, {1, []}, {2, []}, {3, []}, {4, []}, {5, []}, {6, []}, {7, []}, {8, []},
        };
        var cols = new Dictionary<int, HashSet<char>>
        {
            {0, []}, {1, []}, {2, []}, {3, []}, {4, []}, {5, []}, {6, []}, {7, []}, {8, []},
        };
        var squares = new Dictionary<(int, int), HashSet<char>>
        {
            {(0, 0), []}, {(0, 1), []}, {(0, 2), []},
            {(1, 0), []}, {(1, 1), []}, {(1, 2), []},
            {(2, 0), []}, {(2, 1), []}, {(2, 2), []},
        };

        foreach (var (row, i) in board.Select((x, i) => (x, i)))
        {
            foreach (var (cell, j) in row.Select((x, j) => (x, j)))
            {
                if (cell == '.')
                {
                    continue;
                }

                if (rows[i].Contains(cell) ||
                    cols[j].Contains(cell) ||
                    squares[(i / 3, j / 3)].Contains(cell))
                {
                    return false;
                }

                rows[i].Add(cell);
                cols[j].Add(cell);
                squares[(i / 3, j / 3)].Add(cell);
            }
        }

        return true;

        #endregion
        */

        /*
        #region Flattening + Index Math Approach
        var flattenArray = board.SelectMany(x => x).ToList();

        // Check Rows
        for (var i = 0; i < 9; i++)
        {
            var i1 = i * 9;
            char[] row =
            [
                flattenArray[i1 + 0],
                flattenArray[i1 + 1],
                flattenArray[i1 + 2],
                flattenArray[i1 + 3],
                flattenArray[i1 + 4],
                flattenArray[i1 + 5],
                flattenArray[i1 + 6],
                flattenArray[i1 + 7],
                flattenArray[i1 + 8]
            ];

            if (row.Count(x => x != '.') == row.Where(x => x != '.').Distinct().Count())
            {
                continue;
            }

            return false;
        }

        // Check Cols
        for (var i = 0; i < 9; i++)
        {
            char[] column =
            [
                flattenArray[0 * 9 + i],
                flattenArray[1 * 9 + i],
                flattenArray[2 * 9 + i],
                flattenArray[3 * 9 + i],
                flattenArray[4 * 9 + i],
                flattenArray[5 * 9 + i],
                flattenArray[6 * 9 + i],
                flattenArray[7 * 9 + i],
                flattenArray[8 * 9 + i]
            ];

            if (column.Count(x => x != '.') == column.Where(x => x != '.').Distinct().Count())
            {
                continue;
            }

            return false;
        }

        // Check Squares
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                var i1 = i * 27;
                var i2 = j * 3;

                char[] square =
                [
                    flattenArray[i1 + i2 + 0], flattenArray[i1 + i2 + 1], flattenArray[i1 + i2 + 2],
                    flattenArray[i1 + i2 + 9], flattenArray[i1 + i2 + 10], flattenArray[i1 + i2 + 11],
                    flattenArray[i1 + i2 + 18], flattenArray[i1 + i2 + 19], flattenArray[i1 + i2 + 20]
                ];

                if (square.Count(x => x != '.') == square.Where(x => x != '.').Distinct().Count())
                {
                    continue;
                }

                return false;
            }
        }

        return true;
        #endregion
        */
    }
}

