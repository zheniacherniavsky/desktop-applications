
namespace lab2
{
    partial class SearchForm
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
            this.searchOutputBox = new System.Windows.Forms.TextBox();
            this.SearchLabelProductName = new System.Windows.Forms.Label();
            this.productNameSearch = new System.Windows.Forms.TextBox();
            this.SearchLabelMaterial = new System.Windows.Forms.Label();
            this.materialSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchOutputBox
            // 
            this.searchOutputBox.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchOutputBox.Location = new System.Drawing.Point(12, 69);
            this.searchOutputBox.Multiline = true;
            this.searchOutputBox.Name = "searchOutputBox";
            this.searchOutputBox.ReadOnly = true;
            this.searchOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchOutputBox.Size = new System.Drawing.Size(461, 373);
            this.searchOutputBox.TabIndex = 36;
            // 
            // SearchLabelProductName
            // 
            this.SearchLabelProductName.AutoSize = true;
            this.SearchLabelProductName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.SearchLabelProductName.Location = new System.Drawing.Point(164, 16);
            this.SearchLabelProductName.Name = "SearchLabelProductName";
            this.SearchLabelProductName.Size = new System.Drawing.Size(93, 13);
            this.SearchLabelProductName.TabIndex = 38;
            this.SearchLabelProductName.Text = "Название товара";
            // 
            // productNameSearch
            // 
            this.productNameSearch.Location = new System.Drawing.Point(12, 12);
            this.productNameSearch.MaxLength = 256;
            this.productNameSearch.Name = "productNameSearch";
            this.productNameSearch.Size = new System.Drawing.Size(146, 20);
            this.productNameSearch.TabIndex = 37;
            // 
            // SearchLabelMaterial
            // 
            this.SearchLabelMaterial.AutoSize = true;
            this.SearchLabelMaterial.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.SearchLabelMaterial.Location = new System.Drawing.Point(164, 43);
            this.SearchLabelMaterial.Name = "SearchLabelMaterial";
            this.SearchLabelMaterial.Size = new System.Drawing.Size(58, 13);
            this.SearchLabelMaterial.TabIndex = 40;
            this.SearchLabelMaterial.Text = "Материал";
            // 
            // materialSearch
            // 
            this.materialSearch.Location = new System.Drawing.Point(12, 39);
            this.materialSearch.MaxLength = 256;
            this.materialSearch.Name = "materialSearch";
            this.materialSearch.Size = new System.Drawing.Size(146, 20);
            this.materialSearch.TabIndex = 39;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(309, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(164, 36);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchLabelMaterial);
            this.Controls.Add(this.materialSearch);
            this.Controls.Add(this.SearchLabelProductName);
            this.Controls.Add(this.productNameSearch);
            this.Controls.Add(this.searchOutputBox);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchOutputBox;
        private System.Windows.Forms.Label SearchLabelProductName;
        private System.Windows.Forms.TextBox productNameSearch;
        private System.Windows.Forms.Label SearchLabelMaterial;
        private System.Windows.Forms.TextBox materialSearch;
        private System.Windows.Forms.Button searchButton;
    }
}