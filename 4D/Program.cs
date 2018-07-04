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
            gm.Run(60.0);
        }
    }

    class game : GameWindow
    {
        public game(GameWindow g)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(1.0f, 0.8f, 0.9f, 1f);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            SwapBuffers();

        }

        //void renderF(object o, EventArgs e)
        //{
        //    GL.Clear(ClearBufferMask.ColorBufferBit);
        //    g.SwapBuffers();
        //}
        //void loaded(object o,EventArgs e)
        //{
        //    GL.ClearColor(1.0f,0.8f,0.9f,1f);
        //}

    }
}
