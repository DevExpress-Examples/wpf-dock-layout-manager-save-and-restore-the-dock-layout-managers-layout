using System;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Layout.Core;
using System.Windows.Controls;

namespace DXSample {
    public partial class MainWindow : ThemedWindow {
        const string LayoutFileName = "layout.xml";
        public MainWindow() {
            InitializeComponent();
        }
        private void OnSaveButtonClick(object sender, System.Windows.RoutedEventArgs e) {
            manager.SaveLayoutToXml(LayoutFileName);
        }
        private void OnRestoreButtonClick(object sender, System.Windows.RoutedEventArgs e) {
            manager.RestoreLayoutFromXml(LayoutFileName);
        }
        private void OnAddPanelButtonClick(object sender, System.Windows.RoutedEventArgs e) {
            var panel = manager.DockController.AddPanel(DockType.Fill);
            panel.Name = "panel4";
            panel.Caption = "Panel4";
            manager.DockController.Dock(panel, root, DockType.Right);
            ((Button)sender).IsEnabled = false;
        }
    }
}
