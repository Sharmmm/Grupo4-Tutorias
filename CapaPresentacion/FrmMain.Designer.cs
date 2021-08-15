
namespace CapaPresentacion
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Sidebar = new System.Windows.Forms.Panel();
            this.labelCategoriaU = new System.Windows.Forms.Label();
            this.btnTutorados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFicha = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.btnTutoria = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDocentes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstudiantes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Header = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Sidebar.Controls.Add(this.labelCategoriaU);
            this.Sidebar.Controls.Add(this.btnTutorados);
            this.Sidebar.Controls.Add(this.btnFicha);
            this.Sidebar.Controls.Add(this.labelUsuario);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.labelCategoria);
            this.Sidebar.Controls.Add(this.btnTutoria);
            this.Sidebar.Controls.Add(this.btnDocentes);
            this.Sidebar.Controls.Add(this.btnEstudiantes);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(333, 703);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // labelCategoriaU
            // 
            this.labelCategoriaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCategoriaU.ForeColor = System.Drawing.Color.White;
            this.labelCategoriaU.Location = new System.Drawing.Point(80, 220);
            this.labelCategoriaU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoriaU.Name = "labelCategoriaU";
            this.labelCategoriaU.Size = new System.Drawing.Size(164, 28);
            this.labelCategoriaU.TabIndex = 8;
            this.labelCategoriaU.Text = "Categoria";
            this.labelCategoriaU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTutorados
            // 
            this.btnTutorados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutorados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutorados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutorados.BorderRadius = 0;
            this.btnTutorados.ButtonText = "            Tutorados";
            this.btnTutorados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutorados.DisabledColor = System.Drawing.Color.Gray;
            this.btnTutorados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTutorados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTutorados.Iconimage")));
            this.btnTutorados.Iconimage_right = null;
            this.btnTutorados.Iconimage_right_Selected = null;
            this.btnTutorados.Iconimage_Selected = null;
            this.btnTutorados.IconMarginLeft = 0;
            this.btnTutorados.IconMarginRight = 0;
            this.btnTutorados.IconRightVisible = true;
            this.btnTutorados.IconRightZoom = 0D;
            this.btnTutorados.IconVisible = true;
            this.btnTutorados.IconZoom = 90D;
            this.btnTutorados.IsTab = false;
            this.btnTutorados.Location = new System.Drawing.Point(16, 446);
            this.btnTutorados.Margin = new System.Windows.Forms.Padding(5);
            this.btnTutorados.Name = "btnTutorados";
            this.btnTutorados.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutorados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTutorados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTutorados.selected = false;
            this.btnTutorados.Size = new System.Drawing.Size(288, 46);
            this.btnTutorados.TabIndex = 7;
            this.btnTutorados.Text = "            Tutorados";
            this.btnTutorados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutorados.Textcolor = System.Drawing.Color.White;
            this.btnTutorados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorados.Click += new System.EventHandler(this.btnTutorados_Click);
            // 
            // btnFicha
            // 
            this.btnFicha.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFicha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFicha.BorderRadius = 0;
            this.btnFicha.ButtonText = "            Fichas de Tutoria";
            this.btnFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFicha.DisabledColor = System.Drawing.Color.Gray;
            this.btnFicha.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFicha.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFicha.Iconimage")));
            this.btnFicha.Iconimage_right = null;
            this.btnFicha.Iconimage_right_Selected = null;
            this.btnFicha.Iconimage_Selected = null;
            this.btnFicha.IconMarginLeft = 0;
            this.btnFicha.IconMarginRight = 0;
            this.btnFicha.IconRightVisible = true;
            this.btnFicha.IconRightZoom = 0D;
            this.btnFicha.IconVisible = true;
            this.btnFicha.IconZoom = 90D;
            this.btnFicha.IsTab = false;
            this.btnFicha.Location = new System.Drawing.Point(16, 501);
            this.btnFicha.Margin = new System.Windows.Forms.Padding(5);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFicha.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFicha.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFicha.selected = false;
            this.btnFicha.Size = new System.Drawing.Size(288, 46);
            this.btnFicha.TabIndex = 6;
            this.btnFicha.Text = "            Fichas de Tutoria";
            this.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFicha.Textcolor = System.Drawing.Color.White;
            this.btnFicha.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(80, 177);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(164, 28);
            this.labelUsuario.TabIndex = 5;
            this.labelUsuario.Text = "USUARIO1";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelCategoria
            // 
            this.labelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCategoria.ForeColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(127, 15);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(75, 28);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "CRUD";
            // 
            // btnTutoria
            // 
            this.btnTutoria.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutoria.BorderRadius = 0;
            this.btnTutoria.ButtonText = "            Tutoria";
            this.btnTutoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutoria.DisabledColor = System.Drawing.Color.Gray;
            this.btnTutoria.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTutoria.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTutoria.Iconimage")));
            this.btnTutoria.Iconimage_right = null;
            this.btnTutoria.Iconimage_right_Selected = null;
            this.btnTutoria.Iconimage_Selected = null;
            this.btnTutoria.IconMarginLeft = 0;
            this.btnTutoria.IconMarginRight = 0;
            this.btnTutoria.IconRightVisible = true;
            this.btnTutoria.IconRightZoom = 0D;
            this.btnTutoria.IconVisible = true;
            this.btnTutoria.IconZoom = 90D;
            this.btnTutoria.IsTab = false;
            this.btnTutoria.Location = new System.Drawing.Point(16, 390);
            this.btnTutoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnTutoria.Name = "btnTutoria";
            this.btnTutoria.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTutoria.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTutoria.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTutoria.selected = false;
            this.btnTutoria.Size = new System.Drawing.Size(288, 46);
            this.btnTutoria.TabIndex = 2;
            this.btnTutoria.Text = "            Tutoria";
            this.btnTutoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutoria.Textcolor = System.Drawing.Color.White;
            this.btnTutoria.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutoria.Click += new System.EventHandler(this.btnTutoria_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDocentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDocentes.BorderRadius = 0;
            this.btnDocentes.ButtonText = "            Profesores";
            this.btnDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocentes.DisabledColor = System.Drawing.Color.Gray;
            this.btnDocentes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDocentes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDocentes.Iconimage")));
            this.btnDocentes.Iconimage_right = null;
            this.btnDocentes.Iconimage_right_Selected = null;
            this.btnDocentes.Iconimage_Selected = null;
            this.btnDocentes.IconMarginLeft = 0;
            this.btnDocentes.IconMarginRight = 0;
            this.btnDocentes.IconRightVisible = true;
            this.btnDocentes.IconRightZoom = 0D;
            this.btnDocentes.IconVisible = true;
            this.btnDocentes.IconZoom = 90D;
            this.btnDocentes.IsTab = false;
            this.btnDocentes.Location = new System.Drawing.Point(16, 337);
            this.btnDocentes.Margin = new System.Windows.Forms.Padding(5);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDocentes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDocentes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDocentes.selected = false;
            this.btnDocentes.Size = new System.Drawing.Size(288, 46);
            this.btnDocentes.TabIndex = 1;
            this.btnDocentes.Text = "            Profesores";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocentes.Textcolor = System.Drawing.Color.White;
            this.btnDocentes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEstudiantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstudiantes.BorderRadius = 0;
            this.btnEstudiantes.ButtonText = "            Estudiantes";
            this.btnEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiantes.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstudiantes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEstudiantes.Iconimage")));
            this.btnEstudiantes.Iconimage_right = null;
            this.btnEstudiantes.Iconimage_right_Selected = null;
            this.btnEstudiantes.Iconimage_Selected = null;
            this.btnEstudiantes.IconMarginLeft = 0;
            this.btnEstudiantes.IconMarginRight = 0;
            this.btnEstudiantes.IconRightVisible = true;
            this.btnEstudiantes.IconRightZoom = 0D;
            this.btnEstudiantes.IconVisible = true;
            this.btnEstudiantes.IconZoom = 90D;
            this.btnEstudiantes.IsTab = false;
            this.btnEstudiantes.Location = new System.Drawing.Point(16, 281);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(5);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEstudiantes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEstudiantes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEstudiantes.selected = false;
            this.btnEstudiantes.Size = new System.Drawing.Size(288, 46);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "            Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Textcolor = System.Drawing.Color.White;
            this.btnEstudiantes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Header.Controls.Add(this.Salir);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(333, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1362, 74);
            this.Header.TabIndex = 1;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1221, 15);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(53, 46);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(333, 0);
            this.Wrapper.Margin = new System.Windows.Forms.Padding(4);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1362, 703);
            this.Wrapper.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 703);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuFlatButton btnTutoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnDocentes;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstudiantes;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCategoria;
        private Bunifu.Framework.UI.BunifuFlatButton btnTutorados;
        private Bunifu.Framework.UI.BunifuFlatButton btnFicha;
        private System.Windows.Forms.Label labelCategoriaU;
    }
}