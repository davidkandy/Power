   M S B A M L   `   `   `  ���� @  <Power, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PowerPower      Power.DialogWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Power       � WindowStartupLocation$  CenterScreen=� � 
ResizeMode$ NoResize=� � Icon$ Images/Power.ico�� � Title$ 	Set Timer��$	��190��$	��310��.��� 
������� � 	Resources    fontsize �� 
TargetType �� Property �� Value��%-   &	        �� " ��.���  � ��$ 10(� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto �	 � ColumnDefinitions	 �� $	��230 ��� $��70 �.+��� $��0��.+��� $��5 20 0 5q�
 �� Orientation$
 
Horizontal=�$	��Top=�.+��� $��30��$��Arial Rounded MT Bold)�$��Timer:��$��Center=�$��Center=��� -   $��Options��$��5q�$��90��$��22������ *
Capsules+���� .R��� ���� *Name+�� $
 
Horizontal=�$��5 5 0 5q�{���  �� ElementName$ CheckBox�� �� Path$ 	IsChecked�.+��� $��Time:��$��Arial Rounded MT Bold)�$��25���� -    ��Name$ hh��$��Center=�$��Center=�$��5 0 5 0q�$��25��$
��Left=�$��25��$��00��{�. $	��Top=�$
��Bold"��� -   $��colon1��$��:��$��Center=�$��Center=��� -   $ mm��$��Center=�$��Center=�$��5 0 5 0q�$��25��$
��Left=�$��25��$��00��{�. $	��Top=�$
��Bold"��� -    ��Name$ colon2��$��:��$��Center=�$��Center=��� -   $ ss��$��Center=�$��Center=�$��5 0 5 0q�$��25��$
��Left=�$��25��$��00��{�. $	��Top=�$
��Bold"��� $��48��$��25��.@��� $��AM�� �� 
IsSelected . �� $��PM���� -    ��Name$ CancelTimer��$��Bottom=�
���  ��$
��Left=�$��15 05q�$��Cancel Timer���� $
 Vertical=�$��1��$��Bottom=�.+��� -   $��Cancel��$��Arial Rounded MT Bold)�$��25��$��50��$��05q�$��Cancel���� -	   $ Ok��$��Arial Rounded MT Bold)�$��25��$��50��$��Ok��