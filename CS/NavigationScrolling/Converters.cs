using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace DXSample {
    public class OrientationInverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            Orientation inputValue = (Orientation)value;
            switch (inputValue) {
                case Orientation.Horizontal:
                    return Orientation.Vertical;
                default:
                    return Orientation.Horizontal;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            Orientation inputValue = (Orientation)value;
            switch (inputValue) {
                case Orientation.Horizontal:
                    return Orientation.Vertical;
                default:
                    return Orientation.Horizontal;
            }
        }
    }
}
