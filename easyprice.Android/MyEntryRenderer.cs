using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using EasyMakeMoney;
using EasyMakeMoney.Droid;
using Android.Graphics.Drawables;
using easyprice;

#pragma warning disable CS0612 // Le type ou le membre est obsolète
[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
#pragma warning restore CS0612 // Le type ou le membre est obsolète

namespace EasyMakeMoney.Droid
{
    [Obsolete]
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);
                gd.SetCornerRadius(15);
                gd.SetStroke(1, Android.Graphics.Color.Gray);
                this.Control.SetBackground(gd);
            }
        }
    }
}