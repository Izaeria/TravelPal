   M S B A M L   `   `   `  ����D  @TravelPal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TravelPal.WindowsTravelPal.Windows  5   	   +    %TravelPal.Windows.TravelDetailsWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TravelPal.Windows     5   	     � Title$  TravelDetailsWindow��5   	   $	��450��6%   $	��800��62   $��Arial)�6>   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $	��240 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��120 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��30 �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5!   
   �� $ ��/Images/travelpal-logo.png��6   $��2��64   $��1��6D   $��100px��6Q   �� 5#   
   $	��200��6   $	��200��6   $%��B:\OPG1\Logo\travelpal-logo.png��6)   �� 5%   
   $,��&D:\Slutprojekt_OPG1/travelpal-logo.png��6   $��2��6@   $��1��6P   $��100px��6]   �� 5'   
   -   5        $��lblUsername��5'      $��3��6#   $��1��63   $��2��6@   $��14(�6T   $��Hello��6c   ���#7B68EE$
��Bold"�6�   �� 5)   
   $��1��6   $��5��6$   $��Destination��61   $��14(�6E   �� 5*   
   $��1��6   $��6��6$   $��Country��61   $��14(�6A   �� 5+   
   $��1��6   $��7��6$   $��	Travelers��61   $��14(�6C   �� 5,   
   -   5        $��txtbAllInclusive��5,      $��1��6,   $��8��6<   $��All Inclusive:��6I   $��14(�6`   $y�Hidden=�6o   �� 5-   
   -   5        $��txtbMeetingDetails��5-      $��1��6.   $��8��6>   $��Meeting Details:��6K   $��14(�6d   $y�Hidden=�6s   �� 51   
   -   5        $��txtDestination��51      $��2��6(   $��5��68   $	��200��6F   �� 52   
   -   5        $��
txtCountry��52      $��2��6$   $��6��64   $	��200��6B   �� 53   
   -   5        $��txtTravelers��53      $��2��6&   $��7��66   $��50��6C   �� 54   
   -   5        $��txtAllInclusive��54      $��2��6)   $��8��69   $��30��6F   $y�Hidden=�6Q   �� 55   
   -   5        $��txtMeetingDetails��55      $��2��6+   $��8��6;   $	��100��6H   $y�Hidden=�6T   �� 5>   
   -	   5         ��Name$ 	goBackBtn��5>      $��Go back to previous page��6$   $��2��6_   $��11��6o   $��10(�6}   $
��85,5q�6�   $	��120��6�   $��center=�6�   ���#7B68EE���#7B68EE���#F5FFFA6�   5?      5@      