namespace ispqn.Estore.WinApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.btn_getconnectionstring = new System.Windows.Forms.Button();
			this.btn_getconnection = new System.Windows.Forms.Button();
			this.checkBox_pooling = new System.Windows.Forms.CheckBox();
			this.btn_Category = new System.Windows.Forms.Button();
			this.text_categoryid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_ExectueScalar = new System.Windows.Forms.Button();
			this.btn_GetProducts = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.text_productName = new System.Windows.Forms.TextBox();
			this.btn_createnews = new System.Windows.Forms.Button();
			this.btn_editnews = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textNewsid = new System.Windows.Forms.TextBox();
			this.btn_delelte = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_getconnectionstring
			// 
			this.btn_getconnectionstring.Location = new System.Drawing.Point(30, 27);
			this.btn_getconnectionstring.Name = "btn_getconnectionstring";
			this.btn_getconnectionstring.Size = new System.Drawing.Size(182, 26);
			this.btn_getconnectionstring.TabIndex = 0;
			this.btn_getconnectionstring.Text = "GetConnectionString";
			this.btn_getconnectionstring.UseVisualStyleBackColor = true;
			this.btn_getconnectionstring.Click += new System.EventHandler(this.btn_getconnectionstring_Click);
			// 
			// btn_getconnection
			// 
			this.btn_getconnection.Location = new System.Drawing.Point(30, 65);
			this.btn_getconnection.Name = "btn_getconnection";
			this.btn_getconnection.Size = new System.Drawing.Size(182, 26);
			this.btn_getconnection.TabIndex = 1;
			this.btn_getconnection.Text = "GetConnection";
			this.btn_getconnection.UseVisualStyleBackColor = true;
			this.btn_getconnection.Click += new System.EventHandler(this.btn_getconnection_Click);
			// 
			// checkBox_pooling
			// 
			this.checkBox_pooling.AutoSize = true;
			this.checkBox_pooling.Location = new System.Drawing.Point(220, 69);
			this.checkBox_pooling.Name = "checkBox_pooling";
			this.checkBox_pooling.Size = new System.Drawing.Size(73, 19);
			this.checkBox_pooling.TabIndex = 2;
			this.checkBox_pooling.Text = "Pooling";
			this.checkBox_pooling.UseVisualStyleBackColor = true;
			// 
			// btn_Category
			// 
			this.btn_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Category.Location = new System.Drawing.Point(30, 103);
			this.btn_Category.Name = "btn_Category";
			this.btn_Category.Size = new System.Drawing.Size(182, 26);
			this.btn_Category.TabIndex = 3;
			this.btn_Category.Text = "讀取一筆Category";
			this.btn_Category.UseVisualStyleBackColor = true;
			this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
			// 
			// text_categoryid
			// 
			this.text_categoryid.Location = new System.Drawing.Point(264, 103);
			this.text_categoryid.Name = "text_categoryid";
			this.text_categoryid.Size = new System.Drawing.Size(182, 25);
			this.text_categoryid.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(221, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "id";
			// 
			// btn_ExectueScalar
			// 
			this.btn_ExectueScalar.Location = new System.Drawing.Point(30, 141);
			this.btn_ExectueScalar.Name = "btn_ExectueScalar";
			this.btn_ExectueScalar.Size = new System.Drawing.Size(182, 26);
			this.btn_ExectueScalar.TabIndex = 6;
			this.btn_ExectueScalar.Text = "ExecuteScalar";
			this.btn_ExectueScalar.UseVisualStyleBackColor = true;
			this.btn_ExectueScalar.Click += new System.EventHandler(this.btn_ExectueScalar_Click);
			// 
			// btn_GetProducts
			// 
			this.btn_GetProducts.Location = new System.Drawing.Point(30, 179);
			this.btn_GetProducts.Name = "btn_GetProducts";
			this.btn_GetProducts.Size = new System.Drawing.Size(182, 26);
			this.btn_GetProducts.TabIndex = 7;
			this.btn_GetProducts.Text = "顯示多筆Products";
			this.btn_GetProducts.UseVisualStyleBackColor = true;
			this.btn_GetProducts.Click += new System.EventHandler(this.btn_GetProducts_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(221, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Name";
			// 
			// text_productName
			// 
			this.text_productName.Location = new System.Drawing.Point(264, 179);
			this.text_productName.Name = "text_productName";
			this.text_productName.Size = new System.Drawing.Size(182, 25);
			this.text_productName.TabIndex = 8;
			// 
			// btn_createnews
			// 
			this.btn_createnews.Location = new System.Drawing.Point(30, 217);
			this.btn_createnews.Name = "btn_createnews";
			this.btn_createnews.Size = new System.Drawing.Size(182, 26);
			this.btn_createnews.TabIndex = 7;
			this.btn_createnews.Text = "Create News";
			this.btn_createnews.UseVisualStyleBackColor = true;
			this.btn_createnews.Click += new System.EventHandler(this.btn_createnews_Click);
			// 
			// btn_editnews
			// 
			this.btn_editnews.Location = new System.Drawing.Point(30, 261);
			this.btn_editnews.Name = "btn_editnews";
			this.btn_editnews.Size = new System.Drawing.Size(84, 26);
			this.btn_editnews.TabIndex = 10;
			this.btn_editnews.Text = "編輯News";
			this.btn_editnews.UseVisualStyleBackColor = true;
			this.btn_editnews.Click += new System.EventHandler(this.btn_editnews_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 311);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "News Id:";
			// 
			// textNewsid
			// 
			this.textNewsid.Location = new System.Drawing.Point(112, 306);
			this.textNewsid.Name = "textNewsid";
			this.textNewsid.Size = new System.Drawing.Size(100, 25);
			this.textNewsid.TabIndex = 12;
			// 
			// btn_delelte
			// 
			this.btn_delelte.Location = new System.Drawing.Point(120, 261);
			this.btn_delelte.Name = "btn_delelte";
			this.btn_delelte.Size = new System.Drawing.Size(84, 26);
			this.btn_delelte.TabIndex = 13;
			this.btn_delelte.Text = "Delete";
			this.btn_delelte.UseVisualStyleBackColor = true;
			this.btn_delelte.Click += new System.EventHandler(this.btn_delelte_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_delelte);
			this.Controls.Add(this.textNewsid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_editnews);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.text_productName);
			this.Controls.Add(this.btn_createnews);
			this.Controls.Add(this.btn_GetProducts);
			this.Controls.Add(this.btn_ExectueScalar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.text_categoryid);
			this.Controls.Add(this.btn_Category);
			this.Controls.Add(this.checkBox_pooling);
			this.Controls.Add(this.btn_getconnection);
			this.Controls.Add(this.btn_getconnectionstring);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getconnectionstring;
        private System.Windows.Forms.Button btn_getconnection;
        private System.Windows.Forms.CheckBox checkBox_pooling;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.TextBox text_categoryid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ExectueScalar;
		private System.Windows.Forms.Button btn_GetProducts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox text_productName;
		private System.Windows.Forms.Button btn_createnews;
		private System.Windows.Forms.Button btn_editnews;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textNewsid;
		private System.Windows.Forms.Button btn_delelte;
	}
}

