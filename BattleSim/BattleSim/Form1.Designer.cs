namespace BattleSim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_enemigo = new System.Windows.Forms.Label();
            this.lbl_vidaEnemigo = new System.Windows.Forms.Label();
            this.lbl_vidaPC = new System.Windows.Forms.Label();
            this.lbl_pc = new System.Windows.Forms.Label();
            this.pbx_enemigo = new System.Windows.Forms.PictureBox();
            this.pbx_pc = new System.Windows.Forms.PictureBox();
            this.btn_atacar = new System.Windows.Forms.Button();
            this.btn_subirVida = new System.Windows.Forms.Button();
            this.tmr_battletimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_infoAtaquePC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_enemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_enemigo
            // 
            this.lbl_enemigo.AutoSize = true;
            this.lbl_enemigo.Location = new System.Drawing.Point(12, 9);
            this.lbl_enemigo.Name = "lbl_enemigo";
            this.lbl_enemigo.Size = new System.Drawing.Size(48, 13);
            this.lbl_enemigo.TabIndex = 0;
            this.lbl_enemigo.Text = "Enemigo";
            // 
            // lbl_vidaEnemigo
            // 
            this.lbl_vidaEnemigo.AutoSize = true;
            this.lbl_vidaEnemigo.Location = new System.Drawing.Point(66, 9);
            this.lbl_vidaEnemigo.Name = "lbl_vidaEnemigo";
            this.lbl_vidaEnemigo.Size = new System.Drawing.Size(13, 13);
            this.lbl_vidaEnemigo.TabIndex = 1;
            this.lbl_vidaEnemigo.Text = "0";
            // 
            // lbl_vidaPC
            // 
            this.lbl_vidaPC.AutoSize = true;
            this.lbl_vidaPC.Location = new System.Drawing.Point(496, 155);
            this.lbl_vidaPC.Name = "lbl_vidaPC";
            this.lbl_vidaPC.Size = new System.Drawing.Size(13, 13);
            this.lbl_vidaPC.TabIndex = 2;
            this.lbl_vidaPC.Text = "0";
            // 
            // lbl_pc
            // 
            this.lbl_pc.AutoSize = true;
            this.lbl_pc.Location = new System.Drawing.Point(376, 155);
            this.lbl_pc.Name = "lbl_pc";
            this.lbl_pc.Size = new System.Drawing.Size(21, 13);
            this.lbl_pc.TabIndex = 3;
            this.lbl_pc.Text = "PC";
            // 
            // pbx_enemigo
            // 
            this.pbx_enemigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_enemigo.BackgroundImage")));
            this.pbx_enemigo.Location = new System.Drawing.Point(12, 25);
            this.pbx_enemigo.Name = "pbx_enemigo";
            this.pbx_enemigo.Size = new System.Drawing.Size(146, 146);
            this.pbx_enemigo.TabIndex = 4;
            this.pbx_enemigo.TabStop = false;
            // 
            // pbx_pc
            // 
            this.pbx_pc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbx_pc.BackgroundImage")));
            this.pbx_pc.Location = new System.Drawing.Point(363, 171);
            this.pbx_pc.Name = "pbx_pc";
            this.pbx_pc.Size = new System.Drawing.Size(146, 146);
            this.pbx_pc.TabIndex = 5;
            this.pbx_pc.TabStop = false;
            // 
            // btn_atacar
            // 
            this.btn_atacar.Location = new System.Drawing.Point(15, 260);
            this.btn_atacar.Name = "btn_atacar";
            this.btn_atacar.Size = new System.Drawing.Size(75, 23);
            this.btn_atacar.TabIndex = 6;
            this.btn_atacar.Text = "Atacar";
            this.btn_atacar.UseVisualStyleBackColor = true;
            this.btn_atacar.Click += new System.EventHandler(this.btn_atacar_Click);
            // 
            // btn_subirVida
            // 
            this.btn_subirVida.Location = new System.Drawing.Point(106, 260);
            this.btn_subirVida.Name = "btn_subirVida";
            this.btn_subirVida.Size = new System.Drawing.Size(75, 23);
            this.btn_subirVida.TabIndex = 7;
            this.btn_subirVida.Text = "Subir Vida";
            this.btn_subirVida.UseVisualStyleBackColor = true;
            this.btn_subirVida.Click += new System.EventHandler(this.btn_subirVida_Click);
            // 
            // tmr_battletimer
            // 
            this.tmr_battletimer.Interval = 1500;
            this.tmr_battletimer.Tick += new System.EventHandler(this.tmr_battletimer_Tick);
            // 
            // lbl_infoAtaquePC
            // 
            this.lbl_infoAtaquePC.AutoSize = true;
            this.lbl_infoAtaquePC.Location = new System.Drawing.Point(231, 25);
            this.lbl_infoAtaquePC.Name = "lbl_infoAtaquePC";
            this.lbl_infoAtaquePC.Size = new System.Drawing.Size(35, 13);
            this.lbl_infoAtaquePC.TabIndex = 9;
            this.lbl_infoAtaquePC.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 319);
            this.Controls.Add(this.lbl_infoAtaquePC);
            this.Controls.Add(this.btn_subirVida);
            this.Controls.Add(this.btn_atacar);
            this.Controls.Add(this.pbx_pc);
            this.Controls.Add(this.pbx_enemigo);
            this.Controls.Add(this.lbl_pc);
            this.Controls.Add(this.lbl_vidaPC);
            this.Controls.Add(this.lbl_vidaEnemigo);
            this.Controls.Add(this.lbl_enemigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_enemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_enemigo;
        private System.Windows.Forms.Label lbl_vidaEnemigo;
        private System.Windows.Forms.Label lbl_vidaPC;
        private System.Windows.Forms.Label lbl_pc;
        private System.Windows.Forms.PictureBox pbx_enemigo;
        private System.Windows.Forms.PictureBox pbx_pc;
        private System.Windows.Forms.Button btn_atacar;
        private System.Windows.Forms.Button btn_subirVida;
        private System.Windows.Forms.Timer tmr_battletimer;
        private System.Windows.Forms.Label lbl_infoAtaquePC;
    }
}

