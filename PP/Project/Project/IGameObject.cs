using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    interface IGameObject
    {
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}
