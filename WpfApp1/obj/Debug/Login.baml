   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  Login��5	   	   $	��600��6   $	��900��6$    � WindowStartupLocation$ CenterScreen=�60   .��5
      � ���#b0c4de � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��3��6   $��4��6    $��168,92,149,0q�65    5      �� 5      �� 5      .+�5      � $��0��6   
������� � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 �� CornerRadius��%S  '��       �� 5      " ��6   .�5      ��  � ��$ 30��63   �� 5        � ��$	 100��62   �� 5!       � �� 5"      �� 5#   "   " ��62   .R�5$   &   �� $	 15��5%   )   $��1q�5&   )   #��z��5'   )   ._�5(   *   �� $��Center=�5)   -   $��Center=�5*   -   6J   5+   '   5,   #   5.      5/      50      .+�51      �� $��25(�6   $
��Bold"�6&   $��
100 20 0 0q�68   .��6M   	Sign in6V   �� 52      $	��Top=�53      $��0 60 0 0q�6-   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Username��54       %  !MaterialDesignFloatingHintTextBox#��[  55      $��55��56      $��20(�57      $	��250��58      �� 5:      $��Center=�5;      $
 Password��5<      #��[  5=      $��55��5>      $��20(�5?      $	��250��5@      �� 5B      $��forgot your password��6   $��13(�67   $��Bottom=�6E   $��	0 0 0 100q�6`   $��Center=�6s   �� 5C      -   5        $��Sign in��5C      ���#0000cd
�������$��Bottom=�5F      $��
81,0,97,51q�64   5G      5I      � 5J      $��1��6   ���#ffa07a 5K      ��%^  '��       �� 5L      " ��6   .�5M      ��  � ��$ 30��63   �� 5N       � ��$	 100��62   �� 5O       � �� 5P      �� 5Q   "   " ��62   .R�5R   &   �� $	 15��5S   )   $��1q�5T   )   
�������#��z��5V   )   ._�5W   *   �� $��Center=�5X   -   $��Center=�5Y   -   6J   5Z   '   5[   #   5]      5^      5_      .+�5`      �� $��Hello,Friend!��6   
�������$
��Bold"�6C   $��25(�6U   $
��Left=�6c   $��	72,81,0,0q�6~   $	��Top=�6�   $��45��6�   $	��170��6�   �� 5a      $��13(�6   $��Center=�6*   
�������$��Center=�6X   $��43��6v   $��10,150,10,142q�6�   $	��200��6�   �� 5b      .�6   '%Enter your personal details and start6D   �� 5c      �� 5d      .�6   journey with us6/   5e      �� 5f      -   5        $��Sign up��5f      $��Bottom=�5g      ���#ffa07a
�������$��2q�6]   
�������$��
81,0,97,90q�6�   5h      5j      5k      5l      5m      