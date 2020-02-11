Imports System.Data.SqlClient

Public Class BuscarCeditora

    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If
        Using cmd As New SqlCommand("SELECT * FROM MvtBIBEditora", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codEditora"), dr.Item("nome"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Dim cod As String
    Dim nome As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        CadastrarItemAcervo.txtCodEditora.Text = cod
        CadastrarItemAcervo.txtEditora.Text = nome
        Me.Dispose()
        CadastrarItemAcervo.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cod = dgvInformacoes.SelectedCells(codEditora.Index).Value
        nome = dgvInformacoes.SelectedCells(1).Value

    End Sub

    Private Sub BuscarCeditora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub
End Class