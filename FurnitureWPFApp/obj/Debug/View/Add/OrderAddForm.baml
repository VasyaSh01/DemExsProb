   M S B A M L   `   `   `  ����J  FFurnitureWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FurnitureWPFApp.View.AddFurnitureWPFApp.View.Add  5   	   +    %FurnitureWPFApp.View.Add.OrderAddForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:FurnitureWPFApp.View.Add     5   	     � Title$  OrderAddForm��5   	   $
��1000��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ NumberTB��5
      $
��Left=�6$   $��35��6?   $��
305,40,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��190��6�   6�   �� 5   
   -   5        $ OrderNameTB��5      $
��Left=�6'   $��35��6B   $��305,266,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��190��6�   �� 5   
   -   5         ��Name$ 	ProductCB��5      $
��Left=�6&   $��305,317,0,0q�6A   $	��Top=�6V   $	��190��6n   $��35��6z   �� 5   
   -   5        $ 
CustomerCB��5      $
��Left=�6'   $��305,367,0,0q�6B   $	��Top=�6W   $	��190��6o   $��35��6{   �� 5   
   -   5        $ ResponsibleManagerCB��5      $
��Left=�61   $��305,419,0,0q�6L   $	��Top=�6a   $	��190��6y   $��35��6�   �� 5   
   -   5        $ PriceTB��5      $
��Left=�6#   $��35��6>   $��305,471,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��190��6�   6�   �� 5   
   $��Number��6   $
��Left=�6!   $��
207,49,0,0q�6<   $	��Top=�6P   $��80��6h   �� 5   
   $
��Date��6   $
��Left=�6   $��211,174,0,0q�6:   $	��Top=�6O   $��80��6g   �� 5   
   $��
Order Name��6   $
��Left=�6%   $��211,275,0,0q�6@   $	��Top=�6U   $��80��6m   �� 5   
   $��Product��6   $
��Left=�6"   $��211,326,0,0q�6=   $	��Top=�6R   $��80��6j   �� 5   
   $��Customer��6   $
��Left=�6#   $��211,376,0,0q�6>   $	��Top=�6S   $��87��6k   �� 5   
   $��Responsible Manager��6   $
��Left=�6.   $��162,428,0,0q�6I   $	��Top=�6^   $	��137��6v   �� 5   
   $��Price��6   $
��Left=�6    $��218,480,0,0q�6;   $	��Top=�6P   $��59��6h   �� 5   
   $��Planned date��6   $
��Left=�6'   $��203,601,0,0q�6B   $	��Top=�6W   $��84��6o   �� 5   
   -   5         ��Name$ AddBT��5      $��Добавить��6    $
��Left=�63   $��299,856,0,0q�6N   $	��Top=�6c   $	��200��6{   $��40��6�   6�   �� 5   
   -   5        $ BackBT��5      $��
Назад��6!   $
��Left=�61   $��
30,902,0,0q�6L   $	��Top=�6`   $	��150��6x   $��30��6�   6�   �� 5   
   -	   5         ��Name$ SchemeImage��5      $
��Left=�6%   $	��124��6@   $��332,705,0,0q�6M   $	��Top=�6b   $	��143��6z   �� 5   
   $��Scheme��6   $
��Left=�6!   $��207,754,0,0q�6<   $	��Top=�6Q   $��59��6i   �� 5   
   -
   5        $ ImageBT��5      $��
Load Image��6"   $
��Left=�67   $��26��6R   $��537,754,0,0q�6^   $	��Top=�6s   $	��174��6�   6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ DateCalendar��5      $
��Left=�6)   $��316,516,0,0q�6D   $	��Top=�6Y   $	��170��6q     5   
   -   5        $ PlannedDateCalendar��5      $
��Left=�60   $��
307,88,0,0q�6K   $	��Top=�6_   5      5       