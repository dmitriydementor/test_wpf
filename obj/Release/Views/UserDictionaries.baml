   M S B A M L   `   `   `  ����   Test MAterial Design$    LearnIT.Views.UserDictionaries   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/    N� Title$  Dictionary select�� N� WindowHeight$	 600Q� N� WindowWidth$	 800Q�$	��550��$	��700�� N� 	KeepAlive .  N� ShowsNavigationUI .   � 	Resources    dictionaryNameProvider � Source � XPath  contextMenuDictionary��%�   &	        &	 L     � $  data/users/Dima/system.xml?�$% /ArrayOfDictionaryNameAndAmount���� .@�m� -   $��Delete��m� -   $
��Edit��.���  � RowDefinitions �� $
��Auto ��� .+�o� $��0��	 o� 
IsMainMenu	 .  .@�m� $��Learning��.@�m� -   $��Start learning��$	��200��
 m� Icon
 !  FontAwesome.WPF.FontAwesome     Icon$ GraduationCap=�m� -   $��Switch user��$	��200��
   $
 User=��� m� -   $
��Exit��$	��200��
   $ FlagCheckered=�m� $��
Dictionary��.@�m� -   $��Create dictionary��$	��200��
   $
 Plus=�m� -   $��View/Edit dictionary��$	��200��
   $
 File=�m� -   $��Delete dictionary��$	��200��
   $ Remove=�m� $
��Help��.@�m� $
��Help��$	��200��
   $
 Info=�m� $��About creator��$	��200��
   $
 Yelp=�� -	   $��backgroundGrid��$��1������ .���  � Offset$
 0.00Q� � Color$ 	#FFD7E4F0��� $
 1.00Q�$ 	#FFDFDFEE��.+�� -
   $��dictionariesGrid��$
��1920��$��0 -3 0 0q� �� �� $
��Auto ��� $
��Auto �.+��� -   $��listBoxDictionaries�� �� SelectedIndex$ 0�� � ContextMenu# [ $��0��$��Stretch=�$	��600��$	��400��$
��1920��$��24(� %� VirtualizationMode$ 	Recycling=� %� 
ScrollUnit$ Pixel=�! �� IsDeferredScrollingEnabled . ����  �� Source# [   �� XPath$ DictionaryNameAndAmount�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� View ��  �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Tooltip��.P���  �� Width$	 300�� �� DisplayMemberBinding �� $
 Name��.���� .��
Category�� $	 100�� �� $
 Size��.���� .��Wordsc� $��1��$��18(�.@��� -   .����  �� Orientation$ 
Horizontal=�.+�  $
 User=�$��Center=��� $��Center=�$�� Switch user���� �� -   .���� $ 
Horizontal=�.+�  $
 Plus=�$��Center=��� $��Center=�$
�� Add���� -   .���� $ 
Horizontal=�.+�  $
 Edit=�$��Center=��� $��Center=�$�� Edit���� -   .���� $ 
Horizontal=�.+�  $ Remove=�$��Center=��� $��Center=�$�� Delete���� �� -   .���� $ 
Horizontal=�.+�  $ Question=�$��Center=��� $��Center=�$�� About���� -   .���� $ 
Horizontal=�.+�  $ Phone=�$��Center=��� $��Center=�$�� Help���� -   $��buttonStartLearning�� � ToolTip$ Start learning�� �� 	IsDefault . $	��200��$��60��$	��300��$��90��$��20q�$��2��$��24(�.��Start