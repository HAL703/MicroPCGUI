Imports Logix
Imports System.Runtime.InteropServices

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


    '***************************
    ' * STRUCT_B
    '***************************
    Structure STRUCT_B
        '* boolean values are packed into 32-bit ints
        Public boolVals As Int32

        ' **************************
        '* declare unmanaged fixed array
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> _
        Public hourlyCount As Int16()

        Public rate As Single
    End Structure


    ' ****************************
    ' * Logix.Controller class
    Dim myPLC As New Controller()

    ' ****************************
    ' * Logix.Tag classes
    Dim tagStructA As New Tag("struct_a")
    Dim tagStructB As New Tag("struct_b")

    ' *****************************
    ' * Logix.DTEncoding class
    Dim udtEnc As New DTEncoding()

    ' *****************************
    ' * array for bit values
    Dim bits As Array

    ' ***************************
    ' * Connect to PLC
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Try
            myPLC.IPAddress = ipAddress.Text
            myPLC.Path = cipPath.Text
            myPLC.Timeout = 3000

            If myPLC.Connect() <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(myPLC.ErrorString)
                Exit Sub
            End If

            structA_Grp.Enabled = True
            structB_Grp.Enabled = True
            btnDisconnect.Enabled = True
            btnConnect.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ******************************
    ' * Disconnect from PLC
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        myPLC.Disconnect()
        structA_Grp.Enabled = False
        structB_Grp.Enabled = False
        btnDisconnect.Enabled = False
        btnConnect.Enabled = True
    End Sub

    ' *******************************
    ' * read and decode UDT tag "struct_a"
    Private Sub btnStructA_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructA_Read.Click

        Try
            If myPLC.ReadTag(tagStructA) <> Logix.ResultCode.E_SUCCESS Then
                If myPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(tagStructA.ErrorString)
                End If
                Return
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

            structA_limit4.Checked = bits(0)
            structA_limit7.Checked = bits(1)

            structA_travel.Text = StructA.travel.ToString()
            structA_errors.Text = StructA.errors.ToString()
            structA_wear.Text = StructA.wear.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' *******************************
    ' * write UDT STRUCT_A
    Private Sub btnStuctA_Write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStuctA_Write.Click

        Try
            ' * encode structA
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

    ' ***************************
    ' * read UDT tag "struct_b"
    Private Sub btnStructB_Read_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructB_Read.Click

        Try
            If myPLC.ReadTag(tagStructB) <> Logix.ResultCode.E_SUCCESS Then
                If myPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(tagStructB.ErrorString)
                End If
                Return
            Else
                DecodeStructB()
                btnStructB_Write.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' *****************************
    ' * Decodes STRUCT_B
    Private Sub DecodeStructB()

        Dim StructB As STRUCT_B

        Try
            '*
            '* decode tag StructB to STRUCT_B User Data Type
            '*
            StructB = udtEnc.ToType(tagStructB, GetType(STRUCT_B))

            '* 
            '* value for StructB.pilot_on
            '*
            bits = udtEnc.ToBoolArray(StructB.boolVals)
            structB_pilot_on.Checked = bits(0)

            '*
            '* value for StructB.hourlyCount(12)
            '*
            structB_hourlyCount_0.Text = StructB.hourlyCount(0).ToString()
            structB_hourlyCount_1.Text = StructB.hourlyCount(1).ToString()
            structB_hourlyCount_2.Text = StructB.hourlyCount(2).ToString()
            structB_hourlyCount_3.Text = StructB.hourlyCount(3).ToString()
            structB_hourlyCount_4.Text = StructB.hourlyCount(4).ToString()
            structB_hourlyCount_5.Text = StructB.hourlyCount(5).ToString()
            structB_hourlyCount_6.Text = StructB.hourlyCount(6).ToString()
            structB_hourlyCount_7.Text = StructB.hourlyCount(7).ToString()
            structB_hourlyCount_8.Text = StructB.hourlyCount(8).ToString()
            structB_hourlyCount_9.Text = StructB.hourlyCount(9).ToString()
            structB_hourlyCount_10.Text = StructB.hourlyCount(10).ToString()
            structB_hourlyCount_11.Text = StructB.hourlyCount(11).ToString()

            structB_rate.Text = StructB.rate.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' **********************
    ' * executes STRUCT_B Write
    ' *
    Private Sub btnStructB_Write_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStructB_Write.Click

        Try
            EncodeStructB()
            If myPLC.WriteTag(tagStructB) <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(tagStructB.ErrorString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' *******************************
    ' * encodes STRUCT_B data for
    ' * writing
    Private Sub EncodeStructB()

        Dim StructB As STRUCT_B

        Try
            ' * need to allocate buffer
            ReDim StructB.hourlyCount(11)

            '* get bool value
            If structB_pilot_on.Checked Then
                StructB.boolVals = 1
            End If

            '* remaining STRUCT_B members
            StructB.hourlyCount(0) = Convert.ToInt16(structB_hourlyCount_0.Text)
            StructB.hourlyCount(1) = Convert.ToInt16(structB_hourlyCount_1.Text)
            StructB.hourlyCount(2) = Convert.ToInt16(structB_hourlyCount_2.Text)
            StructB.hourlyCount(3) = Convert.ToInt16(structB_hourlyCount_3.Text)
            StructB.hourlyCount(4) = Convert.ToInt16(structB_hourlyCount_4.Text)
            StructB.hourlyCount(5) = Convert.ToInt16(structB_hourlyCount_5.Text)
            StructB.hourlyCount(6) = Convert.ToInt16(structB_hourlyCount_6.Text)
            StructB.hourlyCount(7) = Convert.ToInt16(structB_hourlyCount_7.Text)
            StructB.hourlyCount(8) = Convert.ToInt16(structB_hourlyCount_8.Text)
            StructB.hourlyCount(9) = Convert.ToInt16(structB_hourlyCount_9.Text)
            StructB.hourlyCount(10) = Convert.ToInt16(structB_hourlyCount_10.Text)
            StructB.hourlyCount(11) = Convert.ToInt16(structB_hourlyCount_11.Text)

            StructB.rate = Convert.ToSingle(structB_rate.Text)

            ' *
            ' * encode STRUCT_B for writing
            ' *
            tagStructB.Value = udtEnc.FromType(StructB)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myPLC.Timeout = 3000
    End Sub
End Class
