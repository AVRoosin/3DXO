   M S B A M L   `   `   `  ����  Menu    Menu.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        �� 	Resources  5         
MenuButton �� 
TargetType �� Property �� Value �� 
TargetType �Name J� RenderTransformOrigin'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� KeyTime �� Value ��Name �� RadiusY �� RadiusX J� Opacity 
� RadiusY 
� RadiusX 
� Center 
� GradientOrigin � Color � Offset �� EndPoint �� 
StartPoint J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius    ShadowDepth!   Opacity" ��Name# J� SnapsToDevicePixels$ J� OpacityMask% �� Triggers& P� Property' P� Value��%  &	        �� 5   
   " ��6#   .�5      ��  � �� 5      �� 5	      " ��6&   .R�5
      � $
 grid��6   $ 0.5,0.5&�6-   z�5      V� 5   "   .~�5   &   �� �� 5   &   �� 5   &   T� 5   &   5   #    5        5   "   CommonStates��. 5   &     
Normal��.	 5   *   �� .��5   .   �� $H
 B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�6K   $
 Glow��6�   .g�5   2     $ 0��6F   $ 	#00F39B41��6R   5   /   U� 5   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6L   $ contentPresenter��6�   .\�5   2     $ 0��6G   $ -2.333Q�6S   5   /   U� 5   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6L   $ contentPresenter��6�   .\�5   2     $ 0��6G   $
 -0.5Q�6S   5   /   U� 5    .   $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $ contentPresenter��6�   .\�5!   2     $ 0��6G   $
 2.46Q�6S   5"   /   U� 5#   .   $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6L   $ contentPresenter��6�   .\�5$   2     $ 0��6G   $ 2.416Q�6S   5%   /   �� 5&   .   $
 (UIElement.ClipToBounds)�6M   $ contentPresenter��6�   .p�5'   2   s� $ 0��6J    .  6V   5(   /   5)   +   5*   '     5+   &   	MouseOver��.	 5,   *   �� .��5-   .   U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $
 grid��6�   .\�5.   2     $ 0��6G   $ 1.037Q�6S   5/   /   U� 50   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6L   $
 grid��6�   .\�51   2     $ 0��6G   $	 3.5Q�6S   52   /   U� 53   .   $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6L   $
 grid��6�   .\�54   2     $ 0��6G   $ 1.125Q�6S   55   /   U� 56   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6L   $
 grid��6�   .\�57   2     $ 0��6G   $ 3Q�6S   58   /   U� 59   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6L   $
 Glow��6�   .\�5:   2     $ 0��6G   $ -2.893Q�6S   5;   /   U� 5<   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6L   $
 Glow��6�   .\�5=   2     $ 0��6G   $ -1.778Q�6S   5>   /   U� 5?   .   $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $ contentPresenter��6�   .\�5@   2     $ 0��6G   $ 2.335Q�6S   5A   /   U� 5B   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6L   $ contentPresenter��6�   .\�5C   2     $ 0��6G   $	 4.5Q�6S   5D   /   U� 5E   .   $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6L   $ contentPresenter��6�   .\�5F   2     $ 0��6G   $ 2.623Q�6S   5G   /   U� 5H   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6L   $ contentPresenter��6�   .\�5I   2     $ 0��6G   $ -1.185Q�6S   5J   /   5K   +   5L   '     5M   &   Pressed��.	 5N   *   �� .��5O   .   U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $ contentPresenter��6�   .\�5P   2     $ 0��6G   $ 2.228Q�6S   5Q   /   U� 5R   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6L   $ contentPresenter��6�   .\�5S   2     $ 0��6G   $ 3.999Q�6S   5T   /   U� 5U   .   $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6L   $ contentPresenter��6�   .\�5V   2     $ 0��6G   $ 2.786Q�6S   5W   /   U� 5X   .   $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6L   $ contentPresenter��6�   .\�5Y   2     $ 0��6G   $ -1Q�6S   5Z   /   5[   +   5\   '     5]   &   Disabled��62   5^   #   .+�5`      �� $ BaseRect��6(   
�������$ 72��6G   $ 72��6T   $ 0.145Q�6a   �� 5a      $
 Glow��6(   $ 72��66   $ 72��6C   $ 0.5,0.5&�6P   z�5b   "   V� 5c   &   .~�5d   *   �� �� 5e   *   �� 5f   *   T� 5g   *   5h   '   ��5j   "   
� 5k   &   $ 0.419Q�6:   $ 0.336Q�6J   $ 	0.5,0.982&�6Z   $ 	0.5,0.982&�6m   .��5l   *   � $ 	#00F9F8F7��67   $ 1Q�6I   � 5m   *   $ 	#FFF39B41��67   5n   '   5p      �� 5q      $ 	GlassRect��6(   $ 72��6;   $ 72��6H   $ 0.795Q�6U   ��5r   "   �� 5s   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5t   *   � $ 	#00000000��67   $ 1Q�6I   � 5u   *   $ White��67   � 5v   *   $ 	#CACACACA��67   $ 0.121Q�6I   � 5w   *   $ 	#35353535��67   $ 0.284Q�6I   5x   '    5z   "     5{   &   $ 0Q�67   $  0Q�6F   $! 0Q�6V   5}      �� 5~      $" contentPresenter��6/   #��z��6I   ��. ## z# 6�   #��z��6�   $ 0.5,0.5&�6"  $ 6B  Z� z�5   "   V� 5�   &   .~�5�   *   �� �� 5�   *   �� 5�   *   T� 5�   *   5�   '   5�      5�      % 5�      P� 5�      & �@J�	IsFocused' . 6;   P� 5�      & �@��IsDefaulted' . 6=   P� 5�      & �@J�IsMouseOver' . 6=   P� 5�      & � ��' . 6;   P� 5�      & � {�' .  6;   5�      5�      �� 5�       � ��
 � ���6+   �� 5�       � ��$ Monotype Corsiva)�6+   �� 5�       � ��$ 18.667(�6)   5�      5�      5�      