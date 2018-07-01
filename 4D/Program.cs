using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace _4D
{
    class Program
    {
        static void Main(string[] args)
        {

            GameWindow g = new GameWindow(640,480);
            game gm = new game(g); 
        }
    }

    class game
    {
        GameWindow g;
        public game(GameWindow g)
        {
            this.g = g;
            Start();
        }

        void Start()
        {
            g.Load += loaded;
            g.RenderFrame += renderF;
            g.Run(1.0 / 60.0);

        }

        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            g.SwapBuffers();
        }
        void loaded(object o,EventArgs e)
        {
            GL.ClearColor(1.0f,0.8f,0.9f,1f);
        }

    }
}
