Imports Logix
Module Module1

    Sub Main()
        ' ************************
        ' * dimension some variables

        Dim IPAddress As String
        Dim cpuType As Integer
        Dim Path As String
        Dim Tagname As String

        ' *************************
        ' declare NETGEAR.Logix classes
        Dim MyPLC As Controller
        Dim MyTag As Tag

        System.Console.WriteLine("INGEAR NET.LOGIX 7 VB Console Example")
        System.Console.Write("CPU Type: 0 = ControlLogix(default)  1 = Micro ")
        If System.Console.ReadLine() = "1" Then
            cpuType = 1
        Else
            cpuType = 0
        End If

        ' *****************************
        ' * step 1 enter an IP Address
LBL_STEP_1:
        System.Console.Write("Enter IP Address: ")
            IPAddress = System.Console.ReadLine()
            If (IPAddress.Length = 0) Then
                GoTo LBL_STEP_1
            End If

            System.Console.WriteLine()
            ' *****************************
            ' * step 2 enter a CPU Slot or CIP Path
LBL_STEP_2:
        System.Console.Write("Enter CPU Slot or CIP Path.  If this is a 5069 CompactLogix 5380 or 5480, leave CIP Path empty")
            Path = System.Console.ReadLine()

            System.Console.WriteLine()

            ' ******************************
            ' * step 3 enter a ControlLogix Tagname
LBL_STEP_3:
            System.Console.Write("Enter a ControlLogix Tagname: ")
            Tagname = System.Console.ReadLine()
            If (Tagname.Length = 0) Then
                GoTo LBL_STEP_3
            End If

            ' *****************************
            ' * if no Path was entered then
            ' * use the default CPU Slot = 0
            ' *
            If (Path.Length = 0) Then
                Path = "0"
            End If

        ' ***************************
        ' * create Controller class

        MyPLC = New Controller()
        MyPLC.Timeout = 3000
        If cpuType = 1 Then
            MyPLC.CPUType = Controller.CPU.MICRO
        End If
        MyPLC.IPAddress = IPAddress
        MyPLC.Path = Path

            ' *******************************
            ' * check for errors
            ' *
        If (MyPLC.Connect() <> Logix.ResultCode.E_SUCCESS) Then
            System.Console.WriteLine()
            System.Console.Write("Controller Error = ")
            System.Console.WriteLine(MyPLC.ErrorString)
            System.Console.Write("Press Any Key...")
            System.Console.ReadKey()
            Exit Sub
        End If

            ' ********************************
        ' * create tag then read value
            ' *
        MyTag = New Tag(Tagname)

        If MyPLC.ReadTag(MyTag) = ResultCode.E_SUCCESS Then
            System.Console.WriteLine()
            System.Console.Write("Tag Value = ")
            System.Console.WriteLine(MyTag.Value)

            System.Console.WriteLine()
            System.Console.Write("Tag TimeStamp = ")
            System.Console.WriteLine(MyTag.TimeStamp.ToString())

            ' *********************************
            ' * otherwise display error
        Else

            System.Console.WriteLine()
            System.Console.Write("Tag Error = ")
            System.Console.WriteLine(MyTag.ErrorString)
        End If

        '************************************
        ' * display quality status
        System.Console.WriteLine()
        System.Console.Write("Tag Quality = ")
        System.Console.WriteLine(MyTag.QualityString)
        System.Console.WriteLine()
        System.Console.Write("Press Any Key...")
        System.Console.ReadKey()

    End Sub

End Module
