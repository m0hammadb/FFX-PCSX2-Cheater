namespace FFX_PCSX2_Cheater
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
            btnRandomInventoryStarter = new Button();
            btnCancelScenario = new Button();
            SuspendLayout();
            // 
            // btnRandomInventoryStarter
            // 
            btnRandomInventoryStarter.Location = new Point(12, 21);
            btnRandomInventoryStarter.Name = "btnRandomInventoryStarter";
            btnRandomInventoryStarter.Size = new Size(301, 23);
            btnRandomInventoryStarter.TabIndex = 0;
            btnRandomInventoryStarter.Text = "Random Inventory";
            btnRandomInventoryStarter.UseVisualStyleBackColor = true;
            btnRandomInventoryStarter.Click += btnRandomInventoryStarter_Click;
            // 
            // btnCancelScenario
            // 
            btnCancelScenario.Enabled = false;
            btnCancelScenario.Location = new Point(12, 168);
            btnCancelScenario.Name = "btnCancelScenario";
            btnCancelScenario.Size = new Size(301, 25);
            btnCancelScenario.TabIndex = 1;
            btnCancelScenario.Text = "Cancel Scenario";
            btnCancelScenario.UseVisualStyleBackColor = true;
            btnCancelScenario.Click += btnCancelScenario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 205);
            Controls.Add(btnCancelScenario);
            Controls.Add(btnRandomInventoryStarter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "FFX Custom Scenarios";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRandomInventoryStarter;
        private Button btnCancelScenario;
    }
}