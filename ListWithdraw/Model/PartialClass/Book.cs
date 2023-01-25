using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ListWithdraw.Model
{
    public partial class Book
    {

        public string Color
        {
            get
            {
                if (Discount > 15)
                    return "#7fff00";
                else
                    return "Transparent";
            }
        }
        public byte[] pictureEmpty
        {
            get
            {
                if (Image == null)
                
                return File.ReadAllBytes("C:\\Users\\grosf\\source\\repos\\ListWithdraw\\ListWithdraw\\Resources\\pictureEmp.png");

                else
                    return Image;
            }
        }
        public Visibility VisibilityCost
        {
            get
            {
                if (Discount == null || Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }
        public string StrCostDiscount
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return $"{Price} руб";
                else
                    return $"{(double)Price - ((double)Price / 100 * Discount)} руб";
            }
        }
    }
}
