   M S B A M L   `   `   `  ����J  FLicensingClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LicensingClientLicensingClient  5   	        LicensingClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LicensingClient     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ emailTextBox��5
      $
��Left=�6(   $��23��6C   $��	81,20,0,0q�6O    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��159��6�   �� 5   
   -   5         ��Name$ label��5      $��e-mail��6   $
��Left=�60   $��	15,12,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ label1��5      $��password��6    $
��Left=�63   $��	12,54,0,0q�6N   $	��Top=�6a   �� 5   
   -   5         ��Name$ loginButton��5      $��Log in��6&   $
��Left=�67   $��	79,98,0,0q�6R   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $ LogoutButton��5      $��Log out��6'   $
��Left=�69   $��
166,98,0,0q�6T   $	��Top=�6h   $��74��6�   6�   �� 5   
   -   5        $ label2��5      $��Old password:��6    $
��Left=�68   $��	9,162,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ label3��5      $��New password:��6    $
��Left=�68   $��
10,192,0,0q�6S   $	��Top=�6g   �� 5   
   -	   5        $ label4��5      $��Confirm. password:��6    $
��Left=�6=   $��
10,221,0,0q�6X   $	��Top=�6l   �� 5   
   -
   5        $ button��5      $��Change password��6!   $
��Left=�6;   $��
68,264,0,0q�6V   $	��Top=�6j   $	��120��6�   6�   �� 5   
   -   5        $ label5��5      $��
New email:��6    $
��Left=�65   $��285,162,0,0q�6P   $	��Top=�6e   �� 5   
   -   5        $ label6��5      $��	Password:��6    $
��Left=�64   $��285,192,0,0q�6O   $	��Top=�6d   �� 5   
   -   5        $ label4_Copy��5      $��Confirm. password:��6%   $
��Left=�6B   $��285,221,0,0q�6]   $	��Top=�6r   �� 5   
   -   5        $ newEmailTextBox��5      $
��Left=�6+   $��22��6F   $��407,164,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��100��6�   �� 5   
   -   5        $ button1��5      $��ChangeEmail��6"   $
��Left=�68   $��360,262,0,0q�6S   $	��Top=�6h   $��75��6�   6�   G� 5   
   -   5         G�Name$ passwordTextBox��5      $
��Left=�6/   $��22��6J   $��	82,56,0,0q�6V   $	��Top=�6i   $	��157��6�   G� 5   
   -   5        $ oldPassword��5      $
��Left=�6+   $��22��6F   $��123,164,0,0q�6R   $	��Top=�6g   $	��125��6   G� 5   
   -   5        $ newPassword��5      $
��Left=�6+   $��22��6F   $��123,194,0,0q�6R   $	��Top=�6g   $	��125��6   G� 5   
   -   5        $ newConfirmPassword��5      $
��Left=�62   $��22��6M   $��123,223,0,0q�6Y   $	��Top=�6n   $	��125��6�   G� 5   
   -   5        $ passwordTextBox1��5      $
��Left=�60   $��22��6K   $��407,194,0,0q�6W   $	��Top=�6l   $	��100��6�   G� 5   
   -   5        $ confPasswordTextBox1��5      $
��Left=�64   $��22��6O   $��407,223,0,0q�6[   $	��Top=�6p   $	��100��6�   5      5       