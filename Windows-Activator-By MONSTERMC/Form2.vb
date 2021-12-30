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
    Partial Public Class Form2
        Inherits Form

        Public Sub New()
            InitializeComponent()

        End Sub

        Friend WithEvents NyX_Theme1 As NYX_Theme
        Friend WithEvents NyX_Button1 As NYX_Button

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
            Me.NyX_Theme1 = New Windows_Activator_By_MONSTERMC.NYX_Theme()
            Me.NyX_ControlBox1 = New Windows_Activator_By_MONSTERMC.NYX_ControlBox()
            Me.CrystalClearTextBox2 = New Windows_Activator_By_MONSTERMC.CrystalClearTextBox()
            Me.CrystalClearTextBox1 = New Windows_Activator_By_MONSTERMC.CrystalClearTextBox()
            Me.NyX_Button7 = New Windows_Activator_By_MONSTERMC.NYX_Button()
            Me.NyX_Button6 = New Windows_Activator_By_MONSTERMC.NYX_Button()
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
            Me.NyX_Theme1.Controls.Add(Me.CrystalClearTextBox2)
            Me.NyX_Theme1.Controls.Add(Me.CrystalClearTextBox1)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button7)
            Me.NyX_Theme1.Controls.Add(Me.NyX_Button6)
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
            Me.NyX_Theme1.Size = New System.Drawing.Size(335, 202)
            Me.NyX_Theme1.SmartBounds = True
            Me.NyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.NyX_Theme1.TabIndex = 0
            Me.NyX_Theme1.Text = "Windows 7"
            Me.NyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia
            Me.NyX_Theme1.Transparent = False
            '
            'NyX_ControlBox1
            '
            Me.NyX_ControlBox1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_ControlBox1.Customization = ""
            Me.NyX_ControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.NyX_ControlBox1.Image = Nothing
            Me.NyX_ControlBox1.Location = New System.Drawing.Point(288, 2)
            Me.NyX_ControlBox1.Name = "NyX_ControlBox1"
            Me.NyX_ControlBox1.NoRounding = False
            Me.NyX_ControlBox1.Size = New System.Drawing.Size(44, 20)
            Me.NyX_ControlBox1.TabIndex = 9
            Me.NyX_ControlBox1.Text = "NyX_ControlBox1"
            Me.NyX_ControlBox1.Transparent = False
            '
            'CrystalClearTextBox2
            '
            Me.CrystalClearTextBox2.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.CrystalClearTextBox2.Customization = ""
            Me.CrystalClearTextBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.CrystalClearTextBox2.Image = Nothing
            Me.CrystalClearTextBox2.Location = New System.Drawing.Point(143, 97)
            Me.CrystalClearTextBox2.MaxLength = 32767
            Me.CrystalClearTextBox2.Multiline = False
            Me.CrystalClearTextBox2.Name = "CrystalClearTextBox2"
            Me.CrystalClearTextBox2.NoRounding = False
            Me.CrystalClearTextBox2.ReadOnly = False
            Me.CrystalClearTextBox2.Size = New System.Drawing.Size(48, 24)
            Me.CrystalClearTextBox2.TabIndex = 8
            Me.CrystalClearTextBox2.Text = "64 BIT"
            Me.CrystalClearTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.CrystalClearTextBox2.Transparent = False
            Me.CrystalClearTextBox2.UseSystemPasswordChar = False
            '
            'CrystalClearTextBox1
            '
            Me.CrystalClearTextBox1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.CrystalClearTextBox1.Customization = ""
            Me.CrystalClearTextBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
            Me.CrystalClearTextBox1.Image = Nothing
            Me.CrystalClearTextBox1.Location = New System.Drawing.Point(143, 33)
            Me.CrystalClearTextBox1.MaxLength = 32767
            Me.CrystalClearTextBox1.Multiline = False
            Me.CrystalClearTextBox1.Name = "CrystalClearTextBox1"
            Me.CrystalClearTextBox1.NoRounding = False
            Me.CrystalClearTextBox1.ReadOnly = False
            Me.CrystalClearTextBox1.Size = New System.Drawing.Size(48, 24)
            Me.CrystalClearTextBox1.TabIndex = 7
            Me.CrystalClearTextBox1.Text = "32 BIT"
            Me.CrystalClearTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.CrystalClearTextBox1.Transparent = False
            Me.CrystalClearTextBox1.UseSystemPasswordChar = False
            '
            'NyX_Button7
            '
            Me.NyX_Button7.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button7.Customization = ""
            Me.NyX_Button7.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button7.Image = Nothing
            Me.NyX_Button7.Location = New System.Drawing.Point(12, 162)
            Me.NyX_Button7.Name = "NyX_Button7"
            Me.NyX_Button7.NoRounding = False
            Me.NyX_Button7.Size = New System.Drawing.Size(312, 25)
            Me.NyX_Button7.TabIndex = 6
            Me.NyX_Button7.Text = "ABOUT"
            Me.NyX_Button7.Transparent = False
            '
            'NyX_Button6
            '
            Me.NyX_Button6.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button6.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button6.Customization = ""
            Me.NyX_Button6.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button6.Image = Nothing
            Me.NyX_Button6.Location = New System.Drawing.Point(224, 131)
            Me.NyX_Button6.Name = "NyX_Button6"
            Me.NyX_Button6.NoRounding = False
            Me.NyX_Button6.Size = New System.Drawing.Size(100, 25)
            Me.NyX_Button6.TabIndex = 5
            Me.NyX_Button6.Text = "Ultimate"
            Me.NyX_Button6.Transparent = False
            '
            'NyX_Button5
            '
            Me.NyX_Button5.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button5.Customization = ""
            Me.NyX_Button5.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button5.Image = Nothing
            Me.NyX_Button5.Location = New System.Drawing.Point(118, 131)
            Me.NyX_Button5.Name = "NyX_Button5"
            Me.NyX_Button5.NoRounding = False
            Me.NyX_Button5.Size = New System.Drawing.Size(100, 25)
            Me.NyX_Button5.TabIndex = 4
            Me.NyX_Button5.Text = "Enterprise"
            Me.NyX_Button5.Transparent = False
            '
            'NyX_Button4
            '
            Me.NyX_Button4.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button4.Customization = ""
            Me.NyX_Button4.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button4.Image = Nothing
            Me.NyX_Button4.Location = New System.Drawing.Point(12, 131)
            Me.NyX_Button4.Name = "NyX_Button4"
            Me.NyX_Button4.NoRounding = False
            Me.NyX_Button4.Size = New System.Drawing.Size(100, 25)
            Me.NyX_Button4.TabIndex = 3
            Me.NyX_Button4.Text = "Professional"
            Me.NyX_Button4.Transparent = False
            '
            'NyX_Button3
            '
            Me.NyX_Button3.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button3.Customization = ""
            Me.NyX_Button3.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button3.Image = Nothing
            Me.NyX_Button3.Location = New System.Drawing.Point(224, 64)
            Me.NyX_Button3.Name = "NyX_Button3"
            Me.NyX_Button3.NoRounding = False
            Me.NyX_Button3.Size = New System.Drawing.Size(100, 25)
            Me.NyX_Button3.TabIndex = 2
            Me.NyX_Button3.Text = "Ultimate"
            Me.NyX_Button3.Transparent = False
            '
            'NyX_Button2
            '
            Me.NyX_Button2.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button2.Customization = ""
            Me.NyX_Button2.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button2.Image = Nothing
            Me.NyX_Button2.Location = New System.Drawing.Point(118, 64)
            Me.NyX_Button2.Name = "NyX_Button2"
            Me.NyX_Button2.NoRounding = False
            Me.NyX_Button2.Size = New System.Drawing.Size(100, 25)
            Me.NyX_Button2.TabIndex = 1
            Me.NyX_Button2.Text = "Enterprise"
            Me.NyX_Button2.Transparent = False
            '
            'NyX_Button1
            '
            Me.NyX_Button1.Colors = New Windows_Activator_By_MONSTERMC.Bloom(-1) {}
            Me.NyX_Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.NyX_Button1.Customization = ""
            Me.NyX_Button1.Font = New System.Drawing.Font("Arial", 8.0!)
            Me.NyX_Button1.Image = Nothing
            Me.NyX_Button1.Location = New System.Drawing.Point(12, 64)
            Me.NyX_Button1.Name = "NyX_Button1"
            Me.NyX_Button1.NoRounding = False
            Me.NyX_Button1.Size = New System.Drawing.Size(100, 25)
            Me.NyX_Button1.TabIndex = 0
            Me.NyX_Button1.Text = "Professional"
            Me.NyX_Button1.Transparent = False
            '
            'Form2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(335, 202)
            Me.Controls.Add(Me.NyX_Theme1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Windows 7"
            Me.TransparencyKey = System.Drawing.Color.Fuchsia
            Me.NyX_Theme1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private Sub NyX_Button1_Click(sender As Object, e As EventArgs) Handles NyX_Button1.Click
            Try
                Dim key As String = "slmgr /ipk GMJQF-JC7VC-76HMH-M4RKY-V4HX6"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Catch
                Dim key As String = "slmgr /ipk AXBS6-LR9OV-MEYF5-RMJB9-UCRT2P"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Finally
                Dim key As String = "slmgr /ipk SF6YR-DEVX1-WSSL4-STPO3-QEX5P"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            End Try
        End Sub

        Friend WithEvents NyX_Button2 As NYX_Button

        Private Sub NyX_Button2_Click(sender As Object, e As EventArgs) Handles NyX_Button2.Click
            Try
                Dim key As String = "slmgr /ipk 83KKC-GGDK7-39JHV-723GB-XJGFR"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Catch
                Dim key As String = "slmgr /ipk 7RJ6P-7HM8F-B8HV8-4JDKM-JMRMF"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Finally
                Dim key As String = "slmgr /ipk BKWPQ-QPCC4-RXH26-BY2DJ-WQHCJ"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            End Try
        End Sub

        Friend WithEvents NyX_Button3 As NYX_Button

        Private Sub NyX_Button3_Click(sender As Object, e As EventArgs) Handles NyX_Button3.Click
            Try
                Dim key As String = "slmgr /ipk 7YWX9-W3C2V-D46GW-P722P-9CP4D"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Catch
                Dim key As String = "slmgr /ipk MM7DF-G8XWM-J2VRG-4M3C4-GR27X"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Finally
                Dim key As String = "slmgr /ipk KGMPT-GQ6XF-DM3VM-HW6PR-DX9G8"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            End Try
        End Sub

        Friend WithEvents NyX_Button4 As NYX_Button

        Private Sub NyX_Button4_Click(sender As Object, e As EventArgs) Handles NyX_Button4.Click
            Try
                Dim key As String = "slmgr /ipk GMJQF-JC7VC-76HMH-M4RKY-V4HX6"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Catch
                Dim key As String = "slmgr /ipk AXBS6-LR9OV-MEYF5-RMJB9-UCRT2P"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Finally
                Dim key As String = "slmgr /ipk SF6YR-DEVX1-WSSL4-STPO3-QEX5P"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            End Try
        End Sub

        Friend WithEvents NyX_Button5 As NYX_Button

        Private Sub NyX_Button5_Click(sender As Object, e As EventArgs) Handles NyX_Button5.Click
            Try
                Dim key As String = "slmgr /ipk 83KKC-GGDK7-39JHV-723GB-XJGFR"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Catch
                Dim key As String = "slmgr /ipk 7RJ6P-7HM8F-B8HV8-4JDKM-JMRMF"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Finally
                Dim key As String = "slmgr /ipk BKWPQ-QPCC4-RXH26-BY2DJ-WQHCJ"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            End Try
        End Sub

        Friend WithEvents NyX_Button6 As NYX_Button

        Private Sub NyX_Button6_Click(sender As Object, e As EventArgs) Handles NyX_Button6.Click
            Try
                Dim key As String = "slmgr /ipk 7YWX9-W3C2V-D46GW-P722P-9CP4D"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Catch
                Dim key As String = "slmgr /ipk MM7DF-G8XWM-J2VRG-4M3C4-GR27X"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            Finally
                Dim key As String = "slmgr /ipk KGMPT-GQ6XF-DM3VM-HW6PR-DX9G8"
                Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe", "/C " & key)
                Dim proc As New System.Diagnostics.Process()
                p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                proc.StartInfo = p
                proc.Start()
                proc.WaitForExit()
                proc.Close()
            End Try
        End Sub

        Friend WithEvents NyX_Button7 As NYX_Button
        Friend WithEvents NyX_ControlBox1 As NYX_ControlBox
        Friend WithEvents CrystalClearTextBox2 As CrystalClearTextBox
        Friend WithEvents CrystalClearTextBox1 As CrystalClearTextBox

        Private Sub NyX_Button7_Click(sender As Object, e As EventArgs) Handles NyX_Button7.Click
            Form4.Show()
        End Sub
    End Class
End Namespace