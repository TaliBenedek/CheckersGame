using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public class Player
    {
        //TO DO (extract) 
    }
    public class AlphaBeta
    {
        public static double GetAlphaBetaValue(Board board, int depth, double alpha, double beta, Player player)
        {
            double value;
            if (depth == 0) //reached end of tree
            {
                value = board.GetHeuristicValue();
            }
            else if (board.IsGameOver())
            {
                value = board.GetHeuristicValue();
            }
            else
            {
                Player opponent = player == Player.Max ? Player.Min : Player.Max;
                if (player == Player.Max)//computer's turn
                {
                    Move[] potentialMoves = board.GetLegalMoves(player);
                    for (int index = 0; index < potentialMoves.Length; index++)
                    {
                        Board nextBoard = board.PlayMove(potentialMoves[index]);
                        double nextBoardValue = GetAlphaBetaValue(nextBoard, depth - 1, alpha, beta, opponent);
                        if (nextBoardValue > alpha)
                        {
                            alpha = nextBoardValue;
                        }
                        if (beta <= alpha)
                        {
                            break;
                        }
                    }
                    value = alpha;
                }
                else //user's turn
                {
                    Move[] potentialMoves = board.GetLegalMoves(player);
                    for (int index = 0; index < potentialMoves.Length; index++)
                    {
                        Board nextBoard = board.PlayMove(potentialMoves[index]);
                        double nextBoardValue = GetAlphaBetaValue(nextBoard, depth - 1, alpha, beta, opponent);
                        if (nextBoardValue < beta)
                        {
                            beta = nextBoardValue;
                        }
                        if (beta <= alpha)
                        {
                            break;
                        }
                    }
                    value = beta;
                }               
            }
            return value;
        }
    }
}

