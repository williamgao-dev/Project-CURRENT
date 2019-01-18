using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core
{
    public static class IconTypeExtensions
    {
        public static string ToFontAwesome(this IconType iconType)
        {
            switch (iconType)
            {
                // File
                case IconType.File:
                    return "\uf0f6";

                // Picture
                case IconType.Picture:
                    return "\uf1c5";

                // Return nothing if no icon type
                default:
                    return default(string);
            }
        }
    }
}
