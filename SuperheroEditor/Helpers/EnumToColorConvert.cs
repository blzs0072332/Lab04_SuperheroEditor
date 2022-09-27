using SuperheroEditor.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SuperheroEditor.Helpers
{
    class EnumToColorConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((value as Superhero).Politics)
            {
                case politics.jó:
                    return Brushes.LightGreen;
                case politics.gonosz:
                    return Brushes.LightPink;
                case politics.semleges:
                    return Brushes.LightYellow;
                default:
                    return Brushes.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
