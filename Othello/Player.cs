using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    class Player
    {
        public Vector2 GetClickCell(object _o)
        {
            Cell targetCell = (Cell)_o;
            Size cellSize = targetCell.Size;
            Vector2 v2 = new Vector2(targetCell.Location.X / cellSize.Width, targetCell.Location.Y / cellSize.Height);
            
            return v2;
        }
    }
}
