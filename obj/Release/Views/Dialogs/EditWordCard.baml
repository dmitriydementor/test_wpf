   M S B A M L   `   `   `  ����   Test MAterial Design(    "LearnIT.Views.Dialogs.EditWordCard   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Edit word card��$	��275��$	��300��$	��500��$	��550��$	��600��$	��550��   MaterialDesignBody#���     MaterialDesignPaper#���  $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)� � WindowStartupLocation$ CenterOwner=�.��� -   $��editWordCardGrid�� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��20q�$��Word or phrase:��$��18(�$��0���� $��1��$��18(�$
��20 0q�����  �� Path$
 Word� �� Mode$ TwoWay=��� $��20q�$��Translation:��$��18(�$��2���� $��3��$��18(�$
��20 0q����� $ Translation�$ TwoWay=��� $��20q�$��Example:��$��18(�$��4���� $��5��$��18(�$
��20 0q����� $ Example.ExampleWithWord�$ TwoWay=��� $��20q�$��Translation of example:��$��18(�$��6���� $��7��$��18(�$
��20 0q����� $ Example.TranslatedExample�$ TwoWay=�� $��10 20q�$��8�� � ColumnDefinitions �� �� .+��� -   $��0��$	��150��$��60��$	��300��$��90��$��10q�$��24(� �� 	IsDefault . .��Save�� -   $��1��$	��150��$��60��$	��300��$��90��$��10q�$��24(�.��Cancel