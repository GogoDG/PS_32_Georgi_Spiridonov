   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   #    StudentInfoSystem.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ lblUsername��5
   -   $��0��6   $��0��6    $��	Username:��6B   $
��Left=�6V   $��28��6q   $��
190,54,0,0q�6}   $	��Top=�6�   $��73��6�    K� ZIndex$ 1��6�   �� 5   
   -   5        $ lblPassword��5       $��0��6   $��	Password:��65   $
��Left=�6I   $��28��6d   $��
190,95,0,0q�6p   $	��Top=�6�   $��86��6�   $ 1��6�   �� 5   
   -   5         ��Name$ textUsername��5      $
��Left=�6(   $��27��6C   $��
312,58,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��254��6�   $ 1��6�   ��6�   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   -   5        $ textPassword��5      $��27��6(   $��
312,96,0,0q�64   $
 Wrap=�6H   $	��Top=�6\   $ 1��6t   $
��Left=�6�   $	��254��6�   ��6�   �� *
Password+$ PropertyChanged=��� 5   
   -   5         ��Name$ btnLogin��5      $��Login��6#   $
��Left=�63   $��36��6N   $��363,139,0,0q�6Z   $	��Top=�6o   $	��152��6�   $ 1��6�   ��6�   �� *LoginStudentCommand+��6�   �� *.+�� 5   
   -   5        $ lblTitle��5      $��0��6   $ ��Student Info System Log In��6/   $��Right=�6T   $��33��6p   $��
0,10,234,0q�6|   $	��Top=�6�   $	��254��6�   $ 1��6�   $
��Bold"�6�   $��16(�6�   5      5      