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
        Me.txtInputUnstretchedLength = New System.Windows.Forms.TextBox()
        Me.txtInputAccelerationObject = New System.Windows.Forms.TextBox()
        Me.txtInputRadius = New System.Windows.Forms.TextBox()
        Me.lblInstructionsInputUnstretchedLength = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructionsInputAcceleration = New System.Windows.Forms.Label()
        Me.lstTableofResults = New System.Windows.Forms.ListBox()
        Me.lblInstructionsInputRadius = New System.Windows.Forms.Label()
        Me.lblShowInputLength = New System.Windows.Forms.Label()
        Me.lblShowInputAcceleration = New System.Windows.Forms.Label()
        Me.lblShowInputRadius = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInputUnstretchedLength
        '
        Me.txtInputUnstretchedLength.Location = New System.Drawing.Point(14, 36)
        Me.txtInputUnstretchedLength.Name = "txtInputUnstretchedLength"
        Me.txtInputUnstretchedLength.Size = New System.Drawing.Size(100, 20)
        Me.txtInputUnstretchedLength.TabIndex = 0
        '
        'txtInputAccelerationObject
        '
        Me.txtInputAccelerationObject.Location = New System.Drawing.Point(211, 36)
        Me.txtInputAccelerationObject.Name = "txtInputAccelerationObject"
        Me.txtInputAccelerationObject.Size = New System.Drawing.Size(100, 20)
        Me.txtInputAccelerationObject.TabIndex = 1
        '
        'txtInputRadius
        '
        Me.txtInputRadius.Location = New System.Drawing.Point(385, 36)
        Me.txtInputRadius.Name = "txtInputRadius"
        Me.txtInputRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtInputRadius.TabIndex = 2
        '
        'lblInstructionsInputUnstretchedLength
        '
        Me.lblInstructionsInputUnstretchedLength.AutoSize = True
        Me.lblInstructionsInputUnstretchedLength.Location = New System.Drawing.Point(11, 9)
        Me.lblInstructionsInputUnstretchedLength.Name = "lblInstructionsInputUnstretchedLength"
        Me.lblInstructionsInputUnstretchedLength.Size = New System.Drawing.Size(158, 13)
        Me.lblInstructionsInputUnstretchedLength.TabIndex = 3
        Me.lblInstructionsInputUnstretchedLength.Text = "Unstretched length of cable (m):"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(107, 79)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(247, 79)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInstructionsInputAcceleration
        '
        Me.lblInstructionsInputAcceleration.AutoSize = True
        Me.lblInstructionsInputAcceleration.Location = New System.Drawing.Point(189, 9)
        Me.lblInstructionsInputAcceleration.Name = "lblInstructionsInputAcceleration"
        Me.lblInstructionsInputAcceleration.Size = New System.Drawing.Size(191, 13)
        Me.lblInstructionsInputAcceleration.TabIndex = 7
        Me.lblInstructionsInputAcceleration.Text = "Upward Acceleration of Object (m/s^2)"
        '
        'lstTableofResults
        '
        Me.lstTableofResults.AccessibleName = ""
        Me.lstTableofResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTableofResults.FormattingEnabled = True
        Me.lstTableofResults.ItemHeight = 14
        Me.lstTableofResults.Location = New System.Drawing.Point(189, 135)
        Me.lstTableofResults.Name = "lstTableofResults"
        Me.lstTableofResults.Size = New System.Drawing.Size(281, 326)
        Me.lstTableofResults.TabIndex = 8
        '
        'lblInstructionsInputRadius
        '
        Me.lblInstructionsInputRadius.AutoSize = True
        Me.lblInstructionsInputRadius.Location = New System.Drawing.Point(410, 9)
        Me.lblInstructionsInputRadius.Name = "lblInstructionsInputRadius"
        Me.lblInstructionsInputRadius.Size = New System.Drawing.Size(60, 13)
        Me.lblInstructionsInputRadius.TabIndex = 9
        Me.lblInstructionsInputRadius.Text = "Radius (m):"
        '
        'lblShowInputLength
        '
        Me.lblShowInputLength.AutoSize = True
        Me.lblShowInputLength.Location = New System.Drawing.Point(26, 163)
        Me.lblShowInputLength.Name = "lblShowInputLength"
        Me.lblShowInputLength.Size = New System.Drawing.Size(0, 13)
        Me.lblShowInputLength.TabIndex = 10
        '
        'lblShowInputAcceleration
        '
        Me.lblShowInputAcceleration.AutoSize = True
        Me.lblShowInputAcceleration.Location = New System.Drawing.Point(26, 214)
        Me.lblShowInputAcceleration.Name = "lblShowInputAcceleration"
        Me.lblShowInputAcceleration.Size = New System.Drawing.Size(0, 13)
        Me.lblShowInputAcceleration.TabIndex = 11
        '
        'lblShowInputRadius
        '
        Me.lblShowInputRadius.AutoSize = True
        Me.lblShowInputRadius.Location = New System.Drawing.Point(26, 269)
        Me.lblShowInputRadius.Name = "lblShowInputRadius"
        Me.lblShowInputRadius.Size = New System.Drawing.Size(0, 13)
        Me.lblShowInputRadius.TabIndex = 12
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 479)
        Me.Controls.Add(Me.lblShowInputRadius)
        Me.Controls.Add(Me.lblShowInputAcceleration)
        Me.Controls.Add(Me.lblShowInputLength)
        Me.Controls.Add(Me.lblInstructionsInputRadius)
        Me.Controls.Add(Me.lstTableofResults)
        Me.Controls.Add(Me.lblInstructionsInputAcceleration)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructionsInputUnstretchedLength)
        Me.Controls.Add(Me.txtInputRadius)
        Me.Controls.Add(Me.txtInputAccelerationObject)
        Me.Controls.Add(Me.txtInputUnstretchedLength)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputUnstretchedLength As System.Windows.Forms.TextBox
    Friend WithEvents txtInputAccelerationObject As System.Windows.Forms.TextBox
    Friend WithEvents txtInputRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructionsInputUnstretchedLength As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInstructionsInputAcceleration As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsInputRadius As System.Windows.Forms.Label
    Friend WithEvents lstTableofResults As System.Windows.Forms.ListBox
    Friend WithEvents lblShowInputLength As System.Windows.Forms.Label
    Friend WithEvents lblShowInputAcceleration As System.Windows.Forms.Label
    Friend WithEvents lblShowInputRadius As System.Windows.Forms.Label

End Class
