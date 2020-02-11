Imports System.Data.SqlClient
Public Class CadastrarSecao
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodSecao.ReadOnly = True
    End Sub

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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtDescSecao.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo de descrição da seção")
        End If

        Try
            objConexao.Open()

            Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBSecao (descricaoSecao) values (@descricaoSecao)"

            Dim cmd As New SqlCommand(lqs, objConexao)
            cmd.Parameters.Add(New SqlParameter("@descricaoSecao", txtDescSecao.Text))

            cmd.ExecuteNonQuery()
            MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
            objConexao.Close()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")

            objConexao.Close()
        End Try
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        If txtCodSecao.Visible = False Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodSecao.Visible = True
        Else
            Try

                objConexao.Open()
                Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBSecao WHERE codSecao = @codSecao"
                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@codSecao", txtCodSecao.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                objConexao.Close()
                txtCodSecao.Visible = False
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
                txtCodSecao.Visible = False
            End Try
        End If
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub CadastrarSecao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
        txtCodSecao.ReadOnly = True
        ClearTextBoxes(Me)
    End Sub

    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBSecao WHERE codSecao =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub

    Private Sub txtCodg_TextChanged(sender As Object, e As EventArgs) Handles txtCodSecao.TextChanged
        objBanco.Conectar()

        If txtCodSecao.Text <> "" Then
            Dim ds As DataSet = objBanco.ExecuteQuery("Select * FROM MvtBIBSecao WHERE codSecao like " + txtCodSecao.Text)
            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * FROM MvtBIBSecao WHERE codSecao like " + txtCodSecao.Text, objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("CodSecao"), dr.Item("descricaoSecao"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()
    End Sub

    Dim Cod4 As String
    Dim desc5 As String



    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Cod4 = dgvInformacoes.SelectedCells(0).Value
        desc5 = dgvInformacoes.SelectedCells(1).Value

        txtCodSecao.Text = Cod4
        txtDescSecao.Text = desc5

        txtCodSecao.ReadOnly = True
        txtDescSecao.ReadOnly = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDescSecao.ReadOnly = False
        txtCodSecao.ReadOnly = True

        txtCodSecao.ResetText()
        txtDescSecao.ResetText()
    End Sub
End Class