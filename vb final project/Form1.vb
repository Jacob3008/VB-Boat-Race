Public Class Form1
    Structure Boat
        Dim strColor As String      ' Boat color
        Dim intPlace() As Integer   ' Standing for each race
        Dim intScore As Integer     ' Sum of all races
    End Structure

    Const intMAX_BOAT_INDEX As Integer = 2
    Const intMAX_RACE_INDEX As Integer = 3

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim Boats(intMAX_BOAT_INDEX) As Boat    ' Array of boats in the race

        resetLeaderboard()

        ' Set color and number of races
        With Boats(0)
            .strColor = "Red"
            ReDim .intPlace(intMAX_RACE_INDEX)
        End With

        With Boats(1)
            .strColor = "Green"
            ReDim .intPlace(intMAX_RACE_INDEX)
        End With

        With Boats(2)
            .strColor = "Blue"
            ReDim .intPlace(intMAX_RACE_INDEX)
        End With



        Try
            ' Grab user input and validate
            getRanks(Boats)
            For intCol = 0 To intMAX_RACE_INDEX
                checkDuplicate(Boats(0).intPlace(intCol), Boats(1).intPlace(intCol), Boats(2).intPlace(intCol))
            Next

            ' Display final scores
            lblRedScore.Text = Boats(0).intScore.ToString()
            lblGreenScore.Text = Boats(1).intScore.ToString()
            lblBlueScore.Text = Boats(2).intScore.ToString()

            ' Display leaderboard with boat names
            setLeaderboard(Boats)

            lblFirst.Text = lblFirst.Text & Boats(0).strColor
            lblSecond.Text = lblSecond.Text & Boats(1).strColor
            lblThird.Text = lblThird.Text & Boats(2).strColor

        Catch ex As Exception
            lblError.Text = ex.Message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub checkDuplicate(ByVal intNum1, ByVal intNum2, ByVal intNum3)
        ' If any two values are equal throw error
        If (intNum1 = intNum2 Or intNum1 = intNum3 Or intNum2 = intNum3) Then
            Throw New Exception("Duplicate value found")
        End If

    End Sub

    Sub getRanks(ByRef Boats() As Boat)
        ' Text box array
        Dim intRanks(,) As TextBox = {{txtRed1, txtRed2, txtRed3, txtRed4},
        {txtGreen1, txtGreen2, txtGreen3, txtGreen4},
        {txtBlue1, txtBlue2, txtBlue3, txtBlue4}}

        Dim intRank As Integer      ' Rank in single race
        Dim intScore As Integer     ' Final score for a boat

        For intRow = 0 To intMAX_BOAT_INDEX
            intScore = 0
            For intCol = 0 To intMAX_RACE_INDEX

                ' Check for numerical value
                If (Integer.TryParse(intRanks(intRow, intCol).Text, intRank)) Then
                    ' Make sure that value is between 1 and 3
                    If (intRank >= 1 And intRank <= 3) Then

                        Boats(intRow).intPlace(intCol) = intRank
                        intScore += intRank

                    Else
                        Throw New System.Exception("Please only enter values between 1 and 3")
                    End If
                Else
                    Throw New System.Exception("Please enter numeric values only")
                End If

            Next
            Boats(intRow).intScore = intScore
        Next
    End Sub

    Sub setLeaderboard(ByRef Boats() As Boat)
        ' Sort boat array
        Boats = Boats.OrderBy(Function(c) c.intScore).ToArray

        ' If all scores are the same
        If (Boats(0).intScore = Boats(1).intScore And Boats(1).intScore = Boats(2).intScore) Then
            lblFirst.Text = "1st Place (Tie): "
            lblSecond.Text = "1st Place (Tie): "
            lblThird.Text = "1st Place (Tie): "

            lblRedScore.ForeColor = Color.Red
            lblGreenScore.ForeColor = Color.Red
            lblBlueScore.ForeColor = Color.Red

            lblError.Text = "Tie"

            ' If first and second are the same
        ElseIf (Boats(0).intScore = Boats(1).intScore) Then
            lblFirst.Text = "1st Place (Tie): "
            lblSecond.Text = "1st Place (Tie): "
            lblThird.Text = "2nd Place: "

            lblRedScore.ForeColor = Color.Red
            lblGreenScore.ForeColor = Color.Red
            lblBlueScore.ForeColor = Color.Red

            lblError.Text = "Tie"

            ' If second and third are the same
        ElseIf (Boats(1).intScore = Boats(2).intScore) Then
            lblSecond.Text = "2nd Place (Tie): "
            lblThird.Text = "2nd Place (Tie): "

            lblRedScore.ForeColor = Color.Red
            lblGreenScore.ForeColor = Color.Red
            lblBlueScore.ForeColor = Color.Red

            lblError.Text = "Tie"
        End If


    End Sub

    Sub resetLeaderboard()

        ' Reset leaderboard labels
        lblFirst.Text = "1st Place: "
        lblSecond.Text = "2nd Place: "
        lblThird.Text = "3rd Place: "

        ' Reset score labels
        With lblRedScore
            .Text = String.Empty
            .ForeColor = Color.Black
        End With

        With lblGreenScore
            .Text = String.Empty
            .ForeColor = Color.Black
        End With

        With lblBlueScore
            .Text = String.Empty
            .ForeColor = Color.Black
        End With

        ' Reset status strip
        lblError.Text = String.Empty
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Text box array
        Dim intRanks(,) As TextBox = {{txtRed1, txtRed2, txtRed3, txtRed4},
        {txtGreen1, txtGreen2, txtGreen3, txtGreen4},
        {txtBlue1, txtBlue2, txtBlue3, txtBlue4}}

        resetLeaderboard()

        ' Reset text boxes
        For intRow = 0 To intMAX_BOAT_INDEX
            For intCol = 0 To intMAX_RACE_INDEX
                intRanks(intRow, intCol).Text = String.Empty
            Next
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit application
        Me.Close()
    End Sub
End Class
