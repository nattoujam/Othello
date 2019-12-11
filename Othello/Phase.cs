using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    abstract class Phase
    {
        protected readonly Board board;
        protected readonly BaseRule baseRule;

        private List<Vector2> canPutCells;

        public Phase(Board board)
        {
            this.board = board;
            baseRule = new BaseRule(board);
        }

        /// <summary>
        /// clickedCellへ石を置いて裏返すなどの1ターンに行われる処理。
        /// 裏返した石の総数を返す。
        /// </summary>
        /// <param name="myColor"></param>
        /// <param name="clickedCell"></param>
        /// <returns>
        /// 裏返す石の総数
        /// </returns>
        public abstract int Play(TurnState myColor, Vector2 clickedCell);

        /// <summary>
        /// clickedCellに石が置けるならtrue
        /// </summary>
        /// <param name="state"></param>
        /// <param name="clickedCell"></param>
        /// <returns></returns>
        public bool CanPut(Vector2 clickedCell)
        {
            return canPutCells.Contains(clickedCell);
        }

        /// <summary>
        /// どこかに石を置けるならtrue
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool CanPutAnywhere(TurnState state)
        {
            canPutCells = baseRule.GetCanPutCells(state);
            return canPutCells.Count != 0;
        }
    }
}
