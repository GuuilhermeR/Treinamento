Public Class Form1
    Private Sub btnCadastAutor_Click(sender As Object, e As EventArgs)
        Me.Hide()
        CadastrarAutor.Show()
    End Sub
    Private Sub btnCadastLeitor_Click(sender As Object, e As EventArgs) Handles btnCadastLeitor.Click
        Me.Hide()
        CadastrarLeitor.Show()
    End Sub

    Private Sub btnCadastEditora_Click(sender As Object, e As EventArgs) Handles btnCadastEditora.Click
        Me.Hide()
        CadastrarEditora.Show()
    End Sub

    Private Sub btnCadastLocal_Click(sender As Object, e As EventArgs) Handles btnCadastLocal.Click
        Me.Hide()
        CadastrarLocal.Show()
    End Sub

    Private Sub btnCadastSecao_Click(sender As Object, e As EventArgs) Handles btnCadastSecao.Click
        Me.Hide()
        CadastrarSecao.Show()
    End Sub

    Private Sub btnItemAcervo_Click(sender As Object, e As EventArgs) Handles btnItemAcervo.Click
        Me.Hide()
        CadastrarItemAcervo.Show()
    End Sub

    Private Sub btnCadastReserva_Click(sender As Object, e As EventArgs) Handles btnCadastReserva.Click
        Me.Hide()
        Reserva.Show()
    End Sub
    Private Sub btnConsItemAcervo_Click(sender As Object, e As EventArgs) Handles btnConsItemAcervo.Click
        Me.Hide()
        ConsultaItemAcervo.Show()
    End Sub

    Private Sub btnCadastDevolucao_Click(sender As Object, e As EventArgs) Handles btnCadastDevolucao.Click
        Me.Hide()
        CadastrarDevolucao.Show()
    End Sub

    Private Sub btnColecao_Click_1(sender As Object, e As EventArgs) Handles btnColecao.Click
        Me.Hide()
        CadastrarColecao.Show()
    End Sub

    Private Sub btnConsEmpr_Click(sender As Object, e As EventArgs) Handles btnConsEmpr.Click
        Me.Hide()
        ConsultaEmprestimo.Show()
    End Sub

    Private Sub btnCadastAutor_Click_1(sender As Object, e As EventArgs) Handles btnCadastAutor.Click
        Me.Hide()
        CadastrarAutor.Show()
    End Sub
End Class
