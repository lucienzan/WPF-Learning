   M S B A M L   `   `   `  ����F  BAppControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BSNWPF.Front.AppControlsBSNWPF.Front.AppControls  5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'    !BSNWPF.Front.AppControls.iTextBox  �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType �� CornerRadius J� RenderTransformOrigin �� ScaleX �� ScaleY ��Name	 �� Padding
 J� SnapsToDevicePixels � ColumnDefinitions �Name ��Name K� ZIndex � Cursor � UseLayoutRounding'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty W� From	 W� To g� Duration W� EasingFunction-  'System.Windows.Media.Animation.SineEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode g� 	BeginTime �� Triggers ]� 
Conditions �� Property �� Value  P� Property! P� Value" �� 
TargetName�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      0local&clr-namespace:BSNWPF.Front.AppControls  5      %h  '         �� 5      "    6   .�5	   
   ��  � �� �#18181B6'   �� 5
   
    � �� �#5252526(   �� 5   
    � ��$ 0q�6,   �� 5   
    � �� �	#FFFFFFFF6'   �� 5   
    �@��
CaretBrush �	#FF0802296'   �� 5   
    �@��SelectionBrush �#64d8cb6+   �� 5   
    � ��$ Stretch=�67   �� 5   
    � ��$ Center=�65   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop$
 true��6&   �� 5   
    �@�Cursor$ Arrow��6#   �� 5   
    � ��$ 4,2,4,2q�6$   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled$ False��63   �� 5   
    �@ TabNavigation$ Local=�6=   �� 5   
    � �� 5      �� 5      "   6"   .R�5      � .+�5!      �� $��Stretch=�5"      $��Stretch=�5#      #��z��5$      $ 4,4,4,4��5%      $ 0.5,0.5&�5&      $y�Visible=�5'      z�5)      �� 5*   "   RippleOnFocusScaleTransform��$ 0Q�6V   $ 0Q�6a   5-      �� 5/      .u�51      �� $ border��52   !   #	 z��53   !   #��z��54   !   #��z��55   !   #��z��56   !   $ 4,4,4,4��57   !   $

 True��58   !   ._�5:   "   � #��z��6'   #��z��6j    5;   &   �� 5<   *   $
��Auto �6;   �� 5=   *   �� 5>   *   $
��Auto �6;   .+�5A   &   � $
 grid��5B   )   $��1��5C   )   $��1��5D   )   .+�5E   *   � $��0��6/    5F   .   �� 5G   2   $
��Auto �6C   �� 5H   2   $��* �6C   �� 5I   2   $
��Auto �6C   .+�5L   .   �� $ PART_ContentHost��5M   1   $��1��5N   1   #��z��5O   1   $ 1��5P   1   $ IBeam��5Q   1   $|�false��5R   1   $��Hidden=�5S   1   #
 z
 5T   1   # z 5U   1   $��Hidden=�5V   1   5X   +   5[   '   5^   #   5_      5`       5c        5d      FocusStates��. 5e   "     Focused��. 5f   &   �� $! RippleOnFocusScaleTransform��61   .��5g   *   W� $ ScaleX�5h   -    05i   -    15j   -   $ 0:0:0.3D�5k   -    5l   .     5m   2   $ EaseOut=�6;   5o   +   W� 5p   *   $ ScaleY�5q   -    05r   -    15s   -   $ 0:0:0.3D�5t   -    5u   .     5v   2   $ EaseOut=�6;   5x   +   W� 5y   *    0:0:0.455z   -   $ ScaleX�5{   -    05|   -   $ 0D�5}   -   W� 5~   *    0:0:0.455   -   $ ScaleY�5�   -    05�   -   $ 0D�5�   -   5�   '   5�   #     5�   "   	Unfocused��. 5�   &   �� $! RippleOnFocusScaleTransform��61   .��5�   *   W� $ ScaleX�5�   -    05�   -   $ 0D�5�   -   W� 5�   *   $ ScaleY�5�   -    05�   -   $ 0D�5�   -   5�   '   5�   #   5�      5�       5�      ]� 5�       5�      �� 5�   "    � {�$ False��6A   ./�5�      ��  � �� �	#FFD6D6D66;   5�      ]� 5�       5�      �� 5�   "    �@��
IsReadOnly$
 True��6B   ./�5�      ��  � �� �	#FFD6D6D66;   5�      P� 5�        �@J�IsKeyboardFocused$
! True��6?   5�      ]� 5�       5�      �� 5�   "    �@J�IsKeyboardFocused$
 True��6I   ./�5�      �� $" border��6%    � ��$ -1q�6K   �� 5�       � ��$ 2q�6@   �� 5�       � �� �#15803D6<   5�      ]� 5�       5�      �� 5�   "    �@J�IsMouseOver$
 True��6C   ./�5�      ��  � �� �#15803D6<   �� 5�      $" border��6%    � ��$ -1q�6K   �� 5�       � ��$ 2q�6@   5�      P� 5�        �@=�HasError$
! true��6A   . �5�      �� $" border��6%    � ��$ -1q�6K   �� 5�       � �� �#991B1B6<   �� 5�       � ��$ 2q�6@   5�      5�      5�      5�      5�      