using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello_v1._0
{
    class DefaultPhase : Phase
    {
        public DefaultPhase(Board board) : base(board) { }

        public override int Play(CellColorTypes myColor, Vector2 clickedCell)
        {
            int reversed = 0;

            //石を置ける
            if (this.board.GetCellColor(clickedCell) == CellColorTypes.CanReverse)
            {
                //石を置いて，裏返す
                baseRule.PutStone(myColor, clickedCell);
                List<Vector2> reverseList = baseRule.GetReverseCells(myColor, clickedCell);
                reversed = reverseList.Count();
                baseRule.Reverse(myColor, reverseList);
            }
            return reversed;
        }
    }
}
