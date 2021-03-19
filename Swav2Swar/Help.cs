using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Swav2Swar
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class Help : Form
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00006EFC File Offset: 0x000052FC
		[DebuggerNonUserCode]
		public Help()
		{
			base.Load += this.Help_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00007258 File Offset: 0x00005658
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000726C File Offset: 0x0000566C
		internal virtual Label Texto
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Texto;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Texto = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00007278 File Offset: 0x00005678
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000728C File Offset: 0x0000568C
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007298 File Offset: 0x00005698
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000072AC File Offset: 0x000056AC
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000072B8 File Offset: 0x000056B8
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000072CC File Offset: 0x000056CC
		internal virtual Label Creditos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Creditos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Creditos = value;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000072D8 File Offset: 0x000056D8
		private void Help_Load(object sender, EventArgs e)
		{
			this.Texto.Text = "1. Add files with 'Add' button or Drag & Drop directly to the list\r\n\r\n";
			Label label = this.Texto;
			label.Text += "2. Move up and down files as you wish with arrows buttons.\r\n";
			label = this.Texto;
			label.Text += "    You can also delete file from list with 'Supr' key.\r\n\r\n";
			label = this.Texto;
			label.Text += "3. Press 'Create SWAR' button. It'll create ONE swar file\r\n";
			label = this.Texto;
			label.Text += "    which contains all swav files from list in order.\r\n\r\n";
			this.Creditos.Text = "Swav2Swar Converter v0.1.0.1\r\n";
			label = this.Creditos;
			label.Text += "By Borra (AAI Spanish Team)\r\n";
			label = this.Creditos;
			label.Text += "http://aceattorneyspain.com/TradAAI.htm";
		}

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("Texto")]
		private Label _Texto;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("Creditos")]
		private Label _Creditos;
	}
}
