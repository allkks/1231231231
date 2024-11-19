namespace app2
{
    partial class Form1
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
            this.idарендыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шифркнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номербилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датасдачифактDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выдачаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mdbDataSet = new app2.mdbDataSet();
            this.mdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдачаTableAdapter = new app2.mdbDataSetTableAdapters.ВыдачаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idарендыDataGridViewTextBoxColumn,
            this.шифркнигиDataGridViewTextBoxColumn,
            this.номербилетаDataGridViewTextBoxColumn,
            this.датавыдачиDataGridViewTextBoxColumn,
            this.датасдачиDataGridViewTextBoxColumn,
            this.датасдачифактDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.выдачаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // idарендыDataGridViewTextBoxColumn
            // 
            this.idарендыDataGridViewTextBoxColumn.DataPropertyName = "id_аренды";
            this.idарендыDataGridViewTextBoxColumn.HeaderText = "id_аренды";
            this.idарендыDataGridViewTextBoxColumn.Name = "idарендыDataGridViewTextBoxColumn";
            // 
            // шифркнигиDataGridViewTextBoxColumn
            // 
            this.шифркнигиDataGridViewTextBoxColumn.DataPropertyName = "Шифр_книги";
            this.шифркнигиDataGridViewTextBoxColumn.HeaderText = "Шифр_книги";
            this.шифркнигиDataGridViewTextBoxColumn.Name = "шифркнигиDataGridViewTextBoxColumn";
            // 
            // номербилетаDataGridViewTextBoxColumn
            // 
            this.номербилетаDataGridViewTextBoxColumn.DataPropertyName = "Номер_билета";
            this.номербилетаDataGridViewTextBoxColumn.HeaderText = "Номер_билета";
            this.номербилетаDataGridViewTextBoxColumn.Name = "номербилетаDataGridViewTextBoxColumn";
            // 
            // датавыдачиDataGridViewTextBoxColumn
            // 
            this.датавыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи";
            this.датавыдачиDataGridViewTextBoxColumn.Name = "датавыдачиDataGridViewTextBoxColumn";
            // 
            // датасдачиDataGridViewTextBoxColumn
            // 
            this.датасдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_сдачи";
            this.датасдачиDataGridViewTextBoxColumn.HeaderText = "Дата_сдачи";
            this.датасдачиDataGridViewTextBoxColumn.Name = "датасдачиDataGridViewTextBoxColumn";
            // 
            // датасдачифактDataGridViewTextBoxColumn
            // 
            this.датасдачифактDataGridViewTextBoxColumn.DataPropertyName = "Дата_сдачи_факт";
            this.датасдачифактDataGridViewTextBoxColumn.HeaderText = "Дата_сдачи_факт";
            this.датасдачифактDataGridViewTextBoxColumn.Name = "датасдачифактDataGridViewTextBoxColumn";
            // 
            // выдачаBindingSource
            // 
            this.выдачаBindingSource.DataMember = "Выдача";
            this.выдачаBindingSource.DataSource = this.mdbDataSet;
            // 
            // mdbDataSet
            // 
            this.mdbDataSet.DataSetName = "mdbDataSet";
            this.mdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mdbDataSetBindingSource
            // 
            this.mdbDataSetBindingSource.DataSource = this.mdbDataSet;
            this.mdbDataSetBindingSource.Position = 0;
            // 
            // выдачаTableAdapter
            // 
            this.выдачаTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mdbDataSetBindingSource;
        private mdbDataSet mdbDataSet;
        private System.Windows.Forms.BindingSource выдачаBindingSource;
        private mdbDataSetTableAdapters.ВыдачаTableAdapter выдачаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idарендыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шифркнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номербилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датасдачифактDataGridViewTextBoxColumn;
    }
}