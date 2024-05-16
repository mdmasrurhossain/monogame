﻿using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace DugOut
{
    public class Coin
    {
        private static Texture2D _texture;
        private Vector2 _position;
        private readonly Animation _anim;

        public Coin(Vector2 pos)
        {
            _texture ??= Globals.Content.Load<Texture2D>("sprites/coin");
            _anim = new(_texture, 6, 1, 0.1f);
            _position = pos;
        }

        public void Update()
        {
            _anim.Update();
        }

        public void Draw()
        {
            _anim.Draw(_position);
        }
    }
}
