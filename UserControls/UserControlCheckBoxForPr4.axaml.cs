using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using Avalonia.Styling;
using System;

namespace PR4_1.UserControls
{
    public partial class UserControlCheckBoxForPr4 : UserControl
    {
        public UserControlCheckBoxForPr4()
        {
            InitializeComponent();
        }

        public void Border_Click(object sender, PointerPressedEventArgs e)
        {
            Border border = (Border)sender;
            if(border.Name == "sadBorder")
            {
                border.Opacity = 0.7;
                happyBorder.Opacity = 0.1;
            }
            else if(border.Name == "happyBorder")
            {
                border.Opacity = 0.7;
                sadBorder.Opacity = 0.1;
            }
        }
        public void Border_Enter(object sender, PointerEventArgs e)
        {
            Border border = (Border)sender;
            if (border.Opacity != 0.7) border.Opacity = 0.3;
        }
        public void Border_Leave(object sender, PointerEventArgs e)
        { 
            Border border = (Border)sender;
            if (border.Opacity != 0.7) border.Opacity = 0.1;
        }
    }
}
