using System;
using System.Diagnostics;
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
            var timer = new Stopwatch();
            timer.Start();
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
            //pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(947, 646), new SixLabors.ImageSharp.PointF(947, 644), new SixLabors.ImageSharp.PointF(947, 642));
            //pathBuilder.CloseFigure();
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
            // Time taken: 1:13.593
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 678), new SixLabors.ImageSharp.PointF(-2147483648, 676), new SixLabors.ImageSharp.PointF(-2147483648, 676));
            pathBuilder.CloseFigure();
            // Time taken: 1:17.616
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675));
            pathBuilder.CloseFigure();
            // Time taken: 1:14.745
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 682), new SixLabors.ImageSharp.PointF(-2147483648, 680), new SixLabors.ImageSharp.PointF(-2147483648, 678));
            pathBuilder.CloseFigure();
            // Time taken: 52:50.169
            pathBuilder.AddQuadraticBezier(new SixLabors.ImageSharp.PointF(-2147483648, 677), new SixLabors.ImageSharp.PointF(-2147483648, 675), new SixLabors.ImageSharp.PointF(-2147483648, 675));
            pathBuilder.CloseFigure();
            IPath path = pathBuilder.Build();
            rivers.Mutate(ctx => ctx.Draw(riverOptions, pen, path));
            pathBuilder.ResetTransform();
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine(foo);
        }
    }
}
