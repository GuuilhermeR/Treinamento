Imports System.Data.SqlClient

Public Class CadastrarLeitor
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub PCarregaInfo()
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBLeitor", objConexao)
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

        objConexao.Close()
    End Sub

    Private Sub CadastrarLeitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
        txtCodg.ReadOnly = True
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodg.ReadOnly = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodg.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodg.ReadOnly = False
        Else

            Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBLeitor WHERE codLeitor = @codLeitor"
            Dim cmd As New SqlCommand(lqs, objConexao)
            cmd.Parameters.Add(New SqlParameter("@codLeitor", txtCodg.Text))

            If txtCodg.Text.Trim().Length = 0 Then
                MessageBox.Show("Favor preencher o campo do código do leitor para ser excluído")
            Else
                Try

                    objConexao.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                    objConexao.Close()
                    txtCodg.ReadOnly = True
                Catch ex As Exception
                    MsgBox("Ocorreu um erro ao excluir os dados", vbInformation, "Atenção!")
                    txtCodg.ReadOnly = True
                End Try
            End If
        End If
        ClearTextBoxes(Me)
        PCarregaInfo()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtNome.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo do nome do leitor")
        ElseIf txtSexo.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo de sexo do leitor")
        ElseIf txtDtNasc.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo da data de nascimento do leitor")
        ElseIf txtRua.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo da rua do leitor")
        ElseIf txtBairro.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo do bairro do leitor")
        ElseIf txtCidade.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo da cidade do leitor")
        ElseIf txtUF.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo da UF do leitor")
        Else

            Try
                objConexao.Open()

                Dim lqs As String = "INSERT INTO MvtBIBLeitor (nome, sexo, dataNascimento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, 
    enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero) values (@nome, @sexo, @dataNascimento, @cpf, @rg, @email, @telefone,
    @telefoneCelular, @enderecoNome, @enderecoBairro, @enderecoCidade, @enderecoCEP, @enderecoUF, @enderecoNumero)"

                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@nome", txtNome.Text))
                cmd.Parameters.Add(New SqlParameter("@sexo", txtSexo.Text))
                cmd.Parameters.Add(New SqlParameter("@dataNascimento", txtDtNasc.Text))
                cmd.Parameters.Add(New SqlParameter("@cpf", txtCPF.Text))
                cmd.Parameters.Add(New SqlParameter("@rg", txtRG.Text))
                cmd.Parameters.Add(New SqlParameter("@email", txtEmail.Text))
                cmd.Parameters.Add(New SqlParameter("@telefone", txtTelefone.Text))
                cmd.Parameters.Add(New SqlParameter("@telefoneCelular", txtCelular.Text))
                cmd.Parameters.Add(New SqlParameter("@enderecoNome", txtRua.Text))
                cmd.Parameters.Add(New SqlParameter("@enderecoBairro", txtBairro.Text))
                cmd.Parameters.Add(New SqlParameter("@enderecoCidade", txtCidade.Text))
                cmd.Parameters.Add(New SqlParameter("@enderecoCEP", txtCEP.Text))
                cmd.Parameters.Add(New SqlParameter("@enderecoUF", txtUF.Text))
                cmd.Parameters.Add(New SqlParameter("@enderecoNumero", txtNumero.Text))

                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")

                objConexao.Close()
            End Try
            Me.dgvInformacoes.AutoResizeColumns()
            ClearTextBoxes(Me)
            PCarregaInfo()
        End If

    End Sub

    Private Sub txtCodg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodg.KeyPress
        SomenteNumeros(sender, e)
    End Sub

    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtCPF_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCPF.KeyPress
        If IsNumeric(e.KeyChar) AndAlso txtCPF.TextLength < txtCPF.MaxLength Then
            txtCPF.Text &= e.KeyChar
            txtCPF.SelectionStart = txtCPF.TextLength
            formatacpf(sender)
        End If
        e.Handled = True
    End Sub

    Private Sub txtTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefone.KeyPress
        SomenteNumeros(sender, e)
    End Sub

    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        SomenteNumeros(sender, e)
    End Sub

    Private Sub txtCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCEP.KeyPress
        SomenteNumeros(sender, e)
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        SomenteNumeros(sender, e)
    End Sub

    Private Sub txtRG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRG.KeyPress
        SomenteNumeros(sender, e)
    End Sub

    Private Sub dgvInformacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInformacoes.CellContentClick
        dgvInformacoes.Columns(4).DefaultCellStyle.Format = "yyyy-MM-dd"
    End Sub

    Private Sub txtCPF_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCPF.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            txtCPF.Text = " "
        End If
    End Sub

    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBLeitor WHERE codLeitor =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub
    Private Sub txtCodg_TextChanged(sender As Object, e As EventArgs) Handles txtCodg.TextChanged
        objBanco.Conectar()

        If txtCodg.Text <> "" Then

            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * FROM MvtBIBLeitor WHERE codLeitor = " + txtCodg.Text, objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("codLeitor"), dr.Item("nome"), dr.Item("sexo"), dr.Item("dataNascimento"),
            dr.Item("cpf"), dr.Item("rg"), dr.Item("email"), dr.Item("telefone"), dr.Item("telefoneCelular"), dr.Item("enderecoNome"), dr.Item("enderecoBairro"),
            dr.Item("enderecoCidade"), dr.Item("enderecoCEP"), dr.Item("enderecoUF"), dr.Item("enderecoNumero"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()
    End Sub


    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        objBanco.Conectar()

        If txtNome.Text <> "" Then
            If objConexao.State = ConnectionState.Closed Then
                objConexao.Open()
            End If

            Dim command As New SqlCommand("Select * from MvtBIBLeitor where nome like '%" + txtNome.Text + "%'", objConexao)
            Dim dr As SqlDataReader

            dr = command.ExecuteReader()

            dgvInformacoes.Rows.Clear()

            While dr.Read()
                Me.dgvInformacoes.Rows.Add(dr.Item("codLeitor"), dr.Item("nome"), dr.Item("sexo"), dr.Item("dataNascimento"),
            dr.Item("cpf"), dr.Item("rg"), dr.Item("email"), dr.Item("telefone"), dr.Item("telefoneCelular"), dr.Item("enderecoNome"), dr.Item("enderecoBairro"),
            dr.Item("enderecoCidade"), dr.Item("enderecoCEP"), dr.Item("enderecoUF"), dr.Item("enderecoNumero"))
            End While
            objConexao.Close()
        Else
            PCarregaInfo()
        End If

        objBanco.Fechar()
    End Sub

    Dim Cod7 As String
    Dim Name3 As String
    Dim cpf4 As String
    Dim rg4 As String
    Dim emal8 As String
    Dim sex5 As String
    Dim telefone2 As String
    Dim telcel33 As String
    Dim cidade8 As String
    Dim uf7 As String
    Dim bairro8 As String
    Dim rua99 As String
    Dim numero6 As String
    Dim cep6 As String
    Dim dtaa As String

    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Cod7 = dgvInformacoes.SelectedCells(0).Value
        Name3 = dgvInformacoes.SelectedCells(1).Value
        cpf4 = dgvInformacoes.SelectedCells(4).Value
        rg4 = dgvInformacoes.SelectedCells(5).Value
        emal8 = dgvInformacoes.SelectedCells(6).Value
        sex5 = dgvInformacoes.SelectedCells(2).Value
        telefone2 = dgvInformacoes.SelectedCells(7).Value
        telcel33 = dgvInformacoes.SelectedCells(8).Value
        cidade8 = dgvInformacoes.SelectedCells(11).Value
        uf7 = dgvInformacoes.SelectedCells(13).Value
        bairro8 = dgvInformacoes.SelectedCells(10).Value
        rua99 = dgvInformacoes.SelectedCells(9).Value
        numero6 = dgvInformacoes.SelectedCells(14).Value
        cep6 = dgvInformacoes.SelectedCells(12).Value
        dtaa = dgvInformacoes.SelectedCells(3).Value

        txtCodg.Text = Cod7
        txtNome.Text = Name3
        txtCPF.Text = cpf4
        txtRG.Text = rg4
        txtEmail.Text = emal8
        txtSexo.Text = sex5
        txtTelefone.Text = telefone2
        txtCelular.Text = telcel33
        txtCidade.Text = cidade8
        txtUF.Text = uf7
        txtBairro.Text = bairro8
        txtRua.Text = rua99
        txtNumero.Text = numero6
        txtCEP.Text = cep6
        txtDtNasc.Text = dtaa

        txtCodg.ReadOnly = True
        txtNome.ReadOnly = True
        txtCPF.ReadOnly = True
        txtRG.ReadOnly = True
        txtEmail.ReadOnly = True
        txtSexo.ReadOnly = True
        txtTelefone.ReadOnly = True
        txtCelular.ReadOnly = True
        txtCidade.ReadOnly = True
        txtBairro.ReadOnly = True
        txtRua.ReadOnly = True
        txtNumero.ReadOnly = True
        txtCEP.ReadOnly = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PCarregaInfo()
        txtCodg.ReadOnly = True
        txtNome.ReadOnly = False
        txtCPF.ReadOnly = False
        txtRG.ReadOnly = False
        txtEmail.ReadOnly = False
        txtSexo.ReadOnly = False
        txtTelefone.ReadOnly = True
        txtCelular.ReadOnly = True
        txtCidade.ReadOnly = True
        txtBairro.ReadOnly = True
        txtRua.ReadOnly = False
        txtNumero.ReadOnly = False
        txtCEP.ReadOnly = False

        txtCodg.ResetText()
        txtNome.ResetText()
        txtCPF.ResetText()
        txtRG.ResetText()
        txtEmail.ResetText()
        txtSexo.ResetText()
        txtTelefone.ResetText()
        txtCelular.ResetText()
        txtCidade.ResetText()
        txtBairro.ResetText()
        txtRua.ResetText()
        txtNumero.ResetText()
        txtCEP.ResetText()
        txtUF.ResetText()
        txtDtNasc.ResetText()

    End Sub
End Class