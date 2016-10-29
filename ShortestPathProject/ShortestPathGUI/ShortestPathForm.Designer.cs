namespace ShortestPath
{
    partial class ShortestPathForm
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
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.ListBox();
            this.lblWSum = new System.Windows.Forms.Label();
            this.tbWSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbStart
            // 
            this.cbStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(101, 6);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(121, 21);
            this.cbStart.TabIndex = 1;
            this.cbStart.SelectedIndexChanged += new System.EventHandler(this.cbStart_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Početno mjesto:";
            // 
            // cbEnd
            // 
            this.cbEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(396, 6);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(121, 21);
            this.cbEnd.TabIndex = 1;
            this.cbEnd.SelectedIndexChanged += new System.EventHandler(this.cbEnd_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Završno mjesto:";
            // 
            // lbPath
            // 
            this.lbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPath.FormattingEnabled = true;
            this.lbPath.Location = new System.Drawing.Point(15, 43);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(502, 95);
            this.lbPath.TabIndex = 3;
            // 
            // lblWSum
            // 
            this.lblWSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWSum.AutoSize = true;
            this.lblWSum.Location = new System.Drawing.Point(15, 145);
            this.lblWSum.Name = "lblWSum";
            this.lblWSum.Size = new System.Drawing.Size(67, 13);
            this.lblWSum.TabIndex = 4;
            this.lblWSum.Text = "Dužina puta:";
            this.lblWSum.Visible = false;
            // 
            // tbWSum
            // 
            this.tbWSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWSum.Location = new System.Drawing.Point(101, 142);
            this.tbWSum.Name = "tbWSum";
            this.tbWSum.ReadOnly = true;
            this.tbWSum.Size = new System.Drawing.Size(121, 20);
            this.tbWSum.TabIndex = 5;
            this.tbWSum.Visible = false;
            // 
            // ShortestPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 172);
            this.Controls.Add(this.tbWSum);
            this.Controls.Add(this.lblWSum);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStart);
            this.Name = "ShortestPathForm";
            this.Text = "Najkraći put";
            this.Load += new System.EventHandler(this.ShortestPathForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPath;
        private System.Windows.Forms.Label lblWSum;
        private System.Windows.Forms.TextBox tbWSum;
    }
}

