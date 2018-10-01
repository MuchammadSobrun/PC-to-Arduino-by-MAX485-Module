<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.Send_Button = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox_AvailableSerialPorts = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Controller1_Button = New System.Windows.Forms.Button()
        Me.Controller2_Button = New System.Windows.Forms.Button()
        Me.Controller4_Button = New System.Windows.Forms.Button()
        Me.Controller3_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Connect
        '
        Me.Button_Connect.BackColor = System.Drawing.Color.Lime
        Me.Button_Connect.Location = New System.Drawing.Point(278, 119)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(112, 49)
        Me.Button_Connect.TabIndex = 1
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = False
        '
        'Button_Disconnect
        '
        Me.Button_Disconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_Disconnect.Location = New System.Drawing.Point(408, 120)
        Me.Button_Disconnect.Name = "Button_Disconnect"
        Me.Button_Disconnect.Size = New System.Drawing.Size(110, 48)
        Me.Button_Disconnect.TabIndex = 2
        Me.Button_Disconnect.Text = "Disconnect"
        Me.Button_Disconnect.UseVisualStyleBackColor = False
        '
        'Send_Button
        '
        Me.Send_Button.Location = New System.Drawing.Point(360, 236)
        Me.Send_Button.Name = "Send_Button"
        Me.Send_Button.Size = New System.Drawing.Size(75, 23)
        Me.Send_Button.TabIndex = 3
        Me.Send_Button.Text = "Send"
        Me.Send_Button.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(239, 527)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox_AvailableSerialPorts
        '
        Me.ComboBox_AvailableSerialPorts.FormattingEnabled = True
        Me.ComboBox_AvailableSerialPorts.Location = New System.Drawing.Point(87, 120)
        Me.ComboBox_AvailableSerialPorts.Name = "ComboBox_AvailableSerialPorts"
        Me.ComboBox_AvailableSerialPorts.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_AvailableSerialPorts.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "COM PORT"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Serial Monitor"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 199)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 22)
        Me.TextBox1.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 147)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Baudate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(341, 31)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Serial Comunication Test"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "By Muchammad Sobrun Ibnu Atfal"
        '
        'Controller1_Button
        '
        Me.Controller1_Button.BackColor = System.Drawing.Color.DarkSalmon
        Me.Controller1_Button.Location = New System.Drawing.Point(20, 24)
        Me.Controller1_Button.Name = "Controller1_Button"
        Me.Controller1_Button.Size = New System.Drawing.Size(95, 77)
        Me.Controller1_Button.TabIndex = 15
        Me.Controller1_Button.Text = "Controller #1"
        Me.Controller1_Button.UseVisualStyleBackColor = False
        '
        'Controller2_Button
        '
        Me.Controller2_Button.BackColor = System.Drawing.Color.DarkSalmon
        Me.Controller2_Button.Location = New System.Drawing.Point(128, 24)
        Me.Controller2_Button.Name = "Controller2_Button"
        Me.Controller2_Button.Size = New System.Drawing.Size(91, 77)
        Me.Controller2_Button.TabIndex = 16
        Me.Controller2_Button.Text = "Controller #2"
        Me.Controller2_Button.UseVisualStyleBackColor = False
        '
        'Controller4_Button
        '
        Me.Controller4_Button.BackColor = System.Drawing.Color.DarkSalmon
        Me.Controller4_Button.Location = New System.Drawing.Point(128, 117)
        Me.Controller4_Button.Name = "Controller4_Button"
        Me.Controller4_Button.Size = New System.Drawing.Size(91, 74)
        Me.Controller4_Button.TabIndex = 17
        Me.Controller4_Button.Text = "Controller #4"
        Me.Controller4_Button.UseVisualStyleBackColor = False
        '
        'Controller3_Button
        '
        Me.Controller3_Button.BackColor = System.Drawing.Color.DarkSalmon
        Me.Controller3_Button.Location = New System.Drawing.Point(21, 116)
        Me.Controller3_Button.Name = "Controller3_Button"
        Me.Controller3_Button.Size = New System.Drawing.Size(95, 74)
        Me.Controller3_Button.TabIndex = 18
        Me.Controller3_Button.Text = "Controller #3"
        Me.Controller3_Button.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Reset_Button)
        Me.GroupBox2.Controls.Add(Me.Controller1_Button)
        Me.GroupBox2.Controls.Add(Me.Controller2_Button)
        Me.GroupBox2.Controls.Add(Me.Controller4_Button)
        Me.GroupBox2.Controls.Add(Me.Controller3_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 242)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Reset_Button
        '
        Me.Reset_Button.BackColor = System.Drawing.Color.PeachPuff
        Me.Reset_Button.Location = New System.Drawing.Point(75, 201)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(91, 28)
        Me.Reset_Button.TabIndex = 19
        Me.Reset_Button.Text = "Reset"
        Me.Reset_Button.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 199)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(256, 290)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 564)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_AvailableSerialPorts)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Send_Button)
        Me.Controls.Add(Me.Button_Disconnect)
        Me.Controls.Add(Me.Button_Connect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Connect As Button
    Friend WithEvents Button_Disconnect As Button
    Friend WithEvents Send_Button As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox_AvailableSerialPorts As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Controller1_Button As Button
    Friend WithEvents Controller2_Button As Button
    Friend WithEvents Controller4_Button As Button
    Friend WithEvents Controller3_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Reset_Button As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
