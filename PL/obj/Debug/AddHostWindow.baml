   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PL.AddHostWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  AddHostWindow��5	   	   $��461.345��6   $��457.143��60   .��5      � .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	92,42,0,0q�66   $
��Left=�6I    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Bank Account:��6r   �� 5      -   5         ��Name$ bankAccountTextBox��5      $	��120��62   $��Center=�6>   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Y   �� *BankAccount+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Collection Clearance:��6r   �� 5      -   5         ��Name$! collectionClearanceComboBox��5      $	��120��6<   $��Center=�6H   $��1��6c   $��3q�6p   $
��Auto��6{   $
��Left=�6�   $��1��6�   �� 5      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Family Name:��6r   �� 5       -   5        $ familyNameTextBox��5       $	��120��61   $��Center=�6=   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6X   �� *
FamilyName+$ TwoWay=� .  . 6�   �� 5!      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��	Host Key:��6r   �� 5"      -   5        $ hostKeyTextBox��5"      $	��120��6.   $��Center=�6:   $��3��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6U   �� *	HostKey+$ TwoWay=� .  . 6�   �� 5#      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Mail Address:��6r   �� 5$      -   5        $ mailAddressTextBox��5$      $	��120��62   $��Center=�6>   $��4��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Y   �� *MailAddress+$ TwoWay=� .  . 6�   �� 5%      $��Center=�6   $��5��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Phone Number:��6r   �� 5&      -   5        $ phoneNumberTextBox��5&      $	��120��62   $��Center=�6>   $��5��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Y   �� *PhoneNumber+$ TwoWay=� .  . 6�   �� 5'      $��Center=�6   $��6��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Private Name:��6r   �� 5(      -   5        $ privateNameTextBox��5(      $	��120��62   $��Center=�6>   $��6��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Y   �� *PrivateName+$ TwoWay=� .  . 6�   5)      �� 5*   
   -	   5        $��OK��5*      $
��Left=�6   $��103,342,0,0q�69   $	��Top=�6N   $��75��6f   	 �� 	IsDefault	 . 6�   �� 5+   
   $��Cancel��6   $
��Left=�6"   $��316,342,0,0q�6=   $	��Top=�6R   $��75��6j   
 �� IsCancel
 . 6u   5,      5-      