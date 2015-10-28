<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberExport
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpPhoto = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.cboPhone = New System.Windows.Forms.ComboBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.grpMemberInfo = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboPrograms = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtmJoined = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mskZip = New System.Windows.Forms.MaskedTextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.grpPhoto.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.grpMemberInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 551)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(500, 17)
        Me.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpPhoto
        '
        Me.grpPhoto.Controls.Add(Me.btnBrowse)
        Me.grpPhoto.Controls.Add(Me.picPhoto)
        Me.grpPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPhoto.ForeColor = System.Drawing.Color.DarkBlue
        Me.grpPhoto.Location = New System.Drawing.Point(24, 238)
        Me.grpPhoto.Name = "grpPhoto"
        Me.grpPhoto.Size = New System.Drawing.Size(311, 250)
        Me.grpPhoto.TabIndex = 17
        Me.grpPhoto.TabStop = False
        Me.grpPhoto.Text = "Member Photo"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(111, 202)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(77, 32)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'picPhoto
        '
        Me.picPhoto.Location = New System.Drawing.Point(68, 26)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(166, 168)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPhoto.TabIndex = 0
        Me.picPhoto.TabStop = False
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.Label12)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.chkNew)
        Me.grpSearch.Controls.Add(Me.cboPhone)
        Me.grpSearch.Controls.Add(Me.cboName)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.ForeColor = System.Drawing.Color.DarkBlue
        Me.grpSearch.Location = New System.Drawing.Point(24, 79)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(312, 153)
        Me.grpSearch.TabIndex = 16
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Find By Phone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Find By Name"
        '
        'chkNew
        '
        Me.chkNew.Location = New System.Drawing.Point(29, 32)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(264, 23)
        Me.chkNew.TabIndex = 21
        Me.chkNew.Text = "Add New Member"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'cboPhone
        '
        Me.cboPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhone.FormattingEnabled = True
        Me.cboPhone.Location = New System.Drawing.Point(139, 113)
        Me.cboPhone.Name = "cboPhone"
        Me.cboPhone.Size = New System.Drawing.Size(155, 24)
        Me.cboPhone.TabIndex = 20
        '
        'cboName
        '
        Me.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(139, 67)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(155, 24)
        Me.cboName.TabIndex = 19
        '
        'grpMemberInfo
        '
        Me.grpMemberInfo.Controls.Add(Me.txtEmail)
        Me.grpMemberInfo.Controls.Add(Me.Label13)
        Me.grpMemberInfo.Controls.Add(Me.cboPrograms)
        Me.grpMemberInfo.Controls.Add(Me.Label10)
        Me.grpMemberInfo.Controls.Add(Me.dtmJoined)
        Me.grpMemberInfo.Controls.Add(Me.Label9)
        Me.grpMemberInfo.Controls.Add(Me.btnClear)
        Me.grpMemberInfo.Controls.Add(Me.btnSave)
        Me.grpMemberInfo.Controls.Add(Me.mskPhone)
        Me.grpMemberInfo.Controls.Add(Me.mskZip)
        Me.grpMemberInfo.Controls.Add(Me.txtState)
        Me.grpMemberInfo.Controls.Add(Me.txtCity)
        Me.grpMemberInfo.Controls.Add(Me.txtAddress)
        Me.grpMemberInfo.Controls.Add(Me.txtFName)
        Me.grpMemberInfo.Controls.Add(Me.txtLName)
        Me.grpMemberInfo.Controls.Add(Me.txtID)
        Me.grpMemberInfo.Controls.Add(Me.Label8)
        Me.grpMemberInfo.Controls.Add(Me.Label7)
        Me.grpMemberInfo.Controls.Add(Me.Label6)
        Me.grpMemberInfo.Controls.Add(Me.Label5)
        Me.grpMemberInfo.Controls.Add(Me.Label4)
        Me.grpMemberInfo.Controls.Add(Me.Label3)
        Me.grpMemberInfo.Controls.Add(Me.Label2)
        Me.grpMemberInfo.Controls.Add(Me.Label1)
        Me.grpMemberInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMemberInfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.grpMemberInfo.Location = New System.Drawing.Point(368, 79)
        Me.grpMemberInfo.Name = "grpMemberInfo"
        Me.grpMemberInfo.Size = New System.Drawing.Size(311, 460)
        Me.grpMemberInfo.TabIndex = 15
        Me.grpMemberInfo.TabStop = False
        Me.grpMemberInfo.Text = "Member Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 357)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(163, 23)
        Me.txtEmail.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(22, 355)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 24)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Email"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPrograms
        '
        Me.cboPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPrograms.FormattingEnabled = True
        Me.cboPrograms.Location = New System.Drawing.Point(115, 390)
        Me.cboPrograms.Name = "cboPrograms"
        Me.cboPrograms.Size = New System.Drawing.Size(163, 24)
        Me.cboPrograms.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(22, 389)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 24)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Program"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtmJoined
        '
        Me.dtmJoined.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmJoined.Location = New System.Drawing.Point(115, 321)
        Me.dtmJoined.Name = "dtmJoined"
        Me.dtmJoined.Size = New System.Drawing.Size(163, 23)
        Me.dtmJoined.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(22, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Date Joined"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(201, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 32)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(115, 422)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 32)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(115, 285)
        Me.mskPhone.Mask = "(999) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(163, 23)
        Me.mskPhone.TabIndex = 17
        '
        'mskZip
        '
        Me.mskZip.Location = New System.Drawing.Point(115, 249)
        Me.mskZip.Mask = "00000-9999"
        Me.mskZip.Name = "mskZip"
        Me.mskZip.Size = New System.Drawing.Size(163, 23)
        Me.mskZip.TabIndex = 16
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(115, 213)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(163, 23)
        Me.txtState.TabIndex = 15
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(115, 177)
        Me.txtCity.MaxLength = 30
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(163, 23)
        Me.txtCity.TabIndex = 14
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 141)
        Me.txtAddress.MaxLength = 40
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(163, 23)
        Me.txtAddress.TabIndex = 13
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(115, 105)
        Me.txtFName.MaxLength = 30
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(163, 23)
        Me.txtFName.TabIndex = 12
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(115, 69)
        Me.txtLName.MaxLength = 30
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(163, 23)
        Me.txtLName.TabIndex = 11
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(115, 33)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(163, 23)
        Me.txtID.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(22, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 24)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Phone"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(22, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Zip"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(22, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "State"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(22, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "City"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(22, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(22, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "First Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Member ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMemberExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 573)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpPhoto)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpMemberInfo)
        Me.Name = "frmMemberExport"
        Me.Text = "Member Information"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpPhoto.ResumeLayout(False)
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpMemberInfo.ResumeLayout(False)
        Me.grpMemberInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grpPhoto As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkNew As System.Windows.Forms.CheckBox
    Friend WithEvents cboPhone As System.Windows.Forms.ComboBox
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents grpMemberInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboPrograms As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtmJoined As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents mskPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
