namespace LAZURIT
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAgent = new System.Windows.Forms.Button();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelLazur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(12, 111);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(264, 60);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиенты";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonAgent
            // 
            this.buttonAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAgent.ForeColor = System.Drawing.Color.White;
            this.buttonAgent.Location = new System.Drawing.Point(12, 177);
            this.buttonAgent.Name = "buttonAgent";
            this.buttonAgent.Size = new System.Drawing.Size(264, 60);
            this.buttonAgent.TabIndex = 2;
            this.buttonAgent.Text = "Менеджеры";
            this.buttonAgent.UseVisualStyleBackColor = false;
            this.buttonAgent.Click += new System.EventHandler(this.buttonAgent_Click);
            // 
            // buttonTovar
            // 
            this.buttonTovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovar.ForeColor = System.Drawing.Color.White;
            this.buttonTovar.Location = new System.Drawing.Point(12, 243);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(264, 60);
            this.buttonTovar.TabIndex = 3;
            this.buttonTovar.Text = "Товары";
            this.buttonTovar.UseVisualStyleBackColor = false;
            // 
            // buttonOrder
            // 
            this.buttonOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(12, 309);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(264, 60);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Заказы";
            this.buttonOrder.UseVisualStyleBackColor = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelHello.Location = new System.Drawing.Point(35, 82);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(106, 16);
            this.labelHello.TabIndex = 5;
            this.labelHello.Text = "Приветствие";
            // 
            // labelLazur
            // 
            this.labelLazur.AutoSize = true;
            this.labelLazur.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLazur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelLazur.Location = new System.Drawing.Point(11, 9);
            this.labelLazur.Name = "labelLazur";
            this.labelLazur.Size = new System.Drawing.Size(265, 63);
            this.labelLazur.TabIndex = 6;
            this.labelLazur.Text = "LAZURIT";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(288, 387);
            this.Controls.Add(this.labelLazur);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.buttonAgent);
            this.Controls.Add(this.buttonClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAgent;
        private System.Windows.Forms.Button buttonTovar;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelLazur;
    }
}

