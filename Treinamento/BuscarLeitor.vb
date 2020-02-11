Imports System.Data.SqlClient

Public Class BuscarLeitor
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM Treinamento.dbo.MvtBIBLeitor", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codLeitor"), dr.Item("nome"), dr.Item("sexo"), dr.Item("dataNascimento"),
            dr.Item("cpf"), dr.Item("rg"), dr.Item("email"), dr.Item("telefone"), dr.Item("telefoneCelular"), dr.Item("enderecoNome"), dr.Item("enderecoBairro"),
            dr.Item("enderecoCidade"), dr.Item("enderecoCEP"), dr.Item("enderecoUF"), dr.Item("enderecoNumero"))
                    Me.dgvInformacoes.AutoResizeColumns()
                End While
            End Using

        End Using

    End Sub

    Private Sub BuscarCAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
    End Sub

    Dim cod As String
    Dim nome As String

    Private Sub btnSelecionar_Click(sender As Object, e As EventArgs) Handles btnSelecionar.Click

        Reserva.txtCodLeitor.Text = cod
        Reserva.txtLeitor.Text = nome
        Me.Dispose()
        Reserva.Show()

    End Sub

    Private Sub dgvCodigos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        cod = dgvInformacoes.SelectedCells(0).Value
        nome = dgvInformacoes.SelectedCells(1).Value

    End Sub
End Class