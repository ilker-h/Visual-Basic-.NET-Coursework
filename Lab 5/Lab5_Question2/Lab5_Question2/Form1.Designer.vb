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
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lvlInstructions = New System.Windows.Forms.Label()
        Me.lblDisplayResult = New System.Windows.Forms.Label()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(25, 215)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(75, 23)
        Me.btnValidate.TabIndex = 0
        Me.btnValidate.Text = "&Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lvlInstructions
        '
        Me.lvlInstructions.Location = New System.Drawing.Point(8, 8)
        Me.lvlInstructions.Name = "lvlInstructions"
        Me.lvlInstructions.Size = New System.Drawing.Size(253, 30)
        Me.lvlInstructions.TabIndex = 1
        Me.lvlInstructions.Text = "Enter a phone number of the form (yxx) xxx-xxxx, where 0 <=x<= 9 and 0<y<=9"
        '
        'lblDisplayResult
        '
        Me.lblDisplayResult.AutoSize = True
        Me.lblDisplayResult.Location = New System.Drawing.Point(61, 129)
        Me.lblDisplayResult.Name = "lblDisplayResult"
        Me.lblDisplayResult.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayResult.TabIndex = 2
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(64, 50)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUserInput.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(106, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
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
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblDisplayResult)
        Me.Controls.Add(Me.lvlInstructions)
        Me.Controls.Add(Me.btnValidate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents lvlInstructions As System.Windows.Forms.Label
    Friend WithEvents lblDisplayResult As System.Windows.Forms.Label
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
