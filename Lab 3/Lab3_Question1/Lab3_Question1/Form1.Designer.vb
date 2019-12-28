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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkShowAll = New System.Windows.Forms.CheckBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPostedPrice = New System.Windows.Forms.TextBox()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShowAll = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radYellow = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(57, 321)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Location = New System.Drawing.Point(169, 78)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(210, 17)
        Me.chkShowAll.TabIndex = 2
        Me.chkShowAll.Text = "Show Subtotal, HST and Total Amount"
        Me.chkShowAll.UseVisualStyleBackColor = True
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(12, 52)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(139, 52)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'txtPostedPrice
        '
        Me.txtPostedPrice.Location = New System.Drawing.Point(263, 52)
        Me.txtPostedPrice.Name = "txtPostedPrice"
        Me.txtPostedPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPostedPrice.TabIndex = 5
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(253, 108)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(284, 173)
        Me.lstItems.TabIndex = 6
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(25, 24)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(243, 13)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Enter the Item's Name, Quantity and Posted Price:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(277, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShowAll
        '
        Me.lblShowAll.AutoSize = True
        Me.lblShowAll.Location = New System.Drawing.Point(34, 286)
        Me.lblShowAll.Name = "lblShowAll"
        Me.lblShowAll.Size = New System.Drawing.Size(0, 13)
        Me.lblShowAll.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radYellow)
        Me.GroupBox1.Controls.Add(Me.radRed)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sale Type"
        '
        'radYellow
        '
        Me.radYellow.AutoSize = True
        Me.radYellow.Location = New System.Drawing.Point(10, 55)
        Me.radYellow.Name = "radYellow"
        Me.radYellow.Size = New System.Drawing.Size(70, 17)
        Me.radYellow.TabIndex = 1
        Me.radYellow.TabStop = True
        Me.radYellow.Text = "YELLOW"
        Me.radYellow.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(6, 19)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(48, 17)
        Me.radRed.TabIndex = 0
        Me.radRed.TabStop = True
        Me.radRed.Text = "RED"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 365)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblShowAll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.txtPostedPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.chkShowAll)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtPostedPrice As System.Windows.Forms.TextBox
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblShowAll As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radYellow As System.Windows.Forms.RadioButton
    Friend WithEvents radRed As System.Windows.Forms.RadioButton

End Class
