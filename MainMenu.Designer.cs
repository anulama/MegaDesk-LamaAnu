namespace MegaDesk_LamaAnu
{
    partial class MainMenu
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
            this.addButtonQuote = new System.Windows.Forms.Button();
            this.displayQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButtonQuote
            // 
            this.addButtonQuote.Location = new System.Drawing.Point(43, 42);
            this.addButtonQuote.Name = "addButtonQuote";
            this.addButtonQuote.Size = new System.Drawing.Size(273, 75);
            this.addButtonQuote.TabIndex = 0;
            this.addButtonQuote.Text = "Add Quotes";
            this.addButtonQuote.UseVisualStyleBackColor = true;
            this.addButtonQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayQuotes
            // 
            this.displayQuotes.Location = new System.Drawing.Point(43, 140);
            this.displayQuotes.Name = "displayQuotes";
            this.displayQuotes.Size = new System.Drawing.Size(273, 75);
            this.displayQuotes.TabIndex = 1;
            this.displayQuotes.Text = "Display Quotes";
            this.displayQuotes.UseVisualStyleBackColor = true;
            this.displayQuotes.Click += new System.EventHandler(this.displayQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(43, 232);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(273, 75);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(43, 333);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(273, 75);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.displayQuotes);
            this.Controls.Add(this.addButtonQuote);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButtonQuote;
        private System.Windows.Forms.Button displayQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
    }
}

