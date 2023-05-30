using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BSNWPF.Front.AppControls
{
    public class iPasswordBox : PasswordBox
    {
        public iPasswordBox()
        {
            PropertyMetadata metaData = DefaultStyleKeyProperty.GetMetadata(typeof(iTextBox));

            if (metaData.DefaultValue == null)
            {
                DefaultStyleKeyProperty.OverrideMetadata(typeof(iTextBox), new FrameworkPropertyMetadata(typeof(iTextBox)));
            }
            else
            {
                string classType = CommonLibrary.iConvert.ToString(metaData.DefaultValue.ToString());

                if (classType.Contains(nameof(iTextBox)) == false)
                {
                    DefaultStyleKeyProperty.OverrideMetadata(typeof(iTextBox), new FrameworkPropertyMetadata(typeof(iTextBox)));
                }

            }

            this.IsInputMode = false;
            this.Height = 40;

            // 全角入力の対応
            TextCompositionManager.AddPreviewTextInputHandler(this, DecideTextInput);
            TextCompositionManager.AddPreviewTextInputStartHandler(this, StartTextInput);
        }
    }
}
