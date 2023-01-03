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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

