'********************************************************
'* NETLOGIX.VB.CPU_STATE
'* returns the state of a ControlLogix/CompactLogix CPU
'*
'*********************************************************

' * INGEAR.NET.LOGIX
Imports Logix

Public Class Form1
    ' ***************************
    ' * instance of the Logix.Controller class
    Dim MyPLC As New Controller

    ' **************************
    ' * instance of the Logix.Tag class
    Dim cpuState As New Tag
    Dim cpuInfo As New Tag

    ' *************************
    ' * array of state values
    Dim stateArray As Array

    Private Sub _btnReadState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnReadState.Click

        Try

            cpuInfo.Name = "$CPU_INFO"

            If MyPLC.ReadTag(cpuInfo) <> Logix.ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(MyPLC.ErrorString, Me.Text)

                End If
                Return
            End If

            Dim plcProps() As String = cpuInfo.Value

            _progName.Text = plcProps(0) ' program name
            _model.Text = plcProps(1) ' plc model
            _firmware.Text = plcProps(2)  ' firmware revision
            _prodType.Text = plcProps(3) ' product type 
            _prodCode.Text = plcProps(4) ' product code
            _serialNum.Text = plcProps(5) ' serial #
            _edsFile.Text = plcProps(6) ' DS file number

            ' Micro850 does not support CPU state
            If (btnMicroCPU.Checked Or _cipPath.Text.Length = 0) Then
                _LEDState.Text = "Unavailable"
                _faultState.Text = "Unavailable"
                _keySwState.Text = "Unavailable"
                Return
            End If

            ' ***************************
            ' * special tag name
            ' * $CPU_STATE is an INGEAR.NET.LOGIX internal tag name
            ' * 
            cpuState.Name = "$CPU_STATE"

            If MyPLC.ReadTag(cpuState) <> Logix.ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString)
            Else
                ' ******************************
                ' * CPU State is returned as a 3-element
                ' * System.Int32[] array
                ' *****************************
                stateArray = cpuState.Value

                ' *****************************
                ' * element[0] of the array is
                ' * OK LED STATE
                ' *****************************
                Select Case stateArray(0)
                    Case 0
                        _LEDState.Text = "Solid Red (Power Up)"
                    Case 1
                        _LEDState.Text = "Flashing Red (Firmware Update)"
                    Case 2
                        _LEDState.Text = "Flashing Red (Communications Fault)"
                    Case 3
                        _LEDState.Text = "Flashing Green (Awaiting Connection)"
                    Case 4
                        _LEDState.Text = "Flashing Red (Configuration Bad)"
                    Case 5
                        _LEDState.Text = "Flashing/Solid Red (Major Fault)"
                    Case 6
                        _LEDState.Text = "Solid Green (Connected)"
                    Case 7
                        _LEDState.Text = "Flashing Green (Program Mode)"
                End Select

                ' ***********************************
                ' * element[1] of the cpu state array
                ' * major/minor fault
                ' * *********************************
                Select Case stateArray(1)
                    Case 0
                        _faultState.Text = "No Faults"
                    Case 1
                        _faultState.Text = "Minor Unrecoverable Fault"
                    Case 2
                        _faultState.Text = "Major Recoverable Fault"
                    Case 3
                        _faultState.Text = "Major Unrecoverable Fault"
                End Select

                ' *********************************
                ' * element[2] of the cpu state array
                ' * Key Switch Position
                ' *********************************
                Select Case stateArray(2)
                    Case 1
                        _keySwState.Text = "Run Mode (RUN)"
                    Case 2
                        _keySwState.Text = "Program (PROG)"
                    Case 3
                        _keySwState.Text = "Remote (REM)"
                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub _btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnConnect.Click

        Try

            If (btnMicroCPU.Checked) Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If

            ' ********************************
            ' * set controller class propertied
            MyPLC.IPAddress = _ipAddress.Text
            MyPLC.Path = _cipPath.Text
            MyPLC.Timeout = 3000

            ' ********************************
            ' * connect to the PLC
            If Logix.ResultCode.E_SUCCESS <> MyPLC.Connect() Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
            Else

                ' ********************************
                ' * we're connected
                _btnReadState.Enabled = True
                _btnConnect.Enabled = False
                _btnDisconnect.Enabled = True

            End If
            ' *********************************
            ' * report exceptions
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub _btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnDisconnect.Click
        MyPLC.Disconnect()
        _btnReadState.Enabled = False
        _btnConnect.Enabled = True
        _btnDisconnect.Enabled = False
    End Sub
End Class
