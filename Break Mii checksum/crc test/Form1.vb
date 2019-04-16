Imports System

Public Class Form1
    Dim savedataArc As String
    Dim number1 As String
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GetCrc()
        Dim crc As Integer = &H0 ' Starting value 
        Dim Polynom As Integer = &H1021 ' As in X^16 + X^12 + X^5 + 1 
        Dim bytes() As Byte = Nothing
        Dim bit As Boolean
        Dim c15 As Boolean
        Dim i As Integer

        ' Convert the parameter to a Byte-array: 
        For Each s As String In TextBox2.Text
            If IsNothing(bytes) Then
                ReDim bytes(0)
            Else
                ReDim Preserve bytes(bytes.Length)
            End If

            bytes(bytes.Length - 1) = CByte(CStr("&H" & s))
        Next

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
    End Sub
End Class

