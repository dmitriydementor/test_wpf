   M S B A M L   `   `   `  ����  Test MAterial Design$    LearnIT.Views.UserDictionaries   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/  5        N� Title$  Dictionary select��5	       N� WindowHeight$	 600Q�5
       N� WindowWidth$	 800Q�6   $	��550��5      $	��700��6    N� 	KeepAlive .  N� ShowsNavigationUI .   � 	Resources 5         dictionaryNameProvider � Source � XPath��%i   &	        � 5   
   $  data/users/Dima/system.xml?�69   $% /ArrayOfDictionaryNameAndAmount��6]   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   o� $��0��6   	 o� 
IsMainMenu	 .  .@�5      m� $��Learning��6   .@�5      m� -   5        $��Start learning��5      $	��200��63   
 m� Icon
 5      !  FontAwesome.WPF.FontAwesome  5          Icon$ GraduationCap=�6)   5"      m� 5#      -   5        $��Switch user��5#      $	��200��60   
 5$        5%      $
 User=�6)   5'      �� 5(      6   m� 5)      -   5        $
��Exit��5)      $	��200��6D   
 5*        5+      $ FlagCheckered=�6)   5-      5/      m� 50      $��
Dictionary��6   .@�51      m� -   5        $��Create dictionary��51      $	��200��66   
 52        53      $
 Plus=�6)   55      m� 56      -   5        $��View/Edit dictionary��56      $	��200��69   
 57        58      $
 File=�6)   5:      m� 5;      -   5        $��Delete dictionary��5;      $	��200��66   
 5<        5=      $ Remove=�6)   5?      5@      m� 5A      $
��Help��6   .@�5B      m� $
��Help��6   $	��200��6)   
 5C        5D      $
 Info=�6)   5F      m� 5G      $��About creator��6   $	��200��62   
 5H        5I      $
 Yelp=�6)   5K      5L      5M      � 5Q   
   -   5        $��backgroundGrid��5Q      $��1��6%   ��5R      �� 5S      .��5T      �  � Offset$
 0.00Q�6#    � Color$ 	#FFD7E4F0��61   6E   � 5U      $
 1.00Q�6#   $ 	#FFDFDFEE��61   6E   5V      .+�5Y      � -   5        $��dictionariesGrid��5Y      $
��1920��6+   $��0 -3 0 0q�6;    5Z      �� 5[      6&   �� 5\      $
��Auto �6$   64   �� 5]      $
��Auto �6$   64   .+�5a      �� -	   5        $��listBoxDictionaries��5a       �� SelectedIndex$ 0��66   $��0��5b      $��Stretch=�6(   $	��600��5c      $	��400��6*   $
��1920��6:   $��24(�5d       %� VirtualizationMode$ 	Recycling=�5f       %� 
ScrollUnit$ Pixel=�6P   ! �� IsDeferredScrollingEnabled . ��5e      ��  �� Source# [   �� XPath$ DictionaryNameAndAmount�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� View 5h      �� 5i       �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Tooltip��6>   .P�5j      ��  �� Width$	 300��6Y    �� DisplayMemberBinding 6-   �� $
 Name��.��5k   "   �� .��67   
Category6A   5l      �� 5m      $	 100��6Y    6-   �� $
 Size��.��5n   "   �� .��67   Words6>   5o      5p      5s      c� 5u      $��1��6   $��18(�6'   .@�5v      �� -
   5        .��5w      ��  �� Orientation$ 
Horizontal=�6%   .+�5x        $
 User=�6-   $��Center=�69   �� 5y      $��Center=�6(   $�� Switch user��6E   6[   5z      5{      �� 5|      6"   �� 5}      -   5        .��5~      �� $ 
Horizontal=�6%   .+�5        $
 Plus=�6-   $��Center=�69   �� 5�      $��Center=�6(   $
�� Add��6E   6S   5�      5�      �� 5�      -   5        .��5�      �� $ 
Horizontal=�6%   .+�5�        $
 Edit=�6-   $��Center=�69   �� 5�      $��Center=�6(   $�� Edit��6E   6T   5�      5�      �� 5�      -   5        .��5�      �� $ 
Horizontal=�6%   .+�5�        $ Remove=�6-   $��Center=�6;   �� 5�      $��Center=�6(   $�� Delete��6E   6V   5�      5�      �� 5�      6"   �� 5�      -   5        .��5�      �� $ 
Horizontal=�6%   .+�5�        $ Question=�6-   $��Center=�6=   �� 5�      $��Center=�6(   $�� About��6E   6U   5�      5�      5�      �� 5�      -   5        $��buttonStartLearning��5�       � ToolTip$ Start learning��5�       �� 	IsDefault . $	��200��5�      $��60��6(   $	��300��67   $��90��6F   $��20q�5�      $��2��5�      $��24(�6&   .��5�   8   Start5�      5�      5�      5�      5�      