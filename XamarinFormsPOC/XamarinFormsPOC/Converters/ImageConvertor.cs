using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinFormsPOC.Converters
{
    public class ImageConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (value == null) return "DefaultImage";
                return value;
            }
            catch (Exception)
            {
                return "DefaultImage";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "DefaultImage";
        }
    }
}
