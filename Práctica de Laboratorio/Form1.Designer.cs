namespace Práctica_de_Laboratorio
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
            components = new System.ComponentModel.Container();
            lblJugador = new Label();
            lblVidaJugador = new Label();
            lblVidaEnemigo = new Label();
            cmbPersonaje = new ComboBox();
            btnCrear = new Button();
            btnAtacar = new Button();
            btnEspecial = new Button();
            pbVidaJugador = new ProgressBar();
            txtLog = new TextBox();
            pbVidaEnemigo = new ProgressBar();
            btnCurar = new Button();
            pbJugador = new PictureBox();
            pbEnemigo = new PictureBox();
            label1 = new Label();
            txtBoxVida = new TextBox();
            txtBoxVidaEnemigo = new TextBox();
            btnDefender = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            cmbEnemigo = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemigo).BeginInit();
            SuspendLayout();
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Determination Mono Web", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugador.ForeColor = SystemColors.ButtonFace;
            lblJugador.Location = new Point(435, 408);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(111, 29);
            lblJugador.TabIndex = 0;
            lblJugador.Text = "Jugador";
            // 
            // lblVidaJugador
            // 
            lblVidaJugador.AutoSize = true;
            lblVidaJugador.Font = new Font("Determination Mono Web", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVidaJugador.ForeColor = SystemColors.Control;
            lblVidaJugador.Location = new Point(603, 832);
            lblVidaJugador.Name = "lblVidaJugador";
            lblVidaJugador.Size = new Size(237, 29);
            lblVidaJugador.TabIndex = 1;
            lblVidaJugador.Text = "Vida del Jugador";
            // 
            // lblVidaEnemigo
            // 
            lblVidaEnemigo.AutoSize = true;
            lblVidaEnemigo.Font = new Font("Determination Mono Web", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVidaEnemigo.ForeColor = SystemColors.ButtonFace;
            lblVidaEnemigo.Location = new Point(1335, 46);
            lblVidaEnemigo.Name = "lblVidaEnemigo";
            lblVidaEnemigo.Size = new Size(169, 20);
            lblVidaEnemigo.TabIndex = 2;
            lblVidaEnemigo.Text = "Vida del Enemigo";
            // 
            // cmbPersonaje
            // 
            cmbPersonaje.BackColor = SystemColors.InfoText;
            cmbPersonaje.Font = new Font("Determination Mono Web", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPersonaje.ForeColor = SystemColors.Menu;
            cmbPersonaje.FormattingEnabled = true;
            cmbPersonaje.Items.AddRange(new object[] { "Guerrero", "Mago", "Arquero" });
            cmbPersonaje.Location = new Point(22, 12);
            cmbPersonaje.Name = "cmbPersonaje";
            cmbPersonaje.Size = new Size(151, 32);
            cmbPersonaje.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaptionText;
            btnCrear.Font = new Font("Determination Mono Web", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.ForeColor = SystemColors.ButtonFace;
            btnCrear.Location = new Point(1690, 12);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(149, 68);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAtacar
            // 
            btnAtacar.BackColor = SystemColors.ActiveCaptionText;
            btnAtacar.Font = new Font("Determination Mono Web", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtacar.ForeColor = SystemColors.ButtonFace;
            btnAtacar.Location = new Point(305, 884);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(254, 99);
            btnAtacar.TabIndex = 5;
            btnAtacar.Text = "Atacar";
            btnAtacar.UseVisualStyleBackColor = false;
            btnAtacar.Click += btnAtacar_Click;
            // 
            // btnEspecial
            // 
            btnEspecial.BackColor = SystemColors.ActiveCaptionText;
            btnEspecial.Font = new Font("Determination Mono Web", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEspecial.ForeColor = SystemColors.ButtonFace;
            btnEspecial.Location = new Point(652, 884);
            btnEspecial.Name = "btnEspecial";
            btnEspecial.Size = new Size(265, 99);
            btnEspecial.TabIndex = 6;
            btnEspecial.Text = "Especial";
            btnEspecial.UseVisualStyleBackColor = false;
            btnEspecial.Click += btnEspecial_Click;
            // 
            // pbVidaJugador
            // 
            pbVidaJugador.Location = new Point(846, 821);
            pbVidaJugador.Maximum = 150;
            pbVidaJugador.Name = "pbVidaJugador";
            pbVidaJugador.Size = new Size(293, 47);
            pbVidaJugador.TabIndex = 7;
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.InactiveCaptionText;
            txtLog.Font = new Font("Determination Mono Web", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLog.ForeColor = SystemColors.InactiveBorder;
            txtLog.Location = new Point(322, 503);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(1297, 301);
            txtLog.TabIndex = 8;
            // 
            // pbVidaEnemigo
            // 
            pbVidaEnemigo.Location = new Point(1254, 80);
            pbVidaEnemigo.Maximum = 150;
            pbVidaEnemigo.Name = "pbVidaEnemigo";
            pbVidaEnemigo.Size = new Size(305, 29);
            pbVidaEnemigo.TabIndex = 9;
            // 
            // btnCurar
            // 
            btnCurar.AutoSize = true;
            btnCurar.BackColor = SystemColors.ActiveCaptionText;
            btnCurar.Font = new Font("Determination Mono Web", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCurar.ForeColor = SystemColors.ButtonFace;
            btnCurar.Location = new Point(1025, 884);
            btnCurar.Name = "btnCurar";
            btnCurar.Size = new Size(253, 99);
            btnCurar.TabIndex = 10;
            btnCurar.Text = "Curar";
            btnCurar.UseVisualStyleBackColor = false;
            btnCurar.Click += btnCurar_Click;
            // 
            // pbJugador
            // 
            pbJugador.BackColor = SystemColors.ActiveCaptionText;
            pbJugador.Location = new Point(349, 133);
            pbJugador.Name = "pbJugador";
            pbJugador.Size = new Size(280, 261);
            pbJugador.SizeMode = PictureBoxSizeMode.Zoom;
            pbJugador.TabIndex = 11;
            pbJugador.TabStop = false;
            // 
            // pbEnemigo
            // 
            pbEnemigo.BackColor = SystemColors.ActiveCaptionText;
            pbEnemigo.Location = new Point(1258, 133);
            pbEnemigo.Name = "pbEnemigo";
            pbEnemigo.Size = new Size(301, 279);
            pbEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnemigo.TabIndex = 12;
            pbEnemigo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1367, 429);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 13;
            label1.Text = "Enemigo";
            // 
            // txtBoxVida
            // 
            txtBoxVida.Font = new Font("Determination Mono Web", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxVida.Location = new Point(1145, 834);
            txtBoxVida.Name = "txtBoxVida";
            txtBoxVida.Size = new Size(69, 26);
            txtBoxVida.TabIndex = 14;
            // 
            // txtBoxVidaEnemigo
            // 
            txtBoxVidaEnemigo.BackColor = SystemColors.InactiveCaptionText;
            txtBoxVidaEnemigo.ForeColor = SystemColors.Info;
            txtBoxVidaEnemigo.Location = new Point(1195, 80);
            txtBoxVidaEnemigo.Name = "txtBoxVidaEnemigo";
            txtBoxVidaEnemigo.Size = new Size(53, 27);
            txtBoxVidaEnemigo.TabIndex = 15;
            // 
            // btnDefender
            // 
            btnDefender.AutoSize = true;
            btnDefender.BackColor = SystemColors.ActiveCaptionText;
            btnDefender.Font = new Font("Determination Mono Web", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDefender.ForeColor = SystemColors.ButtonFace;
            btnDefender.Location = new Point(1378, 884);
            btnDefender.Name = "btnDefender";
            btnDefender.Size = new Size(253, 99);
            btnDefender.TabIndex = 16;
            btnDefender.Text = "Defender";
            btnDefender.UseVisualStyleBackColor = false;
            btnDefender.Click += btnDefender_Click;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Determination Mono Web", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(22, 60);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 17;
            label2.Text = "Selección de Personaje";
            // 
            // cmbEnemigo
            // 
            cmbEnemigo.BackColor = SystemColors.InfoText;
            cmbEnemigo.Font = new Font("Determination Mono Web", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEnemigo.ForeColor = SystemColors.Menu;
            cmbEnemigo.FormattingEnabled = true;
            cmbEnemigo.Items.AddRange(new object[] { "Jefe", "Enemigo" });
            cmbEnemigo.Location = new Point(22, 199);
            cmbEnemigo.Name = "cmbEnemigo";
            cmbEnemigo.Size = new Size(151, 32);
            cmbEnemigo.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Determination Mono Web", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(22, 244);
            label3.Name = "label3";
            label3.Size = new Size(209, 20);
            label3.TabIndex = 19;
            label3.Text = "Selección de Enemigo";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Determination Mono Web", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(12, 93);
            button1.Name = "button1";
            button1.Size = new Size(181, 90);
            button1.TabIndex = 20;
            button1.Text = "Agregar Imagen de Personaje";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Determination Mono Web", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(22, 279);
            button2.Name = "button2";
            button2.Size = new Size(181, 90);
            button2.TabIndex = 21;
            button2.Text = "Agregar Imagen de Enemigo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(cmbEnemigo);
            Controls.Add(label2);
            Controls.Add(btnDefender);
            Controls.Add(txtBoxVidaEnemigo);
            Controls.Add(txtBoxVida);
            Controls.Add(label1);
            Controls.Add(pbEnemigo);
            Controls.Add(pbJugador);
            Controls.Add(btnCurar);
            Controls.Add(pbVidaEnemigo);
            Controls.Add(txtLog);
            Controls.Add(pbVidaJugador);
            Controls.Add(btnEspecial);
            Controls.Add(btnAtacar);
            Controls.Add(btnCrear);
            Controls.Add(cmbPersonaje);
            Controls.Add(lblVidaEnemigo);
            Controls.Add(lblVidaJugador);
            Controls.Add(lblJugador);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnemigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugador;
        private Label lblVidaJugador;
        private Label lblVidaEnemigo;
        private ComboBox cmbPersonaje;
        private Button btnCrear;
        private Button btnAtacar;
        private Button btnEspecial;
        private ProgressBar pbVidaJugador;
        private TextBox txtLog;
        private ProgressBar pbVidaEnemigo;
        private Button btnCurar;
        private PictureBox pbJugador;
        private PictureBox pbEnemigo;
        private Label label1;
        private TextBox txtBoxVida;
        private TextBox txtBoxVidaEnemigo;
        private Button btnDefender;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private ComboBox cmbEnemigo;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
