Imports System
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Layout.Core
Imports System.Windows.Controls

Namespace DXSample
	Partial Public Class MainWindow
		Inherits DXWindow

		Private Const LayoutFileName As String = "layout.xml"
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			manager.SaveLayoutToXml(LayoutFileName)
		End Sub
		Private Sub OnRestoreButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			manager.RestoreLayoutFromXml(LayoutFileName)
		End Sub
		Private Sub OnAddPanelButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			Dim panel = manager.DockController.AddPanel(DockType.Fill)
			panel.Name = "panel4"
			panel.Caption = "Panel4"
			manager.DockController.Dock(panel, root, DockType.Right)
			DirectCast(sender, Button).IsEnabled = False
		End Sub
	End Class
End Namespace