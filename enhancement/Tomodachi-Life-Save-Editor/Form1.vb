Imports System.Net
Public Class TL_SaveEditor
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim fdialog As New Form2
    Dim applicationpath = Application.StartupPath
    Dim savedataArc As String
    Dim money As String
    Dim IslN As String
    Dim Islp As String
    Dim Mii1L As String
    Dim Mii1P As String
    Dim Mii1N As String
    Dim Mii1S As String
    Dim Mii1C As String
    Dim Mii1PP As String
    Dim Mii1NP As String
    Dim Mii1SP As String
    Dim Mii1R As String
    Dim soucis As String
    Dim vrecu As String
    Dim weddi As String
    Dim born As String
    Dim vsent As String
    Dim stpass As String
    Dim bull1 As String
    Dim bull2 As String
    Dim bull3 As String
    Dim bull4 As String
    Dim bull5 As String
    Dim antiTT As String
    Dim objet1 As String
    Dim objet2 As String
    Dim objet3 As String
    Dim objet4 As String
    Dim objet5 As String
    Dim objet6 As String
    Dim objet7 As String
    Dim objet8 As String
    Dim exp As String
    Dim econom As String
    Dim fullness As String
    Dim eat As String
    Dim interieur As String
    Dim interieur1 As String
    Dim Sfoods As String
    Dim objdiv As String
    Dim appart As String
    Dim mair As String
    Dim info As String
    Dim classem As String
    Dim vetem As String
    Dim chap As String
    Dim epicer As String
    Dim deco As String
    Dim broc As String
    Dim magimport As String
    Dim fontai As String
    Dim mais As String
    Dim port As String
    Dim tervague As String
    Dim conc As String
    Dim test As String
    Dim stud As String
    Dim plage As String
    Dim parc1 As String
    Dim cafe As String
    Dim parc As String
    Dim tour As String
    Dim part As String
    Dim frie1 As String
    Dim frie2 As String
    Dim alltime As String
    Dim alltime2 As String
    Dim fav As String
    Dim fav2 As String
    Dim fav3 As String
    Dim worst As String
    Dim worst2 As String
    Dim copy As String
    Dim sharing As String
    Dim couleur As String
    Dim grow As String
    Dim appartement As String
    Dim BSTF As String
    Dim sweetheart As String
    Dim eventfountain As String
    Dim appartrenov As String

    Private Sub hidepanels()
        Panel_islandedit.Visible = False
        Panel_extras.Visible = False
        Panel_settings.Visible = False
        Panel_miiedit.Visible = False
    End Sub

    Private Sub unselectcolor()
        color_1.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_2.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_3.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_4.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_5.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_6.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_7.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_8.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_9.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_10.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_11.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_12.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_13.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_14.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_15.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_16.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_17.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_18.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_19.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_20.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_21.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_22.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_23.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_24.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_25.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_26.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_27.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_28.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_29.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_30.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_31.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_32.BorderStyle = BorderStyle.None
        color_empty.BorderStyle = BorderStyle.None
    End Sub

    Public Sub makebak()
        Try
            If Filever_text.Text = "US" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\USA\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "EU" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\EUR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "JP" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\JPN\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
            If Filever_text.Text = "KR" Then
                My.Computer.FileSystem.CopyFile(
                          savedataArc,
                        applicationpath & "\bak\KOR\" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute & "\savedataArc.txt")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Checkupdates()
        If Setting_ckupdate.Checked = False Then
            Try
                Dim MAJ As New WebClient
                Dim lastupdate As String = MAJ.DownloadString("https://raw.githubusercontent.com/Brionjv/Tomodachi-Life-Save-Editor/master/Version.txt")
                If Text_TLSE_version.Text = lastupdate Then
                    TLSE_logo.Visible = True
                    TLSE_logo_update.Visible = False
                Else
                    TLSE_logo.Visible = False
                    TLSE_logo_update.Visible = True
                    If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                        fdialog.Text_fdialog.Text = "An update is avalible, click on Tomodachi Life Save Editor icon to download new version"
                        fdialog.ShowDialog()
                    End If
                    If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                        fdialog.Text_fdialog.Text = "Une mise à jour est disponible, cliquez sur l'îcone de Tomodachi Life Save Editor pour télécharger la nouvelle version"
                        fdialog.ShowDialog()
                    End If
                End If
            Catch ex As Exception
                If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                    fdialog.Text_fdialog.Text = "An error has occured when checking updates"
                    fdialog.ShowDialog()
                End If
                If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                    fdialog.Text_fdialog.Text = "Une erreur est survenue lors de la vérification des mises à jour"
                    fdialog.ShowDialog()
                End If
            End Try
        End If
    End Sub

    Public Sub readsavedataArc()
        Try
            If Filever_text.Text = "EU" Or Filever_text.Text = "US" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H1E4BB8
                money = Reader.Position
                value_money.Value = Reader.ReadUInt32
                Reader.Position = &H1E4BCC
                IslN = Reader.Position
                Text_islandname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1E4BF6
                Islp = Reader.Position
                Text_pronun_islandname.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1E4BC6
                soucis = Reader.Position
                value_problemsolved.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BBE
                vrecu = Reader.Position
                value_travelersreceived.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BC0
                weddi = Reader.Position
                value_weddings.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BC2
                born = Reader.Position
                value_childrenborn.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BC4
                vsent = Reader.Position
                value_travelerssent.Value = Reader.ReadUInt16
                Reader.Position = &H1E4BBC
                stpass = Reader.Position
                value_streetpassencounters.Value = Reader.ReadUInt16
                Reader.Position = &H1E4C20
                appart = Reader.Position
                value_appart.Value = Reader.ReadInt8
                Reader.Position = &H1E4C21
                mair = Reader.Position
                value_mair.Value = Reader.ReadInt8
                Reader.Position = &H1E4C22
                info = Reader.Position
                value_info.Value = Reader.ReadInt8
                Reader.Position = &H1E4C23
                classem = Reader.Position
                value_classem.Value = Reader.ReadInt8
                Reader.Position = &H1E4C24
                vetem = Reader.Position
                value_vetem.Value = Reader.ReadInt8
                Reader.Position = &H1E4C25
                chap = Reader.Position
                value_chap.Value = Reader.ReadInt8
                Reader.Position = &H1E4C26
                epicer = Reader.Position
                value_epicer.Value = Reader.ReadInt8
                Reader.Position = &H1E4C27
                deco = Reader.Position
                value_deco.Value = Reader.ReadInt8
                Reader.Position = &H1E4C28
                broc = Reader.Position
                value_broc.Value = Reader.ReadInt8
                Reader.Position = &H1E4C29
                magimport = Reader.Position
                value_magimport.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2A
                Fontai = Reader.Position
                value_font.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2B
                mais = Reader.Position
                value_mais.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2C
                port = Reader.Position
                value_port.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2D
                tervague = Reader.Position
                value_tervague.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2E
                conc = Reader.Position
                value_conc.Value = Reader.ReadInt8
                Reader.Position = &H1E4C2F
                test = Reader.Position
                value_test.Value = Reader.ReadInt8
                Reader.Position = &H1E4C30
                stud = Reader.Position
                value_stud.Value = Reader.ReadInt8
                Reader.Position = &H1E4C31
                plage = Reader.Position
                value_plage.Value = Reader.ReadInt8
                Reader.Position = &H1E4C32
                parc1 = Reader.Position
                value_parc1.Value = Reader.ReadInt8
                Reader.Position = &H1E4C33
                cafe = Reader.Position
                value_cafe.Value = Reader.ReadInt8
                Reader.Position = &H1E4C34
                parc = Reader.Position
                value_parc.Value = Reader.ReadInt8
                Reader.Position = &H1E4C35
                tour = Reader.Position
                value_tour.Value = Reader.ReadInt8
                Reader.Position = &H1E4C36
                part = Reader.Position
                value_part.Value = Reader.ReadInt8
                Reader.Position = &H1E4AF8
                eventfountain = Reader.Position
                value_eventfountain.Value = Reader.ReadUInt32
                Reader.Position = &H1E4C79
                appartrenov = Reader.Position
                value_appartrenov.Value = Reader.ReadInt8
            End If
            If Filever_text.Text = "JP" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H14BCA8
                money = Reader.Position
                value_money.Value = Reader.ReadUInt32
                Reader.Position = &H14BCBC
                IslN = Reader.Position
                Text_islandname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H14BCB6
                soucis = Reader.Position
                value_problemsolved.Value = Reader.ReadUInt16
                Reader.Position = &H14BCAE
                vrecu = Reader.Position
                value_travelersreceived.Value = Reader.ReadUInt16
                Reader.Position = &H14BCB0
                weddi = Reader.Position
                value_weddings.Value = Reader.ReadUInt16
                Reader.Position = &H14BCB2
                born = Reader.Position
                value_childrenborn.Value = Reader.ReadUInt16
                Reader.Position = &H14BCB4
                vsent = Reader.Position
                value_travelerssent.Value = Reader.ReadUInt16
                Reader.Position = &H14BCAC
                stpass = Reader.Position
                value_streetpassencounters.Value = Reader.ReadUInt16
                Reader.Position = &H14BCF0
                appart = Reader.Position
                value_appart.Value = Reader.ReadInt8
                Reader.Position = &H14BCF1
                mair = Reader.Position
                value_mair.Value = Reader.ReadInt8
                Reader.Position = &H14BCF2
                info = Reader.Position
                value_info.Value = Reader.ReadInt8
                Reader.Position = &H14BCF3
                classem = Reader.Position
                value_classem.Value = Reader.ReadInt8
                Reader.Position = &H14BCF4
                vetem = Reader.Position
                value_vetem.Value = Reader.ReadInt8
                Reader.Position = &H14BCF5
                chap = Reader.Position
                value_chap.Value = Reader.ReadInt8
                Reader.Position = &H14BCF6
                epicer = Reader.Position
                value_epicer.Value = Reader.ReadInt8
                Reader.Position = &H14BCF7
                deco = Reader.Position
                value_deco.Value = Reader.ReadInt8
                Reader.Position = &H14BCF8
                broc = Reader.Position
                value_broc.Value = Reader.ReadInt8
                Reader.Position = &H14BCF9
                magimport = Reader.Position
                value_magimport.Value = Reader.ReadInt8
                Reader.Position = &H14BCFA
                fontai = Reader.Position
                value_font.Value = Reader.ReadInt8
                Reader.Position = &H14BCFB
                mais = Reader.Position
                value_mais.Value = Reader.ReadInt8
                Reader.Position = &H14BCFC
                port = Reader.Position
                value_port.Value = Reader.ReadInt8
                Reader.Position = &H14BCFD
                tervague = Reader.Position
                value_tervague.Value = Reader.ReadInt8
                Reader.Position = &H14BCFE
                conc = Reader.Position
                value_conc.Value = Reader.ReadInt8
                Reader.Position = &H14BCFF
                test = Reader.Position
                value_test.Value = Reader.ReadInt8
                Reader.Position = &H14BD00
                stud = Reader.Position
                value_stud.Value = Reader.ReadInt8
                Reader.Position = &H14BD01
                plage = Reader.Position
                value_plage.Value = Reader.ReadInt8
                Reader.Position = &H14BD02
                parc1 = Reader.Position
                value_parc1.Value = Reader.ReadInt8
                Reader.Position = &H14BD03
                cafe = Reader.Position
                value_cafe.Value = Reader.ReadInt8
                Reader.Position = &H14BD04
                parc = Reader.Position
                value_parc.Value = Reader.ReadInt8
                Reader.Position = &H14BBE8
                eventfountain = Reader.Position
                value_eventfountain.Value = Reader.ReadUInt32
                Reader.Position = &H14BD49
                appartrenov = Reader.Position
                value_appartrenov.Value = Reader.ReadInt8
            End If
            If Filever_text.Text = "KR" Then
                Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
                Reader.Position = &H1EFF68
                money = Reader.Position
                value_money.Value = Reader.ReadUInt32
                Reader.Position = &H1EFF7C
                IslN = Reader.Position
                Text_islandname.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H1EFFA6
                Islp = Reader.Position
                Text_pronun_islandname.Text = Reader.ReadUnicodeString(20)
                Reader.Position = &H1EFF76
                soucis = Reader.Position
                value_problemsolved.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF6E
                vrecu = Reader.Position
                value_travelersreceived.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF70
                weddi = Reader.Position
                value_weddings.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF72
                born = Reader.Position
                value_childrenborn.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF74
                vsent = Reader.Position
                value_travelerssent.Value = Reader.ReadUInt16
                Reader.Position = &H1EFF6C
                stpass = Reader.Position
                value_streetpassencounters.Value = Reader.ReadUInt16
                Reader.Position = &H1EFFD0
                appart = Reader.Position
                value_appart.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD1
                mair = Reader.Position
                value_mair.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD2
                info = Reader.Position
                value_info.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD3
                classem = Reader.Position
                value_classem.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD4
                vetem = Reader.Position
                value_vetem.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD5
                chap = Reader.Position
                value_chap.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD6
                epicer = Reader.Position
                value_epicer.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD7
                deco = Reader.Position
                value_deco.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD8
                broc = Reader.Position
                value_broc.Value = Reader.ReadInt8
                Reader.Position = &H1EFFD9
                magimport = Reader.Position
                value_magimport.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDA
                fontai = Reader.Position
                value_font.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDB
                mais = Reader.Position
                value_mais.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDC
                port = Reader.Position
                value_port.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDD
                tervague = Reader.Position
                value_tervague.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDE
                conc = Reader.Position
                value_conc.Value = Reader.ReadInt8
                Reader.Position = &H1EFFDF
                test = Reader.Position
                value_test.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE0
                stud = Reader.Position
                value_stud.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE1
                plage = Reader.Position
                value_plage.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE2
                parc1 = Reader.Position
                value_parc1.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE3
                cafe = Reader.Position
                value_cafe.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE4
                parc = Reader.Position
                value_parc.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE5
                tour = Reader.Position
                value_tour.Value = Reader.ReadInt8
                Reader.Position = &H1EFFE6
                part = Reader.Position
                value_part.Value = Reader.ReadInt8
                Reader.Position = &H1EFEA8
                eventfountain = Reader.Position
                value_eventfountain.Value = Reader.ReadUInt32
                Reader.Position = &H1F0029
                appartrenov = Reader.Position
                value_appartrenov.Value = Reader.ReadInt8
            End If
            Text_menu_open.Visible = False
            Text_menu_save.Visible = True
            Filever_text.Enabled = False
            Select_language.Enabled = False
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read savedataArc.txt, make sure you choose right save file version and to have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'ouverture de savedataArc.txt a échoué, soyez sûr d'avoir choisi la bonne version de sauvegarde et d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
            Text_menu_open.Visible = True
            Text_menu_save.Visible = False
            Filever_text.Enabled = True
            Select_language.Enabled = True
        End Try
    End Sub

    Public Sub writesavedataArc()
        Try
            Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
            Writer.Position = money
            Writer.WriteUInt32(value_money.Value)
            For i As Integer = 0 To 19
                Writer.Position = IslN + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = IslN
            Writer.WriteUnicodeString(Text_islandname.Text)
            Writer.Position = soucis
            Writer.WriteUInt16(value_problemsolved.Value)
            Writer.Position = vrecu
            Writer.WriteUInt16(value_travelersreceived.Value)
            Writer.Position = weddi
            Writer.WriteUInt16(value_weddings.Value)
            Writer.Position = born
            Writer.WriteUInt16(value_childrenborn.Value)
            Writer.Position = vsent
            Writer.WriteUInt16(value_travelerssent.Value)
            Writer.Position = stpass
            Writer.WriteUInt16(value_streetpassencounters.Value)
            Writer.Position = appart
            Writer.WriteInt8(value_appart.Value)
            Writer.Position = mair
            Writer.WriteInt8(value_mair.Value)
            Writer.Position = info
            Writer.WriteInt8(value_info.Value)
            Writer.Position = classem
            Writer.WriteInt8(value_classem.Value)
            Writer.Position = vetem
            Writer.WriteInt8(value_vetem.Value)
            Writer.Position = chap
            Writer.WriteInt8(value_chap.Value)
            Writer.Position = epicer
            Writer.WriteInt8(value_epicer.Value)
            Writer.Position = deco
            Writer.WriteInt8(value_deco.Value)
            Writer.Position = broc
            Writer.WriteInt8(value_broc.Value)
            Writer.Position = magimport
            Writer.WriteInt8(value_magimport.Value)
            Writer.Position = fontai
            Writer.WriteInt8(value_font.Value)
            Writer.Position = mais
            Writer.WriteInt8(value_mais.Value)
            Writer.Position = port
            Writer.WriteInt8(value_port.Value)
            Writer.Position = tervague
            Writer.WriteInt8(value_tervague.Value)
            Writer.Position = conc
            Writer.WriteInt8(value_conc.Value)
            Writer.Position = test
            Writer.WriteInt8(value_test.Value)
            Writer.Position = stud
            Writer.WriteInt8(value_stud.Value)
            Writer.Position = plage
            Writer.WriteInt8(value_plage.Value)
            Writer.Position = parc1
            Writer.WriteInt8(value_parc1.Value)
            Writer.Position = cafe
            Writer.WriteInt8(value_cafe.Value)
            Writer.Position = parc
            Writer.WriteInt8(value_parc.Value)
            Writer.Position = eventfountain
            Writer.WriteUInt32(value_eventfountain.Value)
            Writer.Position = appartrenov
            Writer.WriteInt8(value_appartrenov.Value)
            If Filever_text.Text = "EU" Then
                For i As Integer = 0 To 19
                    Writer.Position = Islp + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Islp
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
                Writer.Position = tour
                Writer.WriteInt8(value_tour.Value)
                Writer.Position = part
                Writer.WriteInt8(value_part.Value)
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H1E4C70
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H1E4C71
                    Writer.WriteInt8(0)
                End If
            End If
            If Filever_text.Text = "US" Then
                For i As Integer = 0 To 19
                    Writer.Position = Islp + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Islp
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
                Writer.Position = tour
                Writer.WriteInt8(value_tour.Value)
                Writer.Position = part
                Writer.WriteInt8(value_part.Value)
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H1E4C70
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H1E4C71
                    Writer.WriteInt8(0)
                End If
            End If
            If Filever_text.Text = "JP" Then
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H14BD40
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H14BD41
                    Writer.WriteInt8(0)
                End If
            End If
            If Filever_text.Text = "KR" Then
                For i As Integer = 0 To 19
                    Writer.Position = Islp + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Islp
                Writer.WriteUnicodeString(Text_pronun_islandname.Text)
                Writer.Position = tour
                Writer.WriteInt8(value_tour.Value)
                Writer.Position = part
                Writer.WriteInt8(value_part.Value)
                If Check_timetravel.Checked = True Then
                    Writer.Position = &H1F0020
                    Writer.WriteInt8(0)
                End If
                If Check_resetstpspp.Checked = True Then
                    Writer.Position = &H1F0021
                    Writer.WriteInt8(0)
                End If
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to write savedataArc.txt, make sure you choose right save file version and to have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'écriture de savedataArc.txt a échoué, soyez sûr d'avoir choisi la bonne version de sauvegarde et d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Public Sub readMii()
        Try

        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to read informations of this Mii, make sure you have opened a file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "La lecture des informations de ce Mii a échoué, soyez sûr d'avoir ouvert un fichier, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
            Select_mii.SelectedItem = Nothing
        End Try
    End Sub

    Public Sub writeMii()
        Try

        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                fdialog.Text_fdialog.Text = "Failed to save changes on this Mii, make sure you have opened a save file, or report this issue"
                fdialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                fdialog.Text_fdialog.Text = "L'enregistrement des changements sur ce Mii a échoué, soyez sûr d'avoir ouvert un fichier de sauvegarde, ou signalez cet erreur"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseDown, TLSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub TLSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseUp, TLSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TLSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TLSE_header.MouseMove, TLSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Filever_text_Click(sender As Object, e As EventArgs) Handles Filever_text.Click
        If Filever_text.Text = "US" Then
            Filever_text.Text = "EU"
            TLSE_logo.Image = My.Resources.logo_EU
            TLSE_logo_update.Image = My.Resources.logo_EU_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
        ElseIf Filever_text.Text = "EU" Then
            Filever_text.Text = "JP"
            TLSE_logo.Image = My.Resources.logo_JP
            TLSE_logo_update.Image = My.Resources.logo_JP_update
            Icon_pronun_islandname.Visible = False
            Icon_tour.Image = My.Resources.touri
            Icon_part.Image = My.Resources.parti
            Icon_tour.Enabled = False
            Icon_part.Enabled = False
            Icon_pronun_firstname.Visible = False
            Icon_pronun_lastname.Visible = False
            Icon_pronun_nickname.Visible = False
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 0
        ElseIf Filever_text.Text = "JP" Then
            Filever_text.Text = "KR"
            TLSE_logo.Image = My.Resources.logo_KR
            TLSE_logo_update.Image = My.Resources.logo_KR_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
        ElseIf Filever_text.Text = "KR" Then
            Filever_text.Text = "US"
            TLSE_logo.Image = My.Resources.logo_US
            TLSE_logo_update.Image = My.Resources.logo_US_update
            Icon_pronun_islandname.Visible = True
            Icon_tour.Image = Nothing
            Icon_part.Image = Nothing
            Icon_tour.Enabled = True
            Icon_part.Enabled = True
            Icon_pronun_firstname.Visible = True
            Icon_pronun_lastname.Visible = True
            Icon_pronun_nickname.Visible = True
            Text_islandname.MaxLength = 10
            Text_pronun_island.MaxLength = 20
        End If
        Icon_changelog.Image = TLSE_logo.Image
    End Sub

    Private Sub Info_islandbuild_MouseMove(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseMove
        Icon_info_building.Visible = True
    End Sub

    Private Sub Info_islandbuild_MouseLeave(sender As Object, e As EventArgs) Handles Info_islandbuild.MouseLeave
        Icon_info_building.Visible = False
    End Sub

    Private Sub Icon_pronun_islandname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseMove
        Text_pronun_islandname.Visible = True
    End Sub

    Private Sub Icon_pronun_islandname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.MouseLeave
        Text_pronun_islandname.Visible = False
    End Sub

    Private Sub Icon_islandn_pronun_val_Click(sender As Object, e As EventArgs) Handles Icon_islandn_pronun_val.Click
        Panel_edit_pronun_island.Visible = False
        Text_pronun_islandname.Text = Text_pronun_island.Text
    End Sub

    Private Sub Icon_pronun_islandname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_islandname.Click
        Panel_edit_pronun_island.Visible = True
        Text_pronun_island.Text = Text_pronun_islandname.Text
    End Sub

    Private Sub Icon_appartrenov_Click(sender As Object, e As EventArgs) Handles Icon_appartrenov.Click
        value_appartrenov.Value = (value_appartrenov.Value + 1)
    End Sub

    Private Sub valu__appartrenov_ValueChanged(sender As Object, e As EventArgs) Handles value_appartrenov.ValueChanged
        If value_appartrenov.Value > 3 Then
            value_appartrenov.Value = 0
        End If
        If value_appartrenov.Value = 0 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_00
        ElseIf value_appartrenov.Value = 1 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_01
        ElseIf value_appartrenov.Value = 2 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_02
        ElseIf value_appartrenov.Value = 3 Then
            Icon_appartrenov.Image = My.Resources.icon_appart_03
        End If
    End Sub

    Private Sub Icon_eventfountain_Click(sender As Object, e As EventArgs) Handles Icon_eventfountain.Click
        value_eventfountain.Value = 0
    End Sub

    Private Sub Text_menu_button_Click(sender As Object, e As EventArgs) Handles Text_menu_button.Click
        If Menu_panel.Visible = False Then
            Menu_panel.Visible = True
        ElseIf Menu_panel.Visible = True Then
            Menu_panel.Visible = False
        End If
    End Sub

    Private Sub Menu_islandedit_Click(sender As Object, e As EventArgs) Handles Menu_islandedit.Click, Menu_text_islandedit.Click
        hidepanels()
        Panel_islandedit.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_islandedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseMove, Menu_text_islandedit.MouseMove
        Menu_islandedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_islandedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_islandedit.MouseLeave, Menu_text_islandedit.MouseLeave
        Menu_islandedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_extras_Click(sender As Object, e As EventArgs) Handles Menu_extras.Click, Menu_text_extras.Click
        hidepanels()
        Panel_extras.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_extras_MouseMove(sender As Object, e As EventArgs) Handles Menu_extras.MouseMove, Menu_text_extras.MouseMove
        Menu_extras.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_extras_MouseLeave(sender As Object, e As EventArgs) Handles Menu_extras.MouseLeave, Menu_text_extras.MouseLeave
        Menu_extras.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TL_SaveEditor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Checkupdates()
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Private Sub Menu_settings_Click(sender As Object, e As EventArgs) Handles Menu_settings.Click, Menu_text_settings.Click
        hidepanels()
        Panel_settings.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_settings_MouseMove(sender As Object, e As EventArgs) Handles Menu_settings.MouseMove, Menu_text_settings.MouseMove
        Menu_settings.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_settings_MouseLeave(sender As Object, e As EventArgs) Handles Menu_settings.MouseLeave, Menu_text_settings.MouseLeave
        Menu_settings.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_itemsedit_Click(sender As Object, e As EventArgs) Handles Menu_itemsedit.Click, Menu_text_itemsedit.Click
        Menu_panel.Visible = False
        Me.Hide()
        'mettre un ecran de chargement (trop de ressources vont être utilisés)
        Items_edit.ShowDialog()
    End Sub

    Private Sub Menu_itemsedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseMove, Menu_text_itemsedit.MouseMove
        Menu_itemsedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_itemsedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_itemsedit.MouseLeave, Menu_text_itemsedit.MouseLeave
        Menu_itemsedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Menu_miiedit_Click(sender As Object, e As EventArgs) Handles Menu_miiedit.Click, Menu_text_miiedit.Click
        hidepanels()
        Panel_miiedit.Visible = True
        Menu_panel.Visible = False
    End Sub

    Private Sub Menu_miiedit_MouseMove(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseMove, Menu_text_miiedit.MouseMove
        Menu_miiedit.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Menu_miiedit_MouseLeave(sender As Object, e As EventArgs) Handles Menu_miiedit.MouseLeave, Menu_text_miiedit.MouseLeave
        Menu_miiedit.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Select_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_language.SelectedIndexChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_menu_button.Text = "Menu"
            Text_menu_open.Text = "Open"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Island edit"
            Menu_text_miiedit.Text = "Mii edit"
            Menu_text_repair.Text = "Repair save file"
            Menu_text_settings.Text = "Settings"
            Menu_text_itemsedit.Text = "Items edit"
            Title_appartrenov.Text = "Apartments renovation"
            Title_childrenborn.Text = "Children born"
            Title_eventfountain.Text = "Event fountain"
            Title_islandname.Text = "Island's name"
            Title_problemsolved.Text = "Problems solved"
            Title_streetpassencounters.Text = "Streetpass encounters"
            Title_travelersreceived.Text = "Travelers received"
            Title_travelerssent.Text = "Travelers sent"
            Title_weddings.Text = "Weddings"
            Check_resetstpspp.Text = "Reset Tomodachi Life Streetpass / Spotpass"
            Check_timetravel.Text = "Remove time travel penality"
            Setting_music.Text = "Active background music"
            Setting_hidden.Text = "Show hidden things"
            Setting_filepath.Text = "Show file path"
            Setting_ckupdate.Text = "Unactive check update"
            Text_language.Text = "Language"
            Tab_mii_edit.Text = "Edit"
            Tab_mii_status.Text = "Status"
            Tab_mii_friendlist.Text = "Friendlist"
            Tab_mii_extras.Text = "Extras"
            Title_sharing.Text = "Sharing"
            Title_copying.Text = "Copying"
            Title_firstname.Text = "First Name"
            Title_lastname.Text = "Last Name"
            Title_nickname.Text = "Nickname"
            Title_favcolor.Text = "Favorite Color"
            Title_relationyou.Text = "Relation to real You"
            Title_growkid.Text = "Grown-up / Kid"
            Title_haircolor.Text = "Hair Color"
            Title_creator.Text = "Creator"
            Text_save_mii.Text = "Save changes"
            Select_unlock_gooditems.Items.Item(0) = "Do nothing"
            Select_unlock_gooditems.Items.Item(1) = "Unlock all"
            Select_unlock_gooditems.Items.Item(2) = "Delete all"
            Select_unlock_interiors.Items.Item(0) = "Do nothing"
            Select_unlock_interiors.Items.Item(1) = "Unlock all"
            Select_unlock_interiors.Items.Item(2) = "Delete all"
            Select_unlock_specialfoods.Items.Item(0) = "Do nothing"
            Select_unlock_specialfoods.Items.Item(1) = "Unlock all"
            Select_unlock_specialfoods.Items.Item(2) = "Delete all"
            color_empty.Text = "normal"
            Button_close_hcoloredit.Text = "OK"
            Text_unlock_music.Text = "Unlock all"
            Text_edit_metal.Text = "Metal"
            Text_edit_pop.Text = "Pop"
            Text_edit_rockroll.Text = "Rock' n' Roll"
            Text_edit_rap.Text = "Rap"
            Text_edit_ballad.Text = "Ballad"
            Text_edit_opera.Text = "Opera"
            Text_edit_techno.Text = "Techno"
            Text_edit_musical.Text = "Musical"
            Text_level.Text = "Lv."
            Title_foods_allfav.Text = "Super All-Time Fav / All-Time Fav"
            Title_foods_favorite.Text = "Favorite Foods"
            Title_foods_worst.Text = "Worst / Worst Ever"
            Text_fullness.Text = "Fullness"
            Check_fullness.Text = "He didn't eat"
            Title_interactionpattern.Text = "Interaction pattern"
            Title_target1.Text = "Target 1"
            Title_target2.Text = "Target 2"
            Title_emotions.Text = "Emotions"
            Select_growkid.Items.Item(0) = "Grown-up"
            Select_growkid.Items.Item(1) = "Grown-up (1)"
            Select_growkid.Items.Item(2) = "Kid"
            Select_relationyou.Items.Item(0) = "Child"
            Select_relationyou.Items.Item(1) = "Not Related"
            Select_relationyou.Items.Item(2) = "Other Relative"
            Select_relationyou.Items.Item(3) = "Parent"
            Select_relationyou.Items.Item(4) = "Self"
            Select_relationyou.Items.Item(5) = "Sibling"
            Select_relationyou.Items.Item(6) = "Spouse"
            Select_interaction.Items.Item(0) = "Nothing"
            Select_interaction.Items.Item(1) = "I'm hungry"
            Select_interaction.Items.Item(2) = "I'm hungry(1)"
            Select_interaction.Items.Item(3) = "I'm hungry(2)"
            Select_interaction.Items.Item(4) = "In love with"
            Select_interaction.Items.Item(5) = "angry at"
            Select_interaction.Items.Item(6) = "angry at(1)"
            Select_interaction.Items.Item(7) = "In love with (undecided)"
            Select_interaction.Items.Item(8) = "Dream"
            Select_interaction.Items.Item(9) = "I need new clothes"
            Select_interaction.Items.Item(10) = "I need new clothes (something classy)"
            Select_interaction.Items.Item(11) = "I need new clothes (to do sports)"
            Select_interaction.Items.Item(12) = "Can I tell you about my [love stories? / my wife?]"
            Select_interaction.Items.Item(13) = "Sad : love rejected"
            Select_interaction.Items.Item(14) = "Want to get married"
            Select_emotions.Items.Item(0) = "Normal"
            Select_emotions.Items.Item(1) = "Happy"
            Select_emotions.Items.Item(2) = "Angry"
            Select_emotions.Items.Item(3) = "Sad"
            Select_emotions.Items.Item(4) = "In love"
            Button_setallfriends.Text = "Set all to"
            Select_allfriends.Items.Item(0) = "Mii 1 to 30"
            Select_allfriends.Items.Item(1) = "Mii 31 to 60"
            Select_allfriends.Items.Item(2) = "Mii 61 to 90"
            Select_allfriends.Items.Item(3) = "Mii 91 to 100"
            Title_ranking_pampered.Text = "Pampered ranking"
            Title_ranking_splurge.Text = "Splurge ranking"
            Select_friend_rela_1.Items.Item(0) = "Unknow"
            Select_friend_rela_1.Items.Item(1) = "Friend"
            Select_friend_rela_1.Items.Item(2) = "Lover"
            Select_friend_rela_1.Items.Item(3) = "Ex"
            Select_friend_rela_1.Items.Item(4) = "Spouse"
            Select_friend_rela_1.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_1.Items.Item(6) = "Parent"
            Select_friend_rela_1.Items.Item(7) = "Sibling"
            Select_friend_rela_1.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_1.Items.Item(9) = "Best friend"
            Select_friend_rela_2.Items.Item(0) = "Unknow"
            Select_friend_rela_2.Items.Item(1) = "Friend"
            Select_friend_rela_2.Items.Item(2) = "Lover"
            Select_friend_rela_2.Items.Item(3) = "Ex"
            Select_friend_rela_2.Items.Item(4) = "Spouse"
            Select_friend_rela_2.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_2.Items.Item(6) = "Parent"
            Select_friend_rela_2.Items.Item(7) = "Sibling"
            Select_friend_rela_2.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_2.Items.Item(9) = "Best friend"
            Select_friend_rela_3.Items.Item(0) = "Unknow"
            Select_friend_rela_3.Items.Item(1) = "Friend"
            Select_friend_rela_3.Items.Item(2) = "Lover"
            Select_friend_rela_3.Items.Item(3) = "Ex"
            Select_friend_rela_3.Items.Item(4) = "Spouse"
            Select_friend_rela_3.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_3.Items.Item(6) = "Parent"
            Select_friend_rela_3.Items.Item(7) = "Sibling"
            Select_friend_rela_3.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_3.Items.Item(9) = "Best friend"
            Select_friend_rela_4.Items.Item(0) = "Unknow"
            Select_friend_rela_4.Items.Item(1) = "Friend"
            Select_friend_rela_4.Items.Item(2) = "Lover"
            Select_friend_rela_4.Items.Item(3) = "Ex"
            Select_friend_rela_4.Items.Item(4) = "Spouse"
            Select_friend_rela_4.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_4.Items.Item(6) = "Parent"
            Select_friend_rela_4.Items.Item(7) = "Sibling"
            Select_friend_rela_4.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_4.Items.Item(9) = "Best friend"
            Select_friend_rela_5.Items.Item(0) = "Unknow"
            Select_friend_rela_5.Items.Item(1) = "Friend"
            Select_friend_rela_5.Items.Item(2) = "Lover"
            Select_friend_rela_5.Items.Item(3) = "Ex"
            Select_friend_rela_5.Items.Item(4) = "Spouse"
            Select_friend_rela_5.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_5.Items.Item(6) = "Parent"
            Select_friend_rela_5.Items.Item(7) = "Sibling"
            Select_friend_rela_5.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_5.Items.Item(9) = "Best friend"
            Select_friend_rela_6.Items.Item(0) = "Unknow"
            Select_friend_rela_6.Items.Item(1) = "Friend"
            Select_friend_rela_6.Items.Item(2) = "Lover"
            Select_friend_rela_6.Items.Item(3) = "Ex"
            Select_friend_rela_6.Items.Item(4) = "Spouse"
            Select_friend_rela_6.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_6.Items.Item(6) = "Parent"
            Select_friend_rela_6.Items.Item(7) = "Sibling"
            Select_friend_rela_6.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_6.Items.Item(9) = "Best friend"
            Select_friend_rela_7.Items.Item(0) = "Unknow"
            Select_friend_rela_7.Items.Item(1) = "Friend"
            Select_friend_rela_7.Items.Item(2) = "Lover"
            Select_friend_rela_7.Items.Item(3) = "Ex"
            Select_friend_rela_7.Items.Item(4) = "Spouse"
            Select_friend_rela_7.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_7.Items.Item(6) = "Parent"
            Select_friend_rela_7.Items.Item(7) = "Sibling"
            Select_friend_rela_7.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_7.Items.Item(9) = "Best friend"
            Select_friend_rela_8.Items.Item(0) = "Unknow"
            Select_friend_rela_8.Items.Item(1) = "Friend"
            Select_friend_rela_8.Items.Item(2) = "Lover"
            Select_friend_rela_8.Items.Item(3) = "Ex"
            Select_friend_rela_8.Items.Item(4) = "Spouse"
            Select_friend_rela_8.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_8.Items.Item(6) = "Parent"
            Select_friend_rela_8.Items.Item(7) = "Sibling"
            Select_friend_rela_8.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_8.Items.Item(9) = "Best friend"
            Select_friend_rela_9.Items.Item(0) = "Unknow"
            Select_friend_rela_9.Items.Item(1) = "Friend"
            Select_friend_rela_9.Items.Item(2) = "Lover"
            Select_friend_rela_9.Items.Item(3) = "Ex"
            Select_friend_rela_9.Items.Item(4) = "Spouse"
            Select_friend_rela_9.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_9.Items.Item(6) = "Parent"
            Select_friend_rela_9.Items.Item(7) = "Sibling"
            Select_friend_rela_9.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_9.Items.Item(9) = "Best friend"
            Select_friend_rela_10.Items.Item(0) = "Unknow"
            Select_friend_rela_10.Items.Item(1) = "Friend"
            Select_friend_rela_10.Items.Item(2) = "Lover"
            Select_friend_rela_10.Items.Item(3) = "Ex"
            Select_friend_rela_10.Items.Item(4) = "Spouse"
            Select_friend_rela_10.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_10.Items.Item(6) = "Parent"
            Select_friend_rela_10.Items.Item(7) = "Sibling"
            Select_friend_rela_10.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_10.Items.Item(9) = "Best friend"
            Select_friend_rela_11.Items.Item(0) = "Unknow"
            Select_friend_rela_11.Items.Item(1) = "Friend"
            Select_friend_rela_11.Items.Item(2) = "Lover"
            Select_friend_rela_11.Items.Item(3) = "Ex"
            Select_friend_rela_11.Items.Item(4) = "Spouse"
            Select_friend_rela_11.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_11.Items.Item(6) = "Parent"
            Select_friend_rela_11.Items.Item(7) = "Sibling"
            Select_friend_rela_11.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_11.Items.Item(9) = "Best friend"
            Select_friend_rela_12.Items.Item(0) = "Unknow"
            Select_friend_rela_12.Items.Item(1) = "Friend"
            Select_friend_rela_12.Items.Item(2) = "Lover"
            Select_friend_rela_12.Items.Item(3) = "Ex"
            Select_friend_rela_12.Items.Item(4) = "Spouse"
            Select_friend_rela_12.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_12.Items.Item(6) = "Parent"
            Select_friend_rela_12.Items.Item(7) = "Sibling"
            Select_friend_rela_12.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_12.Items.Item(9) = "Best friend"
            Select_friend_rela_13.Items.Item(0) = "Unknow"
            Select_friend_rela_13.Items.Item(1) = "Friend"
            Select_friend_rela_13.Items.Item(2) = "Lover"
            Select_friend_rela_13.Items.Item(3) = "Ex"
            Select_friend_rela_13.Items.Item(4) = "Spouse"
            Select_friend_rela_13.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_13.Items.Item(6) = "Parent"
            Select_friend_rela_13.Items.Item(7) = "Sibling"
            Select_friend_rela_13.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_13.Items.Item(9) = "Best friend"
            Select_friend_rela_14.Items.Item(0) = "Unknow"
            Select_friend_rela_14.Items.Item(1) = "Friend"
            Select_friend_rela_14.Items.Item(2) = "Lover"
            Select_friend_rela_14.Items.Item(3) = "Ex"
            Select_friend_rela_14.Items.Item(4) = "Spouse"
            Select_friend_rela_14.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_14.Items.Item(6) = "Parent"
            Select_friend_rela_14.Items.Item(7) = "Sibling"
            Select_friend_rela_14.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_14.Items.Item(9) = "Best friend"
            Select_friend_rela_15.Items.Item(0) = "Unknow"
            Select_friend_rela_15.Items.Item(1) = "Friend"
            Select_friend_rela_15.Items.Item(2) = "Lover"
            Select_friend_rela_15.Items.Item(3) = "Ex"
            Select_friend_rela_15.Items.Item(4) = "Spouse"
            Select_friend_rela_15.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_15.Items.Item(6) = "Parent"
            Select_friend_rela_15.Items.Item(7) = "Sibling"
            Select_friend_rela_15.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_15.Items.Item(9) = "Best friend"
            Select_friend_rela_16.Items.Item(0) = "Unknow"
            Select_friend_rela_16.Items.Item(1) = "Friend"
            Select_friend_rela_16.Items.Item(2) = "Lover"
            Select_friend_rela_16.Items.Item(3) = "Ex"
            Select_friend_rela_16.Items.Item(4) = "Spouse"
            Select_friend_rela_16.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_16.Items.Item(6) = "Parent"
            Select_friend_rela_16.Items.Item(7) = "Sibling"
            Select_friend_rela_16.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_16.Items.Item(9) = "Best friend"
            Select_friend_rela_17.Items.Item(0) = "Unknow"
            Select_friend_rela_17.Items.Item(1) = "Friend"
            Select_friend_rela_17.Items.Item(2) = "Lover"
            Select_friend_rela_17.Items.Item(3) = "Ex"
            Select_friend_rela_17.Items.Item(4) = "Spouse"
            Select_friend_rela_17.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_17.Items.Item(6) = "Parent"
            Select_friend_rela_17.Items.Item(7) = "Sibling"
            Select_friend_rela_17.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_17.Items.Item(9) = "Best friend"
            Select_friend_rela_18.Items.Item(0) = "Unknow"
            Select_friend_rela_18.Items.Item(1) = "Friend"
            Select_friend_rela_18.Items.Item(2) = "Lover"
            Select_friend_rela_18.Items.Item(3) = "Ex"
            Select_friend_rela_18.Items.Item(4) = "Spouse"
            Select_friend_rela_18.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_18.Items.Item(6) = "Parent"
            Select_friend_rela_18.Items.Item(7) = "Sibling"
            Select_friend_rela_18.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_18.Items.Item(9) = "Best friend"
            Select_friend_rela_19.Items.Item(0) = "Unknow"
            Select_friend_rela_19.Items.Item(1) = "Friend"
            Select_friend_rela_19.Items.Item(2) = "Lover"
            Select_friend_rela_19.Items.Item(3) = "Ex"
            Select_friend_rela_19.Items.Item(4) = "Spouse"
            Select_friend_rela_19.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_19.Items.Item(6) = "Parent"
            Select_friend_rela_19.Items.Item(7) = "Sibling"
            Select_friend_rela_19.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_19.Items.Item(9) = "Best friend"
            Select_friend_rela_20.Items.Item(0) = "Unknow"
            Select_friend_rela_20.Items.Item(1) = "Friend"
            Select_friend_rela_20.Items.Item(2) = "Lover"
            Select_friend_rela_20.Items.Item(3) = "Ex"
            Select_friend_rela_20.Items.Item(4) = "Spouse"
            Select_friend_rela_20.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_20.Items.Item(6) = "Parent"
            Select_friend_rela_20.Items.Item(7) = "Sibling"
            Select_friend_rela_20.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_20.Items.Item(9) = "Best friend"
            Select_friend_rela_21.Items.Item(0) = "Unknow"
            Select_friend_rela_21.Items.Item(1) = "Friend"
            Select_friend_rela_21.Items.Item(2) = "Lover"
            Select_friend_rela_21.Items.Item(3) = "Ex"
            Select_friend_rela_21.Items.Item(4) = "Spouse"
            Select_friend_rela_21.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_21.Items.Item(6) = "Parent"
            Select_friend_rela_21.Items.Item(7) = "Sibling"
            Select_friend_rela_21.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_21.Items.Item(9) = "Best friend"
            Select_friend_rela_22.Items.Item(0) = "Unknow"
            Select_friend_rela_22.Items.Item(1) = "Friend"
            Select_friend_rela_22.Items.Item(2) = "Lover"
            Select_friend_rela_22.Items.Item(3) = "Ex"
            Select_friend_rela_22.Items.Item(4) = "Spouse"
            Select_friend_rela_22.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_22.Items.Item(6) = "Parent"
            Select_friend_rela_22.Items.Item(7) = "Sibling"
            Select_friend_rela_22.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_22.Items.Item(9) = "Best friend"
            Select_friend_rela_23.Items.Item(0) = "Unknow"
            Select_friend_rela_23.Items.Item(1) = "Friend"
            Select_friend_rela_23.Items.Item(2) = "Lover"
            Select_friend_rela_23.Items.Item(3) = "Ex"
            Select_friend_rela_23.Items.Item(4) = "Spouse"
            Select_friend_rela_23.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_23.Items.Item(6) = "Parent"
            Select_friend_rela_23.Items.Item(7) = "Sibling"
            Select_friend_rela_23.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_23.Items.Item(9) = "Best friend"
            Select_friend_rela_24.Items.Item(0) = "Unknow"
            Select_friend_rela_24.Items.Item(1) = "Friend"
            Select_friend_rela_24.Items.Item(2) = "Lover"
            Select_friend_rela_24.Items.Item(3) = "Ex"
            Select_friend_rela_24.Items.Item(4) = "Spouse"
            Select_friend_rela_24.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_24.Items.Item(6) = "Parent"
            Select_friend_rela_24.Items.Item(7) = "Sibling"
            Select_friend_rela_24.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_24.Items.Item(9) = "Best friend"
            Select_friend_rela_25.Items.Item(0) = "Unknow"
            Select_friend_rela_25.Items.Item(1) = "Friend"
            Select_friend_rela_25.Items.Item(2) = "Lover"
            Select_friend_rela_25.Items.Item(3) = "Ex"
            Select_friend_rela_25.Items.Item(4) = "Spouse"
            Select_friend_rela_25.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_25.Items.Item(6) = "Parent"
            Select_friend_rela_25.Items.Item(7) = "Sibling"
            Select_friend_rela_25.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_25.Items.Item(9) = "Best friend"
            Select_friend_rela_26.Items.Item(0) = "Unknow"
            Select_friend_rela_26.Items.Item(1) = "Friend"
            Select_friend_rela_26.Items.Item(2) = "Lover"
            Select_friend_rela_26.Items.Item(3) = "Ex"
            Select_friend_rela_26.Items.Item(4) = "Spouse"
            Select_friend_rela_26.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_26.Items.Item(6) = "Parent"
            Select_friend_rela_26.Items.Item(7) = "Sibling"
            Select_friend_rela_26.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_26.Items.Item(9) = "Best friend"
            Select_friend_rela_27.Items.Item(0) = "Unknow"
            Select_friend_rela_27.Items.Item(1) = "Friend"
            Select_friend_rela_27.Items.Item(2) = "Lover"
            Select_friend_rela_27.Items.Item(3) = "Ex"
            Select_friend_rela_27.Items.Item(4) = "Spouse"
            Select_friend_rela_27.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_27.Items.Item(6) = "Parent"
            Select_friend_rela_27.Items.Item(7) = "Sibling"
            Select_friend_rela_27.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_27.Items.Item(9) = "Best friend"
            Select_friend_rela_28.Items.Item(0) = "Unknow"
            Select_friend_rela_28.Items.Item(1) = "Friend"
            Select_friend_rela_28.Items.Item(2) = "Lover"
            Select_friend_rela_28.Items.Item(3) = "Ex"
            Select_friend_rela_28.Items.Item(4) = "Spouse"
            Select_friend_rela_28.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_28.Items.Item(6) = "Parent"
            Select_friend_rela_28.Items.Item(7) = "Sibling"
            Select_friend_rela_28.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_28.Items.Item(9) = "Best friend"
            Select_friend_rela_29.Items.Item(0) = "Unknow"
            Select_friend_rela_29.Items.Item(1) = "Friend"
            Select_friend_rela_29.Items.Item(2) = "Lover"
            Select_friend_rela_29.Items.Item(3) = "Ex"
            Select_friend_rela_29.Items.Item(4) = "Spouse"
            Select_friend_rela_29.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_29.Items.Item(6) = "Parent"
            Select_friend_rela_29.Items.Item(7) = "Sibling"
            Select_friend_rela_29.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_29.Items.Item(9) = "Best friend"
            Select_friend_rela_30.Items.Item(0) = "Unknow"
            Select_friend_rela_30.Items.Item(1) = "Friend"
            Select_friend_rela_30.Items.Item(2) = "Lover"
            Select_friend_rela_30.Items.Item(3) = "Ex"
            Select_friend_rela_30.Items.Item(4) = "Spouse"
            Select_friend_rela_30.Items.Item(5) = "Ex-spouse"
            Select_friend_rela_30.Items.Item(6) = "Parent"
            Select_friend_rela_30.Items.Item(7) = "Sibling"
            Select_friend_rela_30.Items.Item(8) = "Friend (in conflict)"
            Select_friend_rela_30.Items.Item(9) = "Best friend"
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_menu_button.Text = "Menu"
            Text_menu_open.Text = "Ouvrir"
            Menu_text_extras.Text = "Extras"
            Menu_text_islandedit.Text = "Édition île"
            Menu_text_miiedit.Text = "Édition Mii"
            Menu_text_repair.Text = "Réparation sauvegarde"
            Menu_text_settings.Text = "Paramètres"
            Menu_text_itemsedit.Text = "Édition objets"
            Title_appartrenov.Text = "Rénovation appartements"
            Title_childrenborn.Text = "Nouveau né"
            Title_eventfountain.Text = "Évènement fontaine"
            Title_islandname.Text = "Nom de l'île"
            Title_problemsolved.Text = "Problèmes résolus"
            Title_streetpassencounters.Text = "Streetpass reçus"
            Title_travelersreceived.Text = "Voyageurs reçus"
            Title_travelerssent.Text = "Voyageurs envoyés"
            Title_weddings.Text = "Mariages"
            Check_resetstpspp.Text = "Réinitialiser Streetpass / Spotpass de Tomodachi Life"
            Check_timetravel.Text = "Retirer la pénalité de voyage dans le temps"
            Setting_music.Text = "Activer la musique de fond"
            Setting_hidden.Text = "Afficher les choses cachés"
            Setting_filepath.Text = "Afficher le chemin du fichier"
            Setting_ckupdate.Text = "Désactiver la vérification des mises à jour"
            Text_language.Text = "Langage"
            Tab_mii_edit.Text = "Édition"
            Tab_mii_status.Text = "Status"
            Tab_mii_friendlist.Text = "Liste d'amis"
            Tab_mii_extras.Text = "Extras"
            Title_sharing.Text = "Partage"
            Title_copying.Text = "Copie"
            Title_firstname.Text = "Prénom"
            Title_lastname.Text = "Nom"
            Title_nickname.Text = "Surnom"
            Title_favcolor.Text = "Couleur favorite"
            Title_relationyou.Text = "Relation avec le ''vous'' réel"
            Title_growkid.Text = "Adulte / Enfant"
            Title_haircolor.Text = "Couleur cheveux"
            Title_creator.Text = "Créateur"
            Text_save_mii.Text = "Enregistrer changements"
            Select_unlock_gooditems.Items.Item(0) = "Ne rien faire"
            Select_unlock_gooditems.Items.Item(1) = "Tout débloquer"
            Select_unlock_gooditems.Items.Item(2) = "Tout supprimer"
            Select_unlock_interiors.Items.Item(0) = "Ne rien faire"
            Select_unlock_interiors.Items.Item(1) = "Tout débloquer"
            Select_unlock_interiors.Items.Item(2) = "Tout supprimer"
            Select_unlock_specialfoods.Items.Item(0) = "Ne rien faire"
            Select_unlock_specialfoods.Items.Item(1) = "Tout débloquer"
            Select_unlock_specialfoods.Items.Item(2) = "Tout supprimer"
            color_empty.Text = "normal"
            Button_close_hcoloredit.Text = "OK"
            Text_unlock_music.Text = "Tout débloquer"
            Text_edit_metal.Text = "Métal"
            Text_edit_pop.Text = "Pop"
            Text_edit_rockroll.Text = "Rock' n' Roll"
            Text_edit_rap.Text = "Rap"
            Text_edit_ballad.Text = "Ballade"
            Text_edit_opera.Text = "Opéra"
            Text_edit_techno.Text = "Techno"
            Text_edit_musical.Text = "Musicale"
            Text_level.Text = "Niv."
            Title_foods_allfav.Text = "Adore / Aime beaucoup"
            Title_foods_favorite.Text = "Aime bien"
            Title_foods_worst.Text = "N'aime pas / Déteste"
            Text_fullness.Text = "Estomac"
            Check_fullness.Text = "Il a pas mangé"
            Title_interactionpattern.Text = "Interaction"
            Title_target1.Text = "Cible 1"
            Title_target2.Text = "Cible 2"
            Title_emotions.Text = "Émotions"
            Select_growkid.Items.Item(0) = "Adulte"
            Select_growkid.Items.Item(1) = "Adulte (1)"
            Select_growkid.Items.Item(2) = "Enfant"
            Select_relationyou.Items.Item(0) = "Enfant"
            Select_relationyou.Items.Item(1) = "Aucune parenté"
            Select_relationyou.Items.Item(2) = "Famille"
            Select_relationyou.Items.Item(3) = "Parent"
            Select_relationyou.Items.Item(4) = "Moi-même"
            Select_relationyou.Items.Item(5) = "Frère / Soeur"
            Select_relationyou.Items.Item(6) = "Épouse"
            Select_interaction.Items.Item(0) = "Rien"
            Select_interaction.Items.Item(1) = "J'ai faim"
            Select_interaction.Items.Item(2) = "J'ai faim (1)"
            Select_interaction.Items.Item(3) = "J'ai faim (2)"
            Select_interaction.Items.Item(4) = "Amoureux de"
            Select_interaction.Items.Item(5) = "Faché contre"
            Select_interaction.Items.Item(6) = "Faché contre (1)"
            Select_interaction.Items.Item(7) = "Amoureux de (indécis)"
            Select_interaction.Items.Item(8) = "Rêve"
            Select_interaction.Items.Item(9) = "J'ai besoin de nouveaux vêtements"
            Select_interaction.Items.Item(10) = "J'ai besoin de nouveaux vêtements (qq.chose de classe)"
            Select_interaction.Items.Item(11) = "J'ai besoin de nouveaux vêtements (pr.faire du sports)"
            Select_interaction.Items.Item(12) = "Puis-je vous parler de [mes histoires d'amour? / ma femme?]"
            Select_interaction.Items.Item(13) = "Triste : amour rejeté"
            Select_interaction.Items.Item(14) = "Veux se marrier"
            Select_emotions.Items.Item(0) = "Normal"
            Select_emotions.Items.Item(1) = "Heureux"
            Select_emotions.Items.Item(2) = "En colère"
            Select_emotions.Items.Item(3) = "Triste"
            Select_emotions.Items.Item(4) = "Amoureux"
            Button_setallfriends.Text = "Mettre tout à"
            Select_allfriends.Items.Item(0) = "Mii 1 à 30"
            Select_allfriends.Items.Item(1) = "Mii 31 à 60"
            Select_allfriends.Items.Item(2) = "Mii 61 à 90"
            Select_allfriends.Items.Item(3) = "Mii 91 à 100"
            Title_ranking_pampered.Text = "Mii préférés"
            Title_ranking_splurge.Text = "Mii dépensiers"
            Select_friend_rela_1.Items.Item(0) = "Inconnu"
            Select_friend_rela_1.Items.Item(1) = "Ami"
            Select_friend_rela_1.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_1.Items.Item(3) = "Ex"
            Select_friend_rela_1.Items.Item(4) = "Époux(se)"
            Select_friend_rela_1.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_1.Items.Item(6) = "Parent"
            Select_friend_rela_1.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_1.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_1.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_2.Items.Item(0) = "Inconnu"
            Select_friend_rela_2.Items.Item(1) = "Ami"
            Select_friend_rela_2.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_2.Items.Item(3) = "Ex"
            Select_friend_rela_2.Items.Item(4) = "Époux(se)"
            Select_friend_rela_2.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_2.Items.Item(6) = "Parent"
            Select_friend_rela_2.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_2.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_2.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_3.Items.Item(0) = "Inconnu"
            Select_friend_rela_3.Items.Item(1) = "Ami"
            Select_friend_rela_3.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_3.Items.Item(3) = "Ex"
            Select_friend_rela_3.Items.Item(4) = "Époux(se)"
            Select_friend_rela_3.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_3.Items.Item(6) = "Parent"
            Select_friend_rela_3.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_3.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_3.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_4.Items.Item(0) = "Inconnu"
            Select_friend_rela_4.Items.Item(1) = "Ami"
            Select_friend_rela_4.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_4.Items.Item(3) = "Ex"
            Select_friend_rela_4.Items.Item(4) = "Époux(se)"
            Select_friend_rela_4.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_4.Items.Item(6) = "Parent"
            Select_friend_rela_4.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_4.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_4.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_5.Items.Item(0) = "Inconnu"
            Select_friend_rela_5.Items.Item(1) = "Ami"
            Select_friend_rela_5.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_5.Items.Item(3) = "Ex"
            Select_friend_rela_5.Items.Item(4) = "Époux(se)"
            Select_friend_rela_5.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_5.Items.Item(6) = "Parent"
            Select_friend_rela_5.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_5.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_5.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_6.Items.Item(0) = "Inconnu"
            Select_friend_rela_6.Items.Item(1) = "Ami"
            Select_friend_rela_6.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_6.Items.Item(3) = "Ex"
            Select_friend_rela_6.Items.Item(4) = "Époux(se)"
            Select_friend_rela_6.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_6.Items.Item(6) = "Parent"
            Select_friend_rela_6.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_6.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_6.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_7.Items.Item(0) = "Inconnu"
            Select_friend_rela_7.Items.Item(1) = "Ami"
            Select_friend_rela_7.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_7.Items.Item(3) = "Ex"
            Select_friend_rela_7.Items.Item(4) = "Époux(se)"
            Select_friend_rela_7.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_7.Items.Item(6) = "Parent"
            Select_friend_rela_7.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_7.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_7.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_8.Items.Item(0) = "Inconnu"
            Select_friend_rela_8.Items.Item(1) = "Ami"
            Select_friend_rela_8.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_8.Items.Item(3) = "Ex"
            Select_friend_rela_8.Items.Item(4) = "Époux(se)"
            Select_friend_rela_8.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_8.Items.Item(6) = "Parent"
            Select_friend_rela_8.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_8.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_8.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_9.Items.Item(0) = "Inconnu"
            Select_friend_rela_9.Items.Item(1) = "Ami"
            Select_friend_rela_9.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_9.Items.Item(3) = "Ex"
            Select_friend_rela_9.Items.Item(4) = "Époux(se)"
            Select_friend_rela_9.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_9.Items.Item(6) = "Parent"
            Select_friend_rela_9.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_9.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_9.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_10.Items.Item(0) = "Inconnu"
            Select_friend_rela_10.Items.Item(1) = "Ami"
            Select_friend_rela_10.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_10.Items.Item(3) = "Ex"
            Select_friend_rela_10.Items.Item(4) = "Époux(se)"
            Select_friend_rela_10.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_10.Items.Item(6) = "Parent"
            Select_friend_rela_10.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_10.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_10.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_11.Items.Item(0) = "Inconnu"
            Select_friend_rela_11.Items.Item(1) = "Ami"
            Select_friend_rela_11.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_11.Items.Item(3) = "Ex"
            Select_friend_rela_11.Items.Item(4) = "Époux(se)"
            Select_friend_rela_11.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_11.Items.Item(6) = "Parent"
            Select_friend_rela_11.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_11.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_11.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_12.Items.Item(0) = "Inconnu"
            Select_friend_rela_12.Items.Item(1) = "Ami"
            Select_friend_rela_12.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_12.Items.Item(3) = "Ex"
            Select_friend_rela_12.Items.Item(4) = "Époux(se)"
            Select_friend_rela_12.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_12.Items.Item(6) = "Parent"
            Select_friend_rela_12.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_12.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_12.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_13.Items.Item(0) = "Inconnu"
            Select_friend_rela_13.Items.Item(1) = "Ami"
            Select_friend_rela_13.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_13.Items.Item(3) = "Ex"
            Select_friend_rela_13.Items.Item(4) = "Époux(se)"
            Select_friend_rela_13.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_13.Items.Item(6) = "Parent"
            Select_friend_rela_13.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_13.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_13.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_14.Items.Item(0) = "Inconnu"
            Select_friend_rela_14.Items.Item(1) = "Ami"
            Select_friend_rela_14.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_14.Items.Item(3) = "Ex"
            Select_friend_rela_14.Items.Item(4) = "Époux(se)"
            Select_friend_rela_14.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_14.Items.Item(6) = "Parent"
            Select_friend_rela_14.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_14.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_14.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_15.Items.Item(0) = "Inconnu"
            Select_friend_rela_15.Items.Item(1) = "Ami"
            Select_friend_rela_15.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_15.Items.Item(3) = "Ex"
            Select_friend_rela_15.Items.Item(4) = "Époux(se)"
            Select_friend_rela_15.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_15.Items.Item(6) = "Parent"
            Select_friend_rela_15.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_15.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_15.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_16.Items.Item(0) = "Inconnu"
            Select_friend_rela_16.Items.Item(1) = "Ami"
            Select_friend_rela_16.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_16.Items.Item(3) = "Ex"
            Select_friend_rela_16.Items.Item(4) = "Époux(se)"
            Select_friend_rela_16.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_16.Items.Item(6) = "Parent"
            Select_friend_rela_16.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_16.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_16.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_17.Items.Item(0) = "Inconnu"
            Select_friend_rela_17.Items.Item(1) = "Ami"
            Select_friend_rela_17.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_17.Items.Item(3) = "Ex"
            Select_friend_rela_17.Items.Item(4) = "Époux(se)"
            Select_friend_rela_17.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_17.Items.Item(6) = "Parent"
            Select_friend_rela_17.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_17.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_17.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_18.Items.Item(0) = "Inconnu"
            Select_friend_rela_18.Items.Item(1) = "Ami"
            Select_friend_rela_18.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_18.Items.Item(3) = "Ex"
            Select_friend_rela_18.Items.Item(4) = "Époux(se)"
            Select_friend_rela_18.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_18.Items.Item(6) = "Parent"
            Select_friend_rela_18.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_18.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_18.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_19.Items.Item(0) = "Inconnu"
            Select_friend_rela_19.Items.Item(1) = "Ami"
            Select_friend_rela_19.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_19.Items.Item(3) = "Ex"
            Select_friend_rela_19.Items.Item(4) = "Époux(se)"
            Select_friend_rela_19.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_19.Items.Item(6) = "Parent"
            Select_friend_rela_19.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_19.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_19.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_20.Items.Item(0) = "Inconnu"
            Select_friend_rela_20.Items.Item(1) = "Ami"
            Select_friend_rela_20.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_20.Items.Item(3) = "Ex"
            Select_friend_rela_20.Items.Item(4) = "Époux(se)"
            Select_friend_rela_20.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_20.Items.Item(6) = "Parent"
            Select_friend_rela_20.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_20.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_20.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_21.Items.Item(0) = "Inconnu"
            Select_friend_rela_21.Items.Item(1) = "Ami"
            Select_friend_rela_21.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_21.Items.Item(3) = "Ex"
            Select_friend_rela_21.Items.Item(4) = "Époux(se)"
            Select_friend_rela_21.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_21.Items.Item(6) = "Parent"
            Select_friend_rela_21.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_21.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_21.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_22.Items.Item(0) = "Inconnu"
            Select_friend_rela_22.Items.Item(1) = "Ami"
            Select_friend_rela_22.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_22.Items.Item(3) = "Ex"
            Select_friend_rela_22.Items.Item(4) = "Époux(se)"
            Select_friend_rela_22.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_22.Items.Item(6) = "Parent"
            Select_friend_rela_22.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_22.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_22.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_23.Items.Item(0) = "Inconnu"
            Select_friend_rela_23.Items.Item(1) = "Ami"
            Select_friend_rela_23.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_23.Items.Item(3) = "Ex"
            Select_friend_rela_23.Items.Item(4) = "Époux(se)"
            Select_friend_rela_23.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_23.Items.Item(6) = "Parent"
            Select_friend_rela_23.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_23.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_23.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_24.Items.Item(0) = "Inconnu"
            Select_friend_rela_24.Items.Item(1) = "Ami"
            Select_friend_rela_24.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_24.Items.Item(3) = "Ex"
            Select_friend_rela_24.Items.Item(4) = "Époux(se)"
            Select_friend_rela_24.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_24.Items.Item(6) = "Parent"
            Select_friend_rela_24.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_24.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_24.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_25.Items.Item(0) = "Inconnu"
            Select_friend_rela_25.Items.Item(1) = "Ami"
            Select_friend_rela_25.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_25.Items.Item(3) = "Ex"
            Select_friend_rela_25.Items.Item(4) = "Époux(se)"
            Select_friend_rela_25.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_25.Items.Item(6) = "Parent"
            Select_friend_rela_25.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_25.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_25.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_26.Items.Item(0) = "Inconnu"
            Select_friend_rela_26.Items.Item(1) = "Ami"
            Select_friend_rela_26.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_26.Items.Item(3) = "Ex"
            Select_friend_rela_26.Items.Item(4) = "Époux(se)"
            Select_friend_rela_26.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_26.Items.Item(6) = "Parent"
            Select_friend_rela_26.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_26.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_26.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_27.Items.Item(0) = "Inconnu"
            Select_friend_rela_27.Items.Item(1) = "Ami"
            Select_friend_rela_27.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_27.Items.Item(3) = "Ex"
            Select_friend_rela_27.Items.Item(4) = "Époux(se)"
            Select_friend_rela_27.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_27.Items.Item(6) = "Parent"
            Select_friend_rela_27.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_27.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_27.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_28.Items.Item(0) = "Inconnu"
            Select_friend_rela_28.Items.Item(1) = "Ami"
            Select_friend_rela_28.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_28.Items.Item(3) = "Ex"
            Select_friend_rela_28.Items.Item(4) = "Époux(se)"
            Select_friend_rela_28.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_28.Items.Item(6) = "Parent"
            Select_friend_rela_28.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_28.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_28.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_29.Items.Item(0) = "Inconnu"
            Select_friend_rela_29.Items.Item(1) = "Ami"
            Select_friend_rela_29.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_29.Items.Item(3) = "Ex"
            Select_friend_rela_29.Items.Item(4) = "Époux(se)"
            Select_friend_rela_29.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_29.Items.Item(6) = "Parent"
            Select_friend_rela_29.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_29.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_29.Items.Item(9) = "Meilleur(e) ami(e)"
            Select_friend_rela_30.Items.Item(0) = "Inconnu"
            Select_friend_rela_30.Items.Item(1) = "Ami"
            Select_friend_rela_30.Items.Item(2) = "Amoureux(se)"
            Select_friend_rela_30.Items.Item(3) = "Ex"
            Select_friend_rela_30.Items.Item(4) = "Époux(se)"
            Select_friend_rela_30.Items.Item(5) = "Ex-Époux(se)"
            Select_friend_rela_30.Items.Item(6) = "Parent"
            Select_friend_rela_30.Items.Item(7) = "Frère/Soeur"
            Select_friend_rela_30.Items.Item(8) = "Ami (en conflit)"
            Select_friend_rela_30.Items.Item(9) = "Meilleur(e) ami(e)"
        End If
    End Sub

    Private Sub Icon_appart_Click(sender As Object, e As EventArgs) Handles Icon_appart.Click
        If value_appart.Value < 2 Then
            value_appart.Value = value_appart.Value + 1
        ElseIf value_appart.Value = 2 Then
            value_appart.Value = 0
        End If
    End Sub

    Private Sub Icon_broc_Click(sender As Object, e As EventArgs) Handles Icon_broc.Click
        If value_broc.Value < 2 Then
            value_broc.Value = value_broc.Value + 1
        ElseIf value_broc.Value = 2 Then
            value_broc.Value = 0
        End If
    End Sub

    Private Sub Icon_cafe_Click(sender As Object, e As EventArgs) Handles Icon_cafe.Click
        If value_cafe.Value < 2 Then
            value_cafe.Value = value_cafe.Value + 1
        ElseIf value_cafe.Value = 2 Then
            value_cafe.Value = 0
        End If
    End Sub

    Private Sub Icon_chap_Click(sender As Object, e As EventArgs) Handles Icon_chap.Click
        If value_chap.Value < 2 Then
            value_chap.Value = value_chap.Value + 1
        ElseIf value_chap.Value = 2 Then
            value_chap.Value = 0
        End If
    End Sub

    Private Sub Icon_classem_Click(sender As Object, e As EventArgs) Handles Icon_classem.Click
        If value_classem.Value < 2 Then
            value_classem.Value = value_classem.Value + 1
        ElseIf value_classem.Value = 2 Then
            value_classem.Value = 0
        End If
    End Sub

    Private Sub Icon_conc_Click(sender As Object, e As EventArgs) Handles Icon_conc.Click
        If value_conc.Value < 2 Then
            value_conc.Value = value_conc.Value + 1
        ElseIf value_conc.Value = 2 Then
            value_conc.Value = 0
        End If
    End Sub

    Private Sub Icon_deco_Click(sender As Object, e As EventArgs) Handles Icon_deco.Click
        If value_deco.Value < 2 Then
            value_deco.Value = value_deco.Value + 1
        ElseIf value_deco.Value = 2 Then
            value_deco.Value = 0
        End If
    End Sub

    Private Sub Icon_epicer_Click(sender As Object, e As EventArgs) Handles Icon_epicer.Click
        If value_epicer.Value < 2 Then
            value_epicer.Value = value_epicer.Value + 1
        ElseIf value_epicer.Value = 2 Then
            value_epicer.Value = 0
        End If
    End Sub

    Private Sub Icon_font_Click(sender As Object, e As EventArgs) Handles Icon_font.Click
        If value_font.Value < 2 Then
            value_font.Value = value_font.Value + 1
        ElseIf value_font.Value = 2 Then
            value_font.Value = 0
        End If
    End Sub

    Private Sub Icon_info_Click(sender As Object, e As EventArgs) Handles Icon_info.Click
        If value_info.Value < 2 Then
            value_info.Value = value_info.Value + 1
        ElseIf value_info.Value = 2 Then
            value_info.Value = 0
        End If
    End Sub

    Private Sub Icon_magimport_Click(sender As Object, e As EventArgs) Handles Icon_magimport.Click
        If value_magimport.Value < 2 Then
            value_magimport.Value = value_magimport.Value + 1
        ElseIf value_magimport.Value = 2 Then
            value_magimport.Value = 0
        End If
    End Sub

    Private Sub Icon_mair_Click(sender As Object, e As EventArgs) Handles Icon_mair.Click
        If value_mair.Value < 2 Then
            value_mair.Value = value_mair.Value + 1
        ElseIf value_mair.Value = 2 Then
            value_mair.Value = 0
        End If
    End Sub

    Private Sub Icon_mais_Click(sender As Object, e As EventArgs) Handles Icon_mais.Click
        If value_mais.Value < 2 Then
            value_mais.Value = value_mais.Value + 1
        ElseIf value_mais.Value = 2 Then
            value_mais.Value = 0
        End If
    End Sub

    Private Sub Icon_parc_Click(sender As Object, e As EventArgs) Handles Icon_parc.Click
        If value_parc.Value < 2 Then
            value_parc.Value = value_parc.Value + 1
        ElseIf value_parc.Value = 2 Then
            value_parc.Value = 0
        End If
    End Sub

    Private Sub Icon_parc1_Click(sender As Object, e As EventArgs) Handles Icon_parc1.Click
        If value_parc1.Value < 2 Then
            value_parc1.Value = value_parc1.Value + 1
        ElseIf value_parc1.Value = 2 Then
            value_parc1.Value = 0
        End If
    End Sub

    Private Sub Icon_part_Click(sender As Object, e As EventArgs) Handles Icon_part.Click
        If value_part.Value < 2 Then
            value_part.Value = value_part.Value + 1
        ElseIf value_part.Value = 2 Then
            value_part.Value = 0
        End If
    End Sub

    Private Sub Icon_plage_Click(sender As Object, e As EventArgs) Handles Icon_plage.Click
        If value_plage.Value < 2 Then
            value_plage.Value = value_plage.Value + 1
        ElseIf value_plage.Value = 2 Then
            value_plage.Value = 0
        End If
    End Sub

    Private Sub Icon_port_Click(sender As Object, e As EventArgs) Handles Icon_port.Click
        If value_port.Value < 2 Then
            value_port.Value = value_port.Value + 1
        ElseIf value_port.Value = 2 Then
            value_port.Value = 0
        End If
    End Sub

    Private Sub Icon_stud_Click(sender As Object, e As EventArgs) Handles Icon_stud.Click
        If value_stud.Value < 2 Then
            value_stud.Value = value_stud.Value + 1
        ElseIf value_stud.Value = 2 Then
            value_stud.Value = 0
        End If
    End Sub

    Private Sub Icon_tervague_Click(sender As Object, e As EventArgs) Handles Icon_tervague.Click
        If value_tervague.Value < 2 Then
            value_tervague.Value = value_tervague.Value + 1
        ElseIf value_tervague.Value = 2 Then
            value_tervague.Value = 0
        End If
    End Sub

    Private Sub Icon_test_Click(sender As Object, e As EventArgs) Handles Icon_test.Click
        If value_test.Value < 2 Then
            value_test.Value = value_test.Value + 1
        ElseIf value_test.Value = 2 Then
            value_test.Value = 0
        End If
    End Sub

    Private Sub Icon_tour_Click(sender As Object, e As EventArgs) Handles Icon_tour.Click
        If value_tour.Value < 2 Then
            value_tour.Value = value_tour.Value + 1
        ElseIf value_tour.Value = 2 Then
            value_tour.Value = 0
        End If
    End Sub

    Private Sub Icon_vetem_Click(sender As Object, e As EventArgs) Handles Icon_vetem.Click
        If value_vetem.Value < 2 Then
            value_vetem.Value = value_vetem.Value + 1
        ElseIf value_vetem.Value = 2 Then
            value_vetem.Value = 0
        End If
    End Sub

    Private Sub value_appart_ValueChanged(sender As Object, e As EventArgs) Handles value_appart.ValueChanged
        If value_appart.Value = 0 Then
            Icon_appart.Image = Nothing
        ElseIf value_appart.Value = 1 Then
            Icon_appart.Image = My.Resources.appart
        ElseIf value_appart.Value = 2 Then
            Icon_appart.Image = My.Resources.appartn
        End If
    End Sub

    Private Sub value_broc_ValueChanged(sender As Object, e As EventArgs) Handles value_broc.ValueChanged
        If value_broc.Value = 0 Then
            Icon_broc.Image = Nothing
        ElseIf value_broc.Value = 1 Then
            Icon_broc.Image = My.Resources.broc
        ElseIf value_broc.Value = 2 Then
            Icon_broc.Image = My.Resources.brocn
        End If
    End Sub

    Private Sub value_cafe_ValueChanged(sender As Object, e As EventArgs) Handles value_cafe.ValueChanged
        If value_cafe.Value = 0 Then
            Icon_cafe.Image = Nothing
        ElseIf value_cafe.Value = 1 Then
            Icon_cafe.Image = My.Resources.cafe
        ElseIf value_cafe.Value = 2 Then
            Icon_cafe.Image = My.Resources.cafen
        End If
    End Sub

    Private Sub value_chap_ValueChanged(sender As Object, e As EventArgs) Handles value_chap.ValueChanged
        If value_chap.Value = 0 Then
            Icon_chap.Image = Nothing
        ElseIf value_chap.Value = 1 Then
            Icon_chap.Image = My.Resources.chap
        ElseIf value_chap.Value = 2 Then
            Icon_chap.Image = My.Resources.chapn
        End If
    End Sub

    Private Sub value_classem_ValueChanged(sender As Object, e As EventArgs) Handles value_classem.ValueChanged
        If value_classem.Value = 0 Then
            Icon_classem.Image = Nothing
        ElseIf value_classem.Value = 1 Then
            Icon_classem.Image = My.Resources.classem
        ElseIf value_classem.Value = 2 Then
            Icon_classem.Image = My.Resources.classn
        End If
    End Sub

    Private Sub value_conc_ValueChanged(sender As Object, e As EventArgs) Handles value_conc.ValueChanged
        If value_conc.Value = 0 Then
            Icon_conc.Image = Nothing
        ElseIf value_conc.Value = 1 Then
            Icon_conc.Image = My.Resources.conc
        ElseIf value_conc.Value = 2 Then
            Icon_conc.Image = My.Resources.concn
        End If
    End Sub

    Private Sub value_deco_ValueChanged(sender As Object, e As EventArgs) Handles value_deco.ValueChanged
        If value_deco.Value = 0 Then
            Icon_deco.Image = Nothing
        ElseIf value_deco.Value = 1 Then
            Icon_deco.Image = My.Resources.deco
        ElseIf value_deco.Value = 2 Then
            Icon_deco.Image = My.Resources.decon
        End If
    End Sub

    Private Sub value_epicer_ValueChanged(sender As Object, e As EventArgs) Handles value_epicer.ValueChanged
        If value_epicer.Value = 0 Then
            Icon_epicer.Image = Nothing
        ElseIf value_epicer.Value = 1 Then
            Icon_epicer.Image = My.Resources.epicer
        ElseIf value_epicer.Value = 2 Then
            Icon_epicer.Image = My.Resources.epicern
        End If
    End Sub

    Private Sub value_font_ValueChanged(sender As Object, e As EventArgs) Handles value_font.ValueChanged
        If value_font.Value = 0 Then
            Icon_font.Image = Nothing
        ElseIf value_font.Value = 1 Then
            Icon_font.Image = My.Resources.font
        ElseIf value_font.Value = 2 Then
            Icon_font.Image = My.Resources.fontn
        End If
    End Sub

    Private Sub value_info_ValueChanged(sender As Object, e As EventArgs) Handles value_info.ValueChanged
        If value_info.Value = 0 Then
            Icon_info.Image = Nothing
        ElseIf value_info.Value = 1 Then
            Icon_info.Image = My.Resources.info
        ElseIf value_info.Value = 2 Then
            Icon_info.Image = My.Resources.infon
        End If
    End Sub

    Private Sub value_magimport_ValueChanged(sender As Object, e As EventArgs) Handles value_magimport.ValueChanged
        If value_magimport.Value = 0 Then
            Icon_magimport.Image = Nothing
        ElseIf value_magimport.Value = 1 Then
            Icon_magimport.Image = My.Resources.magimport
        ElseIf value_magimport.Value = 2 Then
            Icon_magimport.Image = My.Resources.magimportn
        End If
    End Sub

    Private Sub value_mair_ValueChanged(sender As Object, e As EventArgs) Handles value_mair.ValueChanged
        If value_mair.Value = 0 Then
            Icon_mair.Image = Nothing
        ElseIf value_mair.Value = 1 Then
            Icon_mair.Image = My.Resources.mair
        ElseIf value_mair.Value = 2 Then
            Icon_mair.Image = My.Resources.mairn
        End If
    End Sub

    Private Sub value_mais_ValueChanged(sender As Object, e As EventArgs) Handles value_mais.ValueChanged
        If value_mais.Value = 0 Then
            Icon_mais.Image = Nothing
        ElseIf value_mais.Value = 1 Then
            Icon_mais.Image = My.Resources.mais
        ElseIf value_mais.Value = 2 Then
            Icon_mais.Image = My.Resources.maisn
        End If
    End Sub

    Private Sub value_parc_ValueChanged(sender As Object, e As EventArgs) Handles value_parc.ValueChanged
        If value_parc.Value = 0 Then
            Icon_parc.Image = Nothing
        ElseIf value_parc.Value = 1 Then
            Icon_parc.Image = My.Resources.parc
        ElseIf value_parc.Value = 2 Then
            Icon_parc.Image = My.Resources.parcn
        End If
    End Sub

    Private Sub value_parc1_ValueChanged(sender As Object, e As EventArgs) Handles value_parc1.ValueChanged
        If value_parc1.Value = 0 Then
            Icon_parc1.Image = Nothing
        ElseIf value_parc1.Value = 1 Then
            Icon_parc1.Image = My.Resources.parc1
        ElseIf value_parc1.Value = 2 Then
            Icon_parc1.Image = My.Resources.parc1n
        End If
    End Sub

    Private Sub value_part_ValueChanged(sender As Object, e As EventArgs) Handles value_part.ValueChanged
        If value_part.Value = 0 Then
            Icon_part.Image = Nothing
        ElseIf value_part.Value = 1 Then
            Icon_part.Image = My.Resources.part
        ElseIf value_part.Value = 2 Then
            Icon_part.Image = My.Resources.partn
        End If
    End Sub

    Private Sub value_plage_ValueChanged(sender As Object, e As EventArgs) Handles value_plage.ValueChanged
        If value_plage.Value = 0 Then
            Icon_plage.Image = Nothing
        ElseIf value_plage.Value = 1 Then
            Icon_plage.Image = My.Resources.plage
        ElseIf value_plage.Value = 2 Then
            Icon_plage.Image = My.Resources.plagen
        End If
    End Sub

    Private Sub value_port_ValueChanged(sender As Object, e As EventArgs) Handles value_port.ValueChanged
        If value_port.Value = 0 Then
            Icon_port.Image = Nothing
        ElseIf value_port.Value = 1 Then
            Icon_port.Image = My.Resources.port
        ElseIf value_port.Value = 2 Then
            Icon_port.Image = My.Resources.portn
        End If
    End Sub

    Private Sub value_stud_ValueChanged(sender As Object, e As EventArgs) Handles value_stud.ValueChanged
        If value_stud.Value = 0 Then
            Icon_stud.Image = Nothing
        ElseIf value_stud.Value = 1 Then
            Icon_stud.Image = My.Resources.stud
        ElseIf value_stud.Value = 2 Then
            Icon_stud.Image = My.Resources.studn
        End If
    End Sub

    Private Sub value_tervague_ValueChanged(sender As Object, e As EventArgs) Handles value_tervague.ValueChanged
        If value_tervague.Value = 0 Then
            Icon_tervague.Image = Nothing
        ElseIf value_tervague.Value = 1 Then
            Icon_tervague.Image = My.Resources.tervague
        ElseIf value_tervague.Value = 2 Then
            Icon_tervague.Image = My.Resources.tervaguen
        End If
    End Sub

    Private Sub value_test_ValueChanged(sender As Object, e As EventArgs) Handles value_test.ValueChanged
        If value_test.Value = 0 Then
            Icon_test.Image = Nothing
        ElseIf value_test.Value = 1 Then
            Icon_test.Image = My.Resources.test
        ElseIf value_test.Value = 2 Then
            Icon_test.Image = My.Resources.testn
        End If
    End Sub

    Private Sub value_tour_ValueChanged(sender As Object, e As EventArgs) Handles value_tour.ValueChanged
        If value_tour.Value = 0 Then
            Icon_tour.Image = Nothing
        ElseIf value_tour.Value = 1 Then
            Icon_tour.Image = My.Resources.tour
        ElseIf value_tour.Value = 2 Then
            Icon_tour.Image = My.Resources.tourn
        End If
    End Sub

    Private Sub value_vetem_ValueChanged(sender As Object, e As EventArgs) Handles value_vetem.ValueChanged
        If value_vetem.Value = 0 Then
            Icon_vetem.Image = Nothing
        ElseIf value_vetem.Value = 1 Then
            Icon_vetem.Image = My.Resources.vet
        ElseIf value_vetem.Value = 2 Then
            Icon_vetem.Image = My.Resources.vetn
        End If
    End Sub

    Private Sub Menu_width_Click(sender As Object, e As EventArgs) Handles Menu_width.Click
        If Menu_panel.Width = 34 Then
            Menu_panel.Width = 150
            Menu_width.Location = New Point(116, 0)
        Else
            Menu_panel.Width = 34
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub TL_SaveEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select_language.SelectedItem = Select_language.Items.Item(0)
        Select_music.SelectedItem = Select_music.Items.Item(0)
        Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(0)
        Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(0)
        Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(0)
        Try
            Setting_ckupdate.Checked = My.Settings.Parasetting_ckupdate
            Setting_filepath.Checked = My.Settings.Parasetting_filepath
            Setting_hidden.Checked = My.Settings.Parasetting_hidden
            Select_language.SelectedItem = My.Settings.Parasetting_language
            Menu_panel.Width = My.Settings.Parasetting_menu
            Setting_music.Checked = My.Settings.Parasetting_music
            Select_music.SelectedItem = My.Settings.Parasetting_musicsel
        Catch ex As Exception
        End Try
        If Menu_panel.Width = 150 Then
            Menu_width.Location = New Point(116, 0)
        ElseIf Menu_panel.Width = 34 Then
            Menu_width.Location = New Point(0, 0)
        End If
    End Sub

    Private Sub TL_SaveEditor_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Parasetting_ckupdate = Setting_ckupdate.Checked
        My.Settings.Parasetting_filepath = Setting_filepath.Checked
        My.Settings.Parasetting_hidden = Setting_hidden.Checked
        My.Settings.Parasetting_language = Select_language.SelectedItem
        My.Settings.Parasetting_menu = Menu_panel.Width
        My.Settings.Parasetting_music = Setting_music.Checked
        My.Settings.Parasetting_musicsel = Select_music.SelectedItem
    End Sub

    Private Sub Setting_hidden_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_hidden.CheckedChanged
        If Setting_hidden.Checked = True Then
            Hidden_things.Visible = True
            value_appartrenov.Visible = True
            value_eventfountain.Visible = True
            value_appart.Visible = True
            value_broc.Visible = True
            value_cafe.Visible = True
            value_chap.Visible = True
            value_classem.Visible = True
            value_conc.Visible = True
            value_deco.Visible = True
            value_epicer.Visible = True
            value_font.Visible = True
            value_info.Visible = True
            value_magimport.Visible = True
            value_mair.Visible = True
            value_mais.Visible = True
            value_parc.Visible = True
            value_parc1.Visible = True
            value_part.Visible = True
            value_plage.Visible = True
            value_port.Visible = True
            value_stud.Visible = True
            value_tervague.Visible = True
            value_test.Visible = True
            value_tour.Visible = True
            value_vetem.Visible = True

        Else
            Hidden_things.Visible = False
            value_appartrenov.Visible = False
            value_eventfountain.Visible = False
            value_appart.Visible = False
            value_broc.Visible = False
            value_cafe.Visible = False
            value_chap.Visible = False
            value_classem.Visible = False
            value_conc.Visible = False
            value_deco.Visible = False
            value_epicer.Visible = False
            value_font.Visible = False
            value_info.Visible = False
            value_magimport.Visible = False
            value_mair.Visible = False
            value_mais.Visible = False
            value_parc.Visible = False
            value_parc1.Visible = False
            value_part.Visible = False
            value_plage.Visible = False
            value_port.Visible = False
            value_stud.Visible = False
            value_tervague.Visible = False
            value_test.Visible = False
            value_tour.Visible = False
            value_vetem.Visible = False
        End If
    End Sub

    Private Sub Setting_filepath_CheckedChanged(sender As Object, e As EventArgs) Handles Setting_filepath.CheckedChanged
        If Setting_filepath.Checked = True Then
            File_path.Visible = True
        Else
            File_path.Visible = False
        End If
    End Sub

    Private Sub Icon_miiedit_music_Click(sender As Object, e As EventArgs) Handles Icon_miiedit_music.Click
        Panel_cathphrase.Visible = False
        Panel_mii_musics.Visible = True
        Panel_mii_inventory.Visible = False
    End Sub

    Private Sub Icon_cathphrase_Click(sender As Object, e As EventArgs) Handles Icon_cathphrase.Click
        Panel_cathphrase.Visible = True
        Panel_mii_musics.Visible = False
        Panel_mii_inventory.Visible = False
    End Sub

    Private Sub Icon_inventory_Click(sender As Object, e As EventArgs) Handles Icon_inventory.Click
        Panel_cathphrase.Visible = False
        Panel_mii_musics.Visible = False
        Panel_mii_inventory.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.Click
        Text_edit_firstname.Text = Text_pronun_firstname.Text
        Panel_edit_firstname.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseMove
        Text_pronun_firstname.Visible = True
    End Sub

    Private Sub Icon_pronun_firstname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_firstname.MouseLeave
        Text_pronun_firstname.Visible = False
    End Sub

    Private Sub Icon_valid_firstname_Click(sender As Object, e As EventArgs) Handles Icon_valid_firstname.Click
        Text_pronun_firstname.Text = Text_edit_firstname.Text
        Panel_edit_firstname.Visible = False
    End Sub

    Private Sub Icon_pronun_lastname_Click(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.Click
        Text_edit_lastname.Text = Text_pronun_lastname.Text
        Panel_edit_lastname.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseMove
        Text_pronun_lastname.Visible = True
    End Sub

    Private Sub Icon_pronun_lastname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_lastname.MouseLeave
        Text_pronun_lastname.Visible = False
    End Sub

    Private Sub Icon_valid_lastname_Click(sender As Object, e As EventArgs) Handles Icon_valid_lastname.Click
        Text_pronun_lastname.Text = Text_edit_lastname.Text
        Panel_edit_lastname.Visible = False
    End Sub

    Private Sub Icon_pronun_nickname_MouseMove(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseMove
        Text_pronun_nickname.Visible = True
    End Sub

    Private Sub Icon_pronun_nickname_MouseLeave(sender As Object, e As EventArgs) Handles Icon_pronun_nickname.MouseLeave
        Text_pronun_nickname.Visible = False
    End Sub

    Private Sub Button_close_hcoloredit_Click(sender As Object, e As EventArgs) Handles Button_close_hcoloredit.Click
        Panel_edit_haircolor.Visible = False
    End Sub

    Private Sub Icon_haircolor_Click(sender As Object, e As EventArgs) Handles Icon_haircolor.Click
        Panel_edit_haircolor.Visible = True
    End Sub

    Private Sub color_1_Click(sender As Object, e As EventArgs) Handles color_1.Click
        unselectcolor()
        color_1.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 128
    End Sub

    Private Sub color_2_Click(sender As Object, e As EventArgs) Handles color_2.Click
        unselectcolor()
        color_2.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 130
    End Sub

    Private Sub color_3_Click(sender As Object, e As EventArgs) Handles color_3.Click
        unselectcolor()
        color_3.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 132
    End Sub

    Private Sub color_4_Click(sender As Object, e As EventArgs) Handles color_4.Click
        unselectcolor()
        color_4.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 134
    End Sub

    Private Sub color_5_Click(sender As Object, e As EventArgs) Handles color_5.Click
        unselectcolor()
        color_5.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 136
    End Sub

    Private Sub color_6_Click(sender As Object, e As EventArgs) Handles color_6.Click
        unselectcolor()
        color_6.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 138
    End Sub

    Private Sub color_7_Click(sender As Object, e As EventArgs) Handles color_7.Click
        unselectcolor()
        color_7.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 140
    End Sub

    Private Sub color_8_Click(sender As Object, e As EventArgs) Handles color_8.Click
        unselectcolor()
        color_8.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 142
    End Sub

    Private Sub color_9_Click(sender As Object, e As EventArgs) Handles color_9.Click
        unselectcolor()
        color_9.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 144
    End Sub

    Private Sub color_10_Click(sender As Object, e As EventArgs) Handles color_10.Click
        unselectcolor()
        color_10.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 146
    End Sub

    Private Sub color_11_Click(sender As Object, e As EventArgs) Handles color_11.Click
        unselectcolor()
        color_11.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 148
    End Sub

    Private Sub color_12_Click(sender As Object, e As EventArgs) Handles color_12.Click
        unselectcolor()
        color_12.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 150
    End Sub

    Private Sub color_13_Click(sender As Object, e As EventArgs) Handles color_13.Click
        unselectcolor()
        color_13.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 152
    End Sub

    Private Sub color_14_Click(sender As Object, e As EventArgs) Handles color_14.Click
        unselectcolor()
        color_14.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 154
    End Sub

    Private Sub color_15_Click(sender As Object, e As EventArgs) Handles color_15.Click
        unselectcolor()
        color_15.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 156
    End Sub

    Private Sub color_16_Click(sender As Object, e As EventArgs) Handles color_16.Click
        unselectcolor()
        color_16.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 158
    End Sub

    Private Sub color_17_Click(sender As Object, e As EventArgs) Handles color_17.Click
        unselectcolor()
        color_17.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 160
    End Sub

    Private Sub color_18_Click(sender As Object, e As EventArgs) Handles color_18.Click
        unselectcolor()
        color_18.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 162
    End Sub

    Private Sub color_19_Click(sender As Object, e As EventArgs) Handles color_19.Click
        unselectcolor()
        color_19.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 164
    End Sub

    Private Sub color_20_Click(sender As Object, e As EventArgs) Handles color_20.Click
        unselectcolor()
        color_20.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 166
    End Sub

    Private Sub color_21_Click(sender As Object, e As EventArgs) Handles color_21.Click
        unselectcolor()
        color_21.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 168
    End Sub

    Private Sub color_22_Click(sender As Object, e As EventArgs) Handles color_22.Click
        unselectcolor()
        color_22.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 170
    End Sub

    Private Sub color_23_Click(sender As Object, e As EventArgs) Handles color_23.Click
        unselectcolor()
        color_23.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 172
    End Sub

    Private Sub color_24_Click(sender As Object, e As EventArgs) Handles color_24.Click
        unselectcolor()
        color_24.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 174
    End Sub

    Private Sub color_25_Click(sender As Object, e As EventArgs) Handles color_25.Click
        unselectcolor()
        color_25.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 176
    End Sub

    Private Sub color_26_Click(sender As Object, e As EventArgs) Handles color_26.Click
        unselectcolor()
        color_26.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 178
    End Sub

    Private Sub color_27_Click(sender As Object, e As EventArgs) Handles color_27.Click
        unselectcolor()
        color_27.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 180
    End Sub

    Private Sub color_28_Click(sender As Object, e As EventArgs) Handles color_28.Click
        unselectcolor()
        color_28.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 182
    End Sub

    Private Sub color_29_Click(sender As Object, e As EventArgs) Handles color_29.Click
        unselectcolor()
        color_29.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 184
    End Sub

    Private Sub color_30_Click(sender As Object, e As EventArgs) Handles color_30.Click
        unselectcolor()
        color_30.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 186
    End Sub

    Private Sub color_31_Click(sender As Object, e As EventArgs) Handles color_31.Click
        unselectcolor()
        color_31.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 188
    End Sub

    Private Sub color_32_Click(sender As Object, e As EventArgs) Handles color_32.Click
        unselectcolor()
        color_32.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 190
    End Sub

    Private Sub color_empty_Click(sender As Object, e As EventArgs) Handles color_empty.Click
        unselectcolor()
        color_empty.BorderStyle = BorderStyle.FixedSingle
        valu_haircolor.Value = 1
    End Sub

    Private Sub valu_haircolor_ValueChanged(sender As Object, e As EventArgs) Handles valu_haircolor.ValueChanged
        Select Case valu_haircolor.Value
            Case 128, 129
                Icon_haircolor.Image = My.Resources.HC80
            Case 130, 131
                Icon_haircolor.Image = My.Resources.HC82
            Case 132, 133
                Icon_haircolor.Image = My.Resources.HC84
            Case 134, 135
                Icon_haircolor.Image = My.Resources.HC86
            Case 136, 137
                Icon_haircolor.Image = My.Resources.HC88
            Case 138, 139
                Icon_haircolor.Image = My.Resources.HC8A
            Case 140, 141
                Icon_haircolor.Image = My.Resources.HC8C
            Case 142, 143
                Icon_haircolor.Image = My.Resources.HC8E
            Case 144, 145
                Icon_haircolor.Image = My.Resources.HC90
            Case 146, 147
                Icon_haircolor.Image = My.Resources.HC92
            Case 148, 149
                Icon_haircolor.Image = My.Resources.HC94
            Case 150, 151
                Icon_haircolor.Image = My.Resources.HC96
            Case 152, 153
                Icon_haircolor.Image = My.Resources.HC98
            Case 154, 155
                Icon_haircolor.Image = My.Resources.HC9A
            Case 156, 157
                Icon_haircolor.Image = My.Resources.HC9C
            Case 158, 159
                Icon_haircolor.Image = My.Resources.HC9E
            Case 160, 161
                Icon_haircolor.Image = My.Resources.HCA0
            Case 162, 163
                Icon_haircolor.Image = My.Resources.HCA2
            Case 164, 165
                Icon_haircolor.Image = My.Resources.HCA4
            Case 166, 167
                Icon_haircolor.Image = My.Resources.HCA6
            Case 168, 169
                Icon_haircolor.Image = My.Resources.HCA8
            Case 170, 171
                Icon_haircolor.Image = My.Resources.HCAA
            Case 172, 173
                Icon_haircolor.Image = My.Resources.HCAC
            Case 174, 175
                Icon_haircolor.Image = My.Resources.HCAE
            Case 176, 177
                Icon_haircolor.Image = My.Resources.HCB0
            Case 178, 179
                Icon_haircolor.Image = My.Resources.HCB2
            Case 180, 181
                Icon_haircolor.Image = My.Resources.HCB4
            Case 182, 183
                Icon_haircolor.Image = My.Resources.HCB6
            Case 184, 185
                Icon_haircolor.Image = My.Resources.HCB8
            Case 186, 187
                Icon_haircolor.Image = My.Resources.HCBA
            Case 188, 189
                Icon_haircolor.Image = My.Resources.HCBC
            Case 190, 191
                Icon_haircolor.Image = My.Resources.HCBE
            Case Else
                Icon_haircolor.Image = My.Resources.HCdefault
        End Select
    End Sub

    Private Sub Icon_fullness_Click(sender As Object, e As EventArgs) Handles Icon_fullness.Click
        Panel_edit_fullness.Visible = True
    End Sub

    Private Sub Icon_edit_full_00_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_00.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 0
    End Sub

    Private Sub Icon_edit_full_25_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_25.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 25
    End Sub

    Private Sub Icon_edit_full_50_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_50.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 50
    End Sub

    Private Sub Icon_edit_full_100_Click(sender As Object, e As EventArgs) Handles Icon_edit_full_100.Click
        Panel_edit_fullness.Visible = False
        valu_fullness.Value = 100
    End Sub

    Private Sub valu_fullness_ValueChanged(sender As Object, e As EventArgs) Handles valu_fullness.ValueChanged
        If valu_fullness.Value = 0 Then
            Icon_fullness.Image = My.Resources.fullness_00
        ElseIf valu_fullness.Value = 25 Then
            Icon_fullness.Image = My.Resources.fullness_25
        ElseIf valu_fullness.Value = 50 Then
            Icon_fullness.Image = My.Resources.fullness_50
        ElseIf valu_fullness.Value = 100 Then
            Icon_fullness.Image = My.Resources.fullness_100
        End If
    End Sub

    Private Sub Text_menu_open_Click(sender As Object, e As EventArgs) Handles Text_menu_open.Click
        Dim open As New OpenFileDialog
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            fdialog.Text_fdialog.Text = "Open savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor will make a backup of your save file, check ''bak'' folder" & vbNewLine & vbNewLine & "Make sure you have choose right save file version"
            fdialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            fdialog.Text_fdialog.Text = "Ouvrir savedataArc.txt" & vbNewLine & "Tomodachi Life Save Editor va faire une copie de votre sauvegarde, vérifiez le dossier ''bak''" & vbNewLine & vbNewLine & "Soyez sûr d'avoir choisi la bonne version de sauvegarde"
            fdialog.ShowDialog()
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            open.Filter = "Text files|*.txt"
            open.Title = "Open save savedataArc.txt"
        End If
        If Select_language.SelectedItem = Select_language.Items.Item(1) Then
            open.Filter = "Fichiers texte|*.txt"
            open.Title = "Ouvrir la sauvegarde savedataArc.txt"
        End If
        open.ShowDialog()
        savedataArc = open.FileName
        TextBox_fpath.Text = savedataArc
        readsavedataArc()
        makebak()
    End Sub

    Private Sub valu_experience_ValueChanged(sender As Object, e As EventArgs) Handles valu_experience.ValueChanged
        valu_exp.Value = valu_experience.Value
        If valu_experience.Value = 0 Then
            Icon_experience.Image = My.Resources.exp0
        End If
        If valu_experience.Value = 1 Then
            Icon_experience.Image = My.Resources.exp1
        End If
        If valu_experience.Value = 2 Then
            Icon_experience.Image = My.Resources.exp2
        End If
        If valu_experience.Value = 3 Then
            Icon_experience.Image = My.Resources.exp3
        End If
        If valu_experience.Value = 4 Then
            Icon_experience.Image = My.Resources.exp4
        End If
        If valu_experience.Value = 5 Then
            Icon_experience.Image = My.Resources.exp5
        End If
        If valu_experience.Value = 6 Then
            Icon_experience.Image = My.Resources.exp6
        End If
        If valu_experience.Value = 7 Then
            Icon_experience.Image = My.Resources.exp7
        End If
        If valu_experience.Value = 8 Then
            Icon_experience.Image = My.Resources.exp8
        End If
        If valu_experience.Value = 9 Then
            Icon_experience.Image = My.Resources.exp9
        End If
        If valu_experience.Value = 10 Then
            Icon_experience.Image = My.Resources.exp10
        End If
        If valu_experience.Value = 11 Then
            Icon_experience.Image = My.Resources.exp11
        End If
        If valu_experience.Value = 12 Then
            Icon_experience.Image = My.Resources.exp12
        End If
        If valu_experience.Value = 13 Then
            Icon_experience.Image = My.Resources.exp13
        End If
        If valu_experience.Value = 14 Then
            Icon_experience.Image = My.Resources.exp14
        End If
        If valu_experience.Value = 15 Then
            Icon_experience.Image = My.Resources.exp15
        End If
        If valu_experience.Value = 16 Then
            Icon_experience.Image = My.Resources.exp16
        End If
        If valu_experience.Value = 17 Then
            Icon_experience.Image = My.Resources.exp17
        End If
        If valu_experience.Value = 18 Then
            Icon_experience.Image = My.Resources.exp18
        End If
        If valu_experience.Value = 19 Then
            Icon_experience.Image = My.Resources.exp19
        End If
        If valu_experience.Value = 20 Then
            Icon_experience.Image = My.Resources.exp20
        End If
        If valu_experience.Value = 21 Then
            Icon_experience.Image = My.Resources.exp21
        End If
        If valu_experience.Value = 22 Then
            Icon_experience.Image = My.Resources.exp22
        End If
        If valu_experience.Value = 23 Then
            Icon_experience.Image = My.Resources.exp23
        End If
        If valu_experience.Value = 24 Then
            Icon_experience.Image = My.Resources.exp24
        End If
        If valu_experience.Value = 25 Then
            Icon_experience.Image = My.Resources.exp25
        End If
        If valu_experience.Value = 26 Then
            Icon_experience.Image = My.Resources.exp26
        End If
        If valu_experience.Value = 27 Then
            Icon_experience.Image = My.Resources.exp27
        End If
        If valu_experience.Value = 28 Then
            Icon_experience.Image = My.Resources.exp28
        End If
        If valu_experience.Value = 29 Then
            Icon_experience.Image = My.Resources.exp29
        End If
        If valu_experience.Value = 30 Then
            Icon_experience.Image = My.Resources.exp30
        End If
        If valu_experience.Value = 31 Then
            Icon_experience.Image = My.Resources.exp31
        End If
        If valu_experience.Value = 32 Then
            Icon_experience.Image = My.Resources.exp32
        End If
        If valu_experience.Value = 33 Then
            Icon_experience.Image = My.Resources.exp33
        End If
        If valu_experience.Value = 34 Then
            Icon_experience.Image = My.Resources.exp34
        End If
        If valu_experience.Value = 35 Then
            Icon_experience.Image = My.Resources.exp35
        End If
        If valu_experience.Value = 36 Then
            Icon_experience.Image = My.Resources.exp36
        End If
        If valu_experience.Value = 37 Then
            Icon_experience.Image = My.Resources.exp37
        End If
        If valu_experience.Value = 38 Then
            Icon_experience.Image = My.Resources.exp38
        End If
        If valu_experience.Value = 39 Then
            Icon_experience.Image = My.Resources.exp39
        End If
        If valu_experience.Value = 40 Then
            Icon_experience.Image = My.Resources.exp40
        End If
        If valu_experience.Value = 41 Then
            Icon_experience.Image = My.Resources.exp41
        End If
        If valu_experience.Value = 42 Then
            Icon_experience.Image = My.Resources.exp42
        End If
        If valu_experience.Value = 43 Then
            Icon_experience.Image = My.Resources.exp43
        End If
        If valu_experience.Value = 44 Then
            Icon_experience.Image = My.Resources.exp44
        End If
        If valu_experience.Value = 45 Then
            Icon_experience.Image = My.Resources.exp45
        End If
        If valu_experience.Value = 46 Then
            Icon_experience.Image = My.Resources.exp46
        End If
        If valu_experience.Value = 47 Then
            Icon_experience.Image = My.Resources.exp47
        End If
        If valu_experience.Value = 48 Then
            Icon_experience.Image = My.Resources.exp48
        End If
        If valu_experience.Value = 49 Then
            Icon_experience.Image = My.Resources.exp49
        End If
        If valu_experience.Value = 50 Then
            Icon_experience.Image = My.Resources.exp50
        End If
        If valu_experience.Value = 51 Then
            Icon_experience.Image = My.Resources.exp51
        End If
        If valu_experience.Value = 52 Then
            Icon_experience.Image = My.Resources.exp52
        End If
        If valu_experience.Value = 53 Then
            Icon_experience.Image = My.Resources.exp53
        End If
        If valu_experience.Value = 54 Then
            Icon_experience.Image = My.Resources.exp54
        End If
        If valu_experience.Value = 55 Then
            Icon_experience.Image = My.Resources.exp55
        End If
        If valu_experience.Value = 56 Then
            Icon_experience.Image = My.Resources.exp56
        End If
        If valu_experience.Value = 57 Then
            Icon_experience.Image = My.Resources.exp57
        End If
        If valu_experience.Value = 58 Then
            Icon_experience.Image = My.Resources.exp58
        End If
        If valu_experience.Value = 59 Then
            Icon_experience.Image = My.Resources.exp59
        End If
        If valu_experience.Value = 60 Then
            Icon_experience.Image = My.Resources.exp60
        End If
        If valu_experience.Value = 61 Then
            Icon_experience.Image = My.Resources.exp61
        End If
        If valu_experience.Value = 62 Then
            Icon_experience.Image = My.Resources.exp62
        End If
        If valu_experience.Value = 63 Then
            Icon_experience.Image = My.Resources.exp63
        End If
        If valu_experience.Value = 64 Then
            Icon_experience.Image = My.Resources.exp64
        End If
        If valu_experience.Value = 65 Then
            Icon_experience.Image = My.Resources.exp65
        End If
        If valu_experience.Value = 66 Then
            Icon_experience.Image = My.Resources.exp66
        End If
        If valu_experience.Value = 67 Then
            Icon_experience.Image = My.Resources.exp67
        End If
        If valu_experience.Value = 68 Then
            Icon_experience.Image = My.Resources.exp68
        End If
        If valu_experience.Value = 69 Then
            Icon_experience.Image = My.Resources.exp69
        End If
        If valu_experience.Value = 70 Then
            Icon_experience.Image = My.Resources.exp70
        End If
        If valu_experience.Value = 71 Then
            Icon_experience.Image = My.Resources.exp71
        End If
        If valu_experience.Value = 72 Then
            Icon_experience.Image = My.Resources.exp72
        End If
        If valu_experience.Value = 73 Then
            Icon_experience.Image = My.Resources.exp73
        End If
        If valu_experience.Value = 74 Then
            Icon_experience.Image = My.Resources.exp74
        End If
        If valu_experience.Value = 75 Then
            Icon_experience.Image = My.Resources.exp75
        End If
        If valu_experience.Value = 76 Then
            Icon_experience.Image = My.Resources.exp76
        End If
        If valu_experience.Value = 77 Then
            Icon_experience.Image = My.Resources.exp77
        End If
        If valu_experience.Value = 78 Then
            Icon_experience.Image = My.Resources.exp78
        End If
        If valu_experience.Value = 79 Then
            Icon_experience.Image = My.Resources.exp79
        End If
        If valu_experience.Value = 80 Then
            Icon_experience.Image = My.Resources.exp80
        End If
        If valu_experience.Value = 81 Then
            Icon_experience.Image = My.Resources.exp81
        End If
        If valu_experience.Value = 82 Then
            Icon_experience.Image = My.Resources.exp82
        End If
        If valu_experience.Value = 83 Then
            Icon_experience.Image = My.Resources.exp83
        End If
        If valu_experience.Value = 84 Then
            Icon_experience.Image = My.Resources.exp84
        End If
        If valu_experience.Value = 85 Then
            Icon_experience.Image = My.Resources.exp85
        End If
        If valu_experience.Value = 86 Then
            Icon_experience.Image = My.Resources.exp86
        End If
        If valu_experience.Value = 87 Then
            Icon_experience.Image = My.Resources.exp87
        End If
        If valu_experience.Value = 88 Then
            Icon_experience.Image = My.Resources.exp88
        End If
        If valu_experience.Value = 89 Then
            Icon_experience.Image = My.Resources.exp89
        End If
        If valu_experience.Value = 90 Then
            Icon_experience.Image = My.Resources.exp90
        End If
        If valu_experience.Value = 91 Then
            Icon_experience.Image = My.Resources.exp91
        End If
        If valu_experience.Value = 92 Then
            Icon_experience.Image = My.Resources.exp92
        End If
        If valu_experience.Value = 93 Then
            Icon_experience.Image = My.Resources.exp93
        End If
        If valu_experience.Value = 94 Then
            Icon_experience.Image = My.Resources.exp94
        End If
        If valu_experience.Value = 95 Then
            Icon_experience.Image = My.Resources.exp95
        End If
        If valu_experience.Value = 96 Then
            Icon_experience.Image = My.Resources.exp96
        End If
        If valu_experience.Value = 97 Then
            Icon_experience.Image = My.Resources.exp97
        End If
        If valu_experience.Value = 98 Then
            Icon_experience.Image = My.Resources.exp98
        End If
        If valu_experience.Value = 99 Then
            Icon_experience.Image = My.Resources.exp99
        End If
    End Sub

    Private Sub valu_exp_ValueChanged(sender As Object, e As EventArgs) Handles valu_exp.ValueChanged
        valu_experience.Value = valu_exp.Value
    End Sub

    Private Sub Fea_edit_travelers_Click(sender As Object, e As EventArgs) Handles Fea_edit_travelers.Click

    End Sub

    Private Sub Fea_edit_travelers_MouseLeave(sender As Object, e As EventArgs) Handles Fea_edit_travelers.MouseLeave
        Fea_edit_travelers.BackColor = Color.White
    End Sub

    Private Sub Fea_edit_travelers_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_edit_travelers.MouseMove
        Fea_edit_travelers.BackColor = Color.Orange
    End Sub

    Private Sub Fea_edit_concert_Click(sender As Object, e As EventArgs) Handles Fea_edit_concert.Click

    End Sub

    Private Sub Fea_edit_concert_MouseLeave(sender As Object, e As EventArgs) Handles Fea_edit_concert.MouseLeave
        Fea_edit_concert.BackColor = Color.White
    End Sub

    Private Sub Fea_edit_concert_MouseMove(sender As Object, e As MouseEventArgs) Handles Fea_edit_concert.MouseMove
        Fea_edit_concert.BackColor = Color.Orange
    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        writesavedataArc()
    End Sub

    Private Sub Button_setallfriends_Click(sender As Object, e As EventArgs) Handles Button_setallfriends.Click
        valu_friend_rela_1.Value = valu_setallfriends.Value
        valu_friend_rela_2.Value = valu_setallfriends.Value
        valu_friend_rela_3.Value = valu_setallfriends.Value
        valu_friend_rela_4.Value = valu_setallfriends.Value
        valu_friend_rela_5.Value = valu_setallfriends.Value
        valu_friend_rela_6.Value = valu_setallfriends.Value
        valu_friend_rela_7.Value = valu_setallfriends.Value
        valu_friend_rela_8.Value = valu_setallfriends.Value
        valu_friend_rela_9.Value = valu_setallfriends.Value
        valu_friend_rela_10.Value = valu_setallfriends.Value
        valu_friend_rela_11.Value = valu_setallfriends.Value
        valu_friend_rela_12.Value = valu_setallfriends.Value
        valu_friend_rela_13.Value = valu_setallfriends.Value
        valu_friend_rela_14.Value = valu_setallfriends.Value
        valu_friend_rela_15.Value = valu_setallfriends.Value
        valu_friend_rela_16.Value = valu_setallfriends.Value
        valu_friend_rela_17.Value = valu_setallfriends.Value
        valu_friend_rela_18.Value = valu_setallfriends.Value
        valu_friend_rela_19.Value = valu_setallfriends.Value
        valu_friend_rela_20.Value = valu_setallfriends.Value
        valu_friend_rela_21.Value = valu_setallfriends.Value
        valu_friend_rela_22.Value = valu_setallfriends.Value
        valu_friend_rela_23.Value = valu_setallfriends.Value
        valu_friend_rela_24.Value = valu_setallfriends.Value
        valu_friend_rela_25.Value = valu_setallfriends.Value
        valu_friend_rela_26.Value = valu_setallfriends.Value
        valu_friend_rela_27.Value = valu_setallfriends.Value
        valu_friend_rela_28.Value = valu_setallfriends.Value
        valu_friend_rela_29.Value = valu_setallfriends.Value
        valu_friend_rela_30.Value = valu_setallfriends.Value
    End Sub

    Private Sub Check_fullness_CheckedChanged(sender As Object, e As EventArgs) Handles Check_fullness.CheckedChanged
        valu_fullness.Value = 0
        valu_chkfullness.value = 0
    End Sub

    Private Sub valu_chkfullness_ValueChanged(sender As Object, e As EventArgs) Handles valu_chkfullness.ValueChanged
        If valu_chkfullness.Value > 0 Then
            Check_fullness.Checked = False
        End If
    End Sub

    Private Sub Icon_itemmii_1_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_1.Click
        If valu_itemmii_1.Value > 26 And valu_itemmii_1.Value < 65535 Then
            valu_itemmii_1.Value = 65535
        ElseIf valu_itemmii_1.Value = 65535 Then
            valu_itemmii_1.Value = 0
        Else
            valu_itemmii_1.Value = valu_itemmii_1.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_2_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_2.Click
        If valu_itemmii_2.Value > 26 And valu_itemmii_2.Value < 65535 Then
            valu_itemmii_2.Value = 65535
        ElseIf valu_itemmii_2.Value = 65535 Then
            valu_itemmii_2.Value = 0
        Else
            valu_itemmii_2.Value = valu_itemmii_2.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_3_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_3.Click
        If valu_itemmii_3.Value > 26 And valu_itemmii_3.Value < 65535 Then
            valu_itemmii_3.Value = 65535
        ElseIf valu_itemmii_3.Value = 65535 Then
            valu_itemmii_3.Value = 0
        Else
            valu_itemmii_3.Value = valu_itemmii_3.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_4_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_4.Click
        If valu_itemmii_4.Value > 26 And valu_itemmii_4.Value < 65535 Then
            valu_itemmii_4.Value = 65535
        ElseIf valu_itemmii_4.Value = 65535 Then
            valu_itemmii_4.Value = 0
        Else
            valu_itemmii_4.Value = valu_itemmii_4.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_5_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_5.Click
        If valu_itemmii_5.Value > 26 And valu_itemmii_5.Value < 65535 Then
            valu_itemmii_5.Value = 65535
        ElseIf valu_itemmii_5.Value = 65535 Then
            valu_itemmii_5.Value = 0
        Else
            valu_itemmii_5.Value = valu_itemmii_5.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_6_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_6.Click
        If valu_itemmii_6.Value > 26 And valu_itemmii_6.Value < 65535 Then
            valu_itemmii_6.Value = 65535
        ElseIf valu_itemmii_6.Value = 65535 Then
            valu_itemmii_6.Value = 0
        Else
            valu_itemmii_6.Value = valu_itemmii_6.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_7_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_7.Click
        If valu_itemmii_7.Value > 26 And valu_itemmii_7.Value < 65535 Then
            valu_itemmii_7.Value = 65535
        ElseIf valu_itemmii_7.Value = 65535 Then
            valu_itemmii_7.Value = 0
        Else
            valu_itemmii_7.Value = valu_itemmii_7.Value + 1
        End If
    End Sub

    Private Sub Icon_itemmii_8_Click(sender As Object, e As EventArgs) Handles Icon_itemmii_8.Click
        If valu_itemmii_8.Value > 26 And valu_itemmii_8.Value < 65535 Then
            valu_itemmii_8.Value = 65535
        ElseIf valu_itemmii_8.Value = 65535 Then
            valu_itemmii_8.Value = 0
        Else
            valu_itemmii_8.Value = valu_itemmii_8.Value + 1
        End If
    End Sub

    Private Sub valu_itemmii_1_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_1.ValueChanged
        If valu_itemmii_1.Value = 65535 Then
            Icon_itemmii_1.Image = My.Resources.FFFF
        End If
        If valu_itemmii_1.Value = 0 Then
            Icon_itemmii_1.Image = My.Resources._0000
        End If
        If valu_itemmii_1.Value = 1 Then
            Icon_itemmii_1.Image = My.Resources._0100
        End If
        If valu_itemmii_1.Value = 2 Then
            Icon_itemmii_1.Image = My.Resources._0200
        End If
        If valu_itemmii_1.Value = 3 Then
            Icon_itemmii_1.Image = My.Resources._0300
        End If
        If valu_itemmii_1.Value = 4 Then
            Icon_itemmii_1.Image = My.Resources._0400
        End If
        If valu_itemmii_1.Value = 5 Then
            Icon_itemmii_1.Image = My.Resources._0500
        End If
        If valu_itemmii_1.Value = 6 Then
            Icon_itemmii_1.Image = My.Resources._0600
        End If
        If valu_itemmii_1.Value = 7 Then
            Icon_itemmii_1.Image = My.Resources._0700
        End If
        If valu_itemmii_1.Value = 8 Then
            Icon_itemmii_1.Image = My.Resources._0800
        End If
        If valu_itemmii_1.Value = 9 Then
            Icon_itemmii_1.Image = My.Resources._0900
        End If
        If valu_itemmii_1.Value = 10 Then
            Icon_itemmii_1.Image = My.Resources._0a00
        End If
        If valu_itemmii_1.Value = 11 Then
            Icon_itemmii_1.Image = My.Resources._0b00
        End If
        If valu_itemmii_1.Value = 12 Then
            Icon_itemmii_1.Image = My.Resources._0c00
        End If
        If valu_itemmii_1.Value = 13 Then
            Icon_itemmii_1.Image = My.Resources._0d00
        End If
        If valu_itemmii_1.Value = 14 Then
            Icon_itemmii_1.Image = My.Resources._0e00
        End If
        If valu_itemmii_1.Value = 15 Then
            Icon_itemmii_1.Image = My.Resources._0f00
        End If
        If valu_itemmii_1.Value = 16 Then
            Icon_itemmii_1.Image = My.Resources._1000
        End If
        If valu_itemmii_1.Value = 17 Then
            Icon_itemmii_1.Image = My.Resources._1100
        End If
        If valu_itemmii_1.Value = 18 Then
            Icon_itemmii_1.Image = My.Resources._1200
        End If
        If valu_itemmii_1.Value = 19 Then
            Icon_itemmii_1.Image = My.Resources._1300
        End If
        If valu_itemmii_1.Value = 20 Then
            Icon_itemmii_1.Image = My.Resources._1400
        End If
        If valu_itemmii_1.Value = 21 Then
            Icon_itemmii_1.Image = My.Resources._1500
        End If
        If valu_itemmii_1.Value = 22 Then
            Icon_itemmii_1.Image = My.Resources._1600
        End If
        If valu_itemmii_1.Value = 23 Then
            Icon_itemmii_1.Image = My.Resources._1700
        End If
        If valu_itemmii_1.Value = 24 Then
            Icon_itemmii_1.Image = My.Resources._1800
        End If
        If valu_itemmii_1.Value = 25 Then
            Icon_itemmii_1.Image = My.Resources._1900
        End If
        If valu_itemmii_1.Value = 26 Then
            Icon_itemmii_1.Image = My.Resources._1a00
        End If
        If valu_itemmii_1.Value = 27 Then
            Icon_itemmii_1.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_2_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_2.ValueChanged
        If valu_itemmii_2.Value = 65535 Then
            Icon_itemmii_2.Image = My.Resources.FFFF
        End If
        If valu_itemmii_2.Value = 0 Then
            Icon_itemmii_2.Image = My.Resources._0000
        End If
        If valu_itemmii_2.Value = 1 Then
            Icon_itemmii_2.Image = My.Resources._0100
        End If
        If valu_itemmii_2.Value = 2 Then
            Icon_itemmii_2.Image = My.Resources._0200
        End If
        If valu_itemmii_2.Value = 3 Then
            Icon_itemmii_2.Image = My.Resources._0300
        End If
        If valu_itemmii_2.Value = 4 Then
            Icon_itemmii_2.Image = My.Resources._0400
        End If
        If valu_itemmii_2.Value = 5 Then
            Icon_itemmii_2.Image = My.Resources._0500
        End If
        If valu_itemmii_2.Value = 6 Then
            Icon_itemmii_2.Image = My.Resources._0600
        End If
        If valu_itemmii_2.Value = 7 Then
            Icon_itemmii_2.Image = My.Resources._0700
        End If
        If valu_itemmii_2.Value = 8 Then
            Icon_itemmii_2.Image = My.Resources._0800
        End If
        If valu_itemmii_2.Value = 9 Then
            Icon_itemmii_2.Image = My.Resources._0900
        End If
        If valu_itemmii_2.Value = 10 Then
            Icon_itemmii_2.Image = My.Resources._0a00
        End If
        If valu_itemmii_2.Value = 11 Then
            Icon_itemmii_2.Image = My.Resources._0b00
        End If
        If valu_itemmii_2.Value = 12 Then
            Icon_itemmii_2.Image = My.Resources._0c00
        End If
        If valu_itemmii_2.Value = 13 Then
            Icon_itemmii_2.Image = My.Resources._0d00
        End If
        If valu_itemmii_2.Value = 14 Then
            Icon_itemmii_2.Image = My.Resources._0e00
        End If
        If valu_itemmii_2.Value = 15 Then
            Icon_itemmii_2.Image = My.Resources._0f00
        End If
        If valu_itemmii_2.Value = 16 Then
            Icon_itemmii_2.Image = My.Resources._1000
        End If
        If valu_itemmii_2.Value = 17 Then
            Icon_itemmii_2.Image = My.Resources._1100
        End If
        If valu_itemmii_2.Value = 18 Then
            Icon_itemmii_2.Image = My.Resources._1200
        End If
        If valu_itemmii_2.Value = 19 Then
            Icon_itemmii_2.Image = My.Resources._1300
        End If
        If valu_itemmii_2.Value = 20 Then
            Icon_itemmii_2.Image = My.Resources._1400
        End If
        If valu_itemmii_2.Value = 21 Then
            Icon_itemmii_2.Image = My.Resources._1500
        End If
        If valu_itemmii_2.Value = 22 Then
            Icon_itemmii_2.Image = My.Resources._1600
        End If
        If valu_itemmii_2.Value = 23 Then
            Icon_itemmii_2.Image = My.Resources._1700
        End If
        If valu_itemmii_2.Value = 24 Then
            Icon_itemmii_2.Image = My.Resources._1800
        End If
        If valu_itemmii_2.Value = 25 Then
            Icon_itemmii_2.Image = My.Resources._1900
        End If
        If valu_itemmii_2.Value = 26 Then
            Icon_itemmii_2.Image = My.Resources._1a00
        End If
        If valu_itemmii_2.Value = 27 Then
            Icon_itemmii_2.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_3_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_3.ValueChanged
        If valu_itemmii_3.Value = 65535 Then
            Icon_itemmii_3.Image = My.Resources.FFFF
        End If
        If valu_itemmii_3.Value = 0 Then
            Icon_itemmii_3.Image = My.Resources._0000
        End If
        If valu_itemmii_3.Value = 1 Then
            Icon_itemmii_3.Image = My.Resources._0100
        End If
        If valu_itemmii_3.Value = 2 Then
            Icon_itemmii_3.Image = My.Resources._0200
        End If
        If valu_itemmii_3.Value = 3 Then
            Icon_itemmii_3.Image = My.Resources._0300
        End If
        If valu_itemmii_3.Value = 4 Then
            Icon_itemmii_3.Image = My.Resources._0400
        End If
        If valu_itemmii_3.Value = 5 Then
            Icon_itemmii_3.Image = My.Resources._0500
        End If
        If valu_itemmii_3.Value = 6 Then
            Icon_itemmii_3.Image = My.Resources._0600
        End If
        If valu_itemmii_3.Value = 7 Then
            Icon_itemmii_3.Image = My.Resources._0700
        End If
        If valu_itemmii_3.Value = 8 Then
            Icon_itemmii_3.Image = My.Resources._0800
        End If
        If valu_itemmii_3.Value = 9 Then
            Icon_itemmii_3.Image = My.Resources._0900
        End If
        If valu_itemmii_3.Value = 10 Then
            Icon_itemmii_3.Image = My.Resources._0a00
        End If
        If valu_itemmii_3.Value = 11 Then
            Icon_itemmii_3.Image = My.Resources._0b00
        End If
        If valu_itemmii_3.Value = 12 Then
            Icon_itemmii_3.Image = My.Resources._0c00
        End If
        If valu_itemmii_3.Value = 13 Then
            Icon_itemmii_3.Image = My.Resources._0d00
        End If
        If valu_itemmii_3.Value = 14 Then
            Icon_itemmii_3.Image = My.Resources._0e00
        End If
        If valu_itemmii_3.Value = 15 Then
            Icon_itemmii_3.Image = My.Resources._0f00
        End If
        If valu_itemmii_3.Value = 16 Then
            Icon_itemmii_3.Image = My.Resources._1000
        End If
        If valu_itemmii_3.Value = 17 Then
            Icon_itemmii_3.Image = My.Resources._1100
        End If
        If valu_itemmii_3.Value = 18 Then
            Icon_itemmii_3.Image = My.Resources._1200
        End If
        If valu_itemmii_3.Value = 19 Then
            Icon_itemmii_3.Image = My.Resources._1300
        End If
        If valu_itemmii_3.Value = 20 Then
            Icon_itemmii_3.Image = My.Resources._1400
        End If
        If valu_itemmii_3.Value = 21 Then
            Icon_itemmii_3.Image = My.Resources._1500
        End If
        If valu_itemmii_3.Value = 22 Then
            Icon_itemmii_3.Image = My.Resources._1600
        End If
        If valu_itemmii_3.Value = 23 Then
            Icon_itemmii_3.Image = My.Resources._1700
        End If
        If valu_itemmii_3.Value = 24 Then
            Icon_itemmii_3.Image = My.Resources._1800
        End If
        If valu_itemmii_3.Value = 25 Then
            Icon_itemmii_3.Image = My.Resources._1900
        End If
        If valu_itemmii_3.Value = 26 Then
            Icon_itemmii_3.Image = My.Resources._1a00
        End If
        If valu_itemmii_3.Value = 27 Then
            Icon_itemmii_3.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_4_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_4.ValueChanged
        If valu_itemmii_4.Value = 65535 Then
            Icon_itemmii_4.Image = My.Resources.FFFF
        End If
        If valu_itemmii_4.Value = 0 Then
            Icon_itemmii_4.Image = My.Resources._0000
        End If
        If valu_itemmii_4.Value = 1 Then
            Icon_itemmii_4.Image = My.Resources._0100
        End If
        If valu_itemmii_4.Value = 2 Then
            Icon_itemmii_4.Image = My.Resources._0200
        End If
        If valu_itemmii_4.Value = 3 Then
            Icon_itemmii_4.Image = My.Resources._0300
        End If
        If valu_itemmii_4.Value = 4 Then
            Icon_itemmii_4.Image = My.Resources._0400
        End If
        If valu_itemmii_4.Value = 5 Then
            Icon_itemmii_4.Image = My.Resources._0500
        End If
        If valu_itemmii_4.Value = 6 Then
            Icon_itemmii_4.Image = My.Resources._0600
        End If
        If valu_itemmii_4.Value = 7 Then
            Icon_itemmii_4.Image = My.Resources._0700
        End If
        If valu_itemmii_4.Value = 8 Then
            Icon_itemmii_4.Image = My.Resources._0800
        End If
        If valu_itemmii_4.Value = 9 Then
            Icon_itemmii_4.Image = My.Resources._0900
        End If
        If valu_itemmii_4.Value = 10 Then
            Icon_itemmii_4.Image = My.Resources._0a00
        End If
        If valu_itemmii_4.Value = 11 Then
            Icon_itemmii_4.Image = My.Resources._0b00
        End If
        If valu_itemmii_4.Value = 12 Then
            Icon_itemmii_4.Image = My.Resources._0c00
        End If
        If valu_itemmii_4.Value = 13 Then
            Icon_itemmii_4.Image = My.Resources._0d00
        End If
        If valu_itemmii_4.Value = 14 Then
            Icon_itemmii_4.Image = My.Resources._0e00
        End If
        If valu_itemmii_4.Value = 15 Then
            Icon_itemmii_4.Image = My.Resources._0f00
        End If
        If valu_itemmii_4.Value = 16 Then
            Icon_itemmii_4.Image = My.Resources._1000
        End If
        If valu_itemmii_4.Value = 17 Then
            Icon_itemmii_4.Image = My.Resources._1100
        End If
        If valu_itemmii_4.Value = 18 Then
            Icon_itemmii_4.Image = My.Resources._1200
        End If
        If valu_itemmii_4.Value = 19 Then
            Icon_itemmii_4.Image = My.Resources._1300
        End If
        If valu_itemmii_4.Value = 20 Then
            Icon_itemmii_4.Image = My.Resources._1400
        End If
        If valu_itemmii_4.Value = 21 Then
            Icon_itemmii_4.Image = My.Resources._1500
        End If
        If valu_itemmii_4.Value = 22 Then
            Icon_itemmii_4.Image = My.Resources._1600
        End If
        If valu_itemmii_4.Value = 23 Then
            Icon_itemmii_4.Image = My.Resources._1700
        End If
        If valu_itemmii_4.Value = 24 Then
            Icon_itemmii_4.Image = My.Resources._1800
        End If
        If valu_itemmii_4.Value = 25 Then
            Icon_itemmii_4.Image = My.Resources._1900
        End If
        If valu_itemmii_4.Value = 26 Then
            Icon_itemmii_4.Image = My.Resources._1a00
        End If
        If valu_itemmii_4.Value = 27 Then
            Icon_itemmii_4.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_5_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_5.ValueChanged
        If valu_itemmii_5.Value = 65535 Then
            Icon_itemmii_5.Image = My.Resources.FFFF
        End If
        If valu_itemmii_5.Value = 0 Then
            Icon_itemmii_5.Image = My.Resources._0000
        End If
        If valu_itemmii_5.Value = 1 Then
            Icon_itemmii_5.Image = My.Resources._0100
        End If
        If valu_itemmii_5.Value = 2 Then
            Icon_itemmii_5.Image = My.Resources._0200
        End If
        If valu_itemmii_5.Value = 3 Then
            Icon_itemmii_5.Image = My.Resources._0300
        End If
        If valu_itemmii_5.Value = 4 Then
            Icon_itemmii_5.Image = My.Resources._0400
        End If
        If valu_itemmii_5.Value = 5 Then
            Icon_itemmii_5.Image = My.Resources._0500
        End If
        If valu_itemmii_5.Value = 6 Then
            Icon_itemmii_5.Image = My.Resources._0600
        End If
        If valu_itemmii_5.Value = 7 Then
            Icon_itemmii_5.Image = My.Resources._0700
        End If
        If valu_itemmii_5.Value = 8 Then
            Icon_itemmii_5.Image = My.Resources._0800
        End If
        If valu_itemmii_5.Value = 9 Then
            Icon_itemmii_5.Image = My.Resources._0900
        End If
        If valu_itemmii_5.Value = 10 Then
            Icon_itemmii_5.Image = My.Resources._0a00
        End If
        If valu_itemmii_5.Value = 11 Then
            Icon_itemmii_5.Image = My.Resources._0b00
        End If
        If valu_itemmii_5.Value = 12 Then
            Icon_itemmii_5.Image = My.Resources._0c00
        End If
        If valu_itemmii_5.Value = 13 Then
            Icon_itemmii_5.Image = My.Resources._0d00
        End If
        If valu_itemmii_5.Value = 14 Then
            Icon_itemmii_5.Image = My.Resources._0e00
        End If
        If valu_itemmii_5.Value = 15 Then
            Icon_itemmii_5.Image = My.Resources._0f00
        End If
        If valu_itemmii_5.Value = 16 Then
            Icon_itemmii_5.Image = My.Resources._1000
        End If
        If valu_itemmii_5.Value = 17 Then
            Icon_itemmii_5.Image = My.Resources._1100
        End If
        If valu_itemmii_5.Value = 18 Then
            Icon_itemmii_5.Image = My.Resources._1200
        End If
        If valu_itemmii_5.Value = 19 Then
            Icon_itemmii_5.Image = My.Resources._1300
        End If
        If valu_itemmii_5.Value = 20 Then
            Icon_itemmii_5.Image = My.Resources._1400
        End If
        If valu_itemmii_5.Value = 21 Then
            Icon_itemmii_5.Image = My.Resources._1500
        End If
        If valu_itemmii_5.Value = 22 Then
            Icon_itemmii_5.Image = My.Resources._1600
        End If
        If valu_itemmii_5.Value = 23 Then
            Icon_itemmii_5.Image = My.Resources._1700
        End If
        If valu_itemmii_5.Value = 24 Then
            Icon_itemmii_5.Image = My.Resources._1800
        End If
        If valu_itemmii_5.Value = 25 Then
            Icon_itemmii_5.Image = My.Resources._1900
        End If
        If valu_itemmii_5.Value = 26 Then
            Icon_itemmii_5.Image = My.Resources._1a00
        End If
        If valu_itemmii_5.Value = 27 Then
            Icon_itemmii_5.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_6_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_6.ValueChanged
        If valu_itemmii_6.Value = 65535 Then
            Icon_itemmii_6.Image = My.Resources.FFFF
        End If
        If valu_itemmii_6.Value = 0 Then
            Icon_itemmii_6.Image = My.Resources._0000
        End If
        If valu_itemmii_6.Value = 1 Then
            Icon_itemmii_6.Image = My.Resources._0100
        End If
        If valu_itemmii_6.Value = 2 Then
            Icon_itemmii_6.Image = My.Resources._0200
        End If
        If valu_itemmii_6.Value = 3 Then
            Icon_itemmii_6.Image = My.Resources._0300
        End If
        If valu_itemmii_6.Value = 4 Then
            Icon_itemmii_6.Image = My.Resources._0400
        End If
        If valu_itemmii_6.Value = 5 Then
            Icon_itemmii_6.Image = My.Resources._0500
        End If
        If valu_itemmii_6.Value = 6 Then
            Icon_itemmii_6.Image = My.Resources._0600
        End If
        If valu_itemmii_6.Value = 7 Then
            Icon_itemmii_6.Image = My.Resources._0700
        End If
        If valu_itemmii_6.Value = 8 Then
            Icon_itemmii_6.Image = My.Resources._0800
        End If
        If valu_itemmii_6.Value = 9 Then
            Icon_itemmii_6.Image = My.Resources._0900
        End If
        If valu_itemmii_6.Value = 10 Then
            Icon_itemmii_6.Image = My.Resources._0a00
        End If
        If valu_itemmii_6.Value = 11 Then
            Icon_itemmii_6.Image = My.Resources._0b00
        End If
        If valu_itemmii_6.Value = 12 Then
            Icon_itemmii_6.Image = My.Resources._0c00
        End If
        If valu_itemmii_6.Value = 13 Then
            Icon_itemmii_6.Image = My.Resources._0d00
        End If
        If valu_itemmii_6.Value = 14 Then
            Icon_itemmii_6.Image = My.Resources._0e00
        End If
        If valu_itemmii_6.Value = 15 Then
            Icon_itemmii_6.Image = My.Resources._0f00
        End If
        If valu_itemmii_6.Value = 16 Then
            Icon_itemmii_6.Image = My.Resources._1000
        End If
        If valu_itemmii_6.Value = 17 Then
            Icon_itemmii_6.Image = My.Resources._1100
        End If
        If valu_itemmii_6.Value = 18 Then
            Icon_itemmii_6.Image = My.Resources._1200
        End If
        If valu_itemmii_6.Value = 19 Then
            Icon_itemmii_6.Image = My.Resources._1300
        End If
        If valu_itemmii_6.Value = 20 Then
            Icon_itemmii_6.Image = My.Resources._1400
        End If
        If valu_itemmii_6.Value = 21 Then
            Icon_itemmii_6.Image = My.Resources._1500
        End If
        If valu_itemmii_6.Value = 22 Then
            Icon_itemmii_6.Image = My.Resources._1600
        End If
        If valu_itemmii_6.Value = 23 Then
            Icon_itemmii_6.Image = My.Resources._1700
        End If
        If valu_itemmii_6.Value = 24 Then
            Icon_itemmii_6.Image = My.Resources._1800
        End If
        If valu_itemmii_6.Value = 25 Then
            Icon_itemmii_6.Image = My.Resources._1900
        End If
        If valu_itemmii_6.Value = 26 Then
            Icon_itemmii_6.Image = My.Resources._1a00
        End If
        If valu_itemmii_6.Value = 27 Then
            Icon_itemmii_6.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_7_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_7.ValueChanged
        If valu_itemmii_7.Value = 65535 Then
            Icon_itemmii_7.Image = My.Resources.FFFF
        End If
        If valu_itemmii_7.Value = 0 Then
            Icon_itemmii_7.Image = My.Resources._0000
        End If
        If valu_itemmii_7.Value = 1 Then
            Icon_itemmii_7.Image = My.Resources._0100
        End If
        If valu_itemmii_7.Value = 2 Then
            Icon_itemmii_7.Image = My.Resources._0200
        End If
        If valu_itemmii_7.Value = 3 Then
            Icon_itemmii_7.Image = My.Resources._0300
        End If
        If valu_itemmii_7.Value = 4 Then
            Icon_itemmii_7.Image = My.Resources._0400
        End If
        If valu_itemmii_7.Value = 5 Then
            Icon_itemmii_7.Image = My.Resources._0500
        End If
        If valu_itemmii_7.Value = 6 Then
            Icon_itemmii_7.Image = My.Resources._0600
        End If
        If valu_itemmii_7.Value = 7 Then
            Icon_itemmii_7.Image = My.Resources._0700
        End If
        If valu_itemmii_7.Value = 8 Then
            Icon_itemmii_7.Image = My.Resources._0800
        End If
        If valu_itemmii_7.Value = 9 Then
            Icon_itemmii_7.Image = My.Resources._0900
        End If
        If valu_itemmii_7.Value = 10 Then
            Icon_itemmii_7.Image = My.Resources._0a00
        End If
        If valu_itemmii_7.Value = 11 Then
            Icon_itemmii_7.Image = My.Resources._0b00
        End If
        If valu_itemmii_7.Value = 12 Then
            Icon_itemmii_7.Image = My.Resources._0c00
        End If
        If valu_itemmii_7.Value = 13 Then
            Icon_itemmii_7.Image = My.Resources._0d00
        End If
        If valu_itemmii_7.Value = 14 Then
            Icon_itemmii_7.Image = My.Resources._0e00
        End If
        If valu_itemmii_7.Value = 15 Then
            Icon_itemmii_7.Image = My.Resources._0f00
        End If
        If valu_itemmii_7.Value = 16 Then
            Icon_itemmii_7.Image = My.Resources._1000
        End If
        If valu_itemmii_7.Value = 17 Then
            Icon_itemmii_7.Image = My.Resources._1100
        End If
        If valu_itemmii_7.Value = 18 Then
            Icon_itemmii_7.Image = My.Resources._1200
        End If
        If valu_itemmii_7.Value = 19 Then
            Icon_itemmii_7.Image = My.Resources._1300
        End If
        If valu_itemmii_7.Value = 20 Then
            Icon_itemmii_7.Image = My.Resources._1400
        End If
        If valu_itemmii_7.Value = 21 Then
            Icon_itemmii_7.Image = My.Resources._1500
        End If
        If valu_itemmii_7.Value = 22 Then
            Icon_itemmii_7.Image = My.Resources._1600
        End If
        If valu_itemmii_7.Value = 23 Then
            Icon_itemmii_7.Image = My.Resources._1700
        End If
        If valu_itemmii_7.Value = 24 Then
            Icon_itemmii_7.Image = My.Resources._1800
        End If
        If valu_itemmii_7.Value = 25 Then
            Icon_itemmii_7.Image = My.Resources._1900
        End If
        If valu_itemmii_7.Value = 26 Then
            Icon_itemmii_7.Image = My.Resources._1a00
        End If
        If valu_itemmii_7.Value = 27 Then
            Icon_itemmii_7.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub valu_itemmii_8_ValueChanged(sender As Object, e As EventArgs) Handles valu_itemmii_8.ValueChanged
        If valu_itemmii_8.Value = 65535 Then
            Icon_itemmii_8.Image = My.Resources.FFFF
        End If
        If valu_itemmii_8.Value = 0 Then
            Icon_itemmii_8.Image = My.Resources._0000
        End If
        If valu_itemmii_8.Value = 1 Then
            Icon_itemmii_8.Image = My.Resources._0100
        End If
        If valu_itemmii_8.Value = 2 Then
            Icon_itemmii_8.Image = My.Resources._0200
        End If
        If valu_itemmii_8.Value = 3 Then
            Icon_itemmii_8.Image = My.Resources._0300
        End If
        If valu_itemmii_8.Value = 4 Then
            Icon_itemmii_8.Image = My.Resources._0400
        End If
        If valu_itemmii_8.Value = 5 Then
            Icon_itemmii_8.Image = My.Resources._0500
        End If
        If valu_itemmii_8.Value = 6 Then
            Icon_itemmii_8.Image = My.Resources._0600
        End If
        If valu_itemmii_8.Value = 7 Then
            Icon_itemmii_8.Image = My.Resources._0700
        End If
        If valu_itemmii_8.Value = 8 Then
            Icon_itemmii_8.Image = My.Resources._0800
        End If
        If valu_itemmii_8.Value = 9 Then
            Icon_itemmii_8.Image = My.Resources._0900
        End If
        If valu_itemmii_8.Value = 10 Then
            Icon_itemmii_8.Image = My.Resources._0a00
        End If
        If valu_itemmii_8.Value = 11 Then
            Icon_itemmii_8.Image = My.Resources._0b00
        End If
        If valu_itemmii_8.Value = 12 Then
            Icon_itemmii_8.Image = My.Resources._0c00
        End If
        If valu_itemmii_8.Value = 13 Then
            Icon_itemmii_8.Image = My.Resources._0d00
        End If
        If valu_itemmii_8.Value = 14 Then
            Icon_itemmii_8.Image = My.Resources._0e00
        End If
        If valu_itemmii_8.Value = 15 Then
            Icon_itemmii_8.Image = My.Resources._0f00
        End If
        If valu_itemmii_8.Value = 16 Then
            Icon_itemmii_8.Image = My.Resources._1000
        End If
        If valu_itemmii_8.Value = 17 Then
            Icon_itemmii_8.Image = My.Resources._1100
        End If
        If valu_itemmii_8.Value = 18 Then
            Icon_itemmii_8.Image = My.Resources._1200
        End If
        If valu_itemmii_8.Value = 19 Then
            Icon_itemmii_8.Image = My.Resources._1300
        End If
        If valu_itemmii_8.Value = 20 Then
            Icon_itemmii_8.Image = My.Resources._1400
        End If
        If valu_itemmii_8.Value = 21 Then
            Icon_itemmii_8.Image = My.Resources._1500
        End If
        If valu_itemmii_8.Value = 22 Then
            Icon_itemmii_8.Image = My.Resources._1600
        End If
        If valu_itemmii_8.Value = 23 Then
            Icon_itemmii_8.Image = My.Resources._1700
        End If
        If valu_itemmii_8.Value = 24 Then
            Icon_itemmii_8.Image = My.Resources._1800
        End If
        If valu_itemmii_8.Value = 25 Then
            Icon_itemmii_8.Image = My.Resources._1900
        End If
        If valu_itemmii_8.Value = 26 Then
            Icon_itemmii_8.Image = My.Resources._1a00
        End If
        If valu_itemmii_8.Value = 27 Then
            Icon_itemmii_8.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        If Select_language.SelectedItem = Select_language.Items.Item(0) Then
            Text_editing_mii.Text = "editing " & Text_nickname.Text & " ..."
        ElseIf Select_language.SelectedItem = Select_language.Items.Item(1) Then
            Text_editing_mii.Text = "édition de " & Text_nickname.Text & " ..."
        End If
        Select_unlock_gooditems.SelectedItem = Select_unlock_gooditems.Items.Item(0)
        Select_unlock_interiors.SelectedItem = Select_unlock_interiors.Items.Item(0)
        Select_unlock_specialfoods.SelectedItem = Select_unlock_specialfoods.Items.Item(0)
        Select_interaction.SelectedItem = Select_interaction.Items.Item(0)
        readMii()
    End Sub
End Class
