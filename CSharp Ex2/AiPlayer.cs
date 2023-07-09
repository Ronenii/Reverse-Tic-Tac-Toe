using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace GameLogic
{
    public class AiPlayer: Player
    {
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

        private int AlphaBeta(GameStateNode node, int depth, int alpha, int beta, bool isMaximizingPlayer)
        {

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
