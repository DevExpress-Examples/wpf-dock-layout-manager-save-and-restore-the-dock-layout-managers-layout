Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Layout.Core
Imports System.Windows.Controls

Namespace DXSample

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Const LayoutFileName As String = "layout.xml"

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Me.manager.SaveLayoutToXml(LayoutFileName)
        End Sub

        Private Sub OnRestoreButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Me.manager.RestoreLayoutFromXml(LayoutFileName)
        End Sub

        Private Sub OnAddPanelButtonClick(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim panel = Me.manager.DockController.AddPanel(DockType.Fill)
            panel.Name = "panel4"
            panel.Caption = "Panel4"
            Me.manager.DockController.Dock(panel, Me.root, DockType.Right)
            CType(sender, Button).IsEnabled = False
        End Sub
    End Class
End Namespace
