   M S B A M L   `   `   `  ����B  >TestWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TestWPF.ViewTestWPF.View  5   	       TestWPF.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TestWPF.View     5   	     � Title$  DBTool��5   	    � 
ResizeMode$ CanMinimize=�6   $	��450��61   $	��800��6>   ���	#FF282A36 J� Opacity$ 0Q�6a    � Triggers 5	      :� 5
   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      W�  g� Duration$ 00:00:02D�6&    �� TargetProperty$ Opacity�6:   	 W� To$ 1X�6^   5      5      5      .��5      � .+�5   
   �� -   5        $��dataList��5      $��	0,0,200,0q�6#   ���#282a36���	#FFF8F8F2���	#FFF8F8F2 �� View 5      �� 5      .P�5      �� $��ID��6%   	 �� Width$	 50��6U   
 �� DisplayMemberBinding
 61   �� *id+6U   �� 5      $��ApplicationName��6%   $		 150��6o   
 6>   �� *applicationName+6o   �� 5      $��UserName��6%   $		 150��6a   
 67   �� *
userName+6a   �� 5      $��Comment��6%   $		 250��6_   
 66   �� *	comment+6_   5      5      �� 5   
   -   5        $��Insert��5      $
��Left=�6"   $��650,250,0,0q�6=   $	��Top=�6R   $��25��6j   $	��100��6w   ���#f8f8f26�   �� 5   
   -   5        $��Update��5      $
��Left=�6"   $��650,300,0,0q�6=   $	��Top=�6R   $��25��6j   $	��100��6w   ���#f8f8f26�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $��650,350,0,0q�6=   $	��Top=�6R   $��25��6j   $	��100��6w   ���#f8f8f26�   �� 5    
   $��Application Name��6   $
��Left=�6+   $��
650,50,0,0q�6F   $	��Top=�6Z    J� RenderTransformOrigin$ 0.491,0.658&�6r   $	��100��6�   ���#ffb86c6�   �� 5!   
   -   5        $��ApplicationText��5!      $
��Left=�6)   $��23��6D   $��
650,75,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��100��6�   ���#f8f8f26�   �� 5"   
   $��	User Name��6   $
��Left=�6$   $��650,100,0,0q�6?   $	��Top=�6T   $ 0.491,0.658&�6l   $	��100��6�   ���#ffb86c6�   �� 5#   
   -   5        $��UserNameText��5#      $
��Left=�6&   $��23��6A   $��650,125,0,0q�6M   $
 Wrap=�6b   $��TextBox��6v   $	��Top=�6�   $	��100��6�   ���#f8f8f26�   �� 5$   
   $��Comment��6   $
��Left=�6"   $��650,150,0,0q�6=   $	��Top=�6R   $ 0.491,0.658&�6j   $	��100��6�   ���#ffb86c6�   �� 5%   
   -   5        $��CommentText��5%      $
��Left=�6%   $��23��6@   $��650,175,0,0q�6L   $
 Wrap=�6a   $��TextBox��6u   $	��Top=�6�   $	��100��6�   ���#f8f8f26�   �� 5&   
   -   5        $��Progress��5&      $��
Waiting...��6    $
��Left=�65   $��650,385,0,0q�6P   $	��Top=�6e   $	��100��6}   $��25��6�   ���#ffb86c6�   5'      5(      