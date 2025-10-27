using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame
{
    class Hero : IGameObject
    {
        public Hero(Texture2D texture)
        {
            this.texture = texture;
            deelRectangle = new Rectangle(schuifOp_X, 0, 180, 247);
        }

        private Texture2D texture;
        private Rectangle deelRectangle;
        private int schuifOp_X = 0;

        public void Update()
        {
            schuifOp_X += 180;
            if (schuifOp_X > 720)
            {
                schuifOp_X = 0;
            }
            deelRectangle.X = schuifOp_X;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(0, 0), deelRectangle, Color.White);
        }

    }
}
