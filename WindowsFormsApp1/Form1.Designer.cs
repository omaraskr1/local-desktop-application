
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Display_Multi_rows = new System.Windows.Forms.Button();
            this.Display_Single_row = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_id
            // 
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(237, 80);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(121, 24);
            this.cmb_id.TabIndex = 0;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(169, 80);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 17);
            this.id.TabIndex = 1;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(158, 155);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 17);
            this.name.TabIndex = 5;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(172, 239);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 36);
            this.Insert.TabIndex = 9;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Display_Multi_rows
            // 
            this.Display_Multi_rows.Location = new System.Drawing.Point(306, 239);
            this.Display_Multi_rows.Name = "Display_Multi_rows";
            this.Display_Multi_rows.Size = new System.Drawing.Size(169, 36);
            this.Display_Multi_rows.TabIndex = 10;
            this.Display_Multi_rows.Text = "Display_Multi_rows";
            this.Display_Multi_rows.UseVisualStyleBackColor = true;
            this.Display_Multi_rows.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Display_Single_row
            // 
            this.Display_Single_row.Location = new System.Drawing.Point(515, 239);
            this.Display_Single_row.Name = "Display_Single_row";
            this.Display_Single_row.Size = new System.Drawing.Size(157, 36);
            this.Display_Single_row.TabIndex = 11;
            this.Display_Single_row.Text = "Display single Row";
            this.Display_Single_row.UseVisualStyleBackColor = true;
            this.Display_Single_row.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(515, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 97);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "view data";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Display_Single_row);
            this.Controls.Add(this.Display_Multi_rows);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cmb_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Formclosing);
            this.Load += new System.EventHandler(this.Form1_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Display_Multi_rows;
        private System.Windows.Forms.Button Display_Single_row;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}

