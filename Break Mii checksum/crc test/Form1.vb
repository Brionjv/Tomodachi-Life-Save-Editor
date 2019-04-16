Imports System

Public Class Form1
    Dim savedataArc As String
    Dim number1 As String
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GetCrc()
        Dim crc As Integer = &H0 ' Starting value 
        Dim Polynom As Integer = &H1021 ' As in X^16 + X^12 + X^5 + 1 
        Dim bit As Boolean
        Dim c15 As Boolean
        Dim i As Integer
        Dim str As String = TextBox2.Text
        Dim ctr = PackageIO.Conversions.HexToByteArray(str)
        Dim bytes As Byte() = ctr

        ' Calculate the CRC: 
        For Each b As Byte In bytes
            For i = 0 To 7
                bit = ((b >> (7 - i) And 1)) '= 1) 
                c15 = ((crc >> 15 And 1)) '= 1) 
                crc <<= 1
                If c15 Xor bit Then
                    crc = crc Xor Polynom
                End If
            Next
        Next

        crc = crc And &HFFFF

        ' De crc-variable is a decimal value. We return a Hex-value, so we need to convert this to hex. 
        ' The 16 in the Convert-method means the Hex-base. 
        Dim retVal As String = System.Convert.ToString(crc, 16)
        TextBox1.Text = retVal
        Return
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetCrc()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim open As New OpenFileDialog
        open.Filter = "Text files|*.txt"
        open.Title = "Open save savedataArc.txt"
        open.ShowDialog()
        savedataArc = open.FileName
        Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
        Reader.Position = &H1C70
        TextBox2.Text = Reader.ReadHexString(&H5E)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        UnicodeStringToBytes
    End Sub

    Private Sub UnicodeStringToBytes()
        Dim str As String = TextBox2.Text
        Dim ctr = System.Text.Encoding.Unicode.GetBytes(str)
        Dim crc As UShort = &H0

        Dim data As Byte() = ctr

        Dim pos = 0
        Do While (pos < data.Length)

            crc ^= data(pos)

            Dim i = 8
            Do While (i <> 0)
                i = (i - 1)
                If (crc And &H1) <> 0 Then
                    crc >>= 1
                    crc ^= &H1021
                Else
                    crc >>= 1
                End If
            Loop

            pos = (pos + 1)

        Loop

        TextBox1.Text = crc
        Return
    End Sub

End Class

