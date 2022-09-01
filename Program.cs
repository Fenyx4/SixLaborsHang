using System;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace SixLaborsHang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var rivers = new SixLabors.ImageSharp.Image<Rgba32>(256 * 4, 256 * 4, new Rgba32(0, 0, 0, 0));
            IPen pen = Pens.Solid(SixLabors.ImageSharp.Color.Red, 2);
            DrawingOptions riverOptions = new DrawingOptions()
            {
                GraphicsOptions = new SixLabors.ImageSharp.GraphicsOptions()
                {
                    ColorBlendingMode = PixelColorBlendingMode.Multiply
                }
            };

            PathBuilder pathBuilder = new PathBuilder();
            var transform = System.Numerics.Matrix3x2.CreateRotation(-0.04433158f, new System.Numerics.Vector2(948, 640));
            pathBuilder.SetTransform(transform);
            pathBuilder.AddLine(948, 640, 948, 632);
            pathBuilder.CloseFigure();
            pathBuilder.AddLine(948, 644, 948, 640);
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(947, 646), new SixLabors.ImageSharp.PointF(947, 644), new SixLabors.ImageSharp.PointF(947, 642));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(947, 649), new SixLabors.ImageSharp.PointF(947, 647), new SixLabors.ImageSharp.PointF(947, 645));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(946, 653), new SixLabors.ImageSharp.PointF(946, 651), new SixLabors.ImageSharp.PointF(946, 649));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(944, 656), new SixLabors.ImageSharp.PointF(946, 656), new SixLabors.ImageSharp.PointF(946, 654));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 656), new SixLabors.ImageSharp.PointF(-2147483648, 656), new SixLabors.ImageSharp.PointF(-2147483648, 656));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 657), new SixLabors.ImageSharp.PointF(-2147483648, 655), new SixLabors.ImageSharp.PointF(-2147483648, 655));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 656), new SixLabors.ImageSharp.PointF(-2147483648, 656), new SixLabors.ImageSharp.PointF(-2147483648, 656));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 661), new SixLabors.ImageSharp.PointF(-2147483648, 659), new SixLabors.ImageSharp.PointF(-2147483648, 657));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 655), new SixLabors.ImageSharp.PointF(-2147483648, 655), new SixLabors.ImageSharp.PointF(-2147483648, 655));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 664), new SixLabors.ImageSharp.PointF(-2147483648, 664), new SixLabors.ImageSharp.PointF(-2147483648, 662));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 663), new SixLabors.ImageSharp.PointF(-2147483648, 663), new SixLabors.ImageSharp.PointF(-2147483648, 663));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 665), new SixLabors.ImageSharp.PointF(-2147483648, 663), new SixLabors.ImageSharp.PointF(-2147483648, 663));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 664), new SixLabors.ImageSharp.PointF(-2147483648, 664), new SixLabors.ImageSharp.PointF(-2147483648, 664));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 670), new SixLabors.ImageSharp.PointF(-2147483648, 668), new SixLabors.ImageSharp.PointF(-2147483648, 666));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 666), new SixLabors.ImageSharp.PointF(-2147483648, 664), new SixLabors.ImageSharp.PointF(-2147483648, 664));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 674), new SixLabors.ImageSharp.PointF(-2147483648, 672), new SixLabors.ImageSharp.PointF(-2147483648, 670));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 673));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 676), new SixLabors.ImageSharp.PointF(-2147483648, 676), new SixLabors.ImageSharp.PointF(-2147483648, 676));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 678), new SixLabors.ImageSharp.PointF(-2147483648, 676), new SixLabors.ImageSharp.PointF(-2147483648, 676));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 682), new SixLabors.ImageSharp.PointF(-2147483648, 680), new SixLabors.ImageSharp.PointF(-2147483648, 678));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 677), new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 683), new SixLabors.ImageSharp.PointF(-2147483648, 683), new SixLabors.ImageSharp.PointF(-2147483648, 681));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 682), new SixLabors.ImageSharp.PointF(-2147483648, 680), new SixLabors.ImageSharp.PointF(-2147483648, 678));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 686), new SixLabors.ImageSharp.PointF(-2147483648, 684), new SixLabors.ImageSharp.PointF(-2147483648, 684));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 690), new SixLabors.ImageSharp.PointF(-2147483648, 688), new SixLabors.ImageSharp.PointF(-2147483648, 686));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 691), new SixLabors.ImageSharp.PointF(-2147483648, 691), new SixLabors.ImageSharp.PointF(-2147483648, 689));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 691), new SixLabors.ImageSharp.PointF(-2147483648, 691), new SixLabors.ImageSharp.PointF(-2147483648, 691));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 694), new SixLabors.ImageSharp.PointF(-2147483648, 692), new SixLabors.ImageSharp.PointF(-2147483648, 692));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 692), new SixLabors.ImageSharp.PointF(-2147483648, 692), new SixLabors.ImageSharp.PointF(-2147483648, 692));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 697), new SixLabors.ImageSharp.PointF(-2147483648, 695), new SixLabors.ImageSharp.PointF(-2147483648, 693));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 693), new SixLabors.ImageSharp.PointF(-2147483648, 691), new SixLabors.ImageSharp.PointF(-2147483648, 691));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 699), new SixLabors.ImageSharp.PointF(-2147483648, 699), new SixLabors.ImageSharp.PointF(-2147483648, 697));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 702), new SixLabors.ImageSharp.PointF(-2147483648, 700), new SixLabors.ImageSharp.PointF(-2147483648, 698));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 700), new SixLabors.ImageSharp.PointF(-2147483648, 700), new SixLabors.ImageSharp.PointF(-2147483648, 700));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 705), new SixLabors.ImageSharp.PointF(-2147483648, 703), new SixLabors.ImageSharp.PointF(-2147483648, 701));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 702), new SixLabors.ImageSharp.PointF(-2147483648, 700), new SixLabors.ImageSharp.PointF(-2147483648, 700));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 709), new SixLabors.ImageSharp.PointF(-2147483648, 707), new SixLabors.ImageSharp.PointF(-2147483648, 705));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 711), new SixLabors.ImageSharp.PointF(-2147483648, 711), new SixLabors.ImageSharp.PointF(-2147483648, 709));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 714), new SixLabors.ImageSharp.PointF(-2147483648, 712), new SixLabors.ImageSharp.PointF(-2147483648, 710));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 712), new SixLabors.ImageSharp.PointF(-2147483648, 712), new SixLabors.ImageSharp.PointF(-2147483648, 712));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 717), new SixLabors.ImageSharp.PointF(-2147483648, 715), new SixLabors.ImageSharp.PointF(-2147483648, 713));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 713), new SixLabors.ImageSharp.PointF(-2147483648, 711), new SixLabors.ImageSharp.PointF(-2147483648, 711));
            pathBuilder.CloseFigure();
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 721), new SixLabors.ImageSharp.PointF(-2147483648, 719), new SixLabors.ImageSharp.PointF(-2147483648, 717));
            pathBuilder.CloseFigure();
            IPath path = pathBuilder.Build();
            rivers.Mutate(ctx => ctx.Draw(riverOptions, pen, path));
            pathBuilder.ResetTransform();
        }
    }
}
