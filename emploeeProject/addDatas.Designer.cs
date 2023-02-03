
namespace emploeeProject
{
    partial class addDatas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.emploeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloeesDataSet = new emploeeProject.emloeesDataSet();
            this.emploeeTableTableAdapter = new emploeeProject.emloeesDataSetTableAdapters.emploeeTableTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.specializingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloeesDataSet1 = new emploeeProject.emloeesDataSet1();
            this.specializingTableAdapter = new emploeeProject.emloeesDataSet1TableAdapters.specializingTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloeesDataSet2 = new emploeeProject.emloeesDataSet2();
            this.departmentsTableAdapter = new emploeeProject.emloeesDataSet2TableAdapters.departmentsTableAdapter();
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.idnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resulttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloeesDataSet3 = new emploeeProject.emloeesDataSet3();
            this.result_tableTableAdapter = new emploeeProject.emloeesDataSet3TableAdapters.result_tableTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resulttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.emploeeTableBindingSource;
            this.comboBox1.DisplayMember = "eSurname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id_emp";
            // 
            // emploeeTableBindingSource
            // 
            this.emploeeTableBindingSource.DataMember = "emploeeTable";
            this.emploeeTableBindingSource.DataSource = this.emloeesDataSet;
            // 
            // emloeesDataSet
            // 
            this.emloeesDataSet.DataSetName = "emloeesDataSet";
            this.emloeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emploeeTableTableAdapter
            // 
            this.emploeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.specializingBindingSource;
            this.comboBox2.DisplayMember = "spec_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(277, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "id_sepc";
            // 
            // specializingBindingSource
            // 
            this.specializingBindingSource.DataMember = "specializing";
            this.specializingBindingSource.DataSource = this.emloeesDataSet1;
            // 
            // emloeesDataSet1
            // 
            this.emloeesDataSet1.DataSetName = "emloeesDataSet1";
            this.emloeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializingTableAdapter
            // 
            this.specializingTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.departmentsBindingSource;
            this.comboBox3.DisplayMember = "name_department";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(521, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(219, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "id_dep";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.emloeesDataSet2;
            // 
            // emloeesDataSet2
            // 
            this.emloeesDataSet2.DataSetName = "emloeesDataSet2";
            this.emloeesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resultTable
            // 
            this.resultTable.AutoGenerateColumns = false;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnameDataGridViewTextBoxColumn,
            this.iddepartamentDataGridViewTextBoxColumn,
            this.idspecDataGridViewTextBoxColumn});
            this.resultTable.DataSource = this.resulttableBindingSource;
            this.resultTable.Location = new System.Drawing.Point(36, 181);
            this.resultTable.Name = "resultTable";
            this.resultTable.RowHeadersWidth = 51;
            this.resultTable.RowTemplate.Height = 24;
            this.resultTable.Size = new System.Drawing.Size(704, 245);
            this.resultTable.TabIndex = 3;
            // 
            // idnameDataGridViewTextBoxColumn
            // 
            this.idnameDataGridViewTextBoxColumn.DataPropertyName = "id_name";
            this.idnameDataGridViewTextBoxColumn.HeaderText = "id_name";
            this.idnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idnameDataGridViewTextBoxColumn.Name = "idnameDataGridViewTextBoxColumn";
            this.idnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddepartamentDataGridViewTextBoxColumn
            // 
            this.iddepartamentDataGridViewTextBoxColumn.DataPropertyName = "id_departament";
            this.iddepartamentDataGridViewTextBoxColumn.HeaderText = "id_departament";
            this.iddepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddepartamentDataGridViewTextBoxColumn.Name = "iddepartamentDataGridViewTextBoxColumn";
            this.iddepartamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idspecDataGridViewTextBoxColumn
            // 
            this.idspecDataGridViewTextBoxColumn.DataPropertyName = "id_spec";
            this.idspecDataGridViewTextBoxColumn.HeaderText = "id_spec";
            this.idspecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idspecDataGridViewTextBoxColumn.Name = "idspecDataGridViewTextBoxColumn";
            this.idspecDataGridViewTextBoxColumn.Width = 125;
            // 
            // resulttableBindingSource
            // 
            this.resulttableBindingSource.DataMember = "result_table";
            this.resulttableBindingSource.DataSource = this.emloeesDataSet3;
            // 
            // emloeesDataSet3
            // 
            this.emloeesDataSet3.DataSetName = "emloeesDataSet3";
            this.emloeesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // result_tableTableAdapter
            // 
            this.result_tableTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(292, 117);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(204, 42);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "addDatas";
            this.Text = "addDatas";
            this.Load += new System.EventHandler(this.addDatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resulttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private emloeesDataSet emloeesDataSet;
        private System.Windows.Forms.BindingSource emploeeTableBindingSource;
        private emloeesDataSetTableAdapters.emploeeTableTableAdapter emploeeTableTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private emloeesDataSet1 emloeesDataSet1;
        private System.Windows.Forms.BindingSource specializingBindingSource;
        private emloeesDataSet1TableAdapters.specializingTableAdapter specializingTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private emloeesDataSet2 emloeesDataSet2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private emloeesDataSet2TableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridView resultTable;
        private emloeesDataSet3 emloeesDataSet3;
        private System.Windows.Forms.BindingSource resulttableBindingSource;
        private emloeesDataSet3TableAdapters.result_tableTableAdapter result_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addButton;
    }
}