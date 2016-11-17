Public Class frmMain
    'A1-JEnglish.vb
    'James English
    'Assignment #1
    'Due 9/21
    'The first database program dealing with a customer database along with editing and 
    'updating the database based on what the user inputs.

    Private mboolflag As Boolean = True 'Flag for change events
    Private mintNamePos As Integer 'Name position'
    Private mintStatePos As Integer 'State Position'
    Private mboolSaveflag As Boolean = False 'flag for saving' 



    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim dialogResult As DialogResult

        If btnUpdateDatabase.Enabled = True Then
            dialogResult = MessageBox.Show("You have made changes without updating the database, are you sure you want to exit?",
                            "Are You Sure", MessageBoxButtons.YesNo)

            If dialogResult = vbYes Then 'If the user decides to close the program anyway'

            End If

            If dialogResult = vbNo Then 'Cancels the closing event if the user does not want to close'
                e.Cancel = True
            End If

        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_customers_F2012DataSet1.Customers' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the '_customers_F2012DataSet.States' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Fill(Me._customers_F2012DataSet.States)
        'TODO: This line of code loads data into the '_customers_F2012DataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me._customers_F2012DataSet.Customers)

    End Sub

    Private Sub FirstNameTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstName.Enter,
        txtLastName.Enter, txtAddress.Enter, txtZip.Enter, txtCity.Enter, cboState.Enter

        mboolflag = False 'state change flag'


    End Sub

    Private Sub FirstNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged,
        txtAddress.TextChanged, txtZip.TextChanged, txtCity.TextChanged, cboState.SelectedIndexChanged, txtLastName.TextChanged

        'setting the name position to the correct value'
        mintStatePos = cboState.SelectedIndex 'setting the states position to the correct value'

        If Not mboolflag Then
            cboCustomer.Enabled = False
            buttonChange(False)

        End If


    End Sub

    '----------------Button Change method takes a boolean and switches the buttons regarding the varible the method uses----------------------'
    Private Sub buttonChange(ByVal boolx As Boolean)
        btnAdd.Enabled = boolx
        btnDelete.Enabled = boolx
        btnCancel.Enabled = Not boolx
        btnSave.Enabled = Not boolx
    End Sub

    '-----------------------------------------------------Validates if the boxes have text in them----------------------------------' 
    Private Function validateBoxes() As Boolean
        Dim dialogError As DialogResult

        If txtFirstName.TextLength < 1 Then
            dialogError = MessageBox.Show("First Name Required", "Invalid Entry", MessageBoxButtons.OK)
            Return False

        ElseIf txtLastName.TextLength < 1 Then
            dialogError = MessageBox.Show("Last Name Required", "Invalid Entry", MessageBoxButtons.OK)
            Return False

        ElseIf txtAddress.TextLength < 1 Then
            dialogError = MessageBox.Show("Address Required", "Invalid Entry", MessageBoxButtons.OK)
            Return False

        ElseIf txtCity.TextLength < 1 Then
            dialogError = MessageBox.Show("City Required", "Invalid Entry", MessageBoxButtons.OK)
            Return False


        End If

        Return True

    End Function
    '----------------------------------------------------------validates the zip code / state-----------------------------------------------'
    Private Function validateZip() As Boolean
        Dim dialogError As DialogResult

        If cboState.SelectedIndex = -1 Then 'Checks to see if the user has picked a state'
            dialogError = MessageBox.Show("State Can Not Be Blank", "Invalid State", MessageBoxButtons.OK)
            Return False
        End If

        If txtZip.TextLength < 0 Then
            dialogError = MessageBox.Show("Zip Code Not Entered", "Invalid Zip", MessageBoxButtons.OK)
            Return False
        End If

        If IsNumeric(txtZip.Text) = False Then
            dialogError = MessageBox.Show("Zip Code Invalid", "Invalid Zip", MessageBoxButtons.OK)
            Return False
        End If

        'This checks to see if the zip codes match properly to the state's zip codes that are allowed
        If CInt(txtZip.Text) >= CInt(_customers_F2012DataSet.States(mintStatePos).FirstZipCode) And
            CInt(txtZip.Text) <= CInt(_customers_F2012DataSet.States(mintStatePos).LastZipCode) Then
            Return True

        Else

            dialogError = MessageBox.Show("Zip Code Invalid", "Invalid Zip", MessageBoxButtons.OK)
            Return False
        End If

        Return False
    End Function




    Private Sub FirstNameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub lblCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCustomer.Click

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomersTableAdapter.Fill(Me._customers_F2012DataSet.Customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show("Are You Sure", "Confirm", MessageBoxButtons.YesNo)
        If dlgResult = Windows.Forms.DialogResult.Yes Then
            CustomersBindingSource.RemoveCurrent()
            btnUpdateDatabase.Enabled = True ' update button turns on only if they want to delete the person' 
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        CustomersBindingSource.CancelEdit()
        buttonChange(True)
        cboCustomer.Enabled = True

        cboCustomer.SelectedIndex = mintNamePos 'to set the index of the customer back 
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If validateBoxes() And validateZip() Then
            CustomersBindingSource.EndEdit()
            buttonChange(True)
            cboCustomer.Enabled = True
            btnUpdateDatabase.Enabled = True
            mboolSaveflag = True

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomer.SelectedIndexChanged
        mboolflag = True


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If validateBoxes() And validateZip() Then

            mintNamePos = cboCustomer.SelectedIndex
            CustomersBindingSource.AddNew()
            buttonChange(False)
            cboCustomer.Enabled = False
        End If
    End Sub

    Private Sub btnUpdateDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDatabase.Click
        CustomersTableAdapter.Update(_customers_F2012DataSet)
        btnUpdateDatabase.Enabled = False 'button turned off after updating, turns on again after a save'
        mboolSaveflag = False 'setting the save flag to false again after updating'
    End Sub
End Class
