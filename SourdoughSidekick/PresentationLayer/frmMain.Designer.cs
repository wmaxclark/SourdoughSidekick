namespace PresentationLayer
{
    partial class frmMain
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
            this.lstBakes = new System.Windows.Forms.ListBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnRecalculate = new System.Windows.Forms.Button();
            this.txtFlour = new System.Windows.Forms.TextBox();
            this.txtSalt = new System.Windows.Forms.TextBox();
            this.txtYeast = new System.Windows.Forms.TextBox();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.lblBakes = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblBakingInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFlourUnits = new System.Windows.Forms.TextBox();
            this.lblSaltUnits = new System.Windows.Forms.TextBox();
            this.lblYeastUnits = new System.Windows.Forms.TextBox();
            this.lblWaterUnits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBakes
            // 
            this.lstBakes.FormattingEnabled = true;
            this.lstBakes.Location = new System.Drawing.Point(12, 57);
            this.lstBakes.Name = "lstBakes";
            this.lstBakes.Size = new System.Drawing.Size(224, 342);
            this.lstBakes.TabIndex = 1;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(512, 57);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(276, 337);
            this.txtInstructions.TabIndex = 2;
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecalculate.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecalculate.Location = new System.Drawing.Point(242, 350);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(263, 44);
            this.btnRecalculate.TabIndex = 7;
            this.btnRecalculate.Text = "Recalculate";
            this.btnRecalculate.UseVisualStyleBackColor = true;
            this.btnRecalculate.Click += new System.EventHandler(this.btnRecalculate_Click);
            // 
            // txtFlour
            // 
            this.txtFlour.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlour.Location = new System.Drawing.Point(319, 74);
            this.txtFlour.Multiline = true;
            this.txtFlour.Name = "txtFlour";
            this.txtFlour.Size = new System.Drawing.Size(112, 47);
            this.txtFlour.TabIndex = 8;
            this.txtFlour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalt
            // 
            this.txtSalt.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalt.Location = new System.Drawing.Point(319, 127);
            this.txtSalt.Multiline = true;
            this.txtSalt.Name = "txtSalt";
            this.txtSalt.Size = new System.Drawing.Size(112, 44);
            this.txtSalt.TabIndex = 9;
            this.txtSalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYeast
            // 
            this.txtYeast.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeast.Location = new System.Drawing.Point(319, 177);
            this.txtYeast.Multiline = true;
            this.txtYeast.Name = "txtYeast";
            this.txtYeast.Size = new System.Drawing.Size(112, 44);
            this.txtYeast.TabIndex = 10;
            this.txtYeast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWater
            // 
            this.txtWater.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWater.Location = new System.Drawing.Point(319, 227);
            this.txtWater.Multiline = true;
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(112, 44);
            this.txtWater.TabIndex = 11;
            this.txtWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBakes
            // 
            this.lblBakes.AutoSize = true;
            this.lblBakes.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakes.Location = new System.Drawing.Point(33, 29);
            this.lblBakes.Name = "lblBakes";
            this.lblBakes.Size = new System.Drawing.Size(152, 25);
            this.lblBakes.TabIndex = 14;
            this.lblBakes.Text = "Previous Bakes";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(314, 28);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(117, 25);
            this.lblIngredients.TabIndex = 15;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblBakingInstructions
            // 
            this.lblBakingInstructions.AutoSize = true;
            this.lblBakingInstructions.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakingInstructions.Location = new System.Drawing.Point(562, 29);
            this.lblBakingInstructions.Name = "lblBakingInstructions";
            this.lblBakingInstructions.Size = new System.Drawing.Size(191, 25);
            this.lblBakingInstructions.TabIndex = 16;
            this.lblBakingInstructions.Text = "Baking Instructions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Flour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Salt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yeast";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Water";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFlourUnits
            // 
            this.lblFlourUnits.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlourUnits.Location = new System.Drawing.Point(437, 74);
            this.lblFlourUnits.Multiline = true;
            this.lblFlourUnits.Name = "lblFlourUnits";
            this.lblFlourUnits.ReadOnly = true;
            this.lblFlourUnits.Size = new System.Drawing.Size(68, 47);
            this.lblFlourUnits.TabIndex = 21;
            this.lblFlourUnits.Text = "(g)";
            this.lblFlourUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSaltUnits
            // 
            this.lblSaltUnits.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltUnits.Location = new System.Drawing.Point(437, 127);
            this.lblSaltUnits.Multiline = true;
            this.lblSaltUnits.Name = "lblSaltUnits";
            this.lblSaltUnits.ReadOnly = true;
            this.lblSaltUnits.Size = new System.Drawing.Size(68, 44);
            this.lblSaltUnits.TabIndex = 22;
            this.lblSaltUnits.Text = "(g)";
            this.lblSaltUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYeastUnits
            // 
            this.lblYeastUnits.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYeastUnits.Location = new System.Drawing.Point(437, 177);
            this.lblYeastUnits.Multiline = true;
            this.lblYeastUnits.Name = "lblYeastUnits";
            this.lblYeastUnits.ReadOnly = true;
            this.lblYeastUnits.Size = new System.Drawing.Size(68, 44);
            this.lblYeastUnits.TabIndex = 23;
            this.lblYeastUnits.Text = "Starter (g)";
            this.lblYeastUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWaterUnits
            // 
            this.lblWaterUnits.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterUnits.Location = new System.Drawing.Point(437, 227);
            this.lblWaterUnits.Multiline = true;
            this.lblWaterUnits.Name = "lblWaterUnits";
            this.lblWaterUnits.ReadOnly = true;
            this.lblWaterUnits.Size = new System.Drawing.Size(68, 44);
            this.lblWaterUnits.TabIndex = 24;
            this.lblWaterUnits.Text = "(g)";
            this.lblWaterUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.lblWaterUnits);
            this.Controls.Add(this.lblYeastUnits);
            this.Controls.Add(this.lblSaltUnits);
            this.Controls.Add(this.lblFlourUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBakingInstructions);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblBakes);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.txtYeast);
            this.Controls.Add(this.txtSalt);
            this.Controls.Add(this.txtFlour);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lstBakes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.Text = "Sourdough Sidekick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstBakes;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnRecalculate;
        private System.Windows.Forms.TextBox txtFlour;
        private System.Windows.Forms.TextBox txtSalt;
        private System.Windows.Forms.TextBox txtYeast;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Label lblBakes;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblBakingInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblFlourUnits;
        private System.Windows.Forms.TextBox lblSaltUnits;
        private System.Windows.Forms.TextBox lblYeastUnits;
        private System.Windows.Forms.TextBox lblWaterUnits;
    }
}

