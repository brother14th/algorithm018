/*
 * @lc app=leetcode id=874 lang=csharp
 *
 * [874] Walking Robot Simulation
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        //0:N, 1:E, 2:S, 3:W
        int x=0;
        int y=0;
        int direction=0; 
        int[,] forward=new int[,]{{0,1},{1,0},{0,-1},{-1,0}};
        int result=0;
        //obstacles
        HashSet<long> obstaclesSet=new HashSet<long>();
       foreach (var obs in obstacles)
        {
          //x+30000*2^16 + y+30000
          long code= ((long)(obs[0]+30000)<<16)+ (long)(obs[1]+30000);
          obstaclesSet.Add(code);
        }
        //for loop 
           //if -2 set direction
           //if -1 set direction
           //else 
             //advance pos by 1 
               //check pos in obstacle
                 //yes break 
                 //no update pos
       foreach (var command in commands)
       {
           if (command==-2) direction=(direction==0?3:direction-1);
           else if (command==-1) direction=(direction==3?0:direction+1);
           else 
           {
              for (int i = 1; i <= command; i++)
              {
                  int tmpX =x+forward[direction,0];
                  int tmpY =y+forward[direction,1];
                  long code=((long)(tmpX+30000)<<16)+ (long)(tmpY+30000);
                  if (obstaclesSet.Contains(code)) break;
                  x=tmpX;
                  y=tmpY;
                  result=Math.Max(result,x*x+y*y);
              }
           }
       }

      return result;
    }
}
// @lc code=end

