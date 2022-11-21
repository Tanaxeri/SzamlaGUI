namespace SzamlaGUI
{
    partial class SzamlaGUI
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
            this.Szamlak = new System.Windows.Forms.ListBox();
            this.SzamlakNyilvanTart = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.TulNevText = new System.Windows.Forms.TextBox();
            this.EgyenText = new System.Windows.Forms.TextBox();
            this.NyitDatPick = new System.Windows.Forms.DateTimePicker();
            this.HozzaadButton = new System.Windows.Forms.Button();
            this.TorolButton = new System.Windows.Forms.Button();
            this.FrissitButton = new System.Windows.Forms.Button();
            this.KivalasztButton = new System.Windows.Forms.Button();
            this.KilepesButton = new System.Windows.Forms.Button();
            this.SzamlakNyilvanTart.SuspendLayout();
            this.SuspendLayout();
            // 
            // Szamlak
            // 
            this.Szamlak.Dock = System.Windows.Forms.DockStyle.Left;
            this.Szamlak.FormattingEnabled = true;
            this.Szamlak.Location = new System.Drawing.Point(0, 0);
            this.Szamlak.Name = "Szamlak";
            this.Szamlak.Size = new System.Drawing.Size(237, 450);
            this.Szamlak.TabIndex = 0;
            // 
            // SzamlakNyilvanTart
            // 
            this.SzamlakNyilvanTart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SzamlakNyilvanTart.Controls.Add(this.KilepesButton);
            this.SzamlakNyilvanTart.Controls.Add(this.KivalasztButton);
            this.SzamlakNyilvanTart.Controls.Add(this.FrissitButton);
            this.SzamlakNyilvanTart.Controls.Add(this.TorolButton);
            this.SzamlakNyilvanTart.Controls.Add(this.HozzaadButton);
            this.SzamlakNyilvanTart.Controls.Add(this.NyitDatPick);
            this.SzamlakNyilvanTart.Controls.Add(this.EgyenText);
            this.SzamlakNyilvanTart.Controls.Add(this.TulNevText);
            this.SzamlakNyilvanTart.Controls.Add(this.IDText);
            this.SzamlakNyilvanTart.Controls.Add(this.label4);
            this.SzamlakNyilvanTart.Controls.Add(this.label3);
            this.SzamlakNyilvanTart.Controls.Add(this.label2);
            this.SzamlakNyilvanTart.Controls.Add(this.label1);
            this.SzamlakNyilvanTart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SzamlakNyilvanTart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzamlakNyilvanTart.Location = new System.Drawing.Point(237, 0);
            this.SzamlakNyilvanTart.Name = "SzamlakNyilvanTart";
            this.SzamlakNyilvanTart.Size = new System.Drawing.Size(563, 450);
            this.SzamlakNyilvanTart.TabIndex = 1;
            this.SzamlakNyilvanTart.TabStop = false;
            this.SzamlakNyilvanTart.Text = "Szamlak Nyilvantartasa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tulajdonos neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egyenleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nyitás dátuma:";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(44, 36);
            this.IDText.Name = "IDText";
            this.IDText.ReadOnly = true;
            this.IDText.Size = new System.Drawing.Size(100, 26);
            this.IDText.TabIndex = 4;
            // 
            // TulNevText
            // 
            this.TulNevText.Location = new System.Drawing.Point(134, 79);
            this.TulNevText.Name = "TulNevText";
            this.TulNevText.Size = new System.Drawing.Size(100, 26);
            this.TulNevText.TabIndex = 5;
            // 
            // EgyenText
            // 
            this.EgyenText.Location = new System.Drawing.Point(88, 119);
            this.EgyenText.Name = "EgyenText";
            this.EgyenText.Size = new System.Drawing.Size(96, 26);
            this.EgyenText.TabIndex = 6;
            this.EgyenText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EgyenText_KeyPress);
            // 
            // NyitDatPick
            // 
            this.NyitDatPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NyitDatPick.Location = new System.Drawing.Point(123, 160);
            this.NyitDatPick.MaxDate = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            this.NyitDatPick.Name = "NyitDatPick";
            this.NyitDatPick.Size = new System.Drawing.Size(124, 26);
            this.NyitDatPick.TabIndex = 7;
            this.NyitDatPick.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // HozzaadButton
            // 
            this.HozzaadButton.Location = new System.Drawing.Point(31, 225);
            this.HozzaadButton.Name = "HozzaadButton";
            this.HozzaadButton.Size = new System.Drawing.Size(97, 27);
            this.HozzaadButton.TabIndex = 8;
            this.HozzaadButton.Text = "Hozzáadás";
            this.HozzaadButton.UseVisualStyleBackColor = true;
            this.HozzaadButton.Click += new System.EventHandler(this.HozzaadButton_Click);
            // 
            // TorolButton
            // 
            this.TorolButton.Location = new System.Drawing.Point(181, 225);
            this.TorolButton.Name = "TorolButton";
            this.TorolButton.Size = new System.Drawing.Size(102, 27);
            this.TorolButton.TabIndex = 9;
            this.TorolButton.Text = "Törlés";
            this.TorolButton.UseVisualStyleBackColor = true;
            this.TorolButton.Click += new System.EventHandler(this.TorolButton_Click);
            // 
            // FrissitButton
            // 
            this.FrissitButton.Location = new System.Drawing.Point(31, 290);
            this.FrissitButton.Name = "FrissitButton";
            this.FrissitButton.Size = new System.Drawing.Size(97, 25);
            this.FrissitButton.TabIndex = 10;
            this.FrissitButton.Text = "Frissítés";
            this.FrissitButton.UseVisualStyleBackColor = true;
            this.FrissitButton.Click += new System.EventHandler(this.FrissitButton_Click);
            // 
            // KivalasztButton
            // 
            this.KivalasztButton.Location = new System.Drawing.Point(181, 290);
            this.KivalasztButton.Name = "KivalasztButton";
            this.KivalasztButton.Size = new System.Drawing.Size(102, 25);
            this.KivalasztButton.TabIndex = 11;
            this.KivalasztButton.Text = "Kiválasztás";
            this.KivalasztButton.UseVisualStyleBackColor = true;
            this.KivalasztButton.Click += new System.EventHandler(this.KivalasztButton_Click);
            // 
            // KilepesButton
            // 
            this.KilepesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KilepesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KilepesButton.Location = new System.Drawing.Point(3, 352);
            this.KilepesButton.Name = "KilepesButton";
            this.KilepesButton.Size = new System.Drawing.Size(557, 95);
            this.KilepesButton.TabIndex = 12;
            this.KilepesButton.Text = "Kilépés";
            this.KilepesButton.UseVisualStyleBackColor = true;
            this.KilepesButton.Click += new System.EventHandler(this.KilepesButton_Click);
            // 
            // SzamlaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SzamlakNyilvanTart);
            this.Controls.Add(this.Szamlak);
            this.Name = "SzamlaGUI";
            this.Text = "SzamlaGUI";
            this.Load += new System.EventHandler(this.SzamlaGUI_Load);
            this.SzamlakNyilvanTart.ResumeLayout(false);
            this.SzamlakNyilvanTart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Szamlak;
        private System.Windows.Forms.GroupBox SzamlakNyilvanTart;
        private System.Windows.Forms.DateTimePicker NyitDatPick;
        private System.Windows.Forms.TextBox EgyenText;
        private System.Windows.Forms.TextBox TulNevText;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KivalasztButton;
        private System.Windows.Forms.Button FrissitButton;
        private System.Windows.Forms.Button TorolButton;
        private System.Windows.Forms.Button HozzaadButton;
        private System.Windows.Forms.Button KilepesButton;
    }
}

