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
        Me.lblInstructionsInputMassPlanet = New System.Windows.Forms.Label()
        Me.txtInputMassPlanet = New System.Windows.Forms.TextBox()
        Me.txtInputMassObject = New System.Windows.Forms.TextBox()
        Me.grpDistanceBetweenPlanetAndObject = New System.Windows.Forms.GroupBox()
        Me.rad500Above = New System.Windows.Forms.RadioButton()
        Me.rad100Above = New System.Windows.Forms.RadioButton()
        Me.radOnPlanet = New System.Windows.Forms.RadioButton()
        Me.lblInstructionsInputMassObject = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResultWeight = New System.Windows.Forms.Label()
        Me.lblDisplayPlanetMass = New System.Windows.Forms.Label()
        Me.lblDisplayObjectMass = New System.Windows.Forms.Label()
        Me.grpDistanceBetweenPlanetAndObject.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstructionsInputMassPlanet
        '
        Me.lblInstructionsInputMassPlanet.AutoSize = True
        Me.lblInstructionsInputMassPlanet.Location = New System.Drawing.Point(29, 18)
        Me.lblInstructionsInputMassPlanet.Name = "lblInstructionsInputMassPlanet"
        Me.lblInstructionsInputMassPlanet.Size = New System.Drawing.Size(128, 13)
        Me.lblInstructionsInputMassPlanet.TabIndex = 0
        Me.lblInstructionsInputMassPlanet.Text = "Input Mass of Planet (kg):"
        '
        'txtInputMassPlanet
        '
        Me.txtInputMassPlanet.Location = New System.Drawing.Point(38, 43)
        Me.txtInputMassPlanet.Name = "txtInputMassPlanet"
        Me.txtInputMassPlanet.Size = New System.Drawing.Size(293, 20)
        Me.txtInputMassPlanet.TabIndex = 1
        '
        'txtInputMassObject
        '
        Me.txtInputMassObject.Location = New System.Drawing.Point(433, 43)
        Me.txtInputMassObject.Name = "txtInputMassObject"
        Me.txtInputMassObject.Size = New System.Drawing.Size(260, 20)
        Me.txtInputMassObject.TabIndex = 2
        '
        'grpDistanceBetweenPlanetAndObject
        '
        Me.grpDistanceBetweenPlanetAndObject.Controls.Add(Me.rad500Above)
        Me.grpDistanceBetweenPlanetAndObject.Controls.Add(Me.rad100Above)
        Me.grpDistanceBetweenPlanetAndObject.Controls.Add(Me.radOnPlanet)
        Me.grpDistanceBetweenPlanetAndObject.Location = New System.Drawing.Point(32, 108)
        Me.grpDistanceBetweenPlanetAndObject.Name = "grpDistanceBetweenPlanetAndObject"
        Me.grpDistanceBetweenPlanetAndObject.Size = New System.Drawing.Size(407, 100)
        Me.grpDistanceBetweenPlanetAndObject.TabIndex = 3
        Me.grpDistanceBetweenPlanetAndObject.TabStop = False
        Me.grpDistanceBetweenPlanetAndObject.Text = "Where is the center of the object?"
        '
        'rad500Above
        '
        Me.rad500Above.AutoSize = True
        Me.rad500Above.Location = New System.Drawing.Point(259, 36)
        Me.rad500Above.Name = "rad500Above"
        Me.rad500Above.Size = New System.Drawing.Size(127, 17)
        Me.rad500Above.TabIndex = 2
        Me.rad500Above.TabStop = True
        Me.rad500Above.Text = "500 km Above Planet"
        Me.rad500Above.UseVisualStyleBackColor = True
        '
        'rad100Above
        '
        Me.rad100Above.AutoSize = True
        Me.rad100Above.Location = New System.Drawing.Point(112, 36)
        Me.rad100Above.Name = "rad100Above"
        Me.rad100Above.Size = New System.Drawing.Size(127, 17)
        Me.rad100Above.TabIndex = 1
        Me.rad100Above.TabStop = True
        Me.rad100Above.Text = "100 km Above Planet"
        Me.rad100Above.UseVisualStyleBackColor = True
        '
        'radOnPlanet
        '
        Me.radOnPlanet.AutoSize = True
        Me.radOnPlanet.Location = New System.Drawing.Point(21, 36)
        Me.radOnPlanet.Name = "radOnPlanet"
        Me.radOnPlanet.Size = New System.Drawing.Size(72, 17)
        Me.radOnPlanet.TabIndex = 0
        Me.radOnPlanet.TabStop = True
        Me.radOnPlanet.Text = "On Planet"
        Me.radOnPlanet.UseVisualStyleBackColor = True
        '
        'lblInstructionsInputMassObject
        '
        Me.lblInstructionsInputMassObject.AutoSize = True
        Me.lblInstructionsInputMassObject.Location = New System.Drawing.Point(430, 18)
        Me.lblInstructionsInputMassObject.Name = "lblInstructionsInputMassObject"
        Me.lblInstructionsInputMassObject.Size = New System.Drawing.Size(129, 13)
        Me.lblInstructionsInputMassObject.TabIndex = 4
        Me.lblInstructionsInputMassObject.Text = "Input Mass of Object (kg):"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(63, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 40)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate Weight of Object (kg)"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(264, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResultWeight
        '
        Me.lblResultWeight.AutoSize = True
        Me.lblResultWeight.Location = New System.Drawing.Point(50, 297)
        Me.lblResultWeight.Name = "lblResultWeight"
        Me.lblResultWeight.Size = New System.Drawing.Size(0, 13)
        Me.lblResultWeight.TabIndex = 7
        '
        'lblDisplayPlanetMass
        '
        Me.lblDisplayPlanetMass.AutoSize = True
        Me.lblDisplayPlanetMass.Location = New System.Drawing.Point(261, 297)
        Me.lblDisplayPlanetMass.Name = "lblDisplayPlanetMass"
        Me.lblDisplayPlanetMass.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayPlanetMass.TabIndex = 8
        '
        'lblDisplayObjectMass
        '
        Me.lblDisplayObjectMass.AutoSize = True
        Me.lblDisplayObjectMass.Location = New System.Drawing.Point(439, 297)
        Me.lblDisplayObjectMass.Name = "lblDisplayObjectMass"
        Me.lblDisplayObjectMass.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayObjectMass.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 366)
        Me.Controls.Add(Me.lblDisplayObjectMass)
        Me.Controls.Add(Me.lblDisplayPlanetMass)
        Me.Controls.Add(Me.lblResultWeight)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructionsInputMassObject)
        Me.Controls.Add(Me.grpDistanceBetweenPlanetAndObject)
        Me.Controls.Add(Me.txtInputMassObject)
        Me.Controls.Add(Me.txtInputMassPlanet)
        Me.Controls.Add(Me.lblInstructionsInputMassPlanet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpDistanceBetweenPlanetAndObject.ResumeLayout(False)
        Me.grpDistanceBetweenPlanetAndObject.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructionsInputMassPlanet As System.Windows.Forms.Label
    Friend WithEvents txtInputMassPlanet As System.Windows.Forms.TextBox
    Friend WithEvents txtInputMassObject As System.Windows.Forms.TextBox
    Friend WithEvents grpDistanceBetweenPlanetAndObject As System.Windows.Forms.GroupBox
    Friend WithEvents rad500Above As System.Windows.Forms.RadioButton
    Friend WithEvents rad100Above As System.Windows.Forms.RadioButton
    Friend WithEvents radOnPlanet As System.Windows.Forms.RadioButton
    Friend WithEvents lblInstructionsInputMassObject As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResultWeight As System.Windows.Forms.Label
    Friend WithEvents lblDisplayPlanetMass As System.Windows.Forms.Label
    Friend WithEvents lblDisplayObjectMass As System.Windows.Forms.Label

End Class
