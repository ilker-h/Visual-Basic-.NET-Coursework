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
        Me.txtInputA = New System.Windows.Forms.TextBox()
        Me.txtInputLKnot = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMaterialsList = New System.Windows.Forms.ListBox()
        Me.txtInputDeltaL = New System.Windows.Forms.TextBox()
        Me.lblDisplayResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInputA
        '
        Me.txtInputA.Location = New System.Drawing.Point(12, 63)
        Me.txtInputA.Name = "txtInputA"
        Me.txtInputA.Size = New System.Drawing.Size(100, 20)
        Me.txtInputA.TabIndex = 0
        '
        'txtInputLKnot
        '
        Me.txtInputLKnot.Location = New System.Drawing.Point(146, 63)
        Me.txtInputLKnot.Name = "txtInputLKnot"
        Me.txtInputLKnot.Size = New System.Drawing.Size(100, 20)
        Me.txtInputLKnot.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(25, 272)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(128, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Cle&ar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter A (m^2), L knot (m), and delta L (m):"
        '
        'lstMaterialsList
        '
        Me.lstMaterialsList.FormattingEnabled = True
        Me.lstMaterialsList.Location = New System.Drawing.Point(126, 102)
        Me.lstMaterialsList.Name = "lstMaterialsList"
        Me.lstMaterialsList.Size = New System.Drawing.Size(120, 95)
        Me.lstMaterialsList.TabIndex = 9
        '
        'txtInputDeltaL
        '
        Me.txtInputDeltaL.Location = New System.Drawing.Point(279, 63)
        Me.txtInputDeltaL.Name = "txtInputDeltaL"
        Me.txtInputDeltaL.Size = New System.Drawing.Size(100, 20)
        Me.txtInputDeltaL.TabIndex = 2
        '
        'lblDisplayResults
        '
        Me.lblDisplayResults.AutoSize = True
        Me.lblDisplayResults.Location = New System.Drawing.Point(22, 225)
        Me.lblDisplayResults.Name = "lblDisplayResults"
        Me.lblDisplayResults.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayResults.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 307)
        Me.Controls.Add(Me.lblDisplayResults)
        Me.Controls.Add(Me.lstMaterialsList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInputDeltaL)
        Me.Controls.Add(Me.txtInputLKnot)
        Me.Controls.Add(Me.txtInputA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputA As System.Windows.Forms.TextBox
    Friend WithEvents txtInputLKnot As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMaterialsList As System.Windows.Forms.ListBox
    Friend WithEvents txtInputDeltaL As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplayResults As System.Windows.Forms.Label

End Class
