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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_getconnectionstring);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_getconnectionstring;
    }
}

