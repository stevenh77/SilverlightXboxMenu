using System.Windows;
using System.Windows.Controls;

namespace SilverlightXboxMenu.Controls
{
    public class MenuHeaderRadioButton : RadioButton
    {
        public static readonly DependencyProperty DisplayTextProperty =
            DependencyProperty.Register("DisplayText", typeof(string), typeof(MenuHeaderRadioButton), new PropertyMetadata(default(string)));

        public string DisplayText
        {
            get { return (string)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }
    }
}
