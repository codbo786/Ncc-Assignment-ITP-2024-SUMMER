Public Class FrmSort
    Dim randomNumbers(10) As Integer
    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        'Begin 10 unsorted numbers between 1 and 100
        For i = 0 To 9
            randomNumbers(i) = CInt(Rnd() * 100) + 1 'Scale and offset for range 1 to 100
        Next

        'Clearing the listbox before new data is being displayed
        ListBox.Items.Clear()

        'Show unsorted numbers
        ListBox.Items.Add("Unsorted:")
        For i = 0 To 9
            ListBox.Items.Add(randomNumbers(i).ToString())
        Next

        'Bubble logic 101.
        Dim swapped As Boolean = True 'method to see if any swaps have been made

        'While loop added in the array for multiple loops to start.
        Do While swapped
            swapped = False  'Reset loop after each pass

            'Compare adjacent nums and swap if they are true
            For i = 0 To UBound(randomNumbers) - 1
                If randomNumbers(i) > randomNumbers(i + 1) Then
                    ' Then no command needed directly swap them
                    Dim temp As Integer = randomNumbers(i)
                    randomNumbers(i) = randomNumbers(i + 1)
                    randomNumbers(i + 1) = temp
                    swapped = True 'Set mark if a swap occurred
                End If
            Next
        Loop

        'Show sorted numbers
        ListBox.Items.Add("")
        ListBox.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox.Items.Add(randomNumbers(i).ToString())
        Next
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        ' Start Random Numbers
        For i = 0 To 9
            randomNumbers(i) = CInt(Rnd() * 100) + 1
        Next
        'Clearing the listbox before user pressed insertion sorting again
        ListBox.Items.Clear()

        'Show Unsorted Numbers
        ListBox.Items.Add("UNSORTED:")
        For i = 0 To 9
            ListBox.Items.Add(randomNumbers(i).ToString())
        Next
        ' Insertion Logic 101
        For i = 0 To 9 'Initiate from 2nd element (indexing from 1)
            Dim x As Integer = randomNumbers(i)
            Dim a As Integer = i - 1
            While a >= 0 AndAlso randomNumbers(a) > x
                randomNumbers(a + 1) = randomNumbers(a)
                a -= 1
                If a < 0 Then Exit While 'Make sure a doesnt go below 0
            End While
            randomNumbers(a + 1) = x

        Next

        'Show Sorted Numbers
        ListBox.Items.Add("")
        ListBox.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox.Items.Add(randomNumbers(i).ToString())
        Next


    End Sub

    Private Sub Lstb_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged

    End Sub
End Class
