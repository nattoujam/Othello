using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello_v1._0
{
    class RevolutionPhase : Phase
    {
        public RevolutionPhase(Board board) : base(board) { }
        public override int Play(TurnState myColor, Vector2 clickedCell)
        {
            int reversed = 0;

            ////石を置ける
            //if (this.board.GetCellColor(clickedCell) == CellColorTypes.CanReverse)
            //{
                //角に置いたのなら，他のすべての角の石を裏返す
                var corners = board.GetCorner();
                if (corners.Contains(clickedCell)) {
                    var blackCorner = new List<Vector2>();
                    var whiteCorner = new List<Vector2>();
                    foreach(var l in corners)
                    {
                        Console.WriteLine($"{l.X}, {l.Y}");
                        if(board.GetCellColor(l) == CellColorTypes.Black)
                        {
                            blackCorner.Add(l);
                        }
                        else if (board.GetCellColor(l) == CellColorTypes.White)
                        {
                            whiteCorner.Add(l);
                        }
                    }
                    baseRule.Reverse(TurnState.White, blackCorner);
                    baseRule.Reverse(TurnState.Black, whiteCorner);

                    reversed += (myColor == TurnState.Black) ? whiteCorner.Count() : blackCorner.Count();
                    reversed -= (myColor == TurnState.Black) ? blackCorner.Count() : whiteCorner.Count();
                    Console.WriteLine(reversed);
                }

                //石を置いて，裏返す
                baseRule.PutStone(myColor, clickedCell);
                var reverseList = baseRule.GetReverseCells(myColor, clickedCell);
                reversed += reverseList.Count();
                baseRule.Reverse(myColor, reverseList);
            //}
            return reversed;
        }
    }
}
