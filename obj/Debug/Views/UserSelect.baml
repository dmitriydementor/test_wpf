   M S B A M L   `   `   `  ����  Test MAterial Design    LearnIT.Views.UserSelect   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      N JFontAwesome.WPF, Version=4.4.0.35868, Culture=neutral, PublicKeyToken=null-fa$http://schemas.fontawesome.io/icons/  5        N� Title$  LearnIT��5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper N� 
Background# �  5
   	    N� 
FontFamily$X Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�6<    N� WindowHeight$	 600Q�5   	    N� WindowWidth$	 800Q�6   $	��550��5      $	��700��6    N� 	KeepAlive .  N� ShowsNavigationUI .  .��5      � .+�5   
   � -   5        $��backgroundGrid��5      ��5      �� 5      .��5      �  � Offset$
 0.00Q�6#    � Color$ 	#FFC6DDF1��61   6E   � 5      $
 0.50Q�6#   $ 	#FFBDDFEA��61   6E   � 5      $
 1.00Q�6#   $ 	#FF8E8EE8��61   6E   5      .+�5      � -   5        $��grid2��5      $��100 10q�6    $	��500��60   	 � RowDefinitions	 5      �� 5      6&   �� 5      6&   �� 5       6&   .+�5&      �� 2  ,System.Windows.Markup.XmlAttributeProperties
  XmlSpace
 preserve6\   $��80(�6    �� TextAlignment$ Center=�6*   $��Center=�6A   !  FontAwesome.WPF.FontAwesome  6r      Icon$ GraduationCap=�6�   $��80(�6�   
 Learn IT!6�   �� 5'      -   5        $��usersListBox��5'   5   $��1��6   $��24(�6'    %� 
ScrollUnit$ Pixel=�6I   ! �� IsDeferredScrollingEnabled . .@�5(      �� 
 preserve6"   .��5)      ��  �� Orientation$ 
Horizontal=�6!   .+�5*        $ 
PlusCircle=�6)   $��24(�6;   �� 5+      
 preserve6$   	 New user6D   5,      5-      5.      �� 50      -   5        $��buttonStart��50       � ToolTip$ Start learning��51       �� 	IsDefault . $	��200��52      $��60��6$   $	��300��63   $��90��6B   $��2��53      $��24(�6"   .��54   *   Start56      5;      5=      5>      5?      