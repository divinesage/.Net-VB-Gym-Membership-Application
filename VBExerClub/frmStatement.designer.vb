<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatement))
        Me.lvwStatement = New System.Windows.Forms.ListView()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.grpMemberInfo = New System.Windows.Forms.GroupBox()
        Me.lblDateJ = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpMemberInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvwStatement
        '
        Me.lvwStatement.Location = New System.Drawing.Point(38, 345)
        Me.lvwStatement.Margin = New System.Windows.Forms.Padding(2)
        Me.lvwStatement.Name = "lvwStatement"
        Me.lvwStatement.Size = New System.Drawing.Size(622, 155)
        Me.lvwStatement.TabIndex = 0
        Me.lvwStatement.UseCompatibleStateImageBehavior = False
        Me.lvwStatement.View = System.Windows.Forms.View.Details
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(549, 506)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(110, 25)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'grpMemberInfo
        '
        Me.grpMemberInfo.Controls.Add(Me.lblDateJ)
        Me.grpMemberInfo.Controls.Add(Me.lblEmail)
        Me.grpMemberInfo.Controls.Add(Me.lblName)
        Me.grpMemberInfo.Controls.Add(Me.lblId)
        Me.grpMemberInfo.Controls.Add(Me.Label4)
        Me.grpMemberInfo.Controls.Add(Me.Label3)
        Me.grpMemberInfo.Controls.Add(Me.Label2)
        Me.grpMemberInfo.Controls.Add(Me.Label1)
        Me.grpMemberInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMemberInfo.ForeColor = System.Drawing.Color.White
        Me.grpMemberInfo.Location = New System.Drawing.Point(360, 110)
        Me.grpMemberInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.grpMemberInfo.Name = "grpMemberInfo"
        Me.grpMemberInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.grpMemberInfo.Size = New System.Drawing.Size(297, 143)
        Me.grpMemberInfo.TabIndex = 2
        Me.grpMemberInfo.TabStop = False
        Me.grpMemberInfo.Text = "Member"
        '
        'lblDateJ
        '
        Me.lblDateJ.Location = New System.Drawing.Point(109, 111)
        Me.lblDateJ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDateJ.Name = "lblDateJ"
        Me.lblDateJ.Size = New System.Drawing.Size(166, 18)
        Me.lblDateJ.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(109, 82)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(166, 18)
        Me.lblEmail.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(109, 53)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(166, 18)
        Me.lblName.TabIndex = 5
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(109, 25)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(166, 18)
        Me.lblId.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Joined: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBExerClub.My.Resources.Resources.LOGOStatement
        Me.PictureBox1.Location = New System.Drawing.Point(38, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 332)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(352, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(314, 45)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Member Statement"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(703, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpMemberInfo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lvwStatement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Member Statement"
        Me.grpMemberInfo.ResumeLayout(False)
        Me.grpMemberInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwStatement As System.Windows.Forms.ListView
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents grpMemberInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblDateJ As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
