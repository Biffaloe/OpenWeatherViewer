namespace FlickrViewer
{
   partial class OpenWeatherForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.forecastButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempTextBox
            // 
            this.tempTextBox.Enabled = false;
            this.tempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(266, 15);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(81, 31);
            this.tempTextBox.TabIndex = 0;
            // 
            // forecastButton
            // 
            this.forecastButton.Location = new System.Drawing.Point(266, 52);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(75, 23);
            this.forecastButton.TabIndex = 8;
            this.forecastButton.Text = "Forecast";
            this.forecastButton.UseVisualStyleBackColor = true;
            this.forecastButton.Click += new System.EventHandler(this.forecastButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Temp in Ogden :";
            // 
            // OpenWeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastButton);
            this.Controls.Add(this.tempTextBox);
            this.Name = "OpenWeatherForm";
            this.Text = "Open Weather Viewr";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.Button forecastButton;
        private System.Windows.Forms.Label label1;
    }
}

