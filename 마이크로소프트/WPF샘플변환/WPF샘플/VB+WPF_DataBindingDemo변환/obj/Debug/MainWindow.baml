   M S B A M L   `   `   `  ����W  SVB+WPF_DataBindingDemo변환, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:VB_WPF_DataBindingDemo변환VB_WPF_DataBindingDemo변환  5   	   -    'VB_WPF_DataBindingDemo변환.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:VB_WPF_DataBindingDemo변환     5   	     � Title$  List of Products��5   	    � SizeToContent$ WidthAndHeight=�6"    � 	Resources 5	         ListingDataView �� Source �� Current �� Source �� Path��%M   &	        �� 5
   
    5      �� # Z $ AuctionItems�5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��auto �6   �� 5      $	��300 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��3��6!   $��8,20,8,8q�65   List of Items For sale:6`   �� 5   
   -   5        $��Grouping��5      $��1��6#   $��0��60   $��8q�5      .��6   Group by category5      �� 5    
   -   5        $��	Filtering��5       $��1��6$   $��1��61   $��8q�5"      .��6   Show Only bargains5#      �� 5$   
   -   5        $��Sorting��5$      $��1��6"   $��2��6/   $��8q�5%      .��6   Sort by category and date5&      �� 5(   
   -   5        $��Master��5(      4  .System.Windows.Automation.AutomationProperties	   Name$	 List of Itemos For Sale��6    $��2��6T   $��3��6a   $��8q�6u   
   LiveSetting$
 	Assertive=�5)      6A   �� 5*   
   -   5        $��Detail��5*      $��3��6'   $��3��64   $��9,0,0,0q�5+      ��.  6*   �� 5,   
   -   5        $��OpenAddPropduct��5,      $��4��6(   $��1��65   $��Add Product��6E   $��Center=�6[   $��8q�5-      5.      5/      50      