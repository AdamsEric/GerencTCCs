namespace Apresentacao
{
    partial class FrmMenuSelecao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelPesquisaTipo = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltroUnidade = new System.Windows.Forms.ComboBox();
            this.tblUnidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUnidade = new Apresentacao.DataSetUnidade();
            this.labelFiltrarPorUnidade = new System.Windows.Forms.Label();
            this.labelFiltrarPorCurso = new System.Windows.Forms.Label();
            this.comboBoxFiltroCurso = new System.Windows.Forms.ComboBox();
            this.tblCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCurso = new Apresentacao.DataSetCurso();
            this.labelModuloTitulo = new System.Windows.Forms.Label();
            this.labelFiltrarPorTipo = new System.Windows.Forms.Label();
            this.comboBoxFiltroTipo = new System.Windows.Forms.ComboBox();
            this.tblSalaTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalaTipo = new Apresentacao.DataSetSalaTipo();
            this.dateTimePickerFiltroData = new System.Windows.Forms.DateTimePicker();
            this.labelFiltrarPorData = new System.Windows.Forms.Label();
            this.comboBoxFiltroGrupo = new System.Windows.Forms.ComboBox();
            this.tblGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGrupo = new Apresentacao.DataSetGrupo();
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
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.labelIDSelecionado = new System.Windows.Forms.Label();
            this.labelCampo1Selecionado = new System.Windows.Forms.Label();
            this.labelCampo2Selecionado = new System.Windows.Forms.Label();
            this.labelCampo3Selecionado = new System.Windows.Forms.Label();
            this.tblCursoTableAdapter = new Apresentacao.DataSetCursoTableAdapters.tblCursoTableAdapter();
            this.tblGrupoTableAdapter = new Apresentacao.DataSetGrupoTableAdapters.tblGrupoTableAdapter();
            this.tblUnidadeTableAdapter = new Apresentacao.DataSetUnidadeTableAdapters.tblUnidadeTableAdapter();
            this.tblSalaTipoTableAdapter = new Apresentacao.DataSetSalaTipoTableAdapters.tblSalaTipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalaTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGrupo)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(716, 385);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(9, 8);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(697, 368);
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
            this.textBoxPesquisa.Size = new System.Drawing.Size(533, 20);
            this.textBoxPesquisa.TabIndex = 7;
            this.textBoxPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisa_KeyPress);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(618, 81);
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
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 114);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.Size = new System.Drawing.Size(668, 147);
            this.dataGridView.TabIndex = 9;
            // 
            // comboBoxFiltroUnidade
            // 
            this.comboBoxFiltroUnidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroUnidade.DataSource = this.tblUnidadeBindingSource;
            this.comboBoxFiltroUnidade.DisplayMember = "UnidadeNome";
            this.comboBoxFiltroUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroUnidade.DropDownWidth = 200;
            this.comboBoxFiltroUnidade.FormattingEnabled = true;
            this.comboBoxFiltroUnidade.Location = new System.Drawing.Point(68, 15);
            this.comboBoxFiltroUnidade.Name = "comboBoxFiltroUnidade";
            this.comboBoxFiltroUnidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFiltroUnidade.Size = new System.Drawing.Size(129, 21);
            this.comboBoxFiltroUnidade.TabIndex = 9;
            this.comboBoxFiltroUnidade.ValueMember = "UnidadeNome";
            this.comboBoxFiltroUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFiltroUnidade_KeyPress);
            // 
            // tblUnidadeBindingSource
            // 
            this.tblUnidadeBindingSource.DataMember = "tblUnidade";
            this.tblUnidadeBindingSource.DataSource = this.dataSetUnidade;
            // 
            // dataSetUnidade
            // 
            this.dataSetUnidade.DataSetName = "DataSetUnidade";
            this.dataSetUnidade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.labelFiltrarPorCurso.Location = new System.Drawing.Point(28, 47);
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
            this.comboBoxFiltroCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroCurso.FormattingEnabled = true;
            this.comboBoxFiltroCurso.Location = new System.Drawing.Point(68, 43);
            this.comboBoxFiltroCurso.Name = "comboBoxFiltroCurso";
            this.comboBoxFiltroCurso.Size = new System.Drawing.Size(129, 21);
            this.comboBoxFiltroCurso.TabIndex = 10;
            this.comboBoxFiltroCurso.ValueMember = "CursoNome";
            this.comboBoxFiltroCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFiltroCurso_KeyPress);
            // 
            // tblCursoBindingSource
            // 
            this.tblCursoBindingSource.DataMember = "tblCurso";
            this.tblCursoBindingSource.DataSource = this.dataSetCurso;
            // 
            // dataSetCurso
            // 
            this.dataSetCurso.DataSetName = "DataSetCurso";
            this.dataSetCurso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelModuloTitulo
            // 
            this.labelModuloTitulo.AutoSize = true;
            this.labelModuloTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelModuloTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModuloTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModuloTitulo.Location = new System.Drawing.Point(286, 26);
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
            this.labelFiltrarPorTipo.Location = new System.Drawing.Point(36, 75);
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
            this.comboBoxFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroTipo.FormattingEnabled = true;
            this.comboBoxFiltroTipo.Location = new System.Drawing.Point(68, 71);
            this.comboBoxFiltroTipo.Name = "comboBoxFiltroTipo";
            this.comboBoxFiltroTipo.Size = new System.Drawing.Size(129, 21);
            this.comboBoxFiltroTipo.TabIndex = 11;
            this.comboBoxFiltroTipo.ValueMember = "SalaTipoTipo";
            this.comboBoxFiltroTipo.Visible = false;
            this.comboBoxFiltroTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFiltroTipo_KeyPress);
            // 
            // tblSalaTipoBindingSource
            // 
            this.tblSalaTipoBindingSource.DataMember = "tblSalaTipo";
            this.tblSalaTipoBindingSource.DataSource = this.dataSetSalaTipo;
            // 
            // dataSetSalaTipo
            // 
            this.dataSetSalaTipo.DataSetName = "DataSetSalaTipo";
            this.dataSetSalaTipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // comboBoxFiltroGrupo
            // 
            this.comboBoxFiltroGrupo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroGrupo.DataSource = this.tblGrupoBindingSource;
            this.comboBoxFiltroGrupo.DisplayMember = "GrupoNome";
            this.comboBoxFiltroGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroGrupo.FormattingEnabled = true;
            this.comboBoxFiltroGrupo.Location = new System.Drawing.Point(237, 43);
            this.comboBoxFiltroGrupo.Name = "comboBoxFiltroGrupo";
            this.comboBoxFiltroGrupo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroGrupo.TabIndex = 13;
            this.comboBoxFiltroGrupo.ValueMember = "GrupoNome";
            this.comboBoxFiltroGrupo.Visible = false;
            this.comboBoxFiltroGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFiltroGrupo_KeyPress);
            // 
            // tblGrupoBindingSource
            // 
            this.tblGrupoBindingSource.DataMember = "tblGrupo";
            this.tblGrupoBindingSource.DataSource = this.dataSetGrupo;
            // 
            // dataSetGrupo
            // 
            this.dataSetGrupo.DataSetName = "DataSetGrupo";
            this.dataSetGrupo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelFiltrarPorGrupo
            // 
            this.labelFiltrarPorGrupo.AutoSize = true;
            this.labelFiltrarPorGrupo.Location = new System.Drawing.Point(197, 47);
            this.labelFiltrarPorGrupo.Name = "labelFiltrarPorGrupo";
            this.labelFiltrarPorGrupo.Size = new System.Drawing.Size(36, 13);
            this.labelFiltrarPorGrupo.TabIndex = 38;
            this.labelFiltrarPorGrupo.Text = "Grupo";
            this.labelFiltrarPorGrupo.Visible = false;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(513, 322);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(87, 42);
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
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorGrupo);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorTipo);
            this.groupBoxFiltros.Controls.Add(this.comboBoxFiltroTipo);
            this.groupBoxFiltros.Controls.Add(this.dateTimePickerFiltroData);
            this.groupBoxFiltros.Controls.Add(this.labelFiltrarPorData);
            this.groupBoxFiltros.Location = new System.Drawing.Point(25, 265);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(373, 100);
            this.groupBoxFiltros.TabIndex = 43;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtrar por";
            // 
            // radioButtonPesquisarPorMatricula
            // 
            this.radioButtonPesquisarPorMatricula.AutoSize = true;
            this.radioButtonPesquisarPorMatricula.Location = new System.Drawing.Point(623, 276);
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
            this.radioButtonPesquisarPorCodigo.Location = new System.Drawing.Point(407, 276);
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
            this.radioButtonPesquisarPorLogin.Location = new System.Drawing.Point(582, 299);
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
            this.radioButtonPesquisarPorNome.Location = new System.Drawing.Point(566, 276);
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
            this.radioButtonPesquisarPorAluno.Location = new System.Drawing.Point(407, 322);
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
            this.radioButtonPesquisarPorTitulo.Location = new System.Drawing.Point(407, 345);
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
            this.labelPesquisarEscolha.Location = new System.Drawing.Point(488, 278);
            this.labelPesquisarEscolha.Name = "labelPesquisarEscolha";
            this.labelPesquisarEscolha.Size = new System.Drawing.Size(74, 13);
            this.labelPesquisarEscolha.TabIndex = 15;
            this.labelPesquisarEscolha.Text = "Pesquisar por:";
            // 
            // radioButtonPesquisarPorDescricao
            // 
            this.radioButtonPesquisarPorDescricao.AutoSize = true;
            this.radioButtonPesquisarPorDescricao.Location = new System.Drawing.Point(407, 299);
            this.radioButtonPesquisarPorDescricao.Name = "radioButtonPesquisarPorDescricao";
            this.radioButtonPesquisarPorDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPesquisarPorDescricao.TabIndex = 45;
            this.radioButtonPesquisarPorDescricao.Text = "&Descricao";
            this.radioButtonPesquisarPorDescricao.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorDescricao.Visible = false;
            this.radioButtonPesquisarPorDescricao.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorDescricao_CheckedChanged);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(606, 322);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(87, 42);
            this.buttonSelecionar.TabIndex = 46;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // labelIDSelecionado
            // 
            this.labelIDSelecionado.AutoSize = true;
            this.labelIDSelecionado.Location = new System.Drawing.Point(22, 26);
            this.labelIDSelecionado.Name = "labelIDSelecionado";
            this.labelIDSelecionado.Size = new System.Drawing.Size(13, 13);
            this.labelIDSelecionado.TabIndex = 47;
            this.labelIDSelecionado.Text = "0";
            this.labelIDSelecionado.Visible = false;
            // 
            // labelCampo1Selecionado
            // 
            this.labelCampo1Selecionado.AutoSize = true;
            this.labelCampo1Selecionado.Location = new System.Drawing.Point(40, 26);
            this.labelCampo1Selecionado.Name = "labelCampo1Selecionado";
            this.labelCampo1Selecionado.Size = new System.Drawing.Size(46, 13);
            this.labelCampo1Selecionado.TabIndex = 48;
            this.labelCampo1Selecionado.Text = "Campo1";
            this.labelCampo1Selecionado.Visible = false;
            // 
            // labelCampo2Selecionado
            // 
            this.labelCampo2Selecionado.AutoSize = true;
            this.labelCampo2Selecionado.Location = new System.Drawing.Point(91, 26);
            this.labelCampo2Selecionado.Name = "labelCampo2Selecionado";
            this.labelCampo2Selecionado.Size = new System.Drawing.Size(46, 13);
            this.labelCampo2Selecionado.TabIndex = 49;
            this.labelCampo2Selecionado.Text = "Campo2";
            this.labelCampo2Selecionado.Visible = false;
            // 
            // labelCampo3Selecionado
            // 
            this.labelCampo3Selecionado.AutoSize = true;
            this.labelCampo3Selecionado.Location = new System.Drawing.Point(142, 26);
            this.labelCampo3Selecionado.Name = "labelCampo3Selecionado";
            this.labelCampo3Selecionado.Size = new System.Drawing.Size(46, 13);
            this.labelCampo3Selecionado.TabIndex = 50;
            this.labelCampo3Selecionado.Text = "Campo3";
            this.labelCampo3Selecionado.Visible = false;
            // 
            // tblCursoTableAdapter
            // 
            this.tblCursoTableAdapter.ClearBeforeFill = true;
            // 
            // tblGrupoTableAdapter
            // 
            this.tblGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // tblUnidadeTableAdapter
            // 
            this.tblUnidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tblSalaTipoTableAdapter
            // 
            this.tblSalaTipoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(716, 385);
            this.Controls.Add(this.labelCampo3Selecionado);
            this.Controls.Add(this.labelCampo2Selecionado);
            this.Controls.Add(this.labelCampo1Selecionado);
            this.Controls.Add(this.labelIDSelecionado);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.radioButtonPesquisarPorDescricao);
            this.Controls.Add(this.labelPesquisarEscolha);
            this.Controls.Add(this.radioButtonPesquisarPorAluno);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.radioButtonPesquisarPorCodigo);
            this.Controls.Add(this.radioButtonPesquisarPorLogin);
            this.Controls.Add(this.radioButtonPesquisarPorTitulo);
            this.Controls.Add(this.labelModuloTitulo);
            this.Controls.Add(this.radioButtonPesquisarPorMatricula);
            this.Controls.Add(this.radioButtonPesquisarPorNome);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelPesquisaTipo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuSelecao";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuAluno";
            this.Load += new System.EventHandler(this.FrmMenuSelecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUnidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaTipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalaTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGrupo)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
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
        private System.Windows.Forms.Label labelModuloTitulo;
        private System.Windows.Forms.Label labelFiltrarPorTipo;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltroData;
        private System.Windows.Forms.Label labelFiltrarPorData;
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
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Label labelIDSelecionado;
        private System.Windows.Forms.Label labelCampo1Selecionado;
        private System.Windows.Forms.Label labelCampo2Selecionado;
        private System.Windows.Forms.Label labelCampo3Selecionado;
        private DataSetCurso dataSetCurso;
        private System.Windows.Forms.BindingSource tblCursoBindingSource;
        private DataSetCursoTableAdapters.tblCursoTableAdapter tblCursoTableAdapter;
        private DataSetGrupo dataSetGrupo;
        private System.Windows.Forms.BindingSource tblGrupoBindingSource;
        private DataSetGrupoTableAdapters.tblGrupoTableAdapter tblGrupoTableAdapter;
        private DataSetUnidade dataSetUnidade;
        private System.Windows.Forms.BindingSource tblUnidadeBindingSource;
        private DataSetUnidadeTableAdapters.tblUnidadeTableAdapter tblUnidadeTableAdapter;
        private DataSetSalaTipo dataSetSalaTipo;
        private System.Windows.Forms.BindingSource tblSalaTipoBindingSource;
        private DataSetSalaTipoTableAdapters.tblSalaTipoTableAdapter tblSalaTipoTableAdapter;
    }
}