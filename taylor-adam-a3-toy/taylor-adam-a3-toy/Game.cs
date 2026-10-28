// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>

        Fish[] fishs = new Fish[7];
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Fishing Toy");
            for (int i = 0; i < fishs.Length; i++)
            {


                fishs[i] = new Fish();
                fishs[i].Setup();
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(48, 118, 199);
           

            for (int i = 0; i < fishs.Length; i++)
            {
                fishs[i].FishActive();
            }

        }


       
    }

}
