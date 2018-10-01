Imports System.Diagnostics.Eventing
Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class Form1
    Dim receivedData As String = ""
    Dim comPORT As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'ComboBox_AvailableSerialPorts.Items.Add(AvailableSerialPorts)

        'ComboBox_AvailableSerialPorts.Text = AvailableSerialPorts

        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_AvailableSerialPorts.Items.Add(sp)
        Next

        Button_Connect.Visible = True
        Button_Disconnect.Visible = False

        'TextBox_ReceivedMessage.ScrollBars = ScrollBars.Vertical

        ComboBox1.Items.Add("4800")
        ComboBox1.Items.Add("9600")
        ComboBox1.Items.Add("14400")
        ComboBox1.Items.Add("19200")
        ComboBox1.Items.Add("28800")
        ComboBox1.Items.Add("38400")
        ComboBox1.Items.Add("57600")
        ComboBox1.Items.Add("115200")


    End Sub

    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click

        SerialPort1.BaudRate = (ComboBox1.Text)
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
        'SerialPort1.ReadTimeout = 10000
        SerialPort1.PortName = ComboBox_AvailableSerialPorts.SelectedItem

        Button_Connect.Visible = False
        Button_Disconnect.Visible = True

        Timer1.Enabled = True

        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
        End If
    End Sub

    Private Sub Button_Disconnect_Click(sender As Object, e As EventArgs) Handles Button_Disconnect.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If

        Button_Connect.Visible = True
        Button_Disconnect.Visible = False

        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        RichTextBox1.Text &= receivedData
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Send_Button.Click
        SerialPort1.WriteLine(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim minta As MsgBoxResult
        minta = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If minta = MsgBoxResult.Yes Then
            Me.Close()
        ElseIf minta = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Controller1_Button.Click
        Controller1_Button.BackColor = Color.OrangeRed
        Reset_Button.BackColor = Color.GreenYellow
        SerialPort1.WriteLine("1EN")

    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        Reset_Button.BackColor = Color.PeachPuff
        Controller1_Button.BackColor = Color.DarkSalmon
        Controller2_Button.BackColor = Color.DarkSalmon
        Controller3_Button.BackColor = Color.DarkSalmon
        Controller4_Button.BackColor = Color.DarkSalmon

        SerialPort1.WriteLine("1DI")
        SerialPort1.WriteLine("2DI")

    End Sub

    Private Sub Controller2_Button_Click(sender As Object, e As EventArgs) Handles Controller2_Button.Click
        Controller2_Button.BackColor = Color.OrangeRed
        Reset_Button.BackColor = Color.GreenYellow
        SerialPort1.WriteLine("2EN")
    End Sub

    Private Sub Controller3_Button_Click(sender As Object, e As EventArgs) Handles Controller3_Button.Click
        Controller3_Button.BackColor = Color.OrangeRed
        Reset_Button.BackColor = Color.GreenYellow
    End Sub

    Private Sub Controller4_Button_Click(sender As Object, e As EventArgs) Handles Controller4_Button.Click
        Controller4_Button.BackColor = Color.OrangeRed
        Reset_Button.BackColor = Color.GreenYellow
    End Sub

    Private Sub ComboBox_AvailableSerialPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_AvailableSerialPorts.SelectedIndexChanged
        If (ComboBox_AvailableSerialPorts.SelectedItem <> "") Then
            comPORT = ComboBox_AvailableSerialPorts.SelectedItem
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = ""
    End Sub
End Class
