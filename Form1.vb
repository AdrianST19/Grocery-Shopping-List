Public Class Form1
    Dim I1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Nu ati trecut nimic in textbox!")
        Else
            If ListBox1.Items.Contains(Me.TextBox1.Text) = False Then
                Me.ListBox1.Items.Add(Me.TextBox1.Text)
                Me.TextBox1.Clear()
            Else
                MsgBox("Aveti deja acest produs in lista!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        I1 = ListBox1.SelectedIndex
        If I1 >= 0 Then
            Me.ListBox1.Items.RemoveAt(I1)
        Else
            MsgBox("Selectati din lista produsul pe care doriti sa il stergeti!")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox("Selectati produsul ce doriti sa il modificati!")
        Else
            I1 = ListBox1.SelectedIndex
            If I1 >= 0 Then
                Me.ListBox1.Items.Item(I1) = Me.TextBox1.Text
                Me.TextBox1.Clear()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = String.Empty
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.Button1.BackColor = Color.DarkGreen
        Me.Button1.ForeColor = Color.White
        Me.Button1.Font = New Font("Times New Roman", 12, FontStyle.Regular)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.OrangeRed
        Me.Button1.ForeColor = Color.White
        Me.Button1.Font = New Font("SegoeUI", 11, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.Button2.BackColor = Color.DarkGreen
        Me.Button2.ForeColor = Color.White
        Me.Button2.Font = New Font("Times New Roman", 12, FontStyle.Regular)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.OrangeRed
        Me.Button2.ForeColor = Color.White
        Me.Button2.Font = New Font("SegoeUI", 11, FontStyle.Regular)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Me.Button3.BackColor = Color.DarkGreen
        Me.Button3.ForeColor = Color.White
        Me.Button3.Font = New Font("Times New Roman", 12, FontStyle.Regular)
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.Button3.BackColor = Color.OrangeRed
        Me.Button3.ForeColor = Color.White
        Me.Button3.Font = New Font("SegoeUI", 11, FontStyle.Regular)
    End Sub
    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Me.Button4.BackColor = Color.Crimson
        Me.Button4.ForeColor = Color.White
        Me.Button4.Font = New Font("Times New Roman", 15, FontStyle.Regular)
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Me.Button4.BackColor = Color.Red
        Me.Button4.ForeColor = Color.White
        Me.Button4.Font = New Font("SegoeUI", 11, FontStyle.Regular)
    End Sub
    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Me.Button5.BackColor = Color.DarkGreen
        Me.Button5.ForeColor = Color.White
        Me.Button5.Font = New Font("Times New Roman", 12, FontStyle.Regular)
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Me.Button5.BackColor = Color.OrangeRed
        Me.Button5.ForeColor = Color.White
        Me.Button5.Font = New Font("SegoeUI", 11, FontStyle.Regular)
    End Sub
End Class
