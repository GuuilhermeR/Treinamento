Imports System.Data.SqlClient
Imports System.IO

Public Class CadastrarAutor
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)
    Dim strImgName As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
        txtCodg.ReadOnly = True
        txtInfAutor.ReadOnly = False
        txtNome.ReadOnly = False

    End Sub

    Private Sub CadastrarAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
        txtCodg.ReadOnly = True
        txtInfAutor.ReadOnly = False
        txtNome.ReadOnly = False
        ClearTextBoxes(Me)
        pbImagem.Image = pbImagem.InitialImage
    End Sub

    Private Sub PCarregaInfo()

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBAutor", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codAutor"), dr.Item("nomeAutor"), dr.Item("descricao"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtNome.Text.Trim().Length = 0 Then
            MessageBox.Show("Favor preencher o campo do nome do autor")
            Exit Sub
        End If

        Try
            If strImgName <> "" Then
                objConexao.Open()

                Dim fs As FileStream
                fs = New FileStream(strImgName, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))

                Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBAutor (nomeAutor, descricao, [foto]) values (@nomeAutor, @descricao, @foto)"


                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@nomeAutor", txtNome.Text))
                cmd.Parameters.Add(New SqlParameter("@descricao", txtInfAutor.Text))
                cmd.Parameters.Add(New SqlParameter("@foto", SqlDbType.Binary, picByte.Length)).Value = picByte


                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            Else
                objConexao.Open()

                Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBAutor (nomeAutor, descricao) values (@nomeAutor, @descricao)"


                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@nomeAutor", txtNome.Text))
                cmd.Parameters.Add(New SqlParameter("@descricao", txtInfAutor.Text))

                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")

            objConexao.Close()
        End Try
        txtCodg.ReadOnly = True
        PCarregaInfo()
        ClearTextBoxes(Me)
        pbImagem.Image = pbImagem.InitialImage
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodg.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodg.ReadOnly = False
        Else


            Dim lqs As String = "DELETE FROM Treinamento.dbo.MvtBIBAutor WHERE codAutor = @codAutor"
            Dim cmd As New SqlCommand(lqs, objConexao)
            cmd.Parameters.Add(New SqlParameter("@codAutor", txtCodg.Text))

            If txtCodg.Text.Trim().Length = 0 Then
                MessageBox.Show("Favor preencher o campo do código do autor para ser excluído")
            Else
                Try

                    objConexao.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                    objConexao.Close()
                    txtCodg.ReadOnly = True
                Catch ex As Exception
                    MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
                    txtCodg.ReadOnly = True
                End Try
            End If
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
        pbImagem.Image = pbImagem.InitialImage
    End Sub

    Private Sub txtCodg_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CarregaImagem()

        Dim openfd As New OpenFileDialog

        Try
            openfd.Filter = "Imagens (*.jpg;*.png) | *.jpg; *.png"
            If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then

                strImgName = openfd.FileName

                pbImagem.Image = New System.Drawing.Bitmap(strImgName)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCarregaImagem_Click(sender As Object, e As EventArgs) Handles btnCarregaImagem.Click
        CarregaImagem()
    End Sub

    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objBanco.Conectar()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBAutor WHERE codAutor =" + index)

            objBanco.Fechar()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub

    'Private Sub txtCodg_TextChanged(sender As Object, e As EventArgs) Handles txtCodg.TextChanged
    '    objBanco.Conectar()

    '    If txtCodg.Text <> Nothing Then
    '        If objConexao.State = ConnectionState.Closed Then
    '            objConexao.Open()
    '        End If

    '        Dim command As New SqlCommand("Select * FROM MvtBIBAutor WHERE codAutor = " + txtCodg.Text, objConexao)
    '        Dim dr As SqlDataReader

    '        dr = command.ExecuteReader()

    '        dgvInformacoes.Rows.Clear()

    '        While dr.Read()
    '            Me.dgvInformacoes.Rows.Add(dr.Item("codAutor"), dr.Item("nomeAutor"), dr.Item("descricao"))
    '        End While
    '        objConexao.Close()
    '    Else
    '        PCarregaInfo()
    '    End If

    '    objBanco.Fechar()

    'End Sub


    'Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged

    '    objBanco.Conectar()

    '    If txtNome.Text <> Nothing Then

    '        If objConexao.State = ConnectionState.Closed Then
    '            objConexao.Open()
    '        End If

    '        Dim command As New SqlCommand("Select * from MvtBIBAutor where nomeAutor like '%" + txtNome.Text + "%'", objConexao)
    '        Dim dr As SqlDataReader

    '        dr = command.ExecuteReader()

    '        dgvInformacoes.Rows.Clear()

    '        While dr.Read()
    '            Me.dgvInformacoes.Rows.Add(dr.Item("codAutor"), dr.Item("nomeAutor"), dr.Item("descricao"))
    '        End While
    '        objConexao.Close()
    '    Else
    '        PCarregaInfo()
    '    End If

    '    objBanco.Fechar()
    'End Sub

    Private Sub PListaAutores()
        If pbImagem.Image IsNot Nothing And pbImagem IsNot pbImagem.InitialImage Then
            pbImagem.Image.Dispose()
        End If

        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT foto FROM MvtBIBAutor where foto is not null and codAutor = " & dgvInformacoes.CurrentRow().Cells(0).Value, objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()

                    Dim fsImagem As New FileStream("imagem.jpg", FileMode.Create)
                    Dim blob As Byte() = DirectCast(dr.Item("foto"), Byte())

                    fsImagem.Write(blob, 0, blob.Length)
                    fsImagem.Close()
                    fsImagem = Nothing

                    pbImagem.Image = Image.FromFile("image.jpg")
                    pbImagem.Refresh()

                End If
            End Using
        End Using

        objConexao.Close()
    End Sub

    Dim Cod As String
    Dim Name2 As String
    Dim info As String

    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        If pbImagem.Image IsNot Nothing And pbImagem IsNot pbImagem.InitialImage Then
            pbImagem.Image.Dispose()
        End If

        Cod = dgvInformacoes.SelectedCells(codAutorI.Index).Value
        Name2 = dgvInformacoes.SelectedCells(nomeI.Index).Value
        info = dgvInformacoes.SelectedCells(descricaoI.Index).Value


        txtCodg.Text = Cod
        txtNome.Text = Name2
        txtInfAutor.Text = info
        PListaAutores()


        txtCodg.ReadOnly = True
        txtNome.ReadOnly = True
        txtInfAutor.ReadOnly = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PCarregaInfo()
        txtNome.ReadOnly = False
        txtInfAutor.ReadOnly = False
        txtCodg.ReadOnly = True

        txtCodg.ResetText()
        txtNome.ResetText()
        txtInfAutor.ResetText()


    End Sub
End Class