   M S B A M L   `   `   `  ����D  @Reservoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Reservoom.ViewModelsReservoom.ViewModels  5   K   )    #Reservoom.Views.MakeReservationView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9
viewmodels"clr-namespace:Reservoom.ViewModels     6K   .��5      �   � IsSharedSizeScope$
  true��6    � RowDefinitions 5	   
   �� 5
      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5       
  Header#��[  5      $��Make Reservation��5      � 5   
   $��1��6   $��0 25 0 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��Username��6%   67   �� 5      $��1��6   $��0 5 0 0q�6#   ��64   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6u   5      � 5   
   $��2��6   $��0 10 0 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5"      �� 5#      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 5$      $
��auto �6#   $ SecondColumn��60   .+�5'      �� $��0��6   $��0��6%   $��	Floor No.��65   6H   �� 5(      $��1��6   $��0��6#   $��0 5 0 0q�63   ��6D   �� *FloorNumber+$ PropertyChanged=�6�   �� 5*      $��0��6   $��1��6%   $��10 0 0 0q�65   $��Room No.��6G   6Y   �� 5+      $��1��6   $��1��6#   $��10 5 0 0q�63   ��6E   �� *
RoomNumber+$ PropertyChanged=�6�   5,      � 5-   
   $��3��6   $��0 10 0 0q�6    5.      �� 5/      $
��auto �6    �� 50      $
��auto �6     53      �� 54      $
��auto �6#   $ FirstColumn��60   �� 55      $
��auto �6#   $ SecondColumn��60   .+�58      �� $��0��6   $��0��6%   $��
Start Date��65   6I   (  "System.Windows.Controls.DatePicker  59      $��1��6   $��0��6&   $��0 5 0 0q�66      SelectedDate 6G   �� *	StartDate+$ PropertyChanged=�6�   �� 5;      $��0��6   $��1��6%   $��10 0 0 0q�65   $��End Date��6G   6Y     5<      $��1��6   $��1��6&   $��10 5 0 0q�66    6H   �� *	EndDate+$ PropertyChanged=�6�   5=      �� 5>   
   $��4��6   $��0 25 0 0q�6#    �� Orientation$ 
Horizontal=�65   .+�5?      �� $��Submit��6   ��6&   �� *SubmitCommand+6J   �� 5@      $��10 0 0 0q�6   $��Cancel��6'   ��68   �� *CancelCommand+6\   5A      5B      5C      