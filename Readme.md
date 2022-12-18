<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653177/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1540)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Sort Group Rows by Summary Values

This example shows how to sort group rows by summary values:

![image](https://user-images.githubusercontent.com/65009440/176177295-18f0fb09-0658-4f4b-8f19-96960805c134.png)

1. Create a [GridGroupSummarySortInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridGroupSummarySortInfo) object.
2. Specify its settings (group summary item, grouping column's field name and sort order).
3. Add this object to the [GridControl.GroupSummarySortInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupSummarySortInfo) collection.

Remove the [GridGroupSummarySortInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridGroupSummarySortInfo) object from the [GroupSummarySortInfo](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupSummarySortInfo) collection to clear the summary sorting.

## Files to look at

* [Window1.xaml](./CS/DXSample_SortGroupsBySummary/Window1.xaml) (VB: [Window1.xaml](./VB/DXSample_SortGroupsBySummary/Window1.xaml))
* [Window1.xaml.cs](./CS/DXSample_SortGroupsBySummary/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXSample_SortGroupsBySummary/Window1.xaml.vb))

## Documentation

* [Sort Group Rows by Summary Values](https://docs.devexpress.com/WPF/6144/controls-and-libraries/data-grid/sorting/sorting-group-rows-by-summary-values)
* [Group Row](https://docs.devexpress.com/WPF/6185/controls-and-libraries/data-grid/visual-elements/common-elements/group-row)
* [Group Summary](https://docs.devexpress.com/WPF/6127/controls-and-libraries/data-grid/data-summaries/group-summary)

## More Examples

* [WPF Data Grid - How to Use Custom Rules to Sort Data](https://github.com/DevExpress-Examples/how-to-implement-custom-sorting-e963)
* [WPF Data Grid - How to Display Group Summaries](https://github.com/DevExpress-Examples/how-to-display-group-summaries-e1637)
