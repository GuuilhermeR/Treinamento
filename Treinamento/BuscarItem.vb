Imports System.Data.SqlClient

Public Class BuscarItem
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT codItem, nomeItem, numExemplar, tipoItem, localizacao FROM Treinamento.dbo.MvtBIBItemAcervo", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codItem"), dr.Item("nomeItem"), dr.Item("numExemplar"), dr.Item("tipoItem"), dr.Item("localizacao"))
                End While
            End Using

        End Using

        objConexao.Close()

    End Sub

    Private Sub BuscarCAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub

    Dim cod As String
    Dim nomeItem As String
    Dim numExemplar As String
    Dim tpItem As String
    Dim localizacao As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        Reserva.txtCodItem.Text = cod
        Reserva.txtNomeItem.Text = nomeItem
        Reserva.txtNumExemplar.Text = numExemplar
        Reserva.txtTipoItem.Text = tpItem
        Reserva.txtLocalizacao.Text = localizacao

        Me.Dispose()
        Reserva.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cod = dgvInformacoes.SelectedCells(0).Value
        numExemplar = dgvInformacoes.SelectedCells(2).Value
        tpItem = dgvInformacoes.SelectedCells(3).Value
        nomeItem = dgvInformacoes.SelectedCells(1).Value
        localizacao = dgvInformacoes.SelectedCells(4).Value

    End Sub
End Class