<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T326289)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Save and Restore the DockLayoutManager Layout


<p>DockLayoutManager provides several methods to save and restore layout settings

* <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDockingDockLayoutManager_SaveLayoutToStreamtopic.aspx">SaveLayoutToStream</a>;
* <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDockingDockLayoutManager_SaveLayoutToXmltopic.aspx">SaveLayoutToXml</a>;
* <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDockingDockLayoutManager_RestoreLayoutFromStreamtopic.aspx">RestoreLayoutFromStream</a>;
* <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDockingDockLayoutManager_RestoreLayoutFromXmltopic.aspx">RestoreLayoutFromXml</a>.</p>
<p>Note that item names are used to identify them when saving/restoring a layout, so it will be necessary to set names for all DXDocking items to make sure that settings will be restored properly.<br><br>It may happen that some panels were added/removed after the DockLayoutManager's layout was saved. In this scenario, DockLayoutManager will remove panels that are not present in the saved layout and ignore saved settings for items that do not exist anymore. To change this behavior, set the following options

* To re-create panels that are present in the saved layout, set <strong>RestoreLayoutOptions.RemoveOldPanels</strong> to False.
* Set <strong>RestoreLayoutOptions.AddNewPanels</strong> to True to maintain panels that are not present in the saved layout.<br><br>Please note that the DockLayoutManager's methods save settings only of its groups and panels. To save settings of embedded controls, use <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfCoreWorkspaceManagertopic">WorkspaceManager</a> as shown at <a href="https://www.devexpress.com/Support/Center/p/E2272">How to save and restore settings of all controls that are present in the UI</a>.<br><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/p/E2320">How to serialize a particular panel layout</a><br><a href="https://www.devexpress.com/Support/Center/p/E2324">How to serialize custom panels and their properties</a><br><a href="https://www.devexpress.com/Support/Center/p/E2272">How to save and restore settings of all controls that are present in the UI</a></p>

<br/>


