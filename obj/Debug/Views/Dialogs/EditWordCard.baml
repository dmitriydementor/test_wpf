   M S B A M L   `   `   `  ����  Test MAterial Design(    "LearnIT.Views.Dialogs.EditWordCard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Edit word card��5   	   $	��275��6    $	��300��60   $	��500��5   	   $	��550��6   $	��600��5   	   $	��550��6      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�6<    � WindowStartupLocation$ CenterOwner=�5	   	   .��5
      � -   5        $��editWordCardGrid��5
       � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� $��20q�6   $��Word or phrase:��6    $��18(�67   $��0��6E   6T   �� 5   
   $��1��6   $��18(�6   $
��20 0q�6-   ��6;   ��  �� Path$
 Word� �� Mode$ TwoWay=�6e   �� 5   
   $��20q�6   $��Translation:��6    $��18(�64   $��2��6B   6Q   �� 5   
   $��3��6   $��18(�6   $
��20 0q�6-   ��6;   �� $ Translation�$ TwoWay=�6l   �� 5   
   $��20q�6   $��Example:��6    $��18(�60   $��4��6>   6M   �� 5   
   $��5��6   $��18(�6   $
��20 0q�6-   ��6;   �� $ Example.ExampleWithWord�$ TwoWay=�6x   �� 5   
   $��20q�6   $��Translation of example:��6    $��18(�6?   $��6��6M   6\   �� 5   
   $��7��6   $��18(�6   $
��20 0q�6-   ��6;   �� $ Example.TranslatedExample�$ TwoWay=�6z   � 5!   
   $��10 20q�6   $��8��6    � ColumnDefinitions 5"      �� 5#      6%   �� 5$      6%   .+�5&      �� -   5        $��0��5&      $	��150��6%   $��60��64   $	��300��6C   $��90��6R   $��10q�6a   $��24(�5'   3    �� 	IsDefault . .��6R   Save6X   �� 5)      -   5        $��1��5)      $	��150��6%   $��60��64   $	��300��6C   $��90��6R   $��10q�6a   $��24(�5*   <   .��6J   Cancel6R   5+      5-      5.      