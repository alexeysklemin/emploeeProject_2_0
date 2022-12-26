
namespace emploeeProject
{
    partial class comboSearch
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
            this.emloeesDataSet = new emploeeProject.emloeesDataSet();
            this.emploeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emploeeTableTableAdapter = new emploeeProject.emloeesDataSetTableAdapters.emploeeTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emloeesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emploeeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSecondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.emploeeTableBindingSource;
            this.comboBox1.DisplayMember = "eSurname";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "eSurname";
            // 
            // emloeesDataSet
            // 
            this.emloeesDataSet.DataSetName = "emloeesDataSet";
            this.emloeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emploeeTableBindingSource
            // 
            this.emploeeTableBindingSource.DataMember = "emploeeTable";
            this.emploeeTableBindingSource.DataSource = this.emloeesDataSet;
            // 
            // emploeeTableTableAdapter
            // 
            this.emploeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempDataGridViewTextBoxColumn,
            this.eNameDataGridViewTextBoxColumn,
            this.eSurnameDataGridViewTextBoxColumn,
            this.eSecondNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emploeeTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // emloeesDataSetBindingSource
            // 
            this.emloeesDataSetBindingSource.DataSource = this.emloeesDataSet;
            this.emloeesDataSetBindingSource.Position = 0;
            // 
            // emploeeTableBindingSource1
            // 
            this.emploeeTableBindingSource1.DataMember = "emploeeTable";
            this.emploeeTableBindingSource1.DataSource = this.emloeesDataSet;
            // 
            // idempDataGridViewTextBoxColumn
            // 
            this.idempDataGridViewTextBoxColumn.DataPropertyName = "id_emp";
            this.idempDataGridViewTextBoxColumn.HeaderText = "id_emp";
            this.idempDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idempDataGridViewTextBoxColumn.Name = "idempDataGridViewTextBoxColumn";
            this.idempDataGridViewTextBoxColumn.Width = 125;
            // 
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "eName";
            this.eNameDataGridViewTextBoxColumn.HeaderText = "eName";
            this.eNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            this.eNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // eSurnameDataGridViewTextBoxColumn
            // 
            this.eSurnameDataGridViewTextBoxColumn.DataPropertyName = "eSurname";
            this.eSurnameDataGridViewTextBoxColumn.HeaderText = "eSurname";
            this.eSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSurnameDataGridViewTextBoxColumn.Name = "eSurnameDataGridViewTextBoxColumn";
            this.eSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // eSecondNameDataGridViewTextBoxColumn
            // 
            this.eSecondNameDataGridViewTextBoxColumn.DataPropertyName = "eSecondName";
            this.eSecondNameDataGridViewTextBoxColumn.HeaderText = "eSecondName";
            this.eSecondNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSecondNameDataGridViewTextBoxColumn.Name = "eSecondNameDataGridViewTextBoxColumn";
            this.eSecondNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(514, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "comboSearch";
            this.Text = "comboSearch";
            this.Load += new System.EventHandler(this.comboSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private emloeesDataSet emloeesDataSet;
        private System.Windows.Forms.BindingSource emploeeTableBindingSource;
        private emloeesDataSetTableAdapters.emploeeTableTableAdapter emploeeTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource emloeesDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSecondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emploeeTableBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}