namespace XMLForm
{
    partial class Form1
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
            ListViewItem listViewItem7 = new ListViewItem("Title");
            ListViewItem listViewItem8 = new ListViewItem("Artist");
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "Country" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 7.5F));
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Company" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 7F));
            ListViewItem listViewItem11 = new ListViewItem("Price");
            ListViewItem listViewItem12 = new ListViewItem("Year");
            txtCD = new TextBox();
            btnShowCD = new Button();
            LstvCD = new ListView();
            columnHeader1 = new ColumnHeader();
            btnListView = new Button();
            SuspendLayout();
            // 
            // txtCD
            // 
            txtCD.Location = new Point(29, 75);
            txtCD.Multiline = true;
            txtCD.Name = "txtCD";
            txtCD.ReadOnly = true;
            txtCD.ScrollBars = ScrollBars.Vertical;
            txtCD.Size = new Size(362, 259);
            txtCD.TabIndex = 0;
            // 
            // btnShowCD
            // 
            btnShowCD.Location = new Point(162, 37);
            btnShowCD.Name = "btnShowCD";
            btnShowCD.Size = new Size(75, 23);
            btnShowCD.TabIndex = 1;
            btnShowCD.Text = "Show CDs";
            btnShowCD.UseVisualStyleBackColor = true;
            btnShowCD.Click += btnShowCD_Click;
            // 
            // LstvCD
            // 
            LstvCD.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            LstvCD.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            LstvCD.Location = new Point(406, 75);
            LstvCD.Name = "LstvCD";
            LstvCD.Size = new Size(425, 259);
            LstvCD.TabIndex = 2;
            LstvCD.UseCompatibleStateImageBehavior = false;
            LstvCD.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnListView
            // 
            btnListView.Location = new Point(576, 25);
            btnListView.Name = "btnListView";
            btnListView.RightToLeft = RightToLeft.No;
            btnListView.Size = new Size(75, 23);
            btnListView.TabIndex = 3;
            btnListView.Text = "List View";
            btnListView.UseVisualStyleBackColor = true;
            btnListView.Click += btnListView_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 476);
            Controls.Add(btnListView);
            Controls.Add(LstvCD);
            Controls.Add(btnShowCD);
            Controls.Add(txtCD);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCD;
        private Button btnShowCD;
        private ListView LstvCD;
        private ColumnHeader columnHeader1;
        private Button btnListView;
    }
}
