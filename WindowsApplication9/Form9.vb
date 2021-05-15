Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Lenova" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("chronic Black")
            ComboBox2.Items.Add("white")
            ComboBox2.Items.Add("black")
            ComboBox2.Items.Add("blue")
            ListBox1.Items.Clear()
            ListBox1.Items.Add("S1")
            ListBox1.Items.Add("S2")
            ListBox1.Items.Add("S3")




        End If
        If ComboBox1.SelectedItem = "HP" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("black")
            ComboBox2.Items.Add("grey")
            ComboBox2.Items.Add("pink")
            ComboBox2.Items.Add("silver")

            ListBox1.Items.Clear()
            ListBox1.Items.Add("H4")
            ListBox1.Items.Add("H5")
            ListBox1.Items.Add("H6")

        End If
        If ComboBox1.SelectedItem = "Apple" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Brown")
            ComboBox2.Items.Add("Ash")
            ComboBox2.Items.Add("wine")
            ComboBox2.Items.Add("white")

            ListBox1.Items.Clear()
            ListBox1.Items.Add("A1")
            ListBox1.Items.Add("A2")
            ListBox1.Items.Add("A3")


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Lenova")
        ComboBox1.Items.Add("HP")
        ComboBox1.Items.Add("Apple")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = ("S1") Then
            TextBox1.Text = "10 Thousand"
        End If

        If ListBox1.SelectedItem = ("S2") Then
            TextBox1.Text = "20 Thousand"
        End If

        If ListBox1.SelectedItem = ("S3") Then
            TextBox1.Text = "30 thousand"
        End If

        If ListBox1.SelectedItem = ("H4") Then
            TextBox1.Text = "40 Thousand"
        End If

        If ListBox1.SelectedItem = ("H5") Then
            TextBox1.Text = "50 Thousand"
        End If

        If ListBox1.SelectedItem = ("H6") Then
            TextBox1.Text = "60 Thousand"
        End If

        If ListBox1.SelectedItem = ("A1") Then
            TextBox1.Text = "70 Thousand"
        End If

        If ListBox1.SelectedItem = ("A2") Then
            TextBox1.Text = "80 Thousand"
        End If

        If ListBox1.SelectedItem = ("A3") Then
            TextBox1.Text = "90 Thousand"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        TextBox1.Text = ""
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub
End Class
