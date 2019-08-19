using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello_v1._0
{
    public partial class Cell : UserControl
    {
        public CellColorTypes CellColor
        {
            get
            {
                return cellColor;
            }
            set
            {
                cellColor = value;
                this.Invalidate();
            }
        }

        private readonly Image empty = Properties.Resources._default;
        private readonly Image black = Properties.Resources.black;
        private readonly Image white = Properties.Resources.white;
        private readonly Image canReverse = Properties.Resources.canreverse;
        private CellColorTypes cellColor;
        private readonly float scale;
        private readonly int imageSize;
        //public readonly Size cellSize = new Size(Properties.Resources._default.Width, Properties.Resources._default.Height);

        public Cell(float scale)
        {
            InitializeComponent();
            this.BackColor = Color.Black; 
            this.CellColor = CellColorTypes.Empty;
            this.scale = scale;
            this.imageSize = empty.Width;
            this.Size = new Size((int)(imageSize * scale), (int)(imageSize * scale));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            //e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            switch (this.CellColor)
            {
                case CellColorTypes.Empty: e.Graphics.DrawImage(empty, 0, 0, imageSize * scale, imageSize * scale); break;
                case CellColorTypes.Black: e.Graphics.DrawImage(black, 0, 0, imageSize * scale, imageSize * scale); break;
                case CellColorTypes.White: e.Graphics.DrawImage(white, 0, 0, imageSize * scale, imageSize * scale); break;
                case CellColorTypes.CanReverse: e.Graphics.DrawImage(canReverse, 0, 0, imageSize * scale, imageSize * scale); break;
                default: break;
            }
        }
    }
}
