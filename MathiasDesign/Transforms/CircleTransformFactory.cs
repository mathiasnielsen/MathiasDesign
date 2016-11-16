using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Views.Animations;
using Android.Graphics;

namespace MathiasDesign.Transforms
{
    public class CircleTransformFactory : Transformation
    {
        public CircleTransformFactory()
            : base()
        {
        }

        public Bitmap ToCircleLayout(Bitmap bitmap)
        {
            var size = bitmap.Width >= bitmap.Height ? bitmap.Height : bitmap.Width;
            Bitmap croppedBitmap;

            if (bitmap.Width >= bitmap.Height)
            {
                croppedBitmap = Bitmap.CreateBitmap(
                   bitmap,
                   (bitmap.Width / 2) - (bitmap.Height / 2),
                   0,
                   size,
                   size);
            }
            else
            {
                croppedBitmap = Bitmap.CreateBitmap(
                   bitmap,
                   0,
                   (bitmap.Height / 2) - (bitmap.Width / 2),
                   size,
                   size);
            }

            var result = Bitmap.CreateBitmap(croppedBitmap.Width, croppedBitmap.Height, Bitmap.Config.Argb8888);
            var canvas = new Canvas(result);

            var paint = new Paint();
            var rect = new Rect(0, 0, size, size);
            var rectF = new RectF(rect);

            paint.AntiAlias = true;
            canvas.DrawARGB(0, 0, 0, 0);
            paint.Color = new Color(0x42, 0x42, 0x42, 0xff);
            canvas.DrawRoundRect(rectF, size / 2, size / 2, paint);

            paint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcIn));
            canvas.DrawBitmap(croppedBitmap, rect, rect, paint);

            croppedBitmap.Dispose();

            return result;
        }
    }
}