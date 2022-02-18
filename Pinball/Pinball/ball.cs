using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinball
{
    class ball
    {
        private System.Windows.Forms.PictureBox picture;

        public ball(int positionX, int positionY, float speed, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            Speed = speed;
            this.picture = picture;
        }
        public float Speed { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void move(float speed_x, float speed_y, out float x, out float y)
        {

            x = picture.Location.X + Speed * speed_x;
            y = picture.Location.Y + Speed * speed_y;
            if(x < 7)
            {
                x += 7;
            }
            if(x > 760)
            {
                x -= 15;
            }
            if(y < 3)
            {
                y += 5;
            }
            PositionX = (int)x;
            PositionY = (int)y;
        }

        public void draw(float x, float y)
        {
            
            picture.SuspendLayout();

            picture.Location = new System.Drawing.Point((int)x, (int)y);
            picture.ResumeLayout();
        }
    }
}
