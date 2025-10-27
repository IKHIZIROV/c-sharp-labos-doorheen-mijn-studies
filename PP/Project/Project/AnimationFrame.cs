using Microsoft.Xna.Framework;
using SharpDX.MediaFoundation.DirectX;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class AnimationFrame
    {
        public Rectangle SourceRectangle { get; set; }


        public AnimationFrame(Rectangle rectangle)
        {
            SourceRectangle = rectangle;
        }
    }
}
