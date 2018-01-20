namespace Puissance4Version2
{
    partial class ChargementTab
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
            this.t_JoueurRouge = new System.Windows.Forms.TextBox();
            this.t_JoueurJaune = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_charger = new System.Windows.Forms.Button();
            this.t_mouvement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // t_JoueurRouge
            // 
            this.t_JoueurRouge.Location = new System.Drawing.Point(524, 148);
            this.t_JoueurRouge.Name = "t_JoueurRouge";
            this.t_JoueurRouge.Size = new System.Drawing.Size(224, 22);
            this.t_JoueurRouge.TabIndex = 0;
            this.t_JoueurRouge.Text = "Joueur 1";
            // 
            // t_JoueurJaune
            // 
            this.t_JoueurJaune.Location = new System.Drawing.Point(524, 316);
            this.t_JoueurJaune.Name = "t_JoueurJaune";
            this.t_JoueurJaune.Size = new System.Drawing.Size(224, 22);
            this.t_JoueurJaune.TabIndex = 1;
            this.t_JoueurJaune.Text = "Joueur 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joueur Rouge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Joueur Jaune";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(524, 418);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(96, 35);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Sauver";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_charger
            // 
            this.btn_charger.Location = new System.Drawing.Point(654, 418);
            this.btn_charger.Name = "btn_charger";
            this.btn_charger.Size = new System.Drawing.Size(96, 35);
            this.btn_charger.TabIndex = 5;
            this.btn_charger.Text = "Charger";
            this.btn_charger.UseVisualStyleBackColor = true;
            this.btn_charger.Click += new System.EventHandler(this.btn_charger_Click);
            // 
            // t_mouvement
            // 
            this.t_mouvement.Location = new System.Drawing.Point(24, 418);
            this.t_mouvement.Multiline = true;
            this.t_mouvement.Name = "t_mouvement";
            this.t_mouvement.ReadOnly = true;
            this.t_mouvement.Size = new System.Drawing.Size(431, 35);
            this.t_mouvement.TabIndex = 6;
            // 
            // ChargementTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 476);
            this.Controls.Add(this.t_mouvement);
            this.Controls.Add(this.btn_charger);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_JoueurJaune);
            this.Controls.Add(this.t_JoueurRouge);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChargementTab";
            this.Text = "Puissance 4";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChargementTab_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_JoueurRouge;
        private System.Windows.Forms.TextBox t_JoueurJaune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_charger;
        private System.Windows.Forms.TextBox t_mouvement;
    }
}

