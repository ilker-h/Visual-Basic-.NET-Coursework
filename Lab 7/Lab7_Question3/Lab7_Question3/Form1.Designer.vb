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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblDisplayResult = New System.Windows.Forms.Label()
        Me.lvlInstructions = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblInstructionsAddName = New System.Windows.Forms.Label()
        Me.lblInstructionsAddAddress = New System.Windows.Forms.Label()
        Me.txtAddName = New System.Windows.Forms.TextBox()
        Me.txtAddAddress = New System.Windows.Forms.TextBox()
        Me.lstAddressBook = New System.Windows.Forms.ListBox()
        Me.lstSearchResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(471, 410)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(391, 410)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(75, 150)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUserInput.TabIndex = 9
        '
        'lblDisplayResult
        '
        Me.lblDisplayResult.AutoSize = True
        Me.lblDisplayResult.Location = New System.Drawing.Point(39, 189)
        Me.lblDisplayResult.Name = "lblDisplayResult"
        Me.lblDisplayResult.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayResult.TabIndex = 8
        '
        'lvlInstructions
        '
        Me.lvlInstructions.Location = New System.Drawing.Point(19, 117)
        Me.lvlInstructions.Name = "lvlInstructions"
        Me.lvlInstructions.Size = New System.Drawing.Size(253, 30)
        Me.lvlInstructions.TabIndex = 7
        Me.lvlInstructions.Text = "Enter a phone number of the form (yxx) xxx-xxxx, where 0 <=x<= 9 and 0<y<=9"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(42, 396)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(147, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add to Address Book"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblInstructionsAddName
        '
        Me.lblInstructionsAddName.AutoSize = True
        Me.lblInstructionsAddName.Location = New System.Drawing.Point(39, 9)
        Me.lblInstructionsAddName.Name = "lblInstructionsAddName"
        Me.lblInstructionsAddName.Size = New System.Drawing.Size(58, 13)
        Me.lblInstructionsAddName.TabIndex = 12
        Me.lblInstructionsAddName.Text = "Add name:"
        '
        'lblInstructionsAddAddress
        '
        Me.lblInstructionsAddAddress.AutoSize = True
        Me.lblInstructionsAddAddress.Location = New System.Drawing.Point(19, 65)
        Me.lblInstructionsAddAddress.Name = "lblInstructionsAddAddress"
        Me.lblInstructionsAddAddress.Size = New System.Drawing.Size(69, 13)
        Me.lblInstructionsAddAddress.TabIndex = 13
        Me.lblInstructionsAddAddress.Text = "Add address:"
        '
        'txtAddName
        '
        Me.txtAddName.Location = New System.Drawing.Point(75, 25)
        Me.txtAddName.Name = "txtAddName"
        Me.txtAddName.Size = New System.Drawing.Size(100, 20)
        Me.txtAddName.TabIndex = 14
        '
        'txtAddAddress
        '
        Me.txtAddAddress.Location = New System.Drawing.Point(75, 81)
        Me.txtAddAddress.Name = "txtAddAddress"
        Me.txtAddAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddAddress.TabIndex = 15
        '
        'lstAddressBook
        '
        Me.lstAddressBook.FormattingEnabled = True
        Me.lstAddressBook.Location = New System.Drawing.Point(312, 25)
        Me.lstAddressBook.Name = "lstAddressBook"
        Me.lstAddressBook.Size = New System.Drawing.Size(295, 290)
        Me.lstAddressBook.TabIndex = 16
        '
        'lstSearchResults
        '
        Me.lstSearchResults.FormattingEnabled = True
        Me.lstSearchResults.Location = New System.Drawing.Point(22, 245)
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(250, 121)
        Me.lstSearchResults.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 458)
        Me.Controls.Add(Me.lstSearchResults)
        Me.Controls.Add(Me.lstAddressBook)
        Me.Controls.Add(Me.txtAddAddress)
        Me.Controls.Add(Me.txtAddName)
        Me.Controls.Add(Me.lblInstructionsAddAddress)
        Me.Controls.Add(Me.lblInstructionsAddName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lblDisplayResult)
        Me.Controls.Add(Me.lvlInstructions)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtUserInput As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplayResult As System.Windows.Forms.Label
    Friend WithEvents lvlInstructions As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblInstructionsAddName As System.Windows.Forms.Label
    Friend WithEvents lblInstructionsAddAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddAddress As System.Windows.Forms.TextBox
    Friend WithEvents lstAddressBook As System.Windows.Forms.ListBox
    Friend WithEvents lstSearchResults As System.Windows.Forms.ListBox

End Class
