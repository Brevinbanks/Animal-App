
Public Class Form1
    Dim animalcol As New AnimalCollection("C:\Users\brevi\Desktop\Radius Project\Radius Animal App\animals-data.txt")
    Enum SortKey
        Atype
        Asex
        Aage
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animalcol.CollectAnimals()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Display_button.Click
        ListBox.Items.Clear()

        Dim AnimalPackage As List(Of String) = animalcol.DeliverAnimals()
        For k As Integer = 0 To AnimalPackage.Count - 1
            ListBox.Items.Add(AnimalPackage(k))
        Next

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Dogs_radio.CheckedChanged
        If Dogs_radio.Checked = True Then
            animalcol.SortAnimals(SortKey.Atype, "Dog")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Cats_radio.CheckedChanged
        If Cats_radio.Checked = True Then
            animalcol.SortAnimals(SortKey.Atype, "Cat")
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Male_radio.CheckedChanged
        If Male_radio.Checked = True Then
            animalcol.SortAnimals(SortKey.Asex, "m"c)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Female_radio.CheckedChanged
        If Female_radio.Checked = True Then
            animalcol.SortAnimals(SortKey.Asex, "f"c)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Age_radio.CheckedChanged
        If Age_radio.Checked = True Then
            animalcol.SortAnimals(SortKey.Aage, "")
        End If
    End Sub
End Class
