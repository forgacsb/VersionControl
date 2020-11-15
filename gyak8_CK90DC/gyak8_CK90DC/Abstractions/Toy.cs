﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak8_CK90DC.Abstractions
{
   public abstract class Toy: Label
    {
        public Toy()
        {
            this.AutoSize = false;
            this.Width = 50;
            this.Height = 50;
            Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected abstract void DrawImage(Graphics g);

        public virtual void MoveToy()
        {
            Left += 1;
        }
    }
}
