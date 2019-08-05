namespace HotelReservacion
{
    partial class FormNuevaReservacion
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label horaILabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label npersonasLabel;
            System.Windows.Forms.Label origenLabel;
            System.Windows.Forms.Label pagoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevaReservacion));
            this.listaReservacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaReservacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaReservacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaReservacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.horaIDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.npersonasTextBox = new System.Windows.Forms.TextBox();
            this.origenTextBox = new System.Windows.Forms.TextBox();
            this.pagoTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            horaILabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            npersonasLabel = new System.Windows.Forms.Label();
            origenLabel = new System.Windows.Forms.Label();
            pagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaReservacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReservacionesBindingNavigator)).BeginInit();
            this.listaReservacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaReservacionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(638, 144);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 2;
            activoLabel.Text = "Activo:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(136, 113);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 4;
            edadLabel.Text = "Edad:";
            // 
            // horaILabel
            // 
            horaILabel.AutoSize = true;
            horaILabel.Location = new System.Drawing.Point(132, 194);
            horaILabel.Name = "horaILabel";
            horaILabel.Size = new System.Drawing.Size(39, 13);
            horaILabel.TabIndex = 6;
            horaILabel.Text = "Hora I:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(88, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(124, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // npersonasLabel
            // 
            npersonasLabel.AutoSize = true;
            npersonasLabel.Location = new System.Drawing.Point(110, 165);
            npersonasLabel.Name = "npersonasLabel";
            npersonasLabel.Size = new System.Drawing.Size(61, 13);
            npersonasLabel.TabIndex = 12;
            npersonasLabel.Text = "Npersonas:";
            // 
            // origenLabel
            // 
            origenLabel.AutoSize = true;
            origenLabel.Location = new System.Drawing.Point(130, 139);
            origenLabel.Name = "origenLabel";
            origenLabel.Size = new System.Drawing.Size(41, 13);
            origenLabel.TabIndex = 14;
            origenLabel.Text = "Origen:";
            // 
            // pagoLabel
            // 
            pagoLabel.AutoSize = true;
            pagoLabel.Location = new System.Drawing.Point(638, 116);
            pagoLabel.Name = "pagoLabel";
            pagoLabel.Size = new System.Drawing.Size(35, 13);
            pagoLabel.TabIndex = 16;
            pagoLabel.Text = "Pago:";
            // 
            // listaReservacionesBindingSource
            // 
            this.listaReservacionesBindingSource.DataSource = typeof(Reservacion.BL.ReservacionBL.Reservacion);
            // 
            // listaReservacionesBindingNavigator
            // 
            this.listaReservacionesBindingNavigator.AddNewItem = null;
            this.listaReservacionesBindingNavigator.BindingSource = this.listaReservacionesBindingSource;
            this.listaReservacionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaReservacionesBindingNavigator.DeleteItem = null;
            this.listaReservacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaReservacionesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaReservacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaReservacionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaReservacionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaReservacionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaReservacionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaReservacionesBindingNavigator.Name = "listaReservacionesBindingNavigator";
            this.listaReservacionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaReservacionesBindingNavigator.Size = new System.Drawing.Size(864, 25);
            this.listaReservacionesBindingNavigator.TabIndex = 0;
            this.listaReservacionesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaReservacionesBindingNavigatorSaveItem
            // 
            this.listaReservacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaReservacionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaReservacionesBindingNavigatorSaveItem.Image")));
            this.listaReservacionesBindingNavigatorSaveItem.Name = "listaReservacionesBindingNavigatorSaveItem";
            this.listaReservacionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaReservacionesBindingNavigatorSaveItem.Text = "Save Data";
            this.listaReservacionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaReservacionesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listaReservacionesDataGridView
            // 
            this.listaReservacionesDataGridView.AutoGenerateColumns = false;
            this.listaReservacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaReservacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.listaReservacionesDataGridView.DataSource = this.listaReservacionesBindingSource;
            this.listaReservacionesDataGridView.Location = new System.Drawing.Point(12, 225);
            this.listaReservacionesDataGridView.Name = "listaReservacionesDataGridView";
            this.listaReservacionesDataGridView.Size = new System.Drawing.Size(844, 165);
            this.listaReservacionesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Origen";
            this.dataGridViewTextBoxColumn4.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Npersonas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Npersonas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HoraI";
            this.dataGridViewTextBoxColumn6.HeaderText = "HoraI";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Pago";
            this.dataGridViewTextBoxColumn7.HeaderText = "Pago";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaReservacionesBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(684, 139);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.Text = "checkBox1";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReservacionesBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(177, 110);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(46, 20);
            this.edadTextBox.TabIndex = 5;
            // 
            // horaIDateTimePicker
            // 
            this.horaIDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaReservacionesBindingSource, "HoraI", true));
            this.horaIDateTimePicker.Location = new System.Drawing.Point(177, 188);
            this.horaIDateTimePicker.Name = "horaIDateTimePicker";
            this.horaIDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.horaIDateTimePicker.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReservacionesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(113, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(58, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReservacionesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(177, 84);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(259, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // npersonasTextBox
            // 
            this.npersonasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReservacionesBindingSource, "Npersonas", true));
            this.npersonasTextBox.Location = new System.Drawing.Point(177, 162);
            this.npersonasTextBox.Name = "npersonasTextBox";
            this.npersonasTextBox.Size = new System.Drawing.Size(200, 20);
            this.npersonasTextBox.TabIndex = 13;
            // 
            // origenTextBox
            // 
            this.origenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReservacionesBindingSource, "Origen", true));
            this.origenTextBox.Location = new System.Drawing.Point(177, 136);
            this.origenTextBox.Name = "origenTextBox";
            this.origenTextBox.Size = new System.Drawing.Size(324, 20);
            this.origenTextBox.TabIndex = 15;
            // 
            // pagoTextBox
            // 
            this.pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaReservacionesBindingSource, "Pago", true));
            this.pagoTextBox.Location = new System.Drawing.Point(679, 113);
            this.pagoTextBox.Name = "pagoTextBox";
            this.pagoTextBox.Size = new System.Drawing.Size(102, 20);
            this.pagoTextBox.TabIndex = 17;
            // 
            // FormNuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 405);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(horaILabel);
            this.Controls.Add(this.horaIDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(npersonasLabel);
            this.Controls.Add(this.npersonasTextBox);
            this.Controls.Add(origenLabel);
            this.Controls.Add(this.origenTextBox);
            this.Controls.Add(pagoLabel);
            this.Controls.Add(this.pagoTextBox);
            this.Controls.Add(this.listaReservacionesDataGridView);
            this.Controls.Add(this.listaReservacionesBindingNavigator);
            this.Name = "FormNuevaReservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Reservacion";
            ((System.ComponentModel.ISupportInitialize)(this.listaReservacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaReservacionesBindingNavigator)).EndInit();
            this.listaReservacionesBindingNavigator.ResumeLayout(false);
            this.listaReservacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaReservacionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaReservacionesBindingSource;
        private System.Windows.Forms.BindingNavigator listaReservacionesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaReservacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listaReservacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.DateTimePicker horaIDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox npersonasTextBox;
        private System.Windows.Forms.TextBox origenTextBox;
        private System.Windows.Forms.TextBox pagoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}