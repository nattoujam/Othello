using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    class GameManage
    {
        public bool IsDisplayCellCanPut { get; set; } = true; 
        public TurnState Turn { get; private set; }
        public int CurrentBlackStone { get; private set; } = 2;
        public int CurrentWhiteStone { get; private set; } = 2;
        public int TurnCount { get; private set; } = 1;

        //private Player player = new Player();
        //private readonly DefaultRule rule;
        private readonly Board board;
        private readonly Phase phase;

        public GameManage(Board board, Phase phase)
        {
            this.board = board;
            //this.rule = new DefaultRule(this.Board);
            this.phase = phase;
        }

        public void Init(TurnState playFirst)
        {
            this.Turn = playFirst;
            this.board.Init();

            //SetCanPutCells(this.Turn);
            phase.CanPutAnywhere(this.Turn);

            CurrentBlackStone = 2;
            CurrentWhiteStone = 2;
            TurnCount = 1;
        }

        public void PlayTurn(Vector2 clickedCell, out bool hadPassed)
        {
            hadPassed = false;
            try
            {
                //プレイ
                if(phase.CanPut(clickedCell))
                {
                    TurnCount++;

                    //クリックしたところに石を置く
                    //int canReverseCount = this.rule.Phase(this.GetTurnColor(Turn), clickCell);
                    int canReverseCount = phase.Play(Turn, clickedCell);

                    //石を置けた
                    if (canReverseCount != 0)
                    {
                        //置いた石の個数を更新
                        switch(this.Turn)
                        {
                            case TurnState.Black:
                                CurrentBlackStone += canReverseCount + 1;
                                CurrentWhiteStone -= canReverseCount;
                                break;
                            case TurnState.White:
                                CurrentBlackStone -= canReverseCount;
                                CurrentWhiteStone += canReverseCount + 1;
                                break;
                        }
                        
                        //ターン更新
                        this.Turn = this.GetNextTurn(Turn);

                        //ここから相手のターン//
                        //パスの可能性を吟味//

                        //ボードの更新
                        this.board.RemoveEmpty();
                        //SetCanPutCells(this.Turn);

                        //パス
                        if (!phase.CanPutAnywhere(this.Turn))
                        { 
                            //SetCanPutCells(this.GetNextTurn(Turn));
                            if(!phase.CanPutAnywhere(this.GetNextTurn(this.Turn)))
                            {
                                //ゲーム終了
                                this.Turn = TurnState.Finish;
                            }
                            else
                            {
                                TurnCount++;
                                this.Turn = this.GetNextTurn(this.Turn);
                                hadPassed = true;
                            }
                        }
                    }
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("canPutCellsの中身がないよ！", "エラー");
            }
        }

        public WinnerState GetWinner()
        {
            if (CurrentBlackStone > CurrentWhiteStone) return WinnerState.Black;
            else if (CurrentBlackStone < CurrentWhiteStone) return WinnerState.White;
            else return WinnerState.Draw;
        }
        
        /*
        private void SetCanPutCells(TurnState check)
        {
            Vector2 length = this.Board.GetBoardLength();
            canPutCells = new List<Vector2>();
            //cellColorTypes oppositeColor = this.rule.GetOppositeColor(this.GetTurnColor(turn));
            for (int x = 1; x < length.X - 1; x++)
            {
                for (int y = 1; y < length.Y - 1; y++)
                {
                    Vector2 here = new Vector2(x, y);

                    //既に置いてある石は無視
                    if (this.Board.GetCellColor(here) != CellColorTypes.Empty) continue;

                    //返せる石が存在しない場所は無視
                    try
                    {
                        if (this.rule.GetReverseCells(this.GetTurnColor(check), here).Count == 0) continue;
                    }
                    catch
                    {
                        MessageBox.Show("GetTurnColorで不正な呼び出しがされました。", "エラー");
                        throw;
                    }
                    
                    this.canPutCells.Add(here);
                    this.Board.CellUpdate(CellColorTypes.CanReverse, here);
                }
            }
        }
        */

        private TurnState GetNextTurn(TurnState currentTurn) 
        {
            TurnState nextTurn;

            switch (currentTurn)
            {
                case TurnState.Black:
                    nextTurn = TurnState.White;
                    break;
                case TurnState.White:
                    nextTurn = TurnState.Black;
                    break;
                default:
                    nextTurn = TurnState.Finish;
                    break;
            }

            return nextTurn;
        }
    }
}
