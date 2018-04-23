# How to manually set default operation for newly created nodes in the FilterControl


<p>The default operation is provided by the FilterColumnCollection class. This example demonstrates how to inherit this class, and raise an event before returning a value from the GetDefaultOperation method. Within the event handler, a custom operation can be provided.</p>


<h3>Description</h3>

<p>The example was rewritten due to refactoring in the FilterControl.</p>

<br/>


