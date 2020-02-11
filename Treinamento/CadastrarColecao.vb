Imports System.Data.SqlClient

Public Class CadastrarColecao
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodg.ReadOnly = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtNomeColecao.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo de nome da coleção")
        Else

            Try
                objConexao.Open()

                Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBColecao ( nomeColecao) values ( @nomeColecao)"

                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@codColecao", txtCodg.Text))
                cmd.Parameters.Add(New SqlParameter("@nomeColecao", txtNomeColecao.Text))


                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")

                objConexao.Close()
            End Try
        End If
        txtCodg.ReadOnly = True
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodg.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodg.ReadOnly = False
        Else
            If txtCodg.Text.Trim().Length = 0 Then
                MessageBox.Show("Favor preencher o campo do código do autor para ser excluído")
            Else
                Try

                    objConexao.Open()
                    Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBColecao WHERE codColecao = @codColecao"
                    Dim cmd As New SqlCommand(lqs, objConexao)
                    cmd.Parameters.Add(New SqlParameter("@codColecao", txtCodg.Text))
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                    objConexao.Close()

                Catch ex As Exception
                    MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
                End Try
            End If
        End If
    End Sub

    Private Sub CadastrarColecao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTextBoxes(Me)
        txtCodg.ReadOnly = True
        PCarregaInfo()
    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        txtCodg.ResetText()
        txtNomeColecao.ResetText()

    End Sub

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

End Class