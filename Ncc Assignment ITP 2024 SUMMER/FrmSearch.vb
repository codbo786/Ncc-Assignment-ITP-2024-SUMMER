Imports System.Runtime

Public Class FrmSearch
    Dim str As IO.StreamReader
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Lbl2.Click

    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        str = New IO.StreamReader("C:\Users\Abbas Aamir\Desktop\DATA.txt")
        ListBox2.Items.Clear()
        While (str.Peek > -1)
            ListBox2.Items.Add(str.ReadLine)
        End While
        str.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBox_1.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        Dim point As String = TxtBox_1.Text
        'Obtaining linear search and showcasing the result
        Dim index As Integer = LinearSearch(point)

        If index >= 0 Then
            'Item has been found, do something with its functions
            MessageBox.Show("Item Found using linear search at: " & index)
        Else
            MessageBox.Show("Item not found using linear search")
        End If

    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        Dim dataa As List(Of String) = ListBox2.Items.Cast(Of String)().ToList()
        dataa.Sort()
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(dataa.ToArray())
        BinarySearch(TxtBox_1.Text)


    End Sub
    Public Function LinearSearch(ByVal point As String) As Integer
        For i As Integer = 0 To ListBox2.Items.Count - 1
            If ListBox2.Items(i) = point Then
                'If found, return the index value
                Return i
            End If
        Next
    End Function
    Public Sub BinarySearch(ByVal point As String)
        Dim lowerval As Integer = 0
        Dim upperval As Integer = ListBox2.Items.Count - 1

        While lowerval <= upperval
            Dim mid As Integer = (lowerval + upperval) \ 2
            Dim currItem As String = ListBox2.Items(mid)

            If currItem = point Then
                'Item has been found now work on its function
                MessageBox.Show("Number found using binary search : " & currItem)
                Exit Sub
            ElseIf currItem < point Then
                lowerval = mid + 1
            Else
                upperval = mid - 1
            End If
        End While
        'Item has not been found
        MessageBox.Show("Item not found: " & point)

    End Sub
End Class