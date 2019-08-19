using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Othello_v1._0
{
    public partial class Cell : UserControl
    {
        private readonly bool Debug = StartForm.Debug;
        public CellColorTypes CellColor
        {
            get
            {
                return cellColor;
            }
            set
            {
                DebugColorLabel.Text = value.ToString();
                cellColor = value;
                count = 0;
                GIF_Animate_Init(value);
                this.Invalidate();
            }
        }

        public bool IsReverse
        {
            get
            {
                return isReverse;
            }
            set
            {
                DebugIsReverseLabel.Text = value ? "T" : "F";
                isReverse = value;
            }
        }

        private readonly Image empty = Properties.Resources._default;
        private readonly Image black = Properties.Resources.black;
        private readonly Image white = Properties.Resources.white;
        private readonly Image canReverse = Properties.Resources.canreverse;
        private readonly Bitmap btow;
        private readonly Bitmap wtob;
        private CellColorTypes cellColor;
        private bool isReverse;
        private readonly float scale;
        private readonly int imageSize;
        //public readonly Size cellSize = new Size(Properties.Resources._default.Width, Properties.Resources._default.Height);

        private int count = 0, max;

        public Cell(float scale)
        {
            InitializeComponent();
            DebugColorLabel.Visible = Debug;
            DebugIsReverseLabel.Visible = Debug;
            this.BackColor = Color.Black; 
            this.CellColor = CellColorTypes.Empty;
            this.isReverse = false;
            this.scale = scale;
            this.imageSize = empty.Width;
            this.Size = new Size((int)(imageSize * scale), (int)(imageSize * scale));

            //btow = new Bitmap(@"D:\natto\Pictures\gif\black_to_white.gif");
            wtob = new Bitmap(AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + @"\Resources\white_to_black.gif");
            btow = new Bitmap(AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + @"\Resources\black_to_white.gif");
            max = btow.GetFrameCount(new FrameDimension(btow.FrameDimensionsList[0]));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (IsReverse)
            {
                switch (this.CellColor)
                {
                    case CellColorTypes.White: GIF_Animate(btow, white, e); break;
                    case CellColorTypes.Black: GIF_Animate(wtob, black, e); break;
                }
            }
            else
            {
                switch (this.CellColor)
                {
                    case CellColorTypes.Empty: e.Graphics.DrawImage(empty, 0, 0, imageSize * scale, imageSize * scale); break;
                    case CellColorTypes.Black: e.Graphics.DrawImage(black, 0, 0, imageSize * scale, imageSize * scale); break;
                    case CellColorTypes.White: e.Graphics.DrawImage(white, 0, 0, imageSize * scale, imageSize * scale); break;
                    case CellColorTypes.CanReverse: e.Graphics.DrawImage(canReverse, 0, 0, imageSize * scale, imageSize * scale); break;
                }
            }
        }

        private void GIF_Animate_Init(CellColorTypes c)
        {
            if(c == CellColorTypes.Black)
            {
                ImageAnimator.Animate(wtob, new EventHandler(this.Image_FrameChanged));
            }
            else if(c == CellColorTypes.White)
            {
                ImageAnimator.Animate(btow, new EventHandler(this.Image_FrameChanged));
            }
        }

        private void GIF_Animate(Image gif, Image stopImg, PaintEventArgs e)
        {
            if(count > max - 1)
            {
                ImageAnimator.StopAnimate(gif, Image_FrameChanged);
                e.Graphics.DrawImage(stopImg, 0, 0, imageSize * scale, imageSize * scale);
                IsReverse = false;
                return;
            }
            Console.WriteLine(count);

            count++;
            ImageAnimator.UpdateFrames(gif);
            e.Graphics.DrawImage(gif, 0, 0, imageSize * scale, imageSize * scale);
        }

        private void Image_FrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
