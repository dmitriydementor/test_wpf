   M S B A M L   `   `   `  ����  Test MAterial Design&     LearnIT.Views.QuizPages.QuizPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/  5        N� Title$  Dictionary select��5	       N� WindowHeight$	 600Q�5
       N� WindowWidth$	 800Q�6   $	��550��5      $	��700��6    N� 	KeepAlive .   N� ShowsNavigationUI .   � 	Resources 5         xmlWordsProvider  xmlTranslationsProvider��%:   &	        &	      � 5   
   65   � 5   
   6<   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   ��5   
   �� 5      .��5      �  � Offset$
 0.00Q�6    � Color$ 	#FFFFEADC��6-   6A   � 5      $
 1.00Q�6   $ 	#FFFFE7FE��6-   6A   5      .+�5"   
   �� $��24(�6   $��15 30q�6"   $��0��61   )'Match the words with their translations6g   � 5$   
   -   5        $��gridWithLists��5$      $��1��6   	 � ColumnDefinitions	 5%      �� 5&      6%   �� 5'      6%   .+�5*      �� -   5        $��listBoxWords��5*      $��0��6*   $��Stretch=�5+      $��Stretch=�64   $��10q�5,      $��24(�6#   ��5-      �� 
 �� Source#
 [   �� XPath$ string�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated . 5.      �� 51      -   5        $��listBoxTranslations��51      $��1��61   $��Stretch=�52      $��Stretch=�64   $��10q�53      $��24(�6#   ��61   �� #
 [ $ string��$ TwoWay=� . 54      57      �� 58   
   -   5        $��resultTextBlock��58      $��32(�6+   $��20q�69   $��2��6E   6T   c� 5:   
   $��3��6   $��18(�6   .@�5;      �� -   5        .��5<      ��  �� Orientation$ 
Horizontal=�6   .+�5=      !  FontAwesome.WPF.FontAwesome     Icon$ Backward=�6%   $��Center=�65   �� 5>      $��Center=�6    $�� Back��6=   6L   5?      5@      �� 5A      -   5        .��5B      �� $ 
Horizontal=�6   .+�5C        $ Question=�6%   $��Center=�65   �� 5D      $��Center=�6    $�� Help��6=   6L   5E      5F      5H      5I      5J      