   M S B A M L   `   `   `  ����C  ?MVVM.web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MVVM.web.ViewsMVVM.web.Views  5      9!clr-namespace:MVVM.web.ViewModelsMVVM.web.ViewModels  5          MVVM.web.Views.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MVVM.web.Views     5      8
viewmodels!clr-namespace:MVVM.web.ViewModels     5      $��Roboto)�5      $��14(�5      .��5      �� $��50q�5   	   $	��500��5   	   .+�5   
   ��   �� TextAlignment$  Center=�5      $��24(�5      $
��Bold"�5      ���	#FF162E8E$��Account Login��5      �� 5   
   $��0,30,0,0q�5      
�������$��Username��5      �� 5   
   $
��5,10q�5      $��0,10,0,0q�5       ��5!      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=��� 5#   
    �� CornerRadius$ 8��5$      $��1q�5%      ._�5'      �� $��0q�5(      $��0,25,0,0q�5)      $��10q�5*       � Cursor$
 Hand��5+      $
��Bold"�5,      $��Login��5-      ��5.      �� *LoginCommand+50      �� 51   
   $��Center=�6   $��0,10,0,0q�61   ��6C   �� *StatusMessage+��52      �� 53       �� 
TargetType" ��6   .�54      ��  �� Property � y� �� Value$ 	Collapsed=�63    �� Triggers 55      �� 56       �� Binding 6&   �� *HasStatusMessage+	 �� Value	 True6K   .a�57      ��  � y�$ Visible=�6;   58      5:      5<      5=      5>      