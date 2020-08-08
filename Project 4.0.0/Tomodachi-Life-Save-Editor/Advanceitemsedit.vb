Imports PackageIO
Imports System.Net
Imports System.IO
Public Class Advanceitemsedit
    Dim savedataArc As String
    Dim Goodsitems1 As String
    Dim Goodsitems2 As String
    Dim Goodsitems3 As String
    Dim Goodsitems4 As String
    Dim Goodsitems5 As String
    Dim Goodsitems6 As String
    Dim Goodsitems7 As String
    Dim Goodsitems8 As String
    Dim Goodsitems9 As String
    Dim Goodsitems10 As String
    Dim Goodsitems11 As String
    Dim Goodsitems12 As String
    Dim Goodsitems13 As String
    Dim Goodsitems14 As String
    Dim Goodsitems15 As String
    Dim Goodsitems16 As String
    Dim Goodsitems17 As String
    Dim Goodsitems18 As String

    Private Sub Fea_setallto_Click(sender As Object, e As EventArgs) Handles Fea_setallto.Click
        'goodsitems
        If Panel_gooditems.Visible = True Then
            If Check_setall_available.Checked = True Then
                valu_goodi_1.Maximum = 255
                valu_goodi_1.Value = 254
                valu_goodi_2.Maximum = 255
                valu_goodi_2.Value = 254
                valu_goodi_3.Maximum = 255
                valu_goodi_3.Value = 254
                valu_goodi_4.Maximum = 255
                valu_goodi_4.Value = 254
                valu_goodi_5.Maximum = 255
                valu_goodi_5.Value = 254
                valu_goodi_6.Maximum = 255
                valu_goodi_6.Value = 254
                valu_goodi_7.Maximum = 255
                valu_goodi_7.Value = 254
                valu_goodi_8.Maximum = 255
                valu_goodi_8.Value = 254
                valu_goodi_9.Maximum = 255
                valu_goodi_9.Value = 254
                valu_goodi_10.Maximum = 255
                valu_goodi_10.Value = 254
                valu_goodi_11.Maximum = 255
                valu_goodi_11.Value = 254
                valu_goodi_12.Maximum = 255
                valu_goodi_12.Value = 254
                valu_goodi_13.Maximum = 255
                valu_goodi_13.Value = 254
                valu_goodi_14.Maximum = 255
                valu_goodi_14.Value = 254
                valu_goodi_15.Maximum = 255
                valu_goodi_15.Value = 254
                valu_goodi_16.Maximum = 255
                valu_goodi_16.Value = 254
                valu_goodi_17.Maximum = 255
                valu_goodi_17.Value = 254
                valu_goodi_18.Maximum = 255
                valu_goodi_18.Value = 254
            End If
            If Check_setall_unavailable.Checked = True Then
                valu_goodi_1.Maximum = 255
                valu_goodi_1.Value = 253
                valu_goodi_2.Maximum = 255
                valu_goodi_2.Value = 253
                valu_goodi_3.Maximum = 255
                valu_goodi_3.Value = 253
                valu_goodi_4.Maximum = 255
                valu_goodi_4.Value = 253
                valu_goodi_5.Maximum = 255
                valu_goodi_5.Value = 253
                valu_goodi_6.Maximum = 255
                valu_goodi_6.Value = 253
                valu_goodi_7.Maximum = 255
                valu_goodi_7.Value = 253
                valu_goodi_8.Maximum = 255
                valu_goodi_8.Value = 253
                valu_goodi_9.Maximum = 255
                valu_goodi_9.Value = 253
                valu_goodi_10.Maximum = 255
                valu_goodi_10.Value = 253
                valu_goodi_11.Maximum = 255
                valu_goodi_11.Value = 253
                valu_goodi_12.Maximum = 255
                valu_goodi_12.Value = 253
                valu_goodi_13.Maximum = 255
                valu_goodi_13.Value = 253
                valu_goodi_14.Maximum = 255
                valu_goodi_14.Value = 253
                valu_goodi_15.Maximum = 255
                valu_goodi_15.Value = 253
                valu_goodi_16.Maximum = 255
                valu_goodi_16.Value = 253
                valu_goodi_17.Maximum = 255
                valu_goodi_17.Value = 253
                valu_goodi_18.Maximum = 255
                valu_goodi_18.Value = 253
            End If
            If Check_setall_valu.Checked = True Then
                valu_goodi_1.Maximum = 99
                valu_goodi_1.Value = valu_setall.Value
                valu_goodi_2.Maximum = 99
                valu_goodi_2.Value = valu_setall.Value
                valu_goodi_3.Maximum = 99
                valu_goodi_3.Value = valu_setall.Value
                valu_goodi_4.Maximum = 99
                valu_goodi_4.Value = valu_setall.Value
                valu_goodi_5.Maximum = 99
                valu_goodi_5.Value = valu_setall.Value
                valu_goodi_6.Maximum = 99
                valu_goodi_6.Value = valu_setall.Value
                valu_goodi_7.Maximum = 99
                valu_goodi_7.Value = valu_setall.Value
                valu_goodi_8.Maximum = 99
                valu_goodi_8.Value = valu_setall.Value
                valu_goodi_9.Maximum = 99
                valu_goodi_9.Value = valu_setall.Value
                valu_goodi_10.Maximum = 99
                valu_goodi_10.Value = valu_setall.Value
                valu_goodi_11.Maximum = 99
                valu_goodi_11.Value = valu_setall.Value
                valu_goodi_12.Maximum = 99
                valu_goodi_12.Value = valu_setall.Value
                valu_goodi_13.Maximum = 99
                valu_goodi_13.Value = valu_setall.Value
                valu_goodi_14.Maximum = 99
                valu_goodi_14.Value = valu_setall.Value
                valu_goodi_15.Maximum = 99
                valu_goodi_15.Value = valu_setall.Value
                valu_goodi_16.Maximum = 99
                valu_goodi_16.Value = valu_setall.Value
                valu_goodi_17.Maximum = 99
                valu_goodi_17.Value = valu_setall.Value
                valu_goodi_18.Maximum = 99
                valu_goodi_18.Value = valu_setall.Value
            End If
        End If
        'end goodsitems
    End Sub

    Private Sub Check_setall_available_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setall_available.CheckedChanged
        If Check_setall_available.Checked = True Then
            Check_setall_unavailable.Enabled = False
            Check_setall_valu.Enabled = False
        ElseIf Check_setall_available.Checked = False Then
            Check_setall_unavailable.Enabled = True
            Check_setall_valu.Enabled = True
        End If
    End Sub

    Private Sub Check_setall_unavailable_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setall_unavailable.CheckedChanged
        If Check_setall_unavailable.Checked = True Then
            Check_setall_available.Enabled = False
            Check_setall_valu.Enabled = False
        ElseIf Check_setall_unavailable.Checked = False Then
            Check_setall_available.Enabled = True
            Check_setall_valu.Enabled = True
        End If
    End Sub

    Private Sub Check_setall_valu_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setall_valu.CheckedChanged
        If Check_setall_valu.Checked = True Then
            Check_setall_available.Enabled = False
            Check_setall_unavailable.Enabled = False
        ElseIf Check_setall_valu.Checked = False Then
            Check_setall_available.Enabled = True
            Check_setall_unavailable.Enabled = True
        End If
    End Sub

    Private Sub Fea_setclick_CheckedChanged(sender As Object, e As EventArgs) Handles Fea_setclick.CheckedChanged
        If Fea_setclick.Checked = True Then
            Panel_goodi_1.Cursor = Cursors.Hand
            Panel_goodi_2.Cursor = Cursors.Hand
            Panel_goodi_3.Cursor = Cursors.Hand
            Panel_goodi_4.Cursor = Cursors.Hand
            Panel_goodi_5.Cursor = Cursors.Hand
            Panel_goodi_6.Cursor = Cursors.Hand
            Panel_goodi_7.Cursor = Cursors.Hand
            Panel_goodi_8.Cursor = Cursors.Hand
            Panel_goodi_9.Cursor = Cursors.Hand
            Panel_goodi_10.Cursor = Cursors.Hand
            Panel_goodi_11.Cursor = Cursors.Hand
            Panel_goodi_12.Cursor = Cursors.Hand
            Panel_goodi_13.Cursor = Cursors.Hand
            Panel_goodi_14.Cursor = Cursors.Hand
            Panel_goodi_15.Cursor = Cursors.Hand
            Panel_goodi_16.Cursor = Cursors.Hand
            Panel_goodi_17.Cursor = Cursors.Hand
            Panel_goodi_18.Cursor = Cursors.Hand
        Else
            Panel_goodi_1.Cursor = Cursors.Default
            Panel_goodi_2.Cursor = Cursors.Default
            Panel_goodi_3.Cursor = Cursors.Default
            Panel_goodi_4.Cursor = Cursors.Default
            Panel_goodi_5.Cursor = Cursors.Default
            Panel_goodi_6.Cursor = Cursors.Default
            Panel_goodi_7.Cursor = Cursors.Default
            Panel_goodi_8.Cursor = Cursors.Default
            Panel_goodi_9.Cursor = Cursors.Default
            Panel_goodi_10.Cursor = Cursors.Default
            Panel_goodi_11.Cursor = Cursors.Default
            Panel_goodi_12.Cursor = Cursors.Default
            Panel_goodi_13.Cursor = Cursors.Default
            Panel_goodi_14.Cursor = Cursors.Default
            Panel_goodi_15.Cursor = Cursors.Default
            Panel_goodi_16.Cursor = Cursors.Default
            Panel_goodi_17.Cursor = Cursors.Default
            Panel_goodi_18.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Panel_goodi_1_Click(sender As Object, e As EventArgs) Handles Panel_goodi_1.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_1.Maximum = 255
                valu_goodi_1.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_1.Maximum = 255
                valu_goodi_1.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_1.Maximum = 99
                valu_goodi_1.Value = valu_setclick.Value
            End If
        End If
    End Sub

    Private Sub Panel_goodi_2_Click(sender As Object, e As EventArgs) Handles Panel_goodi_2.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_2.Maximum = 255
                valu_goodi_2.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_2.Maximum = 255
                valu_goodi_2.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_2.Maximum = 99
                valu_goodi_2.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_3_Click(sender As Object, e As EventArgs) Handles Panel_goodi_3.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_3.Maximum = 255
                valu_goodi_3.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_3.Maximum = 255
                valu_goodi_3.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_3.Maximum = 99
                valu_goodi_3.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_4_Click(sender As Object, e As EventArgs) Handles Panel_goodi_4.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_4.Maximum = 255
                valu_goodi_4.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_4.Maximum = 255
                valu_goodi_4.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_4.Maximum = 99
                valu_goodi_4.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_5_Click(sender As Object, e As EventArgs) Handles Panel_goodi_5.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_5.Maximum = 255
                valu_goodi_5.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_5.Maximum = 255
                valu_goodi_5.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_5.Maximum = 99
                valu_goodi_5.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_6_Click(sender As Object, e As EventArgs) Handles Panel_goodi_6.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_6.Maximum = 255
                valu_goodi_6.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_6.Maximum = 255
                valu_goodi_6.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_6.Maximum = 99
                valu_goodi_6.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_7_Click(sender As Object, e As EventArgs) Handles Panel_goodi_7.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_7.Maximum = 255
                valu_goodi_7.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_7.Maximum = 255
                valu_goodi_7.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_7.Maximum = 99
                valu_goodi_7.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_8_Click(sender As Object, e As EventArgs) Handles Panel_goodi_8.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_8.Maximum = 255
                valu_goodi_8.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_8.Maximum = 255
                valu_goodi_8.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_8.Maximum = 99
                valu_goodi_8.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_9_Click(sender As Object, e As EventArgs) Handles Panel_goodi_9.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_9.Maximum = 255
                valu_goodi_9.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_9.Maximum = 255
                valu_goodi_9.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_9.Maximum = 99
                valu_goodi_9.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_10_Click(sender As Object, e As EventArgs) Handles Panel_goodi_10.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_10.Maximum = 255
                valu_goodi_10.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_10.Maximum = 255
                valu_goodi_10.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_10.Maximum = 99
                valu_goodi_10.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_11_Click(sender As Object, e As EventArgs) Handles Panel_goodi_11.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_11.Maximum = 255
                valu_goodi_11.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_11.Maximum = 255
                valu_goodi_11.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_11.Maximum = 99
                valu_goodi_11.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_12_Click(sender As Object, e As EventArgs) Handles Panel_goodi_12.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_12.Maximum = 255
                valu_goodi_12.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_12.Maximum = 255
                valu_goodi_12.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_12.Maximum = 99
                valu_goodi_12.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_13_Click(sender As Object, e As EventArgs) Handles Panel_goodi_13.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_13.Maximum = 255
                valu_goodi_13.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_13.Maximum = 255
                valu_goodi_13.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_13.Maximum = 99
                valu_goodi_13.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_14_Click(sender As Object, e As EventArgs) Handles Panel_goodi_14.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_14.Maximum = 255
                valu_goodi_14.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_14.Maximum = 255
                valu_goodi_14.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_14.Maximum = 99
                valu_goodi_14.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_15_Click(sender As Object, e As EventArgs) Handles Panel_goodi_15.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_15.Maximum = 255
                valu_goodi_15.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_15.Maximum = 255
                valu_goodi_15.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_15.Maximum = 99
                valu_goodi_15.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_16_Click(sender As Object, e As EventArgs) Handles Panel_goodi_16.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_16.Maximum = 255
                valu_goodi_16.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_16.Maximum = 255
                valu_goodi_16.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_16.Maximum = 99
                valu_goodi_16.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_17_Click(sender As Object, e As EventArgs) Handles Panel_goodi_17.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_17.Maximum = 255
                valu_goodi_17.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_17.Maximum = 255
                valu_goodi_17.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_17.Maximum = 99
                valu_goodi_17.Value = valu_setclick.Value
            End If
        End If
    End Sub
    Private Sub Panel_goodi_18_Click(sender As Object, e As EventArgs) Handles Panel_goodi_18.Click
        If Fea_setclick.Checked = True Then
            If Check_setclick_available.Checked = True Then
                valu_goodi_18.Maximum = 255
                valu_goodi_18.Value = 254
            End If
            If Check_setclick_unavailable.Checked = True Then
                valu_goodi_18.Maximum = 255
                valu_goodi_18.Value = 253
            End If
            If Check_setclick_valu.Checked = True Then
                valu_goodi_18.Maximum = 99
                valu_goodi_18.Value = valu_setclick.Value
            End If
        End If
    End Sub

    Public Sub Checkitems()
        If valu_goodi_1.Value = 254 Then
            Check_available_goodi_1.Checked = True
            Check_NA_goodi_1.Checked = False
            Check_available_goodi_1.Enabled = True
            Check_NA_goodi_1.Enabled = False
            valu_goodi_1.Enabled = False
        ElseIf valu_goodi_1.Value = 253 Then
            Check_available_goodi_1.Checked = False
            Check_NA_goodi_1.Checked = True
            Check_available_goodi_1.Enabled = False
            Check_NA_goodi_1.Enabled = True
            valu_goodi_1.Enabled = False
        ElseIf valu_goodi_1.Value <= 99 Then
            Check_available_goodi_1.Checked = False
            Check_NA_goodi_1.Checked = False
            Check_available_goodi_1.Enabled = True
            Check_NA_goodi_1.Enabled = True
            valu_goodi_1.Enabled = True
        End If
        If valu_goodi_2.Value = 254 Then
            Check_available_goodi_2.Checked = True
            Check_NA_goodi_2.Checked = False
            Check_available_goodi_2.Enabled = True
            Check_NA_goodi_2.Enabled = False
            valu_goodi_2.Enabled = False
        ElseIf valu_goodi_2.Value = 253 Then
            Check_available_goodi_2.Checked = False
            Check_NA_goodi_2.Checked = True
            Check_available_goodi_2.Enabled = False
            Check_NA_goodi_2.Enabled = True
            valu_goodi_2.Enabled = False
        ElseIf valu_goodi_2.Value <= 99 Then
            Check_available_goodi_2.Checked = False
            Check_NA_goodi_2.Checked = False
            Check_available_goodi_2.Enabled = True
            Check_NA_goodi_2.Enabled = True
            valu_goodi_2.Enabled = True
        End If
        If valu_goodi_3.Value = 254 Then
            Check_available_goodi_3.Checked = True
            Check_NA_goodi_3.Checked = False
            Check_available_goodi_3.Enabled = True
            Check_NA_goodi_3.Enabled = False
            valu_goodi_3.Enabled = False
        ElseIf valu_goodi_3.Value = 253 Then
            Check_available_goodi_3.Checked = False
            Check_NA_goodi_3.Checked = True
            Check_available_goodi_3.Enabled = False
            Check_NA_goodi_3.Enabled = True
            valu_goodi_3.Enabled = False
        ElseIf valu_goodi_3.Value <= 99 Then
            Check_available_goodi_3.Checked = False
            Check_NA_goodi_3.Checked = False
            Check_available_goodi_3.Enabled = True
            Check_NA_goodi_3.Enabled = True
            valu_goodi_3.Enabled = True
        End If
        If valu_goodi_4.Value = 254 Then
            Check_available_goodi_4.Checked = True
            Check_NA_goodi_4.Checked = False
            Check_available_goodi_4.Enabled = True
            Check_NA_goodi_4.Enabled = False
            valu_goodi_4.Enabled = False
        ElseIf valu_goodi_4.Value = 253 Then
            Check_available_goodi_4.Checked = False
            Check_NA_goodi_4.Checked = True
            Check_available_goodi_4.Enabled = False
            Check_NA_goodi_4.Enabled = True
            valu_goodi_4.Enabled = False
        ElseIf valu_goodi_4.Value <= 99 Then
            Check_available_goodi_4.Checked = False
            Check_NA_goodi_4.Checked = False
            Check_available_goodi_4.Enabled = True
            Check_NA_goodi_4.Enabled = True
            valu_goodi_4.Enabled = True
        End If
        If valu_goodi_5.Value = 254 Then
            Check_available_goodi_5.Checked = True
            Check_NA_goodi_5.Checked = False
            Check_available_goodi_5.Enabled = True
            Check_NA_goodi_5.Enabled = False
            valu_goodi_5.Enabled = False
        ElseIf valu_goodi_5.Value = 253 Then
            Check_available_goodi_5.Checked = False
            Check_NA_goodi_5.Checked = True
            Check_available_goodi_5.Enabled = False
            Check_NA_goodi_5.Enabled = True
            valu_goodi_5.Enabled = False
        ElseIf valu_goodi_5.Value <= 99 Then
            Check_available_goodi_5.Checked = False
            Check_NA_goodi_5.Checked = False
            Check_available_goodi_5.Enabled = True
            Check_NA_goodi_5.Enabled = True
            valu_goodi_5.Enabled = True
        End If
        If valu_goodi_6.Value = 254 Then
            Check_available_goodi_6.Checked = True
            Check_NA_goodi_6.Checked = False
            Check_available_goodi_6.Enabled = True
            Check_NA_goodi_6.Enabled = False
            valu_goodi_6.Enabled = False
        ElseIf valu_goodi_6.Value = 253 Then
            Check_available_goodi_6.Checked = False
            Check_NA_goodi_6.Checked = True
            Check_available_goodi_6.Enabled = False
            Check_NA_goodi_6.Enabled = True
            valu_goodi_6.Enabled = False
        ElseIf valu_goodi_6.Value <= 99 Then
            Check_available_goodi_6.Checked = False
            Check_NA_goodi_6.Checked = False
            Check_available_goodi_6.Enabled = True
            Check_NA_goodi_6.Enabled = True
            valu_goodi_6.Enabled = True
        End If
        If valu_goodi_7.Value = 254 Then
            Check_available_goodi_7.Checked = True
            Check_NA_goodi_7.Checked = False
            Check_available_goodi_7.Enabled = True
            Check_NA_goodi_7.Enabled = False
            valu_goodi_7.Enabled = False
        ElseIf valu_goodi_7.Value = 253 Then
            Check_available_goodi_7.Checked = False
            Check_NA_goodi_7.Checked = True
            Check_available_goodi_7.Enabled = False
            Check_NA_goodi_7.Enabled = True
            valu_goodi_7.Enabled = False
        ElseIf valu_goodi_7.Value <= 99 Then
            Check_available_goodi_7.Checked = False
            Check_NA_goodi_7.Checked = False
            Check_available_goodi_7.Enabled = True
            Check_NA_goodi_7.Enabled = True
            valu_goodi_7.Enabled = True
        End If
        If valu_goodi_8.Value = 254 Then
            Check_available_goodi_8.Checked = True
            Check_NA_goodi_8.Checked = False
            Check_available_goodi_8.Enabled = True
            Check_NA_goodi_8.Enabled = False
            valu_goodi_8.Enabled = False
        ElseIf valu_goodi_8.Value = 253 Then
            Check_available_goodi_8.Checked = False
            Check_NA_goodi_8.Checked = True
            Check_available_goodi_8.Enabled = False
            Check_NA_goodi_8.Enabled = True
            valu_goodi_8.Enabled = False
        ElseIf valu_goodi_8.Value <= 99 Then
            Check_available_goodi_8.Checked = False
            Check_NA_goodi_8.Checked = False
            Check_available_goodi_8.Enabled = True
            Check_NA_goodi_8.Enabled = True
            valu_goodi_8.Enabled = True
        End If
        If valu_goodi_9.Value = 254 Then
            Check_available_goodi_9.Checked = True
            Check_NA_goodi_9.Checked = False
            Check_available_goodi_9.Enabled = True
            Check_NA_goodi_9.Enabled = False
            valu_goodi_9.Enabled = False
        ElseIf valu_goodi_9.Value = 253 Then
            Check_available_goodi_9.Checked = False
            Check_NA_goodi_9.Checked = True
            Check_available_goodi_9.Enabled = False
            Check_NA_goodi_9.Enabled = True
            valu_goodi_9.Enabled = False
        ElseIf valu_goodi_9.Value <= 99 Then
            Check_available_goodi_9.Checked = False
            Check_NA_goodi_9.Checked = False
            Check_available_goodi_9.Enabled = True
            Check_NA_goodi_9.Enabled = True
            valu_goodi_9.Enabled = True
        End If
        If valu_goodi_10.Value = 254 Then
            Check_available_goodi_10.Checked = True
            Check_NA_goodi_10.Checked = False
            Check_available_goodi_10.Enabled = True
            Check_NA_goodi_10.Enabled = False
            valu_goodi_10.Enabled = False
        ElseIf valu_goodi_10.Value = 253 Then
            Check_available_goodi_10.Checked = False
            Check_NA_goodi_10.Checked = True
            Check_available_goodi_10.Enabled = False
            Check_NA_goodi_10.Enabled = True
            valu_goodi_10.Enabled = False
        ElseIf valu_goodi_10.Value <= 99 Then
            Check_available_goodi_10.Checked = False
            Check_NA_goodi_10.Checked = False
            Check_available_goodi_10.Enabled = True
            Check_NA_goodi_10.Enabled = True
            valu_goodi_10.Enabled = True
        End If
        If valu_goodi_11.Value = 254 Then
            Check_available_goodi_11.Checked = True
            Check_NA_goodi_11.Checked = False
            Check_available_goodi_11.Enabled = True
            Check_NA_goodi_11.Enabled = False
            valu_goodi_11.Enabled = False
        ElseIf valu_goodi_11.Value = 253 Then
            Check_available_goodi_11.Checked = False
            Check_NA_goodi_11.Checked = True
            Check_available_goodi_11.Enabled = False
            Check_NA_goodi_11.Enabled = True
            valu_goodi_11.Enabled = False
        ElseIf valu_goodi_11.Value <= 99 Then
            Check_available_goodi_11.Checked = False
            Check_NA_goodi_11.Checked = False
            Check_available_goodi_11.Enabled = True
            Check_NA_goodi_11.Enabled = True
            valu_goodi_11.Enabled = True
        End If
        If valu_goodi_12.Value = 254 Then
            Check_available_goodi_12.Checked = True
            Check_NA_goodi_12.Checked = False
            Check_available_goodi_12.Enabled = True
            Check_NA_goodi_12.Enabled = False
            valu_goodi_12.Enabled = False
        ElseIf valu_goodi_12.Value = 253 Then
            Check_available_goodi_12.Checked = False
            Check_NA_goodi_12.Checked = True
            Check_available_goodi_12.Enabled = False
            Check_NA_goodi_12.Enabled = True
            valu_goodi_12.Enabled = False
        ElseIf valu_goodi_12.Value <= 99 Then
            Check_available_goodi_12.Checked = False
            Check_NA_goodi_12.Checked = False
            Check_available_goodi_12.Enabled = True
            Check_NA_goodi_12.Enabled = True
            valu_goodi_12.Enabled = True
        End If
        If valu_goodi_13.Value = 254 Then
            Check_available_goodi_13.Checked = True
            Check_NA_goodi_13.Checked = False
            Check_available_goodi_13.Enabled = True
            Check_NA_goodi_13.Enabled = False
            valu_goodi_13.Enabled = False
        ElseIf valu_goodi_13.Value = 253 Then
            Check_available_goodi_13.Checked = False
            Check_NA_goodi_13.Checked = True
            Check_available_goodi_13.Enabled = False
            Check_NA_goodi_13.Enabled = True
            valu_goodi_13.Enabled = False
        ElseIf valu_goodi_13.Value <= 99 Then
            Check_available_goodi_13.Checked = False
            Check_NA_goodi_13.Checked = False
            Check_available_goodi_13.Enabled = True
            Check_NA_goodi_13.Enabled = True
            valu_goodi_13.Enabled = True
        End If
        If valu_goodi_14.Value = 254 Then
            Check_available_goodi_14.Checked = True
            Check_NA_goodi_14.Checked = False
            Check_available_goodi_14.Enabled = True
            Check_NA_goodi_14.Enabled = False
            valu_goodi_14.Enabled = False
        ElseIf valu_goodi_14.Value = 253 Then
            Check_available_goodi_14.Checked = False
            Check_NA_goodi_14.Checked = True
            Check_available_goodi_14.Enabled = False
            Check_NA_goodi_14.Enabled = True
            valu_goodi_14.Enabled = False
        ElseIf valu_goodi_14.Value <= 99 Then
            Check_available_goodi_14.Checked = False
            Check_NA_goodi_14.Checked = False
            Check_available_goodi_14.Enabled = True
            Check_NA_goodi_14.Enabled = True
            valu_goodi_14.Enabled = True
        End If
        If valu_goodi_15.Value = 254 Then
            Check_available_goodi_15.Checked = True
            Check_NA_goodi_15.Checked = False
            Check_available_goodi_15.Enabled = True
            Check_NA_goodi_15.Enabled = False
            valu_goodi_15.Enabled = False
        ElseIf valu_goodi_15.Value = 253 Then
            Check_available_goodi_15.Checked = False
            Check_NA_goodi_15.Checked = True
            Check_available_goodi_15.Enabled = False
            Check_NA_goodi_15.Enabled = True
            valu_goodi_15.Enabled = False
        ElseIf valu_goodi_15.Value <= 99 Then
            Check_available_goodi_15.Checked = False
            Check_NA_goodi_15.Checked = False
            Check_available_goodi_15.Enabled = True
            Check_NA_goodi_15.Enabled = True
            valu_goodi_15.Enabled = True
        End If
        If valu_goodi_16.Value = 254 Then
            Check_available_goodi_16.Checked = True
            Check_NA_goodi_16.Checked = False
            Check_available_goodi_16.Enabled = True
            Check_NA_goodi_16.Enabled = False
            valu_goodi_16.Enabled = False
        ElseIf valu_goodi_16.Value = 253 Then
            Check_available_goodi_16.Checked = False
            Check_NA_goodi_16.Checked = True
            Check_available_goodi_16.Enabled = False
            Check_NA_goodi_16.Enabled = True
            valu_goodi_16.Enabled = False
        ElseIf valu_goodi_16.Value <= 99 Then
            Check_available_goodi_16.Checked = False
            Check_NA_goodi_16.Checked = False
            Check_available_goodi_16.Enabled = True
            Check_NA_goodi_16.Enabled = True
            valu_goodi_16.Enabled = True
        End If
        If valu_goodi_17.Value = 254 Then
            Check_available_goodi_17.Checked = True
            Check_NA_goodi_17.Checked = False
            Check_available_goodi_17.Enabled = True
            Check_NA_goodi_17.Enabled = False
            valu_goodi_17.Enabled = False
        ElseIf valu_goodi_17.Value = 253 Then
            Check_available_goodi_17.Checked = False
            Check_NA_goodi_17.Checked = True
            Check_available_goodi_17.Enabled = False
            Check_NA_goodi_17.Enabled = True
            valu_goodi_17.Enabled = False
        ElseIf valu_goodi_17.Value <= 99 Then
            Check_available_goodi_17.Checked = False
            Check_NA_goodi_17.Checked = False
            Check_available_goodi_17.Enabled = True
            Check_NA_goodi_17.Enabled = True
            valu_goodi_17.Enabled = True
        End If
        If valu_goodi_18.Value = 254 Then
            Check_available_goodi_18.Checked = True
            Check_NA_goodi_18.Checked = False
            Check_available_goodi_18.Enabled = True
            Check_NA_goodi_18.Enabled = False
            valu_goodi_18.Enabled = False
        ElseIf valu_goodi_18.Value = 253 Then
            Check_available_goodi_18.Checked = False
            Check_NA_goodi_18.Checked = True
            Check_available_goodi_18.Enabled = False
            Check_NA_goodi_18.Enabled = True
            valu_goodi_18.Enabled = False
        ElseIf valu_goodi_18.Value <= 99 Then
            Check_available_goodi_18.Checked = False
            Check_NA_goodi_18.Checked = False
            Check_available_goodi_18.Enabled = True
            Check_NA_goodi_18.Enabled = True
            valu_goodi_18.Enabled = True
        End If
    End Sub

    Private Sub valu_goodi_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_1.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_2.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_3.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_4.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_5.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_6.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_7.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_8.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_9_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_9.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_10_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_10.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_11_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_11.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_12_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_12.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_13_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_13.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_14_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_14.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_15_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_15.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_16_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_16.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_17_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_17.ValueChanged
        Checkitems()
    End Sub

    Private Sub valu_goodi_18_ValueChanged(sender As Object, e As EventArgs) Handles valu_goodi_18.ValueChanged
        Checkitems()
    End Sub

    Private Sub Check_available_goodi_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_1.CheckedChanged
        If Check_available_goodi_1.Checked = True Then
            valu_goodi_1.Maximum = 255
            valu_goodi_1.Value = 254
        End If
        If Check_available_goodi_1.Checked = False Then
            valu_goodi_1.Maximum = 99
            valu_goodi_1.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_1.CheckedChanged
        If Check_NA_goodi_1.Checked = True Then
            valu_goodi_1.Maximum = 255
            valu_goodi_1.Value = 253
        End If
        If Check_NA_goodi_1.Checked = False Then
            valu_goodi_1.Maximum = 99
            valu_goodi_1.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_2.CheckedChanged
        If Check_available_goodi_2.Checked = True Then
            valu_goodi_2.Maximum = 255
            valu_goodi_2.Value = 254
        End If
        If Check_available_goodi_2.Checked = False Then
            valu_goodi_2.Maximum = 99
            valu_goodi_2.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_2_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_2.CheckedChanged
        If Check_NA_goodi_2.Checked = True Then
            valu_goodi_2.Maximum = 255
            valu_goodi_2.Value = 253
        End If
        If Check_NA_goodi_2.Checked = False Then
            valu_goodi_2.Maximum = 99
            valu_goodi_2.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_3.CheckedChanged
        If Check_available_goodi_3.Checked = True Then
            valu_goodi_3.Maximum = 255
            valu_goodi_3.Value = 254
        End If
        If Check_available_goodi_3.Checked = False Then
            valu_goodi_3.Maximum = 99
            valu_goodi_3.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_3_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_3.CheckedChanged
        If Check_NA_goodi_3.Checked = True Then
            valu_goodi_3.Maximum = 255
            valu_goodi_3.Value = 253
        End If
        If Check_NA_goodi_3.Checked = False Then
            valu_goodi_3.Maximum = 99
            valu_goodi_3.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_4.CheckedChanged
        If Check_available_goodi_4.Checked = True Then
            valu_goodi_4.Maximum = 255
            valu_goodi_4.Value = 254
        End If
        If Check_available_goodi_4.Checked = False Then
            valu_goodi_4.Maximum = 99
            valu_goodi_4.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_4_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_4.CheckedChanged
        If Check_NA_goodi_4.Checked = True Then
            valu_goodi_4.Maximum = 255
            valu_goodi_4.Value = 253
        End If
        If Check_NA_goodi_4.Checked = False Then
            valu_goodi_4.Maximum = 99
            valu_goodi_4.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_5.CheckedChanged
        If Check_available_goodi_5.Checked = True Then
            valu_goodi_5.Maximum = 255
            valu_goodi_5.Value = 254
        End If
        If Check_available_goodi_5.Checked = False Then
            valu_goodi_5.Maximum = 99
            valu_goodi_5.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_5_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_5.CheckedChanged
        If Check_NA_goodi_5.Checked = True Then
            valu_goodi_5.Maximum = 255
            valu_goodi_5.Value = 253
        End If
        If Check_NA_goodi_5.Checked = False Then
            valu_goodi_5.Maximum = 99
            valu_goodi_5.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_6.CheckedChanged
        If Check_available_goodi_6.Checked = True Then
            valu_goodi_6.Maximum = 255
            valu_goodi_6.Value = 254
        End If
        If Check_available_goodi_6.Checked = False Then
            valu_goodi_6.Maximum = 99
            valu_goodi_6.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_6_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_6.CheckedChanged
        If Check_NA_goodi_6.Checked = True Then
            valu_goodi_6.Maximum = 255
            valu_goodi_6.Value = 253
        End If
        If Check_NA_goodi_6.Checked = False Then
            valu_goodi_6.Maximum = 99
            valu_goodi_6.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_7.CheckedChanged
        If Check_available_goodi_7.Checked = True Then
            valu_goodi_7.Maximum = 255
            valu_goodi_7.Value = 254
        End If
        If Check_available_goodi_7.Checked = False Then
            valu_goodi_7.Maximum = 99
            valu_goodi_7.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_7_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_7.CheckedChanged
        If Check_NA_goodi_7.Checked = True Then
            valu_goodi_7.Maximum = 255
            valu_goodi_7.Value = 253
        End If
        If Check_NA_goodi_7.Checked = False Then
            valu_goodi_7.Maximum = 99
            valu_goodi_7.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_8.CheckedChanged
        If Check_available_goodi_8.Checked = True Then
            valu_goodi_8.Maximum = 255
            valu_goodi_8.Value = 254
        End If
        If Check_available_goodi_8.Checked = False Then
            valu_goodi_8.Maximum = 99
            valu_goodi_8.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_8_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_8.CheckedChanged
        If Check_NA_goodi_8.Checked = True Then
            valu_goodi_8.Maximum = 255
            valu_goodi_8.Value = 253
        End If
        If Check_NA_goodi_8.Checked = False Then
            valu_goodi_8.Maximum = 99
            valu_goodi_8.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_9_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_9.CheckedChanged
        If Check_available_goodi_9.Checked = True Then
            valu_goodi_9.Maximum = 255
            valu_goodi_9.Value = 254
        End If
        If Check_available_goodi_9.Checked = False Then
            valu_goodi_9.Maximum = 99
            valu_goodi_9.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_9_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_9.CheckedChanged
        If Check_NA_goodi_9.Checked = True Then
            valu_goodi_9.Maximum = 255
            valu_goodi_9.Value = 253
        End If
        If Check_NA_goodi_9.Checked = False Then
            valu_goodi_9.Maximum = 99
            valu_goodi_9.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_10_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_10.CheckedChanged
        If Check_available_goodi_10.Checked = True Then
            valu_goodi_10.Maximum = 255
            valu_goodi_10.Value = 254
        End If
        If Check_available_goodi_10.Checked = False Then
            valu_goodi_10.Maximum = 99
            valu_goodi_10.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_10_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_10.CheckedChanged
        If Check_NA_goodi_10.Checked = True Then
            valu_goodi_10.Maximum = 255
            valu_goodi_10.Value = 253
        End If
        If Check_NA_goodi_10.Checked = False Then
            valu_goodi_10.Maximum = 99
            valu_goodi_10.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_11_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_11.CheckedChanged
        If Check_available_goodi_11.Checked = True Then
            valu_goodi_11.Maximum = 255
            valu_goodi_11.Value = 254
        End If
        If Check_available_goodi_11.Checked = False Then
            valu_goodi_11.Maximum = 99
            valu_goodi_11.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_11_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_11.CheckedChanged
        If Check_NA_goodi_11.Checked = True Then
            valu_goodi_11.Maximum = 255
            valu_goodi_11.Value = 253
        End If
        If Check_NA_goodi_11.Checked = False Then
            valu_goodi_11.Maximum = 99
            valu_goodi_11.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_12_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_12.CheckedChanged
        If Check_available_goodi_12.Checked = True Then
            valu_goodi_12.Maximum = 255
            valu_goodi_12.Value = 254
        End If
        If Check_available_goodi_12.Checked = False Then
            valu_goodi_12.Maximum = 99
            valu_goodi_12.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_12_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_12.CheckedChanged
        If Check_NA_goodi_12.Checked = True Then
            valu_goodi_12.Maximum = 255
            valu_goodi_12.Value = 253
        End If
        If Check_NA_goodi_12.Checked = False Then
            valu_goodi_12.Maximum = 99
            valu_goodi_12.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_13_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_13.CheckedChanged
        If Check_available_goodi_13.Checked = True Then
            valu_goodi_13.Maximum = 255
            valu_goodi_13.Value = 254
        End If
        If Check_available_goodi_13.Checked = False Then
            valu_goodi_13.Maximum = 99
            valu_goodi_13.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_13_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_13.CheckedChanged
        If Check_NA_goodi_13.Checked = True Then
            valu_goodi_13.Maximum = 255
            valu_goodi_13.Value = 253
        End If
        If Check_NA_goodi_13.Checked = False Then
            valu_goodi_13.Maximum = 99
            valu_goodi_13.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_14_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_14.CheckedChanged
        If Check_available_goodi_14.Checked = True Then
            valu_goodi_14.Maximum = 255
            valu_goodi_14.Value = 254
        End If
        If Check_available_goodi_14.Checked = False Then
            valu_goodi_14.Maximum = 99
            valu_goodi_14.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_14_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_14.CheckedChanged
        If Check_NA_goodi_14.Checked = True Then
            valu_goodi_14.Maximum = 255
            valu_goodi_14.Value = 253
        End If
        If Check_NA_goodi_14.Checked = False Then
            valu_goodi_14.Maximum = 99
            valu_goodi_14.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_15_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_15.CheckedChanged
        If Check_available_goodi_15.Checked = True Then
            valu_goodi_15.Maximum = 255
            valu_goodi_15.Value = 254
        End If
        If Check_available_goodi_15.Checked = False Then
            valu_goodi_15.Maximum = 99
            valu_goodi_15.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_15_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_15.CheckedChanged
        If Check_NA_goodi_15.Checked = True Then
            valu_goodi_15.Maximum = 255
            valu_goodi_15.Value = 253
        End If
        If Check_NA_goodi_15.Checked = False Then
            valu_goodi_15.Maximum = 99
            valu_goodi_15.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_16_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_16.CheckedChanged
        If Check_available_goodi_16.Checked = True Then
            valu_goodi_16.Maximum = 255
            valu_goodi_16.Value = 254
        End If
        If Check_available_goodi_16.Checked = False Then
            valu_goodi_16.Maximum = 99
            valu_goodi_16.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_16_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_16.CheckedChanged
        If Check_NA_goodi_16.Checked = True Then
            valu_goodi_16.Maximum = 255
            valu_goodi_16.Value = 253
        End If
        If Check_NA_goodi_16.Checked = False Then
            valu_goodi_16.Maximum = 99
            valu_goodi_16.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_17_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_17.CheckedChanged
        If Check_available_goodi_17.Checked = True Then
            valu_goodi_17.Maximum = 255
            valu_goodi_17.Value = 254
        End If
        If Check_available_goodi_17.Checked = False Then
            valu_goodi_17.Maximum = 99
            valu_goodi_17.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_17_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_17.CheckedChanged
        If Check_NA_goodi_17.Checked = True Then
            valu_goodi_17.Maximum = 255
            valu_goodi_17.Value = 253
        End If
        If Check_NA_goodi_17.Checked = False Then
            valu_goodi_17.Maximum = 99
            valu_goodi_17.Value = 99
        End If
    End Sub

    Private Sub Check_available_goodi_18_CheckedChanged(sender As Object, e As EventArgs) Handles Check_available_goodi_18.CheckedChanged
        If Check_available_goodi_18.Checked = True Then
            valu_goodi_18.Maximum = 255
            valu_goodi_18.Value = 254
        End If
        If Check_available_goodi_18.Checked = False Then
            valu_goodi_18.Maximum = 99
            valu_goodi_18.Value = 99
        End If
    End Sub

    Private Sub Check_NA_goodi_18_CheckedChanged(sender As Object, e As EventArgs) Handles Check_NA_goodi_18.CheckedChanged
        If Check_NA_goodi_18.Checked = True Then
            valu_goodi_18.Maximum = 255
            valu_goodi_18.Value = 253
        End If
        If Check_NA_goodi_18.Checked = False Then
            valu_goodi_18.Maximum = 99
            valu_goodi_18.Value = 99
        End If
    End Sub

    Private Sub Check_setclick_available_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setclick_available.CheckedChanged
        If Check_setclick_available.Checked = True Then
            Check_setclick_unavailable.Enabled = False
            Check_setclick_valu.Enabled = False
        End If
        If Check_setclick_available.Checked = False Then
            Check_setclick_unavailable.Enabled = True
            Check_setclick_valu.Enabled = True
        End If
    End Sub

    Private Sub Check_setclick_unavailable_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setclick_unavailable.CheckedChanged
        If Check_setclick_unavailable.Checked = True Then
            Check_setclick_available.Enabled = False
            Check_setclick_valu.Enabled = False
        End If
        If Check_setclick_unavailable.Checked = False Then
            Check_setclick_available.Enabled = True
            Check_setclick_valu.Enabled = True
        End If
    End Sub

    Private Sub Check_setclick_valu_CheckedChanged(sender As Object, e As EventArgs) Handles Check_setclick_valu.CheckedChanged
        If Check_setclick_valu.Checked = True Then
            Check_setclick_unavailable.Enabled = False
            Check_setclick_available.Enabled = False
        End If
        If Check_setclick_valu.Checked = False Then
            Check_setclick_unavailable.Enabled = True
            Check_setclick_available.Enabled = True
        End If
    End Sub

    Public Sub savefileregion()
        'goodsitems
        Goodsitems1 = &H18F0
        Goodsitems2 = &H18F1
        Goodsitems3 = &H18F2
        Goodsitems4 = &H18F3
        Goodsitems5 = &H18F4
        Goodsitems6 = &H18F5
        Goodsitems7 = &H18F6
        Goodsitems8 = &H18F7
        Goodsitems9 = &H18F8
        Goodsitems10 = &H18F9
        Goodsitems11 = &H18FA
        Goodsitems12 = &H18FB
        Goodsitems13 = &H18FC
        Goodsitems14 = &H18FD
        Goodsitems15 = &H18FE
        Goodsitems16 = &H18FF
        Goodsitems17 = &H1900
        If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
            Goodsitems18 = &H1901
        End If
        If Filever_text.Text = "EU" Then
            Panel_goodi_2.BackgroundImage = My.Resources.EU_gooditems_02
            Panel_goodi_6.BackgroundImage = My.Resources.EU_gooditems_06
        End If
        If Filever_text.Text = "US" Then
            Panel_goodi_2.BackgroundImage = My.Resources.US_gooditems_02
            Panel_goodi_6.BackgroundImage = My.Resources.US_gooditems_06
        End If
        'end goodsitems
    End Sub

    Public Sub Readgoodsitems()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = Goodsitems1
            valu_goodi_1.Value = Reader.ReadByte
            Reader.Position = Goodsitems2
            valu_goodi_2.Value = Reader.ReadByte
            Reader.Position = Goodsitems3
            valu_goodi_3.Value = Reader.ReadByte
            Reader.Position = Goodsitems4
            valu_goodi_4.Value = Reader.ReadByte
            Reader.Position = Goodsitems5
            valu_goodi_5.Value = Reader.ReadByte
            Reader.Position = Goodsitems6
            valu_goodi_6.Value = Reader.ReadByte
            Reader.Position = Goodsitems7
            valu_goodi_7.Value = Reader.ReadByte
            Reader.Position = Goodsitems8
            valu_goodi_8.Value = Reader.ReadByte
            Reader.Position = Goodsitems9
            valu_goodi_9.Value = Reader.ReadByte
            Reader.Position = Goodsitems10
            valu_goodi_10.Value = Reader.ReadByte
            Reader.Position = Goodsitems11
            valu_goodi_11.Value = Reader.ReadByte
            Reader.Position = Goodsitems12
            valu_goodi_12.Value = Reader.ReadByte
            Reader.Position = Goodsitems13
            valu_goodi_13.Value = Reader.ReadByte
            Reader.Position = Goodsitems14
            valu_goodi_14.Value = Reader.ReadByte
            Reader.Position = Goodsitems15
            valu_goodi_15.Value = Reader.ReadByte
            Reader.Position = Goodsitems16
            valu_goodi_16.Value = Reader.ReadByte
            Reader.Position = Goodsitems17
            valu_goodi_17.Value = Reader.ReadByte
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                Reader.Position = Goodsitems18
                valu_goodi_18.Value = Reader.ReadByte
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Advanceitemsedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedataArc = TL_SaveEditor.TextBox_fpath.Text
        Filever_text.Text = TL_SaveEditor.Filever_text.Text
        savefileregion()
    End Sub

    Private Sub Advanceitemsedit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Readgoodsitems()
    End Sub

    Private Sub Icon_closeadvitemsedit_Click(sender As Object, e As EventArgs) Handles Icon_closeadvitemsedit.Click
        Me.Close()
    End Sub

    Private Sub Icon_saveadvitemsedit_Click(sender As Object, e As EventArgs) Handles Icon_saveadvitemsedit.Click
        Savegoodsitems()
        Savegoodsitems()
        If TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(0) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "Items changes has been saved"
        ElseIf TL_SaveEditor.Select_language.SelectedItem = TL_SaveEditor.Select_language.Items.Item(1) Then
            TLSE_dialog.Text_TLSE_dialog.Text = "L'édition des objets a été sauvegardé"
        End If
        TLSE_dialog.ShowDialog()
    End Sub

    Public Sub Savegoodsitems()
        Try
            Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            fs.Position = Goodsitems1
            fs.WriteByte(valu_goodi_1.Value)
            fs.Position = Goodsitems2
            fs.WriteByte(valu_goodi_2.Value)
            fs.Position = Goodsitems3
            fs.WriteByte(valu_goodi_3.Value)
            fs.Position = Goodsitems4
            fs.WriteByte(valu_goodi_4.Value)
            fs.Position = Goodsitems5
            fs.WriteByte(valu_goodi_5.Value)
            fs.Position = Goodsitems6
            fs.WriteByte(valu_goodi_6.Value)
            fs.Position = Goodsitems7
            fs.WriteByte(valu_goodi_7.Value)
            fs.Position = Goodsitems8
            fs.WriteByte(valu_goodi_8.Value)
            fs.Position = Goodsitems9
            fs.WriteByte(valu_goodi_9.Value)
            fs.Position = Goodsitems10
            fs.WriteByte(valu_goodi_10.Value)
            fs.Position = Goodsitems11
            fs.WriteByte(valu_goodi_11.Value)
            fs.Position = Goodsitems12
            fs.WriteByte(valu_goodi_12.Value)
            fs.Position = Goodsitems13
            fs.WriteByte(valu_goodi_13.Value)
            fs.Position = Goodsitems14
            fs.WriteByte(valu_goodi_14.Value)
            fs.Position = Goodsitems15
            fs.WriteByte(valu_goodi_15.Value)
            fs.Position = Goodsitems16
            fs.WriteByte(valu_goodi_16.Value)
            fs.Position = Goodsitems17
            fs.WriteByte(valu_goodi_17.Value)
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                fs.Position = Goodsitems18
                fs.WriteByte(valu_goodi_18.Value)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class