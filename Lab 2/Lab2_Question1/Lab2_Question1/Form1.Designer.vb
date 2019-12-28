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
        Me.txtInputFx = New System.Windows.Forms.TextBox()
        Me.txtInputFy = New System.Windows.Forms.TextBox()
        Me.lblInputFXInstructions = New System.Windows.Forms.Label()
        Me.lblInputFYInstructions = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResultantVector = New System.Windows.Forms.Label()
        Me.lblDirectionAngle = New System.Windows.Forms.Label()
        Me.chkShowThetaA = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtInputFx
        '
        Me.txtInputFx.Location = New System.Drawing.Point(12, 37)
        Me.txtInputFx.Name = "txtInputFx"
        Me.txtInputFx.Size = New System.Drawing.Size(100, 20)
        Me.txtInputFx.TabIndex = 0
        '
        'txtInputFy
        '
        Me.txtInputFy.Location = New System.Drawing.Point(123, 37)
        Me.txtInputFy.Name = "txtInputFy"
        Me.txtInputFy.Size = New System.Drawing.Size(100, 20)
        Me.txtInputFy.TabIndex = 1
        '
        'lblInputFXInstructions
        '
        Me.lblInputFXInstructions.AutoSize = True
        Me.lblInputFXInstructions.Location = New System.Drawing.Point(26, 9)
        Me.lblInputFXInstructions.Name = "lblInputFXInstructions"
        Me.lblInputFXInstructions.Size = New System.Drawing.Size(48, 13)
        Me.lblInputFXInstructions.TabIndex = 2
        Me.lblInputFXInstructions.Text = "Input Fx:"
        '
        'lblInputFYInstructions
        '
        Me.lblInputFYInstructions.AutoSize = True
        Me.lblInputFYInstructions.Location = New System.Drawing.Point(144, 9)
        Me.lblInputFYInstructions.Name = "lblInputFYInstructions"
        Me.lblInputFYInstructions.Size = New System.Drawing.Size(48, 13)
        Me.lblInputFYInstructions.TabIndex = 3
        Me.lblInputFYInstructions.Text = "Input Fy:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 127)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 56)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate Resultant Vector and Direction Angle"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(147, 127)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 56)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResultantVector
        '
        Me.lblResultantVector.AutoSize = True
        Me.lblResultantVector.Location = New System.Drawing.Point(35, 210)
        Me.lblResultantVector.Name = "lblResultantVector"
        Me.lblResultantVector.Size = New System.Drawing.Size(0, 13)
        Me.lblResultantVector.TabIndex = 6
        '
        'lblDirectionAngle
        '
        Me.lblDirectionAngle.AutoSize = True
        Me.lblDirectionAngle.Location = New System.Drawing.Point(153, 210)
        Me.lblDirectionAngle.Name = "lblDirectionAngle"
        Me.lblDirectionAngle.Size = New System.Drawing.Size(0, 13)
        Me.lblDirectionAngle.TabIndex = 7
        '
        'chkShowThetaA
        '
        Me.chkShowThetaA.AutoSize = True
        Me.chkShowThetaA.Location = New System.Drawing.Point(31, 80)
        Me.chkShowThetaA.Name = "chkShowThetaA"
        Me.chkShowThetaA.Size = New System.Drawing.Size(144, 17)
        Me.chkShowThetaA.TabIndex = 8
        Me.chkShowThetaA.Text = "Show Theta a angle only"
        Me.chkShowThetaA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 277)
        Me.Controls.Add(Me.chkShowThetaA)
        Me.Controls.Add(Me.lblDirectionAngle)
        Me.Controls.Add(Me.lblResultantVector)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInputFYInstructions)
        Me.Controls.Add(Me.lblInputFXInstructions)
        Me.Controls.Add(Me.txtInputFy)
        Me.Controls.Add(Me.txtInputFx)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputFx As System.Windows.Forms.TextBox
    Friend WithEvents txtInputFy As System.Windows.Forms.TextBox
    Friend WithEvents lblInputFXInstructions As System.Windows.Forms.Label
    Friend WithEvents lblInputFYInstructions As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResultantVector As System.Windows.Forms.Label
    Friend WithEvents lblDirectionAngle As System.Windows.Forms.Label
    Friend WithEvents chkShowThetaA As System.Windows.Forms.CheckBox

End Class
