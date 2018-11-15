<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q253493/Form1.cs) (VB: [Form1.vb](./VB/Q253493/Form1.vb))
<!-- default file list end -->
# How to manually set default operation for newly created nodes in the FilterControl


<p>The default operation is provided by the FilterColumnCollection class. This example demonstrates how to inherit this class, and raise an event before returning a value from the GetDefaultOperation method. Within the event handler, a custom operation can be provided.</p>

<br/>


