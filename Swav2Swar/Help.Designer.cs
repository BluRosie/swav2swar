namespace Swav2Swar
{
	public partial class Help : global::System.Windows.Forms.Form
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00006F20 File Offset: 0x00005320
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006F60 File Offset: 0x00005360
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Swav2Swar.Help));
			this.Texto = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Creditos = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Texto.AutoSize = true;
			global::System.Windows.Forms.Control texto = this.Texto;
			global::System.Drawing.Point location = new global::System.Drawing.Point(18, 34);
			texto.Location = location;
			this.Texto.Name = "Texto";
			global::System.Windows.Forms.Control texto2 = this.Texto;
			global::System.Drawing.Size size = new global::System.Drawing.Size(16, 13);
			texto2.Size = size;
			this.Texto.TabIndex = 0;
			this.Texto.Text = "...";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(12, 9);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(100, 13);
			label2.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "INSTRUCTIONS";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(12, 141);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(61, 13);
			label4.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "CREDITS";
			this.Creditos.AutoSize = true;
			global::System.Windows.Forms.Control creditos = this.Creditos;
			location = new global::System.Drawing.Point(18, 167);
			creditos.Location = location;
			this.Creditos.Name = "Creditos";
			global::System.Windows.Forms.Control creditos2 = this.Creditos;
			size = new global::System.Drawing.Size(16, 13);
			creditos2.Size = size;
			this.Creditos.TabIndex = 3;
			this.Creditos.Text = "...";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(344, 220);
			this.ClientSize = size;
			this.Controls.Add(this.Creditos);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Texto);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Help";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Help & Credits";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400002D RID: 45
		private global::System.ComponentModel.IContainer components;
	}
}
