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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstDisplayPrimeNumbers = New System.Windows.Forms.ListBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(51, 301)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(144, 72)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "&Find Prime Numbers Between m and n"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstDisplayPrimeNumbers
        '
        Me.lstDisplayPrimeNumbers.FormattingEnabled = True
        Me.lstDisplayPrimeNumbers.Location = New System.Drawing.Point(51, 105)
        Me.lstDisplayPrimeNumbers.Name = "lstDisplayPrimeNumbers"
        Me.lstDisplayPrimeNumbers.Size = New System.Drawing.Size(308, 186)
        Me.lstDisplayPrimeNumbers.TabIndex = 2
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(51, 39)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(100, 20)
        Me.txtM.TabIndex = 3
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(214, 39)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(100, 20)
        Me.txtN.TabIndex = 4
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(35, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(279, 13)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Enter positive integers m and n, where m is smaller than n:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(207, 330)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 385)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.lstDisplayPrimeNumbers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFind)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstDisplayPrimeNumbers As System.Windows.Forms.ListBox
    Friend WithEvents txtM As System.Windows.Forms.TextBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
