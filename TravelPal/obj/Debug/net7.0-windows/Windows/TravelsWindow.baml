   M S B A M L   `   `   `  ����D  @TravelPal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TravelPal.WindowsTravelPal.Windows  5   	   %    TravelPal.Windows.TravelsWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TravelPal.Windows     5   	     � Title$  TravelsWindow��5      $	��450��6%   $	��800��62   $��Arial)�6>   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $	��240 �6   �� 5      $	��300 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��120 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��20 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5!   
   �� $ ��/Images/travelpal-logo.png��6   $��2��64   $��1��6D   $��100px��6Q   �� 5#   
   $,��&D:\Slutprojekt_OPG1/travelpal-logo.png��6   $��2��6@   $��1��6P   $��100px��6]   �� 5%   
   -   5        $��lblUsername��5%      $��3��6#   $��1��63   $��14(�6@   $��Hello��6O   $��Center=�6a   ���#7B68EE$
��Bold"�6�   �� 5(   
   -   5         ��Name$ addTravelBtn��5(      $��
Add Travel��6'   $��1��6W   $��7��6g   $��
35,10,35,0q�6t   $	��120��6�   ���#7B68EE���#7B68EE���#F5FFFA$y�Visible=�6�   �� 5)   
   -   5        $ checkDetailsBtn��5)      $��Details��6*   $��1��6Z   $��8��6j   $��
35,10,35,0q�6w   $	��120��6�   ���#7B68EE���#7B68EE���#F5FFFA6�   �� 5*   
   -   5        $ removeTravelsBtn��5*      $��Remove��6+   $��1��6[   $��9��6k   $��
35,10,35,0q�6x   $	��120��6�   ���#7B68EE���#7B68EE���#F5FFFA6�   �� 5+   
   -   5        $ 
signOutBtn��5+      $��Sign out��6%   $��3��6Q   $��11��6a   $��
35,10,35,0q�6o   $��90��6�   ���#7B68EE���#7B68EE���#F5FFFA6�   �� 5,   
   -   5        $ aboutBtn��5,      $��About TravelPal��6#   $��3��6T   $��7��6d   $��
35,10,35,0q�6q   $	��120��6�   ���#7B68EE���#7B68EE���#F5FFFA6�   �� 5.   
   -   5        $��
lstTravels��5.      $��2��6%   $��2��65   $��10��6B   50      53      54      