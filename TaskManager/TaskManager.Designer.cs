namespace TaskManager
{
    partial class TaskManager
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
            this.dgTaskManager = new System.Windows.Forms.DataGridView();
            this.btnNewProc = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTaskManager
            // 
            this.dgTaskManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTaskManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTaskManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskManager.Location = new System.Drawing.Point(12, 54);
            this.dgTaskManager.Name = "dgTaskManager";
            this.dgTaskManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTaskManager.Size = new System.Drawing.Size(1010, 375);
            this.dgTaskManager.TabIndex = 0;
            this.dgTaskManager.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgTaskManager_MouseClick);
            // 
            // btnNewProc
            // 
            this.btnNewProc.Location = new System.Drawing.Point(13, 13);
            this.btnNewProc.Name = "btnNewProc";
            this.btnNewProc.Size = new System.Drawing.Size(94, 35);
            this.btnNewProc.TabIndex = 1;
            this.btnNewProc.Text = "Новая задача";
            this.btnNewProc.UseVisualStyleBackColor = true;
            this.btnNewProc.Click += new System.EventHandler(this.btnNewProc_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(135, 13);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(92, 35);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Завершить процесс";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 441);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnNewProc);
            this.Controls.Add(this.dgTaskManager);
            this.Name = "TaskManager";
            this.Text = "Диспетчер задач";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTaskManager;
        private System.Windows.Forms.Button btnNewProc;
        private System.Windows.Forms.Button btnKill;
    }
}

