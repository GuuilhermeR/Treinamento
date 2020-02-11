<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastrarAutor
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtInfAutor = New System.Windows.Forms.TextBox()
        Me.btnCarregaImagem = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.dgvInformacoes = New System.Windows.Forms.DataGridView()
        Me.codAutorI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomeI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricaoI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(250, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(250, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Informações do autor:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.DarkGray
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(253, 99)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(522, 20)
        Me.txtNome.TabIndex = 4
        '
        'txtInfAutor
        '
        Me.txtInfAutor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInfAutor.BackColor = System.Drawing.Color.DarkGray
        Me.txtInfAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfAutor.Location = New System.Drawing.Point(253, 159)
        Me.txtInfAutor.MaxLength = 1000
        Me.txtInfAutor.Multiline = True
        Me.txtInfAutor.Name = "txtInfAutor"
        Me.txtInfAutor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfAutor.Size = New System.Drawing.Size(1102, 130)
        Me.txtInfAutor.TabIndex = 5
        '
        'btnCarregaImagem
        '
        Me.btnCarregaImagem.BackColor = System.Drawing.Color.Silver
        Me.btnCarregaImagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregaImagem.Location = New System.Drawing.Point(12, 232)
        Me.btnCarregaImagem.Name = "btnCarregaImagem"
        Me.btnCarregaImagem.Size = New System.Drawing.Size(219, 34)
        Me.btnCarregaImagem.TabIndex = 7
        Me.btnCarregaImagem.Text = "Carregar Imagem"
        Me.btnCarregaImagem.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(26, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.BackColor = System.Drawing.Color.Silver
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Green
        Me.btnSalvar.Location = New System.Drawing.Point(1049, 307)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(144, 34)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'dgvInformacoes
        '
        Me.dgvInformacoes.AllowUserToAddRows = False
        Me.dgvInformacoes.AllowUserToDeleteRows = False
        Me.dgvInformacoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInformacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codAutorI, Me.nomeI, Me.descricaoI})
        Me.dgvInformacoes.Location = New System.Drawing.Point(12, 347)
        Me.dgvInformacoes.Name = "dgvInformacoes"
        Me.dgvInformacoes.ReadOnly = True
        Me.dgvInformacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInformacoes.Size = New System.Drawing.Size(1343, 388)
        Me.dgvInformacoes.TabIndex = 13
        '
        'codAutorI
        '
        Me.codAutorI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.codAutorI.DataPropertyName = "codAutor"
        Me.codAutorI.HeaderText = "Código do Autor"
        Me.codAutorI.Name = "codAutorI"
        Me.codAutorI.ReadOnly = True
        Me.codAutorI.Width = 108
        '
        'nomeI
        '
        Me.nomeI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.nomeI.DataPropertyName = "nome"
        Me.nomeI.HeaderText = "Nome Autor"
        Me.nomeI.Name = "nomeI"
        Me.nomeI.ReadOnly = True
        Me.nomeI.Width = 88
        '
        'descricaoI
        '
        Me.descricaoI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.descricaoI.DataPropertyName = "descricao"
        Me.descricaoI.FillWeight = 80.0!
        Me.descricaoI.HeaderText = "Descrição"
        Me.descricaoI.Name = "descricaoI"
        Me.descricaoI.ReadOnly = True
        Me.descricaoI.Width = 80
        '
        'txtCodg
        '
        Me.txtCodg.BackColor = System.Drawing.Color.DarkGray
        Me.txtCodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodg.Location = New System.Drawing.Point(253, 40)
        Me.txtCodg.MaxLength = 50
        Me.txtCodg.Name = "txtCodg"
        Me.txtCodg.Size = New System.Drawing.Size(90, 20)
        Me.txtCodg.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(250, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Código"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(999, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(330, 34)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Limpar informações"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.BackColor = System.Drawing.Color.Silver
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Red
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(1211, 307)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(144, 34)
        Me.btnExcluir.TabIndex = 10
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'pbImagem
        '
        Me.pbImagem.InitialImage = Global.Treinamento.My.Resources.Resources.kisspng_user_interface_design_computer_icons_default_stephen_salazar_photography_5b1462e1b19d70_removebg_preview__2_
        Me.pbImagem.Location = New System.Drawing.Point(12, 24)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(219, 202)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 15
        Me.pbImagem.TabStop = False
        Me.pbImagem.UseWaitCursor = True
        Me.pbImagem.WaitOnLoad = True
        '
        'CadastrarAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCodg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.dgvInformacoes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnCarregaImagem)
        Me.Controls.Add(Me.txtInfAutor)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CadastrarAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Autor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInformacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtInfAutor As TextBox
    Friend WithEvents btnCarregaImagem As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents dgvInformacoes As DataGridView
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents txtCodg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents codAutorI As DataGridViewTextBoxColumn
    Friend WithEvents nomeI As DataGridViewTextBoxColumn
    Friend WithEvents descricaoI As DataGridViewTextBoxColumn
End Class
