namespace WindowsFormsApp1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.btnAgregarDerecha = new System.Windows.Forms.Button();
            this.btnAgregarIzquierda = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(300, 276);
            this.treeView1.TabIndex = 1;
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.Location = new System.Drawing.Point(318, 12);
            this.btnAgregarRaiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(163, 36);
            this.btnAgregarRaiz.TabIndex = 4;
            this.btnAgregarRaiz.Text = "Agregar Raiz";
            this.btnAgregarRaiz.UseVisualStyleBackColor = true;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // btnAgregarDerecha
            // 
            this.btnAgregarDerecha.Location = new System.Drawing.Point(318, 92);
            this.btnAgregarDerecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarDerecha.Name = "btnAgregarDerecha";
            this.btnAgregarDerecha.Size = new System.Drawing.Size(163, 36);
            this.btnAgregarDerecha.TabIndex = 5;
            this.btnAgregarDerecha.Text = "Agregar Derecha";
            this.btnAgregarDerecha.UseVisualStyleBackColor = true;
            this.btnAgregarDerecha.Click += new System.EventHandler(this.btnAgregarDerecha_Click);
            // 
            // btnAgregarIzquierda
            // 
            this.btnAgregarIzquierda.Location = new System.Drawing.Point(318, 52);
            this.btnAgregarIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarIzquierda.Name = "btnAgregarIzquierda";
            this.btnAgregarIzquierda.Size = new System.Drawing.Size(163, 36);
            this.btnAgregarIzquierda.TabIndex = 6;
            this.btnAgregarIzquierda.Text = "Agregar Izquierda";
            this.btnAgregarIzquierda.UseVisualStyleBackColor = true;
            this.btnAgregarIzquierda.Click += new System.EventHandler(this.btnAgregarIzquierda_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(318, 132);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(163, 36);
            this.btnPreOrden.TabIndex = 7;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.Location = new System.Drawing.Point(318, 172);
            this.btnInOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(163, 36);
            this.btnInOrden.TabIndex = 8;
            this.btnInOrden.Text = "InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(318, 212);
            this.btnPostOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(163, 36);
            this.btnPostOrden.TabIndex = 9;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Location = new System.Drawing.Point(318, 252);
            this.btnAmplitud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(163, 36);
            this.btnAmplitud.TabIndex = 10;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbol seleccionado";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Altura y Anchura";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(318, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 136);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorrido";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(625, 150);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(163, 36);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.btnPostOrden);
            this.Controls.Add(this.btnInOrden);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnAgregarIzquierda);
            this.Controls.Add(this.btnAgregarDerecha);
            this.Controls.Add(this.btnAgregarRaiz);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.Button btnAgregarDerecha;
        private System.Windows.Forms.Button btnAgregarIzquierda;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCerrar;
    }
}

