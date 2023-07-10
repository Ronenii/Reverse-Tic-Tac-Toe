using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace GameLogic
{
    public class AiPlayer: Player
    {
        private enum eGameState
        {
            P1Wins,
            P2Wins,
            Draw,
            Ongoing
        }
        private class GameStateNode
        {
            public Board CurrentBoard { get; set; }
            public eCellType CurrentPlayerCellType { get; set; }
            public Point LastMove { get; set; }
            public int Score { get; set; }

        }

        private readonly int r_MaxDepth;
        private const string k_AiName = "Computer";

        public AiPlayer(ePlayers i_PlayerId, int i_Score, eCellType i_CellType, int i_MaxDepth): base(i_PlayerId, i_CellType, i_Score, k_AiName)
        {
            r_MaxDepth = i_MaxDepth;
        }

        // Randomize the computer turn
        public Point PlayTurn(Board i_GameBoard, int i_BoardSize)
        {
            int bestScore = int.MinValue;
            Point bestMove = Point.Empty;

            foreach (Point move in getAvailableMoves(i_GameBoard))
            {
                Board newBoard = i_GameBoard.Copy();
                newBoard.BoardCells[move.X, move.Y] = this.CellType;

                GameStateNode currentState = new GameStateNode
                {
                    CurrentBoard = newBoard,
                    CurrentPlayerCellType = getOpponent(this.CellType),
                    LastMove = move,
                    Score = 0
                };

                int score = AlphaBeta(currentState, r_MaxDepth, int.MinValue, int.MaxValue,false);
                if (score > bestScore)
                {
                    bestScore = score;
                    bestMove = move;
                }
            }

            return bestMove;
        }

        private int AlphaBeta(GameStateNode i_Node, int i_Depth, int i_Alpha, int i_Beta, bool i_IsMaximizingPlayer)
        {
            eGameState gameState = getGameState(i_Node.CurrentBoard);
            if (i_Depth == 0 || gameState != eGameState.Ongoing)
            {
                i_Node.Score = getScore(gameState);
                return i_Node.Score;
            }

            if (i_IsMaximizingPlayer)
            {
                int maxEval = int.MinValue;

                foreach (Point move in getAvailableMoves(i_Node.CurrentBoard))
                {
                    Board newBoard = i_Node.CurrentBoard.Copy();
                    newBoard.BoardCells[move.X, move.Y] = this.CellType;

                    GameStateNode newState = new GameStateNode
                    {
                        CurrentBoard = newBoard,
                        CurrentPlayerCellType = getOpponent(this.CellType),
                        LastMove = move,
                        Score = 0
                    };

                    int eval = AlphaBeta(newState, i_Depth - 1, i_Alpha, i_Beta, false);
                    maxEval = Math.Max(maxEval, eval);
                    i_Alpha = Math.Max(i_Alpha, eval);
                    if (i_Beta <= i_Alpha)
                    {
                        break;
                    }
                }

                i_Node.Score = maxEval;
                return maxEval;
            }
            else
            {
                int minEval = int.MaxValue;

                foreach (Point move in getAvailableMoves(i_Node.CurrentBoard))
                {
                    Board newBoard = i_Node.CurrentBoard.Copy();
                    newBoard.BoardCells[move.X, move.Y] = this.CellType;

                    GameStateNode newState = new GameStateNode
                    {
                        CurrentBoard = newBoard,
                        CurrentPlayerCellType = getOpponent(this.CellType),
                        LastMove = move,
                        Score = 0
                    };

                    int eval = AlphaBeta(newState, i_Depth - 1, i_Alpha, i_Beta, true);
                    minEval = Math.Min(minEval, eval);
                    i_Alpha = Math.Min(i_Beta, eval);
                    if (i_Beta <= i_Alpha)
                    {
                        break;
                    }
                }

                i_Node.Score = minEval;
                return minEval;
            }
        }

        // Returns the current state of the game on the given board
        private eGameState getGameState(Board i_Board)
        {
            if (i_Board.TurnsLeft == 0)
            {
                return eGameState.Draw;
            }

            for (int i = 0; i < i_Board.BoardSize; i++)
            {
                if (i_Board.IsColumnSameShape(i))
                {
                    if (i_Board.BoardCells[0, i] == CellType)
                    {
                        return eGameState.P2Wins;
                    }
                    else
                    {
                        return eGameState.P1Wins;
                    }
                }

                if (i_Board.IsRowSameShape(i))
                {
                    if (i_Board.BoardCells[i, 0] == CellType)
                    {
                        return eGameState.P2Wins;
                    }
                    else
                    {
                        return eGameState.P1Wins;
                    }
                }

                if (i_Board.IsDiagonalSameShape(eDiagonal.TopLeftToBottomRight) || i_Board.IsDiagonalSameShape(eDiagonal.BottomLeftToTopRight))
                {
                    if (i_Board.BoardCells[i, i] == CellType)
                    {
                        return eGameState.P2Wins;
                    }
                    else
                    {
                        return eGameState.P1Wins;
                    }
                }
            }

            return eGameState.Ongoing;
        }

        // Evaluates a score for the move based on the given game state
        private int getScore(eGameState i_CurrentGameState)
        {
            if (i_CurrentGameState == eGameState.P1Wins)
            {
                return -1;
            }
            else if (i_CurrentGameState == eGameState.P2Wins)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Returns all available moves in the board.
        private Point[] getAvailableMoves(Board i_GameBoard)
        {
            int boardSize = i_GameBoard.BoardSize;
            int numOfAvalableCells = 0;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i_GameBoard.BoardCells[i, j] == eCellType.Empty)
                    {
                        numOfAvalableCells++;
                    }
                }
            }

            Point[] moves = new Point[numOfAvalableCells];
            int index = 0;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i_GameBoard.BoardCells[i, j] == eCellType.Empty)
                    {
                        moves[index++] = new Point(i, j);
                    }
                }
            }

            return moves;
        }

        private eCellType getOpponent(eCellType i_CurrentPlayer)
        {
            if (i_CurrentPlayer == eCellType.Cross)
            {
                return eCellType.Circle;
            }
            else
            {
                return eCellType.Cross;
            }
        }
    }
}
