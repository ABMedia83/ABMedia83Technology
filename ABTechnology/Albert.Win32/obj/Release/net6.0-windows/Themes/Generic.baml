   M S B A M L   `   `   `  ���� G  CAlbert.Win32, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Albert.Win32Albert.Win32  =#clr-namespace:Albert.Win32.ControlsAlbert.Win32.Controls  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089(    "Albert.Win32.ColorToBrushConverter   ColorToBrushConverter  aRadialChrome  � Offset � Color)   #Albert.Win32.Controls.RichTextBlock �� 
TargetType �� Property �� Value �� 
TargetType ��Name   CornerRadius �� CornerRadius	 J� SnapsToDevicePixels
 ��Name#   Albert.Win32.Controls.ZoomBox   Stretch (� Stretch   Zoom&    Albert.Win32.Controls.ChromeBase   CornerRadius&    Albert.Win32.Controls.ViewDialog � RowDefinitions ��Name   TitleAlignment �� TextAlignment   Title   Message �� Orientation&    Albert.Win32.Controls.PushButton  Name   ButtonTextOne � ToolTip   ButtonTextTwo'   !Albert.Win32.Controls.ViewControl   TopDialogVisibility   TopDialogBar   BottomDialogVisibility   BottomDialogBar'   !Albert.Win32.Controls.ViewTabItem  Name   CornerRadius    BackgroundSelected!   BackgroundA"   ForegroundSelected#   ForegroundA$   BorderBrushSelected%   BorderBrushA& �Name' � ColumnDefinitions( ��Name)   BorderBrushMouseOver*   ForegroundMouseOver+   ForegroundPressed,   BackgroundMouseOver-   BackgroundPressed. �� Triggers/ P� Property0 P� Value1 �� 
TargetName2 �� ElementName3 �� Path4 �� EndPoint5 �� 
StartPoint6   CornerRadius7   BackgroundB8   ForegroundB9   BorderBrushPressed:   BorderBrushB; ��Name< �� ContentStringFormat= �� ContentStringFormat>   Source?   Stretch(   "Albert.Win32.Controls.OptionButton@   CornerRadiusA   BackgroundMouseOverB   BackgroundCheckedC   ForegroundCheckedD   ForegroundMouseOverE   BorderBrushCheckedF   BorderBrushMouseOverG   SourceH   Stretch'	   !Albert.Win32.Controls.CheckButtonI 	  CornerRadiusJ 	  BackgroundMouseOverK 	  BackgroundCheckedL 	  ForegroundCheckedM 	  ForegroundMouseOverN 	  BorderBrushCheckedO 	  BorderBrushMouseOverP 	  SourceQ 	  Stretch�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      wclr-namespace:Albert.Win32  /desktop#clr-namespace:Albert.Win32.Controls  %A  &	        &	      '  G     '  �     '  u    '  �    '  `    '  8    '  	    '  
    7  '	  �       
� .��� $  1Q�$ 	#FF333333��� $  0Q�$ 	#FF706F6F���� "  .���  � �� �� "  .R��� $ border��# z #��z��#��z��#��z��$
	 True��._��� $
 PART_ContentHost��$��7q�$|�false��$��Hidden=�$��Hidden=��� "  .���  � �� �� "  .R��� #��z��#��z��#��z��._�(� # z .��� $
��True��.+��� #��z #��z���� "  .���  � �� �� "  .R��� #��z��#��z��#��z��# z ._��� #��z��#��z���� "  .���  � �� �� "  .R��� #��z��#��z��#��z��._��  �� $
��auto ��� �� $
��auto �.+��� $ PART_tbMessage��$��5q�# z $��0���� $
��Bold"�#�z �� �� #�z �� $��1��#��z��#��z���� $
��Left=�$��2��$ 
Horizontal=�.+�  $ PART_btnOne��# z $	��120��$��55��#��z   $ PART_btnTwo��# z $	��120��$��55��#��z �� "  .���  � �� �� "  .R��� #��z��#��z��#��z��._��  �� $
��auto ��� �� $
��auto �.+��� $��0��#y�z #��z��#��z �� $��1��#��z��#��z���� $��2��#y�z #��z��#��z �� "  .���  � ��
 �   ���  � ��$ .5q���  �@ CornerRadius$ 2,2,0,0����  � �� �#222222��  �@ BorderBrushSelected �#ffffff��  �@ ForegroundSelected
 �������  �@ BackgroundSelected �	#FF1D76C5��  � ��
 �������  � ��$ 0q���  � ��$ 6,2,6,2q���  � ��$ Stretch=���  � ��$ Stretch=���  � �� �� "  .R�� .+�  $ chrome��# z #��z��#��z��#! z  ## z" #% z$ $��2,0,0,0q�#��z��.��� $& panel��' �� �� $
��Auto �.+��� $( label��#��z��$��7,0,7,0q�$��Center=�$��Center=�#��z��  $ PART_CloseButton��$��1��$��3q�$	��8pt(�$��30��$��30��
�������
) �   �
* �����
+ �����$��r��$��Webdings)�
���  ��, �	#FFB62929
- �  ��. P� / �@ IsClosedEnabled$
0 True��. ��� $1 PART_CloseButton�� � y�$ Visible=�P� / �@ IsClosedEnabled$0 False��. ��� $1 PART_CloseButton�� � y�$ 	Collapsed=�P� / �@��
IsSelected$
0 True��. ��� $1 chrome�� �� $2 chrome��$3 BackgroundA� � ���� $1 label�� �� $2 chrome��$3 ForegroundA� � ���� $1 chrome�� �� $2 chrome��$3 BorderBrushA� � ���� "  .���  � ��$ Segoe UI Light)���  � ��$
 10pt(���  � �� �	#ff333333��  �@ BackgroundMouseOver �� $4 0.5,1&�$5 0.5,0&�.��� $ 	#FF06A4B4��$  1Q�� $ 	#FF00C5FF��$  0Q���  �@ BackgroundPressed �� $4 0.5,1&�$5 0.5,0&�.��� $ 	#FF0080FF��$  0Q�� $ 	#FF0051A2��$  1Q���  � ��
 �������  �@ ForegroundMouseOver
 �������  �@ ForegroundPressed �#ffffff��  � ��$	 1.2q���  � ��
 �������  �@ BorderBrushMouseOver
 �������  �@ BorderBrushPressed
 �������  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � ��$
 auto����  � ��$ 40����  �@ Stretch$
 Fill=���  �@ CornerRadius$ 2����  � �� �� "  .R�� .+�  $ chorme��#��z��# z6 #7 z, #! z- #��z��#��z��## z+ #8 z* #��z��#% z9 #: z) .��� .+��� $; content��#��z��#= z< #��z��$��Center=�$��Center=�#��z���� $��7q�#��z> #��z? . P� / �@J�IsMouseOver$
0 True��. ��� $1 chorme�� �� $2 chorme��$3 BackgroundB� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushB� � ���� $1 content�� �� $2 chorme��$3 ForegroundB� � ��P� / � ��$
0 True��. ��� $1 chorme�� �� $2 chorme��$3 BackgroundA� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushA� � ���� $1 content�� �� $2 chorme��$3 ForegroundA� � ���� "  .���  � ��$
 14pt(���  � ��8   ��  �@ BackgroundMouseOver �� $4 0.5,1&�$5 0.5,0&�.��� $ 	#FF06A4B4��$  1Q�� $ 	#FF00C5FF��$  0Q���  �@ BackgroundChecked �� $4 0.5,1&�$5 0.5,0&�.��� $ 	#FF0080FF��$  0Q�� $ 	#FF0051A2��$  1Q���  � ��
 �   ���  �@ ForegroundMouseOver �	#FFEAEAEA��  �@ ForegroundChecked �#ffffff��  � ��$	 1.2q���  � ��
 �������  �@ BorderBrushMouseOver �	#FF7E7E7E��  �@ BorderBrushChecked �	#FF0B86AA��  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � ��$
 auto����  � ��$ 80����  �@ CornerRadius$ 2����  � �� �� "  .R�� .+�  $ chorme��#��z��# z@ #7 zA #! zB #��z��#��z��## zC #8 zD #��z��#% zE #: zF .���� $; content��#��z��#= z< #��z��$��Center=�$��Center=�#��z���� $��7q�#��zG #��zH . P� / �@J�IsMouseOver$
0 True��. ��� $1 chorme�� �� $2 chorme��$3 BackgroundB� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushB� � ���� $1 content�� �� $2 chorme��$3 ForegroundB� � ��P� / � ��$
0 True��. ��� $1 chorme�� �� $2 chorme��$3 BackgroundA� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushA� � ���� $1 content�� �� $2 chorme��$3 ForegroundA� � ��P� / �@d�	IsChecked$
0 TrueY�. ��� $1 chorme�� �� $2 chorme��$3 BackgroundA� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushA� � ���� $1 content�� �� $2 chorme��$3 ForegroundA� � ���� " 	 .���  � ��$ Segoe UI Light)���  � ��$
 14pt(���  � �� �� $4 0.5,1&�$5 0.5,0&�.��� $ White��$  0.004Q�� $ 	#FFC7E3EE��$  1Q���  �@	 BackgroundMouseOver �� $4 0.5,1&�$5 0.5,0&�.��� $ 	#FF06A4B4��$  1Q�� $ 	#FF00C5FF��$  0Q���  �@	 BackgroundChecked �� $4 0.5,1&�$5 0.5,0&�.��� $ 	#FF0080FF��$  0Q�� $ 	#FF0051A2��$  1Q���  � ��
 �   ���  �@	 ForegroundMouseOver �	#FFEAEAEA��  �@	 ForegroundChecked �#ffffff��  � ��$	 1.2q���  � ��
 �������  �@	 BorderBrushMouseOver �	#FF7E7E7E��  �@	 BorderBrushChecked �	#FF0B86AA��  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � ��$ Center=���  � ��$
 auto����  � ��$ 55����  �@	 CornerRadius$ 2����  � �� �� " 	 .R�� .+�  $ chorme��#��z��# zI #7 zJ #! zK #��z��#��z��## zL #8 zM #��z��#% zN #: zO .���� $; content��#��z��#= z< #��z��$��Center=�$��Center=�#��z���� $��7q�#��zP #��zQ . P� / �@J�IsMouseOver$
0 True��. ��� $1 chorme�� �� $2 chorme��$3 BackgroundB� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushB� � ���� $1 content�� �� $2 chorme��$3 ForegroundB� � ��P� / � ��$
0 True��. ��� $1 chorme�� �� $2 chorme��$3 BackgroundA� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushA� � ���� $1 content�� �� $2 chorme��$3 ForegroundA� � ��P� / �@d�	IsChecked$
0 TrueY�. ��� $1 chorme�� �� $2 chorme��$3 BackgroundA� � ���� $1 chorme�� �� $2 chorme��$3 BorderBrushA� � ���� $1 content�� �� $2 chorme��$3 ForegroundA� � ��