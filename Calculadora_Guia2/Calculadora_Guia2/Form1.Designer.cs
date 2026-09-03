namespace Calculadora_Guia2
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
            etPantalla = new Label();
            btDigito0 = new Button();
            btDigito1 = new Button();
            btDigito2 = new Button();
            btDigito3 = new Button();
            btDigito7 = new Button();
            btDigito6 = new Button();
            btDigito5 = new Button();
            btDigito4 = new Button();
            btMenos = new Button();
            btMas = new Button();
            btDigito9 = new Button();
            btDigito8 = new Button();
            btComaDec = new Button();
            btIgual = new Button();
            btDividir = new Button();
            btPor = new Button();
            btTantoPorCiento = new Button();
            btIniciar = new Button();
            btBorrarEntrada = new Button();
            SuspendLayout();
            // 
            // etPantalla
            // 
            etPantalla.BackColor = SystemColors.ButtonFace;
            etPantalla.BorderStyle = BorderStyle.Fixed3D;
            etPantalla.Location = new Point(29, 26);
            etPantalla.Name = "etPantalla";
            etPantalla.Size = new Size(230, 28);
            etPantalla.TabIndex = 0;
            etPantalla.Text = "0,";
            etPantalla.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btDigito0
            // 
            btDigito0.Location = new Point(29, 206);
            btDigito0.Name = "btDigito0";
            btDigito0.Size = new Size(84, 31);
            btDigito0.TabIndex = 1;
            btDigito0.Text = "0";
            btDigito0.UseVisualStyleBackColor = true;
            btDigito0.Click += btDigito_Click;
            // 
            // btDigito1
            // 
            btDigito1.Location = new Point(29, 164);
            btDigito1.Name = "btDigito1";
            btDigito1.Size = new Size(40, 36);
            btDigito1.TabIndex = 2;
            btDigito1.Text = "1";
            btDigito1.UseVisualStyleBackColor = true;
            btDigito1.Click += btDigito_Click;
            // 
            // btDigito2
            // 
            btDigito2.Location = new Point(75, 164);
            btDigito2.Name = "btDigito2";
            btDigito2.Size = new Size(38, 36);
            btDigito2.TabIndex = 3;
            btDigito2.Text = "2";
            btDigito2.UseVisualStyleBackColor = true;
            btDigito2.Click += btDigito_Click;
            // 
            // btDigito3
            // 
            btDigito3.Location = new Point(119, 164);
            btDigito3.Name = "btDigito3";
            btDigito3.Size = new Size(36, 36);
            btDigito3.TabIndex = 4;
            btDigito3.Text = "3";
            btDigito3.UseVisualStyleBackColor = true;
            btDigito3.Click += btDigito_Click;
            // 
            // btDigito7
            // 
            btDigito7.Location = new Point(29, 79);
            btDigito7.Name = "btDigito7";
            btDigito7.Size = new Size(38, 37);
            btDigito7.TabIndex = 8;
            btDigito7.Text = "7";
            btDigito7.UseVisualStyleBackColor = true;
            btDigito7.Click += btDigito_Click;
            // 
            // btDigito6
            // 
            btDigito6.Location = new Point(119, 122);
            btDigito6.Name = "btDigito6";
            btDigito6.Size = new Size(36, 36);
            btDigito6.TabIndex = 7;
            btDigito6.Text = "6";
            btDigito6.UseVisualStyleBackColor = true;
            btDigito6.Click += btDigito_Click;
            // 
            // btDigito5
            // 
            btDigito5.Location = new Point(73, 122);
            btDigito5.Name = "btDigito5";
            btDigito5.Size = new Size(40, 36);
            btDigito5.TabIndex = 6;
            btDigito5.Text = "5";
            btDigito5.UseVisualStyleBackColor = true;
            btDigito5.Click += btDigito_Click;
            // 
            // btDigito4
            // 
            btDigito4.Location = new Point(29, 122);
            btDigito4.Name = "btDigito4";
            btDigito4.Size = new Size(38, 36);
            btDigito4.TabIndex = 5;
            btDigito4.Text = "4";
            btDigito4.UseVisualStyleBackColor = true;
            btDigito4.Click += btDigito_Click;
            // 
            // btMenos
            // 
            btMenos.Location = new Point(221, 164);
            btMenos.Name = "btMenos";
            btMenos.Size = new Size(38, 36);
            btMenos.TabIndex = 12;
            btMenos.Text = "-";
            btMenos.UseVisualStyleBackColor = true;
            btMenos.Click += btOperacion_Click;
            // 
            // btMas
            // 
            btMas.Location = new Point(221, 122);
            btMas.Name = "btMas";
            btMas.Size = new Size(38, 36);
            btMas.TabIndex = 11;
            btMas.Text = "+";
            btMas.UseVisualStyleBackColor = true;
            btMas.Click += btOperacion_Click;
            // 
            // btDigito9
            // 
            btDigito9.Location = new Point(119, 79);
            btDigito9.Name = "btDigito9";
            btDigito9.Size = new Size(36, 37);
            btDigito9.TabIndex = 10;
            btDigito9.Text = "9";
            btDigito9.UseVisualStyleBackColor = true;
            btDigito9.Click += btDigito_Click;
            // 
            // btDigito8
            // 
            btDigito8.Location = new Point(73, 79);
            btDigito8.Name = "btDigito8";
            btDigito8.Size = new Size(40, 37);
            btDigito8.TabIndex = 9;
            btDigito8.Text = "8";
            btDigito8.UseVisualStyleBackColor = true;
            btDigito8.Click += btDigito_Click;
            // 
            // btComaDec
            // 
            btComaDec.Location = new Point(119, 206);
            btComaDec.Name = "btComaDec";
            btComaDec.Size = new Size(36, 31);
            btComaDec.TabIndex = 16;
            btComaDec.Text = ",";
            btComaDec.UseVisualStyleBackColor = true;
            btComaDec.Click += btComaDec_Click;
            // 
            // btIgual
            // 
            btIgual.Location = new Point(221, 206);
            btIgual.Name = "btIgual";
            btIgual.Size = new Size(38, 31);
            btIgual.TabIndex = 15;
            btIgual.Text = "=";
            btIgual.UseVisualStyleBackColor = true;
            btIgual.Click += btOperacion_Click;
            // 
            // btDividir
            // 
            btDividir.Location = new Point(180, 122);
            btDividir.Name = "btDividir";
            btDividir.Size = new Size(35, 36);
            btDividir.TabIndex = 14;
            btDividir.Text = "/";
            btDividir.UseVisualStyleBackColor = true;
            btDividir.Click += btOperacion_Click;
            // 
            // btPor
            // 
            btPor.Location = new Point(180, 164);
            btPor.Name = "btPor";
            btPor.Size = new Size(35, 36);
            btPor.TabIndex = 13;
            btPor.Text = "*";
            btPor.UseVisualStyleBackColor = true;
            btPor.Click += btOperacion_Click;
            // 
            // btTantoPorCiento
            // 
            btTantoPorCiento.Location = new Point(180, 206);
            btTantoPorCiento.Name = "btTantoPorCiento";
            btTantoPorCiento.Size = new Size(35, 31);
            btTantoPorCiento.TabIndex = 17;
            btTantoPorCiento.Text = "%";
            btTantoPorCiento.UseVisualStyleBackColor = true;
            btTantoPorCiento.Click += btTantoPorCiento_Click;
            // 
            // btIniciar
            // 
            btIniciar.Location = new Point(180, 79);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(35, 37);
            btIniciar.TabIndex = 18;
            btIniciar.Text = "C";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += btIniciar_Click;
            // 
            // btBorrarEntrada
            // 
            btBorrarEntrada.Location = new Point(221, 79);
            btBorrarEntrada.Name = "btBorrarEntrada";
            btBorrarEntrada.Size = new Size(38, 37);
            btBorrarEntrada.TabIndex = 19;
            btBorrarEntrada.Text = "CE";
            btBorrarEntrada.UseVisualStyleBackColor = true;
            btBorrarEntrada.Click += btBorrarEntrada_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 258);
            Controls.Add(btBorrarEntrada);
            Controls.Add(btIniciar);
            Controls.Add(btTantoPorCiento);
            Controls.Add(btComaDec);
            Controls.Add(btIgual);
            Controls.Add(btDividir);
            Controls.Add(btPor);
            Controls.Add(btMenos);
            Controls.Add(btMas);
            Controls.Add(btDigito9);
            Controls.Add(btDigito8);
            Controls.Add(btDigito7);
            Controls.Add(btDigito6);
            Controls.Add(btDigito5);
            Controls.Add(btDigito4);
            Controls.Add(btDigito3);
            Controls.Add(btDigito2);
            Controls.Add(btDigito1);
            Controls.Add(btDigito0);
            Controls.Add(etPantalla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label etPantalla;
        private Button btDigito0;
        private Button btDigito1;
        private Button button3;
        private Button btDigito2;
        private Button btDigito3;
        private Button btDigito7;
        private Button btDigito6;
        private Button btDigito5;
        private Button btDigito4;
        private Button btMenos;
        private Button btMas;
        private Button btDigito9;
        private Button btDigito8;
        private Button btComaDec;
        private Button btIgual;
        private Button btDividir;
        private Button btPor;
        private Button btTantoPorCiento;
        private Button btIniciar;
        private Button btBorrarEntrada;
    }
}
