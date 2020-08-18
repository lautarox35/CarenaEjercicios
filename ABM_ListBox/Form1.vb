Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Focus()

        'Si el TextBox está vacío salgo del Sub.
        If TextBox1.Text.Trim = "" Then Exit Sub

        'Agrga un item a la colección del ListBox
        ListBox1.Items.Add(TextBox1.Text.Trim)

        'Limpio el TextBox
        TextBox1.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Si el TextBox está vacío salgo del Sub.
        If ListBox1.SelectedIndex = -1 Then Exit Sub

        'Elimino el elemento seleccionado del ListBox.
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

        'Elimino la selección del ListBox.
        ListBox1.ClearSelected()

        'Limpio el TextBox
        TextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Focus()

        'Si el TextBox está vacío salgo del Sub.
        If ListBox1.SelectedIndex = -1 Then Exit Sub

        'ListBox1.SelectedItem = TextBox1.Text
        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text

        'Elimino la selección del ListBox.
        ListBox1.ClearSelected()

        'Limpio el TextBox
        TextBox1.Clear()

    End Sub
End Class
