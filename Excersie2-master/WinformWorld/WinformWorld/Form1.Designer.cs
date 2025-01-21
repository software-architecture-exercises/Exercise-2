namespace WinformWorld
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetAllCountries;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.Button btnGetCountryByCode;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnGetCityByName;
        private System.Windows.Forms.TextBox txtCountryCodeForCities;
        private System.Windows.Forms.Button btnGetCitiesByCountry;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetAllCountries = new System.Windows.Forms.Button();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.btnGetCountryByCode = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnGetCityByName = new System.Windows.Forms.Button();
            this.txtCountryCodeForCities = new System.Windows.Forms.TextBox();
            this.btnGetCitiesByCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetAllCountries
            // 
            this.btnGetAllCountries.Location = new System.Drawing.Point(12, 428);
            this.btnGetAllCountries.Name = "btnGetAllCountries";
            this.btnGetAllCountries.Size = new System.Drawing.Size(200, 50);
            this.btnGetAllCountries.TabIndex = 1;
            this.btnGetAllCountries.Text = "Get All Countries";
            this.btnGetAllCountries.UseVisualStyleBackColor = true;
            this.btnGetAllCountries.Click += new System.EventHandler(this.btnGetAllCountries_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(12, 500);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(200, 31);
            this.txtCountryCode.TabIndex = 2;
            // 
            // btnGetCountryByCode
            // 
            this.btnGetCountryByCode.Location = new System.Drawing.Point(230, 490);
            this.btnGetCountryByCode.Name = "btnGetCountryByCode";
            this.btnGetCountryByCode.Size = new System.Drawing.Size(200, 50);
            this.btnGetCountryByCode.TabIndex = 3;
            this.btnGetCountryByCode.Text = "Get Country by Code";
            this.btnGetCountryByCode.UseVisualStyleBackColor = true;
            this.btnGetCountryByCode.Click += new System.EventHandler(this.btnGetCountryByCode_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(12, 570);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(200, 31);
            this.txtCityName.TabIndex = 4;
            // 
            // btnGetCityByName
            // 
            this.btnGetCityByName.Location = new System.Drawing.Point(230, 560);
            this.btnGetCityByName.Name = "btnGetCityByName";
            this.btnGetCityByName.Size = new System.Drawing.Size(200, 50);
            this.btnGetCityByName.TabIndex = 5;
            this.btnGetCityByName.Text = "Get City by Name";
            this.btnGetCityByName.UseVisualStyleBackColor = true;
            this.btnGetCityByName.Click += new System.EventHandler(this.btnGetCityByName_Click);
            // 
            // txtCountryCodeForCities
            // 
            this.txtCountryCodeForCities.Location = new System.Drawing.Point(12, 640);
            this.txtCountryCodeForCities.Name = "txtCountryCodeForCities";
            this.txtCountryCodeForCities.Size = new System.Drawing.Size(200, 31);
            this.txtCountryCodeForCities.TabIndex = 6;
            // 
            // btnGetCitiesByCountry
            // 
            this.btnGetCitiesByCountry.Location = new System.Drawing.Point(230, 630);
            this.btnGetCitiesByCountry.Name = "btnGetCitiesByCountry";
            this.btnGetCitiesByCountry.Size = new System.Drawing.Size(200, 50);
            this.btnGetCitiesByCountry.TabIndex = 7;
            this.btnGetCitiesByCountry.Text = "Get Cities by Country";
            this.btnGetCitiesByCountry.UseVisualStyleBackColor = true;
            this.btnGetCitiesByCountry.Click += new System.EventHandler(this.btnGetCitiesByCountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 801);
            this.Controls.Add(this.btnGetCitiesByCountry);
            this.Controls.Add(this.txtCountryCodeForCities);
            this.Controls.Add(this.btnGetCityByName);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.btnGetCountryByCode);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.btnGetAllCountries);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "World Database Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}

