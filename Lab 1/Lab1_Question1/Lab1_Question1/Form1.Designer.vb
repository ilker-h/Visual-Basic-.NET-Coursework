<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEarth = New System.Windows.Forms.Button()
        Me.btnMercury = New System.Windows.Forms.Button()
        Me.btnMars = New System.Windows.Forms.Button()
        Me.lblGravityMeters = New System.Windows.Forms.Label()
        Me.lblGravityFeet = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEarth
        '
        Me.btnEarth.Location = New System.Drawing.Point(12, 175)
        Me.btnEarth.Name = "btnEarth"
        Me.btnEarth.Size = New System.Drawing.Size(75, 23)
        Me.btnEarth.TabIndex = 1
        Me.btnEarth.Text = "&Earth"
        Me.btnEarth.UseVisualStyleBackColor = True
        '
        'btnMercury
        '
        Me.btnMercury.Location = New System.Drawing.Point(104, 175)
        Me.btnMercury.Name = "btnMercury"
        Me.btnMercury.Size = New System.Drawing.Size(75, 23)
        Me.btnMercury.TabIndex = 2
        Me.btnMercury.Text = "&Mercury"
        Me.btnMercury.UseVisualStyleBackColor = True
        '
        'btnMars
        '
        Me.btnMars.Location = New System.Drawing.Point(197, 175)
        Me.btnMars.Name = "btnMars"
        Me.btnMars.Size = New System.Drawing.Size(75, 23)
        Me.btnMars.TabIndex = 3
        Me.btnMars.Text = "M&ars"
        Me.btnMars.UseVisualStyleBackColor = True
        '
        'lblGravityMeters
        '
        Me.lblGravityMeters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGravityMeters.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblGravityMeters.Location = New System.Drawing.Point(30, 63)
        Me.lblGravityMeters.Name = "lblGravityMeters"
        Me.lblGravityMeters.Size = New System.Drawing.Size(104, 43)
        Me.lblGravityMeters.TabIndex = 4
        Me.lblGravityMeters.Text = "Gravity in m/s^2"
        Me.lblGravityMeters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGravityFeet
        '
        Me.lblGravityFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGravityFeet.Location = New System.Drawing.Point(153, 63)
        Me.lblGravityFeet.Name = "lblGravityFeet"
        Me.lblGravityFeet.Size = New System.Drawing.Size(111, 43)
        Me.lblGravityFeet.TabIndex = 5
        Me.lblGravityFeet.Text = "Gravity in ft/s^2"
        Me.lblGravityFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(104, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGravityFeet)
        Me.Controls.Add(Me.lblGravityMeters)
        Me.Controls.Add(Me.btnMars)
        Me.Controls.Add(Me.btnMercury)
        Me.Controls.Add(Me.btnEarth)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEarth As System.Windows.Forms.Button
    Friend WithEvents btnMercury As System.Windows.Forms.Button
    Friend WithEvents btnMars As System.Windows.Forms.Button
    Friend WithEvents lblGravityMeters As System.Windows.Forms.Label
    Friend WithEvents lblGravityFeet As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
