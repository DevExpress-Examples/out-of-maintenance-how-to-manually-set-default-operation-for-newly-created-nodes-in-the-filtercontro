<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621796/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2146)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomClauseNode.cs](./CS/Q253493/FilterControl/CustomClauseNode.cs) (VB: [CustomClauseNode.vb](./VB/Q253493/FilterControl/CustomClauseNode.vb))
* [CustomFilterControl.cs](./CS/Q253493/FilterControl/CustomFilterControl.cs) (VB: [CustomFilterControl.vb](./VB/Q253493/FilterControl/CustomFilterControl.vb))
* [CustomWinFilterTreeNodeModel.cs](./CS/Q253493/FilterControl/CustomWinFilterTreeNodeModel.cs) (VB: [CustomWinFilterTreeNodeModel.vb](./VB/Q253493/FilterControl/CustomWinFilterTreeNodeModel.vb))
* [GetDefaultOperationEventArgs.cs](./CS/Q253493/FilterControl/GetDefaultOperationEventArgs.cs) (VB: [GetDefaultOperationEventArgs.vb](./VB/Q253493/FilterControl/GetDefaultOperationEventArgs.vb))
* [Form1.cs](./CS/Q253493/Form1.cs) (VB: [Form1.vb](./VB/Q253493/Form1.vb))
<!-- default file list end -->
# How to manually set default operation for newly created nodes in the FilterControl


<p>The default operation is provided by the FilterColumnCollection class. This example demonstrates how to inherit this class, and raise an event before returning a value from the GetDefaultOperation method. Within the event handler, a custom operation can be provided.</p>


<h3>Description</h3>

<p>The example was rewritten due to refactoring in the FilterControl.</p>

<br/>


