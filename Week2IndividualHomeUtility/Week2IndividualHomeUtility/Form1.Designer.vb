<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitleProgram = New System.Windows.Forms.Label()
        Me.lblKiloWattHour = New System.Windows.Forms.Label()
        Me.txtBoxAnswer1 = New System.Windows.Forms.TextBox()
        Me.lblChooseApplianceTitle = New System.Windows.Forms.Label()
        Me.lblHoursPerDay = New System.Windows.Forms.Label()
        Me.txtBoxHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.clrButton = New System.Windows.Forms.Button()
        Me.lstBoxDisplay = New System.Windows.Forms.ListBox()
        Me.lblDisplayAppliance = New System.Windows.Forms.Label()
        Me.txtBoxApplianceName = New System.Windows.Forms.TextBox()
        Me.radButtonRefrigerator = New System.Windows.Forms.RadioButton()
        Me.radButtonTelevision = New System.Windows.Forms.RadioButton()
        Me.radButtonSpaceHeater = New System.Windows.Forms.RadioButton()
        Me.radButtonFan = New System.Windows.Forms.RadioButton()
        Me.radButtonHairDryer = New System.Windows.Forms.RadioButton()
        Me.radButtonOven = New System.Windows.Forms.RadioButton()
        Me.radButtonLaudryWasher = New System.Windows.Forms.RadioButton()
        Me.radButtonFrontWasher = New System.Windows.Forms.RadioButton()
        Me.comBoxWatts = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.comBoxTV = New System.Windows.Forms.ComboBox()
        Me.comBoxSpaceHeater = New System.Windows.Forms.ComboBox()
        Me.comBoxFan = New System.Windows.Forms.ComboBox()
        Me.comBoxHairDryer = New System.Windows.Forms.ComboBox()
        Me.comBoxOven = New System.Windows.Forms.ComboBox()
        Me.comBoxTopWasher = New System.Windows.Forms.ComboBox()
        Me.comBoxFrontWasher = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblTitleProgram
        '
        Me.lblTitleProgram.AutoSize = True
        Me.lblTitleProgram.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleProgram.Location = New System.Drawing.Point(214, 27)
        Me.lblTitleProgram.Name = "lblTitleProgram"
        Me.lblTitleProgram.Size = New System.Drawing.Size(716, 46)
        Me.lblTitleProgram.TabIndex = 0
        Me.lblTitleProgram.Text = "Home Utility Estimate Program" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblKiloWattHour
        '
        Me.lblKiloWattHour.AutoSize = True
        Me.lblKiloWattHour.Location = New System.Drawing.Point(87, 88)
        Me.lblKiloWattHour.Name = "lblKiloWattHour"
        Me.lblKiloWattHour.Size = New System.Drawing.Size(489, 17)
        Me.lblKiloWattHour.TabIndex = 1
        Me.lblKiloWattHour.Text = "Enter the cost per KiloWatt hour. Current rates range from $.10 - $.15 cents."
        '
        'txtBoxAnswer1
        '
        Me.txtBoxAnswer1.Location = New System.Drawing.Point(582, 83)
        Me.txtBoxAnswer1.Name = "txtBoxAnswer1"
        Me.txtBoxAnswer1.Size = New System.Drawing.Size(100, 22)
        Me.txtBoxAnswer1.TabIndex = 2
        Me.txtBoxAnswer1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblChooseApplianceTitle
        '
        Me.lblChooseApplianceTitle.AutoSize = True
        Me.lblChooseApplianceTitle.Location = New System.Drawing.Point(87, 122)
        Me.lblChooseApplianceTitle.Name = "lblChooseApplianceTitle"
        Me.lblChooseApplianceTitle.Size = New System.Drawing.Size(629, 17)
        Me.lblChooseApplianceTitle.TabIndex = 4
        Me.lblChooseApplianceTitle.Text = "Check the correct box identifying the appliance.  Use the drop down box to chose " &
    "the correct watts." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblHoursPerDay
        '
        Me.lblHoursPerDay.AutoSize = True
        Me.lblHoursPerDay.Location = New System.Drawing.Point(39, 490)
        Me.lblHoursPerDay.Name = "lblHoursPerDay"
        Me.lblHoursPerDay.Size = New System.Drawing.Size(425, 17)
        Me.lblHoursPerDay.TabIndex = 12
        Me.lblHoursPerDay.Text = "Enter the number of hours per day the appliance will be operating." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBoxHours
        '
        Me.txtBoxHours.Location = New System.Drawing.Point(476, 485)
        Me.txtBoxHours.Name = "txtBoxHours"
        Me.txtBoxHours.Size = New System.Drawing.Size(100, 22)
        Me.txtBoxHours.TabIndex = 13
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(814, 122)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(189, 60)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate Appliance Usage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'clrButton
        '
        Me.clrButton.Location = New System.Drawing.Point(928, 234)
        Me.clrButton.Name = "clrButton"
        Me.clrButton.Size = New System.Drawing.Size(75, 60)
        Me.clrButton.TabIndex = 19
        Me.clrButton.Text = "Clear Boxes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.clrButton.UseVisualStyleBackColor = True
        '
        'lstBoxDisplay
        '
        Me.lstBoxDisplay.FormattingEnabled = True
        Me.lstBoxDisplay.ItemHeight = 16
        Me.lstBoxDisplay.Location = New System.Drawing.Point(757, 342)
        Me.lstBoxDisplay.Name = "lstBoxDisplay"
        Me.lstBoxDisplay.Size = New System.Drawing.Size(316, 180)
        Me.lstBoxDisplay.TabIndex = 21
        '
        'lblDisplayAppliance
        '
        Me.lblDisplayAppliance.AutoSize = True
        Me.lblDisplayAppliance.Location = New System.Drawing.Point(39, 447)
        Me.lblDisplayAppliance.Name = "lblDisplayAppliance"
        Me.lblDisplayAppliance.Size = New System.Drawing.Size(166, 17)
        Me.lblDisplayAppliance.TabIndex = 22
        Me.lblDisplayAppliance.Text = "The appliance chosen is:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBoxApplianceName
        '
        Me.txtBoxApplianceName.Location = New System.Drawing.Point(211, 442)
        Me.txtBoxApplianceName.Name = "txtBoxApplianceName"
        Me.txtBoxApplianceName.ReadOnly = True
        Me.txtBoxApplianceName.Size = New System.Drawing.Size(149, 22)
        Me.txtBoxApplianceName.TabIndex = 23
        '
        'radButtonRefrigerator
        '
        Me.radButtonRefrigerator.AutoSize = True
        Me.radButtonRefrigerator.Location = New System.Drawing.Point(42, 240)
        Me.radButtonRefrigerator.Name = "radButtonRefrigerator"
        Me.radButtonRefrigerator.Size = New System.Drawing.Size(105, 21)
        Me.radButtonRefrigerator.TabIndex = 24
        Me.radButtonRefrigerator.TabStop = True
        Me.radButtonRefrigerator.Text = "Refrigerator"
        Me.radButtonRefrigerator.UseVisualStyleBackColor = True
        '
        'radButtonTelevision
        '
        Me.radButtonTelevision.AutoSize = True
        Me.radButtonTelevision.Location = New System.Drawing.Point(42, 318)
        Me.radButtonTelevision.Name = "radButtonTelevision"
        Me.radButtonTelevision.Size = New System.Drawing.Size(93, 21)
        Me.radButtonTelevision.TabIndex = 25
        Me.radButtonTelevision.TabStop = True
        Me.radButtonTelevision.Text = "Television"
        Me.radButtonTelevision.UseVisualStyleBackColor = True
        '
        'radButtonSpaceHeater
        '
        Me.radButtonSpaceHeater.AutoSize = True
        Me.radButtonSpaceHeater.Location = New System.Drawing.Point(411, 240)
        Me.radButtonSpaceHeater.Name = "radButtonSpaceHeater"
        Me.radButtonSpaceHeater.Size = New System.Drawing.Size(116, 21)
        Me.radButtonSpaceHeater.TabIndex = 26
        Me.radButtonSpaceHeater.TabStop = True
        Me.radButtonSpaceHeater.Text = "Space Heater" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radButtonSpaceHeater.UseVisualStyleBackColor = True
        '
        'radButtonFan
        '
        Me.radButtonFan.AutoSize = True
        Me.radButtonFan.Location = New System.Drawing.Point(411, 320)
        Me.radButtonFan.Name = "radButtonFan"
        Me.radButtonFan.Size = New System.Drawing.Size(53, 21)
        Me.radButtonFan.TabIndex = 27
        Me.radButtonFan.TabStop = True
        Me.radButtonFan.Text = "Fan"
        Me.radButtonFan.UseVisualStyleBackColor = True
        '
        'radButtonHairDryer
        '
        Me.radButtonHairDryer.AutoSize = True
        Me.radButtonHairDryer.Location = New System.Drawing.Point(42, 165)
        Me.radButtonHairDryer.Name = "radButtonHairDryer"
        Me.radButtonHairDryer.Size = New System.Drawing.Size(94, 21)
        Me.radButtonHairDryer.TabIndex = 28
        Me.radButtonHairDryer.TabStop = True
        Me.radButtonHairDryer.Text = "Hair Dryer"
        Me.radButtonHairDryer.UseVisualStyleBackColor = True
        '
        'radButtonOven
        '
        Me.radButtonOven.AutoSize = True
        Me.radButtonOven.Location = New System.Drawing.Point(411, 165)
        Me.radButtonOven.Name = "radButtonOven"
        Me.radButtonOven.Size = New System.Drawing.Size(63, 21)
        Me.radButtonOven.TabIndex = 29
        Me.radButtonOven.TabStop = True
        Me.radButtonOven.Text = "Oven"
        Me.radButtonOven.UseVisualStyleBackColor = True
        '
        'radButtonLaudryWasher
        '
        Me.radButtonLaudryWasher.AutoSize = True
        Me.radButtonLaudryWasher.Location = New System.Drawing.Point(42, 388)
        Me.radButtonLaudryWasher.Name = "radButtonLaudryWasher"
        Me.radButtonLaudryWasher.Size = New System.Drawing.Size(139, 21)
        Me.radButtonLaudryWasher.TabIndex = 30
        Me.radButtonLaudryWasher.TabStop = True
        Me.radButtonLaudryWasher.Text = "Top-load Washer"
        Me.radButtonLaudryWasher.UseVisualStyleBackColor = True
        '
        'radButtonFrontWasher
        '
        Me.radButtonFrontWasher.AutoSize = True
        Me.radButtonFrontWasher.Location = New System.Drawing.Point(411, 388)
        Me.radButtonFrontWasher.Name = "radButtonFrontWasher"
        Me.radButtonFrontWasher.Size = New System.Drawing.Size(147, 21)
        Me.radButtonFrontWasher.TabIndex = 31
        Me.radButtonFrontWasher.TabStop = True
        Me.radButtonFrontWasher.Text = "Front-load Washer"
        Me.radButtonFrontWasher.UseVisualStyleBackColor = True
        '
        'comBoxWatts
        '
        Me.comBoxWatts.FormattingEnabled = True
        Me.comBoxWatts.Location = New System.Drawing.Point(188, 239)
        Me.comBoxWatts.Name = "comBoxWatts"
        Me.comBoxWatts.Size = New System.Drawing.Size(162, 24)
        Me.comBoxWatts.TabIndex = 32
        Me.comBoxWatts.Text = "Watt Value:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(814, 234)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 60)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Save "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'comBoxTV
        '
        Me.comBoxTV.FormattingEnabled = True
        Me.comBoxTV.Location = New System.Drawing.Point(188, 317)
        Me.comBoxTV.Name = "comBoxTV"
        Me.comBoxTV.Size = New System.Drawing.Size(162, 24)
        Me.comBoxTV.TabIndex = 34
        Me.comBoxTV.Text = "Watt Value:"
        '
        'comBoxSpaceHeater
        '
        Me.comBoxSpaceHeater.FormattingEnabled = True
        Me.comBoxSpaceHeater.Location = New System.Drawing.Point(582, 234)
        Me.comBoxSpaceHeater.Name = "comBoxSpaceHeater"
        Me.comBoxSpaceHeater.Size = New System.Drawing.Size(162, 24)
        Me.comBoxSpaceHeater.TabIndex = 35
        Me.comBoxSpaceHeater.Text = "Watt Value:"
        '
        'comBoxFan
        '
        Me.comBoxFan.FormattingEnabled = True
        Me.comBoxFan.Location = New System.Drawing.Point(576, 315)
        Me.comBoxFan.Name = "comBoxFan"
        Me.comBoxFan.Size = New System.Drawing.Size(162, 24)
        Me.comBoxFan.TabIndex = 36
        Me.comBoxFan.Text = "Watt Value:"
        '
        'comBoxHairDryer
        '
        Me.comBoxHairDryer.FormattingEnabled = True
        Me.comBoxHairDryer.Location = New System.Drawing.Point(188, 162)
        Me.comBoxHairDryer.Name = "comBoxHairDryer"
        Me.comBoxHairDryer.Size = New System.Drawing.Size(162, 24)
        Me.comBoxHairDryer.TabIndex = 37
        Me.comBoxHairDryer.Text = "Watt Value:"
        '
        'comBoxOven
        '
        Me.comBoxOven.FormattingEnabled = True
        Me.comBoxOven.Location = New System.Drawing.Point(582, 158)
        Me.comBoxOven.Name = "comBoxOven"
        Me.comBoxOven.Size = New System.Drawing.Size(162, 24)
        Me.comBoxOven.TabIndex = 38
        Me.comBoxOven.Text = "Watt Value:"
        '
        'comBoxTopWasher
        '
        Me.comBoxTopWasher.FormattingEnabled = True
        Me.comBoxTopWasher.Location = New System.Drawing.Point(188, 385)
        Me.comBoxTopWasher.Name = "comBoxTopWasher"
        Me.comBoxTopWasher.Size = New System.Drawing.Size(162, 24)
        Me.comBoxTopWasher.TabIndex = 39
        Me.comBoxTopWasher.Text = "Watt Value:"
        '
        'comBoxFrontWasher
        '
        Me.comBoxFrontWasher.FormattingEnabled = True
        Me.comBoxFrontWasher.Location = New System.Drawing.Point(576, 385)
        Me.comBoxFrontWasher.Name = "comBoxFrontWasher"
        Me.comBoxFrontWasher.Size = New System.Drawing.Size(162, 24)
        Me.comBoxFrontWasher.TabIndex = 40
        Me.comBoxFrontWasher.Text = "Watt Value:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 540)
        Me.Controls.Add(Me.comBoxFrontWasher)
        Me.Controls.Add(Me.comBoxTopWasher)
        Me.Controls.Add(Me.comBoxOven)
        Me.Controls.Add(Me.comBoxHairDryer)
        Me.Controls.Add(Me.comBoxFan)
        Me.Controls.Add(Me.comBoxSpaceHeater)
        Me.Controls.Add(Me.comBoxTV)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.comBoxWatts)
        Me.Controls.Add(Me.radButtonFrontWasher)
        Me.Controls.Add(Me.radButtonLaudryWasher)
        Me.Controls.Add(Me.radButtonOven)
        Me.Controls.Add(Me.radButtonHairDryer)
        Me.Controls.Add(Me.radButtonFan)
        Me.Controls.Add(Me.radButtonSpaceHeater)
        Me.Controls.Add(Me.radButtonTelevision)
        Me.Controls.Add(Me.radButtonRefrigerator)
        Me.Controls.Add(Me.txtBoxApplianceName)
        Me.Controls.Add(Me.lblDisplayAppliance)
        Me.Controls.Add(Me.lstBoxDisplay)
        Me.Controls.Add(Me.clrButton)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBoxHours)
        Me.Controls.Add(Me.lblHoursPerDay)
        Me.Controls.Add(Me.lblChooseApplianceTitle)
        Me.Controls.Add(Me.txtBoxAnswer1)
        Me.Controls.Add(Me.lblKiloWattHour)
        Me.Controls.Add(Me.lblTitleProgram)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitleProgram As Label
    Friend WithEvents lblKiloWattHour As Label
    Friend WithEvents txtBoxAnswer1 As TextBox
    Friend WithEvents lblChooseApplianceTitle As Label
    Friend WithEvents lblHoursPerDay As Label
    Friend WithEvents txtBoxHours As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents clrButton As Button
    Friend WithEvents lstBoxDisplay As ListBox
    Friend WithEvents lblDisplayAppliance As Label
    Friend WithEvents txtBoxApplianceName As TextBox
    Friend WithEvents radButtonRefrigerator As RadioButton
    Friend WithEvents radButtonTelevision As RadioButton
    Friend WithEvents radButtonSpaceHeater As RadioButton
    Friend WithEvents radButtonFan As RadioButton
    Friend WithEvents radButtonHairDryer As RadioButton
    Friend WithEvents radButtonOven As RadioButton
    Friend WithEvents radButtonLaudryWasher As RadioButton
    Friend WithEvents radButtonFrontWasher As RadioButton
    Friend WithEvents comBoxWatts As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents comBoxTV As ComboBox
    Friend WithEvents comBoxSpaceHeater As ComboBox
    Friend WithEvents comBoxFan As ComboBox
    Friend WithEvents comBoxHairDryer As ComboBox
    Friend WithEvents comBoxOven As ComboBox
    Friend WithEvents comBoxTopWasher As ComboBox
    Friend WithEvents comBoxFrontWasher As ComboBox
End Class
