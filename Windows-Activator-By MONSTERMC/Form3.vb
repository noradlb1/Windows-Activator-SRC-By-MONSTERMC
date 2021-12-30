Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Namespace Windows_Activator
	Partial Public Class Form3
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

        Friend WithEvents NyX_Theme1 As NYX_Theme
        Friend WithEvents NyX_Button1 As NYX_Button



        Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
            Dim key As String = "slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99"
            Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
            Dim proc As New System.Diagnostics.Process()
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            proc.StartInfo = p
            proc.Start()
            proc.WaitForExit()
            proc.Close()
        End Sub

        Friend WithEvents NyX_Button2 As NYX_Button

        Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
            Dim key As String = "slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX"
            Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
            Dim proc As New System.Diagnostics.Process()
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            proc.StartInfo = p
            proc.Start()
            proc.WaitForExit()
            proc.Close()
        End Sub

        Friend WithEvents NyX_Button3 As NYX_Button

        Private Sub NyX_Button3_Click(sender As Object, e As EventArgs) Handles NyX_Button3.Click
            Dim key As String = "slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2"
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
            Dim key As String = "slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43"
            Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
            Dim proc As New System.Diagnostics.Process()
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            proc.StartInfo = p
            proc.Start()
            proc.WaitForExit()
            proc.Close()
        End Sub
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
            Me.NyX_Theme1 = New Windows_Activator_By_MONSTERMC.NYX_Theme()
            Me.NyX_ControlBox1 = New Windows_Activator_By_MONSTERMC.NYX_ControlBox()
            Me.NyX_Button5 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button4 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button3 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button2 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button1 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Theme1.SuspendLayout()
            Me.SuspendLayout()
            '
            'NyX_Theme1
            '
            Me.NyX_Theme1.Animated = True
            Me.NyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.NyX_Theme1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Theme1.Controls.Add(Me.NyX_ControlBox1)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button5)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button4)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button3)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button2)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button1)
            Me.NyX_Theme1.Customization = ""
            Me.NyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NyX_Theme1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.NyX_Theme1.Image = Nothing
            Me.NyX_Theme1.Location = New System.Drawing.Point(0, 0)
            Me.NyX_Theme1.Movable = True
            Me.NyX_Theme1.Name = "NyX_Theme1"
            Me.NyX_Theme1.NoRounding = False
            Me.NyX_Theme1.Sizable = False
            Me.NyX_Theme1.Size = New System.Drawing.Size(284, 193)
            Me.NyX_Theme1.SmartBounds = True
            Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
            Me.NyX_Theme1.TabIndex = 0
            Me.NyX_Theme1.Text = "Windows 10"
            Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
            Me.NyX_Theme1.Transparent = False
            '
            'NyX_ControlBox1
            '
            Me.NyX_ControlBox1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_ControlBox1.Customization = ""
            Me.NyX_ControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.NyX_ControlBox1.Image = Nothing
            Me.NyX_ControlBox1.Location = New System.Drawing.Point(237, 3)
            Me.NyX_ControlBox1.Name = "NyX_ControlBox1"
            Me.NyX_ControlBox1.NoRounding = False
            Me.NyX_ControlBox1.Size = New System.Drawing.Size(44, 20)
            Me.NyX_ControlBox1.TabIndex = 5
            Me.NyX_ControlBox1.Text = "NyX_ControlBox1"
            Me.NyX_ControlBox1.Transparent = False
            '
            'NyX_Button5
            '
            Me.NyX_Button5.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button5.Customization = ""
            Me.NyX_Button5.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button5.Image = Nothing
            Me.NyX_Button5.Location = New System.Drawing.Point(12, 155)
            Me.NyX_Button5.Name = "NyX_Button5"
            Me.NyX_Button5.NoRounding = False
            Me.NyX_Button5.Size = New System.Drawing.Size(260, 25)
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
            Me.NyX_Button4.Location = New System.Drawing.Point(12, 124)
            Me.NyX_Button4.Name = "NyX_Button4"
            Me.NyX_Button4.NoRounding = False
            Me.NyX_Button4.Size = New System.Drawing.Size(260, 25)
            Me.NyX_Button4.TabIndex = 3
            Me.NyX_Button4.Text = "Enterprise"
            Me.NyX_Button4.Transparent = False
            '
            'NyX_Button3
            '
            Me.NyX_Button3.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button3.Customization = ""
            Me.NyX_Button3.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button3.Image = Nothing
            Me.NyX_Button3.Location = New System.Drawing.Point(12, 93)
            Me.NyX_Button3.Name = "NyX_Button3"
            Me.NyX_Button3.NoRounding = False
            Me.NyX_Button3.Size = New System.Drawing.Size(260, 25)
            Me.NyX_Button3.TabIndex = 2
            Me.NyX_Button3.Text = "Education"
            Me.NyX_Button3.Transparent = False
            '
            'NyX_Button2
            '
            Me.NyX_Button2.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button2.Customization = ""
            Me.NyX_Button2.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button2.Image = Nothing
            Me.NyX_Button2.Location = New System.Drawing.Point(12, 62)
            Me.NyX_Button2.Name = "NyX_Button2"
            Me.NyX_Button2.NoRounding = False
            Me.NyX_Button2.Size = New System.Drawing.Size(260, 25)
            Me.NyX_Button2.TabIndex = 1
            Me.NyX_Button2.Text = "Professional"
            Me.NyX_Button2.Transparent = False
            '
            'NyX_Button1
            '
            Me.NyX_Button1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button1.Customization = ""
            Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button1.Image = Nothing
            Me.NyX_Button1.Location = New System.Drawing.Point(12, 31)
            Me.NyX_Button1.Name = "NyX_Button1"
            Me.NyX_Button1.NoRounding = False
            Me.NyX_Button1.Size = New System.Drawing.Size(260, 25)
            Me.NyX_Button1.TabIndex = 0
            Me.NyX_Button1.Text = "Home"
            Me.NyX_Button1.Transparent = False
            '
            'Form3
            '
            Me.ClientSize = New System.Drawing.Size(284, 193)
            Me.Controls.Add(Me.NyX_Theme1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form3"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
            Me.Text = "Windows 10"
            Me.TransparencyKey = System.Drawing.Color.Fuchsia
            Me.NyX_Theme1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents NyX_Button5 As NYX_Button
        Friend WithEvents NyX_ControlBox1 As NYX_ControlBox

        Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
            Form4.Show()
        End Sub
    End Class
End Namespace