   M S B A M L   `   `   `  ����?  ;UP_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UP_4UP_4  5          UP_4.SecondGrid   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:UP_4     5        N� Title$  
SecondGrid��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $
��320* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $
��320* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ 	forSearch��5      $��Center=�6%   �� 5   
   
���   �$��1q�6%    �� CornerRadius$ 20,20,20,20��69   $��1��6T   ._�5      �� -   5         ��Name$ forGrid��5      $
��16px(�6&   $��0��66   $��1��6C   $��
ПОИСК��6S   $��9,9,9,9q�6c   
�������
�������
���   �6�   5      �� 5   
   
���   �$��1q�6%   $ 20,20,20,20��69   $��1��6T   $��1��6b   ._�5      �� -   5        $ forClean��5      $
��16px(�6'   $��1��67   $��1��6D   $��ОЧИСТИТЬ��6T   $��9,9,9,9q�6g   
�������
�������
���   �6�   5      �� 5    
   
���   �$��1q�6%   $ 20,20,20,20��69   $��1��6T   $��3��6d   ._�5!      �� -   5        $ forExit��5!      $
��16px(�6&   $��0��66   $��0��6C   $��
ВЫЙТИ��6S   $��9,9,9,9q�6c   
�������
�������
���   �6�   5"      �� 5$   
   -   5         ��Name$ ProductsComboBox��5$      $��1��6-   $��0��6;   6K   &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ ProductsDataGrid��5&      $��2��6-   $��2��6:   $��0,0,0,47q�6N      AutoGenerateColumns .  	   Columns	 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn
   Header$'
 !Название Продукта��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *ProductName+  5)      $
 Цена Продукта��6%    6<   �� *PriceProduct+5+      5,      5-      