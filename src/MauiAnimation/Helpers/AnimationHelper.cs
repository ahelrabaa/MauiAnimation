﻿namespace MauiAnimation.Helpers
{
    public static class AnimationHelper
    {
        public static int GetIntValue(int from, int to, double animationProgress)
        {
            return (int)(from + (to - from) * animationProgress);
        }

        public static double GetDoubleValue(double from, double to, double animationProgress)
        {
            return from + (to - from) * animationProgress;
        }

        // https://www.alanzucconi.com/2016/01/06/colour-interpolation/
        public static Color GetColorValue(Color from, Color to, double animationProgress)
        {
            var newR = (to.Red - from.Red) * animationProgress;
            var newG = (to.Green - from.Green) * animationProgress;
            var newB = (to.Blue - from.Blue) * animationProgress;
            return Color.FromRgb(from.Red + newR, from.Green + newG, from.Blue + newB);
        }

        public static CornerRadius GetCornerRadiusValue(CornerRadius from, CornerRadius to, double animationProgress)
        {
            return new CornerRadius(
                from.TopLeft + (to.TopLeft - from.TopLeft) * animationProgress,
                from.TopRight + (to.TopRight - from.TopRight) * animationProgress,
                from.BottomLeft + (to.BottomLeft - from.BottomLeft) * animationProgress,
                from.BottomRight + (to.BottomRight - from.BottomRight) * animationProgress);
        }

        public static Thickness GetThicknessValue(Thickness from, Thickness to, double animationProgress)
        {
            return new Thickness(
                from.Left + (to.Left - from.Left) * animationProgress,  
                from.Top + (to.Top - from.Top) * animationProgress,
                from.Right + (to.Right - from.Right) * animationProgress,
                from.Bottom + (to.Bottom - from.Bottom) * animationProgress);
        }
    }
}