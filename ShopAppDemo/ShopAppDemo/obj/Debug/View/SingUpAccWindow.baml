   M S B A M L   `   `   `  ����F  BShopAppDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ShopAppDemo.ViewShopAppDemo.View  5   	   &     ShopAppDemo.View.SingUpAccWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ShopAppDemo.View     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ SingUp��5   	   $	��350��6   $	��300��6%    � 
ResizeMode$ NoResize=�61    � 	Resources 5      ��%    5      .��5      � $��20 20q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $
��  10q�6   $��0��6#   .+�5      �� -   5         ��Name$ tbEmail��5        MaterialDesignFilledTextBox#��[ 5       $	��Top=�5!       �� AcceptsReturn . 	 �� TextWrapping$
	 Wrap=�5#      $	��400��5$      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Email��5%      ��5      �� *Email+{�5&      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox��5'      �� 5(   
   $
��  10q�6   $��1��6#   .+�5)      �� -   5        $ tbPhone��5)      #��[ 5+      $	��Top=�5,       . $
	 Wrap=�5.      $	��400��5/      $
 Phone��50      ��5*      �� *Phone+{�51      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox��52      �� 53   
   $
��  10q�6   $��2��6#   .+�54      �� -   5        $ tbLogin��54      #��[ 56      $	��Top=�57       . $
	 Wrap=�59      $	��400��5:      $
 Login��5;      ��55      �� *Login+{�5<      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox��5=      �� 5?   
   $
��10 5q�6   $��3��6#   .+�5@      G� -   5         G�Name$ 
tbPassword��5@       # MaterialDesignFilledPasswordBox#��[ 5B      $	��Top=�5C      $
 Password��5E      {�5D      �� $ 	IsChecked�$A ;MaterialDesignFilledPasswordFieldPasswordBoxEnabledComboBox��5E      5F      �� 5I   
   $��4��6   $��Submit��6   $��10q�6/    " MaterialDesignRaisedDarkButton#��[ 6<     PrimaryBlackBrush#��[ 5J      ��5K      �� *SubmitButtonCommand+5L      5V      