namespace Apresentacao
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
            this.buttonAlunoMenu = new System.Windows.Forms.Button();
            this.labelNomeModulo = new System.Windows.Forms.Label();
            this.buttonTCCMenu = new System.Windows.Forms.Button();
            this.buttonProfessorMenu = new System.Windows.Forms.Button();
            this.buttonCursoMenu = new System.Windows.Forms.Button();
            this.buttonUnidadeMenu = new System.Windows.Forms.Button();
            this.buttonSalaMenu = new System.Windows.Forms.Button();
            this.buttonUsuarioMenu = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelPesquisaTipo = new System.Windows.Forms.Label();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelPesquisarEscolha = new System.Windows.Forms.Label();
            this.comboBoxFiltroUnidade = new System.Windows.Forms.ComboBox();
            this.labelFiltrarPorUnidade = new System.Windows.Forms.Label();
            this.labelFiltrarPorCurso = new System.Windows.Forms.Label();
            this.comboBoxFiltroCurso = new System.Windows.Forms.ComboBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelModuloTitulo = new System.Windows.Forms.Label();
            this.labelFiltrarPorTipo = new System.Windows.Forms.Label();
            this.comboBoxFiltroTipo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFiltroData = new System.Windows.Forms.DateTimePicker();
            this.labelFiltrarPorData = new System.Windows.Forms.Label();
            this.radioButtonPesquisarPorDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorTema = new System.Windows.Forms.RadioButton();
            this.comboBoxFiltroProfessor = new System.Windows.Forms.ComboBox();
            this.labelFiltrarPorProfessor = new System.Windows.Forms.Label();
            this.comboBoxFiltroGrupo = new System.Windows.Forms.ComboBox();
            this.labelFiltrarPorGrupo = new System.Windows.Forms.Label();
            this.radioButtonPesquisarPorLogin = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorNome = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarPorMatricula = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAlunoMenu
            // 
            this.buttonAlunoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlunoMenu.Location = new System.Drawing.Point(41, 44);
            this.buttonAlunoMenu.Name = "buttonAlunoMenu";
            this.buttonAlunoMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonAlunoMenu.TabIndex = 0;
            this.buttonAlunoMenu.Text = "Alunos";
            this.buttonAlunoMenu.UseVisualStyleBackColor = true;
            this.buttonAlunoMenu.Click += new System.EventHandler(this.buttonAlunoMenu_Click);
            // 
            // labelNomeModulo
            // 
            this.labelNomeModulo.AutoSize = true;
            this.labelNomeModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeModulo.Location = new System.Drawing.Point(67, 16);
            this.labelNomeModulo.Name = "labelNomeModulo";
            this.labelNomeModulo.Size = new System.Drawing.Size(94, 25);
            this.labelNomeModulo.TabIndex = 1;
            this.labelNomeModulo.Text = "Módulos";
            // 
            // buttonTCCMenu
            // 
            this.buttonTCCMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTCCMenu.Location = new System.Drawing.Point(41, 94);
            this.buttonTCCMenu.Name = "buttonTCCMenu";
            this.buttonTCCMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonTCCMenu.TabIndex = 1;
            this.buttonTCCMenu.Text = "TCCs";
            this.buttonTCCMenu.UseVisualStyleBackColor = true;
            this.buttonTCCMenu.Click += new System.EventHandler(this.buttonTCCMenu_Click);
            // 
            // buttonProfessorMenu
            // 
            this.buttonProfessorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfessorMenu.Location = new System.Drawing.Point(41, 144);
            this.buttonProfessorMenu.Name = "buttonProfessorMenu";
            this.buttonProfessorMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonProfessorMenu.TabIndex = 2;
            this.buttonProfessorMenu.Text = "Professores";
            this.buttonProfessorMenu.UseVisualStyleBackColor = true;
            this.buttonProfessorMenu.Click += new System.EventHandler(this.buttonProfessorMenu_Click);
            // 
            // buttonCursoMenu
            // 
            this.buttonCursoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCursoMenu.Location = new System.Drawing.Point(41, 194);
            this.buttonCursoMenu.Name = "buttonCursoMenu";
            this.buttonCursoMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonCursoMenu.TabIndex = 3;
            this.buttonCursoMenu.Text = "Cursos";
            this.buttonCursoMenu.UseVisualStyleBackColor = true;
            this.buttonCursoMenu.Click += new System.EventHandler(this.buttonCursoMenu_Click);
            // 
            // buttonUnidadeMenu
            // 
            this.buttonUnidadeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnidadeMenu.Location = new System.Drawing.Point(41, 244);
            this.buttonUnidadeMenu.Name = "buttonUnidadeMenu";
            this.buttonUnidadeMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonUnidadeMenu.TabIndex = 4;
            this.buttonUnidadeMenu.Text = "Unidades";
            this.buttonUnidadeMenu.UseVisualStyleBackColor = true;
            this.buttonUnidadeMenu.Click += new System.EventHandler(this.buttonUnidadeMenu_Click);
            // 
            // buttonSalaMenu
            // 
            this.buttonSalaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalaMenu.Location = new System.Drawing.Point(41, 294);
            this.buttonSalaMenu.Name = "buttonSalaMenu";
            this.buttonSalaMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonSalaMenu.TabIndex = 5;
            this.buttonSalaMenu.Text = "Salas";
            this.buttonSalaMenu.UseVisualStyleBackColor = true;
            this.buttonSalaMenu.Click += new System.EventHandler(this.buttonSalaMenu_Click);
            // 
            // buttonUsuarioMenu
            // 
            this.buttonUsuarioMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarioMenu.Location = new System.Drawing.Point(41, 344);
            this.buttonUsuarioMenu.Name = "buttonUsuarioMenu";
            this.buttonUsuarioMenu.Size = new System.Drawing.Size(147, 42);
            this.buttonUsuarioMenu.TabIndex = 6;
            this.buttonUsuarioMenu.Text = "Usuários";
            this.buttonUsuarioMenu.UseVisualStyleBackColor = true;
            this.buttonUsuarioMenu.Click += new System.EventHandler(this.buttonUsuarioMenu_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(979, 408);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(224, 8);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(743, 388);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.Location = new System.Drawing.Point(13, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(199, 388);
            // 
            // labelPesquisaTipo
            // 
            this.labelPesquisaTipo.AutoSize = true;
            this.labelPesquisaTipo.Location = new System.Drawing.Point(241, 86);
            this.labelPesquisaTipo.Name = "labelPesquisaTipo";
            this.labelPesquisaTipo.Size = new System.Drawing.Size(41, 13);
            this.labelPesquisaTipo.TabIndex = 11;
            this.labelPesquisaTipo.Text = "Nome: ";
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPesquisa.Location = new System.Drawing.Point(283, 82);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(587, 20);
            this.textBoxPesquisa.TabIndex = 7;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(876, 81);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 8;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(241, 114);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(710, 193);
            this.dataGridView.TabIndex = 9;
            // 
            // labelPesquisarEscolha
            // 
            this.labelPesquisarEscolha.AutoSize = true;
            this.labelPesquisarEscolha.Location = new System.Drawing.Point(681, 315);
            this.labelPesquisarEscolha.Name = "labelPesquisarEscolha";
            this.labelPesquisarEscolha.Size = new System.Drawing.Size(74, 13);
            this.labelPesquisarEscolha.TabIndex = 15;
            this.labelPesquisarEscolha.Text = "Pesquisar por:";
            // 
            // comboBoxFiltroUnidade
            // 
            this.comboBoxFiltroUnidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroUnidade.FormattingEnabled = true;
            this.comboBoxFiltroUnidade.Location = new System.Drawing.Point(351, 314);
            this.comboBoxFiltroUnidade.Name = "comboBoxFiltroUnidade";
            this.comboBoxFiltroUnidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroUnidade.TabIndex = 9;
            // 
            // labelFiltrarPorUnidade
            // 
            this.labelFiltrarPorUnidade.AutoSize = true;
            this.labelFiltrarPorUnidade.Location = new System.Drawing.Point(301, 318);
            this.labelFiltrarPorUnidade.Name = "labelFiltrarPorUnidade";
            this.labelFiltrarPorUnidade.Size = new System.Drawing.Size(47, 13);
            this.labelFiltrarPorUnidade.TabIndex = 20;
            this.labelFiltrarPorUnidade.Text = "Unidade";
            // 
            // labelFiltrarPorCurso
            // 
            this.labelFiltrarPorCurso.AutoSize = true;
            this.labelFiltrarPorCurso.Location = new System.Drawing.Point(314, 346);
            this.labelFiltrarPorCurso.Name = "labelFiltrarPorCurso";
            this.labelFiltrarPorCurso.Size = new System.Drawing.Size(34, 13);
            this.labelFiltrarPorCurso.TabIndex = 21;
            this.labelFiltrarPorCurso.Text = "Curso";
            // 
            // comboBoxFiltroCurso
            // 
            this.comboBoxFiltroCurso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroCurso.FormattingEnabled = true;
            this.comboBoxFiltroCurso.Location = new System.Drawing.Point(351, 342);
            this.comboBoxFiltroCurso.Name = "comboBoxFiltroCurso";
            this.comboBoxFiltroCurso.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroCurso.TabIndex = 10;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(241, 318);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(53, 13);
            this.labelFiltrar.TabIndex = 25;
            this.labelFiltrar.Text = "Filtrar por:";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(678, 355);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 12;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(777, 355);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 13;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(876, 355);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 14;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // labelModuloTitulo
            // 
            this.labelModuloTitulo.AutoSize = true;
            this.labelModuloTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelModuloTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModuloTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModuloTitulo.Location = new System.Drawing.Point(514, 27);
            this.labelModuloTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.labelModuloTitulo.MinimumSize = new System.Drawing.Size(147, 42);
            this.labelModuloTitulo.Name = "labelModuloTitulo";
            this.labelModuloTitulo.Size = new System.Drawing.Size(147, 42);
            this.labelModuloTitulo.TabIndex = 29;
            this.labelModuloTitulo.Text = "Alunos";
            this.labelModuloTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFiltrarPorTipo
            // 
            this.labelFiltrarPorTipo.AutoSize = true;
            this.labelFiltrarPorTipo.Location = new System.Drawing.Point(500, 318);
            this.labelFiltrarPorTipo.Name = "labelFiltrarPorTipo";
            this.labelFiltrarPorTipo.Size = new System.Drawing.Size(28, 13);
            this.labelFiltrarPorTipo.TabIndex = 31;
            this.labelFiltrarPorTipo.Text = "Tipo";
            this.labelFiltrarPorTipo.Visible = false;
            // 
            // comboBoxFiltroTipo
            // 
            this.comboBoxFiltroTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroTipo.FormattingEnabled = true;
            this.comboBoxFiltroTipo.Location = new System.Drawing.Point(531, 314);
            this.comboBoxFiltroTipo.Name = "comboBoxFiltroTipo";
            this.comboBoxFiltroTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroTipo.TabIndex = 11;
            this.comboBoxFiltroTipo.Visible = false;
            // 
            // dateTimePickerFiltroData
            // 
            this.dateTimePickerFiltroData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePickerFiltroData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFiltroData.Location = new System.Drawing.Point(531, 342);
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
            this.labelFiltrarPorData.Location = new System.Drawing.Point(498, 346);
            this.labelFiltrarPorData.Name = "labelFiltrarPorData";
            this.labelFiltrarPorData.Size = new System.Drawing.Size(30, 13);
            this.labelFiltrarPorData.TabIndex = 33;
            this.labelFiltrarPorData.Text = "Data";
            this.labelFiltrarPorData.Visible = false;
            // 
            // radioButtonPesquisarPorDescricao
            // 
            this.radioButtonPesquisarPorDescricao.AutoSize = true;
            this.radioButtonPesquisarPorDescricao.Location = new System.Drawing.Point(764, 332);
            this.radioButtonPesquisarPorDescricao.Name = "radioButtonPesquisarPorDescricao";
            this.radioButtonPesquisarPorDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonPesquisarPorDescricao.TabIndex = 34;
            this.radioButtonPesquisarPorDescricao.Text = "&Descricao";
            this.radioButtonPesquisarPorDescricao.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorDescricao.Visible = false;
            this.radioButtonPesquisarPorDescricao.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorDescricao_CheckedChanged);
            // 
            // radioButtonPesquisarPorTema
            // 
            this.radioButtonPesquisarPorTema.AutoSize = true;
            this.radioButtonPesquisarPorTema.Location = new System.Drawing.Point(835, 332);
            this.radioButtonPesquisarPorTema.Name = "radioButtonPesquisarPorTema";
            this.radioButtonPesquisarPorTema.Size = new System.Drawing.Size(52, 17);
            this.radioButtonPesquisarPorTema.TabIndex = 35;
            this.radioButtonPesquisarPorTema.Text = "&Tema";
            this.radioButtonPesquisarPorTema.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorTema.Visible = false;
            this.radioButtonPesquisarPorTema.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorTema_CheckedChanged);
            // 
            // comboBoxFiltroProfessor
            // 
            this.comboBoxFiltroProfessor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroProfessor.FormattingEnabled = true;
            this.comboBoxFiltroProfessor.Location = new System.Drawing.Point(351, 369);
            this.comboBoxFiltroProfessor.Name = "comboBoxFiltroProfessor";
            this.comboBoxFiltroProfessor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroProfessor.TabIndex = 11;
            this.comboBoxFiltroProfessor.Visible = false;
            // 
            // labelFiltrarPorProfessor
            // 
            this.labelFiltrarPorProfessor.AutoSize = true;
            this.labelFiltrarPorProfessor.Location = new System.Drawing.Point(297, 373);
            this.labelFiltrarPorProfessor.Name = "labelFiltrarPorProfessor";
            this.labelFiltrarPorProfessor.Size = new System.Drawing.Size(51, 13);
            this.labelFiltrarPorProfessor.TabIndex = 36;
            this.labelFiltrarPorProfessor.Text = "Professor";
            this.labelFiltrarPorProfessor.Visible = false;
            // 
            // comboBoxFiltroGrupo
            // 
            this.comboBoxFiltroGrupo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxFiltroGrupo.FormattingEnabled = true;
            this.comboBoxFiltroGrupo.Location = new System.Drawing.Point(531, 369);
            this.comboBoxFiltroGrupo.Name = "comboBoxFiltroGrupo";
            this.comboBoxFiltroGrupo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltroGrupo.TabIndex = 13;
            this.comboBoxFiltroGrupo.Visible = false;
            // 
            // labelFiltrarPorGrupo
            // 
            this.labelFiltrarPorGrupo.AutoSize = true;
            this.labelFiltrarPorGrupo.Location = new System.Drawing.Point(492, 373);
            this.labelFiltrarPorGrupo.Name = "labelFiltrarPorGrupo";
            this.labelFiltrarPorGrupo.Size = new System.Drawing.Size(36, 13);
            this.labelFiltrarPorGrupo.TabIndex = 38;
            this.labelFiltrarPorGrupo.Text = "Grupo";
            this.labelFiltrarPorGrupo.Visible = false;
            // 
            // radioButtonPesquisarPorLogin
            // 
            this.radioButtonPesquisarPorLogin.AutoSize = true;
            this.radioButtonPesquisarPorLogin.Location = new System.Drawing.Point(893, 332);
            this.radioButtonPesquisarPorLogin.Name = "radioButtonPesquisarPorLogin";
            this.radioButtonPesquisarPorLogin.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPesquisarPorLogin.TabIndex = 40;
            this.radioButtonPesquisarPorLogin.Text = "&Login";
            this.radioButtonPesquisarPorLogin.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorLogin.Visible = false;
            this.radioButtonPesquisarPorLogin.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorLogin_CheckedChanged);
            // 
            // radioButtonPesquisarPorCodigo
            // 
            this.radioButtonPesquisarPorCodigo.AutoSize = true;
            this.radioButtonPesquisarPorCodigo.Location = new System.Drawing.Point(700, 332);
            this.radioButtonPesquisarPorCodigo.Name = "radioButtonPesquisarPorCodigo";
            this.radioButtonPesquisarPorCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPesquisarPorCodigo.TabIndex = 41;
            this.radioButtonPesquisarPorCodigo.Text = "Códi&go";
            this.radioButtonPesquisarPorCodigo.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorCodigo.Visible = false;
            this.radioButtonPesquisarPorCodigo.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorCodigo_CheckedChanged);
            // 
            // radioButtonPesquisarPorNome
            // 
            this.radioButtonPesquisarPorNome.AutoSize = true;
            this.radioButtonPesquisarPorNome.Checked = true;
            this.radioButtonPesquisarPorNome.Location = new System.Drawing.Point(764, 313);
            this.radioButtonPesquisarPorNome.Name = "radioButtonPesquisarPorNome";
            this.radioButtonPesquisarPorNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPesquisarPorNome.TabIndex = 1;
            this.radioButtonPesquisarPorNome.TabStop = true;
            this.radioButtonPesquisarPorNome.Text = "&Nome";
            this.radioButtonPesquisarPorNome.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorNome.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorNome_CheckedChanged);
            // 
            // radioButtonPesquisarPorCPF
            // 
            this.radioButtonPesquisarPorCPF.AutoSize = true;
            this.radioButtonPesquisarPorCPF.Location = new System.Drawing.Point(826, 313);
            this.radioButtonPesquisarPorCPF.Name = "radioButtonPesquisarPorCPF";
            this.radioButtonPesquisarPorCPF.Size = new System.Drawing.Size(45, 17);
            this.radioButtonPesquisarPorCPF.TabIndex = 17;
            this.radioButtonPesquisarPorCPF.Text = "&CPF";
            this.radioButtonPesquisarPorCPF.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorCPF.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorCPF_CheckedChanged);
            // 
            // radioButtonPesquisarPorMatricula
            // 
            this.radioButtonPesquisarPorMatricula.AutoSize = true;
            this.radioButtonPesquisarPorMatricula.Location = new System.Drawing.Point(880, 313);
            this.radioButtonPesquisarPorMatricula.Name = "radioButtonPesquisarPorMatricula";
            this.radioButtonPesquisarPorMatricula.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPesquisarPorMatricula.TabIndex = 18;
            this.radioButtonPesquisarPorMatricula.Text = "&Matrícula";
            this.radioButtonPesquisarPorMatricula.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarPorMatricula.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarPorMatricula_CheckedChanged);
            // 
            // FrmMenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(979, 408);
            this.Controls.Add(this.radioButtonPesquisarPorCodigo);
            this.Controls.Add(this.radioButtonPesquisarPorLogin);
            this.Controls.Add(this.comboBoxFiltroGrupo);
            this.Controls.Add(this.labelFiltrarPorGrupo);
            this.Controls.Add(this.comboBoxFiltroProfessor);
            this.Controls.Add(this.labelFiltrarPorProfessor);
            this.Controls.Add(this.radioButtonPesquisarPorTema);
            this.Controls.Add(this.radioButtonPesquisarPorDescricao);
            this.Controls.Add(this.labelFiltrarPorData);
            this.Controls.Add(this.dateTimePickerFiltroData);
            this.Controls.Add(this.labelFiltrarPorTipo);
            this.Controls.Add(this.comboBoxFiltroTipo);
            this.Controls.Add(this.labelModuloTitulo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.comboBoxFiltroCurso);
            this.Controls.Add(this.labelFiltrarPorCurso);
            this.Controls.Add(this.labelFiltrarPorUnidade);
            this.Controls.Add(this.comboBoxFiltroUnidade);
            this.Controls.Add(this.radioButtonPesquisarPorMatricula);
            this.Controls.Add(this.radioButtonPesquisarPorCPF);
            this.Controls.Add(this.radioButtonPesquisarPorNome);
            this.Controls.Add(this.labelPesquisarEscolha);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.labelPesquisaTipo);
            this.Controls.Add(this.buttonUsuarioMenu);
            this.Controls.Add(this.buttonSalaMenu);
            this.Controls.Add(this.buttonUnidadeMenu);
            this.Controls.Add(this.buttonCursoMenu);
            this.Controls.Add(this.buttonProfessorMenu);
            this.Controls.Add(this.buttonTCCMenu);
            this.Controls.Add(this.labelNomeModulo);
            this.Controls.Add(this.buttonAlunoMenu);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuAdministrador";
            this.Text = "FrmMenuAluno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAlunoMenu;
        private System.Windows.Forms.Label labelNomeModulo;
        private System.Windows.Forms.Button buttonTCCMenu;
        private System.Windows.Forms.Button buttonProfessorMenu;
        private System.Windows.Forms.Button buttonCursoMenu;
        private System.Windows.Forms.Button buttonUnidadeMenu;
        private System.Windows.Forms.Button buttonSalaMenu;
        private System.Windows.Forms.Button buttonUsuarioMenu;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label labelPesquisaTipo;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelPesquisarEscolha;
        private System.Windows.Forms.ComboBox comboBoxFiltroUnidade;
        private System.Windows.Forms.Label labelFiltrarPorUnidade;
        private System.Windows.Forms.Label labelFiltrarPorCurso;
        private System.Windows.Forms.ComboBox comboBoxFiltroCurso;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelModuloTitulo;
        private System.Windows.Forms.Label labelFiltrarPorTipo;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltroData;
        private System.Windows.Forms.Label labelFiltrarPorData;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorDescricao;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorTema;
        private System.Windows.Forms.ComboBox comboBoxFiltroProfessor;
        private System.Windows.Forms.Label labelFiltrarPorProfessor;
        private System.Windows.Forms.ComboBox comboBoxFiltroGrupo;
        private System.Windows.Forms.Label labelFiltrarPorGrupo;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorLogin;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorCodigo;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorCPF;
        private System.Windows.Forms.RadioButton radioButtonPesquisarPorMatricula;
    }
}