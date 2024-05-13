using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace rpg
{
    internal class Projectile
    {
        public static List<Projectile> projectiles = new List<Projectile>();


        private Vector2 position;
        private int speed = 1000;
        public int radius = 18;
        private Dir direction;
        private bool collided = false;

        public Projectile(Vector2 newPos, Dir newDir)
        {
            position = newPos;
            direction = newDir;
        }

        public Vector2 Posiiton
        {
            get 
            { 
                return position; 
            }
        }

        public bool Collided
        {
            get
            {
                return collided;
            }

            set
            {
                collided = value;
            }
        }

        public void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;


            switch (direction)
            {
                case Dir.Right:
                    position.X += speed * dt;
                    break;

                case Dir.Left:
                    position.X -= speed * dt;
                    break;

                case Dir.Down:
                    position.Y += speed * dt;
                    break;

                case Dir.Up:
                    position.Y -= speed * dt;
                    break;
            }
        }

    }
}
