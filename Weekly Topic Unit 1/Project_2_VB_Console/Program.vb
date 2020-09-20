Imports System

' Written by Mark Reynolds
' notice that VB uses the single-quote for comments
' rather than the block-comment /*-*/ available in C#

Module Program

    Sub Main(args As String())
        ' notice we are using the WriteLine method here
        Console.WriteLine("Hello World!")
        Console.WriteLine("Project #2")
        Console.WriteLine("by Mark Reynolds")
        Console.WriteLine()

        ' notice we are using Write so that the cursor does not advance
        Console.Write("Press any key to continue")

        ' notice we are using ReadKey(), not Read()
        Console.ReadKey()
    End Sub
End Module
