using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeLibrary
{
    public partial class LeetcodeTasks
    {
        //https://leetcode.com/problems/valid-sudoku
        public static bool IsValidSudoku(char[][] board)
        {
            int size = 9;
            HashSet<char>[] rectangles = new HashSet<char>[size];
            HashSet<char>[] horizontalLines = new HashSet<char>[size];
            HashSet<char>[] verticalLines = new HashSet<char>[size];
            for (int i = 0; i < size; ++i)
            {
                rectangles[i] = new HashSet<char>();
                horizontalLines[i] = new HashSet<char>();
                verticalLines[i] = new HashSet<char>();
            }

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    var currentChar = board[i][j];
                    if (currentChar != '.')
                    {
                        int rectangleNumber = (i / 3) * 3 + j / 3;
                        if (rectangles[rectangleNumber].Contains(currentChar) ||
                            horizontalLines[j].Contains(currentChar) ||
                            verticalLines[i].Contains(currentChar))
                        {
                            return false;
                        }

                        rectangles[rectangleNumber].Add(currentChar);
                        horizontalLines[j].Add(currentChar);
                        verticalLines[i].Add(currentChar);
                    }
                }
            }

            return true;
        }
    }
}
