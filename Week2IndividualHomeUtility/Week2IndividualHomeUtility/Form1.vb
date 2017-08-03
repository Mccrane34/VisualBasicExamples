'University of Phoenix
'POS/408 Home Utility Program
'Additional features added for week four.  Arrays, read, and output to a file
'December 15, 2015
'Version 3
'By: Michael Crane

Imports System.IO

'Declaring variables

Public Class Form1

    Dim outPutFile As StreamWriter
    Dim intCount As Integer = 0
    Dim strInput As String
    Dim PerKiloWattHour As Double
    Dim Watts As Integer
    Dim Hours As Integer
    Dim WattsHourPerDay As Double
    Dim KiloWattsPerDay As Integer
    Dim KiloWattsPerMonth As Double
    Dim OperatingAppliance As Double
    Dim WaterPerLoadTop As Byte = 40
    Dim WaterPerLoadFront As Byte = 25
    Dim CostPerThousand As Double = 5.44
    Dim CostPerLoad As Double

    'Kilowatts hour variable.  The average kilwatts an hour is .10 to .15 cents.  This range will be used for the program

    Private Sub txtBoxAnswer1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxAnswer1.TextChanged
        Try
            PerKiloWattHour = txtBoxAnswer1.Text
            If PerKiloWattHour >= 0.16 Or PerKiloWattHour <= 0.09 Then
                MessageBox.Show("Please enter data n the correct range")
            End If
        Catch ex As InvalidCastException
        End Try

    End Sub

    'The number of hours the user plans to use the appliance.  This variable is entered by the user.  

    Private Sub txtBoxHours_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHours.TextChanged
        Try
            Hours = txtBoxHours.Text
            If Hours > 24 Or Hours < 0 Or Hours < 0.1 Then
                MessageBox.Show("Please enter data from 0 to 24 hours")
            End If
        Catch ex As InvalidCastException
        End Try

    End Sub

    'Calculation of the program.  The program will calculate different values, which are indicated in the list box display.
    'The two landry washers add additional information about water usage.

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try

            WattsHourPerDay = Watts * Hours
            KiloWattsPerDay = WattsHourPerDay / 1000
            KiloWattsPerMonth = KiloWattsPerDay * 30
            OperatingAppliance = KiloWattsPerMonth * PerKiloWattHour
            If radButtonLaudryWasher.Checked = True Then
                CostPerLoad = 40.0 * 5.44 / 1000
            End If
            If radButtonFrontWasher.Checked = True Then
                CostPerLoad = 25.0 * 5.44 / 1000
            End If
            lstBoxDisplay.Items.Add(txtBoxApplianceName.Text + ":  Appliance Chosen")
            lstBoxDisplay.Items.Add(WattsHourPerDay.ToString + ":  Watts-hour per day")
            lstBoxDisplay.Items.Add(KiloWattsPerDay.ToString + ":  Kilowatts per day")
            lstBoxDisplay.Items.Add(KiloWattsPerMonth.ToString + ":  Kilowatts per month")
            lstBoxDisplay.Items.Add(OperatingAppliance.ToString("C") + ":  Cost of operating the appliance per month")
            If radButtonLaudryWasher.Checked = True Then
                lstBoxDisplay.Items.Add(WaterPerLoadTop.ToString + ":  Gallons of water per load")
                lstBoxDisplay.Items.Add(CostPerThousand.ToString + ":  Cost per thouand gallons of water")
                lstBoxDisplay.Items.Add(CostPerLoad.ToString + ":  Cost per gallon per load")
            End If
            If radButtonFrontWasher.Checked = True Then
                lstBoxDisplay.Items.Add(WaterPerLoadFront.ToString + ":  Gallons of water per load")
                lstBoxDisplay.Items.Add(CostPerThousand.ToString + ":  Cost per thousand gallons of water")
                lstBoxDisplay.Items.Add(CostPerLoad.ToString + ":  Cost per gallon per load")
            End If
            lstBoxDisplay.Items.Add(String.Empty)
        Catch ex As InvalidCastException
            MessageBox.Show("Enter data in the correct range")
        End Try


    End Sub

    'Clear button clears the screen of user data.

    Private Sub clrButton_Click(sender As Object, e As EventArgs) Handles clrButton.Click
        txtBoxAnswer1.Text = ""
        txtBoxHours.Text = ""
        txtBoxApplianceName.Text = ""
        radButtonRefrigerator.Checked = False
        radButtonTelevision.Checked = False
        radButtonSpaceHeater.Checked = False
        radButtonFan.Checked = False
        radButtonHairDryer.Checked = False
        radButtonOven.Checked = False
        radButtonLaudryWasher.Checked = False
        radButtonFrontWasher.Checked = False
        comBoxWatts.Text = "Watt value: "
        comBoxTV.Text = "Watt value: "
        comBoxSpaceHeater.Text = "Watts value: "
        comBoxFan.Text = "Watts value: "
        comBoxHairDryer.Text = "Watts value: "
        comBoxOven.Text = "Watts value: "
        comBoxTopWasher.Text = "Watts value: "
        comBoxFrontWasher.Text = "Watts value: "

    End Sub

    'The following are radio buttons for each appliance.  Each button contains the watts of the appliance, the appliance name, 
    'and the two variables that store the data.  This data is displayed in textboxes.  

    Private Sub radButtonRefrigerator_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonRefrigerator.CheckedChanged
        Dim FridgeFile As StreamWriter
        Dim FridgeText As StreamReader

        If radButtonRefrigerator.Checked = True Then
            txtBoxApplianceName.Text = "Refrigerator"
            comBoxWatts.Items.Clear()
            Try
                FridgeFile = File.CreateText("ApplianceFridge.txt")
                FridgeFile.WriteLine(750)
                FridgeFile.WriteLine(550)
                FridgeFile.WriteLine(1000)
                FridgeFile.Close()
                Try
                    FridgeText = File.OpenText("ApplianceFridge.txt")
                    Do Until FridgeText.EndOfStream
                        strInput = FridgeText.ReadLine()
                        comBoxWatts.Items.Add(strInput.ToString)
                    Loop
                    FridgeFile.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try

        End If

    End Sub

    Private Sub radButtonTelevision_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonTelevision.CheckedChanged
        Dim TvFile As StreamWriter
        Dim tvFileText As StreamReader

        If radButtonTelevision.Checked = True Then
            txtBoxApplianceName.Text = "Television"
            comBoxTV.Items.Clear()
            Try
                TvFile = File.CreateText("Television.txt")
                TvFile.WriteLine(150)
                TvFile.WriteLine(200)
                TvFile.WriteLine(250)
                TvFile.Close()
                Try
                    tvFileText = File.OpenText("Television.txt")
                    Do Until tvFileText.EndOfStream
                        strInput = tvFileText.ReadLine()
                        comBoxTV.Items.Add(strInput.ToString)
                    Loop
                    tvFileText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try



        End If
    End Sub

    Private Sub radButtonSpaceHeater_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonSpaceHeater.CheckedChanged
        Dim SpaceHeater As StreamWriter
        Dim SpaceHeaterText As StreamReader

        If radButtonSpaceHeater.Checked = True Then
            txtBoxApplianceName.Text = "Space Heater"
            comBoxSpaceHeater.Items.Clear()
            Try
                SpaceHeater = File.CreateText("SpaceHeater.txt")
                SpaceHeater.WriteLine(300)
                SpaceHeater.WriteLine(400)
                SpaceHeater.WriteLine(500)
                SpaceHeater.Close()
                Try
                    SpaceHeaterText = File.OpenText("SpaceHeater.txt")
                    Do Until SpaceHeaterText.EndOfStream
                        strInput = SpaceHeaterText.ReadLine()
                        comBoxSpaceHeater.Items.Add(strInput.ToString)
                    Loop
                    SpaceHeaterText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try

        End If
    End Sub

    Private Sub radButtonFan_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonFan.CheckedChanged
        Dim Fan As StreamWriter
        Dim FanText As StreamReader

        If radButtonFan.Checked = True Then
            txtBoxApplianceName.Text = "Fan"
            comBoxFan.Items.Clear()
            Try
                Fan = File.CreateText("Fan.txt")
                Fan.WriteLine(100)
                Fan.WriteLine(150)
                Fan.WriteLine(200)
                Fan.Close()
                Try
                    FanText = File.OpenText("Fan.txt")
                    Do Until FanText.EndOfStream
                        strInput = FanText.ReadLine()
                        comBoxFan.Items.Add(strInput.ToString)
                    Loop
                    FanText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try


        End If
    End Sub

    Private Sub radButtonHairDryer_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonHairDryer.CheckedChanged
        Dim HairDryer As StreamWriter
        Dim HairDryerText As StreamReader

        If radButtonHairDryer.Checked = True Then
            txtBoxApplianceName.Text = "Hair Dryer"
            comBoxHairDryer.Items.Clear()
            Try
                HairDryer = File.CreateText("HairDryer.txt")
                HairDryer.WriteLine(1200)
                HairDryer.WriteLine(1300)
                HairDryer.WriteLine(1500)
                HairDryer.Close()
                Try
                    HairDryerText = File.OpenText("HairDryer.txt")
                    Do Until HairDryerText.EndOfStream
                        strInput = HairDryerText.ReadLine()
                        comBoxHairDryer.Items.Add(strInput.ToString)
                    Loop
                    HairDryerText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try

        End If
    End Sub

    Private Sub radButtonOven_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonOven.CheckedChanged
        Dim Oven As StreamWriter
        Dim OvenText As StreamReader

        If radButtonOven.Checked = True Then
            txtBoxApplianceName.Text = "Oven"
            comBoxOven.Items.Clear()
            Try
                Oven = File.CreateText("Oven.txt")
                Oven.WriteLine(500)
                Oven.WriteLine(600)
                Oven.WriteLine(650)
                Oven.Close()
                Try
                    OvenText = File.OpenText("Oven.txt")
                    Do Until OvenText.EndOfStream
                        strInput = OvenText.ReadLine()
                        comBoxOven.Items.Add(strInput.ToString)
                    Loop
                    OvenText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try

        End If
    End Sub

    Private Sub radButtonLaudryWasher_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonLaudryWasher.CheckedChanged
        Dim TopWasher As StreamWriter
        Dim TopWasherText As StreamReader

        If radButtonLaudryWasher.Checked = True Then
            txtBoxApplianceName.Text = "Top-load Washer"
            comBoxTopWasher.Items.Clear()

            Try
                TopWasher = File.CreateText("TopWasher.txt")
                TopWasher.WriteLine(300)
                TopWasher.WriteLine(350)
                TopWasher.WriteLine(400)
                TopWasher.Close()
                Try
                    TopWasherText = File.OpenText("TopWasher.txt")
                    Do Until TopWasherText.EndOfStream
                        strInput = TopWasherText.ReadLine()
                        comBoxTopWasher.Items.Add(strInput.ToString)
                    Loop
                    TopWasherText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try

        End If
    End Sub

    Private Sub radButtonFrontWasher_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonFrontWasher.CheckedChanged
        Dim FrontWasher As StreamWriter
        Dim FrontWasherText As StreamReader

        If radButtonFrontWasher.Checked = True Then
            txtBoxApplianceName.Text = "Front-load Washer"
            comBoxFrontWasher.Items.Clear()

            Try
                FrontWasher = File.CreateText("FrontWasher.txt")
                FrontWasher.WriteLine(300)
                FrontWasher.WriteLine(350)
                FrontWasher.WriteLine(400)
                FrontWasher.Close()
                Try
                    FrontWasherText = File.OpenText("FrontWasher.txt")
                    Do Until FrontWasherText.EndOfStream
                        strInput = FrontWasherText.ReadLine()
                        comBoxFrontWasher.Items.Add(strInput.ToString)
                    Loop
                    FrontWasherText.Close()
                Catch ex As SystemException

                End Try

            Catch ex As SystemException

            End Try

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxWatts.SelectedIndexChanged

        Watts = comBoxWatts.SelectedItem

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            outPutFile = File.AppendText("outPutFile.txt")
            outPutFile.WriteLine(txtBoxApplianceName.Text & ": Appliance Chosen")
            outPutFile.WriteLine(WattsHourPerDay.ToString & ": Watts per day")
            outPutFile.WriteLine(KiloWattsPerDay.ToString & ": Kilowatts per day")
            outPutFile.WriteLine(KiloWattsPerMonth.ToString & ": Kilowatts per month")
            outPutFile.WriteLine(OperatingAppliance.ToString & ": Cost of operating the appliance per month")
            If radButtonLaudryWasher.Checked = True Then
                outPutFile.WriteLine(WaterPerLoadTop.ToString & ": Gallons of water per load")
                outPutFile.WriteLine(CostPerThousand.ToString & ": Cost per thousand gallons of water")
                outPutFile.WriteLine(CostPerLoad.ToString & ": Cost per gallon per load")
            End If
            If radButtonFrontWasher.Checked = True Then
                outPutFile.WriteLine(WaterPerLoadFront.ToString & ": Gallons of water per load")
                outPutFile.WriteLine(CostPerThousand.ToString & ": Cost per thousand gallons of water")
                outPutFile.WriteLine(CostPerLoad.ToString & ": Cost per gallon per load")
            End If
            outPutFile.WriteLine()
            outPutFile.Close()

        Catch ex As SystemException
        End Try


    End Sub

    Private Sub comBoxTV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxTV.SelectedIndexChanged
        Watts = comBoxTV.SelectedItem
    End Sub

    Private Sub comBoxSpaceHeater_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxSpaceHeater.SelectedIndexChanged
        Watts = comBoxSpaceHeater.SelectedItem
    End Sub

    Private Sub comBoxFan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxFan.SelectedIndexChanged
        Watts = comBoxFan.SelectedItem
    End Sub

    Private Sub comBoxHairDryer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxHairDryer.SelectedIndexChanged
        Watts = comBoxHairDryer.SelectedItem
    End Sub

    Private Sub comBoxOven_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxOven.SelectedIndexChanged
        Watts = comBoxOven.SelectedItem
    End Sub

    Private Sub comBoxTopWasher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxTopWasher.SelectedIndexChanged
        Watts = comBoxTopWasher.SelectedItem
    End Sub

    Private Sub comBoxFrontWasher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBoxFrontWasher.SelectedIndexChanged
        Watts = comBoxFrontWasher.SelectedItem
    End Sub
End Class

'End Program




