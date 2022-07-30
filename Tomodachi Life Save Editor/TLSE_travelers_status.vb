Imports PackageIO
Imports System.IO
Imports System.Net
Imports System
Public Class TLSE_travelers_status
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim AudioTomodachi As System.IO.UnmanagedMemoryStream
    Dim savedataArc As String
    Dim Miidetected As String
    Dim accessrelationship As String
    Dim lastdatesave = &H10
    Dim name_1 = &H392C0
    Dim datetravelers_1 = &H39390
    Dim where_1 = &H39398
    Dim onisland_1 = &H39399
    Dim tent_1 = &H3939A
    Dim pitchtent_1 = &H3939C
    Dim permissionpitch_1 = &H3939E
    Dim departport_1 = &H393A0
    Dim visibleport_1 = &H393A1
    Dim newicon_1 = &H393B3
    Dim wandering_1 = &H393B4
    Dim startconversation_1 = &H393B5
    Dim justarrive_1 = &H393B7
    Dim message_1 = &H393BC
    Dim experience_1 = &H394FC
    Dim level_1 = &H394FD
    Dim name_2 = &H39EE8
    Dim datetravelers_2 = &H39FB8
    Dim where_2 = &H39FC0
    Dim onisland_2 = &H39FC1
    Dim tent_2 = &H39FC2
    Dim pitchtent_2 = &H39FC4
    Dim permissionpitch_2 = &H39FC6
    Dim departport_2 = &H39FC8
    Dim visibleport_2 = &H39FC9
    Dim newicon_2 = &H39FDB
    Dim wandering_2 = &H39FDC
    Dim startconversation_2 = &H39FDD
    Dim justarrive_2 = &H39FDF
    Dim message_2 = &H39FE4
    Dim experience_2 = &H3A124
    Dim level_2 = &H3A125
    Dim name_3 = &H3AB10
    Dim datetravelers_3 = &H3ABE0
    Dim where_3 = &H3ABE8
    Dim onisland_3 = &H3ABE9
    Dim tent_3 = &H3ABEA
    Dim pitchtent_3 = &H3ABEC
    Dim permissionpitch_3 = &H3ABEE
    Dim departport_3 = &H3ABF0
    Dim visibleport_3 = &H3ABF1
    Dim newicon_3 = &H3AC03
    Dim wandering_3 = &H3AC04
    Dim startconversation_3 = &H3AC05
    Dim justarrive_3 = &H3AC07
    Dim message_3 = &H3AC0C
    Dim experience_3 = &H3AD4C
    Dim level_3 = &H3AD4D
    Dim name_4 = &H3B738
    Dim datetravelers_4 = &H3B808
    Dim where_4 = &H3B810
    Dim onisland_4 = &H3B811
    Dim tent_4 = &H3B812
    Dim pitchtent_4 = &H3B814
    Dim permissionpitch_4 = &H3B816
    Dim departport_4 = &H3B818
    Dim visibleport_4 = &H3B819
    Dim newicon_4 = &H3B82B
    Dim wandering_4 = &H3B82C
    Dim startconversation_4 = &H3B82D
    Dim justarrive_4 = &H3B82F
    Dim message_4 = &H3B834
    Dim experience_4 = &H3B974
    Dim level_4 = &H3B975
    Dim name_5 = &H3C360
    Dim datetravelers_5 = &H3C430
    Dim where_5 = &H3C438
    Dim onisland_5 = &H3C439
    Dim tent_5 = &H3C43A
    Dim pitchtent_5 = &H3C43C
    Dim permissionpitch_5 = &H3C43E
    Dim departport_5 = &H3C440
    Dim visibleport_5 = &H3C441
    Dim newicon_5 = &H3C453
    Dim wandering_5 = &H3C454
    Dim startconversation_5 = &H3C455
    Dim justarrive_5 = &H3C457
    Dim message_5 = &H3C45C
    Dim experience_5 = &H3C59C
    Dim level_5 = &H3C59D
    Dim name_6 = &H3CF88
    Dim datetravelers_6 = &H3D058
    Dim where_6 = &H3D060
    Dim onisland_6 = &H3D061
    Dim tent_6 = &H3D062
    Dim pitchtent_6 = &H3D064
    Dim permissionpitch_6 = &H3D066
    Dim departport_6 = &H3D068
    Dim visibleport_6 = &H3D069
    Dim newicon_6 = &H3D07B
    Dim wandering_6 = &H3D07C
    Dim startconversation_6 = &H3D07D
    Dim justarrive_6 = &H3D07F
    Dim message_6 = &H3D084
    Dim experience_6 = &H3D1C4
    Dim level_6 = &H3D1C5
    Dim name_7 = &H3DBB0
    Dim datetravelers_7 = &H3DC80
    Dim where_7 = &H3DC88
    Dim onisland_7 = &H3DC89
    Dim tent_7 = &H3DC8A
    Dim pitchtent_7 = &H3DC8C
    Dim permissionpitch_7 = &H3DC8E
    Dim departport_7 = &H3DC90
    Dim visibleport_7 = &H3DC91
    Dim newicon_7 = &H3DCA3
    Dim wandering_7 = &H3DCA4
    Dim startconversation_7 = &H3DCA5
    Dim justarrive_7 = &H3DCA7
    Dim message_7 = &H3DCAC
    Dim experience_7 = &H3DDEC
    Dim level_7 = &H3DDED
    Dim name_8 = &H3E7D8
    Dim datetravelers_8 = &H3E8A8
    Dim where_8 = &H3E8B0
    Dim onisland_8 = &H3E8B1
    Dim tent_8 = &H3E8B2
    Dim pitchtent_8 = &H3E8B4
    Dim permissionpitch_8 = &H3E8B6
    Dim departport_8 = &H3E8B8
    Dim visibleport_8 = &H3E8B9
    Dim newicon_8 = &H3E8CB
    Dim wandering_8 = &H3E8CC
    Dim startconversation_8 = &H3E8CD
    Dim justarrive_8 = &H3E8CF
    Dim message_8 = &H3E8D4
    Dim experience_8 = &H3EA14
    Dim level_8 = &H3EA15
    Dim name_9 = &H3F400
    Dim datetravelers_9 = &H3F4D0
    Dim where_9 = &H3F4D8
    Dim onisland_9 = &H3F4D9
    Dim tent_9 = &H3F4DA
    Dim pitchtent_9 = &H3F4DC
    Dim permissionpitch_9 = &H3F4DE
    Dim departport_9 = &H3F4E0
    Dim visibleport_9 = &H3F4E1
    Dim newicon_9 = &H3F4F3
    Dim wandering_9 = &H3F4F4
    Dim startconversation_9 = &H3F4F5
    Dim justarrive_9 = &H3F4F7
    Dim message_9 = &H3F4FC
    Dim experience_9 = &H3F63C
    Dim level_9 = &H3F63D
    Dim name_10 = &H40028
    Dim datetravelers_10 = &H400F8
    Dim where_10 = &H40100
    Dim onisland_10 = &H40101
    Dim tent_10 = &H40102
    Dim pitchtent_10 = &H40104
    Dim permissionpitch_10 = &H40106
    Dim departport_10 = &H40108
    Dim visibleport_10 = &H40109
    Dim newicon_10 = &H4011B
    Dim wandering_10 = &H4011C
    Dim startconversation_10 = &H4011D
    Dim justarrive_10 = &H4011F
    Dim message_10 = &H40124
    Dim experience_10 = &H40264
    Dim level_10 = &H40265
    Dim name_11 = &H40C50
    Dim datetravelers_11 = &H40D20
    Dim where_11 = &H40D28
    Dim onisland_11 = &H40D29
    Dim tent_11 = &H40D2A
    Dim pitchtent_11 = &H40D2C
    Dim permissionpitch_11 = &H40D2E
    Dim departport_11 = &H40D30
    Dim visibleport_11 = &H40D31
    Dim newicon_11 = &H40D43
    Dim wandering_11 = &H40D44
    Dim startconversation_11 = &H40D45
    Dim justarrive_11 = &H40D47
    Dim message_11 = &H40D4C
    Dim experience_11 = &H40E8C
    Dim level_11 = &H40E8D
    Dim name_12 = &H41878
    Dim datetravelers_12 = &H41948
    Dim where_12 = &H41950
    Dim onisland_12 = &H41951
    Dim tent_12 = &H41952
    Dim pitchtent_12 = &H41954
    Dim permissionpitch_12 = &H41956
    Dim departport_12 = &H41958
    Dim visibleport_12 = &H41959
    Dim newicon_12 = &H4196B
    Dim wandering_12 = &H4196C
    Dim startconversation_12 = &H4196D
    Dim justarrive_12 = &H4196F
    Dim message_12 = &H41974
    Dim experience_12 = &H41AB4
    Dim level_12 = &H41AB5
    Dim name_13 = &H424A0
    Dim datetravelers_13 = &H42570
    Dim where_13 = &H42578
    Dim onisland_13 = &H42579
    Dim tent_13 = &H4257A
    Dim pitchtent_13 = &H4257C
    Dim permissionpitch_13 = &H4257E
    Dim departport_13 = &H42580
    Dim visibleport_13 = &H42581
    Dim newicon_13 = &H42593
    Dim wandering_13 = &H42594
    Dim startconversation_13 = &H42595
    Dim justarrive_13 = &H42597
    Dim message_13 = &H4259C
    Dim experience_13 = &H426DC
    Dim level_13 = &H426DD
    Dim name_14 = &H430C8
    Dim datetravelers_14 = &H43198
    Dim where_14 = &H431A0
    Dim onisland_14 = &H431A1
    Dim tent_14 = &H431A2
    Dim pitchtent_14 = &H431A4
    Dim permissionpitch_14 = &H431A6
    Dim departport_14 = &H431A8
    Dim visibleport_14 = &H431A9
    Dim newicon_14 = &H431BB
    Dim wandering_14 = &H431BC
    Dim startconversation_14 = &H431BD
    Dim justarrive_14 = &H431BF
    Dim message_14 = &H431C4
    Dim experience_14 = &H43304
    Dim level_14 = &H43305
    Dim name_15 = &H43CF0
    Dim datetravelers_15 = &H43DC0
    Dim where_15 = &H43DC8
    Dim onisland_15 = &H43DC9
    Dim tent_15 = &H43DCA
    Dim pitchtent_15 = &H43DCC
    Dim permissionpitch_15 = &H43DCE
    Dim departport_15 = &H43DD0
    Dim visibleport_15 = &H43DD1
    Dim newicon_15 = &H43DE3
    Dim wandering_15 = &H43DE4
    Dim startconversation_15 = &H43DE5
    Dim justarrive_15 = &H43DE7
    Dim message_15 = &H43DEC
    Dim experience_15 = &H43F2C
    Dim level_15 = &H43F2D
    Dim name_16 = &H44918
    Dim datetravelers_16 = &H449E8
    Dim where_16 = &H449F0
    Dim onisland_16 = &H449F1
    Dim tent_16 = &H449F2
    Dim pitchtent_16 = &H449F4
    Dim permissionpitch_16 = &H449F6
    Dim departport_16 = &H449F8
    Dim visibleport_16 = &H449F9
    Dim newicon_16 = &H44A0B
    Dim wandering_16 = &H44A0C
    Dim startconversation_16 = &H44A0D
    Dim justarrive_16 = &H44A0F
    Dim message_16 = &H44A14
    Dim experience_16 = &H44B54
    Dim level_16 = &H44B55
    Dim name_17 = &H45540
    Dim datetravelers_17 = &H45610
    Dim where_17 = &H45618
    Dim onisland_17 = &H45619
    Dim tent_17 = &H4561A
    Dim pitchtent_17 = &H4561C
    Dim permissionpitch_17 = &H4561E
    Dim departport_17 = &H45620
    Dim visibleport_17 = &H45621
    Dim newicon_17 = &H45633
    Dim wandering_17 = &H45634
    Dim startconversation_17 = &H45635
    Dim justarrive_17 = &H45637
    Dim message_17 = &H4563C
    Dim experience_17 = &H4577C
    Dim level_17 = &H4577D
    Dim name_18 = &H46168
    Dim datetravelers_18 = &H46238
    Dim where_18 = &H46240
    Dim onisland_18 = &H46241
    Dim tent_18 = &H46242
    Dim pitchtent_18 = &H46244
    Dim permissionpitch_18 = &H46246
    Dim departport_18 = &H46248
    Dim visibleport_18 = &H46249
    Dim newicon_18 = &H4625B
    Dim wandering_18 = &H4625C
    Dim startconversation_18 = &H4625D
    Dim justarrive_18 = &H4625F
    Dim message_18 = &H46264
    Dim experience_18 = &H463A4
    Dim level_18 = &H463A5
    Dim name_19 = &H46D90
    Dim datetravelers_19 = &H46E60
    Dim where_19 = &H46E68
    Dim onisland_19 = &H46E69
    Dim tent_19 = &H46E6A
    Dim pitchtent_19 = &H46E6C
    Dim permissionpitch_19 = &H46E6E
    Dim departport_19 = &H46E70
    Dim visibleport_19 = &H46E71
    Dim newicon_19 = &H46E83
    Dim wandering_19 = &H46E84
    Dim startconversation_19 = &H46E85
    Dim justarrive_19 = &H46E87
    Dim message_19 = &H46E8C
    Dim experience_19 = &H46FCC
    Dim level_19 = &H46FCD
    Dim name_20 = &H479B8
    Dim datetravelers_20 = &H47A88
    Dim where_20 = &H47A90
    Dim onisland_20 = &H47A91
    Dim tent_20 = &H47A92
    Dim pitchtent_20 = &H47A94
    Dim permissionpitch_20 = &H47A96
    Dim departport_20 = &H47A98
    Dim visibleport_20 = &H47A99
    Dim newicon_20 = &H47AAB
    Dim wandering_20 = &H47AAC
    Dim startconversation_20 = &H47AAD
    Dim justarrive_20 = &H47AAF
    Dim message_20 = &H47AB4
    Dim experience_20 = &H47BF4
    Dim level_20 = &H47BF5
    Dim name_21 = &H485E0
    Dim datetravelers_21 = &H486B0
    Dim where_21 = &H486B8
    Dim onisland_21 = &H486B9
    Dim tent_21 = &H486BA
    Dim pitchtent_21 = &H486BC
    Dim permissionpitch_21 = &H486BE
    Dim departport_21 = &H486C0
    Dim visibleport_21 = &H486C1
    Dim newicon_21 = &H486D3
    Dim wandering_21 = &H486D4
    Dim startconversation_21 = &H486D5
    Dim justarrive_21 = &H486D7
    Dim message_21 = &H486DC
    Dim experience_21 = &H4881C
    Dim level_21 = &H4881D
    Dim name_22 = &H49208
    Dim datetravelers_22 = &H492D8
    Dim where_22 = &H492E0
    Dim onisland_22 = &H492E1
    Dim tent_22 = &H492E2
    Dim pitchtent_22 = &H492E4
    Dim permissionpitch_22 = &H492E6
    Dim departport_22 = &H492E8
    Dim visibleport_22 = &H492E9
    Dim newicon_22 = &H492FB
    Dim wandering_22 = &H492FC
    Dim startconversation_22 = &H492FD
    Dim justarrive_22 = &H492FF
    Dim message_22 = &H49304
    Dim experience_22 = &H49444
    Dim level_22 = &H49445
    Dim name_23 = &H49E30
    Dim datetravelers_23 = &H49F00
    Dim where_23 = &H49F08
    Dim onisland_23 = &H49F09
    Dim tent_23 = &H49F0A
    Dim pitchtent_23 = &H49F0C
    Dim permissionpitch_23 = &H49F0E
    Dim departport_23 = &H49F10
    Dim visibleport_23 = &H49F11
    Dim newicon_23 = &H49F23
    Dim wandering_23 = &H49F24
    Dim startconversation_23 = &H49F25
    Dim justarrive_23 = &H49F27
    Dim message_23 = &H49F2C
    Dim experience_23 = &H4A06C
    Dim level_23 = &H4A06D
    Dim name_24 = &H4AA58
    Dim datetravelers_24 = &H4AB28
    Dim where_24 = &H4AB30
    Dim onisland_24 = &H4AB31
    Dim tent_24 = &H4AB32
    Dim pitchtent_24 = &H4AB34
    Dim permissionpitch_24 = &H4AB36
    Dim departport_24 = &H4AB38
    Dim visibleport_24 = &H4AB39
    Dim newicon_24 = &H4AB4B
    Dim wandering_24 = &H4AB4C
    Dim startconversation_24 = &H4AB4D
    Dim justarrive_24 = &H4AB4F
    Dim message_24 = &H4AB54
    Dim experience_24 = &H4AC94
    Dim level_24 = &H4AC95
    Dim name_25 = &H4B680
    Dim datetravelers_25 = &H4B750
    Dim where_25 = &H4B758
    Dim onisland_25 = &H4B759
    Dim tent_25 = &H4B75A
    Dim pitchtent_25 = &H4B75C
    Dim permissionpitch_25 = &H4B75E
    Dim departport_25 = &H4B760
    Dim visibleport_25 = &H4B761
    Dim newicon_25 = &H4B773
    Dim wandering_25 = &H4B774
    Dim startconversation_25 = &H4B775
    Dim justarrive_25 = &H4B777
    Dim message_25 = &H4B77C
    Dim experience_25 = &H4B8BC
    Dim level_25 = &H4B8BD
    Dim name_26 = &H4C2A8
    Dim datetravelers_26 = &H4C378
    Dim where_26 = &H4C380
    Dim onisland_26 = &H4C381
    Dim tent_26 = &H4C382
    Dim pitchtent_26 = &H4C384
    Dim permissionpitch_26 = &H4C386
    Dim departport_26 = &H4C388
    Dim visibleport_26 = &H4C389
    Dim newicon_26 = &H4C39B
    Dim wandering_26 = &H4C39C
    Dim startconversation_26 = &H4C39D
    Dim justarrive_26 = &H4C39F
    Dim message_26 = &H4C3A4
    Dim experience_26 = &H4C4E4
    Dim level_26 = &H4C4E5
    Dim name_27 = &H4CED0
    Dim datetravelers_27 = &H4CFA0
    Dim where_27 = &H4CFA8
    Dim onisland_27 = &H4CFA9
    Dim tent_27 = &H4CFAA
    Dim pitchtent_27 = &H4CFAC
    Dim permissionpitch_27 = &H4CFAE
    Dim departport_27 = &H4CFB0
    Dim visibleport_27 = &H4CFB1
    Dim newicon_27 = &H4CFC3
    Dim wandering_27 = &H4CFC4
    Dim startconversation_27 = &H4CFC5
    Dim justarrive_27 = &H4CFC7
    Dim message_27 = &H4CFCC
    Dim experience_27 = &H4D10C
    Dim level_27 = &H4D10D
    Dim name_28 = &H4DAF8
    Dim datetravelers_28 = &H4DBC8
    Dim where_28 = &H4DBD0
    Dim onisland_28 = &H4DBD1
    Dim tent_28 = &H4DBD2
    Dim pitchtent_28 = &H4DBD4
    Dim permissionpitch_28 = &H4DBD6
    Dim departport_28 = &H4DBD8
    Dim visibleport_28 = &H4DBD9
    Dim newicon_28 = &H4DBEB
    Dim wandering_28 = &H4DBEC
    Dim startconversation_28 = &H4DBED
    Dim justarrive_28 = &H4DBEF
    Dim message_28 = &H4DBF4
    Dim experience_28 = &H4DD34
    Dim level_28 = &H4DD35
    Dim name_29 = &H4E720
    Dim datetravelers_29 = &H4E7F0
    Dim where_29 = &H4E7F8
    Dim onisland_29 = &H4E7F9
    Dim tent_29 = &H4E7FA
    Dim pitchtent_29 = &H4E7FC
    Dim permissionpitch_29 = &H4E7FE
    Dim departport_29 = &H4E800
    Dim visibleport_29 = &H4E801
    Dim newicon_29 = &H4E813
    Dim wandering_29 = &H4E814
    Dim startconversation_29 = &H4E815
    Dim justarrive_29 = &H4E817
    Dim message_29 = &H4E81C
    Dim experience_29 = &H4E95C
    Dim level_29 = &H4E95D
    Dim name_30 = &H4F348
    Dim datetravelers_30 = &H4F418
    Dim where_30 = &H4F420
    Dim onisland_30 = &H4F421
    Dim tent_30 = &H4F422
    Dim pitchtent_30 = &H4F424
    Dim permissionpitch_30 = &H4F426
    Dim departport_30 = &H4F428
    Dim visibleport_30 = &H4F429
    Dim newicon_30 = &H4F43B
    Dim wandering_30 = &H4F43C
    Dim startconversation_30 = &H4F43D
    Dim justarrive_30 = &H4F43F
    Dim message_30 = &H4F444
    Dim experience_30 = &H4F584
    Dim level_30 = &H4F585
    Dim name_31 = &H4FF70
    Dim datetravelers_31 = &H50040
    Dim where_31 = &H50048
    Dim onisland_31 = &H50049
    Dim tent_31 = &H5004A
    Dim pitchtent_31 = &H5004C
    Dim permissionpitch_31 = &H5004E
    Dim departport_31 = &H50050
    Dim visibleport_31 = &H50051
    Dim newicon_31 = &H50063
    Dim wandering_31 = &H50064
    Dim startconversation_31 = &H50065
    Dim justarrive_31 = &H50067
    Dim message_31 = &H5006C
    Dim experience_31 = &H501AC
    Dim level_31 = &H501AD
    Dim name_32 = &H50B98
    Dim datetravelers_32 = &H50C68
    Dim where_32 = &H50C70
    Dim onisland_32 = &H50C71
    Dim tent_32 = &H50C72
    Dim pitchtent_32 = &H50C74
    Dim permissionpitch_32 = &H50C76
    Dim departport_32 = &H50C78
    Dim visibleport_32 = &H50C79
    Dim newicon_32 = &H50C8B
    Dim wandering_32 = &H50C8C
    Dim startconversation_32 = &H50C8D
    Dim justarrive_32 = &H50C8F
    Dim message_32 = &H50C94
    Dim experience_32 = &H50DD4
    Dim level_32 = &H50DD5
    Dim name_33 = &H517C0
    Dim datetravelers_33 = &H51890
    Dim where_33 = &H51898
    Dim onisland_33 = &H51899
    Dim tent_33 = &H5189A
    Dim pitchtent_33 = &H5189C
    Dim permissionpitch_33 = &H5189E
    Dim departport_33 = &H518A0
    Dim visibleport_33 = &H518A1
    Dim newicon_33 = &H518B3
    Dim wandering_33 = &H518B4
    Dim startconversation_33 = &H518B5
    Dim justarrive_33 = &H518B7
    Dim message_33 = &H518BC
    Dim experience_33 = &H519FC
    Dim level_33 = &H519FD
    Dim name_34 = &H523E8
    Dim datetravelers_34 = &H524B8
    Dim where_34 = &H524C0
    Dim onisland_34 = &H524C1
    Dim tent_34 = &H524C2
    Dim pitchtent_34 = &H524C4
    Dim permissionpitch_34 = &H524C6
    Dim departport_34 = &H524C8
    Dim visibleport_34 = &H524C9
    Dim newicon_34 = &H524DB
    Dim wandering_34 = &H524DC
    Dim startconversation_34 = &H524DD
    Dim justarrive_34 = &H524DF
    Dim message_34 = &H524E4
    Dim experience_34 = &H52624
    Dim level_34 = &H52625
    Dim name_35 = &H53010
    Dim datetravelers_35 = &H530E0
    Dim where_35 = &H530E8
    Dim onisland_35 = &H530E9
    Dim tent_35 = &H530EA
    Dim pitchtent_35 = &H530EC
    Dim permissionpitch_35 = &H530EE
    Dim departport_35 = &H530F0
    Dim visibleport_35 = &H530F1
    Dim newicon_35 = &H53103
    Dim wandering_35 = &H53104
    Dim startconversation_35 = &H53105
    Dim justarrive_35 = &H53107
    Dim message_35 = &H5310C
    Dim experience_35 = &H5324C
    Dim level_35 = &H5324D
    Dim name_36 = &H53C38
    Dim datetravelers_36 = &H53D08
    Dim where_36 = &H53D10
    Dim onisland_36 = &H53D11
    Dim tent_36 = &H53D12
    Dim pitchtent_36 = &H53D14
    Dim permissionpitch_36 = &H53D16
    Dim departport_36 = &H53D18
    Dim visibleport_36 = &H53D19
    Dim newicon_36 = &H53D2B
    Dim wandering_36 = &H53D2C
    Dim startconversation_36 = &H53D2D
    Dim justarrive_36 = &H53D2F
    Dim message_36 = &H53D34
    Dim experience_36 = &H53E74
    Dim level_36 = &H53E75
    Dim name_37 = &H54860
    Dim datetravelers_37 = &H54930
    Dim where_37 = &H54938
    Dim onisland_37 = &H54939
    Dim tent_37 = &H5493A
    Dim pitchtent_37 = &H5493C
    Dim permissionpitch_37 = &H5493E
    Dim departport_37 = &H54940
    Dim visibleport_37 = &H54941
    Dim newicon_37 = &H54953
    Dim wandering_37 = &H54954
    Dim startconversation_37 = &H54955
    Dim justarrive_37 = &H54957
    Dim message_37 = &H5495C
    Dim experience_37 = &H54A9C
    Dim level_37 = &H54A9D
    Dim name_38 = &H55488
    Dim datetravelers_38 = &H55558
    Dim where_38 = &H55560
    Dim onisland_38 = &H55561
    Dim tent_38 = &H55562
    Dim pitchtent_38 = &H55564
    Dim permissionpitch_38 = &H55566
    Dim departport_38 = &H55568
    Dim visibleport_38 = &H55569
    Dim newicon_38 = &H5557B
    Dim wandering_38 = &H5557C
    Dim startconversation_38 = &H5557D
    Dim justarrive_38 = &H5557F
    Dim message_38 = &H55584
    Dim experience_38 = &H556C4
    Dim level_38 = &H556C5
    Dim name_39 = &H560B0
    Dim datetravelers_39 = &H56180
    Dim where_39 = &H56188
    Dim onisland_39 = &H56189
    Dim tent_39 = &H5618A
    Dim pitchtent_39 = &H5618C
    Dim permissionpitch_39 = &H5618E
    Dim departport_39 = &H56190
    Dim visibleport_39 = &H56191
    Dim newicon_39 = &H561A3
    Dim wandering_39 = &H561A4
    Dim startconversation_39 = &H561A5
    Dim justarrive_39 = &H561A7
    Dim message_39 = &H561AC
    Dim experience_39 = &H562EC
    Dim level_39 = &H562ED
    Dim name_40 = &H56CD8
    Dim datetravelers_40 = &H56DA8
    Dim where_40 = &H56DB0
    Dim onisland_40 = &H56DB1
    Dim tent_40 = &H56DB2
    Dim pitchtent_40 = &H56DB4
    Dim permissionpitch_40 = &H56DB6
    Dim departport_40 = &H56DB8
    Dim visibleport_40 = &H56DB9
    Dim newicon_40 = &H56DCB
    Dim wandering_40 = &H56DCC
    Dim startconversation_40 = &H56DCD
    Dim justarrive_40 = &H56DCF
    Dim message_40 = &H56DD4
    Dim experience_40 = &H56F14
    Dim level_40 = &H56F15
    Dim name_41 = &H57900
    Dim datetravelers_41 = &H579D0
    Dim where_41 = &H579D8
    Dim onisland_41 = &H579D9
    Dim tent_41 = &H579DA
    Dim pitchtent_41 = &H579DC
    Dim permissionpitch_41 = &H579DE
    Dim departport_41 = &H579E0
    Dim visibleport_41 = &H579E1
    Dim newicon_41 = &H579F3
    Dim wandering_41 = &H579F4
    Dim startconversation_41 = &H579F5
    Dim justarrive_41 = &H579F7
    Dim message_41 = &H579FC
    Dim experience_41 = &H57B3C
    Dim level_41 = &H57B3D
    Dim name_42 = &H58528
    Dim datetravelers_42 = &H585F8
    Dim where_42 = &H58600
    Dim onisland_42 = &H58601
    Dim tent_42 = &H58602
    Dim pitchtent_42 = &H58604
    Dim permissionpitch_42 = &H58606
    Dim departport_42 = &H58608
    Dim visibleport_42 = &H58609
    Dim newicon_42 = &H5861B
    Dim wandering_42 = &H5861C
    Dim startconversation_42 = &H5861D
    Dim justarrive_42 = &H5861F
    Dim message_42 = &H58624
    Dim experience_42 = &H58764
    Dim level_42 = &H58765
    Dim name_43 = &H59150
    Dim datetravelers_43 = &H59220
    Dim where_43 = &H59228
    Dim onisland_43 = &H59229
    Dim tent_43 = &H5922A
    Dim pitchtent_43 = &H5922C
    Dim permissionpitch_43 = &H5922E
    Dim departport_43 = &H59230
    Dim visibleport_43 = &H59231
    Dim newicon_43 = &H59243
    Dim wandering_43 = &H59244
    Dim startconversation_43 = &H59245
    Dim justarrive_43 = &H59247
    Dim message_43 = &H5924C
    Dim experience_43 = &H5938C
    Dim level_43 = &H5938D
    Dim name_44 = &H59D78
    Dim datetravelers_44 = &H59E48
    Dim where_44 = &H59E50
    Dim onisland_44 = &H59E51
    Dim tent_44 = &H59E52
    Dim pitchtent_44 = &H59E54
    Dim permissionpitch_44 = &H59E56
    Dim departport_44 = &H59E58
    Dim visibleport_44 = &H59E59
    Dim newicon_44 = &H59E6B
    Dim wandering_44 = &H59E6C
    Dim startconversation_44 = &H59E6D
    Dim justarrive_44 = &H59E6F
    Dim message_44 = &H59E74
    Dim experience_44 = &H59FB4
    Dim level_44 = &H59FB5
    Dim name_45 = &H5A9A0
    Dim datetravelers_45 = &H5AA70
    Dim where_45 = &H5AA78
    Dim onisland_45 = &H5AA79
    Dim tent_45 = &H5AA7A
    Dim pitchtent_45 = &H5AA7C
    Dim permissionpitch_45 = &H5AA7E
    Dim departport_45 = &H5AA80
    Dim visibleport_45 = &H5AA81
    Dim newicon_45 = &H5AA93
    Dim wandering_45 = &H5AA94
    Dim startconversation_45 = &H5AA95
    Dim justarrive_45 = &H5AA97
    Dim message_45 = &H5AA9C
    Dim experience_45 = &H5ABDC
    Dim level_45 = &H5ABDD
    Dim name_46 = &H5B5C8
    Dim datetravelers_46 = &H5B698
    Dim where_46 = &H5B6A0
    Dim onisland_46 = &H5B6A1
    Dim tent_46 = &H5B6A2
    Dim pitchtent_46 = &H5B6A4
    Dim permissionpitch_46 = &H5B6A6
    Dim departport_46 = &H5B6A8
    Dim visibleport_46 = &H5B6A9
    Dim newicon_46 = &H5B6BB
    Dim wandering_46 = &H5B6BC
    Dim startconversation_46 = &H5B6BD
    Dim justarrive_46 = &H5B6BF
    Dim message_46 = &H5B6C4
    Dim experience_46 = &H5B804
    Dim level_46 = &H5B805
    Dim name_47 = &H5C1F0
    Dim datetravelers_47 = &H5C2C0
    Dim where_47 = &H5C2C8
    Dim onisland_47 = &H5C2C9
    Dim tent_47 = &H5C2CA
    Dim pitchtent_47 = &H5C2CC
    Dim permissionpitch_47 = &H5C2CE
    Dim departport_47 = &H5C2D0
    Dim visibleport_47 = &H5C2D1
    Dim newicon_47 = &H5C2E3
    Dim wandering_47 = &H5C2E4
    Dim startconversation_47 = &H5C2E5
    Dim justarrive_47 = &H5C2E7
    Dim message_47 = &H5C2EC
    Dim experience_47 = &H5C42C
    Dim level_47 = &H5C42D
    Dim name_48 = &H5CE18
    Dim datetravelers_48 = &H5CEE8
    Dim where_48 = &H5CEF0
    Dim onisland_48 = &H5CEF1
    Dim tent_48 = &H5CEF2
    Dim pitchtent_48 = &H5CEF4
    Dim permissionpitch_48 = &H5CEF6
    Dim departport_48 = &H5CEF8
    Dim visibleport_48 = &H5CEF9
    Dim newicon_48 = &H5CF0B
    Dim wandering_48 = &H5CF0C
    Dim startconversation_48 = &H5CF0D
    Dim justarrive_48 = &H5CF0F
    Dim message_48 = &H5CF14
    Dim experience_48 = &H5D054
    Dim level_48 = &H5D055
    Dim name_49 = &H5DA40
    Dim datetravelers_49 = &H5DB10
    Dim where_49 = &H5DB18
    Dim onisland_49 = &H5DB19
    Dim tent_49 = &H5DB1A
    Dim pitchtent_49 = &H5DB1C
    Dim permissionpitch_49 = &H5DB1E
    Dim departport_49 = &H5DB20
    Dim visibleport_49 = &H5DB21
    Dim newicon_49 = &H5DB33
    Dim wandering_49 = &H5DB34
    Dim startconversation_49 = &H5DB35
    Dim justarrive_49 = &H5DB37
    Dim message_49 = &H5DB3C
    Dim experience_49 = &H5DC7C
    Dim level_49 = &H5DC7D
    Dim name_50 = &H5E668
    Dim datetravelers_50 = &H5E738
    Dim where_50 = &H5E740
    Dim onisland_50 = &H5E741
    Dim tent_50 = &H5E742
    Dim pitchtent_50 = &H5E744
    Dim permissionpitch_50 = &H5E746
    Dim departport_50 = &H5E748
    Dim visibleport_50 = &H5E749
    Dim newicon_50 = &H5E75B
    Dim wandering_50 = &H5E75C
    Dim startconversation_50 = &H5E75D
    Dim justarrive_50 = &H5E75F
    Dim message_50 = &H5E764
    Dim experience_50 = &H5E8A4
    Dim level_50 = &H5E8A5

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red_tl
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close_tl
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

    Private Sub Minimizebutton_Click(sender As Object, e As EventArgs) Handles Minimizebutton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Minimizebutton_MouseMove(sender As Object, e As MouseEventArgs) Handles Minimizebutton.MouseMove
        Minimizebutton.Image = My.Resources.minimize_gray
    End Sub

    Private Sub Minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles Minimizebutton.MouseLeave
        Minimizebutton.Image = My.Resources.minimize
    End Sub

    'form menu
    Private Sub Icon_menu_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_menu.MouseMove
        Icon_menu.Image = My.Resources.icon_menu_on
    End Sub

    Private Sub Icon_menu_MouseLeave(sender As Object, e As EventArgs) Handles Icon_menu.MouseLeave
        Icon_menu.Image = My.Resources.icon_menu_off
    End Sub

    Private Sub Icon_menu_Click(sender As Object, e As EventArgs) Handles Icon_menu.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        Me.Close()
    End Sub

    Private Sub TLSE_travelers_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Setting_Advhelp.Checked = My.Settings.Para_AdvH
            Setting_ckupdate.Checked = My.Settings.Para_chkupdate
            Setting_hidden.Checked = My.Settings.Para_hidden
            Setting_music.Checked = My.Settings.Para_music
            Setting_filepath.Checked = My.Settings.Para_path
            Setting_spesymb.Checked = My.Settings.Para_spesymb
            Select_language.SelectedItem = My.Settings.Para_language
            Select_music.SelectedItem = My.Settings.Para_selmusic
        Catch ex As Exception
        End Try
        TLSE_filepath.Text = TLSE_hub.TLSE_filepath.Text
        Filever_text.Text = TLSE_hub.Filever_text.Text
        savedataArc = TLSE_filepath.Text
        Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            Reader.Position = lastdatesave
            valu_lastsavedate.Value = Reader.ReadUInt32
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read last save date"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture de la dernière date de la sauvegarde a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub TLSE_logo_update_Click(sender As Object, e As EventArgs) Handles TLSE_logo_update.Click
        Process.Start("https://github.com/Brionjv/Tomodachi-Life-Save-Editor/releases")
    End Sub

    Public Sub Readmiiname()
        Try
            Dim Reader As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Filever_text.Text = "JP" Then
                Reader.Position = &H318B0
                Select_mii.Items.Item(0) = "Traveler 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H324D8
                Select_mii.Items.Item(1) = "Traveler 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H33100
                Select_mii.Items.Item(2) = "Traveler 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H33D28
                Select_mii.Items.Item(3) = "Traveler 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H34950
                Select_mii.Items.Item(4) = "Traveler 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H35578
                Select_mii.Items.Item(5) = "Traveler 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H361A0
                Select_mii.Items.Item(6) = "Traveler 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H36DC8
                Select_mii.Items.Item(7) = "Traveler 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H379F0
                Select_mii.Items.Item(8) = "Traveler 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H38618
                Select_mii.Items.Item(9) = "Traveler 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39240
                Select_mii.Items.Item(10) = "Traveler 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39E68
                Select_mii.Items.Item(11) = "Traveler 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3AA90
                Select_mii.Items.Item(12) = "Traveler 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3B6B8
                Select_mii.Items.Item(13) = "Traveler 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C2E0
                Select_mii.Items.Item(14) = "Traveler 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3CF08
                Select_mii.Items.Item(15) = "Traveler 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DB30
                Select_mii.Items.Item(16) = "Traveler 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3E758
                Select_mii.Items.Item(17) = "Traveler 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3F380
                Select_mii.Items.Item(18) = "Traveler 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3FFA8
                Select_mii.Items.Item(19) = "Traveler 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40BD0
                Select_mii.Items.Item(20) = "Traveler 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H417F8
                Select_mii.Items.Item(21) = "Traveler 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H42420
                Select_mii.Items.Item(22) = "Traveler 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43048
                Select_mii.Items.Item(23) = "Traveler 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43C70
                Select_mii.Items.Item(24) = "Traveler 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H44898
                Select_mii.Items.Item(25) = "Traveler 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H454C0
                Select_mii.Items.Item(26) = "Traveler 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H460E8
                Select_mii.Items.Item(27) = "Traveler 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46D10
                Select_mii.Items.Item(28) = "Traveler 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H47938
                Select_mii.Items.Item(29) = "Traveler 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H48560
                Select_mii.Items.Item(30) = "Traveler 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49188
                Select_mii.Items.Item(31) = "Traveler 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49DB0
                Select_mii.Items.Item(32) = "Traveler 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4A9D8
                Select_mii.Items.Item(33) = "Traveler 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4B600
                Select_mii.Items.Item(34) = "Traveler 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4C228
                Select_mii.Items.Item(35) = "Traveler 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4CE50
                Select_mii.Items.Item(36) = "Traveler 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4DA78
                Select_mii.Items.Item(37) = "Traveler 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E6A0
                Select_mii.Items.Item(38) = "Traveler 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F2C8
                Select_mii.Items.Item(39) = "Traveler 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4FEF0
                Select_mii.Items.Item(40) = "Traveler 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H50B18
                Select_mii.Items.Item(41) = "Traveler 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H51740
                Select_mii.Items.Item(42) = "Traveler 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H52368
                Select_mii.Items.Item(43) = "Traveler 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H52F90
                Select_mii.Items.Item(44) = "Traveler 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53BB8
                Select_mii.Items.Item(45) = "Traveler 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H547E0
                Select_mii.Items.Item(46) = "Traveler 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55408
                Select_mii.Items.Item(47) = "Traveler 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56030
                Select_mii.Items.Item(48) = "Traveler 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56C58
                Select_mii.Items.Item(49) = "Traveler 50 : " & Reader.ReadUnicodeString(10)
            Else
                Reader.Position = &H392C0
                Select_mii.Items.Item(0) = "Traveler 1 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H39EE8
                Select_mii.Items.Item(1) = "Traveler 2 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3AB10
                Select_mii.Items.Item(2) = "Traveler 3 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3B738
                Select_mii.Items.Item(3) = "Traveler 4 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3C360
                Select_mii.Items.Item(4) = "Traveler 5 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3CF88
                Select_mii.Items.Item(5) = "Traveler 6 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3DBB0
                Select_mii.Items.Item(6) = "Traveler 7 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3E7D8
                Select_mii.Items.Item(7) = "Traveler 8 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H3F400
                Select_mii.Items.Item(8) = "Traveler 9 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40028
                Select_mii.Items.Item(9) = "Traveler 10 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H40C50
                Select_mii.Items.Item(10) = "Traveler 11 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H41878
                Select_mii.Items.Item(11) = "Traveler 12 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H424A0
                Select_mii.Items.Item(12) = "Traveler 13 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H430C8
                Select_mii.Items.Item(13) = "Traveler 14 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H43CF0
                Select_mii.Items.Item(14) = "Traveler 15 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H44918
                Select_mii.Items.Item(15) = "Traveler 16 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H45540
                Select_mii.Items.Item(16) = "Traveler 17 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46168
                Select_mii.Items.Item(17) = "Traveler 18 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H46D90
                Select_mii.Items.Item(18) = "Traveler 19 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H479B8
                Select_mii.Items.Item(19) = "Traveler 20 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H485E0
                Select_mii.Items.Item(20) = "Traveler 21 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49208
                Select_mii.Items.Item(21) = "Traveler 22 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H49E30
                Select_mii.Items.Item(22) = "Traveler 23 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4AA58
                Select_mii.Items.Item(23) = "Traveler 24 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4B680
                Select_mii.Items.Item(24) = "Traveler 25 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4C2A8
                Select_mii.Items.Item(25) = "Traveler 26 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4CED0
                Select_mii.Items.Item(26) = "Traveler 27 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4DAF8
                Select_mii.Items.Item(27) = "Traveler 28 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4E720
                Select_mii.Items.Item(28) = "Traveler 29 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4F348
                Select_mii.Items.Item(29) = "Traveler 30 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H4FF70
                Select_mii.Items.Item(30) = "Traveler 31 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H50B98
                Select_mii.Items.Item(31) = "Traveler 32 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H517C0
                Select_mii.Items.Item(32) = "Traveler 33 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H523E8
                Select_mii.Items.Item(33) = "Traveler 34 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53010
                Select_mii.Items.Item(34) = "Traveler 35 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H53C38
                Select_mii.Items.Item(35) = "Traveler 36 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H54860
                Select_mii.Items.Item(36) = "Traveler 37 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H55488
                Select_mii.Items.Item(37) = "Traveler 38 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H560B0
                Select_mii.Items.Item(38) = "Traveler 39 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H56CD8
                Select_mii.Items.Item(39) = "Traveler 40 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H57900
                Select_mii.Items.Item(40) = "Traveler 41 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H58528
                Select_mii.Items.Item(41) = "Traveler 42 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H59150
                Select_mii.Items.Item(42) = "Traveler 43 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H59D78
                Select_mii.Items.Item(43) = "Traveler 44 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5A9A0
                Select_mii.Items.Item(44) = "Traveler 45 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5B5C8
                Select_mii.Items.Item(45) = "Traveler 46 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5C1F0
                Select_mii.Items.Item(46) = "Traveler 47 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5CE18
                Select_mii.Items.Item(47) = "Traveler 48 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5DA40
                Select_mii.Items.Item(48) = "Traveler 49 : " & Reader.ReadUnicodeString(10)
                Reader.Position = &H5E668
                Select_mii.Items.Item(49) = "Traveler 50 : " & Reader.ReadUnicodeString(10)
            End If
        Catch ex As Exception
            If Select_language.SelectedItem = Select_language.Items.Item(0) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read Mii names"
                TLSE_dialog.ShowDialog()
            End If
            If Select_language.SelectedItem = Select_language.Items.Item(1) Then
                TLSE_dialog.Text_TLSE_dialog.Text = "La lecture des noms des Mii a échoué"
                TLSE_dialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Icon_arrowexp_right_MouseDown(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseDown
        If valu_happiness.Value < 99 Then
            Timer_arrowexp_right.Start()
        End If
    End Sub

    Private Sub Timer_arrowexp_right_Tick(sender As Object, e As EventArgs) Handles Timer_arrowexp_right.Tick
        If valu_happiness.Value < 99 Then
            valu_happiness.Value = valu_happiness.Value + 1
            Timer_arrowexp_right.Start()
        End If
    End Sub

    Private Sub Icon_arrowexp_right_MouseUp(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseUp
        Timer_arrowexp_right.Stop()
    End Sub

    Private Sub Icon_arrowexp_right_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_right.MouseMove
        Icon_arrowexp_right.Image = My.Resources.icon_arrowexp_righton
    End Sub

    Private Sub Icon_arrowexp_right_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_right.MouseLeave
        Icon_arrowexp_right.Image = My.Resources.icon_arrowexp_right
    End Sub

    Private Sub Icon_arrowexp_left_MouseDown(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_left.MouseDown
        If valu_happiness.Value > 0 Then
            Timer_arrowexp_left.Start()
        End If
    End Sub

    Private Sub Timer_arrowexp_left_Tick(sender As Object, e As EventArgs) Handles Timer_arrowexp_left.Tick
        If valu_happiness.Value > 0 Then
            valu_happiness.Value = valu_happiness.Value - 1
            Timer_arrowexp_left.Start()
        End If
    End Sub

    Private Sub Icon_arrowexp_left_MouseUp(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_left.MouseUp
        Timer_arrowexp_left.Stop()
    End Sub

    Private Sub Icon_arrowexp_left_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_left.MouseMove
        Icon_arrowexp_left.Image = My.Resources.icon_arrowexp_lefton
    End Sub

    Private Sub Icon_arrowexp_left_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_left.MouseLeave
        Icon_arrowexp_left.Image = My.Resources.icon_arrowexp_left
    End Sub

    Private Sub Icon_arrowexp_maxleft_Click(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxleft.Click
        valu_happiness.Value = valu_happiness.Minimum
    End Sub

    Private Sub Icon_arrowexp_maxleft_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_maxleft.MouseMove
        Icon_arrowexp_maxleft.Image = My.Resources.icon_arrowexp_maxlefton
    End Sub

    Private Sub Icon_arrowexp_maxleft_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxleft.MouseLeave
        Icon_arrowexp_maxleft.Image = My.Resources.icon_arrowexp_maxleft
    End Sub

    Private Sub Icon_arrowexp_maxright_Click(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxright.Click
        valu_happiness.Value = valu_happiness.Maximum
    End Sub

    Private Sub Icon_arrowexp_maxright_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_arrowexp_maxright.MouseMove
        Icon_arrowexp_maxright.Image = My.Resources.icon_arrowexp_maxrighton
    End Sub

    Private Sub Icon_arrowexp_maxright_MouseLeave(sender As Object, e As EventArgs) Handles Icon_arrowexp_maxright.MouseLeave
        Icon_arrowexp_maxright.Image = My.Resources.icon_arrowexp_maxright
    End Sub

    Private Sub valu_happiness_ValueChanged(sender As Object, e As EventArgs) Handles valu_happiness.ValueChanged
        If valu_happiness.Value = 0 Then
            Icon_happiness.Image = My.Resources.expt0
        End If
        If valu_happiness.Value = 1 Then
            Icon_happiness.Image = My.Resources.expt1
        End If
        If valu_happiness.Value = 2 Then
            Icon_happiness.Image = My.Resources.expt2
        End If
        If valu_happiness.Value = 3 Then
            Icon_happiness.Image = My.Resources.expt3
        End If
        If valu_happiness.Value = 4 Then
            Icon_happiness.Image = My.Resources.expt4
        End If
        If valu_happiness.Value = 5 Then
            Icon_happiness.Image = My.Resources.expt5
        End If
        If valu_happiness.Value = 6 Then
            Icon_happiness.Image = My.Resources.expt6
        End If
        If valu_happiness.Value = 7 Then
            Icon_happiness.Image = My.Resources.expt7
        End If
        If valu_happiness.Value = 8 Then
            Icon_happiness.Image = My.Resources.expt8
        End If
        If valu_happiness.Value = 9 Then
            Icon_happiness.Image = My.Resources.expt9
        End If
        If valu_happiness.Value = 10 Then
            Icon_happiness.Image = My.Resources.expt10
        End If
        If valu_happiness.Value = 11 Then
            Icon_happiness.Image = My.Resources.expt11
        End If
        If valu_happiness.Value = 12 Then
            Icon_happiness.Image = My.Resources.expt12
        End If
        If valu_happiness.Value = 13 Then
            Icon_happiness.Image = My.Resources.expt13
        End If
        If valu_happiness.Value = 14 Then
            Icon_happiness.Image = My.Resources.expt14
        End If
        If valu_happiness.Value = 15 Then
            Icon_happiness.Image = My.Resources.expt15
        End If
        If valu_happiness.Value = 16 Then
            Icon_happiness.Image = My.Resources.expt16
        End If
        If valu_happiness.Value = 17 Then
            Icon_happiness.Image = My.Resources.expt17
        End If
        If valu_happiness.Value = 18 Then
            Icon_happiness.Image = My.Resources.expt18
        End If
        If valu_happiness.Value = 19 Then
            Icon_happiness.Image = My.Resources.expt19
        End If
        If valu_happiness.Value = 20 Then
            Icon_happiness.Image = My.Resources.expt20
        End If
        If valu_happiness.Value = 21 Then
            Icon_happiness.Image = My.Resources.expt21
        End If
        If valu_happiness.Value = 22 Then
            Icon_happiness.Image = My.Resources.expt22
        End If
        If valu_happiness.Value = 23 Then
            Icon_happiness.Image = My.Resources.expt23
        End If
        If valu_happiness.Value = 24 Then
            Icon_happiness.Image = My.Resources.expt24
        End If
        If valu_happiness.Value = 25 Then
            Icon_happiness.Image = My.Resources.expt25
        End If
        If valu_happiness.Value = 26 Then
            Icon_happiness.Image = My.Resources.expt26
        End If
        If valu_happiness.Value = 27 Then
            Icon_happiness.Image = My.Resources.expt27
        End If
        If valu_happiness.Value = 28 Then
            Icon_happiness.Image = My.Resources.expt28
        End If
        If valu_happiness.Value = 29 Then
            Icon_happiness.Image = My.Resources.expt29
        End If
        If valu_happiness.Value = 30 Then
            Icon_happiness.Image = My.Resources.expt30
        End If
        If valu_happiness.Value = 31 Then
            Icon_happiness.Image = My.Resources.expt31
        End If
        If valu_happiness.Value = 32 Then
            Icon_happiness.Image = My.Resources.expt32
        End If
        If valu_happiness.Value = 33 Then
            Icon_happiness.Image = My.Resources.expt33
        End If
        If valu_happiness.Value = 34 Then
            Icon_happiness.Image = My.Resources.expt34
        End If
        If valu_happiness.Value = 35 Then
            Icon_happiness.Image = My.Resources.expt35
        End If
        If valu_happiness.Value = 36 Then
            Icon_happiness.Image = My.Resources.expt36
        End If
        If valu_happiness.Value = 37 Then
            Icon_happiness.Image = My.Resources.expt37
        End If
        If valu_happiness.Value = 38 Then
            Icon_happiness.Image = My.Resources.expt38
        End If
        If valu_happiness.Value = 39 Then
            Icon_happiness.Image = My.Resources.expt39
        End If
        If valu_happiness.Value = 40 Then
            Icon_happiness.Image = My.Resources.expt40
        End If
        If valu_happiness.Value = 41 Then
            Icon_happiness.Image = My.Resources.expt41
        End If
        If valu_happiness.Value = 42 Then
            Icon_happiness.Image = My.Resources.expt42
        End If
        If valu_happiness.Value = 43 Then
            Icon_happiness.Image = My.Resources.expt43
        End If
        If valu_happiness.Value = 44 Then
            Icon_happiness.Image = My.Resources.expt44
        End If
        If valu_happiness.Value = 45 Then
            Icon_happiness.Image = My.Resources.expt45
        End If
        If valu_happiness.Value = 46 Then
            Icon_happiness.Image = My.Resources.expt46
        End If
        If valu_happiness.Value = 47 Then
            Icon_happiness.Image = My.Resources.expt47
        End If
        If valu_happiness.Value = 48 Then
            Icon_happiness.Image = My.Resources.expt48
        End If
        If valu_happiness.Value = 49 Then
            Icon_happiness.Image = My.Resources.expt49
        End If
        If valu_happiness.Value = 50 Then
            Icon_happiness.Image = My.Resources.expt50
        End If
        If valu_happiness.Value = 51 Then
            Icon_happiness.Image = My.Resources.expt51
        End If
        If valu_happiness.Value = 52 Then
            Icon_happiness.Image = My.Resources.expt52
        End If
        If valu_happiness.Value = 53 Then
            Icon_happiness.Image = My.Resources.expt53
        End If
        If valu_happiness.Value = 54 Then
            Icon_happiness.Image = My.Resources.expt54
        End If
        If valu_happiness.Value = 55 Then
            Icon_happiness.Image = My.Resources.expt55
        End If
        If valu_happiness.Value = 56 Then
            Icon_happiness.Image = My.Resources.expt56
        End If
        If valu_happiness.Value = 57 Then
            Icon_happiness.Image = My.Resources.expt57
        End If
        If valu_happiness.Value = 58 Then
            Icon_happiness.Image = My.Resources.expt58
        End If
        If valu_happiness.Value = 59 Then
            Icon_happiness.Image = My.Resources.expt59
        End If
        If valu_happiness.Value = 60 Then
            Icon_happiness.Image = My.Resources.expt60
        End If
        If valu_happiness.Value = 61 Then
            Icon_happiness.Image = My.Resources.expt61
        End If
        If valu_happiness.Value = 62 Then
            Icon_happiness.Image = My.Resources.expt62
        End If
        If valu_happiness.Value = 63 Then
            Icon_happiness.Image = My.Resources.expt63
        End If
        If valu_happiness.Value = 64 Then
            Icon_happiness.Image = My.Resources.expt64
        End If
        If valu_happiness.Value = 65 Then
            Icon_happiness.Image = My.Resources.expt65
        End If
        If valu_happiness.Value = 66 Then
            Icon_happiness.Image = My.Resources.expt66
        End If
        If valu_happiness.Value = 67 Then
            Icon_happiness.Image = My.Resources.expt67
        End If
        If valu_happiness.Value = 68 Then
            Icon_happiness.Image = My.Resources.expt68
        End If
        If valu_happiness.Value = 69 Then
            Icon_happiness.Image = My.Resources.expt69
        End If
        If valu_happiness.Value = 70 Then
            Icon_happiness.Image = My.Resources.expt70
        End If
        If valu_happiness.Value = 71 Then
            Icon_happiness.Image = My.Resources.expt71
        End If
        If valu_happiness.Value = 72 Then
            Icon_happiness.Image = My.Resources.expt72
        End If
        If valu_happiness.Value = 73 Then
            Icon_happiness.Image = My.Resources.expt73
        End If
        If valu_happiness.Value = 74 Then
            Icon_happiness.Image = My.Resources.expt74
        End If
        If valu_happiness.Value = 75 Then
            Icon_happiness.Image = My.Resources.expt75
        End If
        If valu_happiness.Value = 76 Then
            Icon_happiness.Image = My.Resources.expt76
        End If
        If valu_happiness.Value = 77 Then
            Icon_happiness.Image = My.Resources.expt77
        End If
        If valu_happiness.Value = 78 Then
            Icon_happiness.Image = My.Resources.expt78
        End If
        If valu_happiness.Value = 79 Then
            Icon_happiness.Image = My.Resources.expt79
        End If
        If valu_happiness.Value = 80 Then
            Icon_happiness.Image = My.Resources.expt80
        End If
        If valu_happiness.Value = 81 Then
            Icon_happiness.Image = My.Resources.expt81
        End If
        If valu_happiness.Value = 82 Then
            Icon_happiness.Image = My.Resources.expt82
        End If
        If valu_happiness.Value = 83 Then
            Icon_happiness.Image = My.Resources.expt83
        End If
        If valu_happiness.Value = 84 Then
            Icon_happiness.Image = My.Resources.expt84
        End If
        If valu_happiness.Value = 85 Then
            Icon_happiness.Image = My.Resources.expt85
        End If
        If valu_happiness.Value = 86 Then
            Icon_happiness.Image = My.Resources.expt86
        End If
        If valu_happiness.Value = 87 Then
            Icon_happiness.Image = My.Resources.expt87
        End If
        If valu_happiness.Value = 88 Then
            Icon_happiness.Image = My.Resources.expt88
        End If
        If valu_happiness.Value = 89 Then
            Icon_happiness.Image = My.Resources.expt89
        End If
        If valu_happiness.Value = 90 Then
            Icon_happiness.Image = My.Resources.expt90
        End If
        If valu_happiness.Value = 91 Then
            Icon_happiness.Image = My.Resources.expt91
        End If
        If valu_happiness.Value = 92 Then
            Icon_happiness.Image = My.Resources.expt92
        End If
        If valu_happiness.Value = 93 Then
            Icon_happiness.Image = My.Resources.expt93
        End If
        If valu_happiness.Value = 94 Then
            Icon_happiness.Image = My.Resources.expt94
        End If
        If valu_happiness.Value = 95 Then
            Icon_happiness.Image = My.Resources.expt95
        End If
        If valu_happiness.Value = 96 Then
            Icon_happiness.Image = My.Resources.expt96
        End If
        If valu_happiness.Value = 97 Then
            Icon_happiness.Image = My.Resources.expt97
        End If
        If valu_happiness.Value = 98 Then
            Icon_happiness.Image = My.Resources.expt98
        End If
        If valu_happiness.Value = 99 Then
            Icon_happiness.Image = My.Resources.expt99
        End If
    End Sub

    Private Sub valu_onisland_ValueChanged(sender As Object, e As EventArgs) Handles valu_onisland.ValueChanged
        If valu_onisland.Value = 0 Then
            Select_onisland.SelectedItem = Select_onisland.Items.Item(0)
        ElseIf valu_onisland.Value = 1 Then
            Select_onisland.SelectedItem = Select_onisland.Items.Item(1)
        End If
    End Sub

    Private Sub valu_pitchtent_ValueChanged(sender As Object, e As EventArgs) Handles valu_pitchtent.ValueChanged
        If valu_pitchtent.Value = 0 Then
            Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(0)
        ElseIf valu_pitchtent.Value = 1 Then
            Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(1)
        End If
    End Sub

    Private Sub valu_permissionpitch_ValueChanged(sender As Object, e As EventArgs) Handles valu_permissionpitch.ValueChanged
        If valu_permissionpitch.Value = 0 Then
            Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(0)
        ElseIf valu_permissionpitch.Value = 1 Then
            Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(1)
        End If
    End Sub

    Private Sub valu_departport_ValueChanged(sender As Object, e As EventArgs) Handles valu_departport.ValueChanged
        If valu_departport.Value = 0 Then
            Select_departport.SelectedItem = Select_departport.Items.Item(0)
        ElseIf valu_departport.Value = 1 Then
            Select_departport.SelectedItem = Select_departport.Items.Item(1)
        End If
    End Sub

    Private Sub valu_visibleport_ValueChanged(sender As Object, e As EventArgs) Handles valu_visibleport.ValueChanged
        If valu_visibleport.Value = 0 Then
            Select_visibleport.SelectedItem = Select_visibleport.Items.Item(0)
        ElseIf valu_visibleport.Value = 1 Then
            Select_visibleport.SelectedItem = Select_visibleport.Items.Item(1)
        End If
    End Sub

    Private Sub valu_newicon_ValueChanged(sender As Object, e As EventArgs) Handles valu_newicon.ValueChanged
        If valu_newicon.Value = 0 Then
            Select_newicon.SelectedItem = Select_newicon.Items.Item(0)
        ElseIf valu_newicon.Value = 1 Then
            Select_newicon.SelectedItem = Select_newicon.Items.Item(1)
        End If
    End Sub

    Private Sub valu_wandering_ValueChanged(sender As Object, e As EventArgs) Handles valu_wandering.ValueChanged
        If valu_wandering.Value = 0 Then
            Select_wandering.SelectedItem = Select_wandering.Items.Item(0)
        ElseIf valu_wandering.Value = 1 Then
            Select_wandering.SelectedItem = Select_wandering.Items.Item(1)
        End If
    End Sub

    Private Sub valu_startconversation_ValueChanged(sender As Object, e As EventArgs) Handles valu_startconversation.ValueChanged
        If valu_startconversation.Value = 0 Then
            Select_startconversation.SelectedItem = Select_startconversation.Items.Item(0)
        ElseIf valu_startconversation.Value = 1 Then
            Select_startconversation.SelectedItem = Select_startconversation.Items.Item(1)
        End If
    End Sub

    Private Sub valu_justarrive_ValueChanged(sender As Object, e As EventArgs) Handles valu_justarrive.ValueChanged
        If valu_justarrive.Value = 0 Then
            Select_justarrive.SelectedItem = Select_justarrive.Items.Item(0)
        ElseIf valu_justarrive.Value = 1 Then
            Select_justarrive.SelectedItem = Select_justarrive.Items.Item(1)
        End If
    End Sub

    Private Sub Select_onisland_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_onisland.SelectedIndexChanged
        If Select_onisland.SelectedItem = Select_onisland.Items.Item(0) Then
            valu_onisland.Value = 0
        ElseIf Select_onisland.SelectedItem = Select_onisland.Items.Item(1) Then
            valu_onisland.Value = 1
        End If
    End Sub

    Private Sub Select_pitchtent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_pitchtent.SelectedIndexChanged
        If Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(0) Then
            valu_pitchtent.Value = 0
        ElseIf Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(1) Then
            valu_pitchtent.Value = 1
        End If
    End Sub

    Private Sub Select_permissionpitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_permissionpitch.SelectedIndexChanged
        If Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(0) Then
            valu_permissionpitch.Value = 0
        ElseIf Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(1) Then
            valu_permissionpitch.Value = 1
        End If
    End Sub

    Private Sub Select_departport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_departport.SelectedIndexChanged
        If Select_departport.SelectedItem = Select_departport.Items.Item(0) Then
            valu_departport.Value = 0
        ElseIf Select_departport.SelectedItem = Select_departport.Items.Item(1) Then
            valu_departport.Value = 1
        End If
    End Sub

    Private Sub Select_visibleport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_visibleport.SelectedIndexChanged
        If Select_visibleport.SelectedItem = Select_visibleport.Items.Item(0) Then
            valu_visibleport.Value = 0
        ElseIf Select_visibleport.SelectedItem = Select_visibleport.Items.Item(1) Then
            valu_visibleport.Value = 1
        End If
    End Sub

    Private Sub Select_newicon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_newicon.SelectedIndexChanged
        If Select_newicon.SelectedItem = Select_newicon.Items.Item(0) Then
            valu_newicon.Value = 0
        ElseIf Select_newicon.SelectedItem = Select_newicon.Items.Item(1) Then
            valu_newicon.Value = 1
        End If
    End Sub

    Private Sub Select_wandering_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_wandering.SelectedIndexChanged
        If Select_wandering.SelectedItem = Select_wandering.Items.Item(0) Then
            valu_wandering.Value = 0
        ElseIf Select_wandering.SelectedItem = Select_wandering.Items.Item(1) Then
            valu_wandering.Value = 1
        End If
    End Sub

    Private Sub Select_startconversation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_startconversation.SelectedIndexChanged
        If Select_startconversation.SelectedItem = Select_startconversation.Items.Item(0) Then
            valu_startconversation.Value = 0
        ElseIf Select_startconversation.SelectedItem = Select_startconversation.Items.Item(1) Then
            valu_startconversation.Value = 1
        End If
    End Sub

    Private Sub Select_justarrive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_justarrive.SelectedIndexChanged
        If Select_justarrive.SelectedItem = Select_justarrive.Items.Item(0) Then
            valu_justarrive.Value = 0
        ElseIf Select_justarrive.SelectedItem = Select_justarrive.Items.Item(1) Then
            valu_justarrive.Value = 1
        End If
    End Sub

    Private Sub Button_wandering_Click(sender As Object, e As EventArgs) Handles Button_wandering.Click
        valu_lastdatetraveler.Value = valu_lastsavedate.Value
        valu_onisland.Value = 1
        valu_pitchtent.Value = 1
        valu_permissionpitch.Value = 2
        valu_departport.Value = 0
        valu_visibleport.Value = 0
        valu_newicon.Value = 0
        valu_wandering.Value = 1
        valu_startconversation.Value = 0
        valu_justarrive.Value = 0
    End Sub

    Private Sub Button_pitchtent_Click(sender As Object, e As EventArgs) Handles Button_pitchtent.Click
        valu_lastdatetraveler.Value = valu_lastsavedate.Value
        valu_onisland.Value = 1
        valu_pitchtent.Value = 1
        valu_permissionpitch.Value = 4
        valu_departport.Value = 0
        valu_visibleport.Value = 0
        valu_newicon.Value = 0
        valu_wandering.Value = 1
        valu_startconversation.Value = 1
        valu_justarrive.Value = 0
    End Sub

    Private Sub Select_mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_mii.SelectedIndexChanged
        Select_departport.SelectedItem = Select_departport.Items.Item(0)
        Select_justarrive.SelectedItem = Select_justarrive.Items.Item(0)
        Select_newicon.SelectedItem = Select_newicon.Items.Item(0)
        Select_onisland.SelectedItem = Select_onisland.Items.Item(0)
        Select_permissionpitch.SelectedItem = Select_permissionpitch.Items.Item(0)
        Select_pitchtent.SelectedItem = Select_pitchtent.Items.Item(0)
        Select_startconversation.SelectedItem = Select_startconversation.Items.Item(0)
        Select_visibleport.SelectedItem = Select_visibleport.Items.Item(0)
        Select_wandering.SelectedItem = Select_wandering.Items.Item(0)
        Select_where.SelectedItem = Select_where.Items.Item(0)
        Readtravelers()
    End Sub

    Public Sub Readtravelers()
        Try
            Dim ReadMii As New PackageIO.Reader(savedataArc, PackageIO.Endian.Little)
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                ReadMii.Position = name_1
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_1
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_1
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_1
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_1
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_1
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_1
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_1
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_1
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_1
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_1
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_1
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_1
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_1
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_1
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_1
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                ReadMii.Position = name_2
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_2
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_2
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_2
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_2
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_2
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_2
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_2
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_2
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_2
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_2
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_2
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_2
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_2
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_2
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_2
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                ReadMii.Position = name_3
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_3
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_3
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_3
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_3
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_3
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_3
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_3
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_3
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_3
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_3
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_3
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_3
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_3
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_3
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_3
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                ReadMii.Position = name_4
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_4
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_4
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_4
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_4
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_4
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_4
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_4
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_4
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_4
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_4
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_4
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_4
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_4
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_4
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_4
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                ReadMii.Position = name_5
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_5
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_5
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_5
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_5
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_5
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_5
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_5
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_5
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_5
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_5
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_5
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_5
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_5
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_5
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_5
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                ReadMii.Position = name_6
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_6
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_6
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_6
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_6
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_6
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_6
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_6
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_6
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_6
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_6
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_6
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_6
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_6
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_6
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_6
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                ReadMii.Position = name_7
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_7
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_7
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_7
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_7
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_7
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_7
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_7
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_7
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_7
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_7
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_7
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_7
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_7
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_7
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_7
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                ReadMii.Position = name_8
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_8
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_8
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_8
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_8
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_8
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_8
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_8
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_8
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_8
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_8
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_8
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_8
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_8
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_8
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_8
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                ReadMii.Position = name_9
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_9
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_9
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_9
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_9
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_9
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_9
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_9
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_9
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_9
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_9
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_9
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_9
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_9
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_9
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_9
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                ReadMii.Position = name_10
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_10
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_10
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_10
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_10
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_10
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_10
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_10
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_10
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_10
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_10
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_10
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_10
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_10
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_10
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_10
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                ReadMii.Position = name_11
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_11
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_11
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_11
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_11
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_11
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_11
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_11
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_11
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_11
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_11
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_11
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_11
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_11
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_11
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_11
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                ReadMii.Position = name_12
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_12
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_12
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_12
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_12
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_12
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_12
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_12
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_12
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_12
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_12
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_12
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_12
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_12
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_12
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_12
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                ReadMii.Position = name_13
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_13
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_13
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_13
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_13
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_13
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_13
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_13
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_13
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_13
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_13
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_13
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_13
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_13
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_13
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_13
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                ReadMii.Position = name_14
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_14
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_14
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_14
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_14
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_14
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_14
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_14
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_14
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_14
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_14
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_14
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_14
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_14
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_14
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_14
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                ReadMii.Position = name_15
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_15
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_15
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_15
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_15
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_15
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_15
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_15
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_15
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_15
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_15
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_15
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_15
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_15
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_15
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_15
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                ReadMii.Position = name_16
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_16
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_16
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_16
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_16
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_16
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_16
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_16
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_16
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_16
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_16
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_16
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_16
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_16
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_16
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_16
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                ReadMii.Position = name_17
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_17
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_17
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_17
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_17
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_17
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_17
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_17
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_17
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_17
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_17
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_17
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_17
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_17
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_17
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_17
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                ReadMii.Position = name_18
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_18
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_18
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_18
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_18
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_18
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_18
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_18
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_18
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_18
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_18
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_18
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_18
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_18
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_18
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_18
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                ReadMii.Position = name_19
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_19
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_19
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_19
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_19
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_19
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_19
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_19
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_19
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_19
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_19
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_19
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_19
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_19
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_19
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_19
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                ReadMii.Position = name_20
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_20
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_20
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_20
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_20
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_20
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_20
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_20
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_20
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_20
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_20
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_20
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_20
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_20
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_20
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_20
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                ReadMii.Position = name_21
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_21
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_21
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_21
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_21
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_21
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_21
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_21
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_21
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_21
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_21
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_21
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_21
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_21
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_21
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_21
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                ReadMii.Position = name_22
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_22
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_22
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_22
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_22
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_22
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_22
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_22
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_22
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_22
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_22
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_22
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_22
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_22
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_22
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_22
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                ReadMii.Position = name_23
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_23
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_23
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_23
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_23
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_23
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_23
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_23
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_23
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_23
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_23
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_23
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_23
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_23
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_23
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_23
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                ReadMii.Position = name_24
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_24
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_24
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_24
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_24
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_24
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_24
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_24
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_24
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_24
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_24
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_24
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_24
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_24
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_24
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_24
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                ReadMii.Position = name_25
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_25
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_25
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_25
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_25
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_25
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_25
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_25
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_25
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_25
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_25
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_25
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_25
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_25
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_25
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_25
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                ReadMii.Position = name_26
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_26
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_26
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_26
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_26
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_26
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_26
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_26
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_26
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_26
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_26
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_26
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_26
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_26
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_26
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_26
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                ReadMii.Position = name_27
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_27
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_27
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_27
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_27
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_27
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_27
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_27
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_27
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_27
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_27
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_27
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_27
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_27
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_27
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_27
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                ReadMii.Position = name_28
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_28
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_28
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_28
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_28
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_28
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_28
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_28
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_28
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_28
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_28
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_28
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_28
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_28
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_28
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_28
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                ReadMii.Position = name_29
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_29
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_29
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_29
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_29
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_29
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_29
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_29
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_29
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_29
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_29
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_29
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_29
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_29
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_29
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_29
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                ReadMii.Position = name_30
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_30
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_30
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_30
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_30
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_30
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_30
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_30
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_30
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_30
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_30
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_30
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_30
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_30
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_30
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_30
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                ReadMii.Position = name_31
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_31
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_31
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_31
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_31
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_31
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_31
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_31
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_31
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_31
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_31
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_31
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_31
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_31
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_31
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_31
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                ReadMii.Position = name_32
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_32
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_32
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_32
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_32
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_32
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_32
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_32
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_32
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_32
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_32
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_32
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_32
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_32
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_32
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_32
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                ReadMii.Position = name_33
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_33
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_33
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_33
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_33
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_33
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_33
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_33
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_33
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_33
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_33
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_33
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_33
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_33
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_33
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_33
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                ReadMii.Position = name_34
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_34
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_34
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_34
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_34
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_34
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_34
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_34
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_34
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_34
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_34
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_34
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_34
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_34
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_34
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_34
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                ReadMii.Position = name_35
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_35
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_35
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_35
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_35
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_35
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_35
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_35
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_35
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_35
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_35
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_35
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_35
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_35
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_35
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_35
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                ReadMii.Position = name_36
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_36
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_36
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_36
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_36
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_36
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_36
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_36
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_36
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_36
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_36
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_36
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_36
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_36
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_36
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_36
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                ReadMii.Position = name_37
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_37
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_37
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_37
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_37
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_37
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_37
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_37
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_37
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_37
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_37
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_37
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_37
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_37
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_37
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_37
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                ReadMii.Position = name_38
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_38
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_38
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_38
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_38
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_38
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_38
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_38
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_38
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_38
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_38
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_38
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_38
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_38
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_38
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_38
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                ReadMii.Position = name_39
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_39
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_39
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_39
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_39
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_39
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_39
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_39
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_39
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_39
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_39
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_39
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_39
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_39
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_39
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_39
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                ReadMii.Position = name_40
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_40
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_40
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_40
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_40
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_40
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_40
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_40
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_40
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_40
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_40
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_40
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_40
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_40
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_40
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_40
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                ReadMii.Position = name_41
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_41
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_41
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_41
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_41
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_41
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_41
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_41
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_41
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_41
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_41
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_41
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_41
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_41
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_41
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_41
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                ReadMii.Position = name_42
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_42
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_42
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_42
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_42
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_42
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_42
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_42
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_42
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_42
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_42
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_42
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_42
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_42
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_42
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_42
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                ReadMii.Position = name_43
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_43
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_43
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_43
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_43
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_43
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_43
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_43
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_43
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_43
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_43
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_43
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_43
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_43
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_43
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_43
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                ReadMii.Position = name_44
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_44
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_44
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_44
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_44
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_44
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_44
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_44
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_44
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_44
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_44
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_44
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_44
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_44
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_44
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_44
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                ReadMii.Position = name_45
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_45
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_45
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_45
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_45
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_45
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_45
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_45
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_45
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_45
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_45
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_45
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_45
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_45
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_45
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_45
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                ReadMii.Position = name_46
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_46
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_46
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_46
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_46
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_46
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_46
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_46
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_46
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_46
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_46
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_46
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_46
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_46
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_46
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_46
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                ReadMii.Position = name_47
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_47
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_47
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_47
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_47
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_47
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_47
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_47
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_47
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_47
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_47
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_47
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_47
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_47
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_47
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_47
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                ReadMii.Position = name_48
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_48
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_48
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_48
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_48
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_48
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_48
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_48
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_48
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_48
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_48
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_48
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_48
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_48
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_48
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_48
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                ReadMii.Position = name_49
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_49
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_49
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_49
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_49
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_49
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_49
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_49
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_49
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_49
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_49
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_49
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_49
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_49
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_49
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_49
                valu_level.Value = ReadMii.ReadByte
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                ReadMii.Position = name_50
                Text_travelersname.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = message_50
                Text_travelermessage.Text = ReadMii.ReadUnicodeString(10)
                ReadMii.Position = datetravelers_50
                valu_lastdatetraveler.Value = ReadMii.ReadUInt32
                ReadMii.Position = where_50
                valu_where.Value = ReadMii.ReadByte
                ReadMii.Position = onisland_50
                valu_onisland.Value = ReadMii.ReadByte
                ReadMii.Position = tent_50
                valu_tent.Value = ReadMii.ReadByte
                ReadMii.Position = pitchtent_50
                valu_pitchtent.Value = ReadMii.ReadByte
                ReadMii.Position = permissionpitch_50
                valu_permissionpitch.Value = ReadMii.ReadByte
                ReadMii.Position = departport_50
                valu_departport.Value = ReadMii.ReadByte
                ReadMii.Position = visibleport_50
                valu_visibleport.Value = ReadMii.ReadByte
                ReadMii.Position = newicon_50
                valu_newicon.Value = ReadMii.ReadByte
                ReadMii.Position = wandering_50
                valu_wandering.Value = ReadMii.ReadByte
                ReadMii.Position = startconversation_50
                valu_startconversation.Value = ReadMii.ReadByte
                ReadMii.Position = justarrive_50
                valu_justarrive.Value = ReadMii.ReadByte
                ReadMii.Position = experience_50
                valu_happiness.Value = ReadMii.ReadByte
                ReadMii.Position = level_50
                valu_level.Value = ReadMii.ReadByte
            End If
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to read this travelers status"
            TLSE_dialog.ShowDialog()
        End Try
    End Sub

    Public Sub Writetravelers()
        Try
            If Select_mii.SelectedItem = Select_mii.Items.Item(0) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_1
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_1
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_1
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_1
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_1
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_1
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_1
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_1
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_1
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_1
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_1
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_1
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_1
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_1
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_1
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_1
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(1) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_2 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_2
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_2 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_2
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_2
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_2
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_2
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_2
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_2
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_2
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_2
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_2
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_2
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_2
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_2
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_2
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_2
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_2
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(2) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_3 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_3
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_3 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_3
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_3
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_3
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_3
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_3
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_3
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_3
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_3
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_3
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_3
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_3
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_3
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_3
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_3
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_3
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(3) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_4 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_4
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_4 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_4
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_4
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_4
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_4
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_4
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_4
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_4
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_4
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_4
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_4
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_4
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_4
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_4
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_4
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_4
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(4) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_5 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_5
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_5 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_5
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_5
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_5
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_5
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_5
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_5
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_5
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_5
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_5
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_5
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_5
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_5
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_5
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_5
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_5
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(5) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_6 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_6
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_6 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_6
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_6
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_6
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_6
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_6
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_6
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_6
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_6
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_6
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_6
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_6
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_6
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_6
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_6
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_6
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(6) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_7 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_7
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_7 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_7
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_7
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_7
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_7
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_7
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_7
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_7
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_7
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_7
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_7
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_7
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_7
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_7
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_7
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_7
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(7) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_8 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_8
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_8 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_8
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_8
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_8
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_8
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_8
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_8
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_8
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_8
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_8
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_8
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_8
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_8
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_8
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_8
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_8
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(8) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_9 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_9
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_9 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_9
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_9
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_9
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_9
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_9
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_9
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_9
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_9
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_9
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_9
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_9
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_9
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_9
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_9
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_9
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(9) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_10 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_10
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_10 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_10
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_10
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_10
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_10
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_10
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_10
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_10
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_10
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_10
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_10
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_10
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_10
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_10
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_10
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_10
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(10) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_11 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_11
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_11 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_11
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_11
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_11
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_11
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_11
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_11
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_11
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_11
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_11
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_11
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_11
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_11
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_11
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_11
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_11
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(11) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_12 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_12
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_12 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_12
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_12
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_12
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_12
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_12
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_12
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_12
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_12
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_12
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_12
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_12
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_12
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_12
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_12
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_12
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(12) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_13 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_13
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_13 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_13
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_13
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_13
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_13
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_13
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_13
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_13
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_13
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_13
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_13
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_13
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_13
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_13
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_13
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_13
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(13) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_14 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_14
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_14 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_14
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_14
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_14
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_14
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_14
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_14
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_14
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_14
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_14
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_14
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_14
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_14
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_14
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_14
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_14
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(14) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_15 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_15
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_15 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_15
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_15
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_15
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_15
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_15
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_15
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_15
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_15
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_15
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_15
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_15
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_15
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_15
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_15
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_15
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(15) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_16 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_16
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_16 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_16
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_16
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_16
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_16
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_16
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_16
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_16
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_16
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_16
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_16
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_16
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_16
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_16
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_16
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_16
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(16) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_17 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_17
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_17 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_17
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_17
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_17
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_17
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_17
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_17
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_17
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_17
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_17
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_17
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_17
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_17
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_17
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_17
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_17
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(17) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_18 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_18
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_18 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_18
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_18
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_18
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_18
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_18
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_18
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_18
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_18
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_18
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_18
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_18
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_18
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_18
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_18
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_18
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(18) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_19 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_19
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_19 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_19
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_19
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_19
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_19
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_19
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_19
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_19
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_19
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_19
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_19
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_19
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_19
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_19
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_19
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_19
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(19) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_20 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_20
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_20 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_20
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_20
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_20
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_20
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_20
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_20
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_20
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_20
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_20
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_20
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_20
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_20
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_20
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_20
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_20
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(20) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_21 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_21
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_21 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_21
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_21
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_21
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_21
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_21
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_21
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_21
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_21
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_21
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_21
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_21
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_21
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_21
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_21
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_21
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(21) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_22 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_22
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_22 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_22
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_22
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_22
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_22
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_22
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_22
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_22
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_22
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_22
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_22
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_22
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_22
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_22
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_22
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_22
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(22) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_23 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_23
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_23 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_23
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_23
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_23
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_23
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_23
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_23
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_23
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_23
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_23
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_23
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_23
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_23
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_23
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_23
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_23
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(23) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_24 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_24
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_24 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_24
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_24
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_24
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_24
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_24
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_24
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_24
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_24
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_24
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_24
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_24
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_24
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_24
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_24
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_24
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(24) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_25 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_25
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_25 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_25
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_25
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_25
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_25
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_25
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_25
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_25
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_25
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_25
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_25
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_25
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_25
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_25
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_25
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_25
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(25) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_26 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_26
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_26 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_26
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_26
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_26
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_26
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_26
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_26
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_26
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_26
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_26
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_26
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_26
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_26
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_26
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_26
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_26
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(26) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_27 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_27
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_27 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_27
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_27
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_27
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_27
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_27
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_27
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_27
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_27
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_27
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_27
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_27
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_27
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_27
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_27
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_27
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(27) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_28 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_28
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_28 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_28
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_28
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_28
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_28
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_28
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_28
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_28
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_28
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_28
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_28
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_28
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_28
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_28
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_28
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_28
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(28) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_29 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_29
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_29 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_29
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_29
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_29
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_29
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_29
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_29
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_29
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_29
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_29
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_29
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_29
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_29
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_29
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_29
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_29
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(29) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_30 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_30
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_30 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_30
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_30
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_30
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_30
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_30
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_30
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_30
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_30
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_30
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_30
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_30
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_30
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_30
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_30
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_30
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(30) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_31 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_31
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_31 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_31
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_31
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_31
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_31
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_31
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_31
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_31
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_31
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_31
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_31
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_31
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_31
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_31
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_31
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_31
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(31) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_32 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_32
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_32 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_32
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_32
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_32
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_32
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_32
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_32
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_32
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_32
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_32
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_32
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_32
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_32
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_32
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_32
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_32
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(32) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_33 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_33
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_33 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_33
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_33
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_33
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_33
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_33
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_33
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_33
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_33
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_33
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_33
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_33
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_33
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_33
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_33
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_33
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(33) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_34 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_34
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_34 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_34
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_34
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_34
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_34
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_34
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_34
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_34
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_34
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_34
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_34
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_34
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_34
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_34
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_34
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_34
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(34) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_35 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_35
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_35 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_35
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_35
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_35
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_35
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_35
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_35
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_35
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_35
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_35
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_35
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_35
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_35
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_35
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_35
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_35
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(35) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_36 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_36
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_36 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_36
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_36
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_36
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_36
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_36
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_36
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_36
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_36
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_36
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_36
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_36
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_36
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_36
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_36
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_36
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(36) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_37 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_37
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_37 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_37
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_37
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_37
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_37
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_37
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_37
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_37
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_37
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_37
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_37
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_37
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_37
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_37
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_37
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_37
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(37) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_38 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_38
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_38 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_38
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_38
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_38
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_38
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_38
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_38
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_38
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_38
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_38
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_38
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_38
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_38
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_38
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_38
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_38
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(38) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_39 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_39
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_39 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_39
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_39
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_39
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_39
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_39
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_39
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_39
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_39
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_39
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_39
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_39
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_39
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_39
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_39
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_39
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(39) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_40 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_40
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_40 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_40
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_40
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_40
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_40
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_40
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_40
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_40
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_40
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_40
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_40
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_40
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_40
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_40
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_40
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_40
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(40) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_41 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_41
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_41 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_41
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_41
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_41
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_41
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_41
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_41
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_41
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_41
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_41
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_41
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_41
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_41
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_41
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_41
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_41
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(41) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_42 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_42
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_42 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_42
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_42
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_42
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_42
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_42
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_42
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_42
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_42
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_42
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_42
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_42
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_42
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_42
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_42
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_42
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(42) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_43 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_43
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_43 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_43
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_43
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_43
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_43
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_43
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_43
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_43
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_43
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_43
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_43
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_43
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_43
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_43
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_43
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_43
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(43) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_44 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_44
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_44 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_44
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_44
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_44
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_44
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_44
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_44
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_44
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_44
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_44
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_44
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_44
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_44
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_44
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_44
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_44
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(44) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_45 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_45
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_45 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_45
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_45
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_45
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_45
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_45
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_45
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_45
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_45
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_45
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_45
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_45
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_45
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_45
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_45
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_45
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(45) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_46 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_46
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_46 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_46
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_46
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_46
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_46
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_46
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_46
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_46
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_46
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_46
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_46
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_46
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_46
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_46
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_46
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_46
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(46) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_47 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_47
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_47 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_47
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_47
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_47
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_47
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_47
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_47
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_47
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_47
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_47
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_47
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_47
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_47
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_47
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_47
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_47
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(47) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_48 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_48
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_48 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_48
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_48
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_48
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_48
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_48
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_48
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_48
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_48
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_48
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_48
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_48
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_48
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_48
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_48
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_48
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(48) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_49 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_49
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_49 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_49
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_49
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_49
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_49
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_49
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_49
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_49
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_49
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_49
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_49
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_49
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_49
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_49
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_49
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_49
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            If Select_mii.SelectedItem = Select_mii.Items.Item(49) Then
                Dim Writer As New PackageIO.Writer(savedataArc, PackageIO.Endian.Little)
                For i As Integer = 0 To 19
                    Writer.Position = name_50 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = name_50
                Writer.WriteUnicodeString(Text_travelersname.Text)
                For i As Integer = 0 To 19
                    Writer.Position = message_50 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = message_50
                Writer.WriteUnicodeString(Text_travelermessage.Text)
                Writer.Position = datetravelers_50
                Writer.WriteUInt32(valu_lastdatetraveler.Value)
                Writer.Flush()

                Dim fs As New FileStream(savedataArc, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                fs.Position = where_50
                fs.WriteByte(valu_where.Value)
                fs.Position = onisland_50
                fs.WriteByte(valu_onisland.Value)
                fs.Position = tent_50
                fs.WriteByte(valu_tent.Value)
                fs.Position = pitchtent_50
                fs.WriteByte(valu_pitchtent.Value)
                fs.Position = permissionpitch_50
                fs.WriteByte(valu_permissionpitch.Value)
                fs.Position = departport_50
                fs.WriteByte(valu_departport.Value)
                fs.Position = visibleport_50
                fs.WriteByte(valu_visibleport.Value)
                fs.Position = newicon_50
                fs.WriteByte(valu_newicon.Value)
                fs.Position = wandering_50
                fs.WriteByte(valu_wandering.Value)
                fs.Position = startconversation_50
                fs.WriteByte(valu_startconversation.Value)
                fs.Position = justarrive_50
                fs.WriteByte(valu_justarrive.Value)
                fs.Position = experience_50
                fs.WriteByte(valu_happiness.Value)
                fs.Position = level_50
                fs.WriteByte(valu_level.Value)
                fs.Flush()
            End If
            TLSE_dialog.Text_TLSE_dialog.Text = "Traveler status has been successfully edited"
            TLSE_dialog.ShowDialog()
        Catch ex As Exception
            TLSE_dialog.Text_TLSE_dialog.Text = "Failed to edit this traveler status"
            TLSE_dialog.ShowDialog()
        End Try

    End Sub

    Private Sub Text_menu_save_Click(sender As Object, e As EventArgs) Handles Text_menu_save.Click
        Writetravelers()
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_travelersedit.Visible = True
        Me.Close()
    End Sub

    Private Sub Menuflow_text_itemsedition_Click(sender As Object, e As EventArgs) Handles Menuflow_text_itemsedition.Click
        If TLSE_logo_update.Visible = True Then
            TLSE_hub.TLSE_logo_update.Visible = True
        End If
        TLSE_hub.Show()
        TLSE_hub.Filever_text.Text = Filever_text.Text
        TLSE_hub.TLSE_filepath.Text = TLSE_filepath.Text
        TLSE_hub.TLSE_menu.Visible = False
        TLSE_hub.TLSE_menu_travelersedit.Visible = True
        Me.Close()
    End Sub

End Class