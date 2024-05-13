﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    internal class Asteroid
    {
        public Vector2 position = new Vector2(600, 300);
        public int speed;
        Random rand = new Random();
        public int radius = 59;

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;
            position = new Vector2 (1380, rand.Next(0, 721));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
