   M S B A M L   `   `   `  ����   Menu    Menu.App   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       �� 	Resources     
MenuButton �� 
TargetType �� Property �� Value �� 
TargetType �Name J� RenderTransformOrigin'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� KeyTime �� Value ��Name �� RadiusY �� RadiusX J� Opacity 
� RadiusY 
� RadiusX 
� Center 
� GradientOrigin � Color � Offset �� EndPoint �� 
StartPoint J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius    ShadowDepth!   Opacity" ��Name# J� SnapsToDevicePixels$ J� OpacityMask% �� Triggers& P� Property' P� Value��%�  &	        �� " ��.���  � �� �� " ��.R�� $
 grid��$ 0.5,0.5&�z�V� .~��� �� �� T�    CommonStates��.   
Normal��.	 �� .���� $H
 B(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Color)�$
 Glow��.g�  $ 0��$ 	#00F39B41��U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ contentPresenter��.\�  $ 0��$ -2.333Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ contentPresenter��.\�  $ 0��$
 -0.5Q�U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ contentPresenter��.\�  $ 0��$
 2.46Q�U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ contentPresenter��.\�  $ 0��$ 2.416Q��� $
 (UIElement.ClipToBounds)�$ contentPresenter��.p�s� $ 0�� .    	MouseOver��.	 �� .��U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$
 grid��.\�  $ 0��$ 1.037Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$
 grid��.\�  $ 0��$	 3.5Q�U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$
 grid��.\�  $ 0��$ 1.125Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 grid��.\�  $ 0��$ 3Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$
 Glow��.\�  $ 0��$ -2.893Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 Glow��.\�  $ 0��$ -1.778Q�U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ contentPresenter��.\�  $ 0��$ 2.335Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ contentPresenter��.\�  $ 0��$	 4.5Q�U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ contentPresenter��.\�  $ 0��$ 2.623Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ contentPresenter��.\�  $ 0��$ -1.185Q�  Pressed��.	 �� .��U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�$ contentPresenter��.\�  $ 0��$ 2.228Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ contentPresenter��.\�  $ 0��$ 3.999Q�U� $V
 P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�$ contentPresenter��.\�  $ 0��$ 2.786Q�U� $U
 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ contentPresenter��.\�  $ 0��$ -1Q�  Disabled��.+��� $ BaseRect��
�������$ 72��$ 72��$ 0.145Q��� $
 Glow��$ 72��$ 72��$ 0.5,0.5&�z�V� .~��� �� �� T� ��
� $ 0.419Q�$ 0.336Q�$ 	0.5,0.982&�$ 	0.5,0.982&�.��� $ 	#00F9F8F7��$ 1Q�� $ 	#FFF39B41���� $ 	GlassRect��$ 72��$ 72��$ 0.795Q����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#00000000��$ 1Q�� $ White��� $ 	#CACACACA��$ 0.121Q�� $ 	#35353535��$ 0.284Q�   $ 0Q�$  0Q�$! 0Q��� $" contentPresenter��#��z����. ## z# #��z��$ 0.5,0.5&�$ Z� z�V� .~��� �� �� T� % P� & �@J�	IsFocused' . P� & �@��IsDefaulted' . P� & �@J�IsMouseOver' . P� & � ��' . P� & � {�' .  ��  � ��
 � �����  � ��$ Monotype Corsiva)���  � ��$ 18.667(�