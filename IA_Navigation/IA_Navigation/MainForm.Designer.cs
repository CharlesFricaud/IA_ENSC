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
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPavage)).BeginInit();
            this.SuspendLayout();
            // 
            // trvBranche
            // 
            this.trvBranche.Location = new System.Drawing.Point(520, 93);
            this.trvBranche.Name = "trvBranche";
            this.trvBranche.Size = new System.Drawing.Size(243, 300);
            this.trvBranche.TabIndex = 0;
            // 
            // lblBranche
            // 
            this.lblBranche.AutoSize = true;
            this.lblBranche.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranche.Location = new System.Drawing.Point(580, 67);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

