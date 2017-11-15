Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pres() As String = IO.File.ReadAllLines("C:\Users\maxxx950\Desktop\USStates.txt")
        '32
        ListBox1.Items.Add(pres(0)) 'first president
        For i As Integer = 0 To 5 ' first 6 presidents
            ListBox1.Items.Add(pres(i))
        Next
        ListBox1.Items.Add(pres(1)) 'second president
        ListBox1.Items.Add(pres(9)) '10th president
        ListBox1.Items.Add(pres(pres.Length - 1))
        ListBox1.Items.Add(pres(Array.IndexOf(pres, "James Monroe")))
        For i As Integer = pres.Length - 1 To pres.Length - 6 'last 5 presidents
            ListBox1.Items.Add(pres(i))
        Next

        '38
        Dim numbers() As Integer
        Dim counter As Integer = 0
        For Each num As Integer In numbers
            If num Mod 2 = 0 Then
                counter = counter + 1
            End If
        Next

        '7.4.22
        Dim allData(,) As Integer = {{23034, 23850}, {13980, 14027}, {11131, 11131}, {7566, 7542}, {7250, 7253}}
        Dim count As Integer = 0
        For i As Integer = 0 To 4
            For j As Integer = 0 To 1
                count = count + allData(i, j)
            Next
        Next
        TextBox1.Text = count
    End Sub

    '46
    Private Function checkOrder()
        Dim states() As String = IO.File.ReadAllLines("C:\Users\maxxx950\Desktop\USStates.txt")
        Dim cloned() As String = states.Clone()
        Array.Sort(cloned)
        For i As Integer = 0 To states.Length - 1
            If (states(i) = cloned(i)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

        Catch ex As Exception
            MsgBox("There is an error while opening the File")
        End Try

        'For Each president As String In pres
        'MsgBox.show(president)
        'Next
    End Sub

    '7.3 20
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Columns("abbre").HeaderText = "State Abbreviation"
        DataGridView1.Columns("name").HeaderText = "State"
        Dim states() As String = IO.File.ReadAllLines("C:\Users\maxxx950\Desktop\USStates.txt")
        For Each state As String In states
            Dim line() As String = state.Split(",")
            Dim name As String = line(0) 'Delaware
            Dim abbre As String = line(1) 'DE
            For i As Integer = 0 To 1
                Dim c11 As Char = name(0) 'D
                Dim c12 As Char = Char.ToUpper(name(1)) 'E
                Dim c21 As Char = abbre(0) 'D
                Dim c22 As Char = abbre(1) 'E
                If c11 = c21 And c12 = c22 Then
                    DataGridView1.Rows.Add(abbre, name)
                End If
            Next
        Next
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
