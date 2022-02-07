Imports System.IO
Imports Newtonsoft.Json

Public Class frmMain

#Region "Private Members"

    Private fobjVendors As CVenders
    Private fobjVen As CVender
    Private fnSelectionID As Integer

#End Region

#Region "Public Methods"

    Public Sub Handler(ByVal DataDirty As Boolean)
        cmdSave.Enabled = DataDirty
    End Sub

#End Region

#Region "Private Methods"

    ''' <summary>
    ''' Creates and assigns bindings to all form fields.
    ''' </summary>
    Private Sub BindControls()
        fobjVen = fobjVendors.Item(fnSelectionID)

        txtCoName.DataBindings.Add("Text", fobjVen, "CompanyName")
        txtAddress.DataBindings.Add("Text", fobjVen, "Address")
        txtCity.DataBindings.Add("Text", fobjVen, "City")

        'Added text to comboBox and textBox
        ComboBoxState.DataBindings.Add("Text", fobjVen, "State")
        txtZip.DataBindings.Add("Text", fobjVen, "ZipCode")
        txtPhone.DataBindings.Add("Text", fobjVen, "PhoneNumber")
        cmdSave.DataBindings.Add("Enabled", fobjVen, "Dirtied")
    End Sub

    ''' <summary>
    ''' Clear all bindings, then calls BindControls
    ''' </summary>
    Private Sub UpdateDataBindings()
        txtCoName.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtCity.DataBindings.Clear()

        'Clear the text box and comboBox
        ComboBoxState.DataBindings.Clear()
        txtZip.DataBindings.Clear()
        txtPhone.DataBindings.Clear()
        cmdSave.DataBindings.Clear()

        BindControls()
    End Sub

    Private Sub TogglePreviousNext()
        cmdNext.Enabled = fnSelectionID < fobjVendors.Count - 1
        cmdPrev.Enabled = fnSelectionID > 0
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Center Form Screen
        MyBase.CenterToScreen()
        Try
            fobjVendors = New CVenders
            fobjVendors.GetVendors()

            'Load the combo box
            ComboBoxState.DataSource = [Enum].GetValues(GetType(EStates))

            fnSelectionID = 0
            UpdateDataBindings()
            TogglePreviousNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Scroll forward through vendor collection and toggle buttons accordingly.
    ''' </summary>
    Private Sub cmdNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Try
            fnSelectionID += 1
            UpdateDataBindings()
            TogglePreviousNext()

            ' Switch to Company Name for editing purposes.
            txtCoName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Scroll back through vendor collection and toggle buttons accordingly.
    ''' </summary>
    Private Sub cmdPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        Try
            fnSelectionID -= 1
            UpdateDataBindings()
            TogglePreviousNext()

            ' Switch to Company Name for editing purposes.
            txtCoName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    ''' <summary>
    ''' Launch save file dialog.
    ''' </summary>
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'List for the save data
        Dim listData As List(Of String) = New List(Of String)
        Try
            'If the save button is enable grab the infomation from the text box and add to a string seperated by commas
            'Added the sting to a list
            'Export the list to a CSV file
            'Disable the button afterwards
            If cmdSave.Enabled = True Then
                Dim csv As New System.Text.StringBuilder

                Dim coName As String = txtCoName.Text
                Dim address As String = txtAddress.Text
                Dim city As String = txtCity.Text
                Dim state As String = ComboBoxState.SelectedIndex
                Dim zipCode As String = txtZip.Text
                Dim phoneNum As String = txtPhone.Text

                Dim newLine As String = String.Format("{0}, {1}, {2}, {3}, {4}, {5}", coName, address, city, state, zipCode, phoneNum)

                csv.AppendLine(newLine)

                listData.Add(csv.ToString)
                For Each item As String In listData
                    File.AppendAllText("VendorData.csv", item)
                    MessageBox.Show("Success")
                Next
                cmdSave.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Launch open file dialog.
    ''' </summary>
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click

        'Added the window file explorer and center to the screeen
        MyBase.CenterToScreen()

        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Method to check the zip code to make sure it is a valid entry
    ''' </summary>
    Private Sub txtZip_TextChanged(sender As Object, e As EventArgs) Handles txtZip.TextChanged
        'If the entry was valid enable the save button if not let the user know
        If IsNumeric(txtZip.Text) Then
            cmdSave.Enabled = True
        Else
            MessageBox.Show("Invalid Zip Code.", "Please try again!")
            RemoveHandler txtZip.TextChanged, AddressOf txtZip_TextChanged
            txtZip.Clear()
            AddHandler txtZip.TextChanged, AddressOf txtZip_TextChanged
        End If
    End Sub

    ''' <summary>
    ''' Method to check the phone number to make sure it is a valid entry
    ''' </summary>
    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        'If the entry was valid enable the save button if not let the user know
        If IsNumeric(txtPhone.Text) Then
            cmdSave.Enabled = True
        Else
            MessageBox.Show("Invalid Phone Number", "Please try again!")
            RemoveHandler txtPhone.TextChanged, AddressOf txtPhone_TextChanged
            txtPhone.Clear()
            AddHandler txtPhone.TextChanged, AddressOf txtPhone_TextChanged
        End If

    End Sub

    ''' <summary>
    ''' Method for the detail button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
        'Pass the information to the detail window and to show the detail window
        frmDetails.detail(txtCoName.Text, txtAddress.Text, txtCity.Text, ComboBoxState.Text, txtZip.Text, txtPhone.Text)
        frmDetails.Show()
    End Sub

    Private Sub ComboBoxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxState.SelectedIndexChanged
        'Enable the save button after the combo box has been changed
        cmdSave.Enabled = True
    End Sub

#End Region

End Class
