namespace DataRelationExample
{
    partial class frmDataRelation
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgStoreList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgStoreSales = new System.Windows.Forms.DataGridView();
            this.dgTitleAuth = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStoreSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTitleAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Stores";
            // 
            // dgStoreList
            // 
            this.dgStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStoreList.Location = new System.Drawing.Point(7, 34);
            this.dgStoreList.Name = "dgStoreList";
            this.dgStoreList.Size = new System.Drawing.Size(565, 218);
            this.dgStoreList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(3, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sales by Stores";
            // 
            // dgStoreSales
            // 
            this.dgStoreSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStoreSales.Location = new System.Drawing.Point(7, 299);
            this.dgStoreSales.Name = "dgStoreSales";
            this.dgStoreSales.Size = new System.Drawing.Size(565, 150);
            this.dgStoreSales.TabIndex = 3;
            // 
            // dgTitleAuth
            // 
            this.dgTitleAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTitleAuth.Location = new System.Drawing.Point(7, 491);
            this.dgTitleAuth.Name = "dgTitleAuth";
            this.dgTitleAuth.Size = new System.Drawing.Size(565, 110);
            this.dgTitleAuth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contributing Author(s)";
            // 
            // cmdLoad
            // 
            this.cmdLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdLoad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.Location = new System.Drawing.Point(7, 607);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(75, 26);
            this.cmdLoad.TabIndex = 6;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = false;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(497, 607);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 26);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmDataRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(584, 637);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.dgTitleAuth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgStoreSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgStoreList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDataRelation";
            this.Text = "Data Relation Example";
            ((System.ComponentModel.ISupportInitialize)(this.dgStoreList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStoreSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTitleAuth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStoreList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgStoreSales;
        private System.Windows.Forms.DataGridView dgTitleAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdClose;
    }
}

