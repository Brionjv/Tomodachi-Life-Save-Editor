Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(0) Then
            PictureBox2.BackgroundImage = My.Resources.tomoF1
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(1) Then
            PictureBox2.BackgroundImage = My.Resources.tomoF
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(2) Then
            PictureBox2.BackgroundImage = My.Resources.tomoJ
        End If
        If Form1.ComboBox12.SelectedItem = Form1.ComboBox12.Items.Item(3) Then
            PictureBox2.BackgroundImage = My.Resources.tomoK
        End If
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Done"
            Label1.Location = New Point(183, 268)
            Label8.Text = "Gifts"
            ComboBox3.Items.Item(0) = "(None)"
            ComboBox3.Items.Item(1) = "Ballet manual"
            ComboBox3.Items.Item(2) = "Baseball bat"
            ComboBox3.Items.Item(3) = "Beauty kit"
            ComboBox3.Items.Item(4) = "Book"
            ComboBox3.Items.Item(5) = "Bubble blower"
            ComboBox3.Items.Item(6) = "CD"
            ComboBox3.Items.Item(7) = "Cell phone"
            ComboBox3.Items.Item(8) = "Fishing pole"
            ComboBox3.Items.Item(9) = "Golf club"
            ComboBox3.Items.Item(10) = "Guitar"
            ComboBox3.Items.Item(11) = "Hula-dancing manual"
            ComboBox3.Items.Item(12) = "Kite"
            ComboBox3.Items.Item(13) = "Laptop"
            ComboBox3.Items.Item(14) = "Maracas"
            ComboBox3.Items.Item(15) = "Metal detector"
            ComboBox3.Items.Item(16) = "Mirror"
            ComboBox3.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox3.Items.Item(18) = "Punching bag"
            ComboBox3.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox3.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox3.Items.Item(21) = "Scale"
            ComboBox3.Items.Item(22) = "Skateboard"
            ComboBox3.Items.Item(23) = "Soccer ball"
            ComboBox3.Items.Item(24) = "Study kit"
            ComboBox3.Items.Item(25) = "Tennis racket"
            ComboBox3.Items.Item(26) = "Treadmill"
            ComboBox3.Items.Item(27) = "Wii U"
            ComboBox3.Items.Item(28) = "Yoga manual"
            ComboBox4.Items.Item(0) = "(None)"
            ComboBox4.Items.Item(1) = "Ballet manual"
            ComboBox4.Items.Item(2) = "Baseball bat"
            ComboBox4.Items.Item(3) = "Beauty kit"
            ComboBox4.Items.Item(4) = "Book"
            ComboBox4.Items.Item(5) = "Bubble blower"
            ComboBox4.Items.Item(6) = "CD"
            ComboBox4.Items.Item(7) = "Cell phone"
            ComboBox4.Items.Item(8) = "Fishing pole"
            ComboBox4.Items.Item(9) = "Golf club"
            ComboBox4.Items.Item(10) = "Guitar"
            ComboBox4.Items.Item(11) = "Hula-dancing manual"
            ComboBox4.Items.Item(12) = "Kite"
            ComboBox4.Items.Item(13) = "Laptop"
            ComboBox4.Items.Item(14) = "Maracas"
            ComboBox4.Items.Item(15) = "Metal detector"
            ComboBox4.Items.Item(16) = "Mirror"
            ComboBox4.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox4.Items.Item(18) = "Punching bag"
            ComboBox4.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox4.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox4.Items.Item(21) = "Scale"
            ComboBox4.Items.Item(22) = "Skateboard"
            ComboBox4.Items.Item(23) = "Soccer ball"
            ComboBox4.Items.Item(24) = "Study kit"
            ComboBox4.Items.Item(25) = "Tennis racket"
            ComboBox4.Items.Item(26) = "Treadmill"
            ComboBox4.Items.Item(27) = "Wii U"
            ComboBox4.Items.Item(28) = "Yoga manual"
            ComboBox5.Items.Item(0) = "(None)"
            ComboBox5.Items.Item(1) = "Ballet manual"
            ComboBox5.Items.Item(2) = "Baseball bat"
            ComboBox5.Items.Item(3) = "Beauty kit"
            ComboBox5.Items.Item(4) = "Book"
            ComboBox5.Items.Item(5) = "Bubble blower"
            ComboBox5.Items.Item(6) = "CD"
            ComboBox5.Items.Item(7) = "Cell phone"
            ComboBox5.Items.Item(8) = "Fishing pole"
            ComboBox5.Items.Item(9) = "Golf club"
            ComboBox5.Items.Item(10) = "Guitar"
            ComboBox5.Items.Item(11) = "Hula-dancing manual"
            ComboBox5.Items.Item(12) = "Kite"
            ComboBox5.Items.Item(13) = "Laptop"
            ComboBox5.Items.Item(14) = "Maracas"
            ComboBox5.Items.Item(15) = "Metal detector"
            ComboBox5.Items.Item(16) = "Mirror"
            ComboBox5.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox5.Items.Item(18) = "Punching bag"
            ComboBox5.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox5.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox5.Items.Item(21) = "Scale"
            ComboBox5.Items.Item(22) = "Skateboard"
            ComboBox5.Items.Item(23) = "Soccer ball"
            ComboBox5.Items.Item(24) = "Study kit"
            ComboBox5.Items.Item(25) = "Tennis racket"
            ComboBox5.Items.Item(26) = "Treadmill"
            ComboBox5.Items.Item(27) = "Wii U"
            ComboBox5.Items.Item(28) = "Yoga manual"
            ComboBox6.Items.Item(0) = "(None)"
            ComboBox6.Items.Item(1) = "Ballet manual"
            ComboBox6.Items.Item(2) = "Baseball bat"
            ComboBox6.Items.Item(3) = "Beauty kit"
            ComboBox6.Items.Item(4) = "Book"
            ComboBox6.Items.Item(5) = "Bubble blower"
            ComboBox6.Items.Item(6) = "CD"
            ComboBox6.Items.Item(7) = "Cell phone"
            ComboBox6.Items.Item(8) = "Fishing pole"
            ComboBox6.Items.Item(9) = "Golf club"
            ComboBox6.Items.Item(10) = "Guitar"
            ComboBox6.Items.Item(11) = "Hula-dancing manual"
            ComboBox6.Items.Item(12) = "Kite"
            ComboBox6.Items.Item(13) = "Laptop"
            ComboBox6.Items.Item(14) = "Maracas"
            ComboBox6.Items.Item(15) = "Metal detector"
            ComboBox6.Items.Item(16) = "Mirror"
            ComboBox6.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox6.Items.Item(18) = "Punching bag"
            ComboBox6.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox6.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox6.Items.Item(21) = "Scale"
            ComboBox6.Items.Item(22) = "Skateboard"
            ComboBox6.Items.Item(23) = "Soccer ball"
            ComboBox6.Items.Item(24) = "Study kit"
            ComboBox6.Items.Item(25) = "Tennis racket"
            ComboBox6.Items.Item(26) = "Treadmill"
            ComboBox6.Items.Item(27) = "Wii U"
            ComboBox6.Items.Item(28) = "Yoga manual"
            ComboBox7.Items.Item(0) = "(None)"
            ComboBox7.Items.Item(1) = "Ballet manual"
            ComboBox7.Items.Item(2) = "Baseball bat"
            ComboBox7.Items.Item(3) = "Beauty kit"
            ComboBox7.Items.Item(4) = "Book"
            ComboBox7.Items.Item(5) = "Bubble blower"
            ComboBox7.Items.Item(6) = "CD"
            ComboBox7.Items.Item(7) = "Cell phone"
            ComboBox7.Items.Item(8) = "Fishing pole"
            ComboBox7.Items.Item(9) = "Golf club"
            ComboBox7.Items.Item(10) = "Guitar"
            ComboBox7.Items.Item(11) = "Hula-dancing manual"
            ComboBox7.Items.Item(12) = "Kite"
            ComboBox7.Items.Item(13) = "Laptop"
            ComboBox7.Items.Item(14) = "Maracas"
            ComboBox7.Items.Item(15) = "Metal detector"
            ComboBox7.Items.Item(16) = "Mirror"
            ComboBox7.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox7.Items.Item(18) = "Punching bag"
            ComboBox7.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox7.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox7.Items.Item(21) = "Scale"
            ComboBox7.Items.Item(22) = "Skateboard"
            ComboBox7.Items.Item(23) = "Soccer ball"
            ComboBox7.Items.Item(24) = "Study kit"
            ComboBox7.Items.Item(25) = "Tennis racket"
            ComboBox7.Items.Item(26) = "Treadmill"
            ComboBox7.Items.Item(27) = "Wii U"
            ComboBox7.Items.Item(28) = "Yoga manual"
            ComboBox8.Items.Item(0) = "(None)"
            ComboBox8.Items.Item(1) = "Ballet manual"
            ComboBox8.Items.Item(2) = "Baseball bat"
            ComboBox8.Items.Item(3) = "Beauty kit"
            ComboBox8.Items.Item(4) = "Book"
            ComboBox8.Items.Item(5) = "Bubble blower"
            ComboBox8.Items.Item(6) = "CD"
            ComboBox8.Items.Item(7) = "Cell phone"
            ComboBox8.Items.Item(8) = "Fishing pole"
            ComboBox8.Items.Item(9) = "Golf club"
            ComboBox8.Items.Item(10) = "Guitar"
            ComboBox8.Items.Item(11) = "Hula-dancing manual"
            ComboBox8.Items.Item(12) = "Kite"
            ComboBox8.Items.Item(13) = "Laptop"
            ComboBox8.Items.Item(14) = "Maracas"
            ComboBox8.Items.Item(15) = "Metal detector"
            ComboBox8.Items.Item(16) = "Mirror"
            ComboBox8.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox8.Items.Item(18) = "Punching bag"
            ComboBox8.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox8.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox8.Items.Item(21) = "Scale"
            ComboBox8.Items.Item(22) = "Skateboard"
            ComboBox8.Items.Item(23) = "Soccer ball"
            ComboBox8.Items.Item(24) = "Study kit"
            ComboBox8.Items.Item(25) = "Tennis racket"
            ComboBox8.Items.Item(26) = "Treadmill"
            ComboBox8.Items.Item(27) = "Wii U"
            ComboBox8.Items.Item(28) = "Yoga manual"
            ComboBox9.Items.Item(0) = "(None)"
            ComboBox9.Items.Item(1) = "Ballet manual"
            ComboBox9.Items.Item(2) = "Baseball bat"
            ComboBox9.Items.Item(3) = "Beauty kit"
            ComboBox9.Items.Item(4) = "Book"
            ComboBox9.Items.Item(5) = "Bubble blower"
            ComboBox9.Items.Item(6) = "CD"
            ComboBox9.Items.Item(7) = "Cell phone"
            ComboBox9.Items.Item(8) = "Fishing pole"
            ComboBox9.Items.Item(9) = "Golf club"
            ComboBox9.Items.Item(10) = "Guitar"
            ComboBox9.Items.Item(11) = "Hula-dancing manual"
            ComboBox9.Items.Item(12) = "Kite"
            ComboBox9.Items.Item(13) = "Laptop"
            ComboBox9.Items.Item(14) = "Maracas"
            ComboBox9.Items.Item(15) = "Metal detector"
            ComboBox9.Items.Item(16) = "Mirror"
            ComboBox9.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox9.Items.Item(18) = "Punching bag"
            ComboBox9.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox9.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox9.Items.Item(21) = "Scale"
            ComboBox9.Items.Item(22) = "Skateboard"
            ComboBox9.Items.Item(23) = "Soccer ball"
            ComboBox9.Items.Item(24) = "Study kit"
            ComboBox9.Items.Item(25) = "Tennis racket"
            ComboBox9.Items.Item(26) = "Treadmill"
            ComboBox9.Items.Item(27) = "Wii U"
            ComboBox9.Items.Item(28) = "Yoga manual"
            ComboBox10.Items.Item(0) = "(None)"
            ComboBox10.Items.Item(1) = "Ballet manual"
            ComboBox10.Items.Item(2) = "Baseball bat"
            ComboBox10.Items.Item(3) = "Beauty kit"
            ComboBox10.Items.Item(4) = "Book"
            ComboBox10.Items.Item(5) = "Bubble blower"
            ComboBox10.Items.Item(6) = "CD"
            ComboBox10.Items.Item(7) = "Cell phone"
            ComboBox10.Items.Item(8) = "Fishing pole"
            ComboBox10.Items.Item(9) = "Golf club"
            ComboBox10.Items.Item(10) = "Guitar"
            ComboBox10.Items.Item(11) = "Hula-dancing manual"
            ComboBox10.Items.Item(12) = "Kite"
            ComboBox10.Items.Item(13) = "Laptop"
            ComboBox10.Items.Item(14) = "Maracas"
            ComboBox10.Items.Item(15) = "Metal detector"
            ComboBox10.Items.Item(16) = "Mirror"
            ComboBox10.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox10.Items.Item(18) = "Punching bag"
            ComboBox10.Items.Item(19) = "Rent-a-cat coupon"
            ComboBox10.Items.Item(20) = "Rent-a-dog coupon"
            ComboBox10.Items.Item(21) = "Scale"
            ComboBox10.Items.Item(22) = "Skateboard"
            ComboBox10.Items.Item(23) = "Soccer ball"
            ComboBox10.Items.Item(24) = "Study kit"
            ComboBox10.Items.Item(25) = "Tennis racket"
            ComboBox10.Items.Item(26) = "Treadmill"
            ComboBox10.Items.Item(27) = "Wii U"
            ComboBox10.Items.Item(28) = "Yoga manual"
        End If
        If Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Enregistrer"
            Label1.Location = New Point(171, 268)
            Label8.Text = "Objets"
            ComboBox3.Items.Item(0) = "(Aucun)"
            ComboBox3.Items.Item(1) = "Manuel de ballet"
            ComboBox3.Items.Item(2) = "Batte de base-ball"
            ComboBox3.Items.Item(3) = "Kit de beauté"
            ComboBox3.Items.Item(4) = "Livre"
            ComboBox3.Items.Item(5) = "Savon à bulles"
            ComboBox3.Items.Item(6) = "CD"
            ComboBox3.Items.Item(7) = "Téléphone portable"
            ComboBox3.Items.Item(8) = "Canne à pêche"
            ComboBox3.Items.Item(9) = "Club de golf"
            ComboBox3.Items.Item(10) = "Guitare"
            ComboBox3.Items.Item(11) = "Manuel de danse hula"
            ComboBox3.Items.Item(12) = "Cerf-volant"
            ComboBox3.Items.Item(13) = "Ordinateur portable"
            ComboBox3.Items.Item(14) = "Paire de maracas"
            ComboBox3.Items.Item(15) = "Détecteur de métaux"
            ComboBox3.Items.Item(16) = "Miroir"
            ComboBox3.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox3.Items.Item(18) = "Sac de frappe"
            ComboBox3.Items.Item(19) = "Bon pour un chat"
            ComboBox3.Items.Item(20) = "Bon pour un chien"
            ComboBox3.Items.Item(21) = "Pèse-personne"
            ComboBox3.Items.Item(22) = "Skateboard"
            ComboBox3.Items.Item(23) = "Ballon de foot"
            ComboBox3.Items.Item(24) = "Kit d’études"
            ComboBox3.Items.Item(25) = "Raquette de tennis"
            ComboBox3.Items.Item(26) = "Tapis de course"
            ComboBox3.Items.Item(27) = "Wii U"
            ComboBox3.Items.Item(28) = "Manuel de yoga"
            ComboBox4.Items.Item(0) = "(Aucun)"
            ComboBox4.Items.Item(1) = "Manuel de ballet"
            ComboBox4.Items.Item(2) = "Batte de base-ball"
            ComboBox4.Items.Item(3) = "Kit de beauté"
            ComboBox4.Items.Item(4) = "Livre"
            ComboBox4.Items.Item(5) = "Savon à bulles"
            ComboBox4.Items.Item(6) = "CD"
            ComboBox4.Items.Item(7) = "Téléphone portable"
            ComboBox4.Items.Item(8) = "Canne à pêche"
            ComboBox4.Items.Item(9) = "Club de golf"
            ComboBox4.Items.Item(10) = "Guitare"
            ComboBox4.Items.Item(11) = "Manuel de danse hula"
            ComboBox4.Items.Item(12) = "Cerf-volant"
            ComboBox4.Items.Item(13) = "Ordinateur portable"
            ComboBox4.Items.Item(14) = "Paire de maracas"
            ComboBox4.Items.Item(15) = "Détecteur de métaux"
            ComboBox4.Items.Item(16) = "Miroir"
            ComboBox4.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox4.Items.Item(18) = "Sac de frappe"
            ComboBox4.Items.Item(19) = "Bon pour un chat"
            ComboBox4.Items.Item(20) = "Bon pour un chien"
            ComboBox4.Items.Item(21) = "Pèse-personne"
            ComboBox4.Items.Item(22) = "Skateboard"
            ComboBox4.Items.Item(23) = "Ballon de foot"
            ComboBox4.Items.Item(24) = "Kit d’études"
            ComboBox4.Items.Item(25) = "Raquette de tennis"
            ComboBox4.Items.Item(26) = "Tapis de course"
            ComboBox4.Items.Item(27) = "Wii U"
            ComboBox4.Items.Item(28) = "Manuel de yoga"
            ComboBox5.Items.Item(0) = "(Aucun)"
            ComboBox5.Items.Item(1) = "Manuel de ballet"
            ComboBox5.Items.Item(2) = "Batte de base-ball"
            ComboBox5.Items.Item(3) = "Kit de beauté"
            ComboBox5.Items.Item(4) = "Livre"
            ComboBox5.Items.Item(5) = "Savon à bulles"
            ComboBox5.Items.Item(6) = "CD"
            ComboBox5.Items.Item(7) = "Téléphone portable"
            ComboBox5.Items.Item(8) = "Canne à pêche"
            ComboBox5.Items.Item(9) = "Club de golf"
            ComboBox5.Items.Item(10) = "Guitare"
            ComboBox5.Items.Item(11) = "Manuel de danse hula"
            ComboBox5.Items.Item(12) = "Cerf-volant"
            ComboBox5.Items.Item(13) = "Ordinateur portable"
            ComboBox5.Items.Item(14) = "Paire de maracas"
            ComboBox5.Items.Item(15) = "Détecteur de métaux"
            ComboBox5.Items.Item(16) = "Miroir"
            ComboBox5.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox5.Items.Item(18) = "Sac de frappe"
            ComboBox5.Items.Item(19) = "Bon pour un chat"
            ComboBox5.Items.Item(20) = "Bon pour un chien"
            ComboBox5.Items.Item(21) = "Pèse-personne"
            ComboBox5.Items.Item(22) = "Skateboard"
            ComboBox5.Items.Item(23) = "Ballon de foot"
            ComboBox5.Items.Item(24) = "Kit d’études"
            ComboBox5.Items.Item(25) = "Raquette de tennis"
            ComboBox5.Items.Item(26) = "Tapis de course"
            ComboBox5.Items.Item(27) = "Wii U"
            ComboBox5.Items.Item(28) = "Manuel de yoga"
            ComboBox6.Items.Item(0) = "(Aucun)"
            ComboBox6.Items.Item(1) = "Manuel de ballet"
            ComboBox6.Items.Item(2) = "Batte de base-ball"
            ComboBox6.Items.Item(3) = "Kit de beauté"
            ComboBox6.Items.Item(4) = "Livre"
            ComboBox6.Items.Item(5) = "Savon à bulles"
            ComboBox6.Items.Item(6) = "CD"
            ComboBox6.Items.Item(7) = "Téléphone portable"
            ComboBox6.Items.Item(8) = "Canne à pêche"
            ComboBox6.Items.Item(9) = "Club de golf"
            ComboBox6.Items.Item(10) = "Guitare"
            ComboBox6.Items.Item(11) = "Manuel de danse hula"
            ComboBox6.Items.Item(12) = "Cerf-volant"
            ComboBox6.Items.Item(13) = "Ordinateur portable"
            ComboBox6.Items.Item(14) = "Paire de maracas"
            ComboBox6.Items.Item(15) = "Détecteur de métaux"
            ComboBox6.Items.Item(16) = "Miroir"
            ComboBox6.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox6.Items.Item(18) = "Sac de frappe"
            ComboBox6.Items.Item(19) = "Bon pour un chat"
            ComboBox6.Items.Item(20) = "Bon pour un chien"
            ComboBox6.Items.Item(21) = "Pèse-personne"
            ComboBox6.Items.Item(22) = "Skateboard"
            ComboBox6.Items.Item(23) = "Ballon de foot"
            ComboBox6.Items.Item(24) = "Kit d’études"
            ComboBox6.Items.Item(25) = "Raquette de tennis"
            ComboBox6.Items.Item(26) = "Tapis de course"
            ComboBox6.Items.Item(27) = "Wii U"
            ComboBox6.Items.Item(28) = "Manuel de yoga"
            ComboBox7.Items.Item(0) = "(Aucun)"
            ComboBox7.Items.Item(1) = "Manuel de ballet"
            ComboBox7.Items.Item(2) = "Batte de base-ball"
            ComboBox7.Items.Item(3) = "Kit de beauté"
            ComboBox7.Items.Item(4) = "Livre"
            ComboBox7.Items.Item(5) = "Savon à bulles"
            ComboBox7.Items.Item(6) = "CD"
            ComboBox7.Items.Item(7) = "Téléphone portable"
            ComboBox7.Items.Item(8) = "Canne à pêche"
            ComboBox7.Items.Item(9) = "Club de golf"
            ComboBox7.Items.Item(10) = "Guitare"
            ComboBox7.Items.Item(11) = "Manuel de danse hula"
            ComboBox7.Items.Item(12) = "Cerf-volant"
            ComboBox7.Items.Item(13) = "Ordinateur portable"
            ComboBox7.Items.Item(14) = "Paire de maracas"
            ComboBox7.Items.Item(15) = "Détecteur de métaux"
            ComboBox7.Items.Item(16) = "Miroir"
            ComboBox7.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox7.Items.Item(18) = "Sac de frappe"
            ComboBox7.Items.Item(19) = "Bon pour un chat"
            ComboBox7.Items.Item(20) = "Bon pour un chien"
            ComboBox7.Items.Item(21) = "Pèse-personne"
            ComboBox7.Items.Item(22) = "Skateboard"
            ComboBox7.Items.Item(23) = "Ballon de foot"
            ComboBox7.Items.Item(24) = "Kit d’études"
            ComboBox7.Items.Item(25) = "Raquette de tennis"
            ComboBox7.Items.Item(26) = "Tapis de course"
            ComboBox7.Items.Item(27) = "Wii U"
            ComboBox7.Items.Item(28) = "Manuel de yoga"
            ComboBox8.Items.Item(0) = "(Aucun)"
            ComboBox8.Items.Item(1) = "Manuel de ballet"
            ComboBox8.Items.Item(2) = "Batte de base-ball"
            ComboBox8.Items.Item(3) = "Kit de beauté"
            ComboBox8.Items.Item(4) = "Livre"
            ComboBox8.Items.Item(5) = "Savon à bulles"
            ComboBox8.Items.Item(6) = "CD"
            ComboBox8.Items.Item(7) = "Téléphone portable"
            ComboBox8.Items.Item(8) = "Canne à pêche"
            ComboBox8.Items.Item(9) = "Club de golf"
            ComboBox8.Items.Item(10) = "Guitare"
            ComboBox8.Items.Item(11) = "Manuel de danse hula"
            ComboBox8.Items.Item(12) = "Cerf-volant"
            ComboBox8.Items.Item(13) = "Ordinateur portable"
            ComboBox8.Items.Item(14) = "Paire de maracas"
            ComboBox8.Items.Item(15) = "Détecteur de métaux"
            ComboBox8.Items.Item(16) = "Miroir"
            ComboBox8.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox8.Items.Item(18) = "Sac de frappe"
            ComboBox8.Items.Item(19) = "Bon pour un chat"
            ComboBox8.Items.Item(20) = "Bon pour un chien"
            ComboBox8.Items.Item(21) = "Pèse-personne"
            ComboBox8.Items.Item(22) = "Skateboard"
            ComboBox8.Items.Item(23) = "Ballon de foot"
            ComboBox8.Items.Item(24) = "Kit d’études"
            ComboBox8.Items.Item(25) = "Raquette de tennis"
            ComboBox8.Items.Item(26) = "Tapis de course"
            ComboBox8.Items.Item(27) = "Wii U"
            ComboBox8.Items.Item(28) = "Manuel de yoga"
            ComboBox9.Items.Item(0) = "(Aucun)"
            ComboBox9.Items.Item(1) = "Manuel de ballet"
            ComboBox9.Items.Item(2) = "Batte de base-ball"
            ComboBox9.Items.Item(3) = "Kit de beauté"
            ComboBox9.Items.Item(4) = "Livre"
            ComboBox9.Items.Item(5) = "Savon à bulles"
            ComboBox9.Items.Item(6) = "CD"
            ComboBox9.Items.Item(7) = "Téléphone portable"
            ComboBox9.Items.Item(8) = "Canne à pêche"
            ComboBox9.Items.Item(9) = "Club de golf"
            ComboBox9.Items.Item(10) = "Guitare"
            ComboBox9.Items.Item(11) = "Manuel de danse hula"
            ComboBox9.Items.Item(12) = "Cerf-volant"
            ComboBox9.Items.Item(13) = "Ordinateur portable"
            ComboBox9.Items.Item(14) = "Paire de maracas"
            ComboBox9.Items.Item(15) = "Détecteur de métaux"
            ComboBox9.Items.Item(16) = "Miroir"
            ComboBox9.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox9.Items.Item(18) = "Sac de frappe"
            ComboBox9.Items.Item(19) = "Bon pour un chat"
            ComboBox9.Items.Item(20) = "Bon pour un chien"
            ComboBox9.Items.Item(21) = "Pèse-personne"
            ComboBox9.Items.Item(22) = "Skateboard"
            ComboBox9.Items.Item(23) = "Ballon de foot"
            ComboBox9.Items.Item(24) = "Kit d’études"
            ComboBox9.Items.Item(25) = "Raquette de tennis"
            ComboBox9.Items.Item(26) = "Tapis de course"
            ComboBox9.Items.Item(27) = "Wii U"
            ComboBox9.Items.Item(28) = "Manuel de yoga"
            ComboBox10.Items.Item(0) = "(Aucun)"
            ComboBox10.Items.Item(1) = "Manuel de ballet"
            ComboBox10.Items.Item(2) = "Batte de base-ball"
            ComboBox10.Items.Item(3) = "Kit de beauté"
            ComboBox10.Items.Item(4) = "Livre"
            ComboBox10.Items.Item(5) = "Savon à bulles"
            ComboBox10.Items.Item(6) = "CD"
            ComboBox10.Items.Item(7) = "Téléphone portable"
            ComboBox10.Items.Item(8) = "Canne à pêche"
            ComboBox10.Items.Item(9) = "Club de golf"
            ComboBox10.Items.Item(10) = "Guitare"
            ComboBox10.Items.Item(11) = "Manuel de danse hula"
            ComboBox10.Items.Item(12) = "Cerf-volant"
            ComboBox10.Items.Item(13) = "Ordinateur portable"
            ComboBox10.Items.Item(14) = "Paire de maracas"
            ComboBox10.Items.Item(15) = "Détecteur de métaux"
            ComboBox10.Items.Item(16) = "Miroir"
            ComboBox10.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox10.Items.Item(18) = "Sac de frappe"
            ComboBox10.Items.Item(19) = "Bon pour un chat"
            ComboBox10.Items.Item(20) = "Bon pour un chien"
            ComboBox10.Items.Item(21) = "Pèse-personne"
            ComboBox10.Items.Item(22) = "Skateboard"
            ComboBox10.Items.Item(23) = "Ballon de foot"
            ComboBox10.Items.Item(24) = "Kit d’études"
            ComboBox10.Items.Item(25) = "Raquette de tennis"
            ComboBox10.Items.Item(26) = "Tapis de course"
            ComboBox10.Items.Item(27) = "Wii U"
            ComboBox10.Items.Item(28) = "Manuel de yoga"
        End If
        If Form1.ComboBox11.Text = "DE" Then
            Label1.Text = "Fertig"
            Label1.Location = New Point(183, 268)
            Label8.Text = "Geschenke"
            ComboBox3.Items.Item(0) = "nichts"
            ComboBox3.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox3.Items.Item(2) = "Baseballschläger"
            ComboBox3.Items.Item(3) = "Schminkset"
            ComboBox3.Items.Item(4) = "Buch"
            ComboBox3.Items.Item(5) = "Seifenblasen"
            ComboBox3.Items.Item(6) = "CD"
            ComboBox3.Items.Item(7) = "Mobiltelefon"
            ComboBox3.Items.Item(8) = "Angelrute"
            ComboBox3.Items.Item(9) = "Golfschläger"
            ComboBox3.Items.Item(10) = "Gitarre"
            ComboBox3.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox3.Items.Item(12) = "Kite"
            ComboBox3.Items.Item(13) = "Laptop"
            ComboBox3.Items.Item(14) = "Maracas"
            ComboBox3.Items.Item(15) = "Metalldetektor"
            ComboBox3.Items.Item(16) = "Spiegel"
            ComboBox3.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox3.Items.Item(18) = "Sandsack"
            ComboBox3.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox3.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox3.Items.Item(21) = "Waage"
            ComboBox3.Items.Item(22) = "Skateboard"
            ComboBox3.Items.Item(23) = "Fußball"
            ComboBox3.Items.Item(24) = "Lernset"
            ComboBox3.Items.Item(25) = "Tennisschläger"
            ComboBox3.Items.Item(26) = "Laufband"
            ComboBox3.Items.Item(27) = "Wii U"
            ComboBox3.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox4.Items.Item(0) = "nichts"
            ComboBox4.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox4.Items.Item(2) = "Baseballschläger"
            ComboBox4.Items.Item(3) = "Schminkset"
            ComboBox4.Items.Item(4) = "Buch"
            ComboBox4.Items.Item(5) = "Seifenblasen"
            ComboBox4.Items.Item(6) = "CD"
            ComboBox4.Items.Item(7) = "Mobiltelefon"
            ComboBox4.Items.Item(8) = "Angelrute"
            ComboBox4.Items.Item(9) = "Golfschläger"
            ComboBox4.Items.Item(10) = "Gitarre"
            ComboBox4.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox4.Items.Item(12) = "Kite"
            ComboBox4.Items.Item(13) = "Laptop"
            ComboBox4.Items.Item(14) = "Maracas"
            ComboBox4.Items.Item(15) = "Metalldetektor"
            ComboBox4.Items.Item(16) = "Spiegel"
            ComboBox4.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox4.Items.Item(18) = "Sandsack"
            ComboBox4.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox4.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox4.Items.Item(21) = "Waage"
            ComboBox4.Items.Item(22) = "Skateboard"
            ComboBox4.Items.Item(23) = "Fußball"
            ComboBox4.Items.Item(24) = "Lernset"
            ComboBox4.Items.Item(25) = "Tennisschläger"
            ComboBox4.Items.Item(26) = "Laufband"
            ComboBox4.Items.Item(27) = "Wii U"
            ComboBox4.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox5.Items.Item(0) = "nichts"
            ComboBox5.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox5.Items.Item(2) = "Baseballschläger"
            ComboBox5.Items.Item(3) = "Schminkset"
            ComboBox5.Items.Item(4) = "Buch"
            ComboBox5.Items.Item(5) = "Seifenblasen"
            ComboBox5.Items.Item(6) = "CD"
            ComboBox5.Items.Item(7) = "Mobiltelefon"
            ComboBox5.Items.Item(8) = "Angelrute"
            ComboBox5.Items.Item(9) = "Golfschläger"
            ComboBox5.Items.Item(10) = "Gitarre"
            ComboBox5.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox5.Items.Item(12) = "Kite"
            ComboBox5.Items.Item(13) = "Laptop"
            ComboBox5.Items.Item(14) = "Maracas"
            ComboBox5.Items.Item(15) = "Metalldetektor"
            ComboBox5.Items.Item(16) = "Spiegel"
            ComboBox5.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox5.Items.Item(18) = "Sandsack"
            ComboBox5.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox5.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox5.Items.Item(21) = "Waage"
            ComboBox5.Items.Item(22) = "Skateboard"
            ComboBox5.Items.Item(23) = "Fußball"
            ComboBox5.Items.Item(24) = "Lernset"
            ComboBox5.Items.Item(25) = "Tennisschläger"
            ComboBox5.Items.Item(26) = "Laufband"
            ComboBox5.Items.Item(27) = "Wii U"
            ComboBox5.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox6.Items.Item(0) = "nichts"
            ComboBox6.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox6.Items.Item(2) = "Baseballschläger"
            ComboBox6.Items.Item(3) = "Schminkset"
            ComboBox6.Items.Item(4) = "Buch"
            ComboBox6.Items.Item(5) = "Seifenblasen"
            ComboBox6.Items.Item(6) = "CD"
            ComboBox6.Items.Item(7) = "Mobiltelefon"
            ComboBox6.Items.Item(8) = "Angelrute"
            ComboBox6.Items.Item(9) = "Golfschläger"
            ComboBox6.Items.Item(10) = "Gitarre"
            ComboBox6.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox6.Items.Item(12) = "Kite"
            ComboBox6.Items.Item(13) = "Laptop"
            ComboBox6.Items.Item(14) = "Maracas"
            ComboBox6.Items.Item(15) = "Metalldetektor"
            ComboBox6.Items.Item(16) = "Spiegel"
            ComboBox6.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox6.Items.Item(18) = "Sandsack"
            ComboBox6.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox6.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox6.Items.Item(21) = "Waage"
            ComboBox6.Items.Item(22) = "Skateboard"
            ComboBox6.Items.Item(23) = "Fußball"
            ComboBox6.Items.Item(24) = "Lernset"
            ComboBox6.Items.Item(25) = "Tennisschläger"
            ComboBox6.Items.Item(26) = "Laufband"
            ComboBox6.Items.Item(27) = "Wii U"
            ComboBox6.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox7.Items.Item(0) = "nichts"
            ComboBox7.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox7.Items.Item(2) = "Baseballschläger"
            ComboBox7.Items.Item(3) = "Schminkset"
            ComboBox7.Items.Item(4) = "Buch"
            ComboBox7.Items.Item(5) = "Seifenblasen"
            ComboBox7.Items.Item(6) = "CD"
            ComboBox7.Items.Item(7) = "Mobiltelefon"
            ComboBox7.Items.Item(8) = "Angelrute"
            ComboBox7.Items.Item(9) = "Golfschläger"
            ComboBox7.Items.Item(10) = "Gitarre"
            ComboBox7.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox7.Items.Item(12) = "Kite"
            ComboBox7.Items.Item(13) = "Laptop"
            ComboBox7.Items.Item(14) = "Maracas"
            ComboBox7.Items.Item(15) = "Metalldetektor"
            ComboBox7.Items.Item(16) = "Spiegel"
            ComboBox7.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox7.Items.Item(18) = "Sandsack"
            ComboBox7.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox7.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox7.Items.Item(21) = "Waage"
            ComboBox7.Items.Item(22) = "Skateboard"
            ComboBox7.Items.Item(23) = "Fußball"
            ComboBox7.Items.Item(24) = "Lernset"
            ComboBox7.Items.Item(25) = "Tennisschläger"
            ComboBox7.Items.Item(26) = "Laufband"
            ComboBox7.Items.Item(27) = "Wii U"
            ComboBox7.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox8.Items.Item(0) = "nichts"
            ComboBox8.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox8.Items.Item(2) = "Baseballschläger"
            ComboBox8.Items.Item(3) = "Schminkset"
            ComboBox8.Items.Item(4) = "Buch"
            ComboBox8.Items.Item(5) = "Seifenblasen"
            ComboBox8.Items.Item(6) = "CD"
            ComboBox8.Items.Item(7) = "Mobiltelefon"
            ComboBox8.Items.Item(8) = "Angelrute"
            ComboBox8.Items.Item(9) = "Golfschläger"
            ComboBox8.Items.Item(10) = "Gitarre"
            ComboBox8.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox8.Items.Item(12) = "Kite"
            ComboBox8.Items.Item(13) = "Laptop"
            ComboBox8.Items.Item(14) = "Maracas"
            ComboBox8.Items.Item(15) = "Metalldetektor"
            ComboBox8.Items.Item(16) = "Spiegel"
            ComboBox8.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox8.Items.Item(18) = "Sandsack"
            ComboBox8.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox8.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox8.Items.Item(21) = "Waage"
            ComboBox8.Items.Item(22) = "Skateboard"
            ComboBox8.Items.Item(23) = "Fußball"
            ComboBox8.Items.Item(24) = "Lernset"
            ComboBox8.Items.Item(25) = "Tennisschläger"
            ComboBox8.Items.Item(26) = "Laufband"
            ComboBox8.Items.Item(27) = "Wii U"
            ComboBox8.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox9.Items.Item(0) = "nichts"
            ComboBox9.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox9.Items.Item(2) = "Baseballschläger"
            ComboBox9.Items.Item(3) = "Schminkset"
            ComboBox9.Items.Item(4) = "Buch"
            ComboBox9.Items.Item(5) = "Seifenblasen"
            ComboBox9.Items.Item(6) = "CD"
            ComboBox9.Items.Item(7) = "Mobiltelefon"
            ComboBox9.Items.Item(8) = "Angelrute"
            ComboBox9.Items.Item(9) = "Golfschläger"
            ComboBox9.Items.Item(10) = "Gitarre"
            ComboBox9.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox9.Items.Item(12) = "Kite"
            ComboBox9.Items.Item(13) = "Laptop"
            ComboBox9.Items.Item(14) = "Maracas"
            ComboBox9.Items.Item(15) = "Metalldetektor"
            ComboBox9.Items.Item(16) = "Spiegel"
            ComboBox9.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox9.Items.Item(18) = "Sandsack"
            ComboBox9.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox9.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox9.Items.Item(21) = "Waage"
            ComboBox9.Items.Item(22) = "Skateboard"
            ComboBox9.Items.Item(23) = "Fußball"
            ComboBox9.Items.Item(24) = "Lernset"
            ComboBox9.Items.Item(25) = "Tennisschläger"
            ComboBox9.Items.Item(26) = "Laufband"
            ComboBox9.Items.Item(27) = "Wii U"
            ComboBox9.Items.Item(28) = "Yoga-Leitfaden"
            ComboBox10.Items.Item(0) = "nichts"
            ComboBox10.Items.Item(1) = "Ballett-Leitfaden"
            ComboBox10.Items.Item(2) = "Baseballschläger"
            ComboBox10.Items.Item(3) = "Schminkset"
            ComboBox10.Items.Item(4) = "Buch"
            ComboBox10.Items.Item(5) = "Seifenblasen"
            ComboBox10.Items.Item(6) = "CD"
            ComboBox10.Items.Item(7) = "Mobiltelefon"
            ComboBox10.Items.Item(8) = "Angelrute"
            ComboBox10.Items.Item(9) = "Golfschläger"
            ComboBox10.Items.Item(10) = "Gitarre"
            ComboBox10.Items.Item(11) = "Hulatanz-Leitfaden"
            ComboBox10.Items.Item(12) = "Kite"
            ComboBox10.Items.Item(13) = "Laptop"
            ComboBox10.Items.Item(14) = "Maracas"
            ComboBox10.Items.Item(15) = "Metalldetektor"
            ComboBox10.Items.Item(16) = "Spiegel"
            ComboBox10.Items.Item(17) = "Nintendo 3DS XL"
            ComboBox10.Items.Item(18) = "Sandsack"
            ComboBox10.Items.Item(19) = "Miezenmiet-Coupon"
            ComboBox10.Items.Item(20) = "Gassigeh-Gutschein"
            ComboBox10.Items.Item(21) = "Waage"
            ComboBox10.Items.Item(22) = "Skateboard"
            ComboBox10.Items.Item(23) = "Fußball"
            ComboBox10.Items.Item(24) = "Lernset"
            ComboBox10.Items.Item(25) = "Tennisschläger"
            ComboBox10.Items.Item(26) = "Laufband"
            ComboBox10.Items.Item(27) = "Wii U"
            ComboBox10.Items.Item(28) = "Yoga-Leitfaden"
        End If
        NumericUpDown11.Value = Form1.NumericUpDown11.Value
        NumericUpDown12.Value = Form1.NumericUpDown12.Value
        NumericUpDown13.Value = Form1.NumericUpDown13.Value
        NumericUpDown14.Value = Form1.NumericUpDown14.Value
        NumericUpDown15.Value = Form1.NumericUpDown15.Value
        NumericUpDown16.Value = Form1.NumericUpDown16.Value
        NumericUpDown17.Value = Form1.NumericUpDown17.Value
        NumericUpDown18.Value = Form1.NumericUpDown18.Value
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.NumericUpDown11.Value = My.Settings.objet1
        Form1.NumericUpDown12.Value = My.Settings.objet2
        Form1.NumericUpDown13.Value = My.Settings.objet3
        Form1.NumericUpDown14.Value = My.Settings.objet4
        Form1.NumericUpDown15.Value = My.Settings.objet5
        Form1.NumericUpDown16.Value = My.Settings.objet6
        Form1.NumericUpDown17.Value = My.Settings.objet7
        Form1.NumericUpDown18.Value = My.Settings.objet8
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        Form1.NumericUpDown11.Value = My.Settings.objet1
        Form1.NumericUpDown12.Value = My.Settings.objet2
        Form1.NumericUpDown13.Value = My.Settings.objet3
        Form1.NumericUpDown14.Value = My.Settings.objet4
        Form1.NumericUpDown15.Value = My.Settings.objet5
        Form1.NumericUpDown16.Value = My.Settings.objet6
        Form1.NumericUpDown17.Value = My.Settings.objet7
        Form1.NumericUpDown18.Value = My.Settings.objet8
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            NumericUpDown11.Value = 65535
            PictureBox17.Image = Nothing
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(7) Then
            NumericUpDown11.Value = 0
            PictureBox17.Image = My.Resources._0000
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(17) Then
            NumericUpDown11.Value = 1
            PictureBox17.Image = My.Resources._0100
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(24) Then
            NumericUpDown11.Value = 2
            PictureBox17.Image = My.Resources._0200
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(13) Then
            NumericUpDown11.Value = 3
            PictureBox17.Image = My.Resources._0300
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(6) Then
            NumericUpDown11.Value = 4
            PictureBox17.Image = My.Resources._0400
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
            NumericUpDown11.Value = 5
            PictureBox17.Image = My.Resources._0500
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(27) Then
            NumericUpDown11.Value = 6
            PictureBox17.Image = My.Resources._0600
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(28) Then
            NumericUpDown11.Value = 7
            PictureBox17.Image = My.Resources._0700
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(26) Then
            NumericUpDown11.Value = 8
            PictureBox17.Image = My.Resources._0800
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(16) Then
            NumericUpDown11.Value = 9
            PictureBox17.Image = My.Resources._0900
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(10) Then
            NumericUpDown11.Value = 10
            PictureBox17.Image = My.Resources._0a00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(14) Then
            NumericUpDown11.Value = 11
            PictureBox17.Image = My.Resources._0b00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(19) Then
            NumericUpDown11.Value = 12
            PictureBox17.Image = My.Resources._0c00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
            NumericUpDown11.Value = 13
            PictureBox17.Image = My.Resources._0d00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(21) Then
            NumericUpDown11.Value = 14
            PictureBox17.Image = My.Resources._0e00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            NumericUpDown11.Value = 15
            PictureBox17.Image = My.Resources._0f00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(11) Then
            NumericUpDown11.Value = 16
            PictureBox17.Image = My.Resources._1000
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(23) Then
            NumericUpDown11.Value = 17
            PictureBox17.Image = My.Resources._1100
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(8) Then
            NumericUpDown11.Value = 18
            PictureBox17.Image = My.Resources._1200
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            NumericUpDown11.Value = 19
            PictureBox17.Image = My.Resources._1300
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(5) Then
            NumericUpDown11.Value = 20
            PictureBox17.Image = My.Resources._1400
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(25) Then
            NumericUpDown11.Value = 21
            PictureBox17.Image = My.Resources._1500
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(9) Then
            NumericUpDown11.Value = 22
            PictureBox17.Image = My.Resources._1600
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(18) Then
            NumericUpDown11.Value = 23
            PictureBox17.Image = My.Resources._1700
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(20) Then
            NumericUpDown11.Value = 24
            PictureBox17.Image = My.Resources._1800
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(22) Then
            NumericUpDown11.Value = 25
            PictureBox17.Image = My.Resources._1900
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(12) Then
            NumericUpDown11.Value = 26
            PictureBox17.Image = My.Resources._1a00
        End If
        If ComboBox3.SelectedItem = ComboBox3.Items.Item(15) Then
            NumericUpDown11.Value = 27
            PictureBox17.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Then
            NumericUpDown12.Value = 65535
            PictureBox23.Image = Nothing
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(7) Then
            NumericUpDown12.Value = 0
            PictureBox23.Image = My.Resources._0000
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(17) Then
            NumericUpDown12.Value = 1
            PictureBox23.Image = My.Resources._0100
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(24) Then
            NumericUpDown12.Value = 2
            PictureBox23.Image = My.Resources._0200
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(13) Then
            NumericUpDown12.Value = 3
            PictureBox23.Image = My.Resources._0300
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(6) Then
            NumericUpDown12.Value = 4
            PictureBox23.Image = My.Resources._0400
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(4) Then
            NumericUpDown12.Value = 5
            PictureBox23.Image = My.Resources._0500
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(27) Then
            NumericUpDown12.Value = 6
            PictureBox23.Image = My.Resources._0600
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(28) Then
            NumericUpDown12.Value = 7
            PictureBox23.Image = My.Resources._0700
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(26) Then
            NumericUpDown12.Value = 8
            PictureBox23.Image = My.Resources._0800
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(16) Then
            NumericUpDown12.Value = 9
            PictureBox23.Image = My.Resources._0900
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(10) Then
            NumericUpDown12.Value = 10
            PictureBox23.Image = My.Resources._0a00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(14) Then
            NumericUpDown12.Value = 11
            PictureBox23.Image = My.Resources._0b00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(19) Then
            NumericUpDown12.Value = 12
            PictureBox23.Image = My.Resources._0c00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(3) Then
            NumericUpDown12.Value = 13
            PictureBox23.Image = My.Resources._0d00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(21) Then
            NumericUpDown12.Value = 14
            PictureBox23.Image = My.Resources._0e00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
            NumericUpDown12.Value = 15
            PictureBox23.Image = My.Resources._0f00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(11) Then
            NumericUpDown12.Value = 16
            PictureBox23.Image = My.Resources._1000
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(23) Then
            NumericUpDown12.Value = 17
            PictureBox23.Image = My.Resources._1100
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(8) Then
            NumericUpDown12.Value = 18
            PictureBox23.Image = My.Resources._1200
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
            NumericUpDown12.Value = 19
            PictureBox23.Image = My.Resources._1300
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(5) Then
            NumericUpDown12.Value = 20
            PictureBox23.Image = My.Resources._1400
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(25) Then
            NumericUpDown12.Value = 21
            PictureBox23.Image = My.Resources._1500
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(9) Then
            NumericUpDown12.Value = 22
            PictureBox23.Image = My.Resources._1600
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(18) Then
            NumericUpDown12.Value = 23
            PictureBox23.Image = My.Resources._1700
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(20) Then
            NumericUpDown12.Value = 24
            PictureBox23.Image = My.Resources._1800
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(22) Then
            NumericUpDown12.Value = 25
            PictureBox23.Image = My.Resources._1900
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(12) Then
            NumericUpDown12.Value = 26
            PictureBox23.Image = My.Resources._1a00
        End If
        If ComboBox4.SelectedItem = ComboBox4.Items.Item(15) Then
            NumericUpDown12.Value = 27
            PictureBox23.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(0) Then
            NumericUpDown13.Value = 65535
            PictureBox24.Image = Nothing
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(7) Then
            NumericUpDown13.Value = 0
            PictureBox24.Image = My.Resources._0000
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(17) Then
            NumericUpDown13.Value = 1
            PictureBox24.Image = My.Resources._0100
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(24) Then
            NumericUpDown13.Value = 2
            PictureBox24.Image = My.Resources._0200
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(13) Then
            NumericUpDown13.Value = 3
            PictureBox24.Image = My.Resources._0300
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(6) Then
            NumericUpDown13.Value = 4
            PictureBox24.Image = My.Resources._0400
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(4) Then
            NumericUpDown13.Value = 5
            PictureBox24.Image = My.Resources._0500
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(27) Then
            NumericUpDown13.Value = 6
            PictureBox24.Image = My.Resources._0600
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(28) Then
            NumericUpDown13.Value = 7
            PictureBox24.Image = My.Resources._0700
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(26) Then
            NumericUpDown13.Value = 8
            PictureBox24.Image = My.Resources._0800
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(16) Then
            NumericUpDown13.Value = 9
            PictureBox24.Image = My.Resources._0900
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(10) Then
            NumericUpDown13.Value = 10
            PictureBox24.Image = My.Resources._0a00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(14) Then
            NumericUpDown13.Value = 11
            PictureBox24.Image = My.Resources._0b00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(19) Then
            NumericUpDown13.Value = 12
            PictureBox24.Image = My.Resources._0c00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(3) Then
            NumericUpDown13.Value = 13
            PictureBox24.Image = My.Resources._0d00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(21) Then
            NumericUpDown13.Value = 14
            PictureBox24.Image = My.Resources._0e00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(1) Then
            NumericUpDown13.Value = 15
            PictureBox24.Image = My.Resources._0f00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(11) Then
            NumericUpDown13.Value = 16
            PictureBox24.Image = My.Resources._1000
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(23) Then
            NumericUpDown13.Value = 17
            PictureBox24.Image = My.Resources._1100
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(8) Then
            NumericUpDown13.Value = 18
            PictureBox24.Image = My.Resources._1200
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(2) Then
            NumericUpDown13.Value = 19
            PictureBox24.Image = My.Resources._1300
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(5) Then
            NumericUpDown13.Value = 20
            PictureBox24.Image = My.Resources._1400
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(25) Then
            NumericUpDown13.Value = 21
            PictureBox24.Image = My.Resources._1500
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(9) Then
            NumericUpDown13.Value = 22
            PictureBox24.Image = My.Resources._1600
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(18) Then
            NumericUpDown13.Value = 23
            PictureBox24.Image = My.Resources._1700
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(20) Then
            NumericUpDown13.Value = 24
            PictureBox24.Image = My.Resources._1800
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(22) Then
            NumericUpDown13.Value = 25
            PictureBox24.Image = My.Resources._1900
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(12) Then
            NumericUpDown13.Value = 26
            PictureBox24.Image = My.Resources._1a00
        End If
        If ComboBox6.SelectedItem = ComboBox6.Items.Item(15) Then
            NumericUpDown13.Value = 27
            PictureBox24.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(0) Then
            NumericUpDown14.Value = 65535
            PictureBox25.Image = Nothing
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(7) Then
            NumericUpDown14.Value = 0
            PictureBox25.Image = My.Resources._0000
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(17) Then
            NumericUpDown14.Value = 1
            PictureBox25.Image = My.Resources._0100
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(24) Then
            NumericUpDown14.Value = 2
            PictureBox25.Image = My.Resources._0200
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(13) Then
            NumericUpDown14.Value = 3
            PictureBox25.Image = My.Resources._0300
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(6) Then
            NumericUpDown14.Value = 4
            PictureBox25.Image = My.Resources._0400
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(4) Then
            NumericUpDown14.Value = 5
            PictureBox25.Image = My.Resources._0500
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(27) Then
            NumericUpDown14.Value = 6
            PictureBox25.Image = My.Resources._0600
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(28) Then
            NumericUpDown14.Value = 7
            PictureBox25.Image = My.Resources._0700
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(26) Then
            NumericUpDown14.Value = 8
            PictureBox25.Image = My.Resources._0800
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(16) Then
            NumericUpDown14.Value = 9
            PictureBox25.Image = My.Resources._0900
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(10) Then
            NumericUpDown14.Value = 10
            PictureBox25.Image = My.Resources._0a00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(14) Then
            NumericUpDown14.Value = 11
            PictureBox25.Image = My.Resources._0b00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(19) Then
            NumericUpDown14.Value = 12
            PictureBox25.Image = My.Resources._0c00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(3) Then
            NumericUpDown14.Value = 13
            PictureBox25.Image = My.Resources._0d00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(21) Then
            NumericUpDown14.Value = 14
            PictureBox25.Image = My.Resources._0e00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(1) Then
            NumericUpDown14.Value = 15
            PictureBox25.Image = My.Resources._0f00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(11) Then
            NumericUpDown14.Value = 16
            PictureBox25.Image = My.Resources._1000
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(23) Then
            NumericUpDown14.Value = 17
            PictureBox25.Image = My.Resources._1100
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(8) Then
            NumericUpDown14.Value = 18
            PictureBox25.Image = My.Resources._1200
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(2) Then
            NumericUpDown14.Value = 19
            PictureBox25.Image = My.Resources._1300
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(5) Then
            NumericUpDown14.Value = 20
            PictureBox25.Image = My.Resources._1400
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(25) Then
            NumericUpDown14.Value = 21
            PictureBox25.Image = My.Resources._1500
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(9) Then
            NumericUpDown14.Value = 22
            PictureBox25.Image = My.Resources._1600
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(18) Then
            NumericUpDown14.Value = 23
            PictureBox25.Image = My.Resources._1700
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(20) Then
            NumericUpDown14.Value = 24
            PictureBox25.Image = My.Resources._1800
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(22) Then
            NumericUpDown14.Value = 25
            PictureBox25.Image = My.Resources._1900
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(12) Then
            NumericUpDown14.Value = 26
            PictureBox25.Image = My.Resources._1a00
        End If
        If ComboBox5.SelectedItem = ComboBox5.Items.Item(15) Then
            NumericUpDown14.Value = 27
            PictureBox25.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(0) Then
            NumericUpDown18.Value = 65535
            PictureBox29.Image = Nothing
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(7) Then
            NumericUpDown18.Value = 0
            PictureBox29.Image = My.Resources._0000
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(17) Then
            NumericUpDown18.Value = 1
            PictureBox29.Image = My.Resources._0100
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(24) Then
            NumericUpDown18.Value = 2
            PictureBox29.Image = My.Resources._0200
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(13) Then
            NumericUpDown18.Value = 3
            PictureBox29.Image = My.Resources._0300
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(6) Then
            NumericUpDown18.Value = 4
            PictureBox29.Image = My.Resources._0400
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(4) Then
            NumericUpDown18.Value = 5
            PictureBox29.Image = My.Resources._0500
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(27) Then
            NumericUpDown18.Value = 6
            PictureBox29.Image = My.Resources._0600
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(28) Then
            NumericUpDown18.Value = 7
            PictureBox29.Image = My.Resources._0700
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(26) Then
            NumericUpDown18.Value = 8
            PictureBox29.Image = My.Resources._0800
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(16) Then
            NumericUpDown18.Value = 9
            PictureBox29.Image = My.Resources._0900
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(10) Then
            NumericUpDown18.Value = 10
            PictureBox29.Image = My.Resources._0a00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(14) Then
            NumericUpDown18.Value = 11
            PictureBox29.Image = My.Resources._0b00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(19) Then
            NumericUpDown18.Value = 12
            PictureBox29.Image = My.Resources._0c00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(3) Then
            NumericUpDown18.Value = 13
            PictureBox29.Image = My.Resources._0d00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(21) Then
            NumericUpDown18.Value = 14
            PictureBox29.Image = My.Resources._0e00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(1) Then
            NumericUpDown18.Value = 15
            PictureBox29.Image = My.Resources._0f00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(11) Then
            NumericUpDown18.Value = 16
            PictureBox29.Image = My.Resources._1000
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(23) Then
            NumericUpDown18.Value = 17
            PictureBox29.Image = My.Resources._1100
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(8) Then
            NumericUpDown18.Value = 18
            PictureBox29.Image = My.Resources._1200
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(2) Then
            NumericUpDown18.Value = 19
            PictureBox29.Image = My.Resources._1300
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(5) Then
            NumericUpDown18.Value = 20
            PictureBox29.Image = My.Resources._1400
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(25) Then
            NumericUpDown18.Value = 21
            PictureBox29.Image = My.Resources._1500
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(9) Then
            NumericUpDown18.Value = 22
            PictureBox29.Image = My.Resources._1600
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(18) Then
            NumericUpDown18.Value = 23
            PictureBox29.Image = My.Resources._1700
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(20) Then
            NumericUpDown18.Value = 24
            PictureBox29.Image = My.Resources._1800
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(22) Then
            NumericUpDown18.Value = 25
            PictureBox29.Image = My.Resources._1900
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(12) Then
            NumericUpDown18.Value = 26
            PictureBox29.Image = My.Resources._1a00
        End If
        If ComboBox10.SelectedItem = ComboBox10.Items.Item(15) Then
            NumericUpDown18.Value = 27
            PictureBox29.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(0) Then
            NumericUpDown17.Value = 65535
            PictureBox28.Image = Nothing
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(7) Then
            NumericUpDown17.Value = 0
            PictureBox28.Image = My.Resources._0000
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(17) Then
            NumericUpDown17.Value = 1
            PictureBox28.Image = My.Resources._0100
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(24) Then
            NumericUpDown17.Value = 2
            PictureBox28.Image = My.Resources._0200
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(13) Then
            NumericUpDown17.Value = 3
            PictureBox28.Image = My.Resources._0300
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(6) Then
            NumericUpDown17.Value = 4
            PictureBox28.Image = My.Resources._0400
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(4) Then
            NumericUpDown17.Value = 5
            PictureBox28.Image = My.Resources._0500
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(27) Then
            NumericUpDown17.Value = 6
            PictureBox28.Image = My.Resources._0600
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(28) Then
            NumericUpDown17.Value = 7
            PictureBox28.Image = My.Resources._0700
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(26) Then
            NumericUpDown17.Value = 8
            PictureBox28.Image = My.Resources._0800
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(16) Then
            NumericUpDown17.Value = 9
            PictureBox28.Image = My.Resources._0900
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(10) Then
            NumericUpDown17.Value = 10
            PictureBox28.Image = My.Resources._0a00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(14) Then
            NumericUpDown17.Value = 11
            PictureBox28.Image = My.Resources._0b00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(19) Then
            NumericUpDown17.Value = 12
            PictureBox28.Image = My.Resources._0c00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(3) Then
            NumericUpDown17.Value = 13
            PictureBox28.Image = My.Resources._0d00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(21) Then
            NumericUpDown17.Value = 14
            PictureBox28.Image = My.Resources._0e00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(1) Then
            NumericUpDown17.Value = 15
            PictureBox28.Image = My.Resources._0f00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(11) Then
            NumericUpDown17.Value = 16
            PictureBox28.Image = My.Resources._1000
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(23) Then
            NumericUpDown17.Value = 17
            PictureBox28.Image = My.Resources._1100
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(8) Then
            NumericUpDown17.Value = 18
            PictureBox28.Image = My.Resources._1200
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(2) Then
            NumericUpDown17.Value = 19
            PictureBox28.Image = My.Resources._1300
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(5) Then
            NumericUpDown17.Value = 20
            PictureBox28.Image = My.Resources._1400
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(25) Then
            NumericUpDown17.Value = 21
            PictureBox28.Image = My.Resources._1500
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(9) Then
            NumericUpDown17.Value = 22
            PictureBox28.Image = My.Resources._1600
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(18) Then
            NumericUpDown17.Value = 23
            PictureBox28.Image = My.Resources._1700
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(20) Then
            NumericUpDown17.Value = 24
            PictureBox28.Image = My.Resources._1800
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(22) Then
            NumericUpDown17.Value = 25
            PictureBox28.Image = My.Resources._1900
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(12) Then
            NumericUpDown17.Value = 26
            PictureBox28.Image = My.Resources._1a00
        End If
        If ComboBox9.SelectedItem = ComboBox9.Items.Item(15) Then
            NumericUpDown17.Value = 27
            PictureBox28.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(0) Then
            NumericUpDown16.Value = 65535
            PictureBox27.Image = Nothing
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(7) Then
            NumericUpDown16.Value = 0
            PictureBox27.Image = My.Resources._0000
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(17) Then
            NumericUpDown16.Value = 1
            PictureBox27.Image = My.Resources._0100
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(24) Then
            NumericUpDown16.Value = 2
            PictureBox27.Image = My.Resources._0200
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(13) Then
            NumericUpDown16.Value = 3
            PictureBox27.Image = My.Resources._0300
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(6) Then
            NumericUpDown16.Value = 4
            PictureBox27.Image = My.Resources._0400
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(4) Then
            NumericUpDown16.Value = 5
            PictureBox27.Image = My.Resources._0500
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(27) Then
            NumericUpDown16.Value = 6
            PictureBox27.Image = My.Resources._0600
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(28) Then
            NumericUpDown16.Value = 7
            PictureBox27.Image = My.Resources._0700
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(26) Then
            NumericUpDown16.Value = 8
            PictureBox27.Image = My.Resources._0800
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(16) Then
            NumericUpDown16.Value = 9
            PictureBox27.Image = My.Resources._0900
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(10) Then
            NumericUpDown16.Value = 10
            PictureBox27.Image = My.Resources._0a00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(14) Then
            NumericUpDown16.Value = 11
            PictureBox27.Image = My.Resources._0b00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(19) Then
            NumericUpDown16.Value = 12
            PictureBox27.Image = My.Resources._0c00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(3) Then
            NumericUpDown16.Value = 13
            PictureBox27.Image = My.Resources._0d00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(21) Then
            NumericUpDown16.Value = 14
            PictureBox27.Image = My.Resources._0e00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(1) Then
            NumericUpDown16.Value = 15
            PictureBox27.Image = My.Resources._0f00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(11) Then
            NumericUpDown16.Value = 16
            PictureBox27.Image = My.Resources._1000
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(23) Then
            NumericUpDown16.Value = 17
            PictureBox27.Image = My.Resources._1100
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(8) Then
            NumericUpDown16.Value = 18
            PictureBox27.Image = My.Resources._1200
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(2) Then
            NumericUpDown16.Value = 19
            PictureBox27.Image = My.Resources._1300
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(5) Then
            NumericUpDown16.Value = 20
            PictureBox27.Image = My.Resources._1400
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(25) Then
            NumericUpDown16.Value = 21
            PictureBox27.Image = My.Resources._1500
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(9) Then
            NumericUpDown16.Value = 22
            PictureBox27.Image = My.Resources._1600
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(18) Then
            NumericUpDown16.Value = 23
            PictureBox27.Image = My.Resources._1700
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(20) Then
            NumericUpDown16.Value = 24
            PictureBox27.Image = My.Resources._1800
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(22) Then
            NumericUpDown16.Value = 25
            PictureBox27.Image = My.Resources._1900
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(12) Then
            NumericUpDown16.Value = 26
            PictureBox27.Image = My.Resources._1a00
        End If
        If ComboBox7.SelectedItem = ComboBox7.Items.Item(15) Then
            NumericUpDown16.Value = 27
            PictureBox27.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(0) Then
            NumericUpDown15.Value = 65535
            PictureBox26.Image = Nothing
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(7) Then
            NumericUpDown15.Value = 0
            PictureBox26.Image = My.Resources._0000
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(17) Then
            NumericUpDown15.Value = 1
            PictureBox26.Image = My.Resources._0100
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(24) Then
            NumericUpDown15.Value = 2
            PictureBox26.Image = My.Resources._0200
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(13) Then
            NumericUpDown15.Value = 3
            PictureBox26.Image = My.Resources._0300
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(6) Then
            NumericUpDown15.Value = 4
            PictureBox26.Image = My.Resources._0400
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(4) Then
            NumericUpDown15.Value = 5
            PictureBox26.Image = My.Resources._0500
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(27) Then
            NumericUpDown15.Value = 6
            PictureBox26.Image = My.Resources._0600
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(28) Then
            NumericUpDown15.Value = 7
            PictureBox26.Image = My.Resources._0700
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(26) Then
            NumericUpDown15.Value = 8
            PictureBox26.Image = My.Resources._0800
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(16) Then
            NumericUpDown15.Value = 9
            PictureBox26.Image = My.Resources._0900
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(10) Then
            NumericUpDown15.Value = 10
            PictureBox26.Image = My.Resources._0a00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(14) Then
            NumericUpDown15.Value = 11
            PictureBox26.Image = My.Resources._0b00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(19) Then
            NumericUpDown15.Value = 12
            PictureBox26.Image = My.Resources._0c00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(3) Then
            NumericUpDown15.Value = 13
            PictureBox26.Image = My.Resources._0d00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(21) Then
            NumericUpDown15.Value = 14
            PictureBox26.Image = My.Resources._0e00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(1) Then
            NumericUpDown15.Value = 15
            PictureBox26.Image = My.Resources._0f00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(11) Then
            NumericUpDown15.Value = 16
            PictureBox26.Image = My.Resources._1000
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(23) Then
            NumericUpDown15.Value = 17
            PictureBox26.Image = My.Resources._1100
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(8) Then
            NumericUpDown15.Value = 18
            PictureBox26.Image = My.Resources._1200
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(2) Then
            NumericUpDown15.Value = 19
            PictureBox26.Image = My.Resources._1300
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(5) Then
            NumericUpDown15.Value = 20
            PictureBox26.Image = My.Resources._1400
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(25) Then
            NumericUpDown15.Value = 21
            PictureBox26.Image = My.Resources._1500
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(9) Then
            NumericUpDown15.Value = 22
            PictureBox26.Image = My.Resources._1600
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(18) Then
            NumericUpDown15.Value = 23
            PictureBox26.Image = My.Resources._1700
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(20) Then
            NumericUpDown15.Value = 24
            PictureBox26.Image = My.Resources._1800
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(22) Then
            NumericUpDown15.Value = 25
            PictureBox26.Image = My.Resources._1900
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(12) Then
            NumericUpDown15.Value = 26
            PictureBox26.Image = My.Resources._1a00
        End If
        If ComboBox8.SelectedItem = ComboBox8.Items.Item(15) Then
            NumericUpDown15.Value = 27
            PictureBox26.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        If NumericUpDown11.Value = 65535 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox17.Image = Nothing
        End If
        If NumericUpDown11.Value = 0 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox17.Image = My.Resources._0000
        End If
        If NumericUpDown11.Value = 1 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox17.Image = My.Resources._0100
        End If
        If NumericUpDown11.Value = 2 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox17.Image = My.Resources._0200
        End If
        If NumericUpDown11.Value = 3 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox17.Image = My.Resources._0300
        End If
        If NumericUpDown11.Value = 4 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox17.Image = My.Resources._0400
        End If
        If NumericUpDown11.Value = 5 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox17.Image = My.Resources._0500
        End If
        If NumericUpDown11.Value = 6 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox17.Image = My.Resources._0600
        End If
        If NumericUpDown11.Value = 7 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox17.Image = My.Resources._0700
        End If
        If NumericUpDown11.Value = 8 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox17.Image = My.Resources._0800
        End If
        If NumericUpDown11.Value = 9 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox17.Image = My.Resources._0900
        End If
        If NumericUpDown11.Value = 10 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox17.Image = My.Resources._0a00
        End If
        If NumericUpDown11.Value = 11 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox17.Image = My.Resources._0b00
        End If
        If NumericUpDown11.Value = 12 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox17.Image = My.Resources._0c00
        End If
        If NumericUpDown11.Value = 13 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox17.Image = My.Resources._0d00
        End If
        If NumericUpDown11.Value = 14 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox17.Image = My.Resources._0e00
        End If
        If NumericUpDown11.Value = 15 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox17.Image = My.Resources._0f00
        End If
        If NumericUpDown11.Value = 16 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox17.Image = My.Resources._1000
        End If
        If NumericUpDown11.Value = 17 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox17.Image = My.Resources._1100
        End If
        If NumericUpDown11.Value = 18 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox17.Image = My.Resources._1200
        End If
        If NumericUpDown11.Value = 19 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox17.Image = My.Resources._1300
        End If
        If NumericUpDown11.Value = 20 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox17.Image = My.Resources._1400
        End If
        If NumericUpDown11.Value = 21 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox17.Image = My.Resources._1500
        End If
        If NumericUpDown11.Value = 22 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox17.Image = My.Resources._1600
        End If
        If NumericUpDown11.Value = 23 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox17.Image = My.Resources._1700
        End If
        If NumericUpDown11.Value = 24 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox17.Image = My.Resources._1800
        End If
        If NumericUpDown11.Value = 25 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox17.Image = My.Resources._1900
        End If
        If NumericUpDown11.Value = 26 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox17.Image = My.Resources._1a00
        End If
        If NumericUpDown11.Value = 27 Then
            ComboBox3.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox17.Image = My.Resources._1b00
        End If
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If NumericUpDown12.Value = 65535 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox23.Image = Nothing
        End If
        If NumericUpDown12.Value = 0 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox23.Image = My.Resources._0000
        End If
        If NumericUpDown12.Value = 1 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox23.Image = My.Resources._0100
        End If
        If NumericUpDown12.Value = 2 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox23.Image = My.Resources._0200
        End If
        If NumericUpDown12.Value = 3 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox23.Image = My.Resources._0300
        End If
        If NumericUpDown12.Value = 4 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox23.Image = My.Resources._0400
        End If
        If NumericUpDown12.Value = 5 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox23.Image = My.Resources._0500
        End If
        If NumericUpDown12.Value = 6 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox23.Image = My.Resources._0600
        End If
        If NumericUpDown12.Value = 7 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox23.Image = My.Resources._0700
        End If
        If NumericUpDown12.Value = 8 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox23.Image = My.Resources._0800
        End If
        If NumericUpDown12.Value = 9 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox23.Image = My.Resources._0900
        End If
        If NumericUpDown12.Value = 10 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox23.Image = My.Resources._0a00
        End If
        If NumericUpDown12.Value = 11 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox23.Image = My.Resources._0b00
        End If
        If NumericUpDown12.Value = 12 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox23.Image = My.Resources._0c00
        End If
        If NumericUpDown12.Value = 13 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox23.Image = My.Resources._0d00
        End If
        If NumericUpDown12.Value = 14 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox23.Image = My.Resources._0e00
        End If
        If NumericUpDown12.Value = 15 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox23.Image = My.Resources._0f00
        End If
        If NumericUpDown12.Value = 16 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox23.Image = My.Resources._1000
        End If
        If NumericUpDown12.Value = 17 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox23.Image = My.Resources._1100
        End If
        If NumericUpDown12.Value = 18 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox23.Image = My.Resources._1200
        End If
        If NumericUpDown12.Value = 19 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox23.Image = My.Resources._1300
        End If
        If NumericUpDown12.Value = 20 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox23.Image = My.Resources._1400
        End If
        If NumericUpDown12.Value = 21 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox23.Image = My.Resources._1500
        End If
        If NumericUpDown12.Value = 22 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox23.Image = My.Resources._1600
        End If
        If NumericUpDown12.Value = 23 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox23.Image = My.Resources._1700
        End If
        If NumericUpDown12.Value = 24 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox23.Image = My.Resources._1800
        End If
        If NumericUpDown12.Value = 25 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox23.Image = My.Resources._1900
        End If
        If NumericUpDown12.Value = 26 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox23.Image = My.Resources._1a00
        End If
        If NumericUpDown12.Value = 27 Then
            ComboBox4.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox23.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown13_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown13.ValueChanged
        If NumericUpDown13.Value = 65535 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox24.Image = Nothing
        End If
        If NumericUpDown13.Value = 0 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox24.Image = My.Resources._0000
        End If
        If NumericUpDown13.Value = 1 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox24.Image = My.Resources._0100
        End If
        If NumericUpDown13.Value = 2 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox24.Image = My.Resources._0200
        End If
        If NumericUpDown13.Value = 3 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox24.Image = My.Resources._0300
        End If
        If NumericUpDown13.Value = 4 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox24.Image = My.Resources._0400
        End If
        If NumericUpDown13.Value = 5 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox24.Image = My.Resources._0500
        End If
        If NumericUpDown13.Value = 6 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox24.Image = My.Resources._0600
        End If
        If NumericUpDown13.Value = 7 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox24.Image = My.Resources._0700
        End If
        If NumericUpDown13.Value = 8 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox24.Image = My.Resources._0800
        End If
        If NumericUpDown13.Value = 9 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox24.Image = My.Resources._0900
        End If
        If NumericUpDown13.Value = 10 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox24.Image = My.Resources._0a00
        End If
        If NumericUpDown13.Value = 11 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox24.Image = My.Resources._0b00
        End If
        If NumericUpDown13.Value = 12 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox24.Image = My.Resources._0c00
        End If
        If NumericUpDown13.Value = 13 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox24.Image = My.Resources._0d00
        End If
        If NumericUpDown13.Value = 14 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox24.Image = My.Resources._0e00
        End If
        If NumericUpDown13.Value = 15 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox24.Image = My.Resources._0f00
        End If
        If NumericUpDown13.Value = 16 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox24.Image = My.Resources._1000
        End If
        If NumericUpDown13.Value = 17 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox24.Image = My.Resources._1100
        End If
        If NumericUpDown13.Value = 18 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox24.Image = My.Resources._1200
        End If
        If NumericUpDown13.Value = 19 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox24.Image = My.Resources._1300
        End If
        If NumericUpDown13.Value = 20 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox24.Image = My.Resources._1400
        End If
        If NumericUpDown13.Value = 21 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox24.Image = My.Resources._1500
        End If
        If NumericUpDown13.Value = 22 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox24.Image = My.Resources._1600
        End If
        If NumericUpDown13.Value = 23 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox24.Image = My.Resources._1700
        End If
        If NumericUpDown13.Value = 24 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox24.Image = My.Resources._1800
        End If
        If NumericUpDown13.Value = 25 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox24.Image = My.Resources._1900
        End If
        If NumericUpDown13.Value = 26 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox24.Image = My.Resources._1a00
        End If
        If NumericUpDown13.Value = 27 Then
            ComboBox6.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox24.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown14_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown14.ValueChanged
        If NumericUpDown14.Value = 65535 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox25.Image = Nothing
        End If
        If NumericUpDown14.Value = 0 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox25.Image = My.Resources._0000
        End If
        If NumericUpDown14.Value = 1 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox25.Image = My.Resources._0100
        End If
        If NumericUpDown14.Value = 2 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox25.Image = My.Resources._0200
        End If
        If NumericUpDown14.Value = 3 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox25.Image = My.Resources._0300
        End If
        If NumericUpDown14.Value = 4 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox25.Image = My.Resources._0400
        End If
        If NumericUpDown14.Value = 5 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox25.Image = My.Resources._0500
        End If
        If NumericUpDown14.Value = 6 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox25.Image = My.Resources._0600
        End If
        If NumericUpDown14.Value = 7 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox25.Image = My.Resources._0700
        End If
        If NumericUpDown14.Value = 8 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox25.Image = My.Resources._0800
        End If
        If NumericUpDown14.Value = 9 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox25.Image = My.Resources._0900
        End If
        If NumericUpDown14.Value = 10 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox25.Image = My.Resources._0a00
        End If
        If NumericUpDown14.Value = 11 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox25.Image = My.Resources._0b00
        End If
        If NumericUpDown14.Value = 12 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox25.Image = My.Resources._0c00
        End If
        If NumericUpDown14.Value = 13 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox25.Image = My.Resources._0d00
        End If
        If NumericUpDown14.Value = 14 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox25.Image = My.Resources._0e00
        End If
        If NumericUpDown14.Value = 15 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox25.Image = My.Resources._0f00
        End If
        If NumericUpDown14.Value = 16 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox25.Image = My.Resources._1000
        End If
        If NumericUpDown14.Value = 17 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox25.Image = My.Resources._1100
        End If
        If NumericUpDown14.Value = 18 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox25.Image = My.Resources._1200
        End If
        If NumericUpDown14.Value = 19 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox25.Image = My.Resources._1300
        End If
        If NumericUpDown14.Value = 20 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox25.Image = My.Resources._1400
        End If
        If NumericUpDown14.Value = 21 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox25.Image = My.Resources._1500
        End If
        If NumericUpDown14.Value = 22 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox25.Image = My.Resources._1600
        End If
        If NumericUpDown14.Value = 23 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox25.Image = My.Resources._1700
        End If
        If NumericUpDown14.Value = 24 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox25.Image = My.Resources._1800
        End If
        If NumericUpDown14.Value = 25 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox25.Image = My.Resources._1900
        End If
        If NumericUpDown14.Value = 26 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox25.Image = My.Resources._1a00
        End If
        If NumericUpDown14.Value = 27 Then
            ComboBox5.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox25.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown18_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown18.ValueChanged
        If NumericUpDown18.Value = 65535 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox29.Image = Nothing
        End If
        If NumericUpDown18.Value = 0 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox29.Image = My.Resources._0000
        End If
        If NumericUpDown18.Value = 1 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox29.Image = My.Resources._0100
        End If
        If NumericUpDown18.Value = 2 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox29.Image = My.Resources._0200
        End If
        If NumericUpDown18.Value = 3 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox29.Image = My.Resources._0300
        End If
        If NumericUpDown18.Value = 4 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox29.Image = My.Resources._0400
        End If
        If NumericUpDown18.Value = 5 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox29.Image = My.Resources._0500
        End If
        If NumericUpDown18.Value = 6 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox29.Image = My.Resources._0600
        End If
        If NumericUpDown18.Value = 7 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox29.Image = My.Resources._0700
        End If
        If NumericUpDown18.Value = 8 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox29.Image = My.Resources._0800
        End If
        If NumericUpDown18.Value = 9 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox29.Image = My.Resources._0900
        End If
        If NumericUpDown18.Value = 10 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox29.Image = My.Resources._0a00
        End If
        If NumericUpDown18.Value = 11 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox29.Image = My.Resources._0b00
        End If
        If NumericUpDown18.Value = 12 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox29.Image = My.Resources._0c00
        End If
        If NumericUpDown18.Value = 13 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox29.Image = My.Resources._0d00
        End If
        If NumericUpDown18.Value = 14 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox29.Image = My.Resources._0e00
        End If
        If NumericUpDown18.Value = 15 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox29.Image = My.Resources._0f00
        End If
        If NumericUpDown18.Value = 16 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox29.Image = My.Resources._1000
        End If
        If NumericUpDown18.Value = 17 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox29.Image = My.Resources._1100
        End If
        If NumericUpDown18.Value = 18 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox29.Image = My.Resources._1200
        End If
        If NumericUpDown18.Value = 19 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox29.Image = My.Resources._1300
        End If
        If NumericUpDown18.Value = 20 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox29.Image = My.Resources._1400
        End If
        If NumericUpDown18.Value = 21 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox29.Image = My.Resources._1500
        End If
        If NumericUpDown18.Value = 22 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox29.Image = My.Resources._1600
        End If
        If NumericUpDown18.Value = 23 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox29.Image = My.Resources._1700
        End If
        If NumericUpDown18.Value = 24 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox29.Image = My.Resources._1800
        End If
        If NumericUpDown18.Value = 25 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox29.Image = My.Resources._1900
        End If
        If NumericUpDown18.Value = 26 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox29.Image = My.Resources._1a00
        End If
        If NumericUpDown18.Value = 27 Then
            ComboBox10.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox29.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown17_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown17.ValueChanged
        If NumericUpDown17.Value = 65535 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox28.Image = Nothing
        End If
        If NumericUpDown17.Value = 0 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox28.Image = My.Resources._0000
        End If
        If NumericUpDown17.Value = 1 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox28.Image = My.Resources._0100
        End If
        If NumericUpDown17.Value = 2 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox28.Image = My.Resources._0200
        End If
        If NumericUpDown17.Value = 3 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox28.Image = My.Resources._0300
        End If
        If NumericUpDown17.Value = 4 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox28.Image = My.Resources._0400
        End If
        If NumericUpDown17.Value = 5 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox28.Image = My.Resources._0500
        End If
        If NumericUpDown17.Value = 6 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox28.Image = My.Resources._0600
        End If
        If NumericUpDown17.Value = 7 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox28.Image = My.Resources._0700
        End If
        If NumericUpDown17.Value = 8 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox28.Image = My.Resources._0800
        End If
        If NumericUpDown17.Value = 9 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox28.Image = My.Resources._0900
        End If
        If NumericUpDown17.Value = 10 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox28.Image = My.Resources._0a00
        End If
        If NumericUpDown17.Value = 11 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox28.Image = My.Resources._0b00
        End If
        If NumericUpDown17.Value = 12 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox28.Image = My.Resources._0c00
        End If
        If NumericUpDown17.Value = 13 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox28.Image = My.Resources._0d00
        End If
        If NumericUpDown17.Value = 14 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox28.Image = My.Resources._0e00
        End If
        If NumericUpDown17.Value = 15 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox28.Image = My.Resources._0f00
        End If
        If NumericUpDown17.Value = 16 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox28.Image = My.Resources._1000
        End If
        If NumericUpDown17.Value = 17 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox28.Image = My.Resources._1100
        End If
        If NumericUpDown17.Value = 18 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox28.Image = My.Resources._1200
        End If
        If NumericUpDown17.Value = 19 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox28.Image = My.Resources._1300
        End If
        If NumericUpDown17.Value = 20 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox28.Image = My.Resources._1400
        End If
        If NumericUpDown17.Value = 21 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox28.Image = My.Resources._1500
        End If
        If NumericUpDown17.Value = 22 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox28.Image = My.Resources._1600
        End If
        If NumericUpDown17.Value = 23 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox28.Image = My.Resources._1700
        End If
        If NumericUpDown17.Value = 24 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox28.Image = My.Resources._1800
        End If
        If NumericUpDown17.Value = 25 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox28.Image = My.Resources._1900
        End If
        If NumericUpDown17.Value = 26 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox28.Image = My.Resources._1a00
        End If
        If NumericUpDown17.Value = 27 Then
            ComboBox9.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox28.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown16_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown16.ValueChanged
        If NumericUpDown16.Value = 65535 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox27.Image = Nothing
        End If
        If NumericUpDown16.Value = 0 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox27.Image = My.Resources._0000
        End If
        If NumericUpDown16.Value = 1 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox27.Image = My.Resources._0100
        End If
        If NumericUpDown16.Value = 2 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox27.Image = My.Resources._0200
        End If
        If NumericUpDown16.Value = 3 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox27.Image = My.Resources._0300
        End If
        If NumericUpDown16.Value = 4 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox27.Image = My.Resources._0400
        End If
        If NumericUpDown16.Value = 5 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox27.Image = My.Resources._0500
        End If
        If NumericUpDown16.Value = 6 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox27.Image = My.Resources._0600
        End If
        If NumericUpDown16.Value = 7 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox27.Image = My.Resources._0700
        End If
        If NumericUpDown16.Value = 8 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox27.Image = My.Resources._0800
        End If
        If NumericUpDown16.Value = 9 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox27.Image = My.Resources._0900
        End If
        If NumericUpDown16.Value = 10 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox27.Image = My.Resources._0a00
        End If
        If NumericUpDown16.Value = 11 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox27.Image = My.Resources._0b00
        End If
        If NumericUpDown16.Value = 12 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox27.Image = My.Resources._0c00
        End If
        If NumericUpDown16.Value = 13 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox27.Image = My.Resources._0d00
        End If
        If NumericUpDown16.Value = 14 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox27.Image = My.Resources._0e00
        End If
        If NumericUpDown16.Value = 15 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox27.Image = My.Resources._0f00
        End If
        If NumericUpDown16.Value = 16 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox27.Image = My.Resources._1000
        End If
        If NumericUpDown16.Value = 17 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox27.Image = My.Resources._1100
        End If
        If NumericUpDown16.Value = 18 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox27.Image = My.Resources._1200
        End If
        If NumericUpDown16.Value = 19 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox27.Image = My.Resources._1300
        End If
        If NumericUpDown16.Value = 20 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox27.Image = My.Resources._1400
        End If
        If NumericUpDown16.Value = 21 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox27.Image = My.Resources._1500
        End If
        If NumericUpDown16.Value = 22 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox27.Image = My.Resources._1600
        End If
        If NumericUpDown16.Value = 23 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox27.Image = My.Resources._1700
        End If
        If NumericUpDown16.Value = 24 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox27.Image = My.Resources._1800
        End If
        If NumericUpDown16.Value = 25 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox27.Image = My.Resources._1900
        End If
        If NumericUpDown16.Value = 26 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox27.Image = My.Resources._1a00
        End If
        If NumericUpDown16.Value = 27 Then
            ComboBox7.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox27.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub NumericUpDown15_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown15.ValueChanged
        If NumericUpDown15.Value = 65535 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(0)
            PictureBox26.Image = Nothing
        End If
        If NumericUpDown15.Value = 0 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(7)
            PictureBox26.Image = My.Resources._0000
        End If
        If NumericUpDown15.Value = 1 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(17)
            PictureBox26.Image = My.Resources._0100
        End If
        If NumericUpDown15.Value = 2 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(24)
            PictureBox26.Image = My.Resources._0200
        End If
        If NumericUpDown15.Value = 3 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(13)
            PictureBox26.Image = My.Resources._0300
        End If
        If NumericUpDown15.Value = 4 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(6)
            PictureBox26.Image = My.Resources._0400
        End If
        If NumericUpDown15.Value = 5 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(4)
            PictureBox26.Image = My.Resources._0500
        End If
        If NumericUpDown15.Value = 6 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(27)
            PictureBox26.Image = My.Resources._0600
        End If
        If NumericUpDown15.Value = 7 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(28)
            PictureBox26.Image = My.Resources._0700
        End If
        If NumericUpDown15.Value = 8 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(26)
            PictureBox26.Image = My.Resources._0800
        End If
        If NumericUpDown15.Value = 9 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(16)
            PictureBox26.Image = My.Resources._0900
        End If
        If NumericUpDown15.Value = 10 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(10)
            PictureBox26.Image = My.Resources._0a00
        End If
        If NumericUpDown15.Value = 11 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(14)
            PictureBox26.Image = My.Resources._0b00
        End If
        If NumericUpDown15.Value = 12 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(19)
            PictureBox26.Image = My.Resources._0c00
        End If
        If NumericUpDown15.Value = 13 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(3)
            PictureBox26.Image = My.Resources._0d00
        End If
        If NumericUpDown15.Value = 14 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(21)
            PictureBox26.Image = My.Resources._0e00
        End If
        If NumericUpDown15.Value = 15 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(1)
            PictureBox26.Image = My.Resources._0f00
        End If
        If NumericUpDown15.Value = 16 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(11)
            PictureBox26.Image = My.Resources._1000
        End If
        If NumericUpDown15.Value = 17 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(23)
            PictureBox26.Image = My.Resources._1100
        End If
        If NumericUpDown15.Value = 18 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(8)
            PictureBox26.Image = My.Resources._1200
        End If
        If NumericUpDown15.Value = 19 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(2)
            PictureBox26.Image = My.Resources._1300
        End If
        If NumericUpDown15.Value = 20 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(5)
            PictureBox26.Image = My.Resources._1400
        End If
        If NumericUpDown15.Value = 21 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(25)
            PictureBox26.Image = My.Resources._1500
        End If
        If NumericUpDown15.Value = 22 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(9)
            PictureBox26.Image = My.Resources._1600
        End If
        If NumericUpDown15.Value = 23 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(18)
            PictureBox26.Image = My.Resources._1700
        End If
        If NumericUpDown15.Value = 24 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(20)
            PictureBox26.Image = My.Resources._1800
        End If
        If NumericUpDown15.Value = 25 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(22)
            PictureBox26.Image = My.Resources._1900
        End If
        If NumericUpDown15.Value = 26 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(12)
            PictureBox26.Image = My.Resources._1a00
        End If
        If NumericUpDown15.Value = 27 Then
            ComboBox8.SelectedItem = ComboBox8.Items.Item(15)
            PictureBox26.Image = My.Resources._1b00
        End If

    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.objet1 = NumericUpDown11.Value
        My.Settings.objet2 = NumericUpDown12.Value
        My.Settings.objet3 = NumericUpDown13.Value
        My.Settings.objet4 = NumericUpDown14.Value
        My.Settings.objet5 = NumericUpDown15.Value
        My.Settings.objet6 = NumericUpDown16.Value
        My.Settings.objet7 = NumericUpDown17.Value
        My.Settings.objet8 = NumericUpDown18.Value
        My.Settings.Save()

        e.Cancel = False
    End Sub
End Class