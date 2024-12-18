namespace DieGewinnerProgramm;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        L_btnlabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // L_btnlabel
        // 
        L_btnlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        L_btnlabel.Location = new System.Drawing.Point(25, 44);
        L_btnlabel.Name = "L_btnlabel";
        L_btnlabel.Size = new System.Drawing.Size(717, 49);
        L_btnlabel.TabIndex = 0;
        L_btnlabel.Text = "Bitte klicken um Temperaturen auzuwerten";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(L_btnlabel);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label L_btnlabel;

    #endregion
}