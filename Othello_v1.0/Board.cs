using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello_v1._0
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

    class Board
    {
        public CellColorTypes[,] board { get; } = new CellColorTypes[size, size];

        private const int size = 10;
        
        public Board()
        {

        }

        public void Init()
        {
            //盤生成
            for(int x = 0; x < size; x++)
            {
                for(int y = 0; y < size; y++)
                {
                    this.board[x, y] = CellColorTypes.Empty;
                } 
            }

            //初期配置
            this.board[4, 4] = CellColorTypes.Black;
            this.board[5, 5] = CellColorTypes.Black;
            this.board[4, 5] = CellColorTypes.White;
            this.board[5, 4] = CellColorTypes.White;
        }

        public void BoardUpdate()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if(this.board[x, y] == CellColorTypes.CanReverse)
                    {
                        Vector2 v2 = new Vector2(x, y);
                        CellUpdate(CellColorTypes.Empty, v2);
                    }
                }
            }
        }

        public void CellUpdate(CellColorTypes _color, Vector2 _vector2)
        {
            this.board[_vector2.X, _vector2.Y] = _color;
        }

        public CellColorTypes GetCellColor(Vector2 _vector2)
        {
            return this.board[_vector2.X, _vector2.Y];
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
