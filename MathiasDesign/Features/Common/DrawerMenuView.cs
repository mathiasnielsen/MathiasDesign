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
using Android.Util;
using MathiasDesign.Features.SnackBar;
using MathiasDesign.Features.Images;
using MathiasDesign.Features.Layouts;
using MathiasDesign.Features.ViewPagers;

namespace MathiasDesign.Features.Common
{
    public class DrawerMenuView : LinearLayout
    {
        private Frame frame;

        public DrawerMenuView(Context context)
            : base(context)
        {
            Initialize(context);
        }

        public DrawerMenuView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            Initialize(context);
        }

        private void Initialize(Context context)
        {
            InitializeView(context);

            var app = context.ApplicationContext as App;
            frame = app.Frame;

            var snackbarButton = FindViewById<Button>(Resource.Id.DrawerButtonSnackbar);
            snackbarButton.Click += (s, e) => { frame.NavigateToPage<SnackbarExamplesView>(); };

            var coordinatorLayoutButton = FindViewById<Button>(Resource.Id.DrawerButtonCoordinatorLayout);
            coordinatorLayoutButton.Click += (s, e) => { frame.NavigateToPage<CoordinatorLayoutView>(); };

            var svgButton = FindViewById<Button>(Resource.Id.DrawerButtonSVG);
            svgButton.Click += (s, e) => { frame.NavigateToPage<SVGImageView>(); };

            var imageViewScaleTypeButton = FindViewById<Button>(Resource.Id.DrawerButtonImageViewScaleTypes);
            imageViewScaleTypeButton.Click += (s, e) => { frame.NavigateToPage<ImageViewScaleTypesView>(); };

            var viewPagerButton = FindViewById<Button>(Resource.Id.DrawerButtonImageViewViewPagers);
            viewPagerButton.Click += (s, e) => { frame.NavigateToPage<ViewPagerWithIndicatorView>(); };
        }

        private void InitializeView(Context context)
        {
            var inflater = context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
            inflater.Inflate(Resource.Layout.ControlDrawerMenu, this);
        }
    }
}