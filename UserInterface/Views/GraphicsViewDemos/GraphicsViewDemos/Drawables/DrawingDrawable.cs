﻿using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.Graphics.Text;
using System;
using System.IO;
using System.Reflection;

namespace GraphicsViewDemos.Drawables
{
    internal class LineDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 6;
            // canvas.StrokeDashPattern = new float[] { 2, 2 };
            canvas.DrawLine(10, 10, 90, 100);
        }
    }

    internal class EllipseDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;
            canvas.DrawEllipse(10, 10, 150, 50);
        }
    }

    internal class FilledEllipseDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.FillColor = Colors.Red;
            canvas.FillEllipse(10, 10, 100, 50);
        }
    }

    internal class CircleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;
            canvas.DrawEllipse(10, 10, 100, 100);
        }
    }

    internal class RectangleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.DarkBlue;
            canvas.StrokeSize = 4;
            canvas.DrawRectangle(10, 10, 100, 50);
        }
    }

    internal class SquareDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.DarkBlue;
            canvas.StrokeSize = 4;
            canvas.DrawRectangle(10, 10, 100, 100);
        }
    }

    internal class FilledRectangleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.FillColor = Colors.DarkBlue;
            canvas.FillRectangle(10, 10, 100, 50);
        }
    }

    internal class RoundedRectangleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Green;
            canvas.StrokeSize = 4;
            canvas.DrawRoundedRectangle(10, 10, 100, 50, 12);
        }
    }

    internal class FilledRoundedRectangleDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.FillColor = Colors.Green;
            canvas.FillRoundedRectangle(10, 10, 100, 50, 12);
        }
    }

    internal class ArcDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Teal;
            canvas.StrokeSize = 4;
            canvas.DrawArc(10, 10, 100, 100, 0, 180, true, false);
        }
    }

    internal class FilledArcDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.FillColor = Colors.Teal;
            canvas.FillArc(10, 10, 100, 100, 0, 180, true);
        }
    }

    internal class PathDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            PathF path = new PathF();
            path.MoveTo(40, 10);
            path.LineTo(70, 80);
            path.LineTo(10, 50);
            path.Close();
            canvas.StrokeColor = Colors.Green;
            canvas.StrokeSize = 6;
            canvas.DrawPath(path);
        }
    }

    internal class FilledPathDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            PathF path = new PathF();
            path.MoveTo(40, 10);
            path.LineTo(70, 80);
            path.LineTo(10, 50);
            canvas.FillColor = Colors.SlateBlue;
            canvas.FillPath(path);
        }
    }

    internal class ImageDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            IImage image;
            Assembly assembly = GetType().GetTypeInfo().Assembly;
            using (Stream stream = assembly.GetManifestResourceStream("GraphicsViewDemos.Resources.Images.dotnet_bot.png"))
            {
                image = PlatformImage.FromStream(stream);
            }

            if (image != null)
            {
                canvas.DrawImage(image, 10, 10, image.Width, image.Height);
            }
        }
    }

    internal class StringDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.FontColor = Colors.Blue;
            canvas.FontSize = 18;

            canvas.Font = Font.Default;
            canvas.DrawString("Text is left aligned.", 20, 20, 380, 100, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.DrawString("Text is centered.", 20, 60, 380, 100, HorizontalAlignment.Center, VerticalAlignment.Top);
            canvas.DrawString("Text is right aligned.", 20, 100, 380, 100, HorizontalAlignment.Right, VerticalAlignment.Top);

            canvas.Font = Font.DefaultBold;
            canvas.DrawString("This text is displayed using the bold system font.", 20, 140, 350, 100, HorizontalAlignment.Left, VerticalAlignment.Top);

            canvas.Font = new Font("Arial");
            canvas.FontColor = Colors.Black;
            canvas.SetShadow(new SizeF(6, 6), 4, Colors.Gray);
            canvas.DrawString("This text has a shadow.", 20, 200, 300, 100, HorizontalAlignment.Left, VerticalAlignment.Top);
        }
    }

    internal class AttributedTextDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            //canvas.FontName = "Arial";
            //canvas.FontSize = 18;
            //canvas.FontColor = Colors.Blue;

            //string markdownText = @"This is *italic text*, **bold text**, __underline text__, and ***bold italic text***.";
            //IAttributedText attributedText = MarkdownAttributedTextReader.Read(markdownText); // Requires the Microsoft.Maui.Graphics.Text.Markdig package
            //canvas.DrawText(attributedText, 10, 10, 400, 400);
        }
    }

    internal class FillAndStrokeDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            float radius = Math.Min(dirtyRect.Width, dirtyRect.Height) / 4;

            PathF path = new PathF();
            path.AppendCircle(dirtyRect.Center.X, dirtyRect.Center.Y, radius);

            canvas.StrokeColor = Colors.Blue;
            canvas.StrokeSize = 10;
            canvas.FillColor = Colors.Red;

            canvas.FillPath(path);
            canvas.DrawPath(path);
        }
    }

    internal class ShadowDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.FillColor = Colors.Red;
            canvas.SetShadow(new SizeF(10, 10), 4, Colors.Grey);
            canvas.FillRectangle(10, 10, 90, 100);

            canvas.FillColor = Colors.Green;
            canvas.SetShadow(new SizeF(10, -10), 4, Colors.Grey);
            canvas.FillEllipse(110, 10, 90, 100);

            canvas.FillColor = Colors.Blue;
            canvas.SetShadow(new SizeF(-10, 10), 4, Colors.Grey);
            canvas.FillRoundedRectangle(210, 10, 90, 100, 25);
        }
    }

    internal class RegularDashedObjectDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;
            canvas.StrokeDashPattern = new float[] { 2, 2 };
            canvas.DrawRectangle(10, 10, 90, 100);
        }
    }

    internal class IrregularDashedObjectDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 4;
            canvas.StrokeDashPattern = new float[] { 4, 4, 1, 4 };
            canvas.DrawRectangle(10, 10, 90, 100);
        }
    }

    internal class LineEndsDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            canvas.StrokeSize = 10;
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeLineCap = LineCap.Round;
            canvas.DrawLine(10, 10, 110, 110);
        }
    }

    internal class LineJoinsDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            PathF path = new PathF();
            path.MoveTo(10, 10);
            path.LineTo(110, 50);
            path.LineTo(10, 110);

            canvas.StrokeSize = 20;
            canvas.StrokeColor = Colors.Blue;
            canvas.StrokeLineJoin = LineJoin.Round;
            canvas.DrawPath(path);
        }
    }

    internal class ClippingDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            IImage image;
            var assembly = GetType().GetTypeInfo().Assembly;
            using (var stream = assembly.GetManifestResourceStream("GraphicsViewDemos.Resources.Images.dotnet_bot.png"))
            {
                image = PlatformImage.FromStream(stream);
            }

            if (image != null)
            {
                PathF path = new PathF();
                path.AppendCircle(100, 90, 80);
                canvas.ClipPath(path);  // Must be called before DrawImage
                canvas.DrawImage(image, 10, 10, image.Width, image.Height);
            }
        }
    }

    internal class SubtractClippingDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            IImage image;
            var assembly = GetType().GetTypeInfo().Assembly;
            using (var stream = assembly.GetManifestResourceStream("GraphicsViewDemos.Resources.Images.dotnet_bot.png"))
            {
                image = PlatformImage.FromStream(stream);
            }

            if (image != null)
            {
                canvas.SubtractFromClip(60, 60, 90, 90);
                canvas.DrawImage(image, 10, 10, image.Width, image.Height);
            }
        }
    }
}
