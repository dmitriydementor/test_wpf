   M S B A M L   `   `   `  ����  Test MAterial Design&     LearnIT.Views.EditDictionaryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/  5        N� WindowHeight$	  600Q�5	       N� WindowWidth$	 800Q�6   $	��550��5
      $	��850��6    N� 	KeepAlive .   N� ShowsNavigationUI .   N� Title$ EditDictionaryPage��5       � 	Resources 5         wordsProvider��%   &	        � 5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��listViewWordCards��5      $��0��6,    �� SelectedIndex$ 0��69   $��Stretch=�5      $	��600��5      $	��400��6*   $
��1920��6:   $��24(�5       %� VirtualizationMode$ 	Recycling=�5      	 %� 
ScrollUnit$	 Pixel=�6P   !
 �� IsDeferredScrollingEnabled
 . ��5      ��  �� Source# [   �� XPath$ WordCard�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� View 5      �� 5       �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Tooltip��66   .P�5      ��  �� Width$	 300��6Q    �� DisplayMemberBinding 6%   �� $
 Word��.��5       �� .��6/   Word65   5!      �� 5"      $	 300��6X    6%   �� $ Translation��.��5#      �� .��6/   Translation6<   5$      �� 5%      $	 150��6c    6%   �� $ TimesAnsweredCorrectly��.��5&      �� .��6/   
Answered69   5'      5(      5+      c� 5-   
   $��1��6   $��18(�6   .@�5.      �� -   5        .��5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      !  FontAwesome.WPF.FontAwesome     Icon$ Backward=�6%   $��Center=�65   �� 51      $��Center=�6    $�� Back��6=   6L   52      53      �� 54      6   �� 55      -   5        .��56      �� $ 
Horizontal=�6   .+�57        $
 Plus=�6%   $��Center=�61   �� 58      $��Center=�6    $
�� Add��6=   6K   59      5:      �� 5;      -   5        .��5<      �� $ 
Horizontal=�6   .+�5=        $
 Edit=�6%   $��Center=�61   �� 5>      $��Center=�6    $�� Edit��6=   6L   5?      5@      �� 5A      -   5        .��5B      �� $ 
Horizontal=�6   .+�5C        $ Remove=�6%   $��Center=�63   �� 5D      $��Center=�6    $�� Delete��6=   6N   5E      5F      �� 5G      -   5        .��5H      �� $ 
Horizontal=�6   .+�5I        $ Refresh=�6%   $��Center=�64   �� 5J      $��Center=�6    $�� Clear all results��6=   6Y   5K      5L      5N      5O      5P      