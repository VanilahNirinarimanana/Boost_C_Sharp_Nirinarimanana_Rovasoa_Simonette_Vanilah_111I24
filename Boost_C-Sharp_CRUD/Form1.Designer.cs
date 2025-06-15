namespace Boost_C_Sharp_CRUD
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtEmail = new TextBox();
            txtTelephone = new TextBox();
            btnAjouter = new Button();
            btnEffacer = new Button();
            btnSupprimer = new Button();
            btnModifier = new Button();
            dgvPersonne = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersonne).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 70);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 117);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 161);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Prénom(s)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 204);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 244);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Téléphone";
            // 
            // txtId
            // 
            txtId.Location = new Point(164, 75);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(164, 117);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 6;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(164, 158);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 23);
            txtPrenom.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(164, 236);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(100, 23);
            txtTelephone.TabIndex = 9;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(63, 312);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 10;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(189, 312);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(75, 23);
            btnEffacer.TabIndex = 11;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(189, 390);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 12;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(63, 390);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 13;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // dgvPersonne
            // 
            dgvPersonne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonne.Location = new Point(380, 73);
            dgvPersonne.Name = "dgvPersonne";
            dgvPersonne.Size = new Size(706, 340);
            dgvPersonne.TabIndex = 14;
            dgvPersonne.CellClick += dgvPersonne_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 524);
            Controls.Add(dgvPersonne);
            Controls.Add(btnModifier);
            Controls.Add(btnSupprimer);
            Controls.Add(btnEffacer);
            Controls.Add(btnAjouter);
            Controls.Add(txtTelephone);
            Controls.Add(txtEmail);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Personne";
            ((System.ComponentModel.ISupportInitialize)dgvPersonne).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtEmail;
        private TextBox txtTelephone;
        private Button btnAjouter;
        private Button btnEffacer;
        private Button btnSupprimer;
        private Button btnModifier;
        private DataGridView dgvPersonne;
    }
}
