   M S B A M L   `   `   `  ����I  ECrud.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:Crud.ViewModel;assembly=Crud.ViewModelCrud.ViewModel  5   	   D @Crud.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Crud.View	Crud.View 5   	      Crud.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Cvm4clr-namespace:Crud.ViewModel;assembly=Crud.ViewModel     5   	   )localclr-namespace:Crud.View     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      "   Crud.ViewModel.MainViewModel   MainViewModel��%   &	          5   
   63   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $	��125 �6   6+   �� 5      $��* �6   6)   .+�5   
   � $��0��6   #��� ��6    5      �� 5      $	��250 �6#   61   �� 5      $��* �6#   6/   .+�5      �� -   5         ��Name$ txtId��5      $
��Left=�6%   $��	80,19,0,0q�6@    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6   $��17��6�   ��6�   �� *Id+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      -   5        $ txtEdad��5      $
��Left=�6'   $��	80,75,0,0q�6B   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   ��6�   �� *Edad+$ PropertyChanged=��� 5      $��ID��6   $
��Left=�6!   $��	44,14,0,0q�6<   $	��Top=�6O   $
��Bold"�6g   �� 5      $
��EDAD��6   $
��Left=�6#   $��	31,71,0,0q�6>   $	��Top=�6Q   	 J� RenderTransformOrigin$	 -0.171,-0.153&�6i   $
��Bold"�6�   �� 5      $��1��6   $��NOMBRE��6$   $
��Left=�65   $��	28,14,0,0q�6P   $	��Top=�6c   $
��Bold"�6{   �� 5       $��1��6   $��CORREO��6$   $
��Left=�65   $��	28,71,0,0q�6P   $	��Top=�6c   $
��Bold"�6{   �� 5!      -   5        $ 	txtNombre��5!      $��1��6)   $
��Left=�69   $��	90,18,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $	��341��6�   ��6�   �� *Nombre+$ PropertyChanged=��� 5"      -   5        $ 	txtCorreo��5"      $��1��6)   $
��Left=�69   $��	90,75,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $	��341��6�   ��6�   �� *Correo+$ PropertyChanged=�5#      � 5$   
   $��1��6    5%      �� 5&      $	��600 �6#   61   �� 5'      $��* �6#   6/   .+�5)      � $��1��6   #��� ��6#    5*      �� 5+      $��* �6$   61   �� 5,      $��* �6$   61   �� 5-      $��* �6$   61   .+�5/      �� -   5        
 ��Name$
 
btnGuardar��5/      $��Guardar��6-   $��Center=�6?   $��0,30,0,0q�6\   $	��Top=�6n   $	 -0.02,-1.281&�6�   $��35��6�   $	��140��6�   #��� ��6�   $
��Bold"�6  ��6$  �� *GuardarCommand+�� 50      -   5        $
 btnNuevo��50      $��Nuevo��6+   $��Center=�6;   $��1��6X   $	��Top=�6e   $��35��6}   $	��140��6�   $��0,30,0,0q�6�   ���	#FF64A7DA$
��Bold"�6�   ��6�   �� *LimpiarCommand+�� 51      -   5        $
 btnEliminar��51      $��Eliminar��6.   $��Center=�6A   $��2��6^   $	��Top=�6k   $��35��6�   $	��140��6�   $��0,30,0,0q�6�   ���	#FFEE7562$
��Bold"�6�   ��6�   �� *EliminarCommand+��6�   ��  �� ElementName$ DataGrid�� �� Path$ SelectedItem��� 52      $
��Left=�6   $��30��63   $��
132,32,0,0q�6?   $	��Top=�6S   $��30��6k   $��/guardar.png��6v   $	 0.413,-0.165&�6�   �� 53      $
��Left=�6   $��30��63   $��
132,32,0,0q�6?   $��1��6S   $	��Top=�6`   $��30��6x   $��/editar.png��6�   �� 54      $
��Left=�6   $��30��63   $��
132,32,0,0q�6?   $��2��6S   $	��Top=�6`   $��30��6x   $��/eliminar.png��6�   �� 55      $��	Cargar BD��6   $��Center=�6-   $��0,82,0,0q�6J   $	��Top=�6\   $��33��6t   $��84��6�   $��2��6�   #��� ��6�   $
��Bold"�6�   ��6�   �� *GuardarSQLCommand+56      &   System.Windows.Controls.DataGrid  57      -   5          Name$ DataGrid��57         AutoGenerateColumns .  $��24,30,24,30q�6c      
IsReadOnly . ��6)   �� *Lista+ J� InputBindings 58      d� 59       d� Gesture$ LeftDoubleClicka�6#    �� Command 6=   �� *SeleccionarPersonaCommand+ �� CommandParameter 6k   �� *SelectedItem+ �� RelativeSource ��  �� AncestorType$ DataGridL�5;      5=      5>      5?      