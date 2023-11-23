
namespace NegrescoItalico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mensagemModificada = new System.Windows.Forms.Label();
            this.modificaItalico = new System.Windows.Forms.CheckBox();
            this.modificaNegrito = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mensagemModificada
            // 
            this.mensagemModificada.AutoSize = true;
            this.mensagemModificada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemModificada.Location = new System.Drawing.Point(35, 51);
            this.mensagemModificada.Name = "mensagemModificada";
            this.mensagemModificada.Size = new System.Drawing.Size(386, 96);
            this.mensagemModificada.TabIndex = 0;
            this.mensagemModificada.Text = "Julho tem passado lento\r\nEngraçado, nem o tempo consegue encarar\r\nO jeito que voc" +
    "ê tentou\r\nEscolher cada palavra pra não me machucar\r\n";
            // 
            // modificaItalico
            // 
            this.modificaItalico.AutoSize = true;
            this.modificaItalico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaItalico.Location = new System.Drawing.Point(39, 165);
            this.modificaItalico.Name = "modificaItalico";
            this.modificaItalico.Size = new System.Drawing.Size(159, 24);
            this.modificaItalico.TabIndex = 1;
            this.modificaItalico.Text = "Trocar para: Itálico";
            this.modificaItalico.UseVisualStyleBackColor = true;
            this.modificaItalico.CheckedChanged += new System.EventHandler(this.modificaItalico_CheckedChanged);
            // 
            // modificaNegrito
            // 
            this.modificaNegrito.AutoSize = true;
            this.modificaNegrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaNegrito.Location = new System.Drawing.Point(39, 210);
            this.modificaNegrito.Name = "modificaNegrito";
            this.modificaNegrito.Size = new System.Drawing.Size(188, 24);
            this.modificaNegrito.TabIndex = 2;
            this.modificaNegrito.Text = "Trocar para: Negrito";
            this.modificaNegrito.UseVisualStyleBackColor = true;
            this.modificaNegrito.CheckedChanged += new System.EventHandler(this.modificaNegrito_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificaNegrito);
            this.Controls.Add(this.modificaItalico);
            this.Controls.Add(this.mensagemModificada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mensagemModificada;
        private System.Windows.Forms.CheckBox modificaItalico;
        private System.Windows.Forms.CheckBox modificaNegrito;
    }
}

