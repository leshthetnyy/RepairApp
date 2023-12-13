namespace RepairApp
{
    partial class Executor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Executor));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.бД_РЕМОНТDataSet = new RepairApp.БД_РЕМОНТDataSet();
            this.статусызаявокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусы_заявокTableAdapter = new RepairApp.БД_РЕМОНТDataSetTableAdapters.Статусы_заявокTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бД_РЕМОНТDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусызаявокBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "+ Создать новую заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button2.Location = new System.Drawing.Point(589, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выход из аккаунта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 163);
            this.dataGridView1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button3.Location = new System.Drawing.Point(12, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(383, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "Смотреть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button4.Location = new System.Drawing.Point(410, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(378, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "Именить статус";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(344, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Новые заявки";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button5.Location = new System.Drawing.Point(304, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 38);
            this.button5.TabIndex = 19;
            this.button5.Text = "Обновить список";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 301);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 137);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 137);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.статусызаявокBindingSource;
            this.comboBox1.DisplayMember = "Название_статуса_заявки";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_Статуса_заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(195, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Смена статуса заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(69, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Заявка №";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.textBox2.Location = new System.Drawing.Point(155, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(36, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Новый статус:";
            // 
            // бД_РЕМОНТDataSet
            // 
            this.бД_РЕМОНТDataSet.DataSetName = "БД_РЕМОНТDataSet";
            this.бД_РЕМОНТDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // статусызаявокBindingSource
            // 
            this.статусызаявокBindingSource.DataMember = "Статусы_заявок";
            this.статусызаявокBindingSource.DataSource = this.бД_РЕМОНТDataSet;
            // 
            // статусы_заявокTableAdapter
            // 
            this.статусы_заявокTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button6.Location = new System.Drawing.Point(555, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(199, 38);
            this.button6.TabIndex = 23;
            this.button6.Text = "Отмена";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button7.Location = new System.Drawing.Point(555, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(199, 38);
            this.button7.TabIndex = 24;
            this.button7.Text = "Готово";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Executor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Executor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исполнитель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Executor_FormClosed);
            this.Load += new System.EventHandler(this.Executor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.бД_РЕМОНТDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусызаявокBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private БД_РЕМОНТDataSet бД_РЕМОНТDataSet;
        private System.Windows.Forms.BindingSource статусызаявокBindingSource;
        private БД_РЕМОНТDataSetTableAdapters.Статусы_заявокTableAdapter статусы_заявокTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}