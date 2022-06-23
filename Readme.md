<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T326289)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Dock Layout Manager - Save and Restore the DockLayoutManager's Layout

[DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) includes the following methods to save and restore layout settings:

* [SaveLayoutToStream](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.SaveLayoutToStream(System.IO.Stream))
* [SaveLayoutToXml](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.SaveLayoutToXml(System.String))
* [RestoreLayoutFromStream](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.RestoreLayoutFromStream(System.IO.Stream))
* [RestoreLayoutFromXml](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.RestoreLayoutFromXml(System.String))

You should specify the names for all [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) item. [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) uses these names to identify items when you save/restore a layout.

<img src="https://user-images.githubusercontent.com/12169834/175369030-9f965ca6-60fe-4f8a-859c-e32c8bbd888d.png" width=700px/>

Panels may be added/removed after you saved the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager)'s layout. In this case, [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) removes panels that are not exist in the saved layout and ignores saved settings for these items. Set the following options to change this behavior:

* Set [RestoreLayoutOptions.RemoveOldPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.RestoreLayoutOptions.RemoveOldPanels) to `false` to re-create panels that exists in the saved layout.
* Set [RestoreLayoutOptions.AddNewPanels](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.RestoreLayoutOptions.AddNewPanels) to `true` to maintain panels that are not exist in the saved layout.

The [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager)'s methods save settings only of its groups and panels.

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation
- [Save and Restore the Layout of Dock Panels and Controls](https://docs.devexpress.com/WPF/7059/controls-and-libraries/layout-management/dock-windows/miscellaneous/saving-and-restoring-the-layout-of-dock-panels-and-controls)
- [Save/Restore Control Layout Overview](https://docs.devexpress.com/WPF/7391/common-concepts/save-and-restore-layouts)

## More Examples

- [How to save and restore settings of all controls that are present in the UI](https://www.devexpress.com/Support/Center/p/E2272)
- [How to serialize custom panels and their properties](https://github.com/DevExpress-Examples/how-to-serialize-custom-panels-and-their-properties-e2324)
- [How to serialize a particular panel layout](https://www.devexpress.com/Support/Center/p/E2320)
