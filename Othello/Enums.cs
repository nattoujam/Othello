using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    public enum CellColorTypes
    {
        Empty,
        Black,
        White,
        CanReverse,
    }

    public enum TurnState
    {
        Black,
        White,
        Finish
    }

    public enum WinnerState
    {
        Black,
        White,
        Draw
    }

    public enum Rules
    {
        Normal,
        Revolution,
        AllRevolution
    }
    static class Enums
    {
        public static CellColorTypes ToCellColor(TurnState turn)
        {
            CellColorTypes currentTurnColor;

            switch (turn)
            {
                case TurnState.Black:
                    currentTurnColor = CellColorTypes.Black;
                    break;
                case TurnState.White:
                    currentTurnColor = CellColorTypes.White;
                    break;
                default:
                    currentTurnColor = CellColorTypes.Empty;
                    break;
            }

            return currentTurnColor;
        }
        public static string StateName(TurnState state)
        {
            string[] names = { "黒", "白", "ゲーム終了" };
            return names[(int)state];
        }

        public static string WinnerName(WinnerState winner)
        {
            string[] names = { "黒の勝ち", "白の勝ち", "引き分け" };
            return names[(int)winner];
        }

        public static string RuleName(Rules rule)
        {
            string[] names = { "ノーマル", "革命(角のみ)", "革命" };
            return names[(int)rule];
        }
    }
}
