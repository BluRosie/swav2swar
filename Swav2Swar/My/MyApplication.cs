using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace Swav2Swar.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		private byte[] CabeceraSwar;
		// Token: 0x06000001 RID: 1 RVA: 0x0000477C File Offset: 0x00002B7C
		static void Main(string[] args)
		{
			var c = new Principal(args);
		}

		

		// Token: 0x06000002 RID: 2 RVA: 0x000047B4 File Offset: 0x00002BB4
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			this.IsSingleInstance = false;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		internal virtual DataGridView Grid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid1;
			}
		}

		private DataGridView _Grid1;
	}
}
