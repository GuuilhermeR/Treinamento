Imports System.Data.SqlClient

Public Class BuscarCcolecao
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBColecao", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codColecao"), dr.Item("nomeColecao"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub BuscarCAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub

    Dim cod As String
    Dim nome As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        CadastrarItemAcervo.txtCodColecao.Text = cod
        CadastrarItemAcervo.txtColecao.Text = nome
        Me.Dispose()
        CadastrarItemAcervo.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cod = dgvInformacoes.SelectedCells(codColecao.Index).Value
        nome = dgvInformacoes.SelectedCells(1).Value

    End Sub
End Class
