   M S B A M L   `   `   `  ����B  >voteapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:voteappvoteapp  5   	       voteapp.Window5   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:voteapp     5   	     � Title$  Window5��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         ButtonBorderThickness1��%)   &	        u�5
   
   5,3,5,3q�6<   5      .��5      � #��� ��6    � ColumnDefinitions 5   
   �� 5      �� 5      $��4* �6   .+�5   
   �� $��投票主题表��6   $
��Left=�6    $��35��6;   $��
175,10,0,0q�6G   $	��Top=�6[   $	��120��6s   $��20(�6   $��1��6�   �� 5   
   -   5         ��Name$ 
getThemeID��5      $
��Left=�6&   $��30��6A   $��145,345,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $��75��6�    J� RenderTransformOrigin$ 0.833,0.494&�6�   $��16(�6�   $��1��6�    � UseLayoutRounding$ False��6�   �� 5   
   $��选择主题编号：��6   $
��Left=�6"   $��30��6=   $��
10,345,0,0q�6I   $	��Top=�6]   $	��135��6u   $��18(�6�   $��1��6�   �� 5   
   -   5        $��前去投票��5      $
��Left=�6    $��30��6;   $��285,345,0,0q�6G   $	��Top=�6\   $��95��6t   $��16(�6   ���	#FFF3F9F7$��3,2,3,2q�6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ refreshButton��5      $��更新��6(   $
��Left=�65   $��
308,51,0,0q�6P   $	��Top=�6d   $��32��6|   $��62��6�   $��18(�6�   $��3,2,3,2q�6�   $��1��6�    � Cursor$ Arrow��6�   $ 0.538,1.368&�6�   ���	#FFF0F0F06  &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataView��5      $
��Left=�6%   $	��252��6@   $��	38,88,0,0q�6M   $	��Top=�6`   $	��322��6x   $��1��6�   �� 5   
   -   5        $��返回��5      $��Center=�6   $��45��6;   $	��Top=�6G   $��75��6_   $��16(�6j   $��0,45,0,0q�6�   $��0,0,0,0q�6�   $��3,2,3,2q�6�   5      5      