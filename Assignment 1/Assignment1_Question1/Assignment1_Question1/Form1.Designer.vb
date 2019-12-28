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
        Me.lblEnterSeconds = New System.Windows.Forms.Label()
        Me.lblDisplayResults = New System.Windows.Forms.Label()
        Me.txtEnterSeconds = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterSeconds
        '
        Me.lblEnterSeconds.AutoSize = True
        Me.lblEnterSeconds.Location = New System.Drawing.Point(59, 45)
        Me.lblEnterSeconds.Name = "lblEnterSeconds"
        Me.lblEnterSeconds.Size = New System.Drawing.Size(128, 13)
        Me.lblEnterSeconds.TabIndex = 0
        Me.lblEnterSeconds.Text = "Enter number of seconds:"
        '
        'lblDisplayResults
        '
        Me.lblDisplayResults.AutoSize = True
        Me.lblDisplayResults.Location = New System.Drawing.Point(60, 141)
        Me.lblDisplayResults.Name = "lblDisplayResults"
        Me.lblDisplayResults.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayResults.TabIndex = 1
        '
        'txtEnterSeconds
        '
        Me.txtEnterSeconds.Location = New System.Drawing.Point(87, 72)
        Me.txtEnterSeconds.Name = "txtEnterSeconds"
        Me.txtEnterSeconds.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterSeconds.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(125, 201)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(227, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 201)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 29)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 266)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtEnterSeconds)
        Me.Controls.Add(Me.lblDisplayResults)
        Me.Controls.Add(Me.lblEnterSeconds)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterSeconds As System.Windows.Forms.Label
    Friend WithEvents lblDisplayResults As System.Windows.Forms.Label
    Friend WithEvents txtEnterSeconds As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
