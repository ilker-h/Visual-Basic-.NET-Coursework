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
        Me.lblDisplayResults = New System.Windows.Forms.Label()
        Me.btnEstimate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpPickMethod = New System.Windows.Forms.GroupBox()
        Me.radTextFile = New System.Windows.Forms.RadioButton()
        Me.radFunction = New System.Windows.Forms.RadioButton()
        Me.rad2DArray = New System.Windows.Forms.RadioButton()
        Me.rad1DArray = New System.Windows.Forms.RadioButton()
        Me.grpPickMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplayResults
        '
        Me.lblDisplayResults.Location = New System.Drawing.Point(28, 90)
        Me.lblDisplayResults.Name = "lblDisplayResults"
        Me.lblDisplayResults.Size = New System.Drawing.Size(325, 165)
        Me.lblDisplayResults.TabIndex = 0
        '
        'btnEstimate
        '
        Me.btnEstimate.Location = New System.Drawing.Point(12, 271)
        Me.btnEstimate.Name = "btnEstimate"
        Me.btnEstimate.Size = New System.Drawing.Size(75, 23)
        Me.btnEstimate.TabIndex = 1
        Me.btnEstimate.Text = "&Estimate"
        Me.btnEstimate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpPickMethod
        '
        Me.grpPickMethod.Controls.Add(Me.radTextFile)
        Me.grpPickMethod.Controls.Add(Me.radFunction)
        Me.grpPickMethod.Controls.Add(Me.rad2DArray)
        Me.grpPickMethod.Controls.Add(Me.rad1DArray)
        Me.grpPickMethod.Location = New System.Drawing.Point(12, 24)
        Me.grpPickMethod.Name = "grpPickMethod"
        Me.grpPickMethod.Size = New System.Drawing.Size(377, 47)
        Me.grpPickMethod.TabIndex = 4
        Me.grpPickMethod.TabStop = False
        Me.grpPickMethod.Text = "Pick Method:"
        '
        'radTextFile
        '
        Me.radTextFile.AutoSize = True
        Me.radTextFile.Location = New System.Drawing.Point(263, 19)
        Me.radTextFile.Name = "radTextFile"
        Me.radTextFile.Size = New System.Drawing.Size(65, 17)
        Me.radTextFile.TabIndex = 3
        Me.radTextFile.TabStop = True
        Me.radTextFile.Text = "Text File"
        Me.radTextFile.UseVisualStyleBackColor = True
        '
        'radFunction
        '
        Me.radFunction.AutoSize = True
        Me.radFunction.Location = New System.Drawing.Point(166, 19)
        Me.radFunction.Name = "radFunction"
        Me.radFunction.Size = New System.Drawing.Size(66, 17)
        Me.radFunction.TabIndex = 2
        Me.radFunction.TabStop = True
        Me.radFunction.Text = "Function"
        Me.radFunction.UseVisualStyleBackColor = True
        '
        'rad2DArray
        '
        Me.rad2DArray.AutoSize = True
        Me.rad2DArray.Location = New System.Drawing.Point(70, 19)
        Me.rad2DArray.Name = "rad2DArray"
        Me.rad2DArray.Size = New System.Drawing.Size(66, 17)
        Me.rad2DArray.TabIndex = 1
        Me.rad2DArray.TabStop = True
        Me.rad2DArray.Text = "2D Array"
        Me.rad2DArray.UseVisualStyleBackColor = True
        '
        'rad1DArray
        '
        Me.rad1DArray.AutoSize = True
        Me.rad1DArray.Location = New System.Drawing.Point(3, 16)
        Me.rad1DArray.Name = "rad1DArray"
        Me.rad1DArray.Size = New System.Drawing.Size(66, 17)
        Me.rad1DArray.TabIndex = 0
        Me.rad1DArray.TabStop = True
        Me.rad1DArray.Text = "1D Array"
        Me.rad1DArray.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 325)
        Me.Controls.Add(Me.grpPickMethod)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEstimate)
        Me.Controls.Add(Me.lblDisplayResults)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpPickMethod.ResumeLayout(False)
        Me.grpPickMethod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDisplayResults As System.Windows.Forms.Label
    Friend WithEvents btnEstimate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpPickMethod As System.Windows.Forms.GroupBox
    Friend WithEvents radTextFile As System.Windows.Forms.RadioButton
    Friend WithEvents radFunction As System.Windows.Forms.RadioButton
    Friend WithEvents rad2DArray As System.Windows.Forms.RadioButton
    Friend WithEvents rad1DArray As System.Windows.Forms.RadioButton

End Class
