namespace WinFormsBlazor
{
    partial class FormBlazorWeb
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            this.FormBlazorCountBTM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blazorWebView1
            // 
            this.blazorWebView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blazorWebView1.Location = new System.Drawing.Point(0, 62);
            this.blazorWebView1.Name = "blazorWebView1";
            this.blazorWebView1.Size = new System.Drawing.Size(799, 386);
            this.blazorWebView1.TabIndex = 20;
            // 
            // FormBlazorCountBTM
            // 
            this.FormBlazorCountBTM.Location = new System.Drawing.Point(3, 10);
            this.FormBlazorCountBTM.Name = "FormBlazorCountBTM";
            this.FormBlazorCountBTM.Size = new System.Drawing.Size(181, 44);
            this.FormBlazorCountBTM.TabIndex = 21;
            this.FormBlazorCountBTM.Text = "Form Blazor Count";
            this.FormBlazorCountBTM.UseVisualStyleBackColor = true;
            this.FormBlazorCountBTM.Click += new System.EventHandler(this.FormBlazorCountBTM_Click);
            // 
            // FormBlazorWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormBlazorCountBTM);
            this.Controls.Add(this.blazorWebView1);
            this.Name = "FormBlazorWeb";
            this.Text = "FormBlazorWeb";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
        private Button FormBlazorCountBTM;
    }
}