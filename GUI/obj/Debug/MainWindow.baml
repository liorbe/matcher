   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��400��6)   .��5	      � $��0,0,0,-3q�6   ��5
   
   �� 5       �� EndPoint$ 	0.504,1.5&�6"    �� 
StartPoint$ 
0.504,0.03&�67   .��5      �  � Color$ 	LightBlue��6    � Offset$ 0Q�61   � 5      $ 	#FFFFFFFF��6   $ 0.567Q�61   5      .+�5   
   ��  �� TextAlignment$ Center=�6   $��10q�6+   $��40(�67   Partners Matcher6Y   �� 5      $	��400��6   $��center=�6%   $��Center=�6B   .+�5      �� -   5        $
��name��5      $��	0,120,0,0q�6$   $��Center=�67   6V   �� 5      -   5        $��new_user��5      $��	0,20,0,10q�6)   $��30��6<   $��60��6H   .��6i   
New User6s   �� 5      -   5        $��search��5      $��15q�6#   $��30��6/   $��60��6;   .��6[   Search6c   �� 5      
�������$	��0.5q�6(   $	��232��6?   ._�5      � .+�5      � $��15q�6   $��center=�6$    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $	��150 �6+    � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5       $��0 �6(   .+�5"      �� .��6   	E-mail:6%   �� 5#      -   5        $��email��5#      $��1��6+   $��0,4,0,10q�6;   �� 5$      $��1��6   .��6)   	Password:64   G� 5%      -   5        $
��pass��5%   "   $��1��6.   $��1��6;   $��0,4,0,10q�6K   5'      �� 5(      -   5        $��50��5(      $��30��6(   $��	0,80,0,10q�65   $��login��6H   6X   5)      5*      5+      5-      5.      