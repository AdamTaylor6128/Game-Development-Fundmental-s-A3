using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Fish
    {

        float posX;
        float posY;
        Color rad;
        bool leftM = false;
        float speed;

        

        public void Setup()
        {
            posX = Random.Integer(50, Window.Width-50);
            posY = Random.Integer(50, Window.Height-50);
            speed = Random.Integer(50, 150);
            rad = Random.Color();
        }

        public void FishActive()
        {
            if(Input.IsMouseButtonDown(MouseButton.Left) && Input.GetMouseX() <= (posX+35) && Input.GetMouseX() >= (posX -110) && Input.GetMouseY() <= (posY+35) && Input.GetMouseY() >= (posY-35) && leftM == false)
            {
                FishUp();
                posX = Input.GetMouseX();
                posY = Input.GetMouseY();


            }
            else if(Input.IsMouseButtonDown(MouseButton.Left) && Input.GetMouseX() <= (posX + 110) && Input.GetMouseX() >= (posX - 35) && Input.GetMouseY() <= (posY + 35) && Input.GetMouseY() >= (posY - 35) && leftM == true)
            {
                FishUp();
                posX = Input.GetMouseX();
                posY = Input.GetMouseY();

            }
            else
            {
                FishSwim();

            }

        }
        
        public void FishSwim()
        {
            if (leftM == true)
            {

                posX -= speed * Time.DeltaTime;

                FishLeft();

                if (posX <=  50)
                {
                    leftM = false;
                }
            }
            else if (leftM == false)
            {

               
                posX += speed * Time.DeltaTime;

                FishRight();
                
                if (posX >= Window.Width - 50)
                {
                    leftM = true;
                }

            }
        }

        

        private void FishLeft()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(rad);
            Draw.Arc(posX, posY, 70, 70, 140, -150);
            Draw.Triangle(posX, posY+35, posX, posY-35, posX+100, posY);
            Draw.Triangle(posX+110, posY + 20, posX+110, posY - 30, posX + 70, posY);

        }

        private void FishRight()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(rad);
            Draw.Arc(posX, posY, 70, 70, 20, 320);
            Draw.Triangle(posX, posY + 35, posX, posY - 35, posX - 100, posY);
            Draw.Triangle(posX - 110, posY + 20, posX - 110, posY - 30, posX - 70, posY);

        }

        private void FishUp ()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(rad);
            Draw.Arc(posX, posY, 70, 70, 220, -30);
            Draw.Triangle(posX+35, posY , posX-35, posY, posX , posY+100);
            Draw.Triangle(posX + 20, posY + 110, posX - 30, posY+ 110 , posX, posY+ 70);
        }

    }
}
