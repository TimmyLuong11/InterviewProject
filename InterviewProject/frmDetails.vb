Public Class frmDetails

#Region "Event Handlers"

    ''' <summary>
    ''' Create the Detail from window
    ''' </summary>
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Center the window to the screen
        MyBase.CenterToScreen()

    End Sub

    ''' <summary>
    ''' Method to load the information pass to the lables
    ''' </summary>
    ''' <param name="name">A string representing the company name</param>
    ''' <param name="address">A string representing the company address</param>
    ''' <param name="city">A string representing the company city</param>
    ''' <param name="state">A string representing the company state</param>
    ''' <param name="zip">A string representing the company zip code</param>
    ''' <param name="phone">A string representing the company phone number</param>
    Public Sub detail(ByVal name As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal zip As String, ByVal phone As String)

        'Taking the parameter values and assiging to the respective label
        lblName.Text = name
        lblAddress.Text = address
        lblCity.Text = city
        lblState.Text = state
        lblZipCode.Text = zip
        lblPhoneNum.Text = phone
    End Sub

    ''' <summary>
    ''' Method to close the window when the button is pressed
    ''' </summary>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

End Class