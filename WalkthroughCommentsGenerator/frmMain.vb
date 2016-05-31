Imports System.IO

Public Class frmMain
    'Reset form on load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetForm()

    End Sub

    'Toggle Form Textbox For Other Entry
    Private Sub rbOther_CheckedChanged(sender As Object, e As EventArgs) Handles rbOther.CheckedChanged
        If rbOther.Checked Then
            'Enable Textbox
            txtOther.ReadOnly = False
        Else
            'Reset if not selected
            txtOther.Text = "".ToString
            txtOther.ReadOnly = True
        End If
    End Sub

    'Toggle Form Textbox For Password
    Private Sub rbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles rbPassword.CheckedChanged
        If rbPassword.Checked Then
            'Enable Textbox
            txtPassword.ReadOnly = False
        Else
            'Reset if not selected
            txtPassword.Text = "".ToString
            txtPassword.ReadOnly = True
        End If
    End Sub

    'Force Selection of Comm Line when LeaderView is selected
    Private Sub cbLeaderview_CheckedChanged(sender As Object, e As EventArgs) Handles cbLeaderview.CheckedChanged
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

    'When Comm combo box changes state: Toggle CommUsed checkbox\CommLink checkbox
    Private Sub cbComm_CheckedChanged(sender As Object, e As EventArgs) Handles cbComm.CheckedChanged
        If cbComm.Checked And cbLeaderview.Checked Then
            cbCommUsed.Enabled = True
            cbCommUsed.CheckState = CheckState.Checked
            'cbLink.Enabled = True
        ElseIf cbComm.Checked And Not cbLeaderview.Checked Then
            cbCommUsed.CheckState = CheckState.Checked
            'cbLink.Enabled = True
        Else
            cbCommUsed.CheckState = CheckState.Unchecked
            cbCommUsed.Enabled = False
            'cbLink.Enabled = False
            'cbLink.CheckState = CheckState.Unchecked
        End If

    End Sub

    'If Comm is not used, disable CommLink
    Private Sub cbCommUsed_CheckedChanged(sender As Object, e As EventArgs) Handles cbCommUsed.CheckedChanged
        If cbCommUsed.Checked Then
            cbLink.Enabled = True
        Else
            cbLink.Enabled = False
            cbLink.CheckState = CheckState.Unchecked
        End If
    End Sub

    'Toggle input for NRP
    Private Sub cbNrp_CheckedChanged(sender As Object, e As EventArgs) Handles cbNrp.CheckedChanged
        If cbNrp.Checked Then
            'If NRP is required, make an input box visible
            txtNrp.Visible = True
            cbNrp.Text = "Yes   #:".ToString
        Else
            'If NRP is not required, hide and clear input
            cbNrp.Text = "Yes".ToString
            txtNrp.Text = "".ToString
            txtNrp.Visible = False
        End If

    End Sub

    'User clicks Clear or presses Esc
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resetForm()
    End Sub

    'User clicks Generate button
    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Dim validForm As Boolean = False
        Dim comment As String = ""
        Try
            validForm = ValidateForm()
            If validForm Then
                comment = GenerateComment()
                CopyString(comment.ToString)
                SavetoFile(comment)
            Else
                Throw New ApplicationException("Input validation failed!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    'Ensure form is complete
    Private Function ValidateForm() As Boolean
        Dim validCid, validPassword, validOther, validFacts, validVerified As Boolean
        Dim validForm As Boolean = False
        Try
            'Check text boxes for input. NRP text box not checked to allow for later edit
            If (String.IsNullOrEmpty(txtCid.Text.ToString)) Then
                validCid = False
            Else
                validCid = True
            End If
            'Only validate password if used
            If rbPassword.Checked Then
                If (String.IsNullOrEmpty(txtPassword.Text.ToString)) Then
                    validPassword = False
                Else
                    validPassword = True
                End If
            Else
                validPassword = True
            End If
            If rbOther.Checked Then
                If (String.IsNullOrEmpty(txtOther.Text.ToString)) Then
                    validOther = False
                Else
                    validOther = True
                End If
            Else
                validOther = True
            End If
            If (String.IsNullOrEmpty(txtFacts.Text.ToString)) Then
                validFacts = False
            Else
                validFacts = True
            End If
            If (String.IsNullOrEmpty(txtVerified.Text.ToString)) Then
                validVerified = False
            Else
                validVerified = True
            End If

            'Evaluate checks
            If validCid AndAlso validPassword AndAlso validFacts AndAlso validFacts AndAlso validVerified Then
                validForm = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error validating form: " + ex.Message)
        End Try

        Return validForm
    End Function

    'Generate Comment String
    Private Function GenerateComment() As String
        Dim comment As String = ""

        Try
            'Add CID to comment
            comment = "CID: " + txtCid.Text.ToString + Environment.NewLine
            'Add Speakers to comment
            comment &= "Speakers will dial in: " + cmbEarly.Text.ToString + " minutes early on "
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
                comment &= "Password\code(" + Convert.ToString(txtPassword.Text) + ")"
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
            comment &= "Facts Complete: " + txtFacts.Text.ToString + Environment.NewLine
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
                If (String.IsNullOrEmpty(txtNrp.Text.ToString)) Then
                    comment &= "NRP # pending"
                Else
                    comment &= "NRP # provided: " + txtNrp.Text.ToString
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
                comment &= "Silent Record Line: Yes" + Environment.NewLine
            End If
            'Add VT to comment
            If cbVt.Checked Then
                comment &= "True VT: Yes" + Environment.NewLine
            End If
            'Add other to comment
            Dim arrOtherDetails() As String
            Dim counter As Integer
            arrOtherDetails = txtOtherDetails.Lines
            comment &= "Other details for operator: "
            If (arrOtherDetails IsNot Nothing AndAlso arrOtherDetails.Count > 0) Then
                For counter = 0 To arrOtherDetails.GetUpperBound(0)
                    comment &= Convert.ToString(arrOtherDetails(counter))
                    comment &= Environment.NewLine
                Next
            Else
                comment &= Environment.NewLine
            End If

            'Add verified to comment
            comment &= "Verified With: " + txtVerified.Text.ToString
        Catch ex As Exception
            MessageBox.Show("Error creating comment: " + ex.Message)
        End Try

        Return comment
    End Function

    'Call this to initialize/reset the form
    Private Sub resetForm()
        txtCid.Text = "".ToString
        cmbEarly.Text = Convert.ToString("15")
        rbSeparate.Checked = True
        rbCid.Checked = True
        rbStandard.Checked = True
        txtFacts.Text = "f&l".ToString
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
        txtOtherDetails.Text = "".ToString
        txtVerified.Text = "".ToString
    End Sub

    'Call this to copy a string to the system clipboard
    Private Sub CopyString(stringIn As String)
        Try
            If stringIn IsNot String.Empty Then
                'Copy to clipboard
                My.Computer.Clipboard.SetText(stringIn.ToString)
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
            fileName = txtCid.Text.ToString.Trim + ".txt"
            'DevelopmentPath
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\WT Comments\" + Convert.ToString(Now.Date.Year) + "\" + Convert.ToString(MonthName(Now.Date.Month)) + "\"
            'Production Path
            'filePath = "W:\WT Comments\" + Convert.ToString(Now.Date.Year) + "\" + Convert.ToString(MonthName(Now.Date.Month)) + "\"

            'Create directory and save file. (Directory will not be overwritten if it exists, file will)
            Directory.CreateDirectory(filePath)
            File.WriteAllText(filePath & Convert.ToString(fileName), body)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
