   M S B A M L   `   `   `  ����D  @Reservoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Reservoom.ViewModelsReservoom.ViewModels  5      ;"clr-namespace:Reservoom.ConvertersReservoom.Converters  5      P LLoadingSpinnerControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControlLoadingSpinnerControl 5      ,    &Reservoom.Views.ReservationListingView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9
viewmodels"clr-namespace:Reservoom.ViewModels     5      9
converters"clr-namespace:Reservoom.Converters     5      UcustomBclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControl     5        � 	Resources  5      >   8Reservoom.Converters.InverseBooleanToVisibilityConverter '  #InverseBooleanToVisibilityConverter   BooleanToVisibilityConverter��%:   &	        &	        5   
   69   �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��5      $��View Reservations��5       
 Header#��[ 5       �� 5!      $��1��5"      $��10 0 0 0q�5#      $��Make Reservation��5%      ��5$      �� *MakeReservationCommand+5%      5&      � 5(   
   $��1��6   $��0 25 0 0q�6   .+�5)      *  $LoadingSpinnerControl.LoadingSpinner     Diameter$	 100Q�5*         	Thickness$ 5Q�5+         Color
 �   �   	IsLoading 5,      �� *	IsLoading+5-      � 5/      y�6   �� *	IsLoading+ �� 	Converter# [  .+�50      �� 
���  ����52      �� *ErrorMessage+y�53      �� *HasErrorMessage+# [ �� 55      ��6   �� *Reservations+y�6@   �� *HasErrorMessage+# [  ��56      �� 57       �� 
TargetType" ��6    .�58      �� 	 �� Property	 � ��
 �� Value$
 Stretch=�6K   59       �� View 5;      �� 5<      .P�5=      �� $��Room ID��6-    �� CellTemplate 5>   "   �� 5?   &   .R�5@   *   �� $��Center=�64   ��6Q   �� *RoomID+5A   '   5C      �� 5E      $��Username��6-    5F   "   �� 5G   &   .R�5H   *   ��  �� Padding$ 0 0 20 0q�64   ��6G   �� *
Username+5I   '   5K      �� 5M      $��
Start Date��6-    5N   "   �� 5O   &   .R�5P   *   �� $ 0 0 20 0q�64   ��6G   �� *	StartDate+ �� StringFormat$ d��5Q   '   5S      �� 5U      $��End Date��6-    5V   "   �� 5W   &   .R�5X   *   �� $ 0 0 20 0q�64   ��6G   �� *	EndDate+$ d��5Y   '   5[      5\      5^      5_      5`      5a      5b      