   M S B A M L   `   `   `  ����D  @TravelPal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TravelPal.WindowsTravelPal.Windows  5   	   &     TravelPal.Windows.RegisterWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TravelPal.Windows     5   	     � Title$  RegisterWindow��5   
   $	��450��6!   $	��800��6.   $��Arial)�6:   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $	��240 �6   �� 5      $	��300 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��120 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5#   
   �� $ ��/Images/travelpal-logo.png��6   $��2��65   $��1��6E   $��100px��6R   �� 5%   
   $��2��6   $��2��6$   $��18(�61   $��Choose your Username��6@   $��0,0,0,5q�6\   $��Center=�6m   �� 5&   
   -   5        $��txtUsername��5&      $��2��6%   $��3��65   $	��150��6B   �� 5(   
   $��2��6   $��4��6    $��18(�6-   $��Password��6<   $��0,0,0,5q�6O   $��Center=�6`   G� 5)   
   -   5         G�Name$ txtPassword��5)      $��2��6+   $��5��6;   $	��150��6H   �� 5+   
   $��2��6   $��6��6    $��18(�6-   $��Confirm Password��6<   $��0,0,0,5q�6W   $��Center=�6h   G� 5,   
   -   5        $ txtConfirmPassword��5,      $��2��62   $��7��6B   $	��150��6O   �� 5.   
   $��2��6   $��8��6$   $��18(�61   $��Country of Origin��6@   $��0,0,0,5q�6Y   $��Center=�6j   �� 5/   
   -   5        $��
cmbCountry��5/      $��2��6%   $��9��65   $��20��6B   �� 51   
   -   5         ��Name$ RegisterBtn��51      $��Register��6&   $��2��6S   $��10��6c   $	��100��6q   $��5q�6}   ���#7B68EE���#7B68EE
�������6�   �� 52   
   -   5        $ 	goBackBtn��52      $��Go back to previous page��6$   $��3��6_   $��10��6o   $��10(�6}   $��5q�6�   $	��150��6�   $��center=�6�   ���#7B68EE���#7B68EE���#F5FFFA6�   54      55      