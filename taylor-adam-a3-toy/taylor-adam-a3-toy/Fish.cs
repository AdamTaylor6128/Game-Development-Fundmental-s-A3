using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Fish
    {

        int posX;
        int posY;
        //Color(int r, int g, int b);
        bool leftM = false;
        int speed;

        

        public void Setup()
        {
            posX = Random.Integer(150, 750);
            posY = Random.Integer(350, 550);
            speed = Random.Integer(2, 7);
        }

        public void FishSwim()
        {
            if (leftM == true)
            {
               
                posX -= speed * Time.FramesElapsed;

                FishLeft();

                if (posX <= 150)
                {
                    leftM = false;
                }
            }
            else if (leftM == false)
            {

               
                posX += speed * Time.FramesElapsed;

                FishRight();
                
                if (posX >= 750)
                {
                    leftM = true;
                }

            }
        }

        public void FishCaught()
        {


        }

        private void FishLeft()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Green);
            Draw.Arc(posX, posY, 70, 70, 140, -150);
            Draw.Triangle(posX, posY+35, posX, posY-35, posX+100, posY);
            Draw.Triangle(posX+110, posY + 20, posX+110, posY - 30, posX + 70, posY);

        }

        private void FishRight()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Green);
            Draw.Arc(posX, posY, 70, 70, 20, 320);
            Draw.Triangle(posX, posY + 35, posX, posY - 35, posX - 100, posY);
            Draw.Triangle(posX - 110, posY + 20, posX - 110, posY - 30, posX - 70, posY);

        }

    }
}
