Module ConvValidCPF

    Public Sub formatacpf(ByVal txtTexto As Object)
        If Len(txtTexto.Text) = 3 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 7 Then
            txtTexto.Text = txtTexto.Text & "."
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        ElseIf Len(txtTexto.Text) = 11 Then
            txtTexto.Text = txtTexto.Text & "-"
            txtTexto.SelectionStart = Len(txtTexto.Text) + 1
        End If
    End Sub

End Module
