Imports System.Data.SqlClient
Public Class CadastrarLocal
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodLocal.ReadOnly = True
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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtDescLocal.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo de descrição")
            Exit Sub
        End If

        Try
            objConexao.Open()

            Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBLocal (descricaoLocal) values (@descricaoLocal)"

            Dim cmd As New SqlCommand(lqs, objConexao)
            cmd.Parameters.Add(New SqlParameter("@descricaoLocal", txtDescLocal.Text))

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

    Private Sub CadastrarLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
        txtCodLocal.ReadOnly = True
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        If txtCodLocal.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodLocal.ReadOnly = False
        Else
            Try

                objConexao.Open()
                Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBLocal WHERE codLocal = @codLocal"
                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@codLocal", txtCodLocal.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                objConexao.Close()
                txtCodLocal.ReadOnly = True
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
                txtCodLocal.ReadOnly = True
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

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBLocal WHERE codLocal =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub
    Private Sub txtCodg_TextChanged(sender As Object, e As EventArgs) Handles txtCodLocal.TextChanged
        objBanco.Conectar()

        If txtCodLocal.Text <> "" Then

            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * FROM MvtBIBLocal WHERE codLocal like " + txtCodLocal.Text, objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("codLocal"), dr.Item("descricaoLocal"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()
    End Sub

    Dim Cod As String
    Dim desc2 As String



    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Cod = dgvInformacoes.SelectedCells(0).Value
        desc2 = dgvInformacoes.SelectedCells(1).Value

        txtCodLocal.Text = Cod
        txtDescLocal.Text = desc2

        txtCodLocal.ReadOnly = True
        txtDescLocal.ReadOnly = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDescLocal.ReadOnly = False
        txtCodLocal.ReadOnly = True

        txtCodLocal.ResetText()
        txtDescLocal.ResetText()
    End Sub
End Class