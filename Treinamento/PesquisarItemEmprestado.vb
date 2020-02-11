Imports System.Data.SqlClient

Public Class PesquisarItemEmprestado
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM Treinamento.dbo.MvtBIBReserva", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codItem"), dr.Item("nomeItem"), dr.Item("numExemplar"), dr.Item("tipoItem"), dr.Item("localizacao"),
                                   dr.Item("codLeitor"), dr.Item("nomeLeitor"), dr.Item("dataReserva"), dr.Item("prazoReserva"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub PesquisarItemEmprestado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub

    Dim cItem1 As String
    Dim nItem2 As String
    Dim nExemp3 As String
    Dim tItem4 As String
    Dim locali5 As String
    Dim nLeitor6 As String
    Dim datee7 As String
    Dim Prazoo8 As String
    Dim cLeitor As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        CadastrarDevolucao.txtCodItem.Text = cItem1
        CadastrarDevolucao.txtNomeItem.Text = nItem2
        CadastrarDevolucao.txtNumExemplar.Text = nExemp3
        CadastrarDevolucao.txtTipoItem.Text = tItem4
        CadastrarDevolucao.txtLocalizacao.Text = locali5
        CadastrarDevolucao.txtCodLeitor.Text = cLeitor
        CadastrarDevolucao.txtNomeLeitor.Text = nLeitor6
        CadastrarDevolucao.txtDataEmprest.Text = datee7
        CadastrarDevolucao.txtPrazoDev.Text = Prazoo8

        Me.Dispose()
        CadastrarDevolucao.Show()
    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cItem1 = dgvInformacoes.SelectedCells(0).Value
        nItem2 = dgvInformacoes.SelectedCells(1).Value
        nExemp3 = dgvInformacoes.SelectedCells(2).Value
        tItem4 = dgvInformacoes.SelectedCells(3).Value
        locali5 = dgvInformacoes.SelectedCells(4).Value
        cLeitor = dgvInformacoes.SelectedCells(5).Value
        nLeitor6 = dgvInformacoes.SelectedCells(6).Value
        datee7 = dgvInformacoes.SelectedCells(7).Value
        Prazoo8 = dgvInformacoes.SelectedCells(8).Value

    End Sub

End Class