
namespace emploeeProject
{
    partial class mainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSecondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emploeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emloeesDataSet = new emploeeProject.emloeesDataSet();
            this.id_emp = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.uSurname = new System.Windows.Forms.Label();
            this.uSecName = new System.Windows.Forms.Label();
            this.uSecNamBox = new System.Windows.Forms.TextBox();
            this.uSurnameBox = new System.Windows.Forms.TextBox();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.uIdBox = new System.Windows.Forms.TextBox();
            this.emploeeTableTableAdapter = new emploeeProject.emloeesDataSetTableAdapters.emploeeTableTableAdapter();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.emploeeTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(630, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // id_emp
            // 
            this.id_emp.AutoSize = true;
            this.id_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_emp.Location = new System.Drawing.Point(41, 46);
            this.id_emp.Name = "id_emp";
            this.id_emp.Size = new System.Drawing.Size(27, 24);
            this.id_emp.TabIndex = 1;
            this.id_emp.Text = "ID";
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uName.Location = new System.Drawing.Point(41, 99);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(61, 24);
            this.uName.TabIndex = 2;
            this.uName.Text = "Name";
            // 
            // uSurname
            // 
            this.uSurname.AutoSize = true;
            this.uSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uSurname.Location = new System.Drawing.Point(42, 170);
            this.uSurname.Name = "uSurname";
            this.uSurname.Size = new System.Drawing.Size(87, 24);
            this.uSurname.TabIndex = 3;
            this.uSurname.Text = "Surname";
            // 
            // uSecName
            // 
            this.uSecName.AutoSize = true;
            this.uSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uSecName.Location = new System.Drawing.Point(43, 242);
            this.uSecName.Name = "uSecName";
            this.uSecName.Size = new System.Drawing.Size(132, 24);
            this.uSecName.TabIndex = 4;
            this.uSecName.Text = "Second Name";
            // 
            // uSecNamBox
            // 
            this.uSecNamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uSecNamBox.Location = new System.Drawing.Point(229, 242);
            this.uSecNamBox.Name = "uSecNamBox";
            this.uSecNamBox.Size = new System.Drawing.Size(163, 28);
            this.uSecNamBox.TabIndex = 5;
            // 
            // uSurnameBox
            // 
            this.uSurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uSurnameBox.Location = new System.Drawing.Point(229, 171);
            this.uSurnameBox.Name = "uSurnameBox";
            this.uSurnameBox.Size = new System.Drawing.Size(163, 28);
            this.uSurnameBox.TabIndex = 6;
            // 
            // uNameBox
            // 
            this.uNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uNameBox.Location = new System.Drawing.Point(229, 99);
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(163, 28);
            this.uNameBox.TabIndex = 7;
            // 
            // uIdBox
            // 
            this.uIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uIdBox.Location = new System.Drawing.Point(229, 46);
            this.uIdBox.Name = "uIdBox";
            this.uIdBox.Size = new System.Drawing.Size(163, 28);
            this.uIdBox.TabIndex = 8;
            // 
            // emploeeTableTableAdapter
            // 
            this.emploeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertBtn.Location = new System.Drawing.Point(171, 346);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(122, 35);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.Location = new System.Drawing.Point(351, 346);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 35);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(519, 346);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(98, 35);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AllowDrop = true;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(696, 346);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 35);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 476);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uIdBox);
            this.Controls.Add(this.uNameBox);
            this.Controls.Add(this.uSurnameBox);
            this.Controls.Add(this.uSecNamBox);
            this.Controls.Add(this.uSecName);
            this.Controls.Add(this.uSurname);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.id_emp);
            this.Name = "mainForm";
            this.Text = "Main Work Area";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emloeesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label id_emp;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.Label uSurname;
        private System.Windows.Forms.Label uSecName;
        private System.Windows.Forms.TextBox uSecNamBox;
        private System.Windows.Forms.TextBox uSurnameBox;
        private System.Windows.Forms.TextBox uNameBox;
        private System.Windows.Forms.TextBox uIdBox;
        private emloeesDataSet emloeesDataSet;
        private System.Windows.Forms.BindingSource emploeeTableBindingSource;
        private emloeesDataSetTableAdapters.emploeeTableTableAdapter emploeeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSecondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}