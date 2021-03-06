﻿using GPApp.Model;
using GPApp.Wrapper;

namespace GPApp.WinForms.Views
{
    partial class ProdutoEditView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoEditView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControlProdutoEdit = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPagePrincipal = new MetroFramework.Controls.MetroTabPage();
            this.customEditPrecoPromocional = new GPApp.WinForms.Componentes.CustomEdit();
            this.customEditQuantidade = new GPApp.WinForms.Componentes.CustomEdit();
            this.customEditPreco = new GPApp.WinForms.Componentes.CustomEdit();
            this.customEditCusto = new GPApp.WinForms.Componentes.CustomEdit();
            this.customEditMultlineDescricao = new GPApp.WinForms.Componentes.CustomEditMultline();
            this.customEditNome = new GPApp.WinForms.Componentes.CustomEdit();
            this.customEditCodigo = new GPApp.WinForms.Componentes.CustomEdit();
            this.metroTabPageImagens = new MetroFramework.Controls.MetroTabPage();
            this.materialLabelPreview = new MaterialSkin.Controls.MaterialLabel();
            this.metroButtonIncluirImagem = new MetroFramework.Controls.MetroButton();
            this.metroGridImagens = new MetroFramework.Controls.MetroGrid();
            this.ordemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterarImagemColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExcluirImagemColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.produtoImagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.metroTabPageEspecificações = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonIncluirEspecificacao = new MetroFramework.Controls.MetroButton();
            this.metroGridEspecificacoes = new MetroFramework.Controls.MetroGrid();
            this.ordemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.produtoEspecificacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButtonSalvar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancelar = new MetroFramework.Controls.MetroButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroProgressSpinnerSalvar = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabControlProdutoEdit.SuspendLayout();
            this.metroTabPagePrincipal.SuspendLayout();
            this.metroTabPageImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridImagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoImagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.metroTabPageEspecificações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEspecificacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoEspecificacaoBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControlProdutoEdit
            // 
            this.metroTabControlProdutoEdit.Controls.Add(this.metroTabPagePrincipal);
            this.metroTabControlProdutoEdit.Controls.Add(this.metroTabPageImagens);
            this.metroTabControlProdutoEdit.Controls.Add(this.metroTabPageEspecificações);
            this.metroTabControlProdutoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControlProdutoEdit.Location = new System.Drawing.Point(0, 0);
            this.metroTabControlProdutoEdit.Name = "metroTabControlProdutoEdit";
            this.metroTabControlProdutoEdit.SelectedIndex = 0;
            this.metroTabControlProdutoEdit.Size = new System.Drawing.Size(889, 573);
            this.metroTabControlProdutoEdit.TabIndex = 0;
            this.metroTabControlProdutoEdit.UseSelectable = true;
            // 
            // metroTabPagePrincipal
            // 
            this.metroTabPagePrincipal.Controls.Add(this.customEditPrecoPromocional);
            this.metroTabPagePrincipal.Controls.Add(this.customEditQuantidade);
            this.metroTabPagePrincipal.Controls.Add(this.customEditPreco);
            this.metroTabPagePrincipal.Controls.Add(this.customEditCusto);
            this.metroTabPagePrincipal.Controls.Add(this.customEditMultlineDescricao);
            this.metroTabPagePrincipal.Controls.Add(this.customEditNome);
            this.metroTabPagePrincipal.Controls.Add(this.customEditCodigo);
            this.metroTabPagePrincipal.HorizontalScrollbarBarColor = true;
            this.metroTabPagePrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPagePrincipal.HorizontalScrollbarSize = 10;
            this.metroTabPagePrincipal.Location = new System.Drawing.Point(4, 38);
            this.metroTabPagePrincipal.Name = "metroTabPagePrincipal";
            this.metroTabPagePrincipal.Size = new System.Drawing.Size(881, 531);
            this.metroTabPagePrincipal.TabIndex = 0;
            this.metroTabPagePrincipal.Text = "Principal";
            this.metroTabPagePrincipal.VerticalScrollbarBarColor = true;
            this.metroTabPagePrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPagePrincipal.VerticalScrollbarSize = 10;
            // 
            // customEditPrecoPromocional
            // 
            this.customEditPrecoPromocional.BackColor = System.Drawing.Color.White;
            this.customEditPrecoPromocional.LabelErroText = "";
            this.customEditPrecoPromocional.LabelText = "Preço promocional";
            this.customEditPrecoPromocional.Location = new System.Drawing.Point(5, 411);
            this.customEditPrecoPromocional.MaxWidthEdit = 0;
            this.customEditPrecoPromocional.Name = "customEditPrecoPromocional";
            this.customEditPrecoPromocional.Size = new System.Drawing.Size(354, 49);
            this.customEditPrecoPromocional.TabIndex = 6;
            // 
            // customEditQuantidade
            // 
            this.customEditQuantidade.BackColor = System.Drawing.Color.White;
            this.customEditQuantidade.LabelErroText = "";
            this.customEditQuantidade.LabelText = "Estoque";
            this.customEditQuantidade.Location = new System.Drawing.Point(398, 411);
            this.customEditQuantidade.MaxWidthEdit = 0;
            this.customEditQuantidade.Name = "customEditQuantidade";
            this.customEditQuantidade.Size = new System.Drawing.Size(364, 49);
            this.customEditQuantidade.TabIndex = 7;
            // 
            // customEditPreco
            // 
            this.customEditPreco.BackColor = System.Drawing.Color.White;
            this.customEditPreco.LabelErroText = "";
            this.customEditPreco.LabelText = "Preço";
            this.customEditPreco.Location = new System.Drawing.Point(398, 345);
            this.customEditPreco.MaxWidthEdit = 0;
            this.customEditPreco.Name = "customEditPreco";
            this.customEditPreco.Size = new System.Drawing.Size(364, 49);
            this.customEditPreco.TabIndex = 5;
            // 
            // customEditCusto
            // 
            this.customEditCusto.BackColor = System.Drawing.Color.White;
            this.customEditCusto.LabelErroText = "";
            this.customEditCusto.LabelText = "Custo";
            this.customEditCusto.Location = new System.Drawing.Point(5, 345);
            this.customEditCusto.MaxWidthEdit = 0;
            this.customEditCusto.Name = "customEditCusto";
            this.customEditCusto.Size = new System.Drawing.Size(354, 49);
            this.customEditCusto.TabIndex = 4;
            // 
            // customEditMultlineDescricao
            // 
            this.customEditMultlineDescricao.BackColor = System.Drawing.Color.White;
            this.customEditMultlineDescricao.LabelErroText = "";
            this.customEditMultlineDescricao.LabelText = "Descrição";
            this.customEditMultlineDescricao.Location = new System.Drawing.Point(3, 132);
            this.customEditMultlineDescricao.Name = "customEditMultlineDescricao";
            this.customEditMultlineDescricao.Size = new System.Drawing.Size(759, 207);
            this.customEditMultlineDescricao.TabIndex = 3;
            // 
            // customEditNome
            // 
            this.customEditNome.BackColor = System.Drawing.Color.White;
            this.customEditNome.LabelErroText = "";
            this.customEditNome.LabelText = "Nome";
            this.customEditNome.Location = new System.Drawing.Point(3, 69);
            this.customEditNome.MaxWidthEdit = 0;
            this.customEditNome.Name = "customEditNome";
            this.customEditNome.Size = new System.Drawing.Size(759, 47);
            this.customEditNome.TabIndex = 2;
            // 
            // customEditCodigo
            // 
            this.customEditCodigo.BackColor = System.Drawing.Color.White;
            this.customEditCodigo.LabelErroText = "";
            this.customEditCodigo.LabelText = "Código";
            this.customEditCodigo.Location = new System.Drawing.Point(3, 16);
            this.customEditCodigo.MaxWidthEdit = 0;
            this.customEditCodigo.Name = "customEditCodigo";
            this.customEditCodigo.Size = new System.Drawing.Size(238, 47);
            this.customEditCodigo.TabIndex = 1;
            // 
            // metroTabPageImagens
            // 
            this.metroTabPageImagens.Controls.Add(this.materialLabelPreview);
            this.metroTabPageImagens.Controls.Add(this.metroButtonIncluirImagem);
            this.metroTabPageImagens.Controls.Add(this.metroGridImagens);
            this.metroTabPageImagens.Controls.Add(this.pictureBoxPreview);
            this.metroTabPageImagens.HorizontalScrollbarBarColor = true;
            this.metroTabPageImagens.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageImagens.HorizontalScrollbarSize = 10;
            this.metroTabPageImagens.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageImagens.Name = "metroTabPageImagens";
            this.metroTabPageImagens.Size = new System.Drawing.Size(881, 531);
            this.metroTabPageImagens.TabIndex = 1;
            this.metroTabPageImagens.Text = "Imagens";
            this.metroTabPageImagens.VerticalScrollbarBarColor = true;
            this.metroTabPageImagens.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageImagens.VerticalScrollbarSize = 10;
            // 
            // materialLabelPreview
            // 
            this.materialLabelPreview.AutoSize = true;
            this.materialLabelPreview.BackColor = System.Drawing.Color.White;
            this.materialLabelPreview.Depth = 0;
            this.materialLabelPreview.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelPreview.Location = new System.Drawing.Point(413, 37);
            this.materialLabelPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPreview.Name = "materialLabelPreview";
            this.materialLabelPreview.Size = new System.Drawing.Size(61, 19);
            this.materialLabelPreview.TabIndex = 11;
            this.materialLabelPreview.Text = "Preview";
            // 
            // metroButtonIncluirImagem
            // 
            this.metroButtonIncluirImagem.BackColor = System.Drawing.Color.White;
            this.metroButtonIncluirImagem.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonIncluirImagem.Location = new System.Drawing.Point(16, 17);
            this.metroButtonIncluirImagem.Name = "metroButtonIncluirImagem";
            this.metroButtonIncluirImagem.Size = new System.Drawing.Size(87, 39);
            this.metroButtonIncluirImagem.TabIndex = 10;
            this.metroButtonIncluirImagem.Text = "Incluir";
            this.metroButtonIncluirImagem.UseCustomBackColor = true;
            this.metroButtonIncluirImagem.UseSelectable = true;
            this.metroButtonIncluirImagem.Click += new System.EventHandler(this.MetroButtonIncluirImagem_Click);
            // 
            // metroGridImagens
            // 
            this.metroGridImagens.AllowUserToAddRows = false;
            this.metroGridImagens.AllowUserToDeleteRows = false;
            this.metroGridImagens.AllowUserToResizeRows = false;
            this.metroGridImagens.AutoGenerateColumns = false;
            this.metroGridImagens.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridImagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridImagens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridImagens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridImagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridImagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordemDataGridViewTextBoxColumn,
            this.alterarImagemColumn,
            this.ExcluirImagemColumn});
            this.metroGridImagens.DataSource = this.produtoImagemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridImagens.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridImagens.EnableHeadersVisualStyles = false;
            this.metroGridImagens.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridImagens.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridImagens.Location = new System.Drawing.Point(16, 62);
            this.metroGridImagens.MultiSelect = false;
            this.metroGridImagens.Name = "metroGridImagens";
            this.metroGridImagens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridImagens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridImagens.RowHeadersVisible = false;
            this.metroGridImagens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridImagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridImagens.Size = new System.Drawing.Size(345, 349);
            this.metroGridImagens.TabIndex = 8;
            // 
            // ordemDataGridViewTextBoxColumn
            // 
            this.ordemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ordemDataGridViewTextBoxColumn.DataPropertyName = "Ordem";
            this.ordemDataGridViewTextBoxColumn.HeaderText = "Ordem";
            this.ordemDataGridViewTextBoxColumn.Name = "ordemDataGridViewTextBoxColumn";
            this.ordemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alterarImagemColumn
            // 
            this.alterarImagemColumn.HeaderText = "Alterar";
            this.alterarImagemColumn.Image = ((System.Drawing.Image)(resources.GetObject("alterarImagemColumn.Image")));
            this.alterarImagemColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.alterarImagemColumn.Name = "alterarImagemColumn";
            this.alterarImagemColumn.ReadOnly = true;
            this.alterarImagemColumn.Width = 50;
            // 
            // ExcluirImagemColumn
            // 
            this.ExcluirImagemColumn.HeaderText = "Excluir";
            this.ExcluirImagemColumn.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirImagemColumn.Image")));
            this.ExcluirImagemColumn.Name = "ExcluirImagemColumn";
            this.ExcluirImagemColumn.ReadOnly = true;
            this.ExcluirImagemColumn.Width = 50;
            // 
            // produtoImagemBindingSource
            // 
            this.produtoImagemBindingSource.DataSource = typeof(GPApp.Model.ProdutoImagem);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(417, 62);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(431, 349);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 7;
            this.pictureBoxPreview.TabStop = false;
            // 
            // metroTabPageEspecificações
            // 
            this.metroTabPageEspecificações.Controls.Add(this.metroButtonIncluirEspecificacao);
            this.metroTabPageEspecificações.Controls.Add(this.metroGridEspecificacoes);
            this.metroTabPageEspecificações.HorizontalScrollbarBarColor = true;
            this.metroTabPageEspecificações.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageEspecificações.HorizontalScrollbarSize = 10;
            this.metroTabPageEspecificações.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageEspecificações.Name = "metroTabPageEspecificações";
            this.metroTabPageEspecificações.Size = new System.Drawing.Size(881, 531);
            this.metroTabPageEspecificações.TabIndex = 2;
            this.metroTabPageEspecificações.Text = "Especificações";
            this.metroTabPageEspecificações.VerticalScrollbarBarColor = true;
            this.metroTabPageEspecificações.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageEspecificações.VerticalScrollbarSize = 10;
            // 
            // metroButtonIncluirEspecificacao
            // 
            this.metroButtonIncluirEspecificacao.BackColor = System.Drawing.Color.White;
            this.metroButtonIncluirEspecificacao.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonIncluirEspecificacao.Location = new System.Drawing.Point(3, 11);
            this.metroButtonIncluirEspecificacao.Name = "metroButtonIncluirEspecificacao";
            this.metroButtonIncluirEspecificacao.Size = new System.Drawing.Size(87, 39);
            this.metroButtonIncluirEspecificacao.TabIndex = 11;
            this.metroButtonIncluirEspecificacao.Text = "Incluir";
            this.metroButtonIncluirEspecificacao.UseCustomBackColor = true;
            this.metroButtonIncluirEspecificacao.UseSelectable = true;
            this.metroButtonIncluirEspecificacao.Click += new System.EventHandler(this.MetroButtonIncluirEspecificacao_Click);
            // 
            // metroGridEspecificacoes
            // 
            this.metroGridEspecificacoes.AllowUserToAddRows = false;
            this.metroGridEspecificacoes.AllowUserToDeleteRows = false;
            this.metroGridEspecificacoes.AllowUserToResizeRows = false;
            this.metroGridEspecificacoes.AutoGenerateColumns = false;
            this.metroGridEspecificacoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEspecificacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEspecificacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEspecificacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEspecificacoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridEspecificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridEspecificacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordemDataGridViewTextBoxColumn1,
            this.EspNomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.ColumnEspExcluir});
            this.metroGridEspecificacoes.DataSource = this.produtoEspecificacaoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEspecificacoes.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridEspecificacoes.EnableHeadersVisualStyles = false;
            this.metroGridEspecificacoes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEspecificacoes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEspecificacoes.Location = new System.Drawing.Point(3, 63);
            this.metroGridEspecificacoes.Name = "metroGridEspecificacoes";
            this.metroGridEspecificacoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEspecificacoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridEspecificacoes.RowHeadersVisible = false;
            this.metroGridEspecificacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEspecificacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEspecificacoes.Size = new System.Drawing.Size(875, 372);
            this.metroGridEspecificacoes.TabIndex = 8;
            // 
            // ordemDataGridViewTextBoxColumn1
            // 
            this.ordemDataGridViewTextBoxColumn1.DataPropertyName = "Ordem";
            this.ordemDataGridViewTextBoxColumn1.HeaderText = "Ordem";
            this.ordemDataGridViewTextBoxColumn1.Name = "ordemDataGridViewTextBoxColumn1";
            this.ordemDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ordemDataGridViewTextBoxColumn1.Width = 50;
            // 
            // EspNomeDataGridViewTextBoxColumn
            // 
            this.EspNomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.EspNomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.EspNomeDataGridViewTextBoxColumn.Name = "EspNomeDataGridViewTextBoxColumn";
            this.EspNomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // ColumnEspExcluir
            // 
            this.ColumnEspExcluir.HeaderText = "Excluir";
            this.ColumnEspExcluir.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEspExcluir.Image")));
            this.ColumnEspExcluir.Name = "ColumnEspExcluir";
            this.ColumnEspExcluir.Width = 50;
            // 
            // produtoEspecificacaoBindingSource
            // 
            this.produtoEspecificacaoBindingSource.DataSource = typeof(GPApp.Model.ProdutoEspecificacao);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroButtonSalvar);
            this.flowLayoutPanel1.Controls.Add(this.metroButtonCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 520);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(889, 53);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // metroButtonSalvar
            // 
            this.metroButtonSalvar.BackColor = System.Drawing.Color.White;
            this.metroButtonSalvar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonSalvar.Location = new System.Drawing.Point(3, 3);
            this.metroButtonSalvar.Name = "metroButtonSalvar";
            this.metroButtonSalvar.Size = new System.Drawing.Size(87, 39);
            this.metroButtonSalvar.TabIndex = 8;
            this.metroButtonSalvar.Text = "Salvar";
            this.metroButtonSalvar.UseCustomBackColor = true;
            this.metroButtonSalvar.UseSelectable = true;
            this.metroButtonSalvar.Click += new System.EventHandler(this.MetroButtonSalvar_Click);
            // 
            // metroButtonCancelar
            // 
            this.metroButtonCancelar.BackColor = System.Drawing.Color.White;
            this.metroButtonCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonCancelar.Location = new System.Drawing.Point(96, 3);
            this.metroButtonCancelar.Name = "metroButtonCancelar";
            this.metroButtonCancelar.Size = new System.Drawing.Size(87, 39);
            this.metroButtonCancelar.TabIndex = 9;
            this.metroButtonCancelar.Text = "Cancelar";
            this.metroButtonCancelar.UseCustomBackColor = true;
            this.metroButtonCancelar.UseSelectable = true;
            this.metroButtonCancelar.Click += new System.EventHandler(this.MetroButtonCancelar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Alterar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Excluir";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // metroProgressSpinnerSalvar
            // 
            this.metroProgressSpinnerSalvar.BackColor = System.Drawing.Color.White;
            this.metroProgressSpinnerSalvar.Location = new System.Drawing.Point(356, 185);
            this.metroProgressSpinnerSalvar.Maximum = 100;
            this.metroProgressSpinnerSalvar.Minimum = 99;
            this.metroProgressSpinnerSalvar.Name = "metroProgressSpinnerSalvar";
            this.metroProgressSpinnerSalvar.Size = new System.Drawing.Size(176, 160);
            this.metroProgressSpinnerSalvar.Speed = 2F;
            this.metroProgressSpinnerSalvar.TabIndex = 14;
            this.metroProgressSpinnerSalvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProgressSpinnerSalvar.UseCustomBackColor = true;
            this.metroProgressSpinnerSalvar.UseSelectable = true;
            this.metroProgressSpinnerSalvar.Value = 99;
            this.metroProgressSpinnerSalvar.Visible = false;
            // 
            // ProdutoEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroTabControlProdutoEdit);
            this.Controls.Add(this.metroProgressSpinnerSalvar);
            this.Name = "ProdutoEditView";
            this.Size = new System.Drawing.Size(889, 573);
            this.metroTabControlProdutoEdit.ResumeLayout(false);
            this.metroTabPagePrincipal.ResumeLayout(false);
            this.metroTabPageImagens.ResumeLayout(false);
            this.metroTabPageImagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridImagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoImagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.metroTabPageEspecificações.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEspecificacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoEspecificacaoBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControlProdutoEdit;
        private MetroFramework.Controls.MetroTabPage metroTabPagePrincipal;
        private MetroFramework.Controls.MetroTabPage metroTabPageImagens;
        private MetroFramework.Controls.MetroTabPage metroTabPageEspecificações;
        private Componentes.CustomEdit customEditQuantidade;
        private Componentes.CustomEdit customEditPreco;
        private Componentes.CustomEdit customEditCusto;
        private Componentes.CustomEditMultline customEditMultlineDescricao;
        private Componentes.CustomEdit customEditNome;
        private Componentes.CustomEdit customEditCodigo;
        private MetroFramework.Controls.MetroGrid metroGridImagens;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private MetroFramework.Controls.MetroGrid metroGridEspecificacoes;
        private MetroFramework.Controls.MetroButton metroButtonIncluirImagem;
        private MetroFramework.Controls.MetroButton metroButtonIncluirEspecificacao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton metroButtonSalvar;
        private MetroFramework.Controls.MetroButton metroButtonCancelar;
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private System.Windows.Forms.BindingSource produtoImagemBindingSource;
        private System.Windows.Forms.BindingSource produtoEspecificacaoBindingSource;
        private Componentes.CustomEdit customEditPrecoPromocional;
        private MaterialSkin.Controls.MaterialLabel materialLabelPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn alterarImagemColumn;
        private System.Windows.Forms.DataGridViewImageColumn ExcluirImagemColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEspExcluir;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerSalvar;
    }
}
