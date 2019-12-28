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
        Me.txtInputDiameter = New System.Windows.Forms.TextBox()
        Me.txtInputHeight = New System.Windows.Forms.TextBox()
        Me.txtInputDepth = New System.Windows.Forms.TextBox()
        Me.txtInputSheetThickness = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblDiameter = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.lblSheetThickness = New System.Windows.Forms.Label()
        Me.lblTotalWork = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInputDiameter
        '
        Me.txtInputDiameter.Location = New System.Drawing.Point(11, 72)
        Me.txtInputDiameter.Name = "txtInputDiameter"
        Me.txtInputDiameter.Size = New System.Drawing.Size(100, 20)
        Me.txtInputDiameter.TabIndex = 0
        '
        'txtInputHeight
        '
        Me.txtInputHeight.Location = New System.Drawing.Point(117, 72)
        Me.txtInputHeight.Name = "txtInputHeight"
        Me.txtInputHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtInputHeight.TabIndex = 1
        '
        'txtInputDepth
        '
        Me.txtInputDepth.Location = New System.Drawing.Point(233, 72)
        Me.txtInputDepth.Name = "txtInputDepth"
        Me.txtInputDepth.Size = New System.Drawing.Size(100, 20)
        Me.txtInputDepth.TabIndex = 2
        '
        'txtInputSheetThickness
        '
        Me.txtInputSheetThickness.Location = New System.Drawing.Point(352, 72)
        Me.txtInputSheetThickness.Name = "txtInputSheetThickness"
        Me.txtInputSheetThickness.Size = New System.Drawing.Size(100, 20)
        Me.txtInputSheetThickness.TabIndex = 3
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 41)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(490, 13)
        Me.lblInstructions.TabIndex = 4
        Me.lblInstructions.Text = "Input diameter of conical tank (m) , height of tank (m), depth of oil in tank (m)" & _
    ", thickness of oil sheet (m):"
        '
        'lblDiameter
        '
        Me.lblDiameter.AutoSize = True
        Me.lblDiameter.Location = New System.Drawing.Point(48, 158)
        Me.lblDiameter.Name = "lblDiameter"
        Me.lblDiameter.Size = New System.Drawing.Size(0, 13)
        Me.lblDiameter.TabIndex = 5
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(48, 180)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(0, 13)
        Me.lblHeight.TabIndex = 6
        '
        'lblDepth
        '
        Me.lblDepth.AutoSize = True
        Me.lblDepth.Location = New System.Drawing.Point(48, 204)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(0, 13)
        Me.lblDepth.TabIndex = 7
        '
        'lblSheetThickness
        '
        Me.lblSheetThickness.AutoSize = True
        Me.lblSheetThickness.Location = New System.Drawing.Point(48, 226)
        Me.lblSheetThickness.Name = "lblSheetThickness"
        Me.lblSheetThickness.Size = New System.Drawing.Size(0, 13)
        Me.lblSheetThickness.TabIndex = 8
        '
        'lblTotalWork
        '
        Me.lblTotalWork.AutoSize = True
        Me.lblTotalWork.Location = New System.Drawing.Point(48, 250)
        Me.lblTotalWork.Name = "lblTotalWork"
        Me.lblTotalWork.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalWork.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(64, 310)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(84, 46)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate Total Work"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(233, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Cle&ar"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 380)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalWork)
        Me.Controls.Add(Me.lblSheetThickness)
        Me.Controls.Add(Me.lblDepth)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblDiameter)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtInputSheetThickness)
        Me.Controls.Add(Me.txtInputDepth)
        Me.Controls.Add(Me.txtInputHeight)
        Me.Controls.Add(Me.txtInputDiameter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInputDiameter As System.Windows.Forms.TextBox
    Friend WithEvents txtInputHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtInputDepth As System.Windows.Forms.TextBox
    Friend WithEvents txtInputSheetThickness As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblDiameter As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblDepth As System.Windows.Forms.Label
    Friend WithEvents lblSheetThickness As System.Windows.Forms.Label
    Friend WithEvents lblTotalWork As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
