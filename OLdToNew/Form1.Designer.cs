namespace OLdToNew
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plantasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.plantasoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantauzoldDataSet = new OLdToNew.plantauzoldDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plantasDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantauzDataSet = new OLdToNew.plantauzDataSet();
            this.plantasTableAdapter = new OLdToNew.plantauzoldDataSetTableAdapters.plantasTableAdapter();
            this.tableOldAdapterManager = new OLdToNew.plantauzoldDataSetTableAdapters.TableAdapterManager();
            this.plantasTableAdapter1 = new OLdToNew.plantauzDataSetTableAdapters.plantasTableAdapter();
            this.tableAdapterManager = new OLdToNew.plantauzDataSetTableAdapters.TableAdapterManager();
            this.imagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagesTableAdapter = new OLdToNew.plantauzDataSetTableAdapters.imagesTableAdapter();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasTableAdapter = new OLdToNew.plantauzDataSetTableAdapters.AreasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantauzoldDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantasDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantauzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(577, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.plantasDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old PlantaUz DataBase";
            // 
            // plantasDataGridView
            // 
            this.plantasDataGridView.AllowUserToAddRows = false;
            this.plantasDataGridView.AllowUserToDeleteRows = false;
            this.plantasDataGridView.AutoGenerateColumns = false;
            this.plantasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plantasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewImageColumn5});
            this.plantasDataGridView.DataSource = this.plantasoldBindingSource;
            this.plantasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plantasDataGridView.Location = new System.Drawing.Point(3, 30);
            this.plantasDataGridView.MultiSelect = false;
            this.plantasDataGridView.Name = "plantasDataGridView";
            this.plantasDataGridView.ReadOnly = true;
            this.plantasDataGridView.RowHeadersVisible = false;
            this.plantasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plantasDataGridView.Size = new System.Drawing.Size(968, 246);
            this.plantasDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LatName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LatName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RusName";
            this.dataGridViewTextBoxColumn3.HeaderText = "RusName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UzbName";
            this.dataGridViewTextBoxColumn4.HeaderText = "UzbName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FamName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FamName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Description";
            this.dataGridViewImageColumn1.HeaderText = "Description";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "MapImage";
            this.dataGridViewImageColumn2.HeaderText = "MapImage";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Latitude";
            this.dataGridViewTextBoxColumn6.HeaderText = "Latitude";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Longitude";
            this.dataGridViewTextBoxColumn7.HeaderText = "Longitude";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Zoom";
            this.dataGridViewTextBoxColumn8.HeaderText = "Zoom";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MapProvider";
            this.dataGridViewTextBoxColumn9.HeaderText = "MapProvider";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.DataPropertyName = "MapOverlay";
            this.dataGridViewImageColumn3.HeaderText = "MapOverlay";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Visible = false;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.DataPropertyName = "PolygonColors";
            this.dataGridViewImageColumn4.HeaderText = "PolygonColors";
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DescriptionText";
            this.dataGridViewTextBoxColumn10.HeaderText = "DescriptionText";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.DataPropertyName = "Photos";
            this.dataGridViewImageColumn5.HeaderText = "Photos";
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Visible = false;
            // 
            // plantasoldBindingSource
            // 
            this.plantasoldBindingSource.DataMember = "plantas";
            this.plantasoldBindingSource.DataSource = this.plantauzoldDataSet;
            // 
            // plantauzoldDataSet
            // 
            this.plantauzoldDataSet.DataSetName = "plantauzoldDataSet";
            this.plantauzoldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.plantasDataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New PlantaUz DataBase";
            // 
            // plantasDataGridView1
            // 
            this.plantasDataGridView1.AllowUserToAddRows = false;
            this.plantasDataGridView1.AllowUserToDeleteRows = false;
            this.plantasDataGridView1.AutoGenerateColumns = false;
            this.plantasDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plantasDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantasDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewImageColumn6,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewImageColumn7,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.plantasDataGridView1.DataSource = this.plantasBindingSource;
            this.plantasDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plantasDataGridView1.Location = new System.Drawing.Point(3, 30);
            this.plantasDataGridView1.MultiSelect = false;
            this.plantasDataGridView1.Name = "plantasDataGridView1";
            this.plantasDataGridView1.ReadOnly = true;
            this.plantasDataGridView1.RowHeadersVisible = false;
            this.plantasDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.plantasDataGridView1.Size = new System.Drawing.Size(968, 258);
            this.plantasDataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn11.HeaderText = "No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "LatName";
            this.dataGridViewTextBoxColumn12.HeaderText = "LatName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RusName";
            this.dataGridViewTextBoxColumn13.HeaderText = "RusName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UzbName";
            this.dataGridViewTextBoxColumn14.HeaderText = "UzbName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "FamName";
            this.dataGridViewTextBoxColumn15.HeaderText = "FamName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.DataPropertyName = "Description";
            this.dataGridViewImageColumn6.HeaderText = "Description";
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DescriptionText";
            this.dataGridViewTextBoxColumn16.HeaderText = "DescriptionText";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewImageColumn7
            // 
            this.dataGridViewImageColumn7.DataPropertyName = "MapImage";
            this.dataGridViewImageColumn7.HeaderText = "MapImage";
            this.dataGridViewImageColumn7.Name = "dataGridViewImageColumn7";
            this.dataGridViewImageColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Latitude";
            this.dataGridViewTextBoxColumn17.HeaderText = "Latitude";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Longitude";
            this.dataGridViewTextBoxColumn18.HeaderText = "Longitude";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Zoom";
            this.dataGridViewTextBoxColumn19.HeaderText = "Zoom";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "MapProvider";
            this.dataGridViewTextBoxColumn20.HeaderText = "MapProvider";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // plantasBindingSource
            // 
            this.plantasBindingSource.DataMember = "plantas";
            this.plantasBindingSource.DataSource = this.plantauzDataSet;
            // 
            // plantauzDataSet
            // 
            this.plantauzDataSet.DataSetName = "plantauzDataSet";
            this.plantauzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantasTableAdapter
            // 
            this.plantasTableAdapter.ClearBeforeFill = true;
            // 
            // tableOldAdapterManager
            // 
            this.tableOldAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableOldAdapterManager.imagesTableAdapter = null;
            this.tableOldAdapterManager.mapProvidersTableAdapter = null;
            this.tableOldAdapterManager.plantasTableAdapter = this.plantasTableAdapter;
            this.tableOldAdapterManager.UpdateOrder = OLdToNew.plantauzoldDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // plantasTableAdapter1
            // 
            this.plantasTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.imagesTableAdapter = null;
            this.tableAdapterManager.plantasTableAdapter = this.plantasTableAdapter1;
            this.tableAdapterManager.UpdateOrder = OLdToNew.plantauzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagesBindingSource
            // 
            this.imagesBindingSource.DataMember = "plantasimages";
            this.imagesBindingSource.DataSource = this.plantasBindingSource;
            // 
            // imagesTableAdapter
            // 
            this.imagesTableAdapter.ClearBeforeFill = true;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "plantasAreas";
            this.areasBindingSource.DataSource = this.plantasBindingSource;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(998, 548);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old to New";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plantasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantauzoldDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plantasDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantauzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private plantauzoldDataSet plantauzoldDataSet;
        private System.Windows.Forms.BindingSource plantasoldBindingSource;
        private plantauzoldDataSetTableAdapters.plantasTableAdapter plantasTableAdapter;
        private plantauzoldDataSetTableAdapters.TableAdapterManager tableOldAdapterManager;
        private System.Windows.Forms.DataGridView plantasDataGridView;
        private plantauzDataSet plantauzDataSet;
        private System.Windows.Forms.BindingSource plantasBindingSource;
        private plantauzDataSetTableAdapters.plantasTableAdapter plantasTableAdapter1;
        private plantauzDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridView plantasDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.BindingSource imagesBindingSource;
        private plantauzDataSetTableAdapters.imagesTableAdapter imagesTableAdapter;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private plantauzDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
    }
}

