Imports System.Data.SqlClient

Public Class BuscarCLocal

    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub BuscarCLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBLocal", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codLocal"), dr.Item("descricaoLocal"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Dim cod As String
    Dim nome As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        CadastrarItemAcervo.txtCodLocal.Text = cod
        CadastrarItemAcervo.txtLocal.Text = nome
        Me.Dispose()
        CadastrarItemAcervo.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cod = dgvInformacoes.SelectedCells(codLocal.Index).Value
        nome = dgvInformacoes.SelectedCells(1).Value


    End Sub
End Class