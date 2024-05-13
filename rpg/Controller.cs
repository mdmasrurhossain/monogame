﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace rpg
{
    internal class Controller
    {
        public static double timer = 2D;
        public static double maxTime = 2D;
        static Random rand = new Random();

        public static void Update(GameTime gameTime, Texture2D spriteSheet)
        {
            timer -= gameTime.ElapsedGameTime.TotalSeconds;

            if (timer <= 0)
            {
                int side = rand.Next(4);

                switch (side)
                {
                    case 0:
                        Enemy.enemies.Add(new Enemy(new Vector2(-500, rand.Next(-500, 2000)), spriteSheet));
                        break;
                    case 1:
                        Enemy.enemies.Add(new Enemy(new Vector2(2000, rand.Next(-500, 2000)), spriteSheet));
                        break;
                    case 2:
                        Enemy.enemies.Add(new Enemy(new Vector2(rand.Next(-500, 2000), -500), spriteSheet));
                        break;
                    case 3:
                        Enemy.enemies.Add(new Enemy(new Vector2(rand.Next(-500, 2000), 2000), spriteSheet));
                        break;
                }

                Enemy.enemies.Add(new Enemy(new Vector2(100, 100), spriteSheet));
                timer = maxTime;

                if (maxTime > 0.5)
                {
                    maxTime -= 0.05D;
                }
            }
        }
    }
}
