    ' Class-level declaration.
    ' Create a TraceSwitch.
    Private Shared generalSwitch As New TraceSwitch("General", "Entire Application")
    
    
    Public Shared Sub MyErrorMethod(myObject As Object, category As String)
        ' Write the message if the TraceSwitch level is set to Error or higher.
        Debug.WriteIf(generalSwitch.TraceError, "Invalid object for category. ")
        
        ' Write a second message if the TraceSwitch level is set to Verbose.
        Debug.WriteLineIf(generalSwitch.TraceVerbose, myObject, category)
    End Sub 'MyErrorMethod