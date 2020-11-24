namespace IA_Navigation
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trvBranche = new System.Windows.Forms.TreeView();
            this.lblBranche = new System.Windows.Forms.Label();
            this.btnCasA = new System.Windows.Forms.Button();
            this.btnCasB = new System.Windows.Forms.Button();
            this.btnCasC = new System.Windows.Forms.Button();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.txtTemps = new System.Windows.Forms.TextBox();
            this.numPavage = new System.Windows.Forms.NumericUpDown();
            this.lblPavage = new System.Windows.Forms.Label();
            this.grbTypePavage = new System.Windows.Forms.GroupBox();
            this.radCarre = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.radHexaInverse = new System.Windows.Forms.RadioButton();
            this.radHexa = new System.Windows.Forms.RadioButton();
            this.txtSommeOuverts = new System.Windows.Forms.TextBox();
            this.lblSommeOuverts = new System.Windows.Forms.Label();
            this.lblSommeFermes = new System.Windows.Forms.Label();
            this.txtSommeFermes = new System.Windows.Forms.TextBox();
            this.lblNbNoeuds = new System.Windows.Forms.Label();
            this.txtNbNoeuds = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPavage)).BeginInit();
            this.grbTypePavage.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvBranche
            // 
            this.trvBranche.Location = new System.Drawing.Point(545, 93);
            this.trvBranche.Name = "trvBranche";
            this.trvBranche.Size = new System.Drawing.Size(243, 189);
            this.trvBranche.TabIndex = 0;
            // 
            // lblBranche
            // 
            this.lblBranche.AutoSize = true;
            this.lblBranche.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranche.Location = new System.Drawing.Point(605, 67);
            this.lblBranche.Name = "lblBranche";
            this.lblBranche.Size = new System.Drawing.Size(142, 21);
            this.lblBranche.TabIndex = 1;
            this.lblBranche.Text = "Arbre de recherche";
            // 
            // btnCasA
            // 
            this.btnCasA.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasA.Location = new System.Drawing.Point(58, 41);
            this.btnCasA.Name = "btnCasA";
            this.btnCasA.Size = new System.Drawing.Size(70, 36);
            this.btnCasA.TabIndex = 2;
            this.btnCasA.Text = "Cas A";
            this.btnCasA.UseVisualStyleBackColor = true;
            this.btnCasA.Click += new System.EventHandler(this.btn_ClickA);
            // 
            // btnCasB
            // 
            this.btnCasB.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasB.Location = new System.Drawing.Point(155, 41);
            this.btnCasB.Name = "btnCasB";
            this.btnCasB.Size = new System.Drawing.Size(70, 36);
            this.btnCasB.TabIndex = 3;
            this.btnCasB.Text = "Cas  B";
            this.btnCasB.UseVisualStyleBackColor = true;
            this.btnCasB.Click += new System.EventHandler(this.btn_ClickB);
            // 
            // btnCasC
            // 
            this.btnCasC.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasC.Location = new System.Drawing.Point(250, 41);
            this.btnCasC.Name = "btnCasC";
            this.btnCasC.Size = new System.Drawing.Size(70, 36);
            this.btnCasC.TabIndex = 4;
            this.btnCasC.Text = "Cas C";
            this.btnCasC.UseVisualStyleBackColor = true;
            this.btnCasC.Click += new System.EventHandler(this.btn_ClickC);
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(61, 93);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(300, 300);
            this.picBackground.TabIndex = 5;
            this.picBackground.TabStop = false;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Font = new System.Drawing.Font("Nobile", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.Location = new System.Drawing.Point(517, 405);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(0, 17);
            this.lblSolution.TabIndex = 6;
            // 
            // txtTemps
            // 
            this.txtTemps.Enabled = false;
            this.txtTemps.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemps.Location = new System.Drawing.Point(62, 403);
            this.txtTemps.Name = "txtTemps";
            this.txtTemps.Size = new System.Drawing.Size(298, 27);
            this.txtTemps.TabIndex = 7;
            this.txtTemps.Text = "Temps total :";
            // 
            // numPavage
            // 
            this.numPavage.Location = new System.Drawing.Point(130, 12);
            this.numPavage.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPavage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPavage.Name = "numPavage";
            this.numPavage.Size = new System.Drawing.Size(36, 20);
            this.numPavage.TabIndex = 8;
            this.numPavage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPavage
            // 
            this.lblPavage.AutoSize = true;
            this.lblPavage.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPavage.Location = new System.Drawing.Point(57, 9);
            this.lblPavage.Name = "lblPavage";
            this.lblPavage.Size = new System.Drawing.Size(67, 21);
            this.lblPavage.TabIndex = 9;
            this.lblPavage.Text = "Pavage :";
            // 
            // grbTypePavage
            // 
            this.grbTypePavage.Controls.Add(this.radCarre);
            this.grbTypePavage.Controls.Add(this.radTriangle);
            this.grbTypePavage.Controls.Add(this.radHexaInverse);
            this.grbTypePavage.Controls.Add(this.radHexa);
            this.grbTypePavage.Font = new System.Drawing.Font("Nobile", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTypePavage.Location = new System.Drawing.Point(378, 41);
            this.grbTypePavage.Name = "grbTypePavage";
            this.grbTypePavage.Size = new System.Drawing.Size(161, 138);
            this.grbTypePavage.TabIndex = 10;
            this.grbTypePavage.TabStop = false;
            this.grbTypePavage.Text = "Forme du pavage";
            // 
            // radCarre
            // 
            this.radCarre.AutoSize = true;
            this.radCarre.Location = new System.Drawing.Point(7, 108);
            this.radCarre.Name = "radCarre";
            this.radCarre.Size = new System.Drawing.Size(57, 21);
            this.radCarre.TabIndex = 3;
            this.radCarre.TabStop = true;
            this.radCarre.Text = "Carré";
            this.radCarre.UseVisualStyleBackColor = true;
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.Location = new System.Drawing.Point(7, 80);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(96, 21);
            this.radTriangle.TabIndex = 2;
            this.radTriangle.TabStop = true;
            this.radTriangle.Text = "Triangulaire";
            this.radTriangle.UseVisualStyleBackColor = true;
            // 
            // radHexaInverse
            // 
            this.radHexaInverse.AutoSize = true;
            this.radHexaInverse.Location = new System.Drawing.Point(7, 52);
            this.radHexaInverse.Name = "radHexaInverse";
            this.radHexaInverse.Size = new System.Drawing.Size(133, 21);
            this.radHexaInverse.TabIndex = 1;
            this.radHexaInverse.TabStop = true;
            this.radHexaInverse.Text = "Hexagonal inversé";
            this.radHexaInverse.UseVisualStyleBackColor = true;
            // 
            // radHexa
            // 
            this.radHexa.AutoSize = true;
            this.radHexa.Location = new System.Drawing.Point(7, 24);
            this.radHexa.Name = "radHexa";
            this.radHexa.Size = new System.Drawing.Size(87, 21);
            this.radHexa.TabIndex = 0;
            this.radHexa.TabStop = true;
            this.radHexa.Text = "Hexagonal";
            this.radHexa.UseVisualStyleBackColor = true;
            // 
            // txtSommeOuverts
            // 
            this.txtSommeOuverts.Enabled = false;
            this.txtSommeOuverts.Location = new System.Drawing.Point(741, 331);
            this.txtSommeOuverts.Name = "txtSommeOuverts";
            this.txtSommeOuverts.Size = new System.Drawing.Size(47, 20);
            this.txtSommeOuverts.TabIndex = 11;
            this.txtSommeOuverts.TextChanged += new System.EventHandler(this.txtSommeOuverts_TextChanged);
            // 
            // lblSommeOuverts
            // 
            this.lblSommeOuverts.AutoSize = true;
            this.lblSommeOuverts.Font = new System.Drawing.Font("Nobile", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSommeOuverts.Location = new System.Drawing.Point(467, 332);
            this.lblSommeOuverts.Name = "lblSommeOuverts";
            this.lblSommeOuverts.Size = new System.Drawing.Size(272, 17);
            this.lblSommeOuverts.TabIndex = 12;
            this.lblSommeOuverts.Text = "Nombre de noeuds dans la liste des ouverts :";
            // 
            // lblSommeFermes
            // 
            this.lblSommeFermes.AutoSize = true;
            this.lblSommeFermes.Font = new System.Drawing.Font("Nobile", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSommeFermes.Location = new System.Drawing.Point(467, 364);
            this.lblSommeFermes.Name = "lblSommeFermes";
            this.lblSommeFermes.Size = new System.Drawing.Size(270, 17);
            this.lblSommeFermes.TabIndex = 14;
            this.lblSommeFermes.Text = "Nombre de noeuds dans la liste des fermés :";
            // 
            // txtSommeFermes
            // 
            this.txtSommeFermes.Enabled = false;
            this.txtSommeFermes.Location = new System.Drawing.Point(741, 363);
            this.txtSommeFermes.Name = "txtSommeFermes";
            this.txtSommeFermes.Size = new System.Drawing.Size(47, 20);
            this.txtSommeFermes.TabIndex = 13;
            // 
            // lblNbNoeuds
            // 
            this.lblNbNoeuds.AutoSize = true;
            this.lblNbNoeuds.Font = new System.Drawing.Font("Nobile", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbNoeuds.Location = new System.Drawing.Point(467, 299);
            this.lblNbNoeuds.Name = "lblNbNoeuds";
            this.lblNbNoeuds.Size = new System.Drawing.Size(240, 17);
            this.lblNbNoeuds.TabIndex = 16;
            this.lblNbNoeuds.Text = "Nombre de noeuds du chemin solution :";
            // 
            // txtNbNoeuds
            // 
            this.txtNbNoeuds.Enabled = false;
            this.txtNbNoeuds.Location = new System.Drawing.Point(741, 298);
            this.txtNbNoeuds.Name = "txtNbNoeuds";
            this.txtNbNoeuds.Size = new System.Drawing.Size(47, 20);
            this.txtNbNoeuds.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNbNoeuds);
            this.Controls.Add(this.txtNbNoeuds);
            this.Controls.Add(this.lblSommeFermes);
            this.Controls.Add(this.txtSommeFermes);
            this.Controls.Add(this.lblSommeOuverts);
            this.Controls.Add(this.txtSommeOuverts);
            this.Controls.Add(this.grbTypePavage);
            this.Controls.Add(this.lblPavage);
            this.Controls.Add(this.numPavage);
            this.Controls.Add(this.txtTemps);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.btnCasC);
            this.Controls.Add(this.btnCasB);
            this.Controls.Add(this.btnCasA);
            this.Controls.Add(this.lblBranche);
            this.Controls.Add(this.trvBranche);
            this.Name = "MainForm";
            this.Text = "Navigation";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPavage)).EndInit();
            this.grbTypePavage.ResumeLayout(false);
            this.grbTypePavage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvBranche;
        private System.Windows.Forms.Label lblBranche;
        private System.Windows.Forms.Button btnCasA;
        private System.Windows.Forms.Button btnCasB;
        private System.Windows.Forms.Button btnCasC;
        public System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.TextBox txtTemps;
        private System.Windows.Forms.NumericUpDown numPavage;
        private System.Windows.Forms.Label lblPavage;
        private System.Windows.Forms.GroupBox grbTypePavage;
        private System.Windows.Forms.RadioButton radCarre;
        private System.Windows.Forms.RadioButton radTriangle;
        private System.Windows.Forms.RadioButton radHexaInverse;
        private System.Windows.Forms.RadioButton radHexa;
        private System.Windows.Forms.Label lblSommeOuverts;
        private System.Windows.Forms.Label lblSommeFermes;
        private System.Windows.Forms.Label lblNbNoeuds;
        public System.Windows.Forms.TextBox txtSommeOuverts;
        public System.Windows.Forms.TextBox txtSommeFermes;
        public System.Windows.Forms.TextBox txtNbNoeuds;
    }
}

