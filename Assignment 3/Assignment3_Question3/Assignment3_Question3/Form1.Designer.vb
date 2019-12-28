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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.picDrawing = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(153, 19)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(217, 28)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "&Click to show the drawing:"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'picDrawing
        '
        Me.picDrawing.Location = New System.Drawing.Point(28, 53)
        Me.picDrawing.Name = "picDrawing"
        Me.picDrawing.Size = New System.Drawing.Size(547, 429)
        Me.picDrawing.TabIndex = 3
        Me.picDrawing.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(448, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 494)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picDrawing)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents picDrawing As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
