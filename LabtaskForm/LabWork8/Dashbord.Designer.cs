namespace LabWork8
{
    partial class Dashbord
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
            this.buttonAdduser = new System.Windows.Forms.Button();
            this.buttonDeletwuser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdduser
            // 
            this.buttonAdduser.AccessibleName = "Login";
            this.buttonAdduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAdduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdduser.Location = new System.Drawing.Point(33, 76);
            this.buttonAdduser.Name = "buttonAdduser";
            this.buttonAdduser.Size = new System.Drawing.Size(201, 45);
            this.buttonAdduser.TabIndex = 14;
            this.buttonAdduser.Text = "Add user";
            this.buttonAdduser.UseVisualStyleBackColor = false;
            this.buttonAdduser.Click += new System.EventHandler(this.AppearDashbord2);
            // 
            // buttonDeletwuser
            // 
            this.buttonDeletwuser.AccessibleName = "Delete User";
            this.buttonDeletwuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDeletwuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletwuser.Location = new System.Drawing.Point(254, 76);
            this.buttonDeletwuser.Name = "buttonDeletwuser";
            this.buttonDeletwuser.Size = new System.Drawing.Size(201, 45);
            this.buttonDeletwuser.TabIndex = 15;
            this.buttonDeletwuser.Text = "Delete User";
            this.buttonDeletwuser.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AccessibleName = "Login";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(461, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remove User";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDeletwuser);
            this.Controls.Add(this.buttonAdduser);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdduser;
        private System.Windows.Forms.Button buttonDeletwuser;
        private System.Windows.Forms.Button button2;
    }
}