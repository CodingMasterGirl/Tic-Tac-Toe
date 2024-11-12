Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Dim change As Boolean = False ' Image should display
    Dim happyCat As Image = My.Resources.Happy_Cat_X
    Dim tiredCat As Image = My.Resources.Tired_Cat_O
    Dim result As MsgBoxResult
    Dim counter As Integer = 0
    Dim computercounter2 As Integer = 0
    Dim player1 As Integer
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        MsgBox("Welcome to Tic Tac Toe!")
        MsgBox("Press the boxes to start playing!")
        MsgBox("GOOd Luck!")
    End Sub

    Private Sub PictureBox(sender As PictureBox, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click,
            PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click
        If change Then
            sender.Image = happyCat
            change = False

        Else
            sender.Image = tiredCat
            change = True
        End If



        If PictureBox1.Image Is happyCat And PictureBox2.Image Is happyCat And PictureBox3.Image Is happyCat Then
            counter = counter + 1
            lblPlayer1Score.Text = counter
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
        End If

        If PictureBox4.Image Is happyCat And PictureBox5.Image Is happyCat And PictureBox6.Image Is happyCat Then
            counter = counter + 1
            lblPlayer1Score.Text = counter
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing

        End If

        If PictureBox7.Image Is happyCat And PictureBox8.Image Is happyCat And PictureBox9.Image Is happyCat Then
            counter = counter + 1
            lblPlayer1Score.Text = counter
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing
        End If

        If PictureBox1.Image Is tiredCat And PictureBox2.Image Is tiredCat And PictureBox3.Image Is tiredCat Then
            computercounter2 = computercounter2 + 1
            lblPlayer2Score.Text = computercounter2
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
        End If

        If PictureBox4.Image Is tiredCat And PictureBox5.Image Is tiredCat And PictureBox6.Image Is tiredCat Then
            computercounter2 = computercounter2 + 1
            lblPlayer2Score.Text = computercounter2
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
        End If

        If PictureBox7.Image Is tiredCat And PictureBox8.Image Is tiredCat And PictureBox9.Image Is tiredCat Then
            computercounter2 = computercounter2 + 1
            lblPlayer2Score.Text = computercounter2
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing
        End If

        If PictureBox1.Image Is tiredCat And PictureBox5.Image Is tiredCat And PictureBox7.Image Is tiredCat Then
            computercounter2 = computercounter2 + 1
            lblPlayer2Score.Text = computercounter2
            PictureBox1.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox7.Image = Nothing
        End If

    End Sub

    Private Sub RESETBUTTON(sender As Object, e As EventArgs) Handles Button1.Click
        lblPlayer1Score.Text = 0
        lblPlayer2Score.Text = 0
    End Sub

    Private Sub ENDBUTTON(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class