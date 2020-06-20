Public Class SomeClass
    Public Function SayHello(ByVal compname As String, ByVal ip As String)
        Dim item1 As New ListViewItem(compname)
        item1.SubItems.Add(ip)
        ' ChatStart.ListView1.Items.AddRange(New ListViewItem() {item1})
    End Function
    Public Sub InstanceMethod(ByVal compname As String, ByVal ip As String)
        SayHello(compname, ip)
    End Sub

End Class
