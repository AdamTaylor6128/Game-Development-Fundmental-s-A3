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
        AdditionalEffect add = new AdditionalEffect();
        
        //Randomize fish atrributes
        public void Setup()
        {
            posX = Random.Integer(50, Window.Width-50);
            posY = Random.Integer(50, Window.Height-50);
            speed = Random.Integer(50, 150);
            rad = Random.Color();
            
        }
        //Checks for fish collision and changes it if caught
        public void FishActive()
        {
            if(Input.IsMouseButtonDown(MouseButton.Left) && Input.GetMouseX() <= (posX+35) && Input.GetMouseX() >= (posX -110) && Input.GetMouseY() <= (posY+35) && Input.GetMouseY() >= (posY-35) && leftM == false)
            {
                add.Ripple(posX, posY);
                FishUp();
                posX = Input.GetMouseX();
                posY = Input.GetMouseY();
              

            }
            else if(Input.IsMouseButtonDown(MouseButton.Left) && Input.GetMouseX() <= (posX + 110) && Input.GetMouseX() >= (posX - 35) && Input.GetMouseY() <= (posY + 35) && Input.GetMouseY() >= (posY - 35) && leftM == true)
            {
                add.Ripple(posX, posY);
                FishUp();
                posX = Input.GetMouseX();
                posY = Input.GetMouseY();

            }
            else
            {
                FishSwim();

            }

        }
        //Controls the fish movments and checks if it has reached the border
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

        
        //Draws the Fish looking Left
        private void FishLeft()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(rad);
            Draw.Arc(posX, posY, 70, 70, 140, -150);
            Draw.Triangle(posX, posY+35, posX, posY-35, posX+100, posY);
            Draw.Triangle(posX+110, posY + 20, posX+110, posY - 30, posX + 70, posY);

        }
        //Draws the Fish Looking to the right
        private void FishRight()
        {
            Draw.SetLineSize(0);
            Draw.SetFillColor(rad);
            Draw.Arc(posX, posY, 70, 70, 20, 320);
            Draw.Triangle(posX, posY + 35, posX, posY - 35, posX - 100, posY);
            Draw.Triangle(posX - 110, posY + 20, posX - 110, posY - 30, posX - 70, posY);

        }
        //Draws the Fish looking up
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
