namespace ReadingParameters
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
        private void InitializeComponent()
        {
            this.pgSqlConnection1 = new Devart.Data.PostgreSql.PgSqlConnection();
            this.SuspendLayout();
            // 
            // pgSqlConnection1
            // 
            this.pgSqlConnection1.CommitTimeout = 0;
            this.pgSqlConnection1.ConnectionString = "User Id=Reader;Password=read;Host=10.10.48.24;Database=fttm;";
            this.pgSqlConnection1.Name = "pgSqlConnection1";
            this.pgSqlConnection1.Owner = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Devart.Data.PostgreSql.PgSqlConnection pgSqlConnection1;
    }
}

