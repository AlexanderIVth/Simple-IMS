   M S B A M L   `   `   `  ����D  @SimpleIMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SimpleIMS	SimpleIMS  5   	       SimpleIMS.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SimpleIMS     5   	     � Title$(  "Simple Inventory Management System��5   	   $	��450��64   $	��800��6A   $	��450��6M   $	��800��6]   .��5	      � .+�5
   
   �� -   5         ��Name$ 	buttonAdd��5
      $	��Add��6$   $
��Left=�62   $��	10,10,0,0q�6M   $	��Top=�6`   $��25��6x   $��80��6�   6�   �� 5   
   -   5        $ 
buttonEdit��5      $
��Edit��6%   $
��Left=�64   $��	95,10,0,0q�6O   $	��Top=�6b   $��25��6z   $��80��6�   6�   �� 5   
   -   5        $ buttonRemove��5      $��Remove��6'   $
��Left=�68   $��
180,10,0,0q�6S   $	��Top=�6g   $��25��6   $��80��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dGItems��5      $��10,40,10,10q�6O      
IsReadOnly . 6d   5      5      