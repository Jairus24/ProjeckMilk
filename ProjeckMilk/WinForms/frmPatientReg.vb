Public Class frmPatientReg
    Dim firstName, lastName, middleName, address, occupation, maritalStat, contact As String
    Dim bDate As VariantType
    Dim pDBset As New PLDBDataSet()
    Dim pDB As New PLDBDataSetTableAdapters.patientDBTableAdapter()
    Private Sub frmPatientReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PLDBDataSet.patientDB' table. You can move, or remove it, as needed.
        Try
            Me.PatientDBTableAdapter.Fill(Me.PLDBDataSet.patientDB)
            Me.pDB.Fill(Me.pDBset.patientDB)
        Catch ex As Exception
            MsgBox("Cannot access database file. Please check if the Access 2010 Database Engine is installed.", vbCritical, "Database Error")
            End
        End Try
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRegSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegSave.Click
        If txtLastName.Text = "" Or txtFirstName.Text = "" Or txtMiddleName.Text = "" Or txtAddress.Text = "" _
            Or txtContact.Text = "" Or txtOccupation.Text = "" Then
            MsgBox("Every field in this form should be filled up with proper information to proceed!", vbExclamation, "Warning!")
        Else
            firstName = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
            middleName = StrConv(txtMiddleName.Text, VbStrConv.ProperCase)
            lastName = StrConv(txtLastName.Text, VbStrConv.ProperCase)
            address = StrConv(txtAddress.Text, VbStrConv.ProperCase)
            contact = txtContact.Text
            occupation = StrConv(txtOccupation.Text, VbStrConv.ProperCase)
            maritalStat = StrConv(cbRegMarital.Text, VbStrConv.ProperCase)
            Try
                Me.Validate()
                Me.pDB.Insert(lastName, firstName, middleName, lastName + ", " + firstName + " " + middleName, address, contact, dtpRegBDay.Value.ToShortDateString, occupation, maritalStat)
                Me.PatientDBTableAdapter.Update(Me.pDBset.patientDB)
                MsgBox("Registration Successful!", vbInformation, "Patient Registration")
                frmPatientCard.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox("Registration Failed", MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegCancel.Click
        Me.Close()
        frmPatientCard.Close()
    End Sub

    Private Sub btnSaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecord.Click
        If txtLastName.Text = "" Or txtFirstName.Text = "" Or txtMiddleName.Text = "" Or txtAddress.Text = "" _
           Or txtContact.Text = "" Or txtOccupation.Text = "" Then
            MsgBox("Every field in this form should be filled up with proper information to proceed!", vbExclamation, "Warning!")
        Else
            firstName = StrConv(txtFirstName.Text, VbStrConv.ProperCase)
            middleName = StrConv(txtMiddleName.Text, VbStrConv.ProperCase)
            lastName = StrConv(txtLastName.Text, VbStrConv.ProperCase)
            address = StrConv(txtAddress.Text, VbStrConv.ProperCase)
            contact = txtContact.Text
            occupation = StrConv(txtOccupation.Text, VbStrConv.ProperCase)
            maritalStat = StrConv(cbRegMarital.Text, VbStrConv.ProperCase)
            Try
                frmPatientSearch.DataGridView1.CurrentRow.Cells(1).Value = lastName
                frmPatientSearch.DataGridView1.CurrentRow.Cells(2).Value = firstName
                frmPatientSearch.DataGridView1.CurrentRow.Cells(3).Value = middleName
                frmPatientSearch.DataGridView1.CurrentRow.Cells(4).Value = lastName + ", " + firstName + " " + middleName
                frmPatientSearch.DataGridView1.CurrentRow.Cells(5).Value = address
                frmPatientSearch.DataGridView1.CurrentRow.Cells(6).Value = contact
                frmPatientSearch.DataGridView1.CurrentRow.Cells(7).Value = dtpRegBDay.Value
                frmPatientSearch.DataGridView1.CurrentRow.Cells(8).Value = occupation
                frmPatientSearch.DataGridView1.CurrentRow.Cells(9).Value = maritalStat
                frmPatientSearch.ValidateChildren()
                frmPatientSearch.DataGridView1.EndEdit()
                frmPatientSearch.PatientDBTableAdapter.Update(frmPatientSearch.PLDBDataSet.patientDB)
                MsgBox("Editing Information is Successful!", vbInformation, "Edit Information")
                frmPatientSearch.PatientDBTableAdapter.Fill(frmPatientSearch.PLDBDataSet.patientDB)
                frmPatientCard.Close()
                Me.Close()
            Catch ex As Exception
                MsgBox("Edit Failed", MsgBoxStyle.Critical, "Failed")
            End Try
        End If
    End Sub

    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.GotFocus
        txtLastName.SelectAll()
    End Sub

    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.GotFocus
        txtFirstName.SelectAll()
    End Sub

    Private Sub txtMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleName.GotFocus
        txtMiddleName.SelectAll()
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.GotFocus
        txtAddress.SelectAll()
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.GotFocus
        txtContact.SelectAll()
    End Sub

    Private Sub txtOccupation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOccupation.GotFocus
        txtOccupation.SelectAll()
    End Sub
End Class