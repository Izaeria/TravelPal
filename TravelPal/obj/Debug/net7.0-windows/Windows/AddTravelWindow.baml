   M S B A M L   `   `   `  ����D  @TravelPal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TravelPal.WindowsTravelPal.Windows  5   	   '    !TravelPal.Windows.AddTravelWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TravelPal.Windows     5   	     � Title$  TravelsWindow��5      $	��450��6(   $	��800��65   $��Arial)�6A   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $	��240 �6   �� 5      $	��240 �6   �� 5      $	��140 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��120 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��20 �6   .+�5    
   �� $ ��/Images/travelpal-logo.png��6   $��2��65   $��1��6E   $��100px��6R   �� 5#   
   $��2��6   $��2��6$   $��30(�61   $��Add Details��6@   $��center=�6T   �� 5%   
   $��1��6   $��3��6$   $��20(�61   $��Country:��6@   $��	0,0,10,10q�6P   $��right=�6c   �� 5&   
   -   5         ��Name$ 
cmbCountry��5&      $��2��6'   $��3��67   $��0,0,30,0q�6D   �� 5(   
   $��1��6   $��4��6$   $��20(�61   $��City:��6@   $��	0,0,10,10q�6M   $��right=�6`   �� 5)   
   -   5         ��Name$ txtCity��5)      $��2��6#   $��4��63   $��0,0,30,0q�6@   �� 5+   
   $��1��6   $��5��6$   $��20(�61   $��No. of Travelers:��6@   $��	0,0,10,10q�6Y   $��right=�6l   �� 5,   
   -   5        $ cmbTravelers��5,      $��2��6)   $��5��69   $	��100��6F   $
��Left=�6R   �� 5-   
   $��1��6   $��6��6$   $��20(�61   $��Type:��6@   $��	0,0,10,10q�6M   $��right=�6`   �� 5/   
   -   5        $��cmbType��5/      $��2��6N   $��6��6^   $	��150��6k   $
��Left=�6w   51      �� 52   
   -   5        $��txtbMeetingDetails��52      $��1��6.   $��7��6>   $��20(�6K   $��Meeting Details: ��6Z   $��Right=�6s   $y�Hidden=�6�   �� 53   
   -   5        $��txtMeetingDetails��53      $��2��6+   $��7��6;   $	��150��6H   $��20(�6U   $
��Left=�6d   $y�Hidden=�6�   �� 54   
   -   5        $��xbAllInclusive��54      $��All Inclusive?��6)   $��2��6B   $��7��6R   $��20(�6_   $��	0,0,10,10q�6o   $y�Hidden=�6�   �� 56   
   -   5        $��txtAddLuggage��56      $��3��6'   $��3��67   $��1��6D   $y�Hidden=�6U   �� 57   
   -	   5        $��
lstLuggage��57      $��4��6%   $��2��65   $��3��6I   $��4��6V   �� 5:   
   -
   5        $��lblUsername��5:      $��3��6#   $��2��63   $��1��6G   $��2��6T   $��12(�6e   $��Hello��6t   $��Center=�6�   ���#7B68EE$
��Bold"�6�   �� 5>   
   -   5        $��xbTravelDocument��5>      $��Travel Document��6+   $��3��6E   $��5��6U   $��12(�6b   $��	0,10,10,0q�6r   �� 5?   
   -   5        $��
xbRequired��5?      $��	Required?��6%   $��3��69   $��6��6I   $��12(�6V   $��	0,10,10,0q�6f   �� 5A   
   -   5         ��Name$ addLuggageBtn��5A      $	��Add��6(   $��3��6R   $��7��6b   $��10(�6o   $��40��6}   $��right=�6�   ���#7B68EE���#7B68EE���#F5FFFA6�   �� 5B   
   -   5        $ saveDetailsBtn��5B      $
��Save��6)   $��2��68   $��8��6e   $��10(�6r   $
��85,5q�6�   $��60��6�   $��center=�6�   ���#7B68EE���#7B68EE���#F5FFFA6�   �� 5C   
   -   5        $ 	goBackBtn��5C      $��Go back��6$   $��2��6N   $��9��6^   $��10(�6l   $
��85,5q�6z   $��50��6�   $��center=�6�   ���#7B68EE���#7B68EE���#F5FFFA6�   5E      5F      