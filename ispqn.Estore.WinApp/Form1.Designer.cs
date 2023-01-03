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
            this.SuspendLayout();
            // 
            // btn_getconnectionstring
            // 
            this.btn_getconnectionstring.Location = new System.Drawing.Point(65, 49);
            this.btn_getconnectionstring.Name = "btn_getconnectionstring";
            this.btn_getconnectionstring.Size = new System.Drawing.Size(159, 48);
            this.btn_getconnectionstring.TabIndex = 0;
            this.btn_getconnectionstring.Text = "GetConnectionString";
            this.btn_getconnectionstring.UseVisualStyleBackColor = true;
            this.btn_getconnectionstring.Click += new System.EventHandler(this.btn_getconnectionstring_Click);
            // 
            // btn_getconnection
            // 
            this.btn_getconnection.Location = new System.Drawing.Point(65, 122);
            this.btn_getconnection.Name = "btn_getconnection";
            this.btn_getconnection.Size = new System.Drawing.Size(159, 48);
            this.btn_getconnection.TabIndex = 1;
            this.btn_getconnection.Text = "GetConnection";
            this.btn_getconnection.UseVisualStyleBackColor = true;
            this.btn_getconnection.Click += new System.EventHandler(this.btn_getconnection_Click);
            // 
            // checkBox_pooling
            // 
            this.checkBox_pooling.AutoSize = true;
            this.checkBox_pooling.Location = new System.Drawing.Point(259, 138);
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
            this.btn_Category.Location = new System.Drawing.Point(65, 198);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(182, 44);
            this.btn_Category.TabIndex = 3;
            this.btn_Category.Text = "讀取一筆Category";
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // text_categoryid
            // 
            this.text_categoryid.Location = new System.Drawing.Point(315, 210);
            this.text_categoryid.Name = "text_categoryid";
            this.text_categoryid.Size = new System.Drawing.Size(174, 25);
            this.text_categoryid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

