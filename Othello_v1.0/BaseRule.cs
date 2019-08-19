using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello_v1._0
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
                        if (GetReverseCells(Enums.ToCellColor(check), here).Count == 0) continue;
                    }
                    catch
                    {
                        MessageBox.Show("GetTurnColorで不正な呼び出しがされました。", "エラー");
                        throw;
                    }

                    board.CellUpdate(CellColorTypes.CanReverse, here);
                    canPutCells.Add(here);
                }
            }
            return canPutCells;
        }

        public List<Vector2> GetReverseCells(CellColorTypes _myColor, Vector2 _vector2)
        {
            //Vector2 にしろ
            int[,] unitVector = new int[,] { {0, 1}, {1, 1}, {1, 0},{1, -1}, {0, -1}, {-1, -1}, {-1, 0}, {-1, 1} };
            //List<Vector2> tempList = new List<Vector2>();
            List<Vector2> list = new List<Vector2>();

            for (int i = 0; i < unitVector.GetLength(0); i++)
            {
                List<Vector2> tempList = new List<Vector2>();
                for (int k = 1; ; k++)
                {
                    Vector2 currentCell = new Vector2(_vector2.X + k * unitVector[i, 0], _vector2.Y + k * unitVector[i, 1]);

                    if (this.board.GetCellColor(currentCell) == GetOppositeColor(_myColor))
                    {
                        tempList.Add(currentCell);
                    }
                    else if(this.board.GetCellColor(currentCell) == _myColor)
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

        /*
        /// <summary>
        /// 置けたら新しく石を置き，裏返した石の個数を返す
        /// </summary>
        /// <param name="_mycolor">新しく置く石の色</param>
        /// <param name="_input">新しく置く石の座標</param>
        /// <returns></returns>
        public int Phase(CellColorTypes _mycolor, Vector2 _input)
        {
            int canReverse = 0;

            //石を置ける
            if (this.board.GetCellColor(_input) == CellColorTypes.CanReverse)
            {
                //前処理
                Reverse(_mycolor, addRule.BeforeProcess(board, _input, _mycolor));

                //石を置いて，裏返す
                PutStone(_mycolor, _input);
                List<Vector2> reverseList = GetReverseCells(_mycolor, _input);
                canReverse = reverseList.Count();
                Reverse(_mycolor, reverseList);

                //後処理
                Reverse(_mycolor, addRule.AfterProcess(board, _input, _mycolor));
            }

            return canReverse;
        }
        */

        public void PutStone(CellColorTypes _color, Vector2 _vector2)
        {
             this.board.CellUpdate(_color, _vector2);
        }

        /// <summary>
        /// listの石を裏返す(_colorにする)
        /// </summary>
        /// <param name="_color"></param>
        /// <param name="_vector2"></param>
        public void Reverse(CellColorTypes _color, List<Vector2> list)
        {
            
            if (list.Count != 0)
            {
                foreach (Vector2 i in list)
                {
                    this.board.CellUpdate(_color, i);
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
