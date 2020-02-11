<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastrarLeitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodg = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codLeitor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataNascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefoneCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoCidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoCEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoUF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.enderecoNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.txtDtNasc = New System.Windows.Forms.DateTimePicker()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCodigo.Location = New System.Drawing.Point(13, 14)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodg
        '
        Me.txtCodg.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodg.Location = New System.Drawing.Point(16, 37)
        Me.txtCodg.Name = "txtCodg"
        Me.txtCodg.Size = New System.Drawing.Size(100, 20)
        Me.txtCodg.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNome.Location = New System.Drawing.Point(15, 79)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.DarkGray
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(16, 102)
        Me.txtNome.MaxLength = 200
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(306, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(817, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sexo:"
        '
        'txtSexo
        '
        Me.txtSexo.BackColor = System.Drawing.Color.DarkGray
        Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSexo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSexo.Location = New System.Drawing.Point(821, 109)
        Me.txtSexo.MaxLength = 1
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(55, 20)
        Me.txtSexo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(925, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Data de Nascimento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(393, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(588, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RG:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(16, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.DarkGray
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(17, 170)
        Me.txtEmail.MaxLength = 200
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(321, 20)
        Me.txtEmail.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(394, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Telefone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(589, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telefone Celular:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(589, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nome da rua:"
        '
        'txtRua
        '
        Me.txtRua.BackColor = System.Drawing.Color.DarkGray
        Me.txtRua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRua.Location = New System.Drawing.Point(592, 226)
        Me.txtRua.MaxLength = 200
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(217, 20)
        Me.txtRua.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(336, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Bairro:"
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.Color.DarkGray
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(340, 229)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(200, 20)
        Me.txtBairro.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(792, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Cidade:"
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.Color.DarkGray
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(796, 167)
        Me.txtCidade.MaxLength = 100
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(217, 20)
        Me.txtCidade.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(156, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "CEP:"
        '
        'txtCEP
        '
        Me.txtCEP.BackColor = System.Drawing.Color.DarkGray
        Me.txtCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEP.Location = New System.Drawing.Point(160, 229)
        Me.txtCEP.MaxLength = 9
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(121, 20)
        Me.txtCEP.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(14, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "UF:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(884, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Número:"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.DarkGray
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(888, 226)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(103, 20)
        Me.txtNumero.TabIndex = 1
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Silver
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Red
        Me.btnExcluir.Location = New System.Drawing.Point(1204, 303)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(144, 34)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Silver
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(1021, 303)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(144, 34)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.Silver
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVoltar.Location = New System.Drawing.Point(12, 303)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(104, 34)
        Me.btnVoltar.TabIndex = 7
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codLeitor, Me.nome, Me.sexo, Me.dataNascimento, Me.cpf, Me.rg, Me.email, Me.telefone, Me.telefoneCelular, Me.enderecoNome, Me.enderecoBairro, Me.enderecoCidade, Me.enderecoCEP, Me.enderecoUF, Me.enderecoNumero})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 343)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.Size = New System.Drawing.Size(1336, 359)
        Me.dgvInformacoes.StandardTab = True
        Me.dgvInformacoes.TabIndex = 8
        '
        'codLeitor
        '
        Me.codLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codLeitor.DataPropertyName = "codLeitor"
        Me.codLeitor.HeaderText = "Código Leitor"
        Me.codLeitor.MaxInputLength = 10
        Me.codLeitor.Name = "codLeitor"
        Me.codLeitor.ReadOnly = True
        Me.codLeitor.Width = 94
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nome.DataPropertyName = "nome"
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 60
        '
        'sexo
        '
        Me.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        Me.sexo.Width = 56
        '
        'dataNascimento
        '
        Me.dataNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataNascimento.DataPropertyName = "dataNascimento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.dataNascimento.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataNascimento.HeaderText = "Data de Nascimento"
        Me.dataNascimento.Name = "dataNascimento"
        Me.dataNascimento.ReadOnly = True
        Me.dataNascimento.Width = 129
        '
        'cpf
        '
        Me.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.cpf.DataPropertyName = "cpf"
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        Me.cpf.Width = 52
        '
        'rg
        '
        Me.rg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rg.DataPropertyName = "rg"
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        Me.rg.Width = 48
        '
        'email
        '
        Me.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 60
        '
        'telefone
        '
        Me.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.telefone.DataPropertyName = "telefone"
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        Me.telefone.ReadOnly = True
        Me.telefone.Width = 74
        '
        'telefoneCelular
        '
        Me.telefoneCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.telefoneCelular.DataPropertyName = "telefoneCelular"
        Me.telefoneCelular.HeaderText = "Celular"
        Me.telefoneCelular.Name = "telefoneCelular"
        Me.telefoneCelular.ReadOnly = True
        Me.telefoneCelular.Width = 64
        '
        'enderecoNome
        '
        Me.enderecoNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoNome.DataPropertyName = "enderecoNome"
        Me.enderecoNome.HeaderText = "Rua"
        Me.enderecoNome.Name = "enderecoNome"
        Me.enderecoNome.ReadOnly = True
        Me.enderecoNome.Width = 52
        '
        'enderecoBairro
        '
        Me.enderecoBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoBairro.DataPropertyName = "enderecoBairro"
        Me.enderecoBairro.HeaderText = "Bairro"
        Me.enderecoBairro.Name = "enderecoBairro"
        Me.enderecoBairro.ReadOnly = True
        Me.enderecoBairro.Width = 59
        '
        'enderecoCidade
        '
        Me.enderecoCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoCidade.DataPropertyName = "enderecoCidade"
        Me.enderecoCidade.HeaderText = "Cidade"
        Me.enderecoCidade.Name = "enderecoCidade"
        Me.enderecoCidade.ReadOnly = True
        Me.enderecoCidade.Width = 65
        '
        'enderecoCEP
        '
        Me.enderecoCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoCEP.DataPropertyName = "enderecoCEP"
        Me.enderecoCEP.HeaderText = "CEP"
        Me.enderecoCEP.Name = "enderecoCEP"
        Me.enderecoCEP.ReadOnly = True
        Me.enderecoCEP.Width = 53
        '
        'enderecoUF
        '
        Me.enderecoUF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoUF.DataPropertyName = "enderecoUF"
        Me.enderecoUF.HeaderText = "UF"
        Me.enderecoUF.Name = "enderecoUF"
        Me.enderecoUF.ReadOnly = True
        Me.enderecoUF.Width = 46
        '
        'enderecoNumero
        '
        Me.enderecoNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.enderecoNumero.DataPropertyName = "enderecoNumero"
        Me.enderecoNumero.HeaderText = "Número"
        Me.enderecoNumero.Name = "enderecoNumero"
        Me.enderecoNumero.ReadOnly = True
        Me.enderecoNumero.Width = 69
        '
        'txtRG
        '
        Me.txtRG.BackColor = System.Drawing.Color.DarkGray
        Me.txtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRG.Location = New System.Drawing.Point(592, 109)
        Me.txtRG.MaxLength = 50
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(174, 20)
        Me.txtRG.TabIndex = 12
        '
        'txtTelefone
        '
        Me.txtTelefone.BackColor = System.Drawing.Color.DarkGray
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(397, 170)
        Me.txtTelefone.MaxLength = 13
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(119, 20)
        Me.txtTelefone.TabIndex = 13
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.DarkGray
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(592, 170)
        Me.txtCelular.MaxLength = 13
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(119, 20)
        Me.txtCelular.TabIndex = 14
        '
        'txtCPF
        '
        Me.txtCPF.BackColor = System.Drawing.Color.DarkGray
        Me.txtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(396, 109)
        Me.txtCPF.MaxLength = 14
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(119, 20)
        Me.txtCPF.TabIndex = 11
        '
        'txtDtNasc
        '
        Me.txtDtNasc.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.txtDtNasc.CustomFormat = "yyyy-MM-dd"
        Me.txtDtNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDtNasc.Location = New System.Drawing.Point(929, 107)
        Me.txtDtNasc.Name = "txtDtNasc"
        Me.txtDtNasc.Size = New System.Drawing.Size(94, 20)
        Me.txtDtNasc.TabIndex = 15
        Me.txtDtNasc.Value = New Date(2020, 2, 3, 0, 0, 0, 0)
        '
        'txtUF
        '
        Me.txtUF.BackColor = System.Drawing.Color.DarkGray
        Me.txtUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(17, 227)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(72, 21)
        Me.txtUF.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(559, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Limpar informações"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CadastrarLeitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1360, 714)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.txtDtNasc)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSexo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodg)
        Me.Controls.Add(Me.lblCodigo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "CadastrarLeitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Leitor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodg As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRua As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnVoltar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents txtRG As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents txtDtNasc As DateTimePicker
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents codLeitor As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents dataNascimento As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents rg As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents telefoneCelular As DataGridViewTextBoxColumn
    Friend WithEvents enderecoNome As DataGridViewTextBoxColumn
    Friend WithEvents enderecoBairro As DataGridViewTextBoxColumn
    Friend WithEvents enderecoCidade As DataGridViewTextBoxColumn
    Friend WithEvents enderecoCEP As DataGridViewTextBoxColumn
    Friend WithEvents enderecoUF As DataGridViewTextBoxColumn
    Friend WithEvents enderecoNumero As DataGridViewTextBoxColumn
End Class
