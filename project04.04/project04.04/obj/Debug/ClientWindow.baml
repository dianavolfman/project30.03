   M S B A M L   `   `   `  ����G  Cproject04.04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:project04._04project04._04  5   	        project04._04.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:project04._04     5   	     � Title$#  Список клиентов��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��435* �6   �� 5      $
��359* �6    � RowDefinitions 5   
   �� 5      $��90 �6   �� 5      $	��59* �6   �� 5      $��5* �6   .+�5   
   �� $#��Список клиентов��6   $��Center=�6+   $��Center=�6H   $��30(�6c   $��2��6q   $��279,30,279.6,30q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
GridClient��5      $��1��6'   $��0,0,0.4,0.2q�64   {�. 6I   �� 5   
   $��0��6   $��2��6!   $	��175��6.   $#��Удалить клиента��6:   6V    � 5   
   -   5          �Name$ clientFrame��5      $��2��6%   $��434,90,-0.4,0q�69   $��3��6P     � NavigationUIVisibility$ Hidden=�6a   5      5      