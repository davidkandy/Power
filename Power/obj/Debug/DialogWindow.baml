   M S B A M L   `   `   `  ����@  <Power, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PowerPower  5   	       Power.DialogWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Power     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Icon$ Images/Power.ico��5
   	    � Title$ 	Set Timer��5   	   $	��190��6   $	��310��6(   .��5      � 
������� � 	Resources 5   
      fontsize �� 
TargetType �� Property �� Value��%[   &	        �� 5      " ��6%   .�5      ��  � ��$ 10(�6-   5      5      5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   	 � ColumnDefinitions	 5   
   �� 5      $	��230 �6   �� 5      $��70 �6   .+�5!   
   �� $��0��6   .+�5$      �� $��5 20 0 5q�6   
 �� Orientation$
 
Horizontal=�6+   $	��Top=�6D   .+�5%      �� $��30��6   $��Arial Rounded MT Bold)�6$   $��Timer:��6G   $��Center=�6X   $��Center=�6|   �� 5&      -   5        $��Options��5&      $��5q�6w   $��90��6�   $��22��6�   ��6V   �� *
Capsules+��5'      �� 5(      .R�5.      �� ��6   �� *Name+5/   	   57      58      �� 5C      $
 
Horizontal=�6T   $��5 5 0 5q�6m   {�6   ��  �� ElementName$ CheckBox�� �� Path$ 	IsChecked�.+�5D      �� $��Time:��6   $��Arial Rounded MT Bold)�6(   $��25��6K   �� 5F      -   5         ��Name$ hh��5F      $��Center=�6&   $��Center=�6J   $��5 0 5 0q�6l   $��25��6}   $
��Left=�6�   $��25��6�   $��00��6�   {�. $	��Top=�6�   $
��Bold"�6�   �� 5G      -   5        $��colon1��5G      $��:��6&   $��Center=�62   $��Center=�6V   �� 5H      -   5        $ mm��5H      $��Center=�6&   $��Center=�6J   $��5 0 5 0q�6l   $��25��6}   $
��Left=�6�   $��25��6�   $��00��6�   {�. $	��Top=�6�   $
��Bold"�6�   �� 5I      -   5         ��Name$ colon2��5I      $��:��6(   $��Center=�64   $��Center=�6X   �� 5J      -   5        $ ss��5J      $��Center=�6&   $��Center=�6J   $��5 0 5 0q�6l   $��25��6}   $
��Left=�6�   $��25��6�   $��00��6�   {�. $	��Top=�6�   $
��Bold"�6�   �� 5L      $��48��6   $��25��6&   .@�5M      �� $��AM��6$    �� 
IsSelected . 61   �� 5N      $��PM��6#   5O      5P      �� 5R      -   5         ��Name$ CancelTimer��5R   k   $��Bottom=�6   
���  ��$
��Left=�6A   $��15 05q�6\   $��Cancel Timer��6�   5T      �� 5W   
   $
 Vertical=�6   $��1��6,   $��Bottom=�6<   .+�5Y      �� -   5        $��Cancel��5Y   8   $��Arial Rounded MT Bold)�6   $��25��6F   $��50��6g   $��05q�6r   $��Cancel��6~   �� 5Z      -	   5        $ Ok��5Z   8   $��Arial Rounded MT Bold)�6   $��25��6D   $��50��6a   $��Ok��6l   5\      5]      5_      