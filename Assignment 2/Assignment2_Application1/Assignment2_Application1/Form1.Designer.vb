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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblModelType = New System.Windows.Forms.Label()
        Me.lblDoubleOrHalfTime = New System.Windows.Forms.Label()
        Me.txtInputPo = New System.Windows.Forms.TextBox()
        Me.txtInputK = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a P value at t=0 sec, and a k value:"
        '
        'lblModelType
        '
        Me.lblModelType.AutoSize = True
        Me.lblModelType.Location = New System.Drawing.Point(54, 82)
        Me.lblModelType.Name = "lblModelType"
        Me.lblModelType.Size = New System.Drawing.Size(0, 13)
        Me.lblModelType.TabIndex = 1
        '
        'lblDoubleOrHalfTime
        '
        Me.lblDoubleOrHalfTime.AutoSize = True
        Me.lblDoubleOrHalfTime.Location = New System.Drawing.Point(54, 115)
        Me.lblDoubleOrHalfTime.Name = "lblDoubleOrHalfTime"
        Me.lblDoubleOrHalfTime.Size = New System.Drawing.Size(0, 13)
        Me.lblDoubleOrHalfTime.TabIndex = 2
        '
        'txtInputPo
        '
        Me.txtInputPo.Location = New System.Drawing.Point(15, 44)
        Me.txtInputPo.Name = "txtInputPo"
        Me.txtInputPo.Size = New System.Drawing.Size(100, 20)
        Me.txtInputPo.TabIndex = 3
        '
        'txtInputK
        '
        Me.txtInputK.Location = New System.Drawing.Point(135, 44)
        Me.txtInputK.Name = "txtInputK"
        Me.txtInputK.Size = New System.Drawing.Size(100, 20)
        Me.txtInputK.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(10, 186)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(91, 186)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Cle&ar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInputK)
        Me.Controls.Add(Me.txtInputPo)
        Me.Controls.Add(Me.lblDoubleOrHalfTime)
        Me.Controls.Add(Me.lblModelType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblModelType As System.Windows.Forms.Label
    Friend WithEvents lblDoubleOrHalfTime As System.Windows.Forms.Label
    Friend WithEvents txtInputPo As System.Windows.Forms.TextBox
    Friend WithEvents txtInputK As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
