using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    class DefaultPhase : Phase
    {
        public DefaultPhase(Board board) : base(board) { }

        public override int Play(TurnState myColor, Vector2 clickedCell)
        {

            //石を置ける
            //if (this.board.GetCellColor(clickedCell) == CellColorTypes.CanReverse)
            //{
            //石を置いて，裏返す
            baseRule.PutStone(myColor, clickedCell);
            List<Vector2> reverseList = baseRule.GetReverseCells(myColor, clickedCell);
            int reversed = reverseList.Count();
            baseRule.Reverse(myColor, reverseList);
            Console.WriteLine($"reversed: {reversed}");
            //}
            return reversed;
        }
    }
}
