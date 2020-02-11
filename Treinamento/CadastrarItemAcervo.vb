Imports System.Data.SqlClient
Imports System.IO

Public Class CadastrarItemAcervo
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)
    Dim strImgName As String

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

        Using cmd As New SqlCommand("SELECT MvtBIBItemAcervo.codItem, MvtBIBItemAcervo.numExemplar, MvtBIBLocal.descricaoLocal, MvtBIBItemAcervo.nomeItem, 
    MvtBIBAutor.nomeAutor, MvtBIBEditora.nome, MvtBIBItemAcervo.tipoItem, MvtBIBItemAcervo.isbn, MvtBIBItemAcervo.volume, 
	MvtBIBItemAcervo.anoEdicao, MvtBIBItemAcervo.localizacao, MvtBIBItemAcervo.secao, MvtBIBItemAcervo.idioma, MvtBIBColecao.nomeColecao , MvtBIBItemAcervo.status
	FROM MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBEditora, MvtBIBColecao, MvtBIBSecao 
    WHERE MvtBIBItemAcervo.codLocal = MvtBIBLocal.codLocal and MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor and 
    MvtBIBItemAcervo.codColecao = MvtBIBColecao.codColecao and MvtBIBItemAcervo.codEditora = MvtBIBEditora.codEditora and MvtBIBSecao.codSecao = MvtBIBItemAcervo.secao", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codItem"), dr.Item("numExemplar"), dr.Item("descricaoLocal"), dr.Item("nomeItem"), dr.Item("nomeAutor"),
                    dr.Item("nome"), dr.Item("tipoItem"), dr.Item("isbn"), dr.Item("volume"), dr.Item("anoEdicao"), dr.Item("localizacao"),
                    dr.Item("secao"), dr.Item("idioma"), dr.Item("nomeColecao"), dr.Item("status"))
                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If strImgName <> "" Then
                objConexao.Open()

                Dim fs As FileStream
                fs = New FileStream(strImgName, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))

                Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBItemAcervo ( numExemplar, codLocal, nomeItem, codAutor, codEditora,
tipoItem, isbn, volume, anoEdicao, localizacao, secao, idioma, codColecao, status, [foto]) values (@numExemplar, @codLocal, @nomeItem, @codAutor, 
 @codEditora,  @tipoItem, @isbn, @volume, @anoEdicao, @localizacao, @secao, @idioma, @codColecao, @status, @foto)"

                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@numExemplar", txtNumExemplar.Text))
                cmd.Parameters.Add(New SqlParameter("@codLocal", txtCodLocal.Text))
                cmd.Parameters.Add(New SqlParameter("@nomeItem", txtNome.Text))
                cmd.Parameters.Add(New SqlParameter("@codAutor", txtCodAutor.Text))
                cmd.Parameters.Add(New SqlParameter("@codEditora", txtCodEditora.Text))
                cmd.Parameters.Add(New SqlParameter("@tipoItem", cbTipoItem.Text))
                cmd.Parameters.Add(New SqlParameter("@isbn", txtIsbn.Text))
                cmd.Parameters.Add(New SqlParameter("@volume", txtVolume.Text))
                cmd.Parameters.Add(New SqlParameter("@anoEdicao", txtAnoEdicao.Text))
                cmd.Parameters.Add(New SqlParameter("@localizacao", txtLocalizacao.Text))
                cmd.Parameters.Add(New SqlParameter("@secao", txtSecao.Text))
                cmd.Parameters.Add(New SqlParameter("@idioma", cbIdioma.Text))
                cmd.Parameters.Add(New SqlParameter("@codColecao", txtCodColecao.Text))
                cmd.Parameters.Add(New SqlParameter("@status", cbStatus.Text))
                cmd.Parameters.Add(New SqlParameter("@foto", SqlDbType.Binary, picByte.Length)).Value = picByte

                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            Else
                objConexao.Open()

                Dim lqs As String = "INSERT INTO Treinamento.dbo.MvtBIBItemAcervo ( numExemplar, codLocal, nomeItem, codAutor, codEditora,
tipoItem, isbn, volume, anoEdicao, localizacao, secao, idioma, codColecao, status) values (@numExemplar, @codLocal, @nomeItem, @codAutor, 
 @codEditora,  @tipoItem, @isbn, @volume, @anoEdicao, @localizacao, @secao, @idioma, @codColecao, @status )"

                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@numExemplar", txtNumExemplar.Text))
                cmd.Parameters.Add(New SqlParameter("@codLocal", txtCodLocal.Text))
                cmd.Parameters.Add(New SqlParameter("@nomeItem", txtNome.Text))
                cmd.Parameters.Add(New SqlParameter("@codAutor", txtCodAutor.Text))
                cmd.Parameters.Add(New SqlParameter("@codEditora", txtCodEditora.Text))
                cmd.Parameters.Add(New SqlParameter("@tipoItem", cbTipoItem.Text))
                cmd.Parameters.Add(New SqlParameter("@isbn", txtIsbn.Text))
                cmd.Parameters.Add(New SqlParameter("@volume", txtVolume.Text))
                cmd.Parameters.Add(New SqlParameter("@anoEdicao", txtAnoEdicao.Text))
                cmd.Parameters.Add(New SqlParameter("@localizacao", txtLocalizacao.Text))
                cmd.Parameters.Add(New SqlParameter("@secao", txtSecao.Text))
                cmd.Parameters.Add(New SqlParameter("@idioma", cbIdioma.Text))
                cmd.Parameters.Add(New SqlParameter("@codColecao", txtCodColecao.Text))
                cmd.Parameters.Add(New SqlParameter("@status", cbStatus.Text))

                cmd.ExecuteNonQuery()
                MsgBox("Seus dados foram salvos", vbInformation, "Atenção!")
                objConexao.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao salvar os dados" & ex.Message, vbInformation, "Atenção!")

            objConexao.Close()
        End Try

        PCarregaInfo()
        pbImagem.Image = pbImagem.InitialImage

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodg.ReadOnly = True Then
            MsgBox("Campo do código foi habilitado, digite o código a ser excluído", vbInformation, "Atenção!")
            txtCodg.ReadOnly = False
        Else
            Try
                objConexao.Open()
                Dim lqs As String = "DELETE FROM MvtBIBItemAcervo WHERE codItem = @codItem"
                Dim cmd As New SqlCommand(lqs, objConexao)
                cmd.Parameters.Add(New SqlParameter("@codItem", txtCodg.Text))
                cmd.ExecuteNonQuery()
                MsgBox("Dados excluídos com sucesso", vbInformation, "Atenção!")
                objConexao.Close()
                txtCodg.ReadOnly = True
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao excluir os dados" & ex.Message, vbInformation, "Atenção!")
                txtCodg.ReadOnly = True
            End Try
        End If

        ClearTextBoxes(Me)
        PCarregaInfo()
        pbImagem.Image = pbImagem.InitialImage

    End Sub

    Private Sub CadastrarItemAcervo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaInfo()
        txtCodg.ReadOnly = True
        ClearTextBoxes(Me)
        pbImagem.Image = pbImagem.InitialImage
    End Sub

    Private Sub CarregaImagem()

        Dim openfd As New OpenFileDialog

        openfd.Filter = "Imagens (*.jpg;*.png) | *.jpg; *.png"

        If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            strImgName = openfd.FileName

            pbImagem.Image = New System.Drawing.Bitmap(strImgName)

        End If

    End Sub

    Private Sub btnCarregaImagem_Click(sender As Object, e As EventArgs) Handles btnCarregaImagem.Click
        CarregaImagem()
    End Sub

    Private Sub btnBuscarCLocal_Click(sender As Object, e As EventArgs) Handles btnBuscarCLocal.Click
        BuscarCLocal.Show()
        Me.Hide()

    End Sub

    Private Sub btnBuscarCeditora_Click(sender As Object, e As EventArgs) Handles btnBuscarCeditora.Click
        BuscarCeditora.Show()
        Me.Hide()

    End Sub

    Private Sub btnBuscarCautor_Click(sender As Object, e As EventArgs) Handles btnBuscarCautor.Click
        BuscarCAutor.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscarCcolecao_Click(sender As Object, e As EventArgs) Handles btnBuscarCcolecao.Click
        BuscarCcolecao.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarSecao.Show()
        Me.Hide()
    End Sub

    Private Sub dgvInformacoes_DoubleClick(sender As Object, e As EventArgs) Handles dgvInformacoes.DoubleClick

        Dim index As String
        index = dgvInformacoes.SelectedCells(0).Value

        If MsgBox("Deseja excluir o item selecionado?", vbExclamation + vbYesNo, "Deletar Cadastro de Autor") = vbYes Then

            objConexao.Open()

            Dim ds As DataSet = objBanco.ExecuteQuery("DELETE FROM Treinamento.dbo.MvtBIBItemAcervo WHERE codItem =" + index)

            objConexao.Close()
        End If
        PCarregaInfo()
        ClearTextBoxes(Me)
    End Sub

    'Private Sub txtCodg_TextChanged(sender As Object, e As EventArgs) Handles txtCodg.TextChanged
    '    objBanco.Conectar()
    '    If txtCodg.Text <> "" Then

    '        If objConexao.State = ConnectionState.Closed Then
    '            objConexao.Open()
    '        End If

    '        Using cmd As New SqlCommand("Select * FROM MvtBIBItemAcervo WHERE codItem = " + txtCodg.Text, objConexao)
    '            Using dr As SqlDataReader = cmd.ExecuteReader
    '                dgvInformacoes.Rows.Clear()

    '                While dr.Read()
    '                    Me.dgvInformacoes.Rows.Add(dr.Item("codItem"), dr.Item("numExemplar"), dr.Item("codLocal"), dr.Item("nomeItem"), dr.Item("codAutor"),
    '                dr.Item("codEditora"), dr.Item("tipoItem"), dr.Item("isbn"),
    '                dr.Item("volume"), dr.Item("anoEdicao"), dr.Item("localizacao"), dr.Item("secao"), dr.Item("idioma"), dr.Item("codColecao"),
    '                dr.Item("status"))
    '                End While
    '                objConexao.Close()
    '            End Using
    '        End Using


    '    Else
    '        PCarregaInfo()
    '    End If
    '    objBanco.Fechar()
    'End Sub


    'Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
    '    objBanco.Conectar()
    '    If txtNome.Text <> "" Then

    '        If objConexao.State = ConnectionState.Closed Then
    '            objConexao.Open()
    '        End If

    '        Using cmd As New SqlCommand("Select * FROM MvtBIBItemAcervo WHERE codItem = " + txtCodg.Text, objConexao)
    '            Using dr3 As SqlDataReader = cmd.ExecuteReader
    '                dgvInformacoes.Rows.Clear()

    '                While dr3.Read()
    '                    Me.dgvInformacoes.Rows.Add(dr3.Item("codItem"), dr3.Item("numExemplar"), dr3.Item("codLocal"), dr3.Item("nomeItem"), dr3.Item("codAutor"),
    '                dr3.Item("codEditora"), dr3.Item("tipoItem"), dr3.Item("isbn"), dr3.Item("volume"), dr3.Item("anoEdicao"), dr3.Item("localizacao"), dr3.Item("secao"),
    '                dr3.Item("idioma"), dr3.Item("codColecao"), dr3.Item("status"))
    '                End While
    '            End Using
    '        End Using

    '        objConexao.Close()
    '    Else
    '        PCarregaInfo()
    '        objConexao.Close()
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

        Using cmd As New SqlCommand("SELECT * FROM MvtBIBItemAcervo where foto is not null and codItem = " & dgvInformacoes.CurrentRow().Cells(0).Value, objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()

                    If pbImagem.Image IsNot Nothing Then
                        pbImagem.Image.Dispose()
                    End If

                    Dim fsImagemItem As New FileStream("imageItem.jpg", FileMode.Create)
                    Dim blob As Byte() = DirectCast(dr.Item("foto"), Byte())

                    fsImagemItem.Write(blob, 0, blob.Length)
                    fsImagemItem.Close()
                    fsImagemItem = Nothing

                    pbImagem.Image = Image.FromFile("image.jpg")
                    pbImagem.Refresh()


                End If
            End Using

        End Using

        objConexao.Close()

    End Sub

    Dim Cod7 As String
    Dim Name3 As String
    Dim codlcl As String
    Dim ceditora As String
    Dim cautor As String
    Dim ccolecao As String
    Dim nexemp As String
    Dim isbnn As String
    Dim anoedt As String
    Dim localz As String
    Dim volu As String
    Dim sec As String
    Dim idioo As String
    Dim tipit As String
    Dim statss As String
    Dim ccl As String

    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Cod7 = dgvInformacoes.SelectedCells(codItemI.Index).Value
        Name3 = dgvInformacoes.SelectedCells(nomeI.Index).Value
        ceditora = dgvInformacoes.SelectedCells(nomeEditoraI.Index).Value
        cautor = dgvInformacoes.SelectedCells(nomeAutorI.Index).Value
        ccolecao = dgvInformacoes.SelectedCells(nomeColecaoI.Index).Value
        nexemp = dgvInformacoes.SelectedCells(numExemplarI.Index).Value
        isbnn = dgvInformacoes.SelectedCells(isbnI.Index).Value
        anoedt = dgvInformacoes.SelectedCells(anoEdiI.Index).Value
        localz = dgvInformacoes.SelectedCells(localizacaoI.Index).Value
        idioo = dgvInformacoes.SelectedCells(idiomaI.Index).Value
        volu = dgvInformacoes.SelectedCells(volumeI.Index).Value
        tipit = dgvInformacoes.SelectedCells(tipoItemI.Index).Value
        sec = dgvInformacoes.SelectedCells(secaoI.Index).Value
        statss = dgvInformacoes.SelectedCells(statusI.Index).Value
        codlcl = dgvInformacoes.SelectedCells(descricaoLocalI.Index).Value
        PListaAutores()

        txtCodg.Text = Cod7
        txtNome.Text = Name3
        txtLocal.Text = codlcl
        txtEditora.Text = ceditora
        txtAutor.Text = cautor
        txtColecao.Text = ccolecao
        txtNumExemplar.Text = nexemp
        txtIsbn.Text = isbnn
        txtAnoEdicao.Text = anoedt
        txtLocalizacao.Text = localz
        cbIdioma.Text = idioo
        txtVolume.Text = volu
        cbTipoItem.Text = tipit
        txtSecao.Text = sec
        cbStatus.Text = statss

        txtCodg.ReadOnly = True
        txtNome.ReadOnly = True
        txtCodLocal.ReadOnly = True
        txtCodEditora.ReadOnly = True
        txtCodAutor.ReadOnly = True
        txtCodColecao.ReadOnly = True
        txtNumExemplar.ReadOnly = True
        txtIsbn.ReadOnly = True
        txtAnoEdicao.ReadOnly = True
        txtLocalizacao.ReadOnly = True
        txtVolume.ReadOnly = True
        txtSecao.ReadOnly = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PCarregaInfo()
        txtCodg.ReadOnly = True
        txtNome.ReadOnly = False
        txtCodLocal.ReadOnly = False
        txtCodEditora.ReadOnly = False
        txtCodAutor.ReadOnly = False
        txtCodColecao.ReadOnly = False
        txtNumExemplar.ReadOnly = False
        txtIsbn.ReadOnly = False
        txtAnoEdicao.ReadOnly = False
        txtLocalizacao.ReadOnly = False
        txtVolume.ReadOnly = False
        txtSecao.ReadOnly = False

        txtCodg.ResetText()
        txtNome.ResetText()
        txtCodLocal.ResetText()
        txtLocal.ResetText()
        txtCodEditora.ResetText()
        txtEditora.ResetText()
        txtCodAutor.ResetText()
        txtAutor.ResetText()
        txtCodColecao.ResetText()
        txtColecao.ResetText()
        txtNumExemplar.ResetText()
        txtIsbn.ResetText()
        txtAnoEdicao.ResetText()
        txtLocalizacao.ResetText()
        txtVolume.ResetText()
        cbIdioma.ResetText()
        cbTipoItem.ResetText()
        cbStatus.ResetText()
        txtSecao.ResetText()

    End Sub

End Class