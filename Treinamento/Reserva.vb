Imports System.Data.SqlClient
Public Class Reserva

    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnBuscarItem_Click(sender As Object, e As EventArgs) Handles btnBuscarItem.Click
        Me.Hide()
        BuscarItem.Show()
    End Sub

    Private Sub PCarregaInfo()

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBReserva", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codReserva"), dr.Item("codItem"), dr.Item("nomeItem"), dr.Item("numExemplar"), dr.Item("tipoItem"), dr.Item("localizacao"),
                                       dr.Item("codLeitor"), dr.Item("nomeLeitor"), dr.Item("dataReserva"), dr.Item("prazoReserva"), dr.Item("encerrar"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub btnBuscarLeitor_Click(sender As Object, e As EventArgs) Handles btnBuscarLeitor.Click
        Me.Hide()
        BuscarLeitor.Show()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            objConexao.Open()

            Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBReserva (codItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor,
    nomeLeitor, dataReserva, prazoReserva, encerrar) values (@codItem, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor,
    @dataReserva, @prazoReserva, @encerrar)"

            Dim cmd As New SqlCommand(lqs, objConexao)
            cmd.Parameters.Add(New SqlParameter("@codItem", txtCodItem.Text))
            cmd.Parameters.Add(New SqlParameter("@nomeItem", txtNomeItem.Text))
            cmd.Parameters.Add(New SqlParameter("@numExemplar", txtNumExemplar.Text))
            cmd.Parameters.Add(New SqlParameter("@tipoItem", txtTipoItem.Text))
            cmd.Parameters.Add(New SqlParameter("@localizacao", txtLocalizacao.Text))
            cmd.Parameters.Add(New SqlParameter("@codLeitor", txtCodLeitor.Text))
            cmd.Parameters.Add(New SqlParameter("@nomeLeitor", txtLeitor.Text))
            cmd.Parameters.Add(New SqlParameter("@dataReserva", txtDataReserva.Text))
            cmd.Parameters.Add(New SqlParameter("@prazoReserva", txtPrazo.Text))
            cmd.Parameters.Add(New SqlParameter("@encerrar", cbEncerrar.Checked))

            Dim lqs2 As String
            If cbEncerrar.Checked Then

                lqs2 = "UPDATE Treinamento.dbo.MvtBIBItemAcervo SET status = 'Reservado' WHERE codItem =" + txtCodItem.Text

            Else

                lqs2 = "UPDATE Treinamento.dbo.MvtBIBItemAcervo SET status = 'Disponível' WHERE codItem =" + txtCodItem.Text

            End If

            cmd.ExecuteNonQuery()
            Dim cmd2 As New SqlCommand(lqs2, objConexao)
            cmd2.ExecuteNonQuery()
            MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
            objConexao.Close()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar os dados", ex.Message)
            objConexao.Close()
        End Try
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBReserva WHERE codReserva = @codReserva"
        Dim cmd As New SqlCommand(lqs, objConexao)
        cmd.Parameters.Add(New SqlParameter("@codReserva", txtCodReserva.Text))

        If txtCodReserva.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodReserva.ReadOnly = False
        Else
            Try

                objConexao.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                objConexao.Close()

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao excluir os dados", ex.Message)
            End Try
        End If
        PCarregaInfo()
    End Sub

    Private Sub Reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodReserva.ReadOnly = True
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBReserva WHERE codReserva =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub

    Private Sub txtCodReserva_TextChanged(sender As Object, e As EventArgs) Handles txtCodReserva.TextChanged
        objBanco.Conectar()

        If txtCodItem.Text <> Nothing Then
            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Using cmd As New SqlCommand("Select * FROM MvtBIBReserva WHERE codReserva = " + txtCodReserva.Text, objConexao)
                Using dr As SqlDataReader = cmd.ExecuteReader
                    dgvInformacoes.Rows.Clear()

                    While dr.Read()
                        Me.dgvInformacoes.Rows.Add(dr.Item("codReserva"), dr.Item("codItem"), dr.Item("nomeItem"), dr.Item("numExemplar"), dr.Item("tipoItem"), dr.Item("localizacao"),
                                       dr.Item("codLeitor"), dr.Item("nomeLeitor"), dr.Item("dataReserva"), dr.Item("prazoReserva"), dr.Item("encerrar"))
                    End While
                    objConexao.Close()
                End Using

            End Using

        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()

    End Sub

    Dim Codi As String
    Dim NItm As String
    Dim tIm As String
    Dim localzz As String
    Dim nexmmp As String
    Dim cLtr As String
    Dim nLtr As String
    Dim dRes As String
    Dim pRes As String

    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Codi = dgvInformacoes.SelectedCells(codItemI.Index).Value
        NItm = dgvInformacoes.SelectedCells(nomeItemI.Index).Value
        tIm = dgvInformacoes.SelectedCells(tipoItemI.Index).Value
        localzz = dgvInformacoes.SelectedCells(localizacaoI.Index).Value
        nexmmp = dgvInformacoes.SelectedCells(numExemplarI.Index).Value
        cLtr = dgvInformacoes.SelectedCells(codLeitorI.Index).Value
        nLtr = dgvInformacoes.SelectedCells(nomeLeitorI.Index).Value
        dRes = dgvInformacoes.SelectedCells(dataReservaI.Index).Value
        pRes = dgvInformacoes.SelectedCells(prazoReservaI.Index).Value

        txtCodItem.Text = Codi
        txtNomeItem.Text = NItm
        txtTipoItem.Text = tIm
        txtLocalizacao.Text = localzz
        txtNumExemplar.Text = nexmmp
        txtCodLeitor.Text = cLtr
        txtLeitor.Text = nLtr

    End Sub

End Class