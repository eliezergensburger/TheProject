   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PL.HostingUnitWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  HostingUnitWindow��5	   	   $��504.808��6#   $��902.885��64    � SizeToContent$ WidthAndHeight=�6D   .��5
      � $	��474��6   $��Bottom=�6    � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $	��71* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��60* �6   .+�5   
   �� $��2��6   $��Center=�6%   $��HostingUnits��6B   $��20(�6Y   � 5   
   -   5         �Name$ gridAddHostingUnit��5      $	��Top=�6+   $��42,18.324,0,0q�6C   $
��Left=�6Z   $��1��6u    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     5      �� 5      $��0 �6#   �� 5      $	��120 �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��0��6h   $��Hosting Unit Name:��6x   $��2��6�   �� 5      -   5         ��Name$ hostingUnitNameTextBox��5      $	��120��66   $��Center=�6B   $��0��6�   $��3,4,0,4q�6�   $��24��6�   $
��Left=�6�   $��2��6
  ��6]   �� *HostingUnitName+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6
  �� 5       $��Center=�6   $��1��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��0��6h   $��Owner:��6x   $��2��6�   �� 5!      -   5        $ ownerTextBox��5!      $	��120��6,   $��Center=�68   $��1��6�   $��3,4,0,4q�6�   $��24��6�   $
��Left=�6�   $��2��6�   ��6S   �� *Owner+$ TwoWay=� .  . 6�   5"      &   System.Windows.Controls.DataGrid  5#   
   -   5        	  Name$	 hostingUnitDataGrid��5#      
   AutoGenerateColumns
 .  $��1��6L      EnableRowVirtualization . $��19,38.324,81,133q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��1��6�   ��6{   �� z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(       �� Angle$ 0.095Q�6&   T� 5)      5*         Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      -   5        hostingUnitNameColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Hosting Unit Name��5-   h      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *HostingUnitName+6�     5.      -   5        ownerColumn��$ Owner��5.   T   $ SizeToHeader 6c    6:   �� *Owner+6c   50      �� 51   
   -   5         ��Name$ Addbtn��51      $	��Add��6!   $
��Left=�6/   $��118,170.324,0,0q�6J   $	��Top=�6c   $��75��6{   $��1��6�   6�   53      54      