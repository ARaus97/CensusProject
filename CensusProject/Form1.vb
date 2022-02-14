Public Class Form1
    'Andrew Rausch Census
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAvgBath.Clear()
        txtAvgIncome.Clear()
        txtAvgPerson.Clear()
        txtBath.Clear()
        txtIncome.Clear()
        txtPerson.Clear()
        lsbHouses.Items.Clear()
        txtBath.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnHouse1_Click(sender As Object, e As EventArgs) Handles btnHouse1.Click, btnHouse2.Click, btnHouse3.Click, btnHouse4.Click, btnHouse5.Click, btnHouse6.Click, btnHouse7.Click, btnHouse8.Click, btnHouse9.Click, btnHouse10.Click
        Try
            ProcessHouse(sender.tag, txtBath.Text, txtPerson.Text, txtIncome.Text, lsbHouses, txtAvgBath, txtAvgPerson, txtAvgIncome)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'txtBath.Clear()
        'txtIncome.Clear()
        'txtPerson.Clear()
    End Sub

    Private Sub lsbHouses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbHouses.SelectedIndexChanged

    End Sub
End Class
