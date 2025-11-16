namespace To_Do_List_Application
{
    partial class ToDo
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
            Lueberschrift = new Label();
            tTask = new TextBox();
            bAdd = new Button();
            bRemove = new Button();
            label1 = new Label();
            lAdd = new Label();
            tDescription = new TextBox();
            lDescription = new Label();
            viewToDo = new DataGridView();
            bSave = new Button();
            bEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)viewToDo).BeginInit();
            SuspendLayout();
            // 
            // Lueberschrift
            // 
            Lueberschrift.AutoSize = true;
            Lueberschrift.BackColor = SystemColors.InactiveCaptionText;
            Lueberschrift.BorderStyle = BorderStyle.Fixed3D;
            Lueberschrift.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lueberschrift.ForeColor = Color.White;
            Lueberschrift.Location = new Point(357, 9);
            Lueberschrift.Name = "Lueberschrift";
            Lueberschrift.Size = new Size(151, 32);
            Lueberschrift.TabIndex = 0;
            Lueberschrift.Text = "To Do List!";
            Lueberschrift.TextAlign = ContentAlignment.MiddleCenter;
            Lueberschrift.Click += label1_Click;
            // 
            // tTask
            // 
            tTask.BackColor = SystemColors.Window;
            tTask.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tTask.Location = new Point(14, 87);
            tTask.Name = "tTask";
            tTask.Size = new Size(886, 27);
            tTask.TabIndex = 1;
            tTask.TextChanged += textBox1_TextChanged;
            // 
            // bAdd
            // 
            bAdd.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bAdd.Location = new Point(282, 183);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(173, 40);
            bAdd.TabIndex = 2;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bHinzufügen_Click;
            // 
            // bRemove
            // 
            bRemove.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bRemove.Location = new Point(14, 183);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(248, 40);
            bRemove.TabIndex = 3;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = true;
            bRemove.Click += bEntfernen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // lAdd
            // 
            lAdd.AutoSize = true;
            lAdd.BackColor = SystemColors.InactiveCaptionText;
            lAdd.BorderStyle = BorderStyle.Fixed3D;
            lAdd.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lAdd.ForeColor = Color.White;
            lAdd.Location = new Point(14, 58);
            lAdd.Name = "lAdd";
            lAdd.Size = new Size(121, 25);
            lAdd.TabIndex = 5;
            lAdd.Text = "Add a task";
            lAdd.TextAlign = ContentAlignment.TopCenter;
            lAdd.Click += lAdd_Click;
            // 
            // tDescription
            // 
            tDescription.BackColor = SystemColors.Window;
            tDescription.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tDescription.Location = new Point(14, 150);
            tDescription.Name = "tDescription";
            tDescription.Size = new Size(886, 27);
            tDescription.TabIndex = 6;
            // 
            // lDescription
            // 
            lDescription.AutoSize = true;
            lDescription.BackColor = SystemColors.InactiveCaptionText;
            lDescription.BorderStyle = BorderStyle.Fixed3D;
            lDescription.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDescription.ForeColor = Color.White;
            lDescription.Location = new Point(14, 121);
            lDescription.Name = "lDescription";
            lDescription.Size = new Size(197, 25);
            lDescription.TabIndex = 7;
            lDescription.Text = "Add a description";
            lDescription.TextAlign = ContentAlignment.TopCenter;
            lDescription.Click += label2_Click;
            // 
            // viewToDo
            // 
            viewToDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewToDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewToDo.Location = new Point(16, 229);
            viewToDo.Name = "viewToDo";
            viewToDo.Size = new Size(885, 304);
            viewToDo.TabIndex = 9;
            // 
            // bSave
            // 
            bSave.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bSave.Location = new Point(683, 183);
            bSave.Name = "bSave";
            bSave.Size = new Size(217, 40);
            bSave.TabIndex = 11;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bEdit
            // 
            bEdit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bEdit.Location = new Point(486, 183);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(173, 40);
            bEdit.TabIndex = 12;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(914, 545);
            Controls.Add(bEdit);
            Controls.Add(bSave);
            Controls.Add(viewToDo);
            Controls.Add(lDescription);
            Controls.Add(tDescription);
            Controls.Add(lAdd);
            Controls.Add(label1);
            Controls.Add(bRemove);
            Controls.Add(bAdd);
            Controls.Add(tTask);
            Controls.Add(Lueberschrift);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ToDo";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)viewToDo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lueberschrift;
        private TextBox tTask;
        private Button bAdd;
        private Button bRemove;
        private Label label1;
        private Label lAdd;
        private TextBox tDescription;
        private Label lDescription;
        private DataGridView viewToDo;
        private Button bSave;
        private Button bEdit;
    }
}
