using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello_v1._0
{
    class AllRevolutionPhase : Phase
    {
        public AllRevolutionPhase(Board board): base(board) { }
        public override int Play(CellColorTypes myColor, Vector2 clickedCell)
        {
            int reversed = 0;

            //石を置ける
            if (this.board.GetCellColor(clickedCell) == CellColorTypes.CanReverse)
            {
                //角に置いたのなら，すべての石を裏返す
                var corners = board.GetCorner();
                if (corners.Contains(clickedCell))
                {
                    var blackCells = new List<Vector2>();
                    var whiteCells = new List<Vector2>();
                    Vector2 length = board.GetBoardLength();
                    for (int x = 1; x < length.X - 1; x++)
                    {
                        for (int y = 1; y < length.Y - 1; y++)
                        {
                            Vector2 l = new Vector2(x, y);
                            Console.WriteLine($"{l.X}, {l.Y}");
                            if (board.GetCellColor(l) == CellColorTypes.Black)
                            {
                                blackCells.Add(l);
                            }
                            else if (board.GetCellColor(l) == CellColorTypes.White)
                            {
                                whiteCells.Add(l);
                            }
                        }
                    }
                    baseRule.Reverse(CellColorTypes.White, blackCells);
                    baseRule.Reverse(CellColorTypes.Black, whiteCells);

                    reversed += (myColor == CellColorTypes.Black) ? whiteCells.Count() : blackCells.Count();
                    reversed -= (myColor == CellColorTypes.Black) ? blackCells.Count() : whiteCells.Count();
                    Console.WriteLine(reversed);

                    //選択したセルに石を置く
                    baseRule.PutStone(myColor, clickedCell);
                    return reversed;
                }

                //石を置いて，裏返す
                baseRule.PutStone(myColor, clickedCell);
                var reverseList = baseRule.GetReverseCells(myColor, clickedCell);
                reversed += reverseList.Count();
                baseRule.Reverse(myColor, reverseList);
            }
            return reversed;
        }
    }
}
