   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Browser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Browser��5   	   $	��450��6   $	��800��6&   .��5	      � ��5
   
   �� 5       � MappingMode$ RelativeToBoundingBox=�6"    �� EndPoint$ 0.5,1&�6F    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ 	#FF000000��6    � Offset$ 0Q�61   � 5      $ 	#FF52698D��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $��0.226* �6   �� 5      $��0.774* �6    � RowDefinitions 5   
   �� 5      $��0.091* �6   �� 5      $��0.755* �6   �� 5      $��0.154* �6   .+�5   
   �� $��179.4,10,352.2,310.6q�6   $��Mini Browser��62   $
��Wrap=�6F   ���	#FFF4EAEA$��1��6q   $��2��6�   �� 5   
   $��1,1,1,1q�6   $��2��6"   $��1��66   ���	#FF000000$��1,1,1,1q�6[   ._�5      (  "System.Windows.Controls.WebBrowser  -   5          Name$ 	myBrowser��5      $��0.2,0.2,0,-27q�6,   	 � Cursor$	 Arrow��6C   5      �� 5   
   $��1,27.4,1.2,-0.2q�6   $��2��6*   $��2��6>   ���	#FF000000$��1,1,1,1q�6c   ._�5      �� $��0.2,25.2,0,-1q�6   
 �� Orientation$
 
Horizontal=�60   .+�5      �� -   5         ��Name$ btnInternal��5      $��
9,-25,0,-1q�6.   $	��175��6B   $��Load Default Site��6N   ���	#FF0F0D0D$
��Bold"�6�   $��14(�6�   6�   5       5!      5#      5$      