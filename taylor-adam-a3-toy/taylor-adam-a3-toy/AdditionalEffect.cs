using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    internal class AdditionalEffect
    {
       
        int opacityW = 0;
        int opacityR = 255;
        
        int colRed;
        int colGreen;
        float rad = 0;
        bool first = true;



        /// <summary>
        ///     Update runs every frame.
        /// </summary>





        public void Wave()
        {
            int[] WaveX = new int[100];
            int[] WaveY = new int[100];




            //Wave Drawings
            if (opacityW <= 0)
            {
                //Resets the waves opacity
                opacityW = 255;
                for (int i = 0; i < 100; i++)
                {
                    WaveX[i] = Random.Integer(0, Window.Width);
                    WaveY[i] = Random.Integer(0, Window.Height);

                }


                //Changes wave colours randomly
                colGreen = Random.Integer(-50, 100);
                colRed = Random.Integer(-20, 100);

            }
            

            else if (opacityW > 0)
            {
                for (int i = 0; i < 100; i++)
                {


                    //Draws the waves
                    WaveDrawing(WaveX[i], WaveY[i]);
                    
                }

                opacityW -= 2;
            }




        }

        public void WaveDrawing(int wavePosX, int wavePosY)
        {
            Draw.SetLineSize(10);
            Draw.SetFillColor(48, 118, 199, opacityW);
            Draw.SetLineColor(66 + colRed, 155 + colGreen, 245, opacityW);
            Draw.Arc(200 + wavePosX, 200 + wavePosY, 100, 66, 180, 360, false);

        }


        public void Ripple(float x, float y)
        {
            //Creates ripples on click
            
            if (rad < 30)
            {
                rad += 30 * Time.DeltaTime;
                opacityR -= 5;
                Draw.SetLineSize(10);
                Draw.SetFillColor(67, 49, 224);
                Draw.SetLineColor(66, 155, 245, opacityR);
                Draw.Circle(x, y, rad);


            }
            //Reset ripple
            else if (rad == 30)
            {
                rad = 0;
                opacityR = 255;
                

            }

        }


    }
}
