Imports System.Data.SqlClient


Public Class ConsultaItemAcervo
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Hide()
        Form1.Show()
        dgvInformacoes.DataSource = Nothing
        ClearTextBoxes(Me)
    End Sub

    Private Sub PCarregaCod()
        dgvInformacoes.DataSource = Nothing
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        If txtCodg.Text = Nothing Then
            PCarregaNome()
        Else

            Using cmd As New SqlCommand("SELECT MvtBIBItemAcervo.codItem, MvtBIBItemAcervo.numExemplar, MvtBIBLocal.descricaoLocal, MvtBIBItemAcervo.nomeItem,
    MvtBIBAutor.nomeAutor, MvtBIBEditora.nome, MvtBIBItemAcervo.tipoItem, MvtBIBItemAcervo.isbn, MvtBIBItemAcervo.volume,
    MvtBIBItemAcervo.anoEdicao, MvtBIBItemAcervo.localizacao, MvtBIBItemAcervo.secao, MvtBIBItemAcervo.idioma,
    MvtBIBColecao.nomeColecao, MvtBIBItemAcervo.status


    From MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBEditora, MvtBIBColecao, MvtBIBSecao 


    WHERE MvtBIBItemAcervo.codLocal = MvtBIBLocal.codLocal And MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor And
    MvtBIBItemAcervo.codColecao = MvtBIBColecao.codColecao And MvtBIBItemAcervo.codEditora = MvtBIBEditora.codEditora And
    MvtBIBSecao.codSecao = MvtBIBItemAcervo.secao and MvtBIBItemAcervo.codItem = " + txtCodg.Text, objConexao)
                Using dr As SqlDataReader = cmd.ExecuteReader
                    dgvInformacoes.Rows.Clear()

                    While dr.Read()
                        Me.dgvInformacoes.Rows.Add(dr.Item("codItem"), dr.Item("numExemplar"), dr.Item("descricaoLocal"), dr.Item("nomeItem"), dr.Item("nomeAutor"),
                         dr.Item("nome"), dr.Item("tipoItem"), dr.Item("isbn"), dr.Item("volume"), dr.Item("anoEdicao"), dr.Item("localizacao"), dr.Item("secao"),
                         dr.Item("idioma"), dr.Item("nomeColecao"), dr.Item("status"))
                    End While
                    Me.dgvInformacoes.AutoResizeColumns()
                End Using

            End Using

        End If
        objConexao.Close()

    End Sub

    Private Sub PCarregaNome()
        dgvInformacoes.DataSource = Nothing
        If objConexao.State = ConnectionState.Closed Then
            objConexao.Open()
        End If

        Using cmd As New SqlCommand("SELECT MvtBIBItemAcervo.codItem, MvtBIBItemAcervo.numExemplar, MvtBIBLocal.descricaoLocal, MvtBIBItemAcervo.nomeItem,
    MvtBIBAutor.nomeAutor, MvtBIBEditora.nome, MvtBIBItemAcervo.tipoItem, MvtBIBItemAcervo.isbn, MvtBIBItemAcervo.volume,
    MvtBIBItemAcervo.anoEdicao, MvtBIBItemAcervo.localizacao, MvtBIBItemAcervo.secao, MvtBIBItemAcervo.idioma,
    MvtBIBColecao.nomeColecao, MvtBIBItemAcervo.status


    From MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBEditora, MvtBIBColecao, MvtBIBSecao 


    WHERE MvtBIBItemAcervo.codLocal = MvtBIBLocal.codLocal And MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor And
    MvtBIBItemAcervo.codColecao = MvtBIBColecao.codColecao And MvtBIBItemAcervo.codEditora = MvtBIBEditora.codEditora And
    MvtBIBSecao.codSecao = MvtBIBItemAcervo.secao and MvtBIBItemAcervo.nomeItem Like '%" + txtNome.Text + "%'", objConexao)
            Using dr As SqlDataReader = cmd.ExecuteReader
                dgvInformacoes.Rows.Clear()

                While dr.Read()
                    Me.dgvInformacoes.Rows.Add(dr.Item("codItem"), dr.Item("numExemplar"), dr.Item("descricaoLocal"), dr.Item("nomeItem"), dr.Item("nomeAutor"),
                 dr.Item("nome"), dr.Item("tipoItem"), dr.Item("isbn"), dr.Item("volume"), dr.Item("anoEdicao"), dr.Item("localizacao"), dr.Item("secao"),
                 dr.Item("idioma"), dr.Item("nomeColecao"), dr.Item("status"))

                    'Dim indiceLinha As Integer = Me.dgvInformacoes.Rows.Add()
                    'Dim novaLinha As DataGridViewRow = Me.dgvInformacoes.Rows(indiceLinha)

                    'novaLinha.Cells(codItem.Index).Value = dr("codItem")

                End While
            End Using

        End Using

        objConexao.Close()
    End Sub

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        If rbCodigo.Checked Then
            PCarregaCod()

        ElseIf rbNome.Checked Then
            PCarregaNome()
        End If
        ClearTextBoxes(Me)
    End Sub

    Private Sub rbCodigo_MouseClick(sender As Object, e As MouseEventArgs) Handles rbCodigo.MouseClick
        dgvInformacoes.DataSource = Nothing

    End Sub

    Private Sub rbNome_MouseClick(sender As Object, e As MouseEventArgs) Handles rbNome.MouseClick
        dgvInformacoes.DataSource = Nothing

    End Sub

    Dim Cod As String
    Dim Nome As String
    Dim Tipo As String
    Dim CLocal As String
    Dim CAutor As String
    Dim CColecao As String
    Dim Cisbn As String
    Dim Csecao As String
    Dim idio As String
    Dim stat As String

    Private Sub dgvInformacoes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvInformacoes.RowHeaderMouseClick

        Cod = dgvInformacoes.SelectedCells(codItem.Index).Value
        Nome = dgvInformacoes.SelectedCells(nomeItem.Index).Value
        Tipo = dgvInformacoes.SelectedCells(tipoItem.Index).Value
        CLocal = dgvInformacoes.SelectedCells(nomeLocal.Index).Value
        CAutor = dgvInformacoes.SelectedCells(nomeAutor.Index).Value
        CColecao = dgvInformacoes.SelectedCells(nomeColecao.Index).Value
        Cisbn = dgvInformacoes.SelectedCells(isbn.Index).Value
        Csecao = dgvInformacoes.SelectedCells(secao.Index).Value
        idio = dgvInformacoes.SelectedCells(idioma.Index).Value
        stat = dgvInformacoes.SelectedCells(status.Index).Value

        txtCodg.Text = Cod
        txtNome.Text = Nome
        txtTipoItem.Text = Tipo
        txtCodLocal.Text = CLocal
        txtCodAutor.Text = CAutor
        txtCodColecao.Text = CColecao
        txtISBN.Text = Cisbn
        txtCodSecao.Text = Csecao
        txtIdioma.Text = idio
        txtStatus.Text = stat

    End Sub

End Class