﻿namespace CMPG223_Project
{
    partial class rentalOrder
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
            tabPage2 = new TabPage();
            label17 = new Label();
            textBoxOrderUpdate = new TextBox();
            textBoxSearchUpdate = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label13 = new Label();
            checkBoxUpdate = new CheckBox();
            dataGridViewUpdate = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label15 = new Label();
            tabPage1 = new TabPage();
            textBoxSearchAdd = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label21 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            checkBoxAdd = new CheckBox();
            label7 = new Label();
            dataGridViewAdd = new DataGridView();
            buttonBack = new Button();
            buttonClear = new Button();
            buttonCreate = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            label18 = new Label();
            textBoxReturnOrder = new TextBox();
            textBoxReturnSearch = new TextBox();
            label11 = new Label();
            label12 = new Label();
            dataGridViewReturn = new DataGridView();
            button4 = new Button();
            buttonClearReturn = new Button();
            buttonUpdateReturn = new Button();
            label16 = new Label();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdate).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdd).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturn).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(188, 170, 148);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(textBoxOrderUpdate);
            tabPage2.Controls.Add(textBoxSearchUpdate);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(checkBoxUpdate);
            tabPage2.Controls.Add(dataGridViewUpdate);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label15);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1145, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Make Payment";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(299, 57);
            label17.Name = "label17";
            label17.Size = new Size(280, 37);
            label17.TabIndex = 46;
            label17.Text = "Please Select an Order";
            label17.Visible = false;
            // 
            // textBoxOrderUpdate
            // 
            textBoxOrderUpdate.Enabled = false;
            textBoxOrderUpdate.Location = new Point(117, 67);
            textBoxOrderUpdate.Margin = new Padding(3, 4, 3, 4);
            textBoxOrderUpdate.Name = "textBoxOrderUpdate";
            textBoxOrderUpdate.ReadOnly = true;
            textBoxOrderUpdate.Size = new Size(175, 27);
            textBoxOrderUpdate.TabIndex = 45;
            // 
            // textBoxSearchUpdate
            // 
            textBoxSearchUpdate.Location = new Point(896, 16);
            textBoxSearchUpdate.Margin = new Padding(3, 4, 3, 4);
            textBoxSearchUpdate.Name = "textBoxSearchUpdate";
            textBoxSearchUpdate.Size = new Size(201, 27);
            textBoxSearchUpdate.TabIndex = 43;
            textBoxSearchUpdate.TextChanged += textBoxSearchUpdate_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label23.Location = new Point(3, 55);
            label23.Name = "label23";
            label23.Size = new Size(109, 41);
            label23.TabIndex = 44;
            label23.Text = "Order:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(667, 4);
            label22.Name = "label22";
            label22.Size = new Size(222, 41);
            label22.TabIndex = 42;
            label22.Text = "Search Orders:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 101);
            label13.Name = "label13";
            label13.Size = new Size(177, 41);
            label13.TabIndex = 39;
            label13.Text = "Order Paid:";
            // 
            // checkBoxUpdate
            // 
            checkBoxUpdate.AutoSize = true;
            checkBoxUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxUpdate.Location = new Point(182, 100);
            checkBoxUpdate.Margin = new Padding(3, 4, 3, 4);
            checkBoxUpdate.Name = "checkBoxUpdate";
            checkBoxUpdate.Size = new Size(96, 45);
            checkBoxUpdate.TabIndex = 27;
            checkBoxUpdate.Text = "Paid";
            checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUpdate
            // 
            dataGridViewUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdate.Location = new Point(623, 51);
            dataGridViewUpdate.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUpdate.Name = "dataGridViewUpdate";
            dataGridViewUpdate.RowHeadersWidth = 51;
            dataGridViewUpdate.Size = new Size(509, 347);
            dataGridViewUpdate.TabIndex = 23;
            dataGridViewUpdate.CellClick += dataGridViewUpdate_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(1013, 420);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 57);
            button1.TabIndex = 33;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(819, 420);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(119, 57);
            button2.TabIndex = 30;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(623, 420);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(119, 57);
            button3.TabIndex = 29;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(-1, 1);
            label15.Name = "label15";
            label15.Size = new Size(542, 50);
            label15.TabIndex = 36;
            label15.Text = "Update Rental Order Payment";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(188, 170, 146);
            tabPage1.Controls.Add(textBoxSearchAdd);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(checkBoxAdd);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(dataGridViewAdd);
            tabPage1.Controls.Add(buttonBack);
            tabPage1.Controls.Add(buttonClear);
            tabPage1.Controls.Add(buttonCreate);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1145, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Order";
            // 
            // textBoxSearchAdd
            // 
            textBoxSearchAdd.Location = new Point(895, 13);
            textBoxSearchAdd.Margin = new Padding(3, 4, 3, 4);
            textBoxSearchAdd.Name = "textBoxSearchAdd";
            textBoxSearchAdd.Size = new Size(201, 27);
            textBoxSearchAdd.TabIndex = 23;
            textBoxSearchAdd.TextChanged += textBoxSearchAdd_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(117, 136);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(178, 237);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(666, 1);
            label21.Name = "label21";
            label21.Size = new Size(240, 41);
            label21.TabIndex = 22;
            label21.Text = "Search Vehicles:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(299, 127);
            label10.Name = "label10";
            label10.Size = new Size(281, 37);
            label10.TabIndex = 21;
            label10.Text = "Please Select a Vehicle";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(299, 71);
            label9.Name = "label9";
            label9.Size = new Size(266, 37);
            label9.TabIndex = 20;
            label9.Text = "Please Select a Client";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 273);
            label8.Name = "label8";
            label8.Size = new Size(177, 41);
            label8.TabIndex = 19;
            label8.Text = "Order Paid:";
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAdd.Location = new Point(178, 272);
            checkBoxAdd.Margin = new Padding(3, 4, 3, 4);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(96, 45);
            checkBoxAdd.TabIndex = 5;
            checkBoxAdd.Text = "Paid";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(299, 225);
            label7.Name = "label7";
            label7.Size = new Size(319, 37);
            label7.TabIndex = 18;
            label7.Text = "Please Select a Valid Date";
            label7.Visible = false;
            // 
            // dataGridViewAdd
            // 
            dataGridViewAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdd.Location = new Point(622, 48);
            dataGridViewAdd.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAdd.Name = "dataGridViewAdd";
            dataGridViewAdd.RowHeadersWidth = 51;
            dataGridViewAdd.Size = new Size(510, 347);
            dataGridViewAdd.TabIndex = 2;
            dataGridViewAdd.CellClick += dataGridView1_CellClick;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(1013, 428);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(119, 57);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(822, 428);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(119, 57);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(622, 428);
            buttonCreate.Margin = new Padding(3, 4, 3, 4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(119, 57);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(-5, 4);
            label6.Name = "label6";
            label6.Size = new Size(365, 50);
            label6.TabIndex = 11;
            label6.Text = "Create Rental Order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 225);
            label5.Name = "label5";
            label5.Size = new Size(186, 41);
            label5.TabIndex = 9;
            label5.Text = "Order Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(339, 181);
            label4.Name = "label4";
            label4.Size = new Size(84, 41);
            label4.TabIndex = 8;
            label4.Text = "until";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(0, 180);
            label3.Name = "label3";
            label3.Size = new Size(168, 41);
            label3.TabIndex = 7;
            label3.Text = "Rent from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(0, 124);
            label2.Name = "label2";
            label2.Size = new Size(126, 41);
            label2.TabIndex = 6;
            label2.Text = "Vehicle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 71);
            label1.Name = "label1";
            label1.Size = new Size(109, 41);
            label1.TabIndex = 5;
            label1.Text = "Client:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(423, 191);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.MinDate = new DateTime(2024, 8, 31, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(170, 27);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Value = new DateTime(2024, 8, 31, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(162, 191);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.MinDate = new DateTime(2024, 8, 27, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 83);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 28);
            comboBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1153, 656);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(188, 170, 148);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(textBoxReturnOrder);
            tabPage3.Controls.Add(textBoxReturnSearch);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(dataGridViewReturn);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(buttonClearReturn);
            tabPage3.Controls.Add(buttonUpdateReturn);
            tabPage3.Controls.Add(label16);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1145, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Return Vehicle";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(303, 60);
            label18.Name = "label18";
            label18.Size = new Size(280, 37);
            label18.TabIndex = 57;
            label18.Text = "Please Select an Order";
            label18.Visible = false;
            // 
            // textBoxReturnOrder
            // 
            textBoxReturnOrder.Location = new Point(120, 69);
            textBoxReturnOrder.Margin = new Padding(3, 4, 3, 4);
            textBoxReturnOrder.Name = "textBoxReturnOrder";
            textBoxReturnOrder.ReadOnly = true;
            textBoxReturnOrder.Size = new Size(175, 27);
            textBoxReturnOrder.TabIndex = 56;
            // 
            // textBoxReturnSearch
            // 
            textBoxReturnSearch.Location = new Point(901, 19);
            textBoxReturnSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxReturnSearch.Name = "textBoxReturnSearch";
            textBoxReturnSearch.Size = new Size(201, 27);
            textBoxReturnSearch.TabIndex = 54;
            textBoxReturnSearch.TextChanged += textBoxReturnSearch_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.Location = new Point(7, 57);
            label11.Name = "label11";
            label11.Size = new Size(109, 41);
            label11.TabIndex = 55;
            label11.Text = "Order:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(672, 7);
            label12.Name = "label12";
            label12.Size = new Size(222, 41);
            label12.TabIndex = 53;
            label12.Text = "Search Orders:";
            // 
            // dataGridViewReturn
            // 
            dataGridViewReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReturn.Location = new Point(627, 53);
            dataGridViewReturn.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReturn.Name = "dataGridViewReturn";
            dataGridViewReturn.RowHeadersWidth = 51;
            dataGridViewReturn.Size = new Size(509, 347);
            dataGridViewReturn.TabIndex = 46;
            dataGridViewReturn.CellClick += dataGridViewReturn_CellClick;
            // 
            // button4
            // 
            button4.Location = new Point(1017, 423);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(119, 57);
            button4.TabIndex = 50;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonClearReturn
            // 
            buttonClearReturn.Location = new Point(825, 423);
            buttonClearReturn.Margin = new Padding(3, 4, 3, 4);
            buttonClearReturn.Name = "buttonClearReturn";
            buttonClearReturn.Size = new Size(119, 57);
            buttonClearReturn.TabIndex = 49;
            buttonClearReturn.Text = "Clear";
            buttonClearReturn.UseVisualStyleBackColor = true;
            buttonClearReturn.Click += buttonClearReturn_Click;
            // 
            // buttonUpdateReturn
            // 
            buttonUpdateReturn.Location = new Point(627, 423);
            buttonUpdateReturn.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateReturn.Name = "buttonUpdateReturn";
            buttonUpdateReturn.Size = new Size(119, 57);
            buttonUpdateReturn.TabIndex = 48;
            buttonUpdateReturn.Text = "Vehicle Returned";
            buttonUpdateReturn.UseVisualStyleBackColor = true;
            buttonUpdateReturn.Click += buttonUpdateReturn_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 4);
            label16.Name = "label16";
            label16.Size = new Size(303, 50);
            label16.TabIndex = 51;
            label16.Text = "Return a Vehicle";
            // 
            // rentalOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1152, 660);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "rentalOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rentalOrder";
            Load += rentalOrder_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdate).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdd).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TextBox textBoxOrderUpdate;
        private TextBox textBoxSearchUpdate;
        private Label label23;
        private Label label22;
        private Label label13;
        private CheckBox checkBoxUpdate;
        private DataGridView dataGridViewUpdate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label15;
        private TabPage tabPage1;
        private TextBox textBoxSearchAdd;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label21;
        private Label label10;
        private Label label9;
        private Label label8;
        private CheckBox checkBoxAdd;
        private Label label7;
        private DataGridView dataGridViewAdd;
        private Button buttonBack;
        private Button buttonClear;
        private Button buttonCreate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TextBox textBoxReturnOrder;
        private TextBox textBoxReturnSearch;
        private Label label11;
        private Label label12;
        private DataGridView dataGridViewReturn;
        private Button button4;
        private Button buttonClearReturn;
        private Button buttonUpdateReturn;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}