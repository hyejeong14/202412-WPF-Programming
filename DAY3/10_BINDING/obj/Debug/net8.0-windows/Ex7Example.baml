   M S B A M L   `   `   `  ����E  A10_BINDING, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:_10_BINDING_10_BINDING  5   	       _10_BINDING.Ex7Example   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:_10_BINDING     5   	     � Title$  
Ex7Example��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��193* �6   �� 5      $
��207* �6   .+�5   
   �� -   5         ��Name$ canvas��5      
�������$��0��64   $��0��6A   5      �� 5   
   -   5         ��Name$ 
stackpanel��5       �� Orientation$ 
Horizontal=�6*   $��0��6C   $��1��6P   .+�5      ��  �� Orientation$ Vertical=�6    � Minimum$ 0Q�6H    � Maximum$	 255Q�6T   $��10q�6b    � Value 6,   �� 	 �� Path$		 Red�6b   �� 5      $ Vertical=�6   $ 0Q�6I   $	 255Q�6U   $��10q�6c    6,   �� $	 Green�6c   �� 5      $ Vertical=�6   $ 0Q�6H   $	 255Q�6T   $��10q�6b    6,   �� $
	 Blue�6b   �� 5      $ Vertical=�6   $ 10Q�6I   $	 100Q�6V   $��10q�6d    6,   �� $	 Thick�6d   �� 5      $	��100��6   $	��100��6$   $��20q�6M   ��61   �� $	 Brush�6M   5      5      5      