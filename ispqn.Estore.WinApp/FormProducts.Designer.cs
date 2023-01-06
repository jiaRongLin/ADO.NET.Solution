namespace ispqn.Estore.WinApp
{
	partial class FormProducts
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.labelId = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 75);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1058, 391);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(774, 486);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(105, 43);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Add New..";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(774, 16);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(105, 43);
			this.buttonSearch.TabIndex = 2;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(165, 25);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(127, 30);
			this.txtId.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(488, 25);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(127, 30);
			this.txtName.TabIndex = 1;
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Location = new System.Drawing.Point(411, 25);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(57, 19);
			this.labelId.TabIndex = 6;
			this.labelId.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Id:";
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 552);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormProducts";
			this.Text = "FormProducts";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Label label2;
	}
}