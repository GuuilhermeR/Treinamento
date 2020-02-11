Imports System.Data.SqlClient
Public Class ConsultaEmprestimo
    Public objBanco As New mdlAcesso
    Dim objConexao As SqlClient.SqlConnection = New SqlClient.SqlConnection(objBanco.Conexao)

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        dgvInformacoes.DataSource = Nothing
        Me.Hide()
        Form1.Show()
        ClearTextBoxes(Me)
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If txtNomeLeitor.Text <> Nothing Then
            BuscarPorNomeLeitor()
        ElseIf txtPrazoDevolucao.Text <> " " Then
            BuscarPorData()
        ElseIf txtNomeItm.Text <> " " Then
            BuscarPorNomeItem()
        Else
            BuscarTudo()
        End If
        ClearTextBoxes(Me)
    End Sub

    Public Sub BuscarPorNomeItem()
        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("Select MvtBIBEmprestimo.codEmprestimo, MvtBIBItemAcervo.nomeItem, MvtBIBItemAcervo.tipoItem, 
        MvtBIBLocal.descricaoLocal, MvtBIBAutor.nomeAutor,  MvtBIBLeitor.nome, 
        MvtBIBSecao.descricaoSecao, MvtBIBEmprestimo.dataEmprestimo, MvtBIBEmprestimo.dataDevolucao, MvtBIBItemAcervo.status 
        From MvtBIBEmprestimo, MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBLeitor, MvtBIBSecao
        Where MvtBIBEmprestimo.codItem = MvtBIBItemAcervo.codItem And MvtBIBEmprestimo.codLeitor = MvtBIBLeitor.codLeitor
       And MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor And MvtBIBSecao.codSecao = MvtBIBItemAcervo.Secao 
        And MvtBIBLocal.codLocal = MvtBIBItemAcervo.codLocal And MvtBIBItemAcervo.nomeItem like '%" + txtNomeItm.Text + "%'")

        dgvInformacoes.DataSource = ds.Tables(0)

        objBanco.Fechar()
    End Sub

    Public Sub BuscarPorNomeLeitor()
        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("Select MvtBIBEmprestimo.codEmprestimo, MvtBIBItemAcervo.nomeItem, MvtBIBItemAcervo.tipoItem, 
        MvtBIBLocal.descricaoLocal, MvtBIBAutor.nomeAutor,  MvtBIBLeitor.nome, 
        MvtBIBSecao.descricaoSecao, MvtBIBEmprestimo.dataEmprestimo, MvtBIBEmprestimo.dataDevolucao, MvtBIBItemAcervo.status 
        From MvtBIBEmprestimo, MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBLeitor, MvtBIBSecao
        Where MvtBIBEmprestimo.codItem = MvtBIBItemAcervo.codItem And MvtBIBEmprestimo.codLeitor = MvtBIBLeitor.codLeitor
       And MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor And MvtBIBSecao.codSecao = MvtBIBItemAcervo.Secao 
        And MvtBIBLocal.codLocal = MvtBIBItemAcervo.codLocal And MvtBIBLeitor.nome like '%" + txtNomeLeitor.Text + "%'")

        dgvInformacoes.DataSource = ds.Tables(0)

        objBanco.Fechar()
    End Sub

    Public Sub BuscarPorData()
        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("Select MvtBIBEmprestimo.codEmprestimo, MvtBIBItemAcervo.nomeItem, MvtBIBItemAcervo.tipoItem, 
        MvtBIBLocal.descricaoLocal, MvtBIBAutor.nomeAutor,  MvtBIBLeitor.nome, 
        MvtBIBSecao.descricaoSecao, MvtBIBEmprestimo.dataEmprestimo, MvtBIBEmprestimo.dataDevolucao, MvtBIBItemAcervo.status 
        From MvtBIBEmprestimo, MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBLeitor, MvtBIBSecao
        Where MvtBIBEmprestimo.codItem = MvtBIBItemAcervo.codItem And MvtBIBEmprestimo.codLeitor = MvtBIBLeitor.codLeitor
       And MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor And MvtBIBSecao.codSecao = MvtBIBItemAcervo.Secao 
        And MvtBIBLocal.codLocal = MvtBIBItemAcervo.codLocal And MvtBIBEmprestimo.prazoDevolucao = '" + txtPrazoDevolucao.Text + "'")

        dgvInformacoes.DataSource = ds.Tables(0)

        objBanco.Fechar()
    End Sub

    Public Sub BuscarTudo()
        objBanco.Conectar()

        Dim ds As DataSet = objBanco.ExecuteQuery("Select MvtBIBEmprestimo.codEmprestimo, MvtBIBItemAcervo.nomeItem, MvtBIBItemAcervo.tipoItem, 
        MvtBIBLocal.descricaoLocal, MvtBIBAutor.nomeAutor, MvtBIBLeitor.nome, 
        MvtBIBSecao.descricaoSecao , MvtBIBEmprestimo.dataEmprestimo, MvtBIBEmprestimo.dataDevolucao, MvtBIBItemAcervo.status 
        From MvtBIBEmprestimo, MvtBIBItemAcervo, MvtBIBLocal, MvtBIBAutor, MvtBIBLeitor, MvtBIBSecao
        Where MvtBIBEmprestimo.codItem = MvtBIBItemAcervo.codItem And MvtBIBEmprestimo.codLeitor = MvtBIBLeitor.codLeitor
       And MvtBIBItemAcervo.codAutor = MvtBIBAutor.codAutor And MvtBIBSecao.codSecao = MvtBIBItemAcervo.Secao 
        And MvtBIBLocal.codLocal = MvtBIBItemAcervo.codLocal")

        dgvInformacoes.DataSource = ds.Tables(0)

        objBanco.Fechar()
    End Sub


    Private Sub txtPrazoDevolucao_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtPrazoDevolucao.KeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            txtPrazoDevolucao.CustomFormat = " "
        End If
    End Sub

    Private Sub txtPrazoDevolucao_ValueChanged_1(sender As Object, e As EventArgs) Handles txtPrazoDevolucao.ValueChanged
        txtPrazoDevolucao.CustomFormat = "yyyy-MM-dd"
    End Sub

End Class