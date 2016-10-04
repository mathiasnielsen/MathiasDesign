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
using Android.Support.V4.View;
using Android.Util;

namespace MathiasDesign.Controls.ViewPagers
{
    public class ViewPagerWithIndicator : ViewPager
    {
        public ViewPagerWithIndicator(Context context)
            : base(context)
        {
        }

        public ViewPagerWithIndicator(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
        }

        public override void SetScrollIndicators([IntDef(Flag = true, Type = "", Fields = new[] { "#", "#", "#", "#", "#", "#" })] int indicators)
        {
            base.SetScrollIndicators(indicators);
        }

        public override ScrollIndicatorPosition ScrollIndicators
        {
            get { return ScrollIndicatorPosition.Bottom; }
        }
    }
}