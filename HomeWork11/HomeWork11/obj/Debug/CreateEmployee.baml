   M S B A M L   `   `   `  ����E  AHomeWork11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HomeWork11
HomeWork11  5   	       HomeWork11.CreateEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:HomeWork11     5   	     � Title$  CreateDepartmentWindow��5   	   $	��200��6(   $	��300��65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��50* �6   �� 5      $	��50* �6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��25* �6   �� 5      $	��25* �6   �� 5      $	��25* �6   .+�5   
   �� $$��Тип сотрудника : ��5      $��0��5      $��0��5      5      �� 5   
   -   5         ��Name$ EmployeeType��5      $��0��5      $��1��5      ��5      ��  �� Source "   HomeWork11.EnumToItemsSource  *M� *local:EmployeeEnum++5       �� 5"   
   $��	Имя : ��5#      $��1��5$      $��0��5%      5'      �� 5)   
   -   5         ��Name$ 	FirstName��5,      $��1��5*      $��1��5+      5-      �� 5/   
   $��Фамилия : ��50      $��2��51      $��0��52      54      �� 56   
   -   5        $ LastName��59      $��2��57      $��1��58      5:      �� 5<   
   -   5         ��Name$ CreateNewEmployee��5@      $��3��5=      $��2��5>      $��Создать��5?      5A      5B      5C      