using System.Windows.Controls;
using System.Windows;

namespace BSNWPF.Front.AppControls
{
    public class iLoginButton : Button
    {
        public iLoginButton()
        {
            PropertyMetadata metaData = DefaultStyleKeyProperty.GetMetadata(typeof(iLoginButton));

            if (metaData.DefaultValue == null)
            {
                DefaultStyleKeyProperty.OverrideMetadata(typeof(iLoginButton), new FrameworkPropertyMetadata(typeof(iLoginButton)));
            }
            else
            {
                string classType = CommonLibrary.iConvert.ToString(metaData.DefaultValue.ToString());

                if (classType.Contains(nameof(iLoginButton)) == false)
                {
                    DefaultStyleKeyProperty.OverrideMetadata(typeof(iLoginButton), new FrameworkPropertyMetadata(typeof(iLoginButton)));
                }
            }

            this.Width = 100;
        }
    }
}
