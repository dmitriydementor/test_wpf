   M S B A M L   `   `   `  ����   Test MAterial Design&     LearnIT.Views.EditDictionaryPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/    N� WindowHeight$	  600Q� N� WindowWidth$	 800Q�$	��550��$	��850�� N� 	KeepAlive .   N� ShowsNavigationUI .   N� Title$ EditDictionaryPage�� � 	Resources    wordsProvider  contexMenuWordCard��%M   &	        &	      � �� .@�m� -   $
��Edit��m� -   $��Delete��.���  � RowDefinitions �� �� $
��Auto �.+��� -   $��listViewWordCards��$��0�� �� SelectedIndex$ 0��$��Stretch=� � ContextMenu# [ $	��600��$	��400��$
��1920��$��24(�	 %� VirtualizationMode$	 	Recycling=�
 %� 
ScrollUnit$
 Pixel=�! �� IsDeferredScrollingEnabled . ����  �� Source# [   �� XPath$ WordCard�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� View ��  �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Tooltip��.P���  �� Width$	 300�� �� DisplayMemberBinding �� $
 Word��.���� .��Word�� $	 300�� �� $ Translation��.���� .��Translation�� $	 150�� �� $ TimesAnsweredCorrectly��.���� .��
Answeredc� $��1��$��18(�.@��� -   .����  �� Orientation$ 
Horizontal=�.+�!  FontAwesome.WPF.FontAwesome     Icon$ Backward=�$��Center=��� $��Center=�$�� Back���� �� -   .���� $ 
Horizontal=�.+�  $
 Plus=�$��Center=��� $��Center=�$
�� Add���� -   .���� $ 
Horizontal=�.+�  $
 Edit=�$��Center=��� $��Center=�$�� Edit���� -   .���� $ 
Horizontal=�.+�  $ Remove=�$��Center=��� $��Center=�$�� Delete���� -   .���� $ 
Horizontal=�.+�  $ Refresh=�$��Center=��� $��Center=�$�� Clear all results��