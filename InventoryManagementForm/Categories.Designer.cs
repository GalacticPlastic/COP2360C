
namespace InventoryManagementForm
{
    partial class Categories
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnAddConfirm = new System.Windows.Forms.Button();
            this.lblAddMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxAddName = new System.Windows.Forms.TextBox();
            this.tabModify = new System.Windows.Forms.TabPage();
            this.btnModifyUpdate = new System.Windows.Forms.Button();
            this.lblModifyMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxModifyName = new System.Windows.Forms.TextBox();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btnDeleteConfirm = new System.Windows.Forms.Button();
            this.lblDeleteMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDeleteName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabModify.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(184, 332);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(53, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(53, 145);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabModify);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Location = new System.Drawing.Point(190, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 332);
            this.tabControl1.TabIndex = 8;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btnAddConfirm);
            this.tabAdd.Controls.Add(this.lblAddMsg);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.txtBoxAddName);
            this.tabAdd.Location = new System.Drawing.Point(4, 24);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(401, 304);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddConfirm
            // 
            this.btnAddConfirm.Location = new System.Drawing.Point(137, 137);
            this.btnAddConfirm.Name = "btnAddConfirm";
            this.btnAddConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnAddConfirm.TabIndex = 7;
            this.btnAddConfirm.Text = "Confirm";
            this.btnAddConfirm.UseVisualStyleBackColor = true;
            this.btnAddConfirm.Click += new System.EventHandler(this.btnAddConfirm_Click);
            // 
            // lblAddMsg
            // 
            this.lblAddMsg.AutoSize = true;
            this.lblAddMsg.Location = new System.Drawing.Point(12, 284);
            this.lblAddMsg.Name = "lblAddMsg";
            this.lblAddMsg.Size = new System.Drawing.Size(69, 15);
            this.lblAddMsg.TabIndex = 2;
            this.lblAddMsg.Text = "<Message>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name:";
            // 
            // txtBoxAddName
            // 
            this.txtBoxAddName.Location = new System.Drawing.Point(128, 56);
            this.txtBoxAddName.Name = "txtBoxAddName";
            this.txtBoxAddName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxAddName.TabIndex = 0;
            // 
            // tabModify
            // 
            this.tabModify.Controls.Add(this.btnModifyUpdate);
            this.tabModify.Controls.Add(this.lblModifyMsg);
            this.tabModify.Controls.Add(this.label2);
            this.tabModify.Controls.Add(this.txtBoxModifyName);
            this.tabModify.Location = new System.Drawing.Point(4, 24);
            this.tabModify.Name = "tabModify";
            this.tabModify.Padding = new System.Windows.Forms.Padding(3);
            this.tabModify.Size = new System.Drawing.Size(401, 304);
            this.tabModify.TabIndex = 1;
            this.tabModify.Text = "Modify";
            this.tabModify.UseVisualStyleBackColor = true;
            // 
            // btnModifyUpdate
            // 
            this.btnModifyUpdate.Location = new System.Drawing.Point(150, 141);
            this.btnModifyUpdate.Name = "btnModifyUpdate";
            this.btnModifyUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnModifyUpdate.TabIndex = 7;
            this.btnModifyUpdate.Text = "Update";
            this.btnModifyUpdate.UseVisualStyleBackColor = true;
            this.btnModifyUpdate.Click += new System.EventHandler(this.btnModifyUpdate_Click);
            // 
            // lblModifyMsg
            // 
            this.lblModifyMsg.AutoSize = true;
            this.lblModifyMsg.Location = new System.Drawing.Point(12, 284);
            this.lblModifyMsg.Name = "lblModifyMsg";
            this.lblModifyMsg.Size = new System.Drawing.Size(69, 15);
            this.lblModifyMsg.TabIndex = 4;
            this.lblModifyMsg.Text = "<Message>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name:";
            // 
            // txtBoxModifyName
            // 
            this.txtBoxModifyName.Location = new System.Drawing.Point(139, 71);
            this.txtBoxModifyName.Name = "txtBoxModifyName";
            this.txtBoxModifyName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxModifyName.TabIndex = 2;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btnDeleteConfirm);
            this.tabDelete.Controls.Add(this.lblDeleteMsg);
            this.tabDelete.Controls.Add(this.label5);
            this.tabDelete.Controls.Add(this.label3);
            this.tabDelete.Controls.Add(this.txtBoxDeleteName);
            this.tabDelete.Location = new System.Drawing.Point(4, 24);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(401, 304);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteConfirm
            // 
            this.btnDeleteConfirm.Location = new System.Drawing.Point(163, 141);
            this.btnDeleteConfirm.Name = "btnDeleteConfirm";
            this.btnDeleteConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteConfirm.TabIndex = 7;
            this.btnDeleteConfirm.Text = "Confirm";
            this.btnDeleteConfirm.UseVisualStyleBackColor = true;
            this.btnDeleteConfirm.Click += new System.EventHandler(this.btnDeleteConfirm_Click);
            // 
            // lblDeleteMsg
            // 
            this.lblDeleteMsg.AutoSize = true;
            this.lblDeleteMsg.Location = new System.Drawing.Point(14, 284);
            this.lblDeleteMsg.Name = "lblDeleteMsg";
            this.lblDeleteMsg.Size = new System.Drawing.Size(69, 15);
            this.lblDeleteMsg.TabIndex = 5;
            this.lblDeleteMsg.Text = "<Message>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category Name:";
            // 
            // txtBoxDeleteName
            // 
            this.txtBoxDeleteName.Location = new System.Drawing.Point(156, 83);
            this.txtBoxDeleteName.Name = "txtBoxDeleteName";
            this.txtBoxDeleteName.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDeleteName.TabIndex = 2;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 332);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.splitter1);
            this.Name = "Categories";
            this.Text = "Categories";
            this.tabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabModify.ResumeLayout(false);
            this.tabModify.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAddName;
        private System.Windows.Forms.TabPage tabModify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxModifyName;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDeleteName;
        private System.Windows.Forms.Label lblAddMsg;
        private System.Windows.Forms.Label lblModifyMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDeleteMsg;
        private System.Windows.Forms.Button btnAddConfirm;
        private System.Windows.Forms.Button btnDeleteConfirm;
        private System.Windows.Forms.Button btnModifyUpdate;
    }
}