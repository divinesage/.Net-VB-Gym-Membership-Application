<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbProgram = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbShop = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbContact = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbReturn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboPhone = New System.Windows.Forms.ComboBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMemberInfo = New System.Windows.Forms.GroupBox()
        Me.txtProgID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpPhoto = New System.Windows.Forms.GroupBox()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblProgDesc = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpPaymentInfo = New System.Windows.Forms.GroupBox()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.cboExpirationYear = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboExpirationMonth = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mskCardNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.radCreditCard = New System.Windows.Forms.RadioButton()
        Me.grpAmount = New System.Windows.Forms.GroupBox()
        Me.lblOtherTotal = New System.Windows.Forms.Label()
        Me.lblAnnualTotal = New System.Windows.Forms.Label()
        Me.lblMonthTotal = New System.Windows.Forms.Label()
        Me.cboAmtMonthOther = New System.Windows.Forms.ComboBox()
        Me.radOtherAmt = New System.Windows.Forms.RadioButton()
        Me.radAnnualAmt = New System.Windows.Forms.RadioButton()
        Me.radSingleMonthAmt = New System.Windows.Forms.RadioButton()
        Me.grpPaymentSelect = New System.Windows.Forms.GroupBox()
        Me.lblOthrAmt = New System.Windows.Forms.Label()
        Me.lblAnnAmt = New System.Windows.Forms.Label()
        Me.lblOneMnthAmt = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.radMonth = New System.Windows.Forms.RadioButton()
        Me.grpHistory = New System.Windows.Forms.GroupBox()
        Me.lvwMemHistory = New System.Windows.Forms.ListView()
        Me.errProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnStatement = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpSelect.SuspendLayout()
        Me.grpMemberInfo.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpPhoto.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPayment.SuspendLayout()
        Me.grpPaymentInfo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAmount.SuspendLayout()
        Me.grpPaymentSelect.SuspendLayout()
        Me.grpHistory.SuspendLayout()
        CType(Me.errProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbHome, Me.ToolStripSeparator3, Me.tsbMember, Me.ToolStripSeparator4, Me.tsbProgram, Me.ToolStripSeparator2, Me.tsbShop, Me.ToolStripSeparator5, Me.tsbContact, Me.ToolStripSeparator7, Me.ToolStripSeparator6, Me.tsbReturn, Me.ToolStripSeparator8, Me.tsbHelp, Me.ToolStripSeparator9, Me.tsbPayment, Me.ToolStripSeparator10})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1061, 75)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 75)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.VBExerClub.My.Resources.Resources.HomeIcon
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(65, 70)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 75)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.VBExerClub.My.Resources.Resources.MembersIcon
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(65, 70)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 75)
        '
        'tsbProgram
        '
        Me.tsbProgram.AutoSize = False
        Me.tsbProgram.BackgroundImage = Global.VBExerClub.My.Resources.Resources.ProgramIcon
        Me.tsbProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProgram.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProgram.Name = "tsbProgram"
        Me.tsbProgram.Size = New System.Drawing.Size(65, 70)
        Me.tsbProgram.Text = "PROGRAM"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 75)
        '
        'tsbShop
        '
        Me.tsbShop.AutoSize = False
        Me.tsbShop.BackgroundImage = Global.VBExerClub.My.Resources.Resources.ShoppingIcon
        Me.tsbShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbShop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbShop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShop.Name = "tsbShop"
        Me.tsbShop.Size = New System.Drawing.Size(65, 70)
        Me.tsbShop.Text = "SHOP"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 75)
        '
        'tsbContact
        '
        Me.tsbContact.AutoSize = False
        Me.tsbContact.BackgroundImage = Global.VBExerClub.My.Resources.Resources.ContactIconv2_0
        Me.tsbContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContact.Name = "tsbContact"
        Me.tsbContact.Size = New System.Drawing.Size(65, 70)
        Me.tsbContact.Text = "CONTACT"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 75)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 75)
        '
        'tsbReturn
        '
        Me.tsbReturn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbReturn.AutoSize = False
        Me.tsbReturn.BackgroundImage = Global.VBExerClub.My.Resources.Resources._Return
        Me.tsbReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbReturn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReturn.Name = "tsbReturn"
        Me.tsbReturn.Size = New System.Drawing.Size(65, 70)
        Me.tsbReturn.Text = "RETURN"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 75)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.VBExerClub.My.Resources.Resources.HelpIcon
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(65, 70)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 75)
        '
        'tsbPayment
        '
        Me.tsbPayment.AutoSize = False
        Me.tsbPayment.BackgroundImage = Global.VBExerClub.My.Resources.Resources.PaymentIconv2_0
        Me.tsbPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsbPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPayment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPayment.Name = "tsbPayment"
        Me.tsbPayment.Size = New System.Drawing.Size(68, 70)
        Me.tsbPayment.Text = "PAYMENT"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 75)
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.btnSearch)
        Me.grpSelect.Controls.Add(Me.cboSearch)
        Me.grpSelect.Controls.Add(Me.Label14)
        Me.grpSelect.Controls.Add(Me.cboPhone)
        Me.grpSelect.Controls.Add(Me.cboName)
        Me.grpSelect.Controls.Add(Me.Label2)
        Me.grpSelect.Controls.Add(Me.Label1)
        Me.grpSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelect.ForeColor = System.Drawing.Color.White
        Me.grpSelect.Location = New System.Drawing.Point(42, 101)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(349, 187)
        Me.grpSelect.TabIndex = 21
        Me.grpSelect.TabStop = False
        Me.grpSelect.Text = "Select Member"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearch.Location = New System.Drawing.Point(253, 126)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(63, 40)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cboSearch
        '
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(37, 139)
        Me.cboSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSearch.MaxDropDownItems = 5
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(191, 24)
        Me.cboSearch.Sorted = True
        Me.cboSearch.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Search By Last Name"
        '
        'cboPhone
        '
        Me.cboPhone.FormattingEnabled = True
        Me.cboPhone.Location = New System.Drawing.Point(152, 69)
        Me.cboPhone.Name = "cboPhone"
        Me.cboPhone.Size = New System.Drawing.Size(164, 24)
        Me.cboPhone.TabIndex = 2
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(152, 34)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(164, 24)
        Me.cboName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Find by Phone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find by Name:"
        '
        'grpMemberInfo
        '
        Me.grpMemberInfo.Controls.Add(Me.txtProgID)
        Me.grpMemberInfo.Controls.Add(Me.Label10)
        Me.grpMemberInfo.Controls.Add(Me.txtFName)
        Me.grpMemberInfo.Controls.Add(Me.txtLName)
        Me.grpMemberInfo.Controls.Add(Me.txtID)
        Me.grpMemberInfo.Controls.Add(Me.Label3)
        Me.grpMemberInfo.Controls.Add(Me.Label4)
        Me.grpMemberInfo.Controls.Add(Me.Label5)
        Me.grpMemberInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMemberInfo.ForeColor = System.Drawing.Color.White
        Me.grpMemberInfo.Location = New System.Drawing.Point(411, 101)
        Me.grpMemberInfo.Name = "grpMemberInfo"
        Me.grpMemberInfo.Size = New System.Drawing.Size(298, 187)
        Me.grpMemberInfo.TabIndex = 22
        Me.grpMemberInfo.TabStop = False
        Me.grpMemberInfo.Text = "Member Details"
        '
        'txtProgID
        '
        Me.txtProgID.Location = New System.Drawing.Point(114, 140)
        Me.txtProgID.MaxLength = 30
        Me.txtProgID.Name = "txtProgID"
        Me.txtProgID.ReadOnly = True
        Me.txtProgID.Size = New System.Drawing.Size(163, 23)
        Me.txtProgID.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(21, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Program"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(114, 103)
        Me.txtFName.MaxLength = 30
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(163, 23)
        Me.txtFName.TabIndex = 6
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(114, 67)
        Me.txtLName.MaxLength = 30
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(163, 23)
        Me.txtLName.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(114, 31)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(163, 23)
        Me.txtID.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "First Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Last Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Member ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 899)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1061, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.tslStatus.ForeColor = System.Drawing.Color.White
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(500, 17)
        Me.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpPhoto
        '
        Me.grpPhoto.Controls.Add(Me.picPhoto)
        Me.grpPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPhoto.ForeColor = System.Drawing.Color.White
        Me.grpPhoto.Location = New System.Drawing.Point(730, 101)
        Me.grpPhoto.Name = "grpPhoto"
        Me.grpPhoto.Size = New System.Drawing.Size(311, 187)
        Me.grpPhoto.TabIndex = 23
        Me.grpPhoto.TabStop = False
        Me.grpPhoto.Text = "Member Photo"
        '
        'picPhoto
        '
        Me.picPhoto.Location = New System.Drawing.Point(67, 34)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(166, 136)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPhoto.TabIndex = 0
        Me.picPhoto.TabStop = False
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.btnStatement)
        Me.grpPayment.Controls.Add(Me.lblProgDesc)
        Me.grpPayment.Controls.Add(Me.btnClear)
        Me.grpPayment.Controls.Add(Me.btnSubmit)
        Me.grpPayment.Controls.Add(Me.Label9)
        Me.grpPayment.Controls.Add(Me.grpPaymentInfo)
        Me.grpPayment.Controls.Add(Me.grpAmount)
        Me.grpPayment.Controls.Add(Me.grpPaymentSelect)
        Me.grpPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPayment.ForeColor = System.Drawing.Color.White
        Me.grpPayment.Location = New System.Drawing.Point(42, 317)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(999, 360)
        Me.grpPayment.TabIndex = 25
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Make A Payment"
        Me.grpPayment.Visible = False
        '
        'lblProgDesc
        '
        Me.lblProgDesc.Location = New System.Drawing.Point(25, 30)
        Me.lblProgDesc.Name = "lblProgDesc"
        Me.lblProgDesc.Size = New System.Drawing.Size(260, 25)
        Me.lblProgDesc.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(529, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 31)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmit.Location = New System.Drawing.Point(844, 313)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(136, 31)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit Payment"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(308, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(672, 35)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Payment Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpPaymentInfo
        '
        Me.grpPaymentInfo.Controls.Add(Me.radCash)
        Me.grpPaymentInfo.Controls.Add(Me.Label16)
        Me.grpPaymentInfo.Controls.Add(Me.txtFullName)
        Me.grpPaymentInfo.Controls.Add(Me.mskCVV)
        Me.grpPaymentInfo.Controls.Add(Me.cboExpirationYear)
        Me.grpPaymentInfo.Controls.Add(Me.Label15)
        Me.grpPaymentInfo.Controls.Add(Me.cboExpirationMonth)
        Me.grpPaymentInfo.Controls.Add(Me.Label13)
        Me.grpPaymentInfo.Controls.Add(Me.Label12)
        Me.grpPaymentInfo.Controls.Add(Me.mskCardNum)
        Me.grpPaymentInfo.Controls.Add(Me.Label11)
        Me.grpPaymentInfo.Controls.Add(Me.PictureBox5)
        Me.grpPaymentInfo.Controls.Add(Me.PictureBox3)
        Me.grpPaymentInfo.Controls.Add(Me.PictureBox2)
        Me.grpPaymentInfo.Controls.Add(Me.PictureBox1)
        Me.grpPaymentInfo.Controls.Add(Me.radCreditCard)
        Me.grpPaymentInfo.ForeColor = System.Drawing.Color.White
        Me.grpPaymentInfo.Location = New System.Drawing.Point(308, 68)
        Me.grpPaymentInfo.Name = "grpPaymentInfo"
        Me.grpPaymentInfo.Size = New System.Drawing.Size(672, 229)
        Me.grpPaymentInfo.TabIndex = 1
        Me.grpPaymentInfo.TabStop = False
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(380, 24)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(58, 21)
        Me.radCash.TabIndex = 18
        Me.radCash.TabStop = True
        Me.radCash.Text = "Cash"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 17)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Full Name on Card"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(20, 187)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(321, 23)
        Me.txtFullName.TabIndex = 16
        '
        'mskCVV
        '
        Me.mskCVV.Location = New System.Drawing.Point(221, 137)
        Me.mskCVV.Mask = "000"
        Me.mskCVV.Name = "mskCVV"
        Me.mskCVV.Size = New System.Drawing.Size(63, 23)
        Me.mskCVV.TabIndex = 15
        '
        'cboExpirationYear
        '
        Me.cboExpirationYear.FormattingEnabled = True
        Me.cboExpirationYear.Location = New System.Drawing.Point(100, 136)
        Me.cboExpirationYear.Name = "cboExpirationYear"
        Me.cboExpirationYear.Size = New System.Drawing.Size(54, 24)
        Me.cboExpirationYear.TabIndex = 14
        Me.cboExpirationYear.Text = "Year"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(85, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 17)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "/"
        '
        'cboExpirationMonth
        '
        Me.cboExpirationMonth.FormattingEnabled = True
        Me.cboExpirationMonth.Location = New System.Drawing.Point(20, 136)
        Me.cboExpirationMonth.Name = "cboExpirationMonth"
        Me.cboExpirationMonth.Size = New System.Drawing.Size(61, 24)
        Me.cboExpirationMonth.TabIndex = 12
        Me.cboExpirationMonth.Text = "Month"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(218, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "CVV"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Expiration date"
        '
        'mskCardNum
        '
        Me.mskCardNum.Location = New System.Drawing.Point(20, 79)
        Me.mskCardNum.Mask = "0000-0000-0000-0000"
        Me.mskCardNum.Name = "mskCardNum"
        Me.mskCardNum.Size = New System.Drawing.Size(321, 23)
        Me.mskCardNum.TabIndex = 9
        Me.mskCardNum.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Card Number"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(290, 20)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(51, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(233, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(176, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(119, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'radCreditCard
        '
        Me.radCreditCard.AutoSize = True
        Me.radCreditCard.Location = New System.Drawing.Point(20, 27)
        Me.radCreditCard.Name = "radCreditCard"
        Me.radCreditCard.Size = New System.Drawing.Size(97, 21)
        Me.radCreditCard.TabIndex = 0
        Me.radCreditCard.TabStop = True
        Me.radCreditCard.Text = "Credit Card"
        Me.radCreditCard.UseVisualStyleBackColor = True
        '
        'grpAmount
        '
        Me.grpAmount.Controls.Add(Me.lblOtherTotal)
        Me.grpAmount.Controls.Add(Me.lblAnnualTotal)
        Me.grpAmount.Controls.Add(Me.lblMonthTotal)
        Me.grpAmount.Controls.Add(Me.cboAmtMonthOther)
        Me.grpAmount.Controls.Add(Me.radOtherAmt)
        Me.grpAmount.Controls.Add(Me.radAnnualAmt)
        Me.grpAmount.Controls.Add(Me.radSingleMonthAmt)
        Me.grpAmount.ForeColor = System.Drawing.Color.White
        Me.grpAmount.Location = New System.Drawing.Point(24, 68)
        Me.grpAmount.Name = "grpAmount"
        Me.grpAmount.Size = New System.Drawing.Size(261, 229)
        Me.grpAmount.TabIndex = 0
        Me.grpAmount.TabStop = False
        Me.grpAmount.Text = "Amount"
        '
        'lblOtherTotal
        '
        Me.lblOtherTotal.Location = New System.Drawing.Point(143, 172)
        Me.lblOtherTotal.Name = "lblOtherTotal"
        Me.lblOtherTotal.Size = New System.Drawing.Size(100, 19)
        Me.lblOtherTotal.TabIndex = 6
        '
        'lblAnnualTotal
        '
        Me.lblAnnualTotal.Location = New System.Drawing.Point(143, 98)
        Me.lblAnnualTotal.Name = "lblAnnualTotal"
        Me.lblAnnualTotal.Size = New System.Drawing.Size(100, 19)
        Me.lblAnnualTotal.TabIndex = 5
        '
        'lblMonthTotal
        '
        Me.lblMonthTotal.Location = New System.Drawing.Point(143, 51)
        Me.lblMonthTotal.Name = "lblMonthTotal"
        Me.lblMonthTotal.Size = New System.Drawing.Size(100, 19)
        Me.lblMonthTotal.TabIndex = 4
        '
        'cboAmtMonthOther
        '
        Me.cboAmtMonthOther.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAmtMonthOther.FormattingEnabled = True
        Me.cboAmtMonthOther.Location = New System.Drawing.Point(23, 171)
        Me.cboAmtMonthOther.Name = "cboAmtMonthOther"
        Me.cboAmtMonthOther.Size = New System.Drawing.Size(88, 24)
        Me.cboAmtMonthOther.TabIndex = 3
        '
        'radOtherAmt
        '
        Me.radOtherAmt.AutoSize = True
        Me.radOtherAmt.Location = New System.Drawing.Point(23, 139)
        Me.radOtherAmt.Name = "radOtherAmt"
        Me.radOtherAmt.Size = New System.Drawing.Size(62, 21)
        Me.radOtherAmt.TabIndex = 2
        Me.radOtherAmt.TabStop = True
        Me.radOtherAmt.Text = "Other"
        Me.radOtherAmt.UseVisualStyleBackColor = True
        '
        'radAnnualAmt
        '
        Me.radAnnualAmt.AutoSize = True
        Me.radAnnualAmt.Location = New System.Drawing.Point(23, 96)
        Me.radAnnualAmt.Name = "radAnnualAmt"
        Me.radAnnualAmt.Size = New System.Drawing.Size(70, 21)
        Me.radAnnualAmt.TabIndex = 1
        Me.radAnnualAmt.TabStop = True
        Me.radAnnualAmt.Text = "Annual"
        Me.radAnnualAmt.UseVisualStyleBackColor = True
        '
        'radSingleMonthAmt
        '
        Me.radSingleMonthAmt.AutoSize = True
        Me.radSingleMonthAmt.Location = New System.Drawing.Point(23, 49)
        Me.radSingleMonthAmt.Name = "radSingleMonthAmt"
        Me.radSingleMonthAmt.Size = New System.Drawing.Size(65, 21)
        Me.radSingleMonthAmt.TabIndex = 0
        Me.radSingleMonthAmt.TabStop = True
        Me.radSingleMonthAmt.Text = "Month"
        Me.radSingleMonthAmt.UseVisualStyleBackColor = True
        '
        'grpPaymentSelect
        '
        Me.grpPaymentSelect.Controls.Add(Me.lblOthrAmt)
        Me.grpPaymentSelect.Controls.Add(Me.lblAnnAmt)
        Me.grpPaymentSelect.Controls.Add(Me.lblOneMnthAmt)
        Me.grpPaymentSelect.Controls.Add(Me.cboMonths)
        Me.grpPaymentSelect.Controls.Add(Me.RadioButton2)
        Me.grpPaymentSelect.Controls.Add(Me.RadioButton1)
        Me.grpPaymentSelect.Controls.Add(Me.radMonth)
        Me.grpPaymentSelect.Location = New System.Drawing.Point(24, 68)
        Me.grpPaymentSelect.Name = "grpPaymentSelect"
        Me.grpPaymentSelect.Size = New System.Drawing.Size(261, 176)
        Me.grpPaymentSelect.TabIndex = 0
        Me.grpPaymentSelect.TabStop = False
        '
        'lblOthrAmt
        '
        Me.lblOthrAmt.Location = New System.Drawing.Point(125, 142)
        Me.lblOthrAmt.Name = "lblOthrAmt"
        Me.lblOthrAmt.Size = New System.Drawing.Size(100, 19)
        Me.lblOthrAmt.TabIndex = 6
        '
        'lblAnnAmt
        '
        Me.lblAnnAmt.Location = New System.Drawing.Point(125, 69)
        Me.lblAnnAmt.Name = "lblAnnAmt"
        Me.lblAnnAmt.Size = New System.Drawing.Size(100, 19)
        Me.lblAnnAmt.TabIndex = 5
        '
        'lblOneMnthAmt
        '
        Me.lblOneMnthAmt.Location = New System.Drawing.Point(125, 28)
        Me.lblOneMnthAmt.Name = "lblOneMnthAmt"
        Me.lblOneMnthAmt.Size = New System.Drawing.Size(100, 19)
        Me.lblOneMnthAmt.TabIndex = 4
        '
        'cboMonths
        '
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(21, 137)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(88, 24)
        Me.cboMonths.TabIndex = 3
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 108)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 21)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Other"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(21, 67)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 21)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Annual "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'radMonth
        '
        Me.radMonth.AutoSize = True
        Me.radMonth.Location = New System.Drawing.Point(21, 26)
        Me.radMonth.Name = "radMonth"
        Me.radMonth.Size = New System.Drawing.Size(96, 21)
        Me.radMonth.TabIndex = 0
        Me.radMonth.TabStop = True
        Me.radMonth.Text = "One Month"
        Me.radMonth.UseVisualStyleBackColor = True
        '
        'grpHistory
        '
        Me.grpHistory.Controls.Add(Me.lvwMemHistory)
        Me.grpHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHistory.ForeColor = System.Drawing.Color.White
        Me.grpHistory.Location = New System.Drawing.Point(42, 683)
        Me.grpHistory.Name = "grpHistory"
        Me.grpHistory.Size = New System.Drawing.Size(999, 216)
        Me.grpHistory.TabIndex = 26
        Me.grpHistory.TabStop = False
        Me.grpHistory.Text = "Payment History"
        Me.grpHistory.Visible = False
        '
        'lvwMemHistory
        '
        Me.lvwMemHistory.Location = New System.Drawing.Point(6, 22)
        Me.lvwMemHistory.Name = "lvwMemHistory"
        Me.lvwMemHistory.Size = New System.Drawing.Size(987, 188)
        Me.lvwMemHistory.TabIndex = 0
        Me.lvwMemHistory.UseCompatibleStateImageBehavior = False
        Me.lvwMemHistory.View = System.Windows.Forms.View.Details
        '
        'errProv
        '
        Me.errProv.ContainerControl = Me
        '
        'btnStatement
        '
        Me.btnStatement.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStatement.Location = New System.Drawing.Point(688, 313)
        Me.btnStatement.Name = "btnStatement"
        Me.btnStatement.Size = New System.Drawing.Size(136, 31)
        Me.btnStatement.TabIndex = 7
        Me.btnStatement.Text = "Statement"
        Me.btnStatement.UseVisualStyleBackColor = False
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1078, 750)
        Me.Controls.Add(Me.grpHistory)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpPhoto)
        Me.Controls.Add(Me.grpMemberInfo)
        Me.Controls.Add(Me.grpSelect)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Members Payment"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.grpMemberInfo.ResumeLayout(False)
        Me.grpMemberInfo.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpPhoto.ResumeLayout(False)
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPaymentInfo.ResumeLayout(False)
        Me.grpPaymentInfo.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAmount.ResumeLayout(False)
        Me.grpAmount.PerformLayout()
        Me.grpPaymentSelect.ResumeLayout(False)
        Me.grpPaymentSelect.PerformLayout()
        Me.grpHistory.ResumeLayout(False)
        CType(Me.errProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbMember As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbProgram As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbShop As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbContact As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbReturn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpSelect As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPhone As System.Windows.Forms.ComboBox
    Friend WithEvents cboName As System.Windows.Forms.ComboBox
    Friend WithEvents grpMemberInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grpPhoto As System.Windows.Forms.GroupBox
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents grpPaymentSelect As System.Windows.Forms.GroupBox
    Friend WithEvents cboMonths As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents radMonth As System.Windows.Forms.RadioButton
    Friend WithEvents lblAnnAmt As System.Windows.Forms.Label
    Friend WithEvents lblOneMnthAmt As System.Windows.Forms.Label
    Friend WithEvents lblOthrAmt As System.Windows.Forms.Label
    Friend WithEvents grpAmount As System.Windows.Forms.GroupBox
    Friend WithEvents lblOtherTotal As System.Windows.Forms.Label
    Friend WithEvents lblAnnualTotal As System.Windows.Forms.Label
    Friend WithEvents lblMonthTotal As System.Windows.Forms.Label
    Friend WithEvents cboAmtMonthOther As System.Windows.Forms.ComboBox
    Friend WithEvents radOtherAmt As System.Windows.Forms.RadioButton
    Friend WithEvents radAnnualAmt As System.Windows.Forms.RadioButton
    Friend WithEvents radSingleMonthAmt As System.Windows.Forms.RadioButton
    Friend WithEvents grpHistory As System.Windows.Forms.GroupBox
    Friend WithEvents grpPaymentInfo As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents radCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mskCardNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboExpirationYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboExpirationMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mskCVV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents radCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtProgID As System.Windows.Forms.TextBox
    Friend WithEvents lblProgDesc As System.Windows.Forms.Label
    Friend WithEvents errProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents lvwMemHistory As System.Windows.Forms.ListView
    Friend WithEvents btnStatement As System.Windows.Forms.Button
End Class
