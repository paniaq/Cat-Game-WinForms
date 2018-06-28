namespace CatGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblpuntaje = new System.Windows.Forms.Label();
            this.lblintentos = new System.Windows.Forms.Label();
            this.tiempojuego = new System.Windows.Forms.Timer(this.components);
            this.lblnombre = new System.Windows.Forms.Label();
            this.Perro = new System.Windows.Forms.PictureBox();
            this.Cat = new System.Windows.Forms.PictureBox();
            this.Supermercado = new System.Windows.Forms.PictureBox();
            this.Hombre = new System.Windows.Forms.PictureBox();
            this.Casa1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supermercado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Casa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // comenzarToolStripMenuItem
            // 
            this.comenzarToolStripMenuItem.Name = "comenzarToolStripMenuItem";
            this.comenzarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.comenzarToolStripMenuItem.Text = "Comenzar";
            this.comenzarToolStripMenuItem.Click += new System.EventHandler(this.comenzarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblpuntaje
            // 
            this.lblpuntaje.AutoSize = true;
            this.lblpuntaje.BackColor = System.Drawing.Color.White;
            this.lblpuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntaje.Location = new System.Drawing.Point(375, 622);
            this.lblpuntaje.Name = "lblpuntaje";
            this.lblpuntaje.Size = new System.Drawing.Size(76, 20);
            this.lblpuntaje.TabIndex = 8;
            this.lblpuntaje.Text = "Puntaje 0";
            // 
            // lblintentos
            // 
            this.lblintentos.AutoSize = true;
            this.lblintentos.BackColor = System.Drawing.Color.White;
            this.lblintentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintentos.Location = new System.Drawing.Point(12, 622);
            this.lblintentos.Name = "lblintentos";
            this.lblintentos.Size = new System.Drawing.Size(81, 20);
            this.lblintentos.TabIndex = 9;
            this.lblintentos.Text = "Intentos 9";
            // 
            // tiempojuego
            // 
            this.tiempojuego.Interval = 80;
            this.tiempojuego.Tick += new System.EventHandler(this.tiempojuego_Tick);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Gray;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Red;
            this.lblnombre.Location = new System.Drawing.Point(13, 37);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(12, 16);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "-";
            // 
            // Perro
            // 
            this.Perro.BackColor = System.Drawing.Color.DarkGray;
            this.Perro.Image = global::CatGame.Properties.Resources.dog2;
            this.Perro.Location = new System.Drawing.Point(387, 37);
            this.Perro.Name = "Perro";
            this.Perro.Size = new System.Drawing.Size(64, 64);
            this.Perro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perro.TabIndex = 3;
            this.Perro.TabStop = false;
            // 
            // Cat
            // 
            this.Cat.BackColor = System.Drawing.Color.DarkGray;
            this.Cat.Image = global::CatGame.Properties.Resources.cat1;
            this.Cat.Location = new System.Drawing.Point(206, 561);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(64, 64);
            this.Cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cat.TabIndex = 0;
            this.Cat.TabStop = false;
            // 
            // Supermercado
            // 
            this.Supermercado.BackColor = System.Drawing.Color.DarkGray;
            this.Supermercado.Image = global::CatGame.Properties.Resources.supermarket;
            this.Supermercado.Location = new System.Drawing.Point(201, 170);
            this.Supermercado.Name = "Supermercado";
            this.Supermercado.Size = new System.Drawing.Size(69, 64);
            this.Supermercado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Supermercado.TabIndex = 7;
            this.Supermercado.TabStop = false;
            // 
            // Hombre
            // 
            this.Hombre.BackColor = System.Drawing.Color.DarkGray;
            this.Hombre.Image = global::CatGame.Properties.Resources.man;
            this.Hombre.Location = new System.Drawing.Point(251, 48);
            this.Hombre.Name = "Hombre";
            this.Hombre.Size = new System.Drawing.Size(64, 64);
            this.Hombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hombre.TabIndex = 6;
            this.Hombre.TabStop = false;
            // 
            // Casa1
            // 
            this.Casa1.BackColor = System.Drawing.Color.DarkGray;
            this.Casa1.Image = global::CatGame.Properties.Resources.home;
            this.Casa1.Location = new System.Drawing.Point(41, 37);
            this.Casa1.Name = "Casa1";
            this.Casa1.Size = new System.Drawing.Size(64, 64);
            this.Casa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Casa1.TabIndex = 5;
            this.Casa1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CatGame.Properties.Resources.paper2dBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 627);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 651);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.Perro);
            this.Controls.Add(this.lblpuntaje);
            this.Controls.Add(this.lblintentos);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.Supermercado);
            this.Controls.Add(this.Hombre);
            this.Controls.Add(this.Casa1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatGame ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supermercado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Casa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Cat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox Perro;
        private System.Windows.Forms.PictureBox Casa1;
        private System.Windows.Forms.PictureBox Hombre;
        private System.Windows.Forms.PictureBox Supermercado;
        private System.Windows.Forms.Label lblpuntaje;
        private System.Windows.Forms.Label lblintentos;
        private System.Windows.Forms.Timer tiempojuego;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnombre;
    }
}

