﻿using System.Windows;

namespace BuildVision.UI.Controls.Indicators
{
    public class UpToDateProjectsIndicator : ValueIndicator
    {
        static UpToDateProjectsIndicator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UpToDateProjectsIndicator), new FrameworkPropertyMetadata(typeof(UpToDateProjectsIndicator)));
        }

        public UpToDateProjectsIndicator()
        {
            Header = UI.Resources.UpToDateProjectsIndicator_Header;
        }

        static void OnValueChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(ValueProperty, (long)e.NewValue);
        }
    }
}
