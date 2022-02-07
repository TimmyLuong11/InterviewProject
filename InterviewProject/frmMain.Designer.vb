<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdPrev = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.gbxSupplyVendor = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxState = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCoName = New System.Windows.Forms.TextBox()
        Me.lblCoName = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gbxSupplyVendor.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLoad.Location = New System.Drawing.Point(68, 216)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(55, 24)
        Me.cmdLoad.TabIndex = 14
        Me.cmdLoad.Text = "Load"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(10, 215)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(52, 24)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        '
        'cmdPrev
        '
        Me.cmdPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrev.Location = New System.Drawing.Point(289, 215)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(60, 24)
        Me.cmdPrev.TabIndex = 10
        Me.cmdPrev.Text = "Previous"
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.Location = New System.Drawing.Point(355, 215)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(60, 24)
        Me.cmdNext.TabIndex = 11
        Me.cmdNext.Text = "Next"
        '
        'gbxSupplyVendor
        '
        Me.gbxSupplyVendor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSupplyVendor.Controls.Add(Me.Label3)
        Me.gbxSupplyVendor.Controls.Add(Me.txtPhone)
        Me.gbxSupplyVendor.Controls.Add(Me.txtZip)
        Me.gbxSupplyVendor.Controls.Add(Me.Label2)
        Me.gbxSupplyVendor.Controls.Add(Me.Label1)
        Me.gbxSupplyVendor.Controls.Add(Me.ComboBoxState)
        Me.gbxSupplyVendor.Controls.Add(Me.txtCity)
        Me.gbxSupplyVendor.Controls.Add(Me.txtAddress)
        Me.gbxSupplyVendor.Controls.Add(Me.txtCoName)
        Me.gbxSupplyVendor.Controls.Add(Me.lblCoName)
        Me.gbxSupplyVendor.Controls.Add(Me.lblCity)
        Me.gbxSupplyVendor.Controls.Add(Me.lblAddress)
        Me.gbxSupplyVendor.Location = New System.Drawing.Point(10, 12)
        Me.gbxSupplyVendor.Name = "gbxSupplyVendor"
        Me.gbxSupplyVendor.Size = New System.Drawing.Size(404, 188)
        Me.gbxSupplyVendor.TabIndex = 9
        Me.gbxSupplyVendor.TabStop = False
        Me.gbxSupplyVendor.Text = "Supply Vendors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(96, 147)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(302, 20)
        Me.txtPhone.TabIndex = 19
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(96, 121)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(302, 20)
        Me.txtZip.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Zip Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "State"
        '
        'ComboBoxState
        '
        Me.ComboBoxState.FormattingEnabled = True
        Me.ComboBoxState.Location = New System.Drawing.Point(96, 94)
        Me.ComboBoxState.Name = "ComboBoxState"
        Me.ComboBoxState.Size = New System.Drawing.Size(302, 21)
        Me.ComboBoxState.TabIndex = 15
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.Location = New System.Drawing.Point(96, 68)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(302, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(96, 44)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(302, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtCoName
        '
        Me.txtCoName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCoName.Location = New System.Drawing.Point(96, 20)
        Me.txtCoName.Name = "txtCoName"
        Me.txtCoName.Size = New System.Drawing.Size(302, 20)
        Me.txtCoName.TabIndex = 3
        '
        'lblCoName
        '
        Me.lblCoName.AutoSize = True
        Me.lblCoName.Location = New System.Drawing.Point(11, 24)
        Me.lblCoName.Name = "lblCoName"
        Me.lblCoName.Size = New System.Drawing.Size(85, 13)
        Me.lblCoName.TabIndex = 0
        Me.lblCoName.Text = "Company Name:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(11, 72)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 1
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(11, 48)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        '
        'cmdDetails
        '
        Me.cmdDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDetails.Location = New System.Drawing.Point(183, 216)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(55, 24)
        Me.cmdDetails.TabIndex = 15
        Me.cmdDetails.Text = "Details"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 252)
        Me.Controls.Add(Me.cmdDetails)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.gbxSupplyVendor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Widget Group Company"
        Me.gbxSupplyVendor.ResumeLayout(False)
        Me.gbxSupplyVendor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdPrev As Button
    Friend WithEvents cmdNext As Button
    Friend WithEvents gbxSupplyVendor As GroupBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCoName As TextBox
    Friend WithEvents lblCoName As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxState As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdDetails As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
