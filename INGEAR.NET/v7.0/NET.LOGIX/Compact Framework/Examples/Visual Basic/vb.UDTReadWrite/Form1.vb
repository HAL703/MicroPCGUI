Imports Logix

Public Class Form1

    '***************************
    ' * STRUCT_A
    '***************************
    Public Structure STRUCT_A
        '* boolean values are packed into 32-bit ints
        Public boolVals As Integer
        Public travel As Integer
        Public errors As Integer
        Public wear As Single
    End Structure
    ' ****************************
    ' * Logix.Controller class
    Dim myPLC As New Controller()

    ' ****************************
    ' * Logix.Tag classes
    Dim tagStructA As New Tag("struct_a")

    ' *****************************
    ' * Logix.DTEncoding class
    Dim udtEnc As New DTEncoding()

    ' *****************************
    ' * array for bit values
    Dim bits As Array

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPLC.Timeout = 3000
        tagStructA.DataType = Logix.Tag.ATOMIC.OBJECT
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Try
            myPLC.IPAddress = ipAddress.Text
            myPLC.Path = cipPath.Text
            myPLC.Timeout = 3000

            If myPLC.Connect() <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(myPLC.ErrorString)
                Exit Sub
            End If

            Disconnect.Enabled = True
            btnConnect.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disconnect.Click
        myPLC.Disconnect()
        Disconnect.Enabled = False
        btnConnect.Enabled = True

    End Sub

    Private Sub btnStructA_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructA_Read.Click
        Try
            If myPLC.ReadTag(tagStructA) <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(tagStructA.ErrorString)
            Else
                DecodeStructA()
                btnStuctA_Write.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    ' ****************************
    ' * Decodes UDT STRUCT_A
    Private Sub DecodeStructA()

        Dim StructA As STRUCT_A

        Try
            ' * decode to STRUCT_A UDT
            StructA = udtEnc.ToType(tagStructA, GetType(STRUCT_A))
            bits = udtEnc.ToBoolArray(StructA.boolVals)

            structA_limit4.Checked = bits.GetValue(0)
            structA_limit7.Checked = bits.GetValue(1)

            structA_travel.Text = StructA.travel.ToString()
            structA_errors.Text = StructA.errors.ToString()
            structA_wear.Text = StructA.wear.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnStuctA_Write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStuctA_Write.Click
        Try
            ' *************************
            ' * encode the structure
            ' * to a Tag
            EncodeStructA()
            If myPLC.WriteTag(tagStructA) <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(tagStructA.ErrorString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' *********************************
    ' * Encodes STRUCT_A for writing
    ' *
    Private Sub EncodeStructA()

        Dim StructA As STRUCT_A
        Dim limits(1) As Boolean

        ' * populate STRUCT_A members
        Try
            ' * get the bit values from check box
            limits(0) = structA_limit4.Checked
            limits(1) = structA_limit7.Checked

            '* convert bool{} to Int32
            StructA.boolVals = udtEnc.FromBoolArray(limits)

            '* get values for remaining members
            StructA.errors = Convert.ToInt32(structA_errors.Text)
            StructA.travel = Convert.ToInt32(structA_travel.Text)
            StructA.wear = Convert.ToSingle(structA_wear.Text)

            ' *
            ' * encode STRUCT_A for writing
            ' * 
            tagStructA.Value = udtEnc.FromType(StructA)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
