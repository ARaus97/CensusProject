Module Module1
    'Andrew Rausch Census
    Private aBaths(9) As Integer
    Private aPeople(9) As Integer
    Private aIncome(9) As Double
    Private BathAvg As Double
    Private PersonAvg As Double
    Private IncomeAvg As Double

    Public Sub ProcessHouse(HouseNo As Integer, NumBaths As Integer, NumPeople As Integer, Income As Double, lstHouseData As ListBox, AvgBath As TextBox, AvgPerson As TextBox, AvgIncome As TextBox)
        Try
            aBaths(HouseNo - 1) = NumBaths
            aPeople(HouseNo - 1) = NumPeople
            aIncome(HouseNo - 1) = Income


            AverageBath()
            AveragePerson()
            AverageIncome()

            AvgBath.Text = BathAvg
            AvgIncome.Text = IncomeAvg
            AvgPerson.Text = PersonAvg
            lstHouseData.Items.Clear()
            For i = 0 To aBaths.Length - 1
                If aBaths(i) = 0 Then


                Else
                    lstHouseData.Items.Add((i + 1).ToString + "    Baths:" + aBaths(i).ToString + "    Persons:" + aPeople(i).ToString + "    income:" + aIncome(i).ToString("c"))
                End If

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub AverageBath()
        Dim sum As Double
        For i = 0 To aBaths.Length - 1
            sum += aBaths(i)
        Next
        BathAvg = sum / aBaths.Length

    End Sub

    Private Sub AveragePerson()
        Dim sum As Double
        For i = 0 To aPeople.Length - 1
            sum += aPeople(i)
        Next
        PersonAvg = sum / aPeople.Length

    End Sub

    Private Sub AverageIncome()
        Dim sum As Double
        For i = 0 To aIncome.Length - 1
            sum += aIncome(i)
        Next
        IncomeAvg = sum / aIncome.Length
    End Sub

End Module
