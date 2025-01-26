using System;
using System.IO;
using System.Collections.Generic;
using Cosmos.System;
using Cosmos.System.Graphics;

namespace NexonKernel.Interface.GUI {
    public class gui {
        public void loadgui() {
            var gui = FullScreenCanvas.GetFullScreenCanvas();
            mDebugger.Send("Run");
            canvas.DrawPoint(Color.Red, 69, 69);
            canvas.DrawLine(Color.GreenYellow, 250, 100, 400, 100);
            canvas.DrawLine(Color.IndianRed, 350, 150, 350, 250);
            canvas.DrawLine(Color.MintCream, 250, 150, 400, 250);
            canvas.DrawRectangle(Color.PaleVioletRed, 350, 350, 80, 60);
            canvas.DrawCircle(Color.Chartreuse, 69, 69, 10);
            canvas.DrawEllipse(Color.LightSalmon, 400, 300, 100, 150);
            canvas.DrawPolygon(Color.MediumPurple, new Point(200, 250), new Point(250, 300), new Point(220, 350), new Point(210, 275));
            canvas.DrawFilledEllipse(Color.LightSalmon, 400, 300, 100, 150);
            canvas.DrawImage(bitmap, 20, 20);
                    /* Cosmos graphics is double-buffered so you need to swap buffers every time user needs to see a picture */
            canvas.Display();
        }
    }
}

