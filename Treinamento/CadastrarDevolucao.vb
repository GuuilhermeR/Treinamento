Imports System.Data.SqlClient

Public Class CadastrarDevolucao

    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub CadastrarDevolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodg.ReadOnly = True
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodg.ReadOnly = True
    End Sub

    Private Sub PCarregaInfo()

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT codEmprestimo, codItem, nomeItem, numExemplar, tipoItem, localizacao, nomeLeitor, dataEmprestimo, prazoDevolucao, dataDevolucao, devolvido 
    FROM Treinamento.dbo.MvtBIBEmprestimo", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codEmprestimo"), dr.Item("nomeItem"), dr.Item("codItem"), dr.Item("numExemplar"), dr.Item("tipoItem"), dr.Item("localizacao"),
                                        dr.Item("nomeLeitor"), dr.Item("dataEmprestimo"), dr.Item("prazoDevolucao"), dr.Item("dataDevolucao"), dr.Item("devolvido"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            objConexao.Open()

            Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBEmprestimo ( codItem, nomeItem, numExemplar, tipoItem, localizacao, codLeitor,
    nomeLeitor, dataEmprestimo, prazoDevolucao, dataDevolucao, devolvido) values ( @codItem, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor,
    @dataEmprestimo, @prazoDevolucao, @dataDevolucao, @devolvido)"

            Dim cmd As New SqlCommand(lqs, objConexao)
            cmd.Parameters.Add(New SqlParameter("@codItem", txtCodItem.Text))
            cmd.Parameters.Add(New SqlParameter("@nomeItem", txtNomeItem.Text))
            cmd.Parameters.Add(New SqlParameter("@numExemplar", txtNumExemplar.Text))
            cmd.Parameters.Add(New SqlParameter("@tipoItem", txtTipoItem.Text))
            cmd.Parameters.Add(New SqlParameter("@localizacao", txtLocalizacao.Text))
            cmd.Parameters.Add(New SqlParameter("@codLeitor", txtCodLeitor.Text))
            cmd.Parameters.Add(New SqlParameter("@nomeLeitor", txtNomeLeitor.Text))
            cmd.Parameters.Add(New SqlParameter("@dataEmprestimo", txtDataEmprest.Text))
            cmd.Parameters.Add(New SqlParameter("@prazoDevolucao", txtDataEmprest.Text))
            cmd.Parameters.Add(New SqlParameter("@dataDevolucao", txtDataDevolucao.Text))
            cmd.Parameters.Add(New SqlParameter("@devolvido", cbDevolvido.Checked))

            Dim lqs2 As String
            If cbDevolvido.CheckState Then

                lqs2 = "UPDATE Treinamento.dbo.MvtBIBItemAcervo SET status = 'Disponível' WHERE codItem =" + txtCodItem.Text

            Else

                lqs2 = "UPDATE Treinamento.dbo.MvtBIBItemAcervo SET status = 'Emprestado' WHERE codItem =" + txtCodItem.Text

            End If

            cmd.ExecuteNonQuery()
            Dim cmd2 As New SqlCommand(lqs2, objConexao)
            cmd2.ExecuteNonQuery()
            MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
            objConexao.Close()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")

            objConexao.Close()
        End Try
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        PesquisarItemEmprestado.Show()
        Me.Hide()
    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        If txtCodg.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodg.ReadOnly = False
        Else
            Try
                objConexao.Open()
                Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBEmprestimo WHERE codEmprestimo = @codEmprestimo"
                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@codEmprestimo", txtCodg.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Os dados foram excluídos", vbInformation, "Atenção!")
                objConexao.Close()

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
            End Try
        End If
        PCarregaInfo()
    End Sub

    Private Sub txtDataDevolucao_ValueChanged_1(sender As Object, e As EventArgs) Handles txtDataDevolucao.ValueChanged
        txtDataDevolucao.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub txtDataDevolucao_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtDataDevolucao.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            txtDataDevolucao.CustomFormat = " "
        End If
    End Sub
    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBEmprestimo WHERE codItem =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub

    Private Sub txtCodItem_TextChanged(sender As Object, e As EventArgs) Handles txtCodItem.TextChanged
        objBanco.Conectar()

        If txtCodItem.Text <> Nothing Then
            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * FROM MvtBIBEmprestimo WHERE codItem = " + txtCodItem.Text, objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("codEmprestimo"), dr.Item("nomeItem"), dr.Item("numExemplar"), dr.Item("codItem"), dr.Item("tipoItem"), dr.Item("localizacao"),
                                           dr.Item("nomeLeitor"), dr.Item("dataEmprestimo"), dr.Item("prazoDevolucao"), dr.Item("dataDevolucao"), dr.Item("devolvido"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()



    End Sub

    Dim codIm As String
    Dim namIte As String
    Dim NExem As String
    Dim tItem As String
    Dim localz As String
    Dim nLeit As String
    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        codIm = dgvInformacoes.SelectedCells(3).Value
        namIte = dgvInformacoes.SelectedCells(1).Value
        NExem = dgvInformacoes.SelectedCells(2).Value
        tItem = dgvInformacoes.SelectedCells(4).Value
        localz = dgvInformacoes.SelectedCells(5).Value
        nLeit = dgvInformacoes.SelectedCells(6).Value


        txtCodg.Text = codIm
        txtNomeItem.Text = namIte
        txtNumExemplar.Text = NExem
        txtTipoItem.Text = tItem
        txtLocalizacao.Text = localz
        txtNomeLeitor.Text = nLeit


    End Sub
End Class