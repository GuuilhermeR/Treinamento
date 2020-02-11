Imports System.Data.SqlClient

Public Class BuscarSecao
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBSecao", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("CodSecao"), dr.Item("descricaoSecao"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Dim sec As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        CadastrarItemAcervo.txtSecao.Text = sec
        Me.Dispose()
        CadastrarItemAcervo.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        sec = dgvInformacoes.SelectedCells(0).Value

    End Sub

    Private Sub BuscarCeditora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub
End Class