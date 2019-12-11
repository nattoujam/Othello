using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    class WindPressurePhase : Phase
    {
        private readonly int range = 3;
        public WindPressurePhase(Board b): base(b) { }
        public override int Play(TurnState myColor, Vector2 clickedCell)
        {
            //石を裏返す
            var reverseList = this.baseRule.GetReverseCells(myColor, clickedCell);
            int reversed = reverseList.Count();
            //int reversed = 0;
            this.baseRule.Reverse(myColor, reverseList);

            //十字に石を裏返す
            var blackCells = new List<Vector2>();
            var whiteCells = new List<Vector2>();
            //horizontal
            var length = this.board.GetBoardLength().Y - 1;
            var start = clickedCell.X - this.range < 0 ? 1 : clickedCell.X - this.range;
            var end = clickedCell.X + this.range > length ? length : clickedCell.X + this.range + 1;
            //Console.WriteLine($"horizontal {start} - {end}");
            for (int i = start; i < end; i++)
            {
                var vh = new Vector2(i, clickedCell.Y);
                if (this.board.GetCellColor(vh) == CellColorTypes.Black)
                {
                    blackCells.Add(vh);
                }
                else if(this.board.GetCellColor(vh) == CellColorTypes.White)
                {
                    whiteCells.Add(vh);
                }
            }
            //vertical
            length = this.board.GetBoardLength().X - 1;
            start = clickedCell.Y - this.range < 0 ? 1 : clickedCell.Y - this.range;
            end = clickedCell.Y + this.range > length ? length : clickedCell.Y + this.range + 1;
            //Console.WriteLine($"vertical {start} - {end}");
            for (int i = start; i < end; i++)
            {
                var vv = new Vector2(clickedCell.X, i);
                if(this.board.GetCellColor(vv) == CellColorTypes.White)
                {
                    whiteCells.Add(vv);
                }
                else if (this.board.GetCellColor(vv) == CellColorTypes.White)
                {
                    blackCells.Add(vv);
                }
            }
            baseRule.Reverse(TurnState.White, blackCells);
            baseRule.Reverse(TurnState.Black, whiteCells);
            Console.WriteLine($"reversed: {reversed}");
            reversed += (myColor == TurnState.Black) ? whiteCells.Count() : blackCells.Count();
            Console.WriteLine($"reversed + {myColor}: {reversed}");
            reversed -= (myColor == TurnState.Black) ? blackCells.Count() : whiteCells.Count();
            Console.WriteLine($"reversed + {this.baseRule.GetOppositeColor(Enums.ToCellColor(myColor))}: {reversed}");

            //石を置く
            this.baseRule.PutStone(myColor, clickedCell);

            return reversed;
        }

        private IEnumerator<int> getLinedRange(int clicked, bool isVertical)
        {
            var length = isVertical ? this.board.GetBoardLength().X : this.board.GetBoardLength().Y;
            var start = clicked - this.range < 0 ? 0 : clicked - this.range;
            var end = clicked + this.range > length ? length : clicked + this.range;
            for(int i = start; i < end; i++)
            {
                yield return i;
            }
        }
    }
}
