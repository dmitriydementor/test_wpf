   M S B A M L   `   `   `  ����  Test MAterial Design/    )LearnIT.Views.QuizPages.TypeWordsQuizPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/  5        N� Title$  Dictionary select��5	       N� WindowHeight$	 600Q�5
       N� WindowWidth$	 800Q�6   $	��550��5      $	��700��6    N� 	KeepAlive .   N� ShowsNavigationUI .  .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   ��5   
   �� 5      .��5      �  � Offset$
 0.00Q�6    � Color$ 	#FFF2FFDC��6-   6A   � 5      $
 1.00Q�6   $ 	#FFE7FBFF��6-   6A   5      .+�5    
   �� $��24(�6   $��15 30q�6"   $��0��61   $��2��6>   ;9Type translation in the text box and press "Check" button6�   �� 5"   
   -   5        $
��word��5"      $��1��6    $��0��6-   $��Center=�6=   $��Center=�6X   $��24(�6u   Word6�   �� 5$   
   -   5        $��textBoxAnswer��5$       $��24(�6   $��1��65   $��1��6B   $��Stretch=�6R   $��Center=�6p   $��20q�6�   6�   �� 5&   
   -   5        $��resultTextBlock��5&   ?   $��2��6   $��0��6!   $��32(�61   $��Center=�6V   $��20q�6q   6   �� 5(   
   -   5        $��CheckAnswerBtn��5(      	 �� 	IsDefault	 . $��2��68   $��1��6E   $��40 20q�6U   $��60��6d   .��6�   Check6�   c� 5*   
   $��3��6   $��18(�6   $��2��6-   .@�5+      �� -   5        .��5,      �� 
 �� Orientation$
 
Horizontal=�6   .+�5-      !  FontAwesome.WPF.FontAwesome     Icon$ Backward=�6%   $��Center=�65   �� 5.      $��Center=�6    $�� Back��6=   6L   5/      50      �� 51      -   5        .��52      �� $
 
Horizontal=�6   .+�53        $ Question=�6%   $��Center=�65   �� 54      $��Center=�6    $�� Help��6=   6L   55      56      58      59      5:      