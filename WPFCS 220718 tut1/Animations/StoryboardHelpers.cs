using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Project
{
    /// <summary>
    /// Animation helpers for storyboards
    /// </summary>
    public static class StoryboardHelpers
    {
        #region Slide from right/left
        /// <summary>
        /// Adds a slide in from right animation to the storyboard
        /// </summary>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, string elementName = null,
            float decelerationRatio = 0.9f)
        {
            // Create the animation from right
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, 0, -offset - 500, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(slideAnimation, elementName);
            }

            // Set property
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));

            // Add new animation to the elements storyboard, ready to animate
            storyboard.Children.Add(slideAnimation);
        }


        /// <summary>
        /// Adds a slide in from left animation to the storyboard
        /// </summary>
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, string elementName = null,
            float decelerationRatio = 0.9f)
        {
            // Create the animation from right
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset - 500, 0, 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(slideAnimation, elementName);
            }
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }
        #endregion

        #region Slide to right/left
        /// <summary>
        /// Adds a slide to right animation to the storyboard
        /// </summary>
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, string elementName = null,
            float decelerationRatio = 0.9f)
        {
            // Create the animation from right
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, 0, -offset - 500, 0),
                DecelerationRatio = decelerationRatio
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(slideAnimation, elementName);
            }
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        /// <summary>
        /// Adds a slide to left animation to the storyboard
        /// </summary>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, string elementName = null,
            float decelerationRatio = 0.9f)
        {
            // Create the animation from right
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset - 500, 0, 0, 0),
                DecelerationRatio = decelerationRatio
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(slideAnimation, elementName);
            }
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }
        #endregion

        #region Slide in/out from bottom
        /// <summary>
        /// Add slide from bottom animation to a storyboard
        /// </summary>
        /// <param name="storyboard"></param>
        /// <param name="seconds"></param>
        /// <param name="offset"></param>
        /// <param name="elementName"></param>
        /// <param name="decelerationRatio"></param>
        public static void AddSlideFromBottom(this Storyboard storyboard, float seconds, double offset, string elementName = null,
            float decelerationRatio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, offset, 0, -offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(slideAnimation, elementName);
            }
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }

        /// <summary>
        /// Add slide to bottom animation to a storyboard
        /// </summary>
        public static void AddSlideToBottom(this Storyboard storyboard, float seconds, double offset, string elementName = null,
            float decelerationRatio = 0.9f)
        {
            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, offset, 0, -offset),
                DecelerationRatio = decelerationRatio
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(slideAnimation, elementName);
            }
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
        }
        #endregion

        #region Fade in/out
        /// <summary>
        /// Adds a fade in animation
        /// </summary>
        public static void AddFadeIn(this Storyboard storyboard, float seconds, string elementName = null)
        {
            // Create the animation from right
            var fadeAnimation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(fadeAnimation, elementName);
            }
            Storyboard.SetTargetProperty(fadeAnimation, new PropertyPath("Opacity"));
            storyboard.Children.Add(fadeAnimation);
        }

        /// <summary>
        /// Adds a fade out animation
        /// </summary>
        public static void AddFadeOut(this Storyboard storyboard, float seconds, string elementName = null)
        {
            // Create the animation from right
            var fadeAnimation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0
            };
            if (elementName != null)
            {
                Storyboard.SetTargetName(fadeAnimation, elementName);
            }
            Storyboard.SetTargetProperty(fadeAnimation, new PropertyPath("Opacity"));
            storyboard.Children.Add(fadeAnimation);
        }
        #endregion
    }
}