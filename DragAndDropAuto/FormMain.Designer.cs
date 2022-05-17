namespace DragAndDropAuto
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonSourceDrag = new System.Windows.Forms.Button();
            this.textBoxTargetDrop = new System.Windows.Forms.TextBox();
            this.buttonSourceDrag1 = new System.Windows.Forms.Button();
            this.pictureBoxSourceDrag = new System.Windows.Forms.PictureBox();
            this.pictureBoxSourceDrag1 = new System.Windows.Forms.PictureBox();
            this.panelTargetDrag = new System.Windows.Forms.Panel();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.listBoxFruits = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSourceDrag
            // 
            this.buttonSourceDrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourceDrag.Location = new System.Drawing.Point(29, 24);
            this.buttonSourceDrag.Name = "buttonSourceDrag";
            this.buttonSourceDrag.Size = new System.Drawing.Size(356, 49);
            this.buttonSourceDrag.TabIndex = 0;
            this.buttonSourceDrag.Text = "Перетащи меня";
            this.buttonSourceDrag.UseVisualStyleBackColor = true;
            this.buttonSourceDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourceDrag_MouseDown);
            // 
            // textBoxTargetDrop
            // 
            this.textBoxTargetDrop.AllowDrop = true;
            this.textBoxTargetDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTargetDrop.Location = new System.Drawing.Point(476, 58);
            this.textBoxTargetDrop.Name = "textBoxTargetDrop";
            this.textBoxTargetDrop.Size = new System.Drawing.Size(231, 47);
            this.textBoxTargetDrop.TabIndex = 1;
            this.textBoxTargetDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragDrop);
            this.textBoxTargetDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragEnter);
            // 
            // buttonSourceDrag1
            // 
            this.buttonSourceDrag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourceDrag1.Location = new System.Drawing.Point(29, 100);
            this.buttonSourceDrag1.Name = "buttonSourceDrag1";
            this.buttonSourceDrag1.Size = new System.Drawing.Size(356, 49);
            this.buttonSourceDrag1.TabIndex = 2;
            this.buttonSourceDrag1.Text = "ТАЩИ!!!!";
            this.buttonSourceDrag1.UseVisualStyleBackColor = true;
            this.buttonSourceDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourceDrag1_MouseDown);
            // 
            // pictureBoxSourceDrag
            // 
            this.pictureBoxSourceDrag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourceDrag.Image")));
            this.pictureBoxSourceDrag.Location = new System.Drawing.Point(29, 227);
            this.pictureBoxSourceDrag.Name = "pictureBoxSourceDrag";
            this.pictureBoxSourceDrag.Size = new System.Drawing.Size(157, 142);
            this.pictureBoxSourceDrag.TabIndex = 3;
            this.pictureBoxSourceDrag.TabStop = false;
            this.pictureBoxSourceDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSourceDrag_MouseDown);
            // 
            // pictureBoxSourceDrag1
            // 
            this.pictureBoxSourceDrag1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourceDrag1.Image")));
            this.pictureBoxSourceDrag1.Location = new System.Drawing.Point(228, 227);
            this.pictureBoxSourceDrag1.Name = "pictureBoxSourceDrag1";
            this.pictureBoxSourceDrag1.Size = new System.Drawing.Size(157, 142);
            this.pictureBoxSourceDrag1.TabIndex = 4;
            this.pictureBoxSourceDrag1.TabStop = false;
            this.pictureBoxSourceDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSourceDrag_MouseDown);
            // 
            // panelTargetDrag
            // 
            this.panelTargetDrag.AllowDrop = true;
            this.panelTargetDrag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTargetDrag.Location = new System.Drawing.Point(497, 213);
            this.panelTargetDrag.Name = "panelTargetDrag";
            this.panelTargetDrag.Size = new System.Drawing.Size(200, 183);
            this.panelTargetDrag.TabIndex = 5;
            this.panelTargetDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTargetDrag_DragDrop);
            this.panelTargetDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTargetDrag_DragEnter);
            // 
            // listBoxColors
            // 
            this.listBoxColors.AllowDrop = true;
            this.listBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 31;
            this.listBoxColors.Items.AddRange(new object[] {
            "красный",
            "синий",
            "зеленый",
            "оранж"});
            this.listBoxColors.Location = new System.Drawing.Point(123, 431);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(204, 221);
            this.listBoxColors.TabIndex = 6;
            this.listBoxColors.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragDrop);
            this.listBoxColors.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragEnter);
            this.listBoxColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxColors_MouseDown);
            // 
            // listBoxFruits
            // 
            this.listBoxFruits.AllowDrop = true;
            this.listBoxFruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFruits.FormattingEnabled = true;
            this.listBoxFruits.ItemHeight = 31;
            this.listBoxFruits.Items.AddRange(new object[] {
            "яблоко",
            "слива",
            "киви",
            "апельсин"});
            this.listBoxFruits.Location = new System.Drawing.Point(392, 431);
            this.listBoxFruits.Name = "listBoxFruits";
            this.listBoxFruits.Size = new System.Drawing.Size(204, 221);
            this.listBoxFruits.TabIndex = 7;
            this.listBoxFruits.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragDrop);
            this.listBoxFruits.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragEnter);
            this.listBoxFruits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxColors_MouseDown);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.listBoxFruits);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.panelTargetDrag);
            this.Controls.Add(this.pictureBoxSourceDrag1);
            this.Controls.Add(this.pictureBoxSourceDrag);
            this.Controls.Add(this.buttonSourceDrag1);
            this.Controls.Add(this.textBoxTargetDrop);
            this.Controls.Add(this.buttonSourceDrag);
            this.Name = "FormMain";
            this.Text = "Встроенный инструмент для перетаскивания объектов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSourceDrag;
        private System.Windows.Forms.TextBox textBoxTargetDrop;
        private System.Windows.Forms.Button buttonSourceDrag1;
        private System.Windows.Forms.PictureBox pictureBoxSourceDrag;
        private System.Windows.Forms.PictureBox pictureBoxSourceDrag1;
        private System.Windows.Forms.Panel panelTargetDrag;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.ListBox listBoxFruits;
    }
}

