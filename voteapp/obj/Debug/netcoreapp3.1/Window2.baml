   M S B A M L   `   `   `  ����B  >voteapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:voteappvoteapp  5   	       voteapp.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:voteapp     5   	     � Title$  Window2��5   	   $	��450��6   $	��800��6&   .��5	      � -   5         �Name$ menuWin��5	      #��� ��6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $��投票管理系统��6   $��Center=�6!   $��0,25,0,0q�6>   $	��Top=�6P   $��40��6h   $	��150��6t   $��22(�6�   �� 5   
   -   5         ��Name$ gotovote��5      $��参与投票��6#   $
��Left=�62   $��50��6M   $��
320,95,0,0q�6Y   $	��Top=�6m   $	��156��6�   $��20(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF7ED9B6��6#   � 5      $ White��6#    � Offset$ 1Q�61   5      5      �� 5   
   -   5        $ delivervote��5      $��发起投票��6&   $
��Left=�65   $��50��6P   $��320,170,0,0q�6\   $	��Top=�6q   $	��156��6�   $��20(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF7ED9B6��6#   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $ personcenter��5      $��个人中心��6'   $
��Left=�66   $��50��6Q   $��320,245,0,0q�6]   $	��Top=�6r   $	��156��6�   $��20(�6�   ��5       �� 5!      $ 0.5,1&�6&   $ 0.5,0&�67   .��5"      � $ 	#FF87DCBB��6#   � 5#      $ White��6#   $ 1Q�61   5$      5&      �� 5'   
   -   5        $ logout��5'      $��退出登陆��6!   $
��Left=�60   $��50��6K   $��320,320,0,0q�6W   $	��Top=�6l   $	��156��6�   $��20(�6�   6�   �� 5(   
   $��欢迎您：��6   $
��Left=�6   $��
535,65,0,0q�6:   $	��Top=�6N   $��25��6f   $��50��6r   �� 5)   
   -   5         ��Name$ 
username_2��5)      $��Label��6$   $
��Left=�64   $��
600,65,0,0q�6O   $	��Top=�6c   $��75��6{   5+      5,      