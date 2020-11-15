/*
 * @lc app=leetcode id=529 lang=csharp
 *
 * [529] Minesweeper
 */

// @lc code=start
using System;

public class Solution {
    int[] dirX={-1,0,1,-1,1,-1,0,1};
     int[] dirY={-1,-1,-1,0,0,1,1,1};

    public char[][] UpdateBoard(char[][] board, int[] click) {
        //if M stop
          // if E, dfs
        int nRow=board.Length;
        int nCol=board[0].Length;
        int clickX=click[0];
        int clickY=click[1];
        if(board[clickX][clickY]=='M') 
        {
          board[clickX][clickY]='X';
        }
        else
        {
          dfs(board,clickX,clickY,nRow,nCol);
        }
        return board;
    }

    private void dfs(char[][] board, int clickX, int clickY,int nRow,int nCol)
    {
         
        //terminate
        if(clickX<0||clickX>nRow-1||clickY<0||clickY>nCol-1) return;
       
        int count=0;
       //only E 

        for (int i = 0; i < 8; i++)
        {
            int x=clickX + dirX[i];
            int y=clickY + dirY[i];
            if(x<0||x>nRow-1||y<0||y>nCol-1) continue;
            if(board[x][y]=='M') count++;
        }

        if (count>0)
        {
           board[clickX][clickY]= (count.ToString())[0];    
        }
        else
        {
             board[clickX][clickY]='B';
            //dfs 8 directions
            for (int i = 0; i < 8; i++)
            {
                 int x=clickX + dirX[i];
                 int y=clickY + dirY[i];
                if(x<0||x>nRow-1||y<0||y>nCol-1||board[x][y]!='E') continue;
                dfs(board,x,y,nRow,nCol);
            }
        }
    }
}
// @lc code=end

