   M S B A M L   `   `   `  ����  
WpfExample    WpfExample.NamesWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  Commanding Demo��5      $	��250��6   $	��300��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� .��6   
First Name6   �� 5   
   $��1��6   ��5      �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   .��6   	Last Name6(   �� 5   
   $��1��6   $��1��6"   ��5      �� *
LastName+$ PropertyChanged=��� 5   
   $��2��6   $��2��6)    �� Orientation$ 
Horizontal=�66   $��Right=�5      .+�5      �� ��6   �� *AddNameCommand+��68   �� *.+.��6W   Add6\   �� 5      ��6   �� *RemoveNameCommand+��6;   �� *.+.��6Z   Remove6b   5      �� 5   
   $��3��6   .��6   Names6$   �� 5   
   $��1��6   $��3��6"   $	��5 0q�5   '   
���������5   /   �� *Names+ �� SelectedItem 5      �� *SelectedName+5       �� 5!   
   $��2��6   $��4��6%   .��62   Info68   5"      5#      