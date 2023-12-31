﻿using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLive.Avalonia.Converters
{
    public class NumberToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }

            if (value is int || value is long)
            {
                var number = System.Convert.ToDouble(value);
                if (parameter != null)
                {
                    return number.ToString(parameter.ToString());
                }
                if (number >= 10000)
                {
                    return ((double)number / 10000).ToString("0.0") + "万";
                }
            }
            if (value is double)
            {
                var number = (double)value;
                if (parameter != null)
                {
                    return number.ToString(parameter.ToString());
                }
                return number.ToString("0.00");
            }
            if (value is string)
            {
                if (double.TryParse(value.ToString(), out var num))
                {
                    if (num >= 10000)
                    {
                        return (num / 10000).ToString("0.0") + "万";
                    }
                }

            }
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
