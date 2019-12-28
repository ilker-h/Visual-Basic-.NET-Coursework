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
        Me.cboMultiplicationTable = New System.Windows.Forms.ComboBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShowAnswers = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboMultiplicationTable
        '
        Me.cboMultiplicationTable.FormattingEnabled = True
        Me.cboMultiplicationTable.Location = New System.Drawing.Point(38, 58)
        Me.cboMultiplicationTable.Name = "cboMultiplicationTable"
        Me.cboMultiplicationTable.Size = New System.Drawing.Size(121, 21)
        Me.cboMultiplicationTable.TabIndex = 0
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 42)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(234, 13)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Select a Number to View its Multiplication Table:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 302)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Multiplication Practice!"
        '
        'chkShowAnswers
        '
        Me.chkShowAnswers.AutoSize = True
        Me.chkShowAnswers.Location = New System.Drawing.Point(176, 62)
        Me.chkShowAnswers.Name = "chkShowAnswers"
        Me.chkShowAnswers.Size = New System.Drawing.Size(96, 17)
        Me.chkShowAnswers.TabIndex = 5
        Me.chkShowAnswers.Text = "Show Answers"
        Me.chkShowAnswers.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.Location = New System.Drawing.Point(51, 98)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(138, 201)
        Me.lblResults.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(331, 357)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkShowAnswers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.cboMultiplicationTable)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMultiplicationTable As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkShowAnswers As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label

End Class
