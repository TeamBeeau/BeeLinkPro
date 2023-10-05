using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{

    public  struct Resource
    {
        public static Color ColorBG(clBackground colorBG)
        {
          
            switch (colorBG)
            {
                case clBackground.Form:
                    return Color.FromArgb(255, 205, 35);
                case clBackground.UserCotrol:
                    return Color.FromKnownColor(KnownColor.Gainsboro);
                case clBackground.Panel:
                    return Color.White;
                case clBackground.Label:
                    return Color.FromArgb(70, 70, 70);
                case clBackground.BtnApply:
                    return Color.FromKnownColor(KnownColor.ControlDarkDark);
                case clBackground.BtnCancel:
                    return Color.FromKnownColor(KnownColor.LightGray);
            }
            return new Color();
        }
    }
}
