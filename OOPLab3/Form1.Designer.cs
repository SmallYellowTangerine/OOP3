namespace OOPLab3
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
            this.objectsList = new System.Windows.Forms.ListBox();
            this.objectsBox = new System.Windows.Forms.ComboBox();
            this.addObject = new System.Windows.Forms.Button();
            this.deleteObject = new System.Windows.Forms.Button();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.propertyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // objectsList
            // 
            this.objectsList.FormattingEnabled = true;
            this.objectsList.Location = new System.Drawing.Point(12, 12);
            this.objectsList.Name = "objectsList";
            this.objectsList.Size = new System.Drawing.Size(120, 95);
            this.objectsList.TabIndex = 0;
            // 
            // objectsBox
            // 
            this.objectsBox.FormattingEnabled = true;
            this.objectsBox.Items.AddRange(new object[] {
            "Fiction",
            "NonFiction",
            "Fantasy",
            "ScienceFiction",
            "MagicRealism",
            "Biography"});
            this.objectsBox.Location = new System.Drawing.Point(151, 12);
            this.objectsBox.Name = "objectsBox";
            this.objectsBox.Size = new System.Drawing.Size(121, 21);
            this.objectsBox.TabIndex = 1;
            // 
            // addObject
            // 
            this.addObject.Location = new System.Drawing.Point(154, 39);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(118, 23);
            this.addObject.TabIndex = 2;
            this.addObject.Text = "Add object";
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // deleteObject
            // 
            this.deleteObject.Location = new System.Drawing.Point(24, 113);
            this.deleteObject.Name = "deleteObject";
            this.deleteObject.Size = new System.Drawing.Size(99, 23);
            this.deleteObject.TabIndex = 3;
            this.deleteObject.Text = "Delete object";
            this.deleteObject.UseVisualStyleBackColor = true;
            this.deleteObject.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // Serialize
            // 
            this.Serialize.Location = new System.Drawing.Point(91, 239);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(102, 49);
            this.Serialize.TabIndex = 7;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.Location = new System.Drawing.Point(91, 372);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(102, 49);
            this.Deserialize.TabIndex = 8;
            this.Deserialize.Text = "Deserialize";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 69);
            this.listBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edit property";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // propertyList
            // 
            this.propertyList.FormattingEnabled = true;
            this.propertyList.Location = new System.Drawing.Point(154, 128);
            this.propertyList.Name = "propertyList";
            this.propertyList.Size = new System.Drawing.Size(120, 95);
            this.propertyList.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 431);
            this.Controls.Add(this.propertyList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.deleteObject);
            this.Controls.Add(this.addObject);
            this.Controls.Add(this.objectsBox);
            this.Controls.Add(this.objectsList);
            this.Name = "Form1";
            this.Text = "z";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox objectsList;
        private System.Windows.Forms.ComboBox objectsBox;
        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.Button deleteObject;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox propertyList;
    }
}

