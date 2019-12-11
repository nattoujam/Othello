using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public struct Vector2
    {
        public int X { get; }
        public int Y { get; }

        public Vector2(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }

    public struct BoardUnit
    {
        public CellColorTypes ColorType { get; set; }
        public bool IsReverse { get; set; }
        public BoardUnit(CellColorTypes c, bool b)
        {
            ColorType = c;
            IsReverse = b;
        }
    }

    class Board
    {
        private const int size = 10;

        //public CellColorTypes[,] board { get; } = new CellColorTypes[size, size];
        public BoardUnit[,] board { get; private set; } = new BoardUnit[size, size];


        public void Init()
        {
            //盤生成
            for(int x = 0; x < size; x++)
            {
                for(int y = 0; y < size; y++)
                {
                    this.board[x, y] = new BoardUnit(CellColorTypes.Empty, false);
                } 
            }

            //初期配置
            this.board[4, 4].ColorType = CellColorTypes.Black;
            this.board[5, 5].ColorType = CellColorTypes.Black;
            this.board[4, 5].ColorType = CellColorTypes.White;
            this.board[5, 4].ColorType = CellColorTypes.White;
        }

        public void RemoveCanReverse()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    switch(this.board[x, y].ColorType)
                    {
                        case CellColorTypes.CanReverse:
                            BoardColorUpdate(CellColorTypes.Empty, new Vector2(x, y));
                            break;
                    }
                }
            }
        }

        public void BoardColorUpdate(CellColorTypes _color, Vector2 _vector2)
        {
            this.board[_vector2.X, _vector2.Y].ColorType = _color;
        }

        public void BoardReverseUpdate(bool b, Vector2 v)
        {
            this.board[v.X, v.Y].IsReverse = b;
        }

        public CellColorTypes GetCellColor(Vector2 _vector2)
        {
            return this.board[_vector2.X, _vector2.Y].ColorType;
        }

        public bool IsReverse(Vector2 v)
        {
            return this.board[v.X, v.Y].IsReverse;
        }

        public Vector2 GetBoardLength()
        {
            Vector2 length = new Vector2(size, size);
            return length;
        }

        public List<Vector2> GetCorner()
        {
            return new List<Vector2> { new Vector2(1, 1),
                                       new Vector2(1, size - 2),
                                       new Vector2(size - 2, 1),
                                       new Vector2(size - 2, size - 2)};
        }
    }
}
