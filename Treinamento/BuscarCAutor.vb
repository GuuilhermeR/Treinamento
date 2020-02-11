Imports System.Data.SqlClient

Public Class BuscarCAutor

    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("Select * from MvtBIBAutor", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codAutor"), dr.Item("nomeAutor"), dr.Item("descricao"))
                End While
            End Using

        End Using

        objConexao.Close()

    End Sub

    Private Sub BuscarCAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub

    Dim cod As String
    Dim desc As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        CadastrarItemAcervo.txtCodAutor.Text = cod
        CadastrarItemAcervo.txtAutor.Text = desc
        Me.Dispose()
        CadastrarItemAcervo.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cod = dgvInformacoes.SelectedCells(codAutor.Index).Value
        desc = dgvInformacoes.SelectedCells(nomAutor.Index).Value


    End Sub
End Class