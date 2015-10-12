﻿namespace Apresentacao
{
    partial class FrmMenuAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelPesquisaTipo = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltroUnidade = new System.Windows.Forms.ComboBox();
            this.tblUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerencTCCsDataSet9 = new Apresentacao.GerencTCCsDataSet9();
            this.labelFiltrarPorUnidade = new System.Windows.Forms.Label();
            this.labelFiltrarPorCurso = new System.Windows.Forms.Label();
            this.comboBoxFiltroCurso = new System.Windows.Forms.ComboBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelModuloTitulo = new System.Windows.Forms.Label();
            this.labelFiltrarPorTipo = new System.Windows.Forms.Label();
            this.comboBoxFiltroTipo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFiltroData = new System.Windows.Forms.DateTimePicker();
            this.labelFiltrarPorData = new System.Windows.Forms.Label();
            this.comboBoxFiltroProfessor = new System.Windows.Forms.ComboBox();
            this.labelFiltrarPorProfessor = new System.Windows.Forms.Label();
            this.comboBoxFiltroGrupo = new System.Windows.Forms.ComboBox();
            this.labelFiltrarPorGrupo = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.radioButtonPesquisarPorMatricula = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorLogin = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorAluno = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorTitulo = new System.Windows.Forms.RadioButton();
            this.labelPesquisarEscolha = new System.Windows.Forms.Label();
            this.radioButtonPesquisarPorDescricao = new System.Windows.Forms.RadioButton();
            this.tblUnidadeTableAdapter = new Apresentacao.GerencTCCsDataSet9TableAdapters.tblUnidadeTableAdapter();
            this.gerencTCCsDataSet10 = new Apresentacao.GerencTCCsDataSet10();
            this.tblCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCursoTableAdapter = new Apresentacao.GerencTCCsDataSet10TableAdapters.tblCursoTableAdapter();
            this.gerencTCCsDataSet11 = new Apresentacao.GerencTCCsDataSet11();
            this.tblProfessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProfessorTableAdapter = new Apresentacao.GerencTCCsDataSet11TableAdapters.tblProfessorTableAdapter();
            this.gerencTCCsDataSet12 = new Apresentacao.GerencTCCsDataSet12();
            this.tblGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGrupoTableAdapter = new Apresentacao.GerencTCCsDataSet12TableAdapters.tblGrupoTableAdapter();
            this.gerencTCCsDataSet13 = new Apresentacao.GerencTCCsDataSet13();
            this.tblSalaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalaTipoTableAdapter = new Apresentacao.GerencTCCsDataSet13TableAdapters.tblSalaTipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet9)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 410);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(9, 8);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(780, 393);
            // 
            // labelPesquisaTipo
            // 
            this.labelPesquisaTipo.AutoSize = true;
            this.labelPesquisaTipo.Location = new System.Drawing.Point(25, 86);
            this.labelPesquisaTipo.Name = "labelPesquisaTipo";
            this.labelPesquisaTipo.Size = new System.Drawing.Size(38, 13);
            this.labelPesquisaTipo.TabIndex = 11;
            this.labelPesquisaTipo.Text = "Título:";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPesquisa.Location = new System.Drawing.Point(80, 82);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(613, 20);
            this.textBoxPesquisa.TabIndex = 7;
            this.textBoxPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisa_KeyPress);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(700, 81);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 8;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 114);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.Size = new System.Drawing.Size(750, 176);
            this.dataGridView.TabIndex = 9;
            // 
            // comboBoxFiltroUnidade
            // 
            this.comboBoxFiltroUnidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroUnidade.DataSource = this.tblUnidadeBindingSource;
            this.comboBoxFiltroUnidade.DisplayMember = "UnidadeNome";
            this.comboBoxFiltroUnidade.DropDownWidth = 200;
            this.comboBoxFiltroUnidade.FormattingEnabled = true;
            this.comboBoxFiltroUnidade.Location = new System.Drawing.Point(68, 15);
            this.comboBoxFiltroUnidade.Name = "comboBoxFiltroUnidade";
            this.comboBoxFiltroUnidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFiltroUnidade.Size = new System.Drawing.Size(129, 21);
            this.comboBoxFiltroUnidade.TabIndex = 9;
            this.comboBoxFiltroUnidade.ValueMember = "UnidadeNome";
            this.comboBoxFiltroUnidade.Click += new System.EventHandler(this.comboBoxFiltroUnidade_Click);
            // 
            // tblUnidadeBindingSource
            // 
            this.tblUnidadeBindingSource.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource.DataSource = this.gerencTCCsDataSet9;
            // 
            // gerencTCCsDataSet9
            // 
            this.gerencTCCsDataSet9.DataSetName = "GerencTCCsDataSet9";
            this.gerencTCCsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelFiltrarPorUnidade
            // 
            this.labelFiltrarPorUnidade.AutoSize = true;
            this.labelFiltrarPorUnidade.Location = new System.Drawing.Point(15, 19);
            this.labelFiltrarPorUnidade.Name = "labelFiltrarPorUnidade";
            this.labelFiltrarPorUnidade.Size = new System.Drawing.Size(47, 13);
            this.labelFiltrarPorUnidade.TabIndex = 20;
            this.labelFiltrarPorUnidade.Text = "Unidade";
            // 
            // labelFiltrarPorCurso
            // 
            this.labelFiltrarPorCurso.AutoSize = true;
            this.labelFiltrarPorCurso.Location = new System.Drawing.Point(28, 48);
            this.labelFiltrarPorCurso.Name = "labelFiltrarPorCurso";
            this.labelFiltrarPorCurso.Size = new System.Drawing.Size(34, 13);
            this.labelFiltrarPorCurso.TabIndex = 21;
            this.labelFiltrarPorCurso.Text = "Curso";
            // 
            // comboBoxFiltroCurso
            // 
            this.comboBoxFiltroCurso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroCurso.DataSource = this.tblCursoBindingSource;
            this.comboBoxFiltroCurso.DisplayMember = "CursoNome";
            this.comboBoxFiltroCurso.FormattingEnabled = true;
            this.comboBoxFiltroCurso.Location = new System.Drawing.Point(68, 44);
            this.comboBoxFiltroCurso.Name = "comboBoxFiltroCurso";
            this.comboBoxFiltroCurso.Size = new System.Drawing.Size(129, 21);
            this.comboBoxFiltroCurso.TabIndex = 10;
            this.comboBoxFiltroCurso.ValueMember = "CursoNome";
            this.comboBoxFiltroCurso.Click += new System.EventHandler(this.comboBoxFiltroCurso_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(408, 366);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 28);
            this.buttonInserir.TabIndex = 12;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(499, 366);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 28);
            this.buttonAlterar.TabIndex = 13;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(590, 366);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 28);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // labelModuloTitulo
            // 
            this.labelModuloTitulo.AutoSize = true;
            this.labelModuloTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelModuloTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModuloTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModuloTitulo.Location = new System.Drawing.Point(327, 26);
            this.labelModuloTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.labelModuloTitulo.MinimumSize = new System.Drawing.Size(147, 42);
            this.labelModuloTitulo.Name = "labelModuloTitulo";
            this.labelModuloTitulo.Size = new System.Drawing.Size(147, 42);
            this.labelModuloTitulo.TabIndex = 29;
            this.labelModuloTitulo.Text = "TCCs";
            this.labelModuloTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFiltrarPorTipo
            // 
            this.labelFiltrarPorTipo.AutoSize = true;
            this.labelFiltrarPorTipo.Location = new System.Drawing.Point(205, 77);
            this.labelFiltrarPorTipo.Name = "labelFiltrarPorTipo";
            this.labelFiltrarPorTipo.Size = new System.Drawing.Size(28, 13);
            this.labelFiltrarPorTipo.TabIndex = 31;
            this.labelFiltrarPorTipo.Text = "Tipo";
            this.labelFiltrarPorTipo.Visible = false;
            // 
            // comboBoxFiltroTipo
            // 
            this.comboBoxFiltroTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroTipo.DataSource = this.tblSalaTipoBindingSource;
            this.comboBoxFiltroTipo.DisplayMember = "SalaTipoTipo";
            this.comboBoxFiltroTipo.FormattingEnabled = true;
            this.comboBoxFiltroTipo.Location = new System.Drawing.Point(237, 73);
            this.comboBoxFiltroTipo.Name = "comboBoxFiltroTipo";
            this.comboBoxFiltroTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroTipo.TabIndex = 11;
            this.comboBoxFiltroTipo.ValueMember = "SalaTipoTipo";
            this.comboBoxFiltroTipo.Visible = false;
            this.comboBoxFiltroTipo.Click += new System.EventHandler(this.comboBoxFiltroTipo_Click);
            // 
            // dateTimePickerFiltroData
            // 
            this.dateTimePickerFiltroData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerFiltroData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFiltroData.Location = new System.Drawing.Point(237, 15);
            this.dateTimePickerFiltroData.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFiltroData.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFiltroData.Name = "dateTimePickerFiltroData";
            this.dateTimePickerFiltroData.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerFiltroData.TabIndex = 12;
            this.dateTimePickerFiltroData.Value = new System.DateTime(2015, 9, 7, 15, 32, 50, 0);
            this.dateTimePickerFiltroData.Visible = false;
            // 
            // labelFiltrarPorData
            // 
            this.labelFiltrarPorData.AutoSize = true;
            this.labelFiltrarPorData.Location = new System.Drawing.Point(203, 19);
            this.labelFiltrarPorData.Name = "labelFiltrarPorData";
            this.labelFiltrarPorData.Size = new System.Drawing.Size(30, 13);
            this.labelFiltrarPorData.TabIndex = 33;
            this.labelFiltrarPorData.Text = "Data";
            this.labelFiltrarPorData.Visible = false;
            // 
            // comboBoxFiltroProfessor
            // 
            this.comboBoxFiltroProfessor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroProfessor.DataSource = this.tblProfessorBindingSource;
            this.comboBoxFiltroProfessor.DisplayMember = "ProfessorNome";
            this.comboBoxFiltroProfessor.FormattingEnabled = true;
            this.comboBoxFiltroProfessor.Location = new System.Drawing.Point(68, 73);
            this.comboBoxFiltroProfessor.Name = "comboBoxFiltroProfessor";
            this.comboBoxFiltroProfessor.Size = new System.Drawing.Size(131, 21);
            this.comboBoxFiltroProfessor.TabIndex = 11;
            this.comboBoxFiltroProfessor.ValueMember = "ProfessorNome";
            this.comboBoxFiltroProfessor.Visible = false;
            this.comboBoxFiltroProfessor.Click += new System.EventHandler(this.comboBoxFiltroProfessor_Click);
            // 
            // labelFiltrarPorProfessor
            // 
            this.labelFiltrarPorProfessor.AutoSize = true;
            this.labelFiltrarPorProfessor.Location = new System.Drawing.Point(11, 77);
            this.labelFiltrarPorProfessor.Name = "labelFiltrarPorProfessor";
            this.labelFiltrarPorProfessor.Size = new System.Drawing.Size(51, 13);
            this.labelFiltrarPorProfessor.TabIndex = 36;
            this.labelFiltrarPorProfessor.Text = "Professor";
            this.labelFiltrarPorProfessor.Visible = false;
            // 
            // comboBoxFiltroGrupo
            // 
            this.comboBoxFiltroGrupo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroGrupo.DataSource = this.tblGrupoBindingSource;
            this.comboBoxFiltroGrupo.DisplayMember = "GrupoNome";
            this.comboBoxFiltroGrupo.FormattingEnabled = true;
            this.comboBoxFiltroGrupo.Location = new System.Drawing.Point(237, 44);
            this.comboBoxFiltroGrupo.Name = "comboBoxFiltroGrupo";
            this.comboBoxFiltroGrupo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroGrupo.TabIndex = 13;
            this.comboBoxFiltroGrupo.ValueMember = "GrupoNome";
            this.comboBoxFiltroGrupo.Visible = false;
            this.comboBoxFiltroGrupo.Click += new System.EventHandler(this.comboBoxFiltroGrupo_Click);
            // 
            // labelFiltrarPorGrupo
            // 
            this.labelFiltrarPorGrupo.AutoSize = true;
            this.labelFiltrarPorGrupo.Location = new System.Drawing.Point(197, 48);
            this.labelFiltrarPorGrupo.Name = "labelFiltrarPorGrupo";
            this.labelFiltrarPorGrupo.Size = new System.Drawing.Size(36, 13);
            this.labelFiltrarPorGrupo.TabIndex = 38;
            this.labelFiltrarPorGrupo.Text = "Grupo";
            this.labelFiltrarPorGrupo.Visible = false;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(678, 347);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(97, 47);
            this.buttonConsultar.TabIndex = 42;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorUnidade);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFiltroUnidade);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorCurso);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFiltroCurso);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFiltroGrupo);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorProfessor);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorGrupo);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFiltroProfessor);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorTipo);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFiltroTipo);
            this.groupBoxFiltros.Controls.Add(this.dateTimePickerFiltroData);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorData);
            this.groupBoxFiltros.Location = new System.Drawing.Point(25, 297);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(373, 100);
            this.groupBoxFiltros.TabIndex = 43;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtrar por";
            // 
            // radioButtonPesquisarPorMatricula
            // 
            this.radioButtonPesquisarPorMatricula.AutoSize = true;
            this.radioButtonPesquisarPorMatricula.Location = new System.Drawing.Point(467, 325);
            this.radioButtonPesquisarPorMatricula.Name = "radioButtonPesquisarPorMatricula";
            this.radioButtonPesquisarPorMatricula.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPesquisarPorMatricula.TabIndex = 18;
            this.radioButtonPesquisarPorMatricula.Text = "&Matrícula";
            this.radioButtonPesquisarPorMatricula.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorMatricula.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorMatricula_CheckedChanged);
            // 
            // radioButtonPesquisarPorCodigo
            // 
            this.radioButtonPesquisarPorCodigo.AutoSize = true;
            this.radioButtonPesquisarPorCodigo.Location = new System.Drawing.Point(410, 302);
            this.radioButtonPesquisarPorCodigo.Name = "radioButtonPesquisarPorCodigo";
            this.radioButtonPesquisarPorCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPesquisarPorCodigo.TabIndex = 41;
            this.radioButtonPesquisarPorCodigo.Text = "Códi&go";
            this.radioButtonPesquisarPorCodigo.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorCodigo.Visible = false;
            this.radioButtonPesquisarPorCodigo.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorCodigo_CheckedChanged);
            // 
            // radioButtonPesquisarPorLogin
            // 
            this.radioButtonPesquisarPorLogin.AutoSize = true;
            this.radioButtonPesquisarPorLogin.Location = new System.Drawing.Point(642, 302);
            this.radioButtonPesquisarPorLogin.Name = "radioButtonPesquisarPorLogin";
            this.radioButtonPesquisarPorLogin.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPesquisarPorLogin.TabIndex = 40;
            this.radioButtonPesquisarPorLogin.Text = "&Login";
            this.radioButtonPesquisarPorLogin.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorLogin.Visible = false;
            this.radioButtonPesquisarPorLogin.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorLogin_CheckedChanged);
            // 
            // radioButtonPesquisarPorNome
            // 
            this.radioButtonPesquisarPorNome.AutoSize = true;
            this.radioButtonPesquisarPorNome.Location = new System.Drawing.Point(691, 302);
            this.radioButtonPesquisarPorNome.Name = "radioButtonPesquisarPorNome";
            this.radioButtonPesquisarPorNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPesquisarPorNome.TabIndex = 1;
            this.radioButtonPesquisarPorNome.Text = "&Nome";
            this.radioButtonPesquisarPorNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorNome_CheckedChanged);
            // 
            // radioButtonPesquisarPorAluno
            // 
            this.radioButtonPesquisarPorAluno.AutoSize = true;
            this.radioButtonPesquisarPorAluno.Location = new System.Drawing.Point(553, 325);
            this.radioButtonPesquisarPorAluno.Name = "radioButtonPesquisarPorAluno";
            this.radioButtonPesquisarPorAluno.Size = new System.Drawing.Size(52, 17);
            this.radioButtonPesquisarPorAluno.TabIndex = 44;
            this.radioButtonPesquisarPorAluno.Text = "&Aluno";
            this.radioButtonPesquisarPorAluno.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorAluno.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorAluno_CheckedChanged);
            // 
            // radioButtonPesquisarPorTitulo
            // 
            this.radioButtonPesquisarPorTitulo.AutoSize = true;
            this.radioButtonPesquisarPorTitulo.Checked = true;
            this.radioButtonPesquisarPorTitulo.Location = new System.Drawing.Point(612, 325);
            this.radioButtonPesquisarPorTitulo.Name = "radioButtonPesquisarPorTitulo";
            this.radioButtonPesquisarPorTitulo.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPesquisarPorTitulo.TabIndex = 34;
            this.radioButtonPesquisarPorTitulo.TabStop = true;
            this.radioButtonPesquisarPorTitulo.Text = "&Título";
            this.radioButtonPesquisarPorTitulo.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorTitulo.Visible = false;
            this.radioButtonPesquisarPorTitulo.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorTitulo_CheckedChanged);
            // 
            // labelPesquisarEscolha
            // 
            this.labelPesquisarEscolha.AutoSize = true;
            this.labelPesquisarEscolha.Location = new System.Drawing.Point(562, 304);
            this.labelPesquisarEscolha.Name = "labelPesquisarEscolha";
            this.labelPesquisarEscolha.Size = new System.Drawing.Size(74, 13);
            this.labelPesquisarEscolha.TabIndex = 15;
            this.labelPesquisarEscolha.Text = "Pesquisar por:";
            // 
            // radioButtonPesquisarPorDescricao
            // 
            this.radioButtonPesquisarPorDescricao.AutoSize = true;
            this.radioButtonPesquisarPorDescricao.Location = new System.Drawing.Point(671, 325);
            this.radioButtonPesquisarPorDescricao.Name = "radioButtonPesquisarPorDescricao";
            this.radioButtonPesquisarPorDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPesquisarPorDescricao.TabIndex = 45;
            this.radioButtonPesquisarPorDescricao.Text = "&Descricao";
            this.radioButtonPesquisarPorDescricao.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorDescricao.Visible = false;
            this.radioButtonPesquisarPorDescricao.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorDescricao_CheckedChanged);
            // 
            // tblUnidadeTableAdapter
            // 
            this.tblUnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // gerencTCCsDataSet10
            // 
            this.gerencTCCsDataSet10.DataSetName = "GerencTCCsDataSet10";
            this.gerencTCCsDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCursoBindingSource
            // 
            this.tblCursoBindingSource.DataMember = "tblCurso";
            this.tblCursoBindingSource.DataSource = this.gerencTCCsDataSet10;
            // 
            // tblCursoTableAdapter
            // 
            this.tblCursoTableAdapter.ClearBeforeFill = true;
            // 
            // gerencTCCsDataSet11
            // 
            this.gerencTCCsDataSet11.DataSetName = "GerencTCCsDataSet11";
            this.gerencTCCsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProfessorBindingSource
            // 
            this.tblProfessorBindingSource.DataMember = "tblProfessor";
            this.tblProfessorBindingSource.DataSource = this.gerencTCCsDataSet11;
            // 
            // tblProfessorTableAdapter
            // 
            this.tblProfessorTableAdapter.ClearBeforeFill = true;
            // 
            // gerencTCCsDataSet12
            // 
            this.gerencTCCsDataSet12.DataSetName = "GerencTCCsDataSet12";
            this.gerencTCCsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGrupoBindingSource
            // 
            this.tblGrupoBindingSource.DataMember = "tblGrupo";
            this.tblGrupoBindingSource.DataSource = this.gerencTCCsDataSet12;
            // 
            // tblGrupoTableAdapter
            // 
            this.tblGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // gerencTCCsDataSet13
            // 
            this.gerencTCCsDataSet13.DataSetName = "GerencTCCsDataSet13";
            this.gerencTCCsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSalaTipoBindingSource
            // 
            this.tblSalaTipoBindingSource.DataMember = "tblSalaTipo";
            this.tblSalaTipoBindingSource.DataSource = this.gerencTCCsDataSet13;
            // 
            // tblSalaTipoTableAdapter
            // 
            this.tblSalaTipoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.radioButtonPesquisarPorDescricao);
            this.Controls.Add(this.labelPesquisarEscolha);
            this.Controls.Add(this.radioButtonPesquisarPorAluno);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.radioButtonPesquisarPorCodigo);
            this.Controls.Add(this.radioButtonPesquisarPorLogin);
            this.Controls.Add(this.radioButtonPesquisarPorTitulo);
            this.Controls.Add(this.labelModuloTitulo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.radioButtonPesquisarPorMatricula);
            this.Controls.Add(this.radioButtonPesquisarPorNome);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelPesquisaTipo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAdministrador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuAluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet9)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerencTCCsDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label labelPesquisaTipo;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxFiltroUnidade;
        private System.Windows.Forms.Label labelFiltrarPorUnidade;
        private System.Windows.Forms.Label labelFiltrarPorCurso;
        private System.Windows.Forms.ComboBox comboBoxFiltroCurso;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelModuloTitulo;
        private System.Windows.Forms.Label labelFiltrarPorTipo;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltroData;
        private System.Windows.Forms.Label labelFiltrarPorData;
        private System.Windows.Forms.ComboBox comboBoxFiltroProfessor;
        private System.Windows.Forms.Label labelFiltrarPorProfessor;
        private System.Windows.Forms.ComboBox comboBoxFiltroGrupo;
        private System.Windows.Forms.Label labelFiltrarPorGrupo;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorMatricula;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorCodigo;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorLogin;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorAluno;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorTitulo;
        private System.Windows.Forms.Label labelPesquisarEscolha;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorDescricao;
        private GerencTCCsDataSet9 gerencTCCsDataSet9;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource;
        private GerencTCCsDataSet9TableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter;
        private GerencTCCsDataSet10 gerencTCCsDataSet10;
        private System.Windows.Forms.BindingSource tblCursoBindingSource;
        private GerencTCCsDataSet10TableAdapters.tblCursoTableAdapter tblCursoTableAdapter;
        private GerencTCCsDataSet11 gerencTCCsDataSet11;
        private System.Windows.Forms.BindingSource tblProfessorBindingSource;
        private GerencTCCsDataSet11TableAdapters.tblProfessorTableAdapter tblProfessorTableAdapter;
        private GerencTCCsDataSet12 gerencTCCsDataSet12;
        private System.Windows.Forms.BindingSource tblGrupoBindingSource;
        private GerencTCCsDataSet12TableAdapters.tblGrupoTableAdapter tblGrupoTableAdapter;
        private GerencTCCsDataSet13 gerencTCCsDataSet13;
        private System.Windows.Forms.BindingSource tblSalaTipoBindingSource;
        private GerencTCCsDataSet13TableAdapters.tblSalaTipoTableAdapter tblSalaTipoTableAdapter;
    }
}