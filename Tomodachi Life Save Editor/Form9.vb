Public Class Form9
    Dim filepath As String
    Dim Pagh1 As String
    Dim Pagh2 As String
    Dim Pagh3 As String
    Dim Pagh4 As String
    Dim Pagh5 As String
    Dim Pagh6 As String
    Dim Pagh7 As String
    Dim Pagh8 As String
    Dim Pagh9 As String
    Dim Pagh10 As String
    Dim Pagh11 As String
    Dim Pagh12 As String
    Dim Pagh13 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filepath = Form1.Label39.Text
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 14 Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value = 14 Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If NumericUpDown3.Value = 14 Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        If NumericUpDown6.Value = 14 Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If NumericUpDown5.Value = 14 Then
            TextBox8.Enabled = True
        Else
            TextBox8.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If NumericUpDown4.Value = 14 Then
            TextBox7.Enabled = True
        Else
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        If NumericUpDown9.Value = 14 Then
            TextBox6.Enabled = True
        Else
            TextBox6.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        If NumericUpDown8.Value = 14 Then
            TextBox5.Enabled = True
        Else
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If NumericUpDown7.Value = 14 Then
            TextBox12.Enabled = True
        Else
            TextBox12.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If NumericUpDown12.Value = 14 Then
            TextBox11.Enabled = True
        Else
            TextBox11.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        If NumericUpDown11.Value = 14 Then
            TextBox10.Enabled = True
        Else
            TextBox10.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        If NumericUpDown10.Value = 14 Then
            TextBox9.Enabled = True
        Else
            TextBox9.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown13_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown13.ValueChanged
        If NumericUpDown13.Value = 14 Then
            TextBox13.Enabled = True
        Else
            TextBox13.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Reader.Position = &H17B6E4
            NumericUpDown1.Value = Reader.ReadInt8
            Reader.Position = &H17B6EA
            Pagh1 = Reader.Position
            TextBox1.Text = Reader.ReadUnicodeString(48)

            Reader.Position = &H17B6E4 + &H68
            NumericUpDown2.Value = Reader.ReadInt8
            Reader.Position = &H17B6EA + &H68
            Pagh2 = Reader.Position
            TextBox2.Text = Reader.ReadUnicodeString(48)

            Reader.Position = &H17B6E4 + (&H68 * 2)
            NumericUpDown3.Value = Reader.ReadInt8
            Reader.Position = &H17B6EA + (&H68 * 2)
            Pagh3 = Reader.Position
            TextBox4.Text = Reader.ReadUnicodeString(48)
        End If
    End Sub
End Class