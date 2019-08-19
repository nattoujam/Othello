using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello_v1._0
{
    public partial class PlayForm : Form
    {
        private readonly bool Debug = StartForm.Debug;

        private readonly GameManage gm;
        private readonly Player player;
        private readonly Cell[,] cells = new Cell[8, 8];    //boardの実体
        private readonly Board board;                       //形式化したボード
        private const TurnState PlayFirst = TurnState.Black; //先攻は黒

        public PlayForm(Rules rule)
        {
            InitializeComponent();
            RuleName.Text = $"ルール: {Enums.RuleName(rule)}";
            debug1.Visible = Debug;

            //initialize board
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    var cell = new Cell(1.5f);
                    cell.Location = new Point(x * cell.Width, y * cell.Height);
                    cell.CellColor = CellColorTypes.Empty;
                    cell.Click += this.Cell_Click;

                    //外枠は描画しない（ばんぺい君）
                    if (x % 9 == 0 || y % 9 == 0)
                    {
                        continue;
                    }

                    this.cells[x - 1, y - 1] = cell;
                    this.Controls.Add(cell);
                }
            }

            this.board = new Board();

            //select rule
            Phase phase;
            switch (rule)
            {
                case Rules.Revolution:
                    phase = new RevolutionPhase(board);
                    break;
                case Rules.AllRevolution:
                    phase = new AllRevolutionPhase(board);
                    break;
                default:
                    phase = new DefaultPhase(board);
                    break;
            }
            this.gm = new GameManage(board, phase);

            this.player = new Player();

            //this.gm.isDisplayCellCanPut = false;

            this.gm.Init(PlayFirst);
            this.UpdateState();
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Vector2 clicked = this.player.GetClickCell(sender);

            debug1.Text = $"clicked: {clicked.X}, {clicked.Y}";

            bool hadPassed;
            this.gm.PlayTurn(clicked, out hadPassed);
            this.UpdateState();

            if (hadPassed) MessageBox.Show("パス！！！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gm.Init(PlayFirst);
            this.UpdateState();
        }

        private void UpdateState()
        {
            this.currentTurn.Text = Enums.StateName(this.gm.Turn);
            this.currentTurn.ForeColor = (this.gm.Turn == TurnState.White) ? Color.White : Color.Black;
            this.UpdateBoard();
            B_Count.Text = gm.CurrentBlackStone.ToString();
            W_Count.Text = gm.CurrentWhiteStone.ToString();
            TurnCount.Text = $"Turn: {gm.TurnCount.ToString()}";
            Result.Text = "";
            label3.Text = "のターンです。";

            //ゲーム終了
            if (gm.Turn == TurnState.Finish)
            {
                label3.Text = "";
                Result.Text = $"{Enums.WinnerName(gm.GetWinner())}です。";
            }
        }

        private void UpdateBoard()
        {
            for (int x = 0; x < this.cells.GetLength(0); x++)
            {
                for (int y = 0; y < this.cells.GetLength(1); y++)
                {
                    var v = new Vector2(x + 1, y + 1);
                    this.cells[x, y].CellColor = this.board.GetCellColor(v);
                    this.cells[x, y].IsReverse = this.board.IsReverse(v);
                    this.board.BoardReverseUpdate(false, v);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
