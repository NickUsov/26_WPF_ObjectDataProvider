   M S B A M L   `   `   `  ����T  P26_WPF_ObjectDataProvider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:_26_WPF_ObjectDataProvider_26_WPF_ObjectDataProvider  5   	   +    %_26_WPF_ObjectDataProvider.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:_26_WPF_ObjectDataProvider     5   	     � Title$  
MainWindow��5      $	��350��6#   $	��525��60    � 	Resources 5	         carRepository S� 
ObjectType.   (_26_WPF_ObjectDataProvider.CarRepository S� 
MethodName��%5   &	        S� 5
   
   "  63   $ GetCars��6]   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ listBox��5      ��6#   ��  �� Source# [  ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� 	 �� Path$	 Manufactured��� 5      $��  ��6$   �� 5      ��6$   �� $	 Model�5      5      5      �� 5    
   $��1��6   .+�5!      �� -   5        
 ��Name$	
 bt1��5!      $%��По производителю��6"   6=   �� 5"      -   5        $	
 bt2��5"      $��По модели��6"   66   �� 5#      -   5        $	
 bt3��5#      $"��По дате продажи��6"   6<   �� 5$      -   5        $	
 bt4��5$      $��По цене��6"   64   5%      5&      5'      