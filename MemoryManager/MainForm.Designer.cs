namespace MemoryManager
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDwLength = new System.Windows.Forms.Label();
            this.lbDwMemoryLoad = new System.Windows.Forms.Label();
            this.lbDwTotalPhys = new System.Windows.Forms.Label();
            this.lbDwAvailPhys = new System.Windows.Forms.Label();
            this.lbDwTotalPageFile = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbDwAvailPageFile = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDwTotalVirtual = new System.Windows.Forms.Label();
            this.lbDwAvailVirtual = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер структуры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Процент занятой памяти";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общее кол-во физической (оперативной) памяти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Свободное кол-во физической (оперативной) памяти";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Предел памяти для системы или текущего процесса";
            // 
            // lbDwLength
            // 
            this.lbDwLength.AutoSize = true;
            this.lbDwLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwLength.Location = new System.Drawing.Point(332, 9);
            this.lbDwLength.Name = "lbDwLength";
            this.lbDwLength.Size = new System.Drawing.Size(11, 13);
            this.lbDwLength.TabIndex = 5;
            this.lbDwLength.Text = "-";
            // 
            // lbDwMemoryLoad
            // 
            this.lbDwMemoryLoad.AutoSize = true;
            this.lbDwMemoryLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwMemoryLoad.Location = new System.Drawing.Point(332, 37);
            this.lbDwMemoryLoad.Name = "lbDwMemoryLoad";
            this.lbDwMemoryLoad.Size = new System.Drawing.Size(11, 13);
            this.lbDwMemoryLoad.TabIndex = 6;
            this.lbDwMemoryLoad.Text = "-";
            // 
            // lbDwTotalPhys
            // 
            this.lbDwTotalPhys.AutoSize = true;
            this.lbDwTotalPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwTotalPhys.Location = new System.Drawing.Point(332, 65);
            this.lbDwTotalPhys.Name = "lbDwTotalPhys";
            this.lbDwTotalPhys.Size = new System.Drawing.Size(11, 13);
            this.lbDwTotalPhys.TabIndex = 7;
            this.lbDwTotalPhys.Text = "-";
            // 
            // lbDwAvailPhys
            // 
            this.lbDwAvailPhys.AutoSize = true;
            this.lbDwAvailPhys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwAvailPhys.Location = new System.Drawing.Point(332, 93);
            this.lbDwAvailPhys.Name = "lbDwAvailPhys";
            this.lbDwAvailPhys.Size = new System.Drawing.Size(11, 13);
            this.lbDwAvailPhys.TabIndex = 8;
            this.lbDwAvailPhys.Text = "-";
            // 
            // lbDwTotalPageFile
            // 
            this.lbDwTotalPageFile.AutoSize = true;
            this.lbDwTotalPageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwTotalPageFile.Location = new System.Drawing.Point(332, 123);
            this.lbDwTotalPageFile.Name = "lbDwTotalPageFile";
            this.lbDwTotalPageFile.Size = new System.Drawing.Size(11, 13);
            this.lbDwTotalPageFile.TabIndex = 9;
            this.lbDwTotalPageFile.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Максимальный объем памяти, \r\nкоторый может зафиксировать текущий процесс";
            // 
            // lbDwAvailPageFile
            // 
            this.lbDwAvailPageFile.AutoSize = true;
            this.lbDwAvailPageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwAvailPageFile.Location = new System.Drawing.Point(332, 154);
            this.lbDwAvailPageFile.Name = "lbDwAvailPageFile";
            this.lbDwAvailPageFile.Size = new System.Drawing.Size(11, 13);
            this.lbDwAvailPageFile.TabIndex = 11;
            this.lbDwAvailPageFile.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(295, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Общее количество виртуальной памяти (файл подкачки)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(315, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Свободное количество виртуальной памяти (файл подкачки)";
            // 
            // lbDwTotalVirtual
            // 
            this.lbDwTotalVirtual.AutoSize = true;
            this.lbDwTotalVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwTotalVirtual.Location = new System.Drawing.Point(332, 186);
            this.lbDwTotalVirtual.Name = "lbDwTotalVirtual";
            this.lbDwTotalVirtual.Size = new System.Drawing.Size(11, 13);
            this.lbDwTotalVirtual.TabIndex = 14;
            this.lbDwTotalVirtual.Text = "-";
            // 
            // lbDwAvailVirtual
            // 
            this.lbDwAvailVirtual.AutoSize = true;
            this.lbDwAvailVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDwAvailVirtual.Location = new System.Drawing.Point(332, 220);
            this.lbDwAvailVirtual.Name = "lbDwAvailVirtual";
            this.lbDwAvailVirtual.Size = new System.Drawing.Size(11, 13);
            this.lbDwAvailVirtual.TabIndex = 15;
            this.lbDwAvailVirtual.Text = "-";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(329, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(416, 290);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbDwAvailVirtual);
            this.Controls.Add(this.lbDwTotalVirtual);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbDwAvailPageFile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbDwTotalPageFile);
            this.Controls.Add(this.lbDwAvailPhys);
            this.Controls.Add(this.lbDwTotalPhys);
            this.Controls.Add(this.lbDwMemoryLoad);
            this.Controls.Add(this.lbDwLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Диспетчер памяти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDwLength;
        private System.Windows.Forms.Label lbDwMemoryLoad;
        private System.Windows.Forms.Label lbDwTotalPhys;
        private System.Windows.Forms.Label lbDwAvailPhys;
        private System.Windows.Forms.Label lbDwTotalPageFile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbDwAvailPageFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbDwTotalVirtual;
        private System.Windows.Forms.Label lbDwAvailVirtual;
        private System.Windows.Forms.Button btnUpdate;
    }
}

