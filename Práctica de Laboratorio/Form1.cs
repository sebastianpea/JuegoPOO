using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Práctica_de_Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
        }
        Personaje jugador;
        Personaje enemigo;
        Random rnd = new Random();
        int contadorDeEspecial = 0;
        bool juegoTerminado = false;
        int turno = 0;
        private string mensajePendiente = "";
        private int indiceLetra = 0;
        private Queue<string> colaMensajes = new Queue<string>();
        public void ActualizarBarraJugador(ProgressBar pbVidaDeJugador, int valor)
        {
            pbVidaDeJugador.Maximum = jugador.Vida;
            pbVidaDeJugador.Minimum = 0;
            pbVidaDeJugador.Value = jugador.Vida;
        }
        public void ActualizarBarraEnemigo(ProgressBar pbVidaDeEnemigo, int valor)
        {
            pbVidaDeEnemigo.Maximum = enemigo.Vida;
            pbVidaDeEnemigo.Minimum = 0;
            pbVidaDeEnemigo.Value = enemigo.Vida;
        }
        private void Animacion(string mensaje)
        {
            colaMensajes.Enqueue(mensaje + Environment.NewLine);
            if (!timer1.Enabled)
                SiguienteMensaje();
        }
        private void SiguienteMensaje()
        {
            if (colaMensajes.Count > 0)
            {
                mensajePendiente = colaMensajes.Dequeue();
                indiceLetra = 0;
                timer1.Start();
            }
        }
        private bool VerificarFinDeJuego()
        {
            if (enemigo.Vida <= 0)
            {
                enemigo.Vida = 0;
                txtBoxVidaEnemigo.Text = "0";
                pbVidaEnemigo.Value = 0;
                pbEnemigo.Visible = false;
                juegoTerminado = true;
                MessageBox.Show("¡Ganaste!", "Victoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            if (jugador.Vida <= 0)
            {
                jugador.Vida = 0;
                pbVidaJugador.Value = 0;
                pbJugador.Visible = false;
                juegoTerminado = true;
                MessageBox.Show("¡Perdiste!", "Derrota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            juegoTerminado = false;
            pbJugador.Visible = true;
            pbEnemigo.Visible = true;
            switch (cmbPersonaje.Text)
            {
                case "Guerrero":
                    jugador = new Guerrero();
                    pbJugador.Image = Properties.Resources.Guerrero;
                    break;
                case "Mago":
                    jugador = new Mago();
                    pbJugador.Image = Properties.Resources.Mago;
                    break;
                case "Arquero":
                    jugador = new Arquero();
                    pbJugador.Image = Properties.Resources.Arquero;
                    break;
                default:
                    MessageBox.Show("Selecciona un personaje primero");
                    return;
            }
            switch (cmbEnemigo.Text)
            {
                case "Enemigo":
                    enemigo = new Personaje("Enemigo", 100, 12, 0, 0);
                    pbEnemigo.Image = Properties.Resources.Enemigo;
                    break;
                case "Jefe":
                    enemigo = new Jefe();
                    pbEnemigo.Image = Properties.Resources.Jefe;
                    break;
                default:
                    MessageBox.Show("Selecciona un enemigo primero");
                    return;
            }
            pbVidaJugador.Maximum = jugador.Vida;
            pbVidaJugador.Minimum = 0;
            pbVidaJugador.Value = jugador.Vida;
            pbVidaEnemigo.Maximum = enemigo.Vida;
            pbVidaEnemigo.Minimum = 0;
            pbVidaEnemigo.Value = enemigo.Vida;
            contadorDeEspecial = 0;
            turno = 0;
            colaMensajes.Clear();
            timer1.Stop();
            mensajePendiente = "";
            indiceLetra = 0;
            txtBoxVida.Text = jugador.Vida.ToString();
            txtBoxVidaEnemigo.Text = enemigo.Vida.ToString();
            txtLog.Clear();
            txtLog.AppendText($"Jugador creado: {jugador.Nombre} | Vida: {jugador.Vida} | Ataque: {jugador.Ataque}{Environment.NewLine}");
        }
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            turno++;
            txtLog.AppendText($"--- Turno {turno} ---{Environment.NewLine}");
            if (jugador == null || enemigo == null)
            {
                MessageBox.Show("Crea un personaje primero"); return;
            }
            if (juegoTerminado)
            {
                MessageBox.Show("El juego terminó. Crea un nuevo personaje para jugar de nuevo.");
                return;
            }
            int daño = jugador.Atacar();
            enemigo.Vida -= daño;
            Animacion($" Jugador atacó: {daño} de daño al enemigo");
            int contra = rnd.Next(5, 15);
            jugador.Vida -= contra;
            Animacion($" Enemigo contraatacó: {contra} de daño al jugador");
            jugador.Vida = Math.Max(0, jugador.Vida);
            enemigo.Vida = Math.Max(0, enemigo.Vida);
            txtBoxVida.Text = jugador.Vida.ToString();
            txtBoxVidaEnemigo.Text = enemigo.Vida.ToString();
            pbVidaJugador.Value = jugador.Vida;
            pbVidaEnemigo.Value = enemigo.Vida;
            VerificarFinDeJuego();
            if (contadorDeEspecial > 0)
            {
                contadorDeEspecial--;
            }
        }
        private void btnEspecial_Click(object sender, EventArgs e)
        {
            if (contadorDeEspecial > 0)
            {
                MessageBox.Show($"Especial listo en {contadorDeEspecial} turnos");
                return;
            }
            if (jugador == null || enemigo == null)
            {
                MessageBox.Show("Crea un personaje primero");
                return;
            }
            if (juegoTerminado)
            {
                MessageBox.Show("El juego terminó. Crea un nuevo personaje para jugar de nuevo.");
                return;
            }
            if (contadorDeEspecial > 0)
            {
                MessageBox.Show($"Especial listo en {contadorDeEspecial} turnos");
                return;
            }
            turno++;
            txtLog.AppendText($"--- Turno {turno} ---{Environment.NewLine}");
            int daño = jugador.Atacar();
            enemigo.Vida -= daño * 2;
            Animacion($" Jugador usó especial: {daño * 2} de daño al enemigo");
            int contra = rnd.Next(5, 15);
            jugador.Vida -= contra;
            Animacion($" Enemigo contraatacó: {contra} de daño al jugador");
            jugador.Vida = Math.Max(0, jugador.Vida);
            enemigo.Vida = Math.Max(0, enemigo.Vida);
            txtBoxVida.Text = jugador.Vida.ToString();
            txtBoxVidaEnemigo.Text = enemigo.Vida.ToString();
            pbVidaJugador.Value = jugador.Vida;
            pbVidaEnemigo.Value = enemigo.Vida;
            contadorDeEspecial = 3;
            VerificarFinDeJuego();
        }
        private void btnCurar_Click(object sender, EventArgs e)
        {
            turno++;
            txtLog.AppendText($"--- Turno {turno} ---{Environment.NewLine}");
            if (jugador == null || enemigo == null) { MessageBox.Show("Crea un personaje primero"); return; }
            if (juegoTerminado) { MessageBox.Show("El juego terminó. Crea un nuevo personaje para jugar de nuevo."); return; }
            int curar = jugador.Curar();
            jugador.Vida += curar;
            Animacion($" Jugador se curó: +{curar} de vida");
            int contra = rnd.Next(5, 15);
            jugador.Vida -= contra;
            Animacion($" Enemigo contraatacó: {contra} de daño al jugador");
            jugador.Vida = Math.Clamp(jugador.Vida, 0, pbVidaJugador.Maximum);
            txtBoxVida.Text = jugador.Vida.ToString();
            txtBoxVidaEnemigo.Text = enemigo.Vida.ToString();
            pbVidaJugador.Value = jugador.Vida;
            if (contadorDeEspecial > 0)
            {
                contadorDeEspecial--;
            }
            VerificarFinDeJuego();
        }
        private void btnDefender_Click(object sender, EventArgs e)
        {
            turno++;
            txtLog.AppendText($"--- Turno {turno} ---{Environment.NewLine}");
            if (jugador == null || enemigo == null) { MessageBox.Show("Crea un personaje primero"); return; }
            if (juegoTerminado) { MessageBox.Show("El juego terminó. Crea un nuevo personaje para jugar de nuevo."); return; }
            int contra = rnd.Next(5, 15);
            int contraDefendido = (int)(contra * jugador.Defensa);
            jugador.Vida -= contraDefendido;
            Animacion($" Jugador defendió: recibió solo {contraDefendido} de daño");
            jugador.Vida = jugador.Vida;
            txtBoxVida.Text = jugador.Vida.ToString();
            pbVidaJugador.Value = jugador.Vida;
            if (contadorDeEspecial > 0)
            {
                contadorDeEspecial--;
            }
            VerificarFinDeJuego();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (indiceLetra < mensajePendiente.Length)
            {
                txtLog.AppendText(mensajePendiente[indiceLetra].ToString());
                indiceLetra++;
            }
            else
            {
                timer1.Stop();
                indiceLetra = 0;
                mensajePendiente = "";
                SiguienteMensaje();
            }
        }
        private void button1_Click(object sender, EventArgs e)  // Botón foto del JUGADOR
        {
            if (jugador == null)
            {
                MessageBox.Show("Primero crea un personaje antes de cambiar su imagen.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                pbJugador.Image = Image.FromFile(dialogo.FileName);
                pbJugador.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void button2_Click(object sender, EventArgs e)  // Botón foto del ENEMIGO
        {
            if (enemigo == null)
            {
                MessageBox.Show("Primero crea un enemigo antes de cambiar su imagen.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbEnemigo.Image = Image.FromFile(dialog.FileName);
                pbEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}