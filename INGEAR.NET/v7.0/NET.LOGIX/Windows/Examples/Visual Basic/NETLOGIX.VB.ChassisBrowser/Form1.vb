Imports Logix
Public Class Form1

    Dim myPLC As New Controller
    Dim myTag As New Tag

    Dim rootNode As New TreeNode("BackPlane")


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        myPLC.IPAddress = ipAddr.Text
        myPLC.Path = path.Text

        If myPLC.Connect() <> ResultCode.E_SUCCESS Then
            MessageBox.Show(String.Format("Connect Error : {0}", myPLC.ErrorString))
            Return
        End If

        ' * step 1
        ' * try go get the number of slots in the back plane.  Some older devices may no support
        myTag.Name = "@backplane"
        If myPLC.ReadTag(myTag) <> ResultCode.E_SUCCESS Then
            bpSlots.Focus()
            MessageBox.Show("Unable to read number of backplane slots, manually enter number of slots")
        Else
            bpSlots.Text = myTag.Value.ToString()
        End If

    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        myPLC.Disconnect()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim slots As Integer = 0
        Dim moduleInfo() As String
        Dim iomodule As TreeNode
        Dim i As Integer

        Try
            rootNode.Nodes.Clear()

            slots = Convert.ToInt32(bpSlots.Text)

            For i = 0 To slots - 1
                myTag.Name = "@slot." + i.ToString()
                If myPLC.ReadTag(myTag) = ResultCode.E_SUCCESS Then
                    moduleInfo = myTag.Value
                    iomodule = New TreeNode(String.Format("{0:d2}, {1}", i, moduleInfo(0)))
                    iomodule.ToolTipText = ToolTipInfo(moduleInfo)
                    rootNode.Nodes.Add(iomodule)
                Else
                    rootNode.Nodes.Add(String.Format("{0:d2} ,<Empty>", i))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ToolTipInfo(info As String()) As String

        Return String.Format("Version: {0}{5}Product Type: {1}{5}Product Code: {2}{5}Serial Number: {3}{5}EDS Filename: {4}{5}", info(1), info(2), info(3), info(4), info(5), Environment.NewLine)

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        treeView1.Nodes.Add(rootNode)
    End Sub
End Class
