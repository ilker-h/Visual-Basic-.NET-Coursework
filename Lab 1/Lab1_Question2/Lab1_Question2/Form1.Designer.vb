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
        Me.txtInputMass = New System.Windows.Forms.TextBox()
        Me.txtInputCharge = New System.Windows.Forms.TextBox()
        Me.txtInputSpeed = New System.Windows.Forms.TextBox()
        Me.txtInputPathRadius = New System.Windows.Forms.TextBox()
        Me.lblInputInstructions = New System.Windows.Forms.Label()
        Me.lblMass = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblPathRadius = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblDisplayMass = New System.Windows.Forms.Label()
        Me.lblDisplaySpeed = New System.Windows.Forms.Label()
        Me.lblDisplayPathRadius = New System.Windows.Forms.Label()
        Me.lblDisplayCharge = New System.Windows.Forms.Label()
        Me.lblHeadingForInputs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInputMass
        '
        Me.txtInputMass.Location = New System.Drawing.Point(178, 39)
        Me.txtInputMass.Name = "txtInputMass"
        Me.txtInputMass.Size = New System.Drawing.Size(100, 20)
        Me.txtInputMass.TabIndex = 0
        '
        'txtInputCharge
        '
        Me.txtInputCharge.Location = New System.Drawing.Point(178, 117)
        Me.txtInputCharge.Name = "txtInputCharge"
        Me.txtInputCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtInputCharge.TabIndex = 1
        '
        'txtInputSpeed
        '
        Me.txtInputSpeed.Location = New System.Drawing.Point(178, 65)
        Me.txtInputSpeed.Name = "txtInputSpeed"
        Me.txtInputSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtInputSpeed.TabIndex = 2
        '
        'txtInputPathRadius
        '
        Me.txtInputPathRadius.Location = New System.Drawing.Point(178, 91)
        Me.txtInputPathRadius.Name = "txtInputPathRadius"
        Me.txtInputPathRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtInputPathRadius.TabIndex = 3
        '
        'lblInputInstructions
        '
        Me.lblInputInstructions.AutoSize = True
        Me.lblInputInstructions.Location = New System.Drawing.Point(39, 9)
        Me.lblInputInstructions.Name = "lblInputInstructions"
        Me.lblInputInstructions.Size = New System.Drawing.Size(171, 13)
        Me.lblInputInstructions.TabIndex = 4
        Me.lblInputInstructions.Text = "Input Anesthetic Isoflurane Values:"
        '
        'lblMass
        '
        Me.lblMass.AutoSize = True
        Me.lblMass.Location = New System.Drawing.Point(39, 46)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.Size = New System.Drawing.Size(53, 13)
        Me.lblMass.TabIndex = 5
        Me.lblMass.Text = "Mass [kg]"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(39, 72)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(65, 13)
        Me.lblSpeed.TabIndex = 6
        Me.lblSpeed.Text = "Speed [m/s]"
        '
        'lblPathRadius
        '
        Me.lblPathRadius.AutoSize = True
        Me.lblPathRadius.Location = New System.Drawing.Point(39, 98)
        Me.lblPathRadius.Name = "lblPathRadius"
        Me.lblPathRadius.Size = New System.Drawing.Size(82, 13)
        Me.lblPathRadius.TabIndex = 7
        Me.lblPathRadius.Text = "Path Radius [m]"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(39, 124)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(137, 13)
        Me.lblCharge.TabIndex = 8
        Me.lblCharge.Text = "Charge [C] (Absolute Value)"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(85, 190)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 63)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate Magnitude of Magnetic Field"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 63)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(137, 294)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 11
        '
        'lblDisplayMass
        '
        Me.lblDisplayMass.AutoSize = True
        Me.lblDisplayMass.Location = New System.Drawing.Point(341, 46)
        Me.lblDisplayMass.Name = "lblDisplayMass"
        Me.lblDisplayMass.Size = New System.Drawing.Size(67, 13)
        Me.lblDisplayMass.TabIndex = 12
        Me.lblDisplayMass.Text = "__________"
        '
        'lblDisplaySpeed
        '
        Me.lblDisplaySpeed.AutoSize = True
        Me.lblDisplaySpeed.Location = New System.Drawing.Point(341, 72)
        Me.lblDisplaySpeed.Name = "lblDisplaySpeed"
        Me.lblDisplaySpeed.Size = New System.Drawing.Size(67, 13)
        Me.lblDisplaySpeed.TabIndex = 13
        Me.lblDisplaySpeed.Text = "__________"
        '
        'lblDisplayPathRadius
        '
        Me.lblDisplayPathRadius.AutoSize = True
        Me.lblDisplayPathRadius.Location = New System.Drawing.Point(341, 98)
        Me.lblDisplayPathRadius.Name = "lblDisplayPathRadius"
        Me.lblDisplayPathRadius.Size = New System.Drawing.Size(67, 13)
        Me.lblDisplayPathRadius.TabIndex = 14
        Me.lblDisplayPathRadius.Text = "__________"
        '
        'lblDisplayCharge
        '
        Me.lblDisplayCharge.AutoSize = True
        Me.lblDisplayCharge.Location = New System.Drawing.Point(341, 124)
        Me.lblDisplayCharge.Name = "lblDisplayCharge"
        Me.lblDisplayCharge.Size = New System.Drawing.Size(67, 13)
        Me.lblDisplayCharge.TabIndex = 15
        Me.lblDisplayCharge.Text = "__________"
        '
        'lblHeadingForInputs
        '
        Me.lblHeadingForInputs.AutoSize = True
        Me.lblHeadingForInputs.Location = New System.Drawing.Point(341, 20)
        Me.lblHeadingForInputs.Name = "lblHeadingForInputs"
        Me.lblHeadingForInputs.Size = New System.Drawing.Size(69, 13)
        Me.lblHeadingForInputs.TabIndex = 16
        Me.lblHeadingForInputs.Text = "Input Values:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 291)
        Me.Controls.Add(Me.lblHeadingForInputs)
        Me.Controls.Add(Me.lblDisplayCharge)
        Me.Controls.Add(Me.lblDisplayPathRadius)
        Me.Controls.Add(Me.lblDisplaySpeed)
        Me.Controls.Add(Me.lblDisplayMass)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.lblPathRadius)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblMass)
        Me.Controls.Add(Me.lblInputInstructions)
        Me.Controls.Add(Me.txtInputPathRadius)
        Me.Controls.Add(Me.txtInputSpeed)
        Me.Controls.Add(Me.txtInputCharge)
        Me.Controls.Add(Me.txtInputMass)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputMass As System.Windows.Forms.TextBox
    Friend WithEvents txtInputCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtInputSpeed As System.Windows.Forms.TextBox
    Friend WithEvents txtInputPathRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblInputInstructions As System.Windows.Forms.Label
    Friend WithEvents lblMass As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblPathRadius As System.Windows.Forms.Label
    Friend WithEvents lblCharge As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblDisplayMass As System.Windows.Forms.Label
    Friend WithEvents lblDisplaySpeed As System.Windows.Forms.Label
    Friend WithEvents lblDisplayPathRadius As System.Windows.Forms.Label
    Friend WithEvents lblDisplayCharge As System.Windows.Forms.Label
    Friend WithEvents lblHeadingForInputs As System.Windows.Forms.Label

End Class
