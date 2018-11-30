Imports System.IO

Public Class frmMain
    'Reset form on load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        resetForm()

    End Sub

    'Toggle Form Textbox For Other Entry
    Private Sub rbOther_CheckedChanged(sender As Object, e As EventArgs) 
        If rbOther.Checked Then
            'Enable Textbox
            txtOther.ReadOnly = False
        Else
            'Reset if not selected
            txtOther.Text = "".ToString()
            txtOther.ReadOnly = True
        End If
    End Sub

    'Toggle Form Textbox For Password
    Private Sub rbPassword_CheckedChanged(sender As Object, e As EventArgs) 
        If rbPassword.Checked Then
            'Enable Textbox
            txtPassword.ReadOnly = False
        Else
            'Reset if not selected
            txtPassword.Text = "".ToString()
            txtPassword.ReadOnly = True
        End If
    End Sub

    'Force Selection of Comm Line when LeaderView is selected
    Private Sub cbLeaderview_CheckedChanged(sender As Object, e As EventArgs) 
        If cbComm.Checked Then
            cbCommUsed.Enabled = True
        End If
        If cbLeaderview.Checked Then
            'Check and Disable Comm Line
            cbComm.CheckState = CheckState.Checked
            cbComm.Enabled = False
        Else
            'Enable and Clear Comm Line
            cbComm.Enabled = True
            cbComm.CheckState = CheckState.Unchecked
        End If

    End Sub

    'When Comm combo box changes state: Toggle CommUsed checkbox
    Private Sub cbComm_CheckedChanged(sender As Object, e As EventArgs) 
        If cbComm.Checked And cbLeaderview.Checked Then
            cbCommUsed.Enabled = True
            cbCommUsed.CheckState = CheckState.Checked
        ElseIf cbComm.Checked And Not cbLeaderview.Checked Then
            cbCommUsed.CheckState = CheckState.Checked
        Else
            cbCommUsed.CheckState = CheckState.Unchecked
            cbCommUsed.Enabled = False
        End If

    End Sub

    'If Comm is not used, disable CommLink
    Private Sub cbCommUsed_CheckedChanged(sender As Object, e As EventArgs) 
        If cbCommUsed.Checked Then
            cbLink.Enabled = True
        Else
            cbLink.Enabled = False
            cbLink.CheckState = CheckState.Unchecked
        End If
    End Sub

    'Toggle input for NRP
    Private Sub cbNrp_CheckedChanged(sender As Object, e As EventArgs) 
        If cbNrp.Checked Then
            'If NRP is required, make an input box visible
            txtNrp.Visible = True
            cbNrp.Text = "Yes   #:".ToString()
        Else
            'If NRP is not required, hide and clear input
            cbNrp.Text = "Yes".ToString()
            txtNrp.Text = "".ToString()
            txtNrp.Visible = False
        End If

    End Sub

    'User clicks Clear or presses Esc
    Private Sub btnClear_Click(sender As Object, e As EventArgs) 
        resetForm()
    End Sub

    'User clicks Generate button
    Private Sub btnGen_Click(sender As Object, e As EventArgs) 
        Dim arrEmptyInputs As New List(Of String)
        Dim comment As String = ""
        Dim emptyInputs As String = ""
        Try
            arrEmptyInputs = ValidateForm()
            If (arrEmptyInputs Is Nothing Or arrEmptyInputs.Count <= 0) Then
                comment = GenerateComment()
                CopyString(comment.ToString())
                SavetoFile(comment)
                lblGenerated.Visible = True
            Else
                For Each element As String In arrEmptyInputs
                    emptyInputs &= element + Environment.NewLine
                Next
                Throw New ApplicationException("Please check the following:" + Environment.NewLine + emptyInputs)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    'Ensure form is complete. If input is empty, fill array with names.
    Private Function ValidateForm() As List(Of String)
        Dim arrEmptyInput As New List(Of String)
        Try
            'Check text boxes for input. NRP text box not checked to allow for later edit
            'Check CID
            If (String.IsNullOrEmpty(txtCid.Text.ToString().Trim())) Then
                arrEmptyInput.Add("CID")
            End If
            'Check Dial In Early
            If (String.IsNullOrEmpty(cmbEarly.Text.ToString().Trim())) Then
                arrEmptyInput.Add("SPK Dial In")
            End If
            'Check Lines
            If (rbTogether.Checked = False AndAlso rbSeparate.Checked = False) Then
                arrEmptyInput.Add("SPK Lines")
            End If
            'Check Participants Reference
            If (rbCid.Checked = False AndAlso rbDirect.Checked = False AndAlso rbPassword.Checked = False AndAlso rbOther.Checked = False) Then
                arrEmptyInput.Add("Parts Reference")
            End If
            'Only validate password if used
            If rbPassword.Checked Then
                If (String.IsNullOrEmpty(txtPassword.Text.ToString().Trim())) Then
                    arrEmptyInput.Add("Password")
                End If
            End If
            'Only validate "other" if used
            If rbOther.Checked Then
                If (String.IsNullOrEmpty(txtOther.Text.ToString().Trim())) Then
                    arrEmptyInput.Add("Other Ref")
                End If
            End If
            'Check Call Format
            If (rbStandard.Checked = False AndAlso rbMulti.Checked = False AndAlso rbLecture.Checked = False AndAlso rbOpen.Checked = False) Then
                arrEmptyInput.Add("Call Format")
            End If
            'Check Facts Complete
            If (String.IsNullOrEmpty(txtFacts.Text.ToString().Trim())) Then
                arrEmptyInput.Add("Facts Complete")
            End If
            If (String.IsNullOrEmpty(txtVerified.Text.ToString().Trim())) Then
                arrEmptyInput.Add("Verified With")
            End If
        Catch ex As Exception
            MessageBox.Show("Error validating form: " + ex.Message)
        End Try

        Return arrEmptyInput
    End Function

    'Generate Comment String
    Private Function GenerateComment() As String
        Dim comment As String = ""

        Try
            'Add CID to comment
            comment = "CID: " + txtCid.Text.ToString() + Environment.NewLine
            'Add Speakers to comment
            comment &= "Speakers will dial in: " + cmbEarly.Text.ToString() + " minutes early on "
            If rbSeparate.Checked Then
                comment &= "separate lines"
            ElseIf rbTogether.Checked Then
                comment &= "one line"
            End If
            comment &= Environment.NewLine
            'Add participants will reference to comment
            comment &= "Participants will reference: "
            If rbCid.Checked Then
                comment &= "Conference ID Number"
            ElseIf rbPassword.Checked Then
                comment &= "Password(" + Convert.ToString(txtPassword.Text) + ")"
            ElseIf rbDirect.Checked Then
                comment &= "Direct Entry"
            ElseIf rbOther.Checked Then
                comment &= Convert.ToString(txtOther.Text)
            End If
            comment &= Environment.NewLine
            'Add format to comment
            comment &= "Call Format: "
            If rbStandard.Checked Then
                comment &= "Standard Q&A"
            ElseIf rbMulti.Checked
                comment &= "Multi Q&A"
            ElseIf rbLecture.Checked Then
                comment &= "Lectured"
            ElseIf rbOpen.Checked Then
                comment &= "Open Call"
            End If
            comment &= Environment.NewLine
            'Add FC to comment
            comment &= "Facts Complete: " + txtFacts.Text.ToString() + Environment.NewLine
            'Add setup to comment
            comment &= "Setup Time Reviewed: Yes" + Environment.NewLine
            'Add LV to comment
            If cbLeaderview.Checked Then
                comment &= "LeaderView WILL be used" + Environment.NewLine
            End If
            'Add comm to comment
            If cbComm.Checked Then
                If cbCommUsed.Checked Then
                    comment &= "Comm Line WILL be used"
                    If cbLink.Checked Then
                        comment &= "   (Link Comm and Main)"
                    End If
                Else
                    comment &= "Comm Line WILL NOT be used"
                End If
                comment &= Environment.NewLine
            End If
            'Add NRP to comment
            If cbNrp.Checked Then
                comment &= "Special NRP/Enunciator Requested: YES   "
                If (String.IsNullOrEmpty(txtNrp.Text.ToString())) Then
                    comment &= "NRP # pending"
                Else
                    comment &= "NRP # provided: " + txtNrp.Text.ToString()
                End If
                comment &= Environment.NewLine
            End If
            'Add special features to comment
            If cbSs.Checked OrElse cbApl.Checked OrElse cbIws.Checked OrElse cbPlayback.Checked OrElse cbPolling.Checked Then
                comment &= "Special Features: "
                If cbSs.Checked Then
                    comment &= "SS\"
                End If
                If cbApl.Checked Then
                    comment &= "APL\"
                End If
                If cbIws.Checked Then
                    comment &= "IWS\"
                End If
                If cbPlayback.Checked Then
                    comment &= "Playback\"
                End If
                If cbPolling.Checked Then
                    comment &= "Polling\"
                End If
                comment = comment.TrimEnd("\")
                comment &= Environment.NewLine
            End If
            'Add silent rec to comment
            If cbRecord.Checked Then
                comment &= "Backup Record Line: Yes" + Environment.NewLine
            End If
            'Add VT to comment
            If cbVt.Checked Then
                comment &= "True VT: Yes" + Environment.NewLine
            End If
            'Add other to comment
            Dim arrOtherDetails() As String
            Dim counter As Integer
            arrOtherDetails = txtOtherDetails.Lines
            If (arrOtherDetails IsNot Nothing AndAlso arrOtherDetails.Count > 0) Then
                comment &= "Other details: "
                For counter = 0 To arrOtherDetails.GetUpperBound(0)
                    comment &= Convert.ToString(arrOtherDetails(counter))
                    comment &= Environment.NewLine
                Next
            End If
            'Add verified to comment
            comment &= "Verified With: " + txtVerified.Text.ToString()
        Catch ex As Exception
            MessageBox.Show("Error creating comment: " + ex.Message)
        End Try

        Return comment
    End Function

    'Call this to initialize/reset the form
    Private Sub resetForm()
        txtCid.Text = "".ToString()
        cmbEarly.Text = "".ToString()
        rbTogether.Checked = False
        rbSeparate.Checked = False
        'Switch on and off resets entire combo group
        rbCid.Checked = True
        rbCid.Checked = False
        'Switch on and off resets entire combo group
        rbStandard.Checked = True
        rbStandard.Checked = False
        txtFacts.Text = "".ToString()
        cbLeaderview.CheckState = CheckState.Unchecked
        cbComm.CheckState = CheckState.Unchecked
        cbNrp.CheckState = CheckState.Unchecked
        cbSs.CheckState = CheckState.Unchecked
        cbApl.CheckState = CheckState.Unchecked
        cbIws.CheckState = CheckState.Unchecked
        cbPlayback.CheckState = CheckState.Unchecked
        cbPolling.CheckState = CheckState.Unchecked
        cbRecord.CheckState = CheckState.Unchecked
        cbVt.CheckState = CheckState.Unchecked
        cbLink.CheckState = CheckState.Unchecked
        cbLink.Enabled = False
        txtOtherDetails.Text = "".ToString()
        txtVerified.Text = "".ToString()
        lblGenerated.Visible = False
    End Sub

    'Call this to copy a string to the system clipboard
    Private Sub CopyString(stringIn As String)
        Try
            If stringIn IsNot String.Empty Then
                'Copy to clipboard
                My.Computer.Clipboard.SetText(stringIn.ToString())
            Else
                'Set error
                Throw New ApplicationException("Nothing was generated!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Call this to save a string to the output file
    Private Sub SavetoFile(body As String)
        'Dim file As System.IO.StreamWriter
        Dim fileName, filePath As String
        Try
            fileName = txtCid.Text.ToString().Trim + ".txt"
            'DevelopmentPath
            'filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\WT Comments\" + Convert.ToString(Now.Date.Year) + "\" + Convert.ToString(MonthName(Now.Date.Month)) + "\"
            'Production Path
            filePath = "\\ygk01cfp01\Operations\Call Execution\WT Team\" + Convert.ToString(Now.Date.Year) + "\" + Convert.ToString(MonthName(Now.Date.Month)) + "\"
            MessageBox.Show(filePath)
            'Create directory and save file. (Directory will not be overwritten if it exists, file will)
            Directory.CreateDirectory(filePath)
            File.WriteAllText(filePath & Convert.ToString(fileName), body)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
