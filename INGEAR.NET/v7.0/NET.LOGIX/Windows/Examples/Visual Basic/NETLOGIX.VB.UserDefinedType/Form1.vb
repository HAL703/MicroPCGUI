Imports Logix
Imports System.Runtime.InteropServices
Imports System.Environment

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

    ' * STRUCT_A variable
    Dim StructA As STRUCT_A

    '***************************
    ' * STRUCT_B
    '***************************
    Structure STRUCT_B
        '* boolean values are packed into 32-bit ints
        Public boolVals As Int32

        ' **************************
        '* declare unmanged fixed array
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> _
        Public hourlyCount As Int16()

        Public rate As Single
    End Structure

    ' * STRUCT_B variable
    Dim StructB As STRUCT_B

    '***************************
    ' * STRUCT_C
    '***************************
    Public Structure STRUCT_C
        Public boolVals As Int32
        Public today As STRUCT_B
        Public sampleTime As Integer
        Public shipped As Integer
    End Structure

    ' STRUCT_C variable
    Dim StructC As STRUCT_C

    ' ***************************
    ' * STRUCT_D
    ' **************************
    Public Structure STRUCT_D
        Public myint As Int16
        Public myfloat As Single
        Public c0 As STRUCT_C
        Public c1 As STRUCT_C
        Public c2 As STRUCT_C
        Public c3 As STRUCT_C
        Public c4 As STRUCT_C
        Public c5 As STRUCT_C
        Public c6 As STRUCT_C
        Public c7 As STRUCT_C
        Public mypid As Single
    End Structure

    ' * STRUCT_D variable
    Dim StructD As STRUCT_D

    ' ****************************
    ' * instance of the NET.LOGIX Controller class
    ' * class
    Dim myPLC As New Controller

    ' *****************************
    ' * instance of the NET.Logix Tag class
    Dim myUDT As New Tag

    ' *****************************
    ' * instance of the NET.LOGIX Data Type encoding class
    Dim udtEnc As New DTEncoding

    ' ****************************
    ' * variable to hold bit values
    Dim bit As Array

    ' ****************************
    ' * variables for Encoded Data Types
    Dim Encoded_TypeCode As Array
    Dim UDT_TypeCode As UInt16

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Try
            ' **************************
            ' * connect to the PLC
            ' **************************
            myPLC.IPAddress = _ipAddress.Text
            myPLC.Path = _cipPath.Text

            If myPLC.Connect() <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(myPLC.ErrorString)
                Exit Sub
            End If

            structTypes.Enabled = True
            _btnDisconnect.Enabled = True
            _btnConnect.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' * default tag name & data type
        myUDT.Name = "struct_a"
        myUDT.DataType = Logix.Tag.ATOMIC.OBJECT

        ' * load instructions in text box
        LoadHelp()

        myPLC.Timeout = 3000

    End Sub

 
    Private Sub btnSTRUCT_A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTRUCT_A.CheckedChanged
        myUDT.Name = "struct_a"
    End Sub

    Private Sub btnSTRUCT_B_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTRUCT_B.CheckedChanged
        myUDT.Name = "struct_b"
    End Sub

    Private Sub btnSTRUCT_C_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTRUCT_C.CheckedChanged
        myUDT.Name = "struct_c"
    End Sub

    Private Sub btnSTRUCT_D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSTRUCT_D.CheckedChanged
        myUDT.Name = "struct_d"
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click

        Try
            ' *********************
            ' * read UDT from PLC
            ' *********************
            If myPLC.ReadTag(myUDT) <> Logix.ResultCode.E_SUCCESS Then
                If myPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(myPLC.ErrorString, Me.Text)
                End If
                Exit Sub
            End If

            ' ************************
            ' * display UDT
            ' ************************
            If btnSTRUCT_A.Checked Then
                DisplayStructA()
            ElseIf btnSTRUCT_B.Checked Then
                DisplayStructB()
            ElseIf btnSTRUCT_C.Checked Then
                DisplayStructC()
            ElseIf btnSTRUCT_D.Checked Then
                DisplayStructD()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisplayStructA()

        Try

            ' *******************************************************
            ' * use NET.LOGIX.DTEncoding to convert the Tag to
            ' * STRUCT_A type
            StructA = udtEnc.ToType(myUDT, GetType(STRUCT_A))

            ' * bits are packed into 32-bit values, use the .ToBoolArray to get
            ' * the individual bit elements
            bit = udtEnc.ToBoolArray(StructA.boolVals)

            treeView1.BeginUpdate()
            treeView1.Nodes.Clear()

            ' * add a root node the tree view
            treeView1.Nodes.Add("STRUCT_A")

            ' * add the branch and value for StructA.limit4
            treeView1.Nodes(0).Nodes.Add("limit4 = " + bit(0).ToString())

            ' * add the branch and value for StructA.limit4
            treeView1.Nodes(0).Nodes.Add("limit7 = " + bit(1).ToString())

            ' * add the branch and value for StructA.travel
            treeView1.Nodes(0).Nodes.Add("travel = " + StructA.travel.ToString())

            ' * add the branch and value for StructA.errors
            treeView1.Nodes(0).Nodes.Add("errors = " + StructA.errors.ToString())

            ' * add the branch and value for StructA.wears
            treeView1.Nodes(0).Nodes.Add("wear = " + StructA.wear.ToString())

            treeView1.EndUpdate()

            ' *******************************************************
            ' * get the "Abbreviated Type Code" for the StructA UDT
            ' *
            Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT)
            UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0)
            lblTypeCode.Text = "STRUCT_A Type Code = " + UDT_TypeCode.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DisplayStructB()

        Try

            ' *******************************************************
            ' * use NET.LOGIX.DTEncoding to convert the Tag to
            ' * STRUCT_B type
            StructB = udtEnc.ToType(myUDT, GetType(STRUCT_B))

            treeView1.BeginUpdate()
            treeView1.Nodes.Clear()

            ' * add root node
            treeView1.Nodes.Add("STRUCT_B")

            ' * add the branch and value for StructB.limit4
            ' * convert the StructB.boolVals a bool()
            bit = udtEnc.ToBoolArray(StructB.boolVals)
            treeView1.Nodes(0).Nodes.Add("pilot_on = " + bit(0).ToString())

            ' * add the branchs and values for StructB.hourlyCount
            treeView1.Nodes(0).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(0) = " + StructB.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(1) = " + StructB.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(2) = " + StructB.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(3) = " + StructB.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(4) = " + StructB.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(5) = " + StructB.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(6) = " + StructB.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(7) = " + StructB.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(8) = " + StructB.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(9) = " + StructB.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(10) = " + StructB.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes.Add("(11) = " + StructB.hourlyCount(11).ToString())

            ' * add the branch and value for StructB.rate
            treeView1.Nodes(0).Nodes.Add("rate = " + StructB.rate.ToString())
            treeView1.EndUpdate()

            ' *
            ' * get the "Abbreviated Type Code" for the StructB UDT
            ' *
            Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT)
            UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0)

            lblTypeCode.Text = "StructB Type Code = " + UDT_TypeCode.ToString()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DisplayStructC()

        Try

            ' *******************************************************
            ' * NET.LOGIX.DTEncoding to convert the Tag to
            ' * STRUCT_C type
            StructC = udtEnc.ToType(myUDT, GetType(STRUCT_C))

            treeView1.BeginUpdate()
            treeView1.Nodes.Clear()

            ' * add StructC root node
            treeView1.Nodes.Add("STRUCT_C")

            ' * add branch and value for StructC.hour_full
            bit = udtEnc.ToBoolArray(StructC.boolVals)
            treeView1.Nodes(0).Nodes.Add("hour_full = " + bit(0).ToString())

            ' * add branch for STRUCT_B
            treeView1.Nodes(0).Nodes.Add("today")

            ' * add branch and value for StructC.today.pilot_on
            bit = udtEnc.ToBoolArray(StructC.today.boolVals)
            treeView1.Nodes(0).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())

            ' * add branch and values for StructC.today.hourlyCount()
            treeView1.Nodes(0).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructC.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructC.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructC.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructC.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructC.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructC.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructC.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructC.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructC.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructC.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructC.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructC.today.hourlyCount(11).ToString())

            ' * add branch and value for StructC.today.rate
            treeView1.Nodes(0).Nodes(1).Nodes.Add("rate =  " + StructC.today.rate.ToString())

            ' * add branch and value for StructC.sampleTime
            treeView1.Nodes(0).Nodes.Add("sampleTime = " + StructC.sampleTime.ToString())

            ' * add branch and value for StructC.shipped
            treeView1.Nodes(0).Nodes.Add("shipped = " + StructC.shipped.ToString())
            treeView1.EndUpdate()

            ' *******************************************************
            ' * get the "Abbreviated Type Code" for the STRUCT_B UDT
            ' *
            Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT)
            UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0)
            lblTypeCode.Text = "StructC Type Code = " + UDT_TypeCode.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DisplayStructD()

        Try

 
            ' *******************************************************
            ' * NET.LOGIX.DTEncoding to convert the Tag to
            ' * STRUCT_D type
            StructD = udtEnc.ToType(myUDT, GetType(STRUCT_D))

            treeView1.BeginUpdate()
            treeView1.Nodes.Clear()

            ' * add root for StructD
            treeView1.Nodes.Add("STRUCT_D")

            ' * add the branch and value for StructD.myint
            treeView1.Nodes(0).Nodes.Add("myint = " + StructD.myint.ToString())

            ' * add the branch and value for StructD.myfloat
            treeView1.Nodes(0).Nodes.Add("myfloat = " + StructD.myfloat.ToString())

            ' **********************************************
            ' * add the branch and value for StructD.myarray(0) (aka StructD.c0)
            ' **********************************************
            treeView1.Nodes(0).Nodes.Add("myarray(0)")
            bit = udtEnc.ToBoolArray(StructD.c0.boolVals)

            treeView1.Nodes(0).Nodes(2).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes.Add("today")

            bit = udtEnc.ToBoolArray(StructD.c0.today.boolVals)

            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c0.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c0.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c0.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c0.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c0.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c0.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c0.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c0.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c0.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c0.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c0.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c0.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(2).Nodes(1).Nodes.Add("rate = " + StructD.c0.today.rate.ToString())
            treeView1.Nodes(0).Nodes(2).Nodes.Add("sampleTime = " + StructD.c0.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(2).Nodes.Add("shipped = " + StructD.c0.shipped.ToString())

            ' **********************************************
            ' * add the branch and value for StructD.myarray(1) (aka StructD.c1)
            ' ************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(1)")

            bit = udtEnc.ToBoolArray(StructD.c1.boolVals)

            treeView1.Nodes(0).Nodes(3).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c1.today.boolVals)

            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c1.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c1.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c1.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c1.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c1.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c1.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c1.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c1.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c1.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c1.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c1.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c1.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(3).Nodes(1).Nodes.Add("rate = " + StructD.c1.today.rate.ToString())
            treeView1.Nodes(0).Nodes(3).Nodes.Add("sampleTime = " + StructD.c1.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(3).Nodes.Add("shipped = " + StructD.c1.shipped.ToString())

            ' *******************************************************
            ' * add the branch and value for StructD.myarray(2) (aka StructD.c2)
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(2)")

            bit = udtEnc.ToBoolArray(StructD.c2.boolVals)

            treeView1.Nodes(0).Nodes(4).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c2.today.boolVals)

            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c2.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c2.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c2.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c2.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c2.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c2.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c2.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c2.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c2.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c2.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c2.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c2.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(4).Nodes(1).Nodes.Add("rate = " + StructD.c2.today.rate.ToString())
            treeView1.Nodes(0).Nodes(4).Nodes.Add("sampleTime = " + StructD.c2.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(4).Nodes.Add("shipped = " + StructD.c2.shipped.ToString())


            ' *******************************************************
            ' * add the branch and value for StructD.myarray(3) (aka StructD.c3)
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(3)")

            bit = udtEnc.ToBoolArray(StructD.c3.boolVals)

            treeView1.Nodes(0).Nodes(5).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c3.today.boolVals)

            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c3.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c3.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c3.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c3.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c3.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c3.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c3.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c3.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c3.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c3.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c3.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c3.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(5).Nodes(1).Nodes.Add("rate = " + StructD.c3.today.rate.ToString())
            treeView1.Nodes(0).Nodes(5).Nodes.Add("sampleTime = " + StructD.c3.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(5).Nodes.Add("shipped = " + StructD.c3.shipped.ToString())

            ' *******************************************************
            ' * add the branch and value for StructD.myarray(4) (aka StructD.c4)
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(4)")

            bit = udtEnc.ToBoolArray(StructD.c4.boolVals)

            treeView1.Nodes(0).Nodes(6).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c4.today.boolVals)

            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c4.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c4.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c4.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c4.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c4.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c4.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c4.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c4.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c4.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c4.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c4.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c4.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(6).Nodes(1).Nodes.Add("rate = " + StructD.c4.today.rate.ToString())
            treeView1.Nodes(0).Nodes(6).Nodes.Add("sampleTime = " + StructD.c4.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(6).Nodes.Add("shipped = " + StructD.c4.shipped.ToString())


            ' *******************************************************
            ' * add the branch and value for StructD.myarray(5) (aka StructD.c5)
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(5)")

            bit = udtEnc.ToBoolArray(StructD.c5.boolVals)

            treeView1.Nodes(0).Nodes(7).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c5.today.boolVals)

            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c5.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c5.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c5.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c5.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c5.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c5.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c5.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c5.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c5.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c5.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c5.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c5.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(7).Nodes(1).Nodes.Add("rate = " + StructD.c5.today.rate.ToString())
            treeView1.Nodes(0).Nodes(7).Nodes.Add("sampleTime = " + StructD.c5.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(7).Nodes.Add("shipped = " + StructD.c5.shipped.ToString())

            ' *******************************************************
            ' * add the branch and value for StructD.myarray(6) (aka StructD.c6)
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(6)")
            bit = udtEnc.ToBoolArray(StructD.c6.boolVals)

            treeView1.Nodes(0).Nodes(8).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c6.today.boolVals)

            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c6.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c6.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c6.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c6.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c6.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c6.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c6.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c6.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c6.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c6.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c6.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c6.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(8).Nodes(1).Nodes.Add("rate = " + StructD.c6.today.rate.ToString())
            treeView1.Nodes(0).Nodes(8).Nodes.Add("sampleTime = " + StructD.c6.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(8).Nodes.Add("shipped = " + StructD.c6.shipped.ToString())

            ' *******************************************************
            ' * add the branch and value for StructD.myarray(7) (aka StructD.c7)
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("myarray(7)")

            bit = udtEnc.ToBoolArray(StructD.c7.boolVals)

            treeView1.Nodes(0).Nodes(9).Nodes.Add("hour_full = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes.Add("today")
            bit = udtEnc.ToBoolArray(StructD.c7.today.boolVals)

            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes.Add("pilot_on = " + bit(0).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes.Add("hourlyCount")
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(0) = " + StructD.c7.today.hourlyCount(0).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(1) = " + StructD.c7.today.hourlyCount(1).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(2) = " + StructD.c7.today.hourlyCount(2).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(3) = " + StructD.c7.today.hourlyCount(3).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(4) = " + StructD.c7.today.hourlyCount(4).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(5) = " + StructD.c7.today.hourlyCount(5).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(6) = " + StructD.c7.today.hourlyCount(6).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(7) = " + StructD.c7.today.hourlyCount(7).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(8) = " + StructD.c7.today.hourlyCount(8).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(9) = " + StructD.c7.today.hourlyCount(9).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(10) = " + StructD.c7.today.hourlyCount(10).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes(1).Nodes.Add("(11) = " + StructD.c7.today.hourlyCount(11).ToString())
            treeView1.Nodes(0).Nodes(9).Nodes(1).Nodes.Add("rate = " + StructD.c7.today.rate.ToString())
            treeView1.Nodes(0).Nodes(9).Nodes.Add("sampleTime = " + StructD.c7.sampleTime.ToString())
            treeView1.Nodes(0).Nodes(9).Nodes.Add("shipped = " + StructD.c7.shipped.ToString())


            ' *******************************************************
            ' * add the branch and value for StructD.mypid
            ' *******************************************************
            treeView1.Nodes(0).Nodes.Add("mypid = " + StructD.mypid.ToString())
            treeView1.EndUpdate()

            ' *******************************************************
            ' * get the "Abbreviated Type Code" for the StructD UDT
            ' *
            Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT)
            UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0)
            lblTypeCode.Text = "StructD Type Code = " + UDT_TypeCode.ToString()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        myPLC.Disconnect()
        _btnDisconnect.Enabled = False
        structTypes.Enabled = False
        _btnConnect.Enabled = True

    End Sub

    Private Sub LoadHelp()

        txtHelp.Text = "NOTES:" + NewLine _
        + "This example requires the following User Data Types (UDT's) to be defined in the PLC" + NewLine + NewLine _
        + "Create a tag called 'struct_a' from this UDT" + NewLine _
        + "STRUCT_A" + NewLine _
        + "  limit4       (BOOL)" + NewLine _
        + "  limit7       (BOOL)" + NewLine _
        + "  travel       (DINT)" + NewLine _
        + "  errors       (DINT)" + NewLine _
        + "  wear         (REAL)" + NewLine _
        + "END STRUCT_A" + NewLine + NewLine _
        + "Create a tag called 'struct_b' from this UDT" + NewLine _
        + "STRUCT_B" + NewLine _
        + "  pilot_on     (BOOL)" + NewLine _
        + "  hourlyCount[](INT[12])" + NewLine _
        + "  rate         (REAL)" + NewLine _
        + "END STRUCT_B" + NewLine + NewLine _
        + "Create a tag called 'struct_c' from this UDT" + NewLine _
        + "STRUCT_C" + NewLine _
        + "  hour_full    (BOOL)" + NewLine _
        + "  today        (STRUCT_B)" + NewLine _
        + "  sampleTime   (DINT)" + NewLine _
        + "  shipped      (DINT)" + NewLine _
        + "END STRUCT_C" + NewLine + NewLine _
        + "Create a tag called 'struct_d' from this UDT" + NewLine _
        + "STRUCT_D" + NewLine _
        + "  myint        (INT)" + NewLine _
        + "  myfloat      (REAL)" + NewLine _
        + "  myarray[]    (STRUCT_C[8])" + NewLine _
        + "  mypid        (REAL)" + NewLine _
        + "END STRUCT_D" + NewLine

    End Sub
End Class
