Imports System.Data.SqlClient

Public Class CadastrarEditora
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub CadastrarEditora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
        txtCodg.ReadOnly = True
        ClearTextBoxes(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodg.ReadOnly = True
    End Sub

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If
        Using cmd As New SqlCommand("SELECT * FROM MvtBIBEditora", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codEditora"), dr.Item("nome"))
                End While
            End Using

        End Using

        objConexao.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtNome.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo do nome da Editora")

        Else
            Try
                objConexao.Open()
                Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBEditora (nome) values (@nome)"

                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@nome", txtNome.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")
            End Try
        End If
        ClearTextBoxes(Me)
        PCarregaInfo()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodg.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodg.ReadOnly = False
        Else
            Try
                objConexao.Open()
                Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBEditora WHERE codEditora = @codEditora"
                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@codEditora", txtCodg.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                objConexao.Close()

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
            End Try
        End If
        ClearTextBoxes(Me)
        PCarregaInfo()

    End Sub

    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBEditora WHERE codEditora =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub
    Private Sub txtCodg_TextChanged(sender As Object, e As EventArgs) Handles txtCodg.TextChanged
        objBanco.Conectar()

        If txtCodg.Text <> Nothing Then

            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * FROM MvtBIBEditora WHERE codEditora like " + txtCodg.Text, objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("codEditora"), dr.Item("nome"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()
    End Sub


    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        objBanco.Conectar()

        If txtNome.Text <> Nothing Then

            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * from MvtBIBEditora where nome like '%" + txtNome.Text + "%'", objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("codEditora"), dr.Item("nome"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()
    End Sub

    Dim Cod As String
    Dim Name2 As String



    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Cod = dgvInformacoes.SelectedCells(0).Value
        Name2 = dgvInformacoes.SelectedCells(1).Value

        txtCodg.Text = Cod
        txtNome.Text = Name2

        txtCodg.ReadOnly = True
        txtNome.ReadOnly = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtNome.ReadOnly = False
        txtCodg.ReadOnly = True

        txtCodg.ResetText()
        txtNome.ResetText()
    End Sub
End Class