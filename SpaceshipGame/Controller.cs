using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceshipGame
{
    internal class Controller
    {
        public List<Asteroid> asteroids = new List<Asteroid>();
        public double timer = 2;
        public double maxTime = 2;
        public int nextSpeed = 240;
        public bool inGame = false;
        public double totalTime;

        public void ConUpdate(GameTime gameTime) 
        {
            if (inGame)
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
                totalTime += gameTime.ElapsedGameTime.TotalSeconds;
            }
            else
            {
                KeyboardState kState = Keyboard.GetState();
                if (kState.IsKeyDown(Keys.Enter))
                {
                    inGame = true;
                    totalTime = 0;
                    timer = 2;
                    maxTime = 2;
                    nextSpeed = 240;
                }
            }

            if(timer < 0)
            {
                asteroids.Add(new Asteroid(nextSpeed));
                timer = maxTime;

                if (maxTime > .5)
                {
                    maxTime -= .1;

                }

                if (nextSpeed < 720) 
                {
                    nextSpeed += 4;
                }

            }

        }
    }
}
