Imports System.Windows.Forms.VisualStyles

Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Hide()

        While (pnlLeft.Width < 211)
            pnlLeft.Width += 1
        End While
        Button24.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.Hide()
        While (pnlLeft.Width > 65)
            pnlLeft.Width -= 1
        End While
        Button4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlShirt2.Visible = True
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = False
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = False
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = True
        pnlShGirl.Visible = False
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = False
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = True
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = False
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = False
        pnlShoes.Visible = True
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = False
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = False
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = True
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = False
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = False
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = True
        pnlSkirt2.Visible = False
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = False
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = True
        pnlHeels.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        pnlShirt2.Visible = False
        pnlShBoy2.Visible = False
        pnlShGirl.Visible = False
        pnlShoes.Visible = False
        pnlShoBoy2.Visible = False
        pnlShoGirl2.Visible = False
        pnlSkirt2.Visible = False
        pnlHeels.Visible = True
        pnlAbout.Visible = False
    End Sub
End Class