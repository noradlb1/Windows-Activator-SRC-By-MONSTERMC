Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Windows_Activator
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			MessageBox.Show("First of all disable your internet connection and run this program as Administrator")
			InitializeComponent()

		End Sub

        Friend WithEvents NyX_Theme1 As NYX_Theme
        Friend WithEvents NyX_ControlBox1 As NYX_ControlBox
        Friend WithEvents button6 As NYX_Button
        Friend WithEvents button5 As NYX_Button
        Friend WithEvents button4 As NYX_Button
        Friend WithEvents button3 As NYX_Button
        Friend WithEvents button1 As NYX_Button

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.NyX_Theme2 = New Windows_Activator_By_MONSTERMC.NYX_Theme()
            Me.NyX_ControlBox2 = New Windows_Activator_By_MONSTERMC.NYX_ControlBox()
            Me.NyX_Button5 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button4 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button3 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button2 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button1 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Theme2.SuspendLayout()
            Me.SuspendLayout()
            '
            'NyX_Theme2
            '
            Me.NyX_Theme2.Animated = True
            Me.NyX_Theme2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.NyX_Theme2.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Theme2.Controls.Add(Me.NyX_ControlBox2)
            Me.NyX_Theme2.Controls.Add(Me.NyX_Button5)
            Me.NyX_Theme2.Controls.Add(Me.NyX_Button4)
            Me.NyX_Theme2.Controls.Add(Me.NyX_Button3)
            Me.NyX_Theme2.Controls.Add(Me.NyX_Button2)
            Me.NyX_Theme2.Controls.Add(Me.NyX_Button1)
            Me.NyX_Theme2.Customization = ""
            Me.NyX_Theme2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NyX_Theme2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.NyX_Theme2.Image = Nothing
            Me.NyX_Theme2.Location = New System.Drawing.Point(0, 0)
            Me.NyX_Theme2.Movable = True
            Me.NyX_Theme2.Name = "NyX_Theme2"
            Me.NyX_Theme2.NoRounding = False
            Me.NyX_Theme2.Sizable = False
            Me.NyX_Theme2.Size = New System.Drawing.Size(299, 193)
            Me.NyX_Theme2.SmartBounds = True
            Me.NyX_Theme2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.NyX_Theme2.TabIndex = 0
            Me.NyX_Theme2.Text = "WiN ActiV By MONSTERMC"
            Me.NyX_Theme2.TransparencyKey = System.Drawing.Color.Fuchsia
            Me.NyX_Theme2.Transparent = False
            '
            'NyX_ControlBox2
            '
            Me.NyX_ControlBox2.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_ControlBox2.Customization = ""
            Me.NyX_ControlBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.NyX_ControlBox2.Image = Nothing
            Me.NyX_ControlBox2.Location = New System.Drawing.Point(252, 3)
            Me.NyX_ControlBox2.Name = "NyX_ControlBox2"
            Me.NyX_ControlBox2.NoRounding = False
            Me.NyX_ControlBox2.Size = New System.Drawing.Size(44, 20)
            Me.NyX_ControlBox2.TabIndex = 5
            Me.NyX_ControlBox2.Text = "NyX_ControlBox2"
            Me.NyX_ControlBox2.Transparent = False
            '
            'NyX_Button5
            '
            Me.NyX_Button5.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button5.Customization = ""
            Me.NyX_Button5.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button5.Image = Nothing
            Me.NyX_Button5.Location = New System.Drawing.Point(12, 154)
            Me.NyX_Button5.Name = "NyX_Button5"
            Me.NyX_Button5.NoRounding = False
            Me.NyX_Button5.Size = New System.Drawing.Size(275, 25)
            Me.NyX_Button5.TabIndex = 4
            Me.NyX_Button5.Text = "ABOUT"
            Me.NyX_Button5.Transparent = False
            '
            'NyX_Button4
            '
            Me.NyX_Button4.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button4.Customization = ""
            Me.NyX_Button4.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button4.Image = Nothing
            Me.NyX_Button4.Location = New System.Drawing.Point(12, 123)
            Me.NyX_Button4.Name = "NyX_Button4"
            Me.NyX_Button4.NoRounding = False
            Me.NyX_Button4.Size = New System.Drawing.Size(275, 25)
            Me.NyX_Button4.TabIndex = 3
            Me.NyX_Button4.Text = "Info"
            Me.NyX_Button4.Transparent = False
            '
            'NyX_Button3
            '
            Me.NyX_Button3.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button3.Customization = ""
            Me.NyX_Button3.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button3.Image = Nothing
            Me.NyX_Button3.Location = New System.Drawing.Point(12, 92)
            Me.NyX_Button3.Name = "NyX_Button3"
            Me.NyX_Button3.NoRounding = False
            Me.NyX_Button3.Size = New System.Drawing.Size(275, 25)
            Me.NyX_Button3.TabIndex = 2
            Me.NyX_Button3.Text = "Microsoft Office 16"
            Me.NyX_Button3.Transparent = False
            '
            'NyX_Button2
            '
            Me.NyX_Button2.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button2.Customization = ""
            Me.NyX_Button2.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button2.Image = Nothing
            Me.NyX_Button2.Location = New System.Drawing.Point(12, 61)
            Me.NyX_Button2.Name = "NyX_Button2"
            Me.NyX_Button2.NoRounding = False
            Me.NyX_Button2.Size = New System.Drawing.Size(275, 25)
            Me.NyX_Button2.TabIndex = 1
            Me.NyX_Button2.Text = "Windows 10"
            Me.NyX_Button2.Transparent = False
            '
            'NyX_Button1
            '
            Me.NyX_Button1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button1.Customization = ""
            Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button1.Image = Nothing
            Me.NyX_Button1.Location = New System.Drawing.Point(12, 30)
            Me.NyX_Button1.Name = "NyX_Button1"
            Me.NyX_Button1.NoRounding = False
            Me.NyX_Button1.Size = New System.Drawing.Size(275, 25)
            Me.NyX_Button1.TabIndex = 0
            Me.NyX_Button1.Text = "Windows 7"
            Me.NyX_Button1.Transparent = False
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(299, 193)
            Me.Controls.Add(Me.NyX_Theme2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.TransparencyKey = System.Drawing.Color.Fuchsia
            Me.NyX_Theme2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private Sub button1_Click_1(sender As Object, e As EventArgs)

        End Sub

        Friend WithEvents NyX_Theme2 As NYX_Theme
        Friend WithEvents NyX_Button1 As NYX_Button

        Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
            Dim form As New Form2()
            form.ShowDialog()
        End Sub

        Friend WithEvents NyX_Button2 As NYX_Button

        Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
            Dim form As New Form3()
            form.ShowDialog()
        End Sub

        Friend WithEvents NyX_Button3 As NYX_Button

        Private Sub NyX_Button3_Click(sender As Object, e As EventArgs) Handles NyX_Button3.Click
            Dim key As String = "cd '""c:/Program Files (x86)/Microsoft Office Office16/"" && cscript ospp.vbs /sethst:ug-kms.uni-goettingen.de && cscript ospp.vbs /act"
            Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
            Dim proc As New System.Diagnostics.Process()
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            proc.StartInfo = p
            proc.Start()
            proc.WaitForExit()
            proc.Close()
        End Sub

        Friend WithEvents NyX_Button4 As NYX_Button

        Private Sub NyX_Button4_Click(sender As Object, e As EventArgs) Handles NyX_Button4.Click
            MsgBox("THIS TOOL CREATED BY MONSTERMC TO ACTIVE ALL WIN VERSION & IF IT DOES NOT WORK PLEASE TURN YOUR INTERNET OFF & تم انشاء هذة الأداه من قبل مجهول عربي لتفعيل جميع الأصدار مجانا, ان لم يعمل معك التفعيل قم فقط بأغلاق الأنترنت الخاص بك وقم بتفعيل ايه شيء")
        End Sub
        Friend WithEvents NyX_Button5 As NYX_Button
        Friend WithEvents NyX_ControlBox2 As NYX_ControlBox

        Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
            Form4.Show()
        End Sub
    End Class
End Namespace
