   M S B A M L   `   `   `  ����B  >voteapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:voteappvoteapp  5   	       voteapp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:voteapp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ 
mainwindow��5	       J� OpacityMask# � ��6   #��� ��6k   .+�5
   
   �� -   5         ��Name$ appname��5
      $��投票管理系统��6!   $��Center=�62   $��0,30,0,0q�6O   $	��Top=�6a   $��80��6y   $	��230��6�   $��36(�6�    J� RenderTransformOrigin$ 	0.5,0.997&�6�   $��Microsoft JhengHei)�6�    � UseLayoutRounding$
 True��6�   �� 5   
   -   5        $ ulabel��5      $��	用户名��6    $
��Left=�6.   $��255,179,0,0q�6I   $	��Top=�6^   $��30��6v   $��90��6�   $��18(�6�   $ 0.444,2.992&�6�   �� 5   
   -   5        $ plabel��5      $��
   密码
��6    $
��Left=�65   $��255,217,0,0q�6P   $	��Top=�6e   $��30��6}   $��90��6�   $��18(�6�   �� 5   
   -   5         ��Name$ uText��5      $��350,179,310,0q�6!    �� TextWrapping$
 Wrap=�68   $	��Top=�6L   $��28��6d   $��16(�6�   $	��140��6�   �� 5   
   -   5         ��Name$ loginButton��5      $��登陆��6&   $
��Left=�63   $��300,280,0,0q�6N   $	��Top=�6c   $ 0.816,-1.312&�6{   $��35��6�   $��90��6�   $��16(�6�   �� 5   
   -   5        $ registerButton��5      $��注册��6)   $
��Left=�66   $��420,280,0,0q�6Q   $	��Top=�6f   $ 0.816,-1.312&�6~   $��35��6�   $��90��6�   $��16(�6�   6�   G� 5   
   -   5        	 G�Name$	 pText��5      $
��Left=�6%   $��28��6@   $��350,225,310,0q�6L   $	��Top=�6c   $	��140��6{   $��16(�6�   � 5   
   $��555,70,130,259q�6   $	��120��6'   $	��120��63   .+�5      �� $��Center=�6   $	��120��61   $	��Top=�6>   $	��120��6V   $ -0.083,-0.669&�6b   $��0,-6,0,0q�6�   $��image/logo.jpg��6�   5      5      5      