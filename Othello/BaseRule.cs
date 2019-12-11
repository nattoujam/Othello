using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    class BaseRule
    {
        //public List<Vector2> CanPutCells { get; private set; }

        private readonly Board board;

        public BaseRule(Board _board)
        {
            this.board = _board;
        }

        public List<Vector2> GetCanPutCells(TurnState check)
        {
            Vector2 length = board.GetBoardLength();
            List<Vector2>canPutCells = new List<Vector2>();
            //cellColorTypes oppositeColor = this.rule.GetOppositeColor(this.GetTurnColor(turn));
            for (int x = 1; x < length.X - 1; x++)
            {
                for (int y = 1; y < length.Y - 1; y++)
                {
                    Vector2 here = new Vector2(x, y);

                    //既に置いてある石は無視
                    if (board.GetCellColor(here) != CellColorTypes.Empty) continue;

                    //返せる石が存在しない場所は無視
                    try
                    {
                        if (GetReverseCells(check, here).Count == 0) continue;
                    }
                    catch
                    {
                        MessageBox.Show("GetTurnColorで不正な呼び出しがされました。", "エラー");
                        throw;
                    }

                    board.BoardColorUpdate(CellColorTypes.CanReverse, here);
                    canPutCells.Add(here);
                }
            }
            return canPutCells;
        }

        public List<Vector2> GetReverseCells(TurnState _myColor, Vector2 _vector2)
        {
            //TODO: Vector2 にしろ
            int[,] unitVector = new int[,] { {0, 1}, {1, 1}, {1, 0},{1, -1}, {0, -1}, {-1, -1}, {-1, 0}, {-1, 1} };
            //List<Vector2> tempList = new List<Vector2>();
            List<Vector2> list = new List<Vector2>();

            for (int i = 0; i < unitVector.GetLength(0); i++)
            {
                List<Vector2> tempList = new List<Vector2>();
                for (int k = 1; ; k++)
                {
                    Vector2 currentCell = new Vector2(_vector2.X + k * unitVector[i, 0], _vector2.Y + k * unitVector[i, 1]);

                    if (this.board.GetCellColor(currentCell) == GetOppositeColor(Enums.ToCellColor(_myColor)))
                    {
                        tempList.Add(currentCell);
                    }
                    else if(this.board.GetCellColor(currentCell) == Enums.ToCellColor(_myColor))
                    {
                        list.AddRange(tempList);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return list;
        }

        public void PutStone(TurnState myColor, Vector2 _vector2)
        {
             this.board.BoardColorUpdate(Enums.ToCellColor(myColor), _vector2);
        }

        /// <summary>
        /// listの石を裏返す(渡したTurnStateの色にする)
        /// </summary>
        /// <param name="_color"></param>
        /// <param name="_vector2"></param>
        public void Reverse(TurnState state, List<Vector2> list)
        {
            
            if (list.Count != 0)
            {
                foreach (Vector2 i in list)
                {
                    this.board.BoardColorUpdate(Enums.ToCellColor(state), i);
                    this.board.BoardReverseUpdate(true, i);
                }
            }
        }

        public CellColorTypes GetOppositeColor(CellColorTypes _color)
        {
            return _color == CellColorTypes.Black ? CellColorTypes.White : 
                   _color == CellColorTypes.White ? CellColorTypes.Black : 
                   CellColorTypes.Empty;
        }
    }
}
