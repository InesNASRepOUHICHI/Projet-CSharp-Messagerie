   M S B A M L   `   `   `  ����E  AWpfProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfProject.ViewModelWpfProject.ViewModel  5   	       WpfProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfProject.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��432��6   $	��859��6)    � DataContext 5	      (   "WpfProject.ViewModel.ViewModelBase  5
   
   6     � 	Resources 5         InfoPersonnes��%m   &	        �� 5   
   .R�5      �� $��0��62   $��20(�6B   ��6   �� *
Nickname+6B   5      5      .��5      � $��	0,0,-8,-5q�6   ��5   
   �� 5       �� ImageSource$X RC:\Users\INES NASR\Desktop\MBDS M2\ProjetC#\WpfProject\WpfProject\images\sms-e.png��6    � ColumnDefinitions 5   
   �� 5      $
��315* �6   �� 5      $
��114* �6   �� 5      $
��420* �6   �� 5      $��7* �6    � RowDefinitions 5   
   �� 5      $��3* �6   �� 5       $��1* �6   .+�5"   
   �� $��0��6   $��0��6!    �� Padding$ 5q�6.   ���#4E87D4$��47,16,16,248q�6O   ._�5#      �� $	��Top=�6   
�������$��
63,-5,68,0q�6?   $��25��6S    J� RenderTransformOrigin$ 0.495,1&�6_   .��6   Liste des Contacts6�   5$      �� 5%   
   -   5        $��PersonneList��5%   '   $��47,47,16,87q�6   #��[  6<   $��2��6�   ��6l   �� *	Personnes+ �� SelectedItem 6�   �� *PersonneSelected+5'      �� 5(   
   $��67,40,150,34q�6   $ 2.132,0.486&�6*   $��1��6s   ��6N   �� *AddButtonCommand+.��5)      �� $W��QC:\Users\INES NASR\Desktop\MBDS M2\ProjetC#\WpfProject\WpfProject\images\plus.png��6   6q   z�5*      V� 5+      .~�5,      �� �� 5-      	 �� AngleY$	 -0.573Q�6$   �� 5.      T� 5/      
 T� Y$
 -2.089Q�6)   50      52      �� 53   
   $��188,39,33,34q�6   $ 2.132,0.486&�6)   $��1��6u   ��6M   �� *DeleteButtonCommand+.��54      �� $X��RC:\Users\INES NASR\Desktop\MBDS M2\ProjetC#\WpfProject\WpfProject\images\minus.png��6   6r   55      �� 57   
   -   5        $
��List��57   G   $��
10,39,63,0q�6   $ 0.5,0.5&�6&   
���  ��$	��255��6�   $	��Top=�6�   $��2��6�   ��6S   ��  �� ElementName$ PersonneList�� �� Path$ SelectedItem.GetList�6�   �� 58   
   -   5        $��inputtxt��58   B   $��10,10,112,10q�6   $��2��6R   $��1��6b   ��6(   �� $	 Msg�6b   �� 59   
   $��328,39,20,34q�6   $ 2.132,0.486&�6(   $��2��6L   $��1��6�   ��6\   �� *SendButtonCommand+.��5:      �� $_��YC:\Users\INES NASR\Desktop\MBDS M2\ProjetC#\WpfProject\WpfProject\images\telegram-app.png��6   6y   5;      �� 5<   
   $��2��6   $��0��6!   $��35��6.   $ 5q�6:   ���#4E87D4$��10,16,63,253q�6[   ._�5=      �� $	��Top=�6   
�������$��112,-5,68,0q�6?   $��25��6T   $ 0.495,1&�6`   $��Liste des Messages��6�   5>      5?      5A      