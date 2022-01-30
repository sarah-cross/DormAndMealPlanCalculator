namespace DormAndMealPlanCalculator
{
    partial class TotalCharges
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
            this.listBoxTotalCharges = new System.Windows.Forms.ListBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTotalCharges
            // 
            this.listBoxTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTotalCharges.FormattingEnabled = true;
            this.listBoxTotalCharges.ItemHeight = 16;
            this.listBoxTotalCharges.Location = new System.Drawing.Point(74, 55);
            this.listBoxTotalCharges.Name = "listBoxTotalCharges";
            this.listBoxTotalCharges.Size = new System.Drawing.Size(339, 132);
            this.listBoxTotalCharges.TabIndex = 0;
            this.listBoxTotalCharges.SelectedIndexChanged += new System.EventHandler(this.listBoxTotalCharges_SelectedIndexChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(74, 223);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(88, 54);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(181, 223);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(95, 54);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change Selection";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // TotalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 570);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxTotalCharges);
            this.Name = "TotalCharges";
            this.Text = "TotalCharges";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonChange;
        public System.Windows.Forms.ListBox listBoxTotalCharges;
    }
}