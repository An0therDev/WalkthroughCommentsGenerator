<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblGenerated = New System.Windows.Forms.Label()
        Me.cbLink = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbTogether = New System.Windows.Forms.RadioButton()
        Me.rbSeparate = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.txtVerified = New System.Windows.Forms.TextBox()
        Me.lblVerified = New System.Windows.Forms.Label()
        Me.txtOtherDetails = New System.Windows.Forms.RichTextBox()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.gbSpecial = New System.Windows.Forms.GroupBox()
        Me.cbVt = New System.Windows.Forms.CheckBox()
        Me.cbRecord = New System.Windows.Forms.CheckBox()
        Me.cbPolling = New System.Windows.Forms.CheckBox()
        Me.cbPlayback = New System.Windows.Forms.CheckBox()
        Me.cbApl = New System.Windows.Forms.CheckBox()
        Me.cbIws = New System.Windows.Forms.CheckBox()
        Me.cbSs = New System.Windows.Forms.CheckBox()
        Me.txtNrp = New System.Windows.Forms.TextBox()
        Me.cbNrp = New System.Windows.Forms.CheckBox()
        Me.lblNrp = New System.Windows.Forms.Label()
        Me.cbLeaderview = New System.Windows.Forms.CheckBox()
        Me.lblLeaderview = New System.Windows.Forms.Label()
        Me.cbCommUsed = New System.Windows.Forms.CheckBox()
        Me.cbComm = New System.Windows.Forms.CheckBox()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.txtFacts = New System.Windows.Forms.TextBox()
        Me.lblFacts = New System.Windows.Forms.Label()
        Me.gbFormat = New System.Windows.Forms.GroupBox()
        Me.rbOpen = New System.Windows.Forms.RadioButton()
        Me.rbMulti = New System.Windows.Forms.RadioButton()
        Me.rbLecture = New System.Windows.Forms.RadioButton()
        Me.rbStandard = New System.Windows.Forms.RadioButton()
        Me.gbReference = New System.Windows.Forms.GroupBox()
        Me.rbOther = New System.Windows.Forms.RadioButton()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.rbDirect = New System.Windows.Forms.RadioButton()
        Me.rbCid = New System.Windows.Forms.RadioButton()
        Me.rbPassword = New System.Windows.Forms.RadioButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblEarly = New System.Windows.Forms.Label()
        Me.cmbEarly = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtCid = New System.Windows.Forms.TextBox()
        Me.lblCid = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbSpecial.SuspendLayout()
        Me.gbFormat.SuspendLayout()
        Me.gbReference.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(363, 762)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.lblGenerated)
        Me.TabPage1.Controls.Add(Me.cbLink)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnGen)
        Me.TabPage1.Controls.Add(Me.txtVerified)
        Me.TabPage1.Controls.Add(Me.lblVerified)
        Me.TabPage1.Controls.Add(Me.txtOtherDetails)
        Me.TabPage1.Controls.Add(Me.lblOther)
        Me.TabPage1.Controls.Add(Me.gbSpecial)
        Me.TabPage1.Controls.Add(Me.txtNrp)
        Me.TabPage1.Controls.Add(Me.cbNrp)
        Me.TabPage1.Controls.Add(Me.lblNrp)
        Me.TabPage1.Controls.Add(Me.cbLeaderview)
        Me.TabPage1.Controls.Add(Me.lblLeaderview)
        Me.TabPage1.Controls.Add(Me.cbCommUsed)
        Me.TabPage1.Controls.Add(Me.cbComm)
        Me.TabPage1.Controls.Add(Me.lblComm)
        Me.TabPage1.Controls.Add(Me.txtFacts)
        Me.TabPage1.Controls.Add(Me.lblFacts)
        Me.TabPage1.Controls.Add(Me.gbFormat)
        Me.TabPage1.Controls.Add(Me.gbReference)
        Me.TabPage1.Controls.Add(Me.lblEarly)
        Me.TabPage1.Controls.Add(Me.cmbEarly)
        Me.TabPage1.Controls.Add(Me.lblTime)
        Me.TabPage1.Controls.Add(Me.txtCid)
        Me.TabPage1.Controls.Add(Me.lblCid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(355, 736)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(355, 736)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblGenerated
        '
        Me.lblGenerated.AutoSize = True
        Me.lblGenerated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerated.ForeColor = System.Drawing.Color.Red
        Me.lblGenerated.Location = New System.Drawing.Point(147, 711)
        Me.lblGenerated.Name = "lblGenerated"
        Me.lblGenerated.Size = New System.Drawing.Size(71, 13)
        Me.lblGenerated.TabIndex = 71
        Me.lblGenerated.Text = "GENERATED"
        Me.lblGenerated.Visible = False
        '
        'cbLink
        '
        Me.cbLink.AutoSize = True
        Me.cbLink.Enabled = False
        Me.cbLink.Location = New System.Drawing.Point(254, 328)
        Me.cbLink.Name = "cbLink"
        Me.cbLink.Size = New System.Drawing.Size(58, 17)
        Me.cbLink.TabIndex = 54
        Me.cbLink.Text = "Linked"
        Me.cbLink.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTogether)
        Me.GroupBox1.Controls.Add(Me.rbSeparate)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 50)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Speaker Lines:"
        '
        'rbTogether
        '
        Me.rbTogether.Location = New System.Drawing.Point(141, 20)
        Me.rbTogether.Name = "rbTogether"
        Me.rbTogether.Size = New System.Drawing.Size(90, 17)
        Me.rbTogether.TabIndex = 4
        Me.rbTogether.Text = "Together"
        Me.rbTogether.UseVisualStyleBackColor = True
        '
        'rbSeparate
        '
        Me.rbSeparate.Location = New System.Drawing.Point(7, 20)
        Me.rbSeparate.Name = "rbSeparate"
        Me.rbSeparate.Size = New System.Drawing.Size(90, 17)
        Me.rbSeparate.TabIndex = 3
        Me.rbSeparate.Text = "Separately"
        Me.rbSeparate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(7, 706)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 67
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGen
        '
        Me.btnGen.Location = New System.Drawing.Point(266, 706)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(75, 23)
        Me.btnGen.TabIndex = 65
        Me.btnGen.Text = "&Generate!"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'txtVerified
        '
        Me.txtVerified.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtVerified.Location = New System.Drawing.Point(83, 666)
        Me.txtVerified.Name = "txtVerified"
        Me.txtVerified.Size = New System.Drawing.Size(255, 23)
        Me.txtVerified.TabIndex = 64
        '
        'lblVerified
        '
        Me.lblVerified.AutoSize = True
        Me.lblVerified.Location = New System.Drawing.Point(7, 669)
        Me.lblVerified.Name = "lblVerified"
        Me.lblVerified.Size = New System.Drawing.Size(70, 13)
        Me.lblVerified.TabIndex = 70
        Me.lblVerified.Text = "Verified With:"
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtOtherDetails.Location = New System.Drawing.Point(10, 555)
        Me.txtOtherDetails.Name = "txtOtherDetails"
        Me.txtOtherDetails.Size = New System.Drawing.Size(331, 96)
        Me.txtOtherDetails.TabIndex = 62
        Me.txtOtherDetails.Text = ""
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(7, 539)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(71, 13)
        Me.lblOther.TabIndex = 69
        Me.lblOther.Text = "Other Details:"
        '
        'gbSpecial
        '
        Me.gbSpecial.Controls.Add(Me.CheckBox7)
        Me.gbSpecial.Controls.Add(Me.CheckBox6)
        Me.gbSpecial.Controls.Add(Me.CheckBox5)
        Me.gbSpecial.Controls.Add(Me.CheckBox4)
        Me.gbSpecial.Controls.Add(Me.CheckBox3)
        Me.gbSpecial.Controls.Add(Me.TextBox2)
        Me.gbSpecial.Controls.Add(Me.CheckBox2)
        Me.gbSpecial.Controls.Add(Me.TextBox1)
        Me.gbSpecial.Controls.Add(Me.CheckBox1)
        Me.gbSpecial.Controls.Add(Me.cbVt)
        Me.gbSpecial.Controls.Add(Me.cbRecord)
        Me.gbSpecial.Controls.Add(Me.cbPolling)
        Me.gbSpecial.Controls.Add(Me.cbPlayback)
        Me.gbSpecial.Controls.Add(Me.cbApl)
        Me.gbSpecial.Controls.Add(Me.cbIws)
        Me.gbSpecial.Controls.Add(Me.cbSs)
        Me.gbSpecial.Location = New System.Drawing.Point(13, 356)
        Me.gbSpecial.Name = "gbSpecial"
        Me.gbSpecial.Size = New System.Drawing.Size(332, 180)
        Me.gbSpecial.TabIndex = 58
        Me.gbSpecial.TabStop = False
        Me.gbSpecial.Text = "Special Features"
        '
        'cbVt
        '
        Me.cbVt.AutoSize = True
        Me.cbVt.Location = New System.Drawing.Point(206, 20)
        Me.cbVt.Name = "cbVt"
        Me.cbVt.Size = New System.Drawing.Size(86, 17)
        Me.cbVt.TabIndex = 31
        Me.cbVt.TabStop = False
        Me.cbVt.Text = "&Voice Talent"
        Me.cbVt.UseVisualStyleBackColor = True
        '
        'cbRecord
        '
        Me.cbRecord.AutoSize = True
        Me.cbRecord.Location = New System.Drawing.Point(206, 43)
        Me.cbRecord.Name = "cbRecord"
        Me.cbRecord.Size = New System.Drawing.Size(124, 17)
        Me.cbRecord.TabIndex = 30
        Me.cbRecord.TabStop = False
        Me.cbRecord.Text = "Backup &Record Line"
        Me.cbRecord.UseVisualStyleBackColor = True
        '
        'cbPolling
        '
        Me.cbPolling.AutoSize = True
        Me.cbPolling.Location = New System.Drawing.Point(109, 43)
        Me.cbPolling.Name = "cbPolling"
        Me.cbPolling.Size = New System.Drawing.Size(57, 17)
        Me.cbPolling.TabIndex = 29
        Me.cbPolling.TabStop = False
        Me.cbPolling.Text = "&Polling"
        Me.cbPolling.UseVisualStyleBackColor = True
        '
        'cbPlayback
        '
        Me.cbPlayback.AutoSize = True
        Me.cbPlayback.Location = New System.Drawing.Point(109, 20)
        Me.cbPlayback.Name = "cbPlayback"
        Me.cbPlayback.Size = New System.Drawing.Size(70, 17)
        Me.cbPlayback.TabIndex = 28
        Me.cbPlayback.TabStop = False
        Me.cbPlayback.Text = "Play&back"
        Me.cbPlayback.UseVisualStyleBackColor = True
        '
        'cbApl
        '
        Me.cbApl.AutoSize = True
        Me.cbApl.Location = New System.Drawing.Point(9, 43)
        Me.cbApl.Name = "cbApl"
        Me.cbApl.Size = New System.Drawing.Size(46, 17)
        Me.cbApl.TabIndex = 26
        Me.cbApl.TabStop = False
        Me.cbApl.Text = "&APL"
        Me.cbApl.UseVisualStyleBackColor = True
        '
        'cbIws
        '
        Me.cbIws.AutoSize = True
        Me.cbIws.Location = New System.Drawing.Point(9, 66)
        Me.cbIws.Name = "cbIws"
        Me.cbIws.Size = New System.Drawing.Size(47, 17)
        Me.cbIws.TabIndex = 27
        Me.cbIws.TabStop = False
        Me.cbIws.Text = "I&WS"
        Me.cbIws.UseVisualStyleBackColor = True
        '
        'cbSs
        '
        Me.cbSs.AutoSize = True
        Me.cbSs.Location = New System.Drawing.Point(9, 20)
        Me.cbSs.Name = "cbSs"
        Me.cbSs.Size = New System.Drawing.Size(91, 17)
        Me.cbSs.TabIndex = 25
        Me.cbSs.TabStop = False
        Me.cbSs.Text = "Special &Script"
        Me.cbSs.UseVisualStyleBackColor = True
        '
        'txtNrp
        '
        Me.txtNrp.Location = New System.Drawing.Point(171, 330)
        Me.txtNrp.Name = "txtNrp"
        Me.txtNrp.Size = New System.Drawing.Size(40, 20)
        Me.txtNrp.TabIndex = 57
        Me.txtNrp.Visible = False
        '
        'cbNrp
        '
        Me.cbNrp.AutoSize = True
        Me.cbNrp.Location = New System.Drawing.Point(110, 332)
        Me.cbNrp.Name = "cbNrp"
        Me.cbNrp.Size = New System.Drawing.Size(44, 17)
        Me.cbNrp.TabIndex = 55
        Me.cbNrp.Text = "Yes"
        Me.cbNrp.UseVisualStyleBackColor = True
        '
        'lblNrp
        '
        Me.lblNrp.AutoSize = True
        Me.lblNrp.Location = New System.Drawing.Point(10, 333)
        Me.lblNrp.Name = "lblNrp"
        Me.lblNrp.Size = New System.Drawing.Size(89, 13)
        Me.lblNrp.TabIndex = 68
        Me.lblNrp.Text = "NRP/Enunciator:"
        '
        'cbLeaderview
        '
        Me.cbLeaderview.AutoSize = True
        Me.cbLeaderview.Location = New System.Drawing.Point(78, 305)
        Me.cbLeaderview.Name = "cbLeaderview"
        Me.cbLeaderview.Size = New System.Drawing.Size(44, 17)
        Me.cbLeaderview.TabIndex = 51
        Me.cbLeaderview.Text = "Yes"
        Me.cbLeaderview.UseVisualStyleBackColor = True
        '
        'lblLeaderview
        '
        Me.lblLeaderview.AutoSize = True
        Me.lblLeaderview.Location = New System.Drawing.Point(10, 306)
        Me.lblLeaderview.Name = "lblLeaderview"
        Me.lblLeaderview.Size = New System.Drawing.Size(66, 13)
        Me.lblLeaderview.TabIndex = 66
        Me.lblLeaderview.Text = "LeaderView:"
        '
        'cbCommUsed
        '
        Me.cbCommUsed.AutoSize = True
        Me.cbCommUsed.Enabled = False
        Me.cbCommUsed.Location = New System.Drawing.Point(254, 305)
        Me.cbCommUsed.Name = "cbCommUsed"
        Me.cbCommUsed.Size = New System.Drawing.Size(51, 17)
        Me.cbCommUsed.TabIndex = 53
        Me.cbCommUsed.Text = "Used"
        Me.cbCommUsed.UseVisualStyleBackColor = True
        '
        'cbComm
        '
        Me.cbComm.AutoSize = True
        Me.cbComm.Location = New System.Drawing.Point(203, 305)
        Me.cbComm.Name = "cbComm"
        Me.cbComm.Size = New System.Drawing.Size(44, 17)
        Me.cbComm.TabIndex = 52
        Me.cbComm.Text = "Yes"
        Me.cbComm.UseVisualStyleBackColor = True
        '
        'lblComm
        '
        Me.lblComm.AutoSize = True
        Me.lblComm.Location = New System.Drawing.Point(137, 306)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(62, 13)
        Me.lblComm.TabIndex = 63
        Me.lblComm.Text = "Comm Line:"
        '
        'txtFacts
        '
        Me.txtFacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtFacts.Location = New System.Drawing.Point(103, 272)
        Me.txtFacts.Name = "txtFacts"
        Me.txtFacts.Size = New System.Drawing.Size(241, 23)
        Me.txtFacts.TabIndex = 50
        '
        'lblFacts
        '
        Me.lblFacts.AutoSize = True
        Me.lblFacts.Location = New System.Drawing.Point(10, 278)
        Me.lblFacts.Name = "lblFacts"
        Me.lblFacts.Size = New System.Drawing.Size(83, 13)
        Me.lblFacts.TabIndex = 61
        Me.lblFacts.Text = "Facts Complete:"
        '
        'gbFormat
        '
        Me.gbFormat.Controls.Add(Me.RadioButton1)
        Me.gbFormat.Controls.Add(Me.rbOpen)
        Me.gbFormat.Controls.Add(Me.rbMulti)
        Me.gbFormat.Controls.Add(Me.rbLecture)
        Me.gbFormat.Controls.Add(Me.rbStandard)
        Me.gbFormat.Location = New System.Drawing.Point(13, 194)
        Me.gbFormat.Name = "gbFormat"
        Me.gbFormat.Size = New System.Drawing.Size(331, 71)
        Me.gbFormat.TabIndex = 49
        Me.gbFormat.TabStop = False
        Me.gbFormat.Text = "Call format:"
        '
        'rbOpen
        '
        Me.rbOpen.AutoSize = True
        Me.rbOpen.Location = New System.Drawing.Point(108, 42)
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Size = New System.Drawing.Size(71, 17)
        Me.rbOpen.TabIndex = 16
        Me.rbOpen.Text = "Open Call"
        Me.rbOpen.UseVisualStyleBackColor = True
        '
        'rbMulti
        '
        Me.rbMulti.AutoSize = True
        Me.rbMulti.Location = New System.Drawing.Point(9, 42)
        Me.rbMulti.Name = "rbMulti"
        Me.rbMulti.Size = New System.Drawing.Size(71, 17)
        Me.rbMulti.TabIndex = 14
        Me.rbMulti.Text = "Multi Q&&A"
        Me.rbMulti.UseVisualStyleBackColor = True
        '
        'rbLecture
        '
        Me.rbLecture.AutoSize = True
        Me.rbLecture.Location = New System.Drawing.Point(108, 19)
        Me.rbLecture.Name = "rbLecture"
        Me.rbLecture.Size = New System.Drawing.Size(67, 17)
        Me.rbLecture.TabIndex = 15
        Me.rbLecture.Text = "Lectured"
        Me.rbLecture.UseVisualStyleBackColor = True
        '
        'rbStandard
        '
        Me.rbStandard.AutoSize = True
        Me.rbStandard.Location = New System.Drawing.Point(9, 19)
        Me.rbStandard.Name = "rbStandard"
        Me.rbStandard.Size = New System.Drawing.Size(92, 17)
        Me.rbStandard.TabIndex = 13
        Me.rbStandard.Text = "Standard Q&&A"
        Me.rbStandard.UseVisualStyleBackColor = True
        '
        'gbReference
        '
        Me.gbReference.Controls.Add(Me.rbOther)
        Me.gbReference.Controls.Add(Me.txtOther)
        Me.gbReference.Controls.Add(Me.rbDirect)
        Me.gbReference.Controls.Add(Me.rbCid)
        Me.gbReference.Controls.Add(Me.rbPassword)
        Me.gbReference.Controls.Add(Me.txtPassword)
        Me.gbReference.Location = New System.Drawing.Point(13, 117)
        Me.gbReference.Name = "gbReference"
        Me.gbReference.Size = New System.Drawing.Size(331, 71)
        Me.gbReference.TabIndex = 48
        Me.gbReference.TabStop = False
        Me.gbReference.Text = "Participants will reference:"
        '
        'rbOther
        '
        Me.rbOther.AutoSize = True
        Me.rbOther.Location = New System.Drawing.Point(108, 42)
        Me.rbOther.Name = "rbOther"
        Me.rbOther.Size = New System.Drawing.Size(51, 17)
        Me.rbOther.TabIndex = 10
        Me.rbOther.Text = "Other"
        Me.rbOther.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(210, 41)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.ReadOnly = True
        Me.txtOther.Size = New System.Drawing.Size(118, 20)
        Me.txtOther.TabIndex = 11
        Me.txtOther.TabStop = False
        '
        'rbDirect
        '
        Me.rbDirect.AutoSize = True
        Me.rbDirect.Location = New System.Drawing.Point(9, 43)
        Me.rbDirect.Name = "rbDirect"
        Me.rbDirect.Size = New System.Drawing.Size(80, 17)
        Me.rbDirect.TabIndex = 7
        Me.rbDirect.Text = "Direct Entry"
        Me.rbDirect.UseVisualStyleBackColor = True
        '
        'rbCid
        '
        Me.rbCid.AutoSize = True
        Me.rbCid.Location = New System.Drawing.Point(9, 19)
        Me.rbCid.Name = "rbCid"
        Me.rbCid.Size = New System.Drawing.Size(94, 17)
        Me.rbCid.TabIndex = 6
        Me.rbCid.Text = "Conference ID"
        Me.rbCid.UseVisualStyleBackColor = True
        '
        'rbPassword
        '
        Me.rbPassword.AutoSize = True
        Me.rbPassword.Location = New System.Drawing.Point(108, 19)
        Me.rbPassword.Name = "rbPassword"
        Me.rbPassword.Size = New System.Drawing.Size(101, 17)
        Me.rbPassword.TabIndex = 8
        Me.rbPassword.Text = "Password\Code"
        Me.rbPassword.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(210, 18)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(118, 20)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.TabStop = False
        '
        'lblEarly
        '
        Me.lblEarly.AutoSize = True
        Me.lblEarly.Location = New System.Drawing.Point(165, 41)
        Me.lblEarly.Name = "lblEarly"
        Me.lblEarly.Size = New System.Drawing.Size(68, 13)
        Me.lblEarly.TabIndex = 60
        Me.lblEarly.Text = "minutes early"
        '
        'cmbEarly
        '
        Me.cmbEarly.FormattingEnabled = True
        Me.cmbEarly.Items.AddRange(New Object() {"5", "10", "15", "30", "45", "60", "75", "90", "105", "120", "135", "150", "165", "180", "195", "210", "225", "240", "255", "270", "285", "300"})
        Me.cmbEarly.Location = New System.Drawing.Point(115, 38)
        Me.cmbEarly.MaxDropDownItems = 5
        Me.cmbEarly.MaxLength = 3
        Me.cmbEarly.Name = "cmbEarly"
        Me.cmbEarly.Size = New System.Drawing.Size(42, 21)
        Me.cmbEarly.TabIndex = 46
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(10, 41)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(102, 13)
        Me.lblTime.TabIndex = 59
        Me.lblTime.Text = "Speakers will dial in:"
        '
        'txtCid
        '
        Me.txtCid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtCid.Location = New System.Drawing.Point(41, 4)
        Me.txtCid.Name = "txtCid"
        Me.txtCid.Size = New System.Drawing.Size(96, 23)
        Me.txtCid.TabIndex = 45
        '
        'lblCid
        '
        Me.lblCid.AutoSize = True
        Me.lblCid.Location = New System.Drawing.Point(10, 10)
        Me.lblCid.Name = "lblCid"
        Me.lblCid.Size = New System.Drawing.Size(28, 13)
        Me.lblCid.TabIndex = 56
        Me.lblCid.Text = "CID:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(190, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.Text = "Lectured to Unlectured"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 118)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Prerecord"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(246, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(81, 20)
        Me.TextBox2.TabIndex = 35
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(179, 118)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox2.TabIndex = 34
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.Text = "Playback"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(109, 66)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox3.TabIndex = 36
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "Entry Tones"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(206, 66)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox4.TabIndex = 37
        Me.CheckBox4.TabStop = False
        Me.CheckBox4.Text = "Exit Tones"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(206, 89)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox5.TabIndex = 38
        Me.CheckBox5.TabStop = False
        Me.CheckBox5.Text = "Announce Parts"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(109, 89)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox6.TabIndex = 39
        Me.CheckBox6.TabStop = False
        Me.CheckBox6.Text = "Transcription"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(9, 89)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox7.TabIndex = 40
        Me.CheckBox7.TabStop = False
        Me.CheckBox7.Text = "Roll Call"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 761)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 800)
        Me.MinimumSize = New System.Drawing.Size(376, 758)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Walkthrough Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbSpecial.ResumeLayout(False)
        Me.gbSpecial.PerformLayout()
        Me.gbFormat.ResumeLayout(False)
        Me.gbFormat.PerformLayout()
        Me.gbReference.ResumeLayout(False)
        Me.gbReference.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblGenerated As Label
    Friend WithEvents cbLink As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbTogether As RadioButton
    Friend WithEvents rbSeparate As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnGen As Button
    Friend WithEvents txtVerified As TextBox
    Friend WithEvents lblVerified As Label
    Friend WithEvents txtOtherDetails As RichTextBox
    Friend WithEvents lblOther As Label
    Friend WithEvents gbSpecial As GroupBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cbVt As CheckBox
    Friend WithEvents cbRecord As CheckBox
    Friend WithEvents cbPolling As CheckBox
    Friend WithEvents cbPlayback As CheckBox
    Friend WithEvents cbApl As CheckBox
    Friend WithEvents cbIws As CheckBox
    Friend WithEvents cbSs As CheckBox
    Friend WithEvents txtNrp As TextBox
    Friend WithEvents cbNrp As CheckBox
    Friend WithEvents lblNrp As Label
    Friend WithEvents cbLeaderview As CheckBox
    Friend WithEvents lblLeaderview As Label
    Friend WithEvents cbCommUsed As CheckBox
    Friend WithEvents cbComm As CheckBox
    Friend WithEvents lblComm As Label
    Friend WithEvents txtFacts As TextBox
    Friend WithEvents lblFacts As Label
    Friend WithEvents gbFormat As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbOpen As RadioButton
    Friend WithEvents rbMulti As RadioButton
    Friend WithEvents rbLecture As RadioButton
    Friend WithEvents rbStandard As RadioButton
    Friend WithEvents gbReference As GroupBox
    Friend WithEvents rbOther As RadioButton
    Friend WithEvents txtOther As TextBox
    Friend WithEvents rbDirect As RadioButton
    Friend WithEvents rbCid As RadioButton
    Friend WithEvents rbPassword As RadioButton
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblEarly As Label
    Friend WithEvents cmbEarly As ComboBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtCid As TextBox
    Friend WithEvents lblCid As Label
    Friend WithEvents TabPage2 As TabPage
End Class
