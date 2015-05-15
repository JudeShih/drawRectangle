using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace form1
{
    class Draw
    {
        private int x= 0;
        private int y = 0;
        private int _width;
        private int _height;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Draw(int width,int height )
        { 
            this.Width = width;
            this.Height = height;
        }
        public void DrawRectangleInt(PaintEventArgs e)
        {

            
            Pen blackPen = new Pen(Color.Black, 3);

            e.Graphics.DrawRectangle(blackPen, x, y, _width, _height);
        }
    }
}
