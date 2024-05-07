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
        lblFirst = New Label()
        lblSecond = New Label()
        lblThird = New Label()
        lblRed = New Label()
        lblGreen = New Label()
        lblBlue = New Label()
        txtRed1 = New TextBox()
        txtGreen1 = New TextBox()
        txtBlue1 = New TextBox()
        btnEnter = New Button()
        btnReset = New Button()
        btnExit = New Button()
        lblRace = New Label()
        StatusStrip1 = New StatusStrip()
        lblError = New ToolStripStatusLabel()
        txtRed2 = New TextBox()
        txtGreen2 = New TextBox()
        txtBlue2 = New TextBox()
        txtRed3 = New TextBox()
        txtGreen3 = New TextBox()
        txtBlue3 = New TextBox()
        txtRed4 = New TextBox()
        txtGreen4 = New TextBox()
        txtBlue4 = New TextBox()
        lblRedScore = New Label()
        lblGreenScore = New Label()
        lblBlueScore = New Label()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFirst
        ' 
        lblFirst.BorderStyle = BorderStyle.Fixed3D
        lblFirst.Font = New Font("Segoe UI", 14.25F)
        lblFirst.Location = New Point(117, 49)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(199, 25)
        lblFirst.TabIndex = 0
        lblFirst.Text = "1st Place:  "
        ' 
        ' lblSecond
        ' 
        lblSecond.BorderStyle = BorderStyle.Fixed3D
        lblSecond.Font = New Font("Segoe UI", 14.25F)
        lblSecond.Location = New Point(14, 84)
        lblSecond.Name = "lblSecond"
        lblSecond.Size = New Size(202, 25)
        lblSecond.TabIndex = 1
        lblSecond.Text = "2nd Place: "
        ' 
        ' lblThird
        ' 
        lblThird.BorderStyle = BorderStyle.Fixed3D
        lblThird.Font = New Font("Segoe UI", 14.25F)
        lblThird.Location = New Point(220, 84)
        lblThird.Name = "lblThird"
        lblThird.Size = New Size(198, 25)
        lblThird.TabIndex = 2
        lblThird.Text = "3rd Place: "
        ' 
        ' lblRed
        ' 
        lblRed.AutoSize = True
        lblRed.Font = New Font("Segoe UI", 14.25F)
        lblRed.Location = New Point(57, 179)
        lblRed.Name = "lblRed"
        lblRed.Size = New Size(90, 25)
        lblRed.TabIndex = 4
        lblRed.Text = "Red Boat:"
        ' 
        ' lblGreen
        ' 
        lblGreen.AutoSize = True
        lblGreen.Font = New Font("Segoe UI", 14.25F)
        lblGreen.Location = New Point(57, 215)
        lblGreen.Name = "lblGreen"
        lblGreen.Size = New Size(110, 25)
        lblGreen.TabIndex = 5
        lblGreen.Text = "Green Boat:"
        ' 
        ' lblBlue
        ' 
        lblBlue.AutoSize = True
        lblBlue.Font = New Font("Segoe UI", 14.25F)
        lblBlue.Location = New Point(57, 251)
        lblBlue.Name = "lblBlue"
        lblBlue.Size = New Size(96, 25)
        lblBlue.TabIndex = 6
        lblBlue.Text = "Blue Boat:"
        ' 
        ' txtRed1
        ' 
        txtRed1.Location = New Point(174, 182)
        txtRed1.Name = "txtRed1"
        txtRed1.Size = New Size(30, 23)
        txtRed1.TabIndex = 7
        ' 
        ' txtGreen1
        ' 
        txtGreen1.Location = New Point(174, 217)
        txtGreen1.Name = "txtGreen1"
        txtGreen1.Size = New Size(30, 23)
        txtGreen1.TabIndex = 8
        ' 
        ' txtBlue1
        ' 
        txtBlue1.Location = New Point(174, 252)
        txtBlue1.Name = "txtBlue1"
        txtBlue1.Size = New Size(30, 23)
        txtBlue1.TabIndex = 9
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(59, 301)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(90, 42)
        btnEnter.TabIndex = 19
        btnEnter.Text = "Enter Times"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(171, 301)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(90, 42)
        btnReset.TabIndex = 20
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(283, 301)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 42)
        btnExit.TabIndex = 21
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblRace
        ' 
        lblRace.AutoSize = True
        lblRace.Font = New Font("Segoe UI", 14.25F)
        lblRace.Location = New Point(59, 143)
        lblRace.Name = "lblRace"
        lblRace.Size = New Size(317, 25)
        lblRace.TabIndex = 3
        lblRace.Text = "Race:               1     2     3     4    Score:"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblError})
        StatusStrip1.Location = New Point(0, 382)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(432, 22)
        StatusStrip1.TabIndex = 22
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblError
        ' 
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 17)
        ' 
        ' txtRed2
        ' 
        txtRed2.Location = New Point(210, 182)
        txtRed2.Name = "txtRed2"
        txtRed2.Size = New Size(30, 23)
        txtRed2.TabIndex = 10
        ' 
        ' txtGreen2
        ' 
        txtGreen2.Location = New Point(210, 217)
        txtGreen2.Name = "txtGreen2"
        txtGreen2.Size = New Size(30, 23)
        txtGreen2.TabIndex = 11
        ' 
        ' txtBlue2
        ' 
        txtBlue2.Location = New Point(210, 252)
        txtBlue2.Name = "txtBlue2"
        txtBlue2.Size = New Size(30, 23)
        txtBlue2.TabIndex = 12
        ' 
        ' txtRed3
        ' 
        txtRed3.Location = New Point(246, 182)
        txtRed3.Name = "txtRed3"
        txtRed3.Size = New Size(30, 23)
        txtRed3.TabIndex = 13
        ' 
        ' txtGreen3
        ' 
        txtGreen3.Location = New Point(246, 217)
        txtGreen3.Name = "txtGreen3"
        txtGreen3.Size = New Size(30, 23)
        txtGreen3.TabIndex = 14
        ' 
        ' txtBlue3
        ' 
        txtBlue3.Location = New Point(246, 252)
        txtBlue3.Name = "txtBlue3"
        txtBlue3.Size = New Size(30, 23)
        txtBlue3.TabIndex = 15
        ' 
        ' txtRed4
        ' 
        txtRed4.Location = New Point(282, 182)
        txtRed4.Name = "txtRed4"
        txtRed4.Size = New Size(30, 23)
        txtRed4.TabIndex = 16
        ' 
        ' txtGreen4
        ' 
        txtGreen4.Location = New Point(282, 217)
        txtGreen4.Name = "txtGreen4"
        txtGreen4.Size = New Size(30, 23)
        txtGreen4.TabIndex = 17
        ' 
        ' txtBlue4
        ' 
        txtBlue4.Location = New Point(282, 252)
        txtBlue4.Name = "txtBlue4"
        txtBlue4.Size = New Size(30, 23)
        txtBlue4.TabIndex = 18
        ' 
        ' lblRedScore
        ' 
        lblRedScore.BorderStyle = BorderStyle.Fixed3D
        lblRedScore.Font = New Font("Segoe UI", 14.25F)
        lblRedScore.Location = New Point(318, 182)
        lblRedScore.Name = "lblRedScore"
        lblRedScore.Size = New Size(37, 23)
        lblRedScore.TabIndex = 4
        lblRedScore.Text = " "
        ' 
        ' lblGreenScore
        ' 
        lblGreenScore.BorderStyle = BorderStyle.Fixed3D
        lblGreenScore.Font = New Font("Segoe UI", 14.25F)
        lblGreenScore.Location = New Point(318, 217)
        lblGreenScore.Name = "lblGreenScore"
        lblGreenScore.Size = New Size(37, 23)
        lblGreenScore.TabIndex = 5
        lblGreenScore.Text = " "
        ' 
        ' lblBlueScore
        ' 
        lblBlueScore.BorderStyle = BorderStyle.Fixed3D
        lblBlueScore.Font = New Font("Segoe UI", 14.25F)
        lblBlueScore.Location = New Point(318, 252)
        lblBlueScore.Name = "lblBlueScore"
        lblBlueScore.Size = New Size(37, 23)
        lblBlueScore.TabIndex = 6
        lblBlueScore.Text = " "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 404)
        Controls.Add(StatusStrip1)
        Controls.Add(lblRace)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnEnter)
        Controls.Add(txtBlue4)
        Controls.Add(txtBlue3)
        Controls.Add(txtBlue2)
        Controls.Add(txtBlue1)
        Controls.Add(txtGreen4)
        Controls.Add(txtGreen3)
        Controls.Add(txtGreen2)
        Controls.Add(txtGreen1)
        Controls.Add(txtRed4)
        Controls.Add(txtRed3)
        Controls.Add(txtRed2)
        Controls.Add(txtRed1)
        Controls.Add(lblBlueScore)
        Controls.Add(lblBlue)
        Controls.Add(lblGreenScore)
        Controls.Add(lblRedScore)
        Controls.Add(lblGreen)
        Controls.Add(lblRed)
        Controls.Add(lblThird)
        Controls.Add(lblSecond)
        Controls.Add(lblFirst)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblThird As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents txtRed1 As TextBox
    Friend WithEvents txtGreen1 As TextBox
    Friend WithEvents txtBlue1 As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblRace As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblError As ToolStripStatusLabel
    Friend WithEvents txtRed2 As TextBox
    Friend WithEvents txtGreen2 As TextBox
    Friend WithEvents txtBlue2 As TextBox
    Friend WithEvents txtRed3 As TextBox
    Friend WithEvents txtGreen3 As TextBox
    Friend WithEvents txtBlue3 As TextBox
    Friend WithEvents txtRed4 As TextBox
    Friend WithEvents txtGreen4 As TextBox
    Friend WithEvents txtBlue4 As TextBox
    Friend WithEvents lblRedScore As Label
    Friend WithEvents lblGreenScore As Label
    Friend WithEvents lblBlueScore As Label

End Class
