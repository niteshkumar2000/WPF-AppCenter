   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Video   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  Video��5   	   $��698.5��6   $��874.4��6&   .��5	      � $��0,0,5.6,-16.8q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   r� -   5        $��mePlayer��5   /    r� LoadedBehavior$ Manual=�6   $��	0,0,0,240q�6?   �� 5   
   $��Bottom=�6   $��596,0,178,196q�60   $��24��6G   Volume6]   �� 5   
   -   5        $��volumeSlider��5      $��Center=�6%    � Minimum$ 0Q�5   	    � Maximum$ 1Q�6    � Value$	 0.5Q�6!   $��594,437,78,175q�6-   $��76��6E    J� RenderTransformOrigin$ 0.499,0.899&�6Q   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5       T� Y$ -51.87Q�6)   5      5      �� 5   
   $��596,536,178,125q�6   $��Center=�6/   $��27��6J   Speed6]   �� 5   
   -   5        $��speedRatioSlider��5      $��Center=�6)   $ 1Q�5      $��596,568,82,79q�6   $��41��6)   $ 0.513,0.946&�65   �� 5   
   $��596,604,190,66q�6   $��Center=�6-   $��18��6H   	Seek To6]   �� 5   
   -   5        $��timelineSlider��5      $��596,627,82,35q�6'   6>   �� 5    
   $��0,468,321,62q�6   .+�5!      �� -   5        	 ��Name$	 btnOpenAudioFile��5!      $��100,10,99.6,10q�6P   $��Open Video file��6h   �� 5"      -   5        
 ��Name$
 Filename��5"      $
��NILL��6&   $��Center=�65   $��	5,5,4.6,5q�6Y   �� 5#      -   5        $
 	lblStatus��5#      $��Not playing...��6'   $��Center=�6@   $��5q�6d   � 5$      $��Center=�6   .+�5%      �� -	   5        $	 btnPlay��5%      $
��Play��6@   �� 5&      -
   5        $	 btnPause��5&      $	��5,0q�6+   $��Pause��6O   �� 5'      -   5        $	 btnStop��5'      $
��Stop��6@   5(      5)      5*      5+      