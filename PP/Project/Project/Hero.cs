using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace Project
{
    public class Hero : IGameObject
    {
        Texture2D _heroTexture;

        private Rectangle _deelRectangle;
        private int schuifOp_X = 0;

        public Hero(Texture2D texture)
        {
            _heroTexture = texture;
            _deelRectangle = new Rectangle(schuifOp_X, 0, 180, 247);
        }

        public void Update()
        {
            schuifOp_X += 180;
            if (schuifOp_X > 720)
            {
                schuifOp_X = 0;
            }
            _deelRectangle.X = schuifOp_X;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_heroTexture, new Vector2(0, 0), _deelRectangle, Color.White);
        }
    }
}
