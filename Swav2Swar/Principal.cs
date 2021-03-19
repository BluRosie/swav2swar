using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Swav2Swar.My;

namespace Swav2Swar
{
	public partial class Principal
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00004BA0 File Offset: 0x00002FA0
		public Principal(string[] args)
		{
			this.CabeceraSwar = new byte[]
			{
				83,
				87,
				65,
				82,
				byte.MaxValue,
				254,
				0,
				1,
				238,
				238,
				0,
				0,
				16,
				0,
				1,
				0,
				68,
				65,
				84,
				65,
				238,
				238,
				238,
				238,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				0,
				0,
				byte.MaxValue
			};


			if (args.Length == 0)
			{
				Console.WriteLine("swav2swar puts a bunch of swavs into a swar file.\nUsage:  swav2swar [... swav list ...] [swar file]");
			}
			else
			{
				CrearSwar_Click(args);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00005DFC File Offset: 0x000041FC
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00005E10 File Offset: 0x00004210
		internal virtual TabControl Tab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Tab = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00005E1C File Offset: 0x0000421C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00005E30 File Offset: 0x00004230
		internal virtual TabPage Tab1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tab1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Tab1 = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00005E3C File Offset: 0x0000423C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00005E50 File Offset: 0x00004250
		internal virtual TabPage Tab2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tab2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Tab2 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00005E5C File Offset: 0x0000425C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00005E70 File Offset: 0x00004270
		internal virtual DataGridView Grid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.ListaSwavs_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.ListaSwavs_DragEnter);
				DataGridViewRowsRemovedEventHandler value4 = new DataGridViewRowsRemovedEventHandler(this.Grid1_RowsRemoved);
				if (this._Grid1 != null)
				{
					this._Grid1.DragDrop -= value2;
					this._Grid1.DragEnter -= value3;
					this._Grid1.RowsRemoved -= value4;
				}
				this._Grid1 = value;
				if (this._Grid1 != null)
				{
					this._Grid1.DragDrop += value2;
					this._Grid1.DragEnter += value3;
					this._Grid1.RowsRemoved += value4;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00005F08 File Offset: 0x00004308
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00005F1C File Offset: 0x0000431C
		internal virtual Button Subir
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Subir;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Subir_Click);
				if (this._Subir != null)
				{
					this._Subir.Click -= value2;
				}
				this._Subir = value;
				if (this._Subir != null)
				{
					this._Subir.Click += value2;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005F68 File Offset: 0x00004368
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00005F7C File Offset: 0x0000437C
		internal virtual Button Bajar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bajar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Bajar_Click);
				if (this._Bajar != null)
				{
					this._Bajar.Click -= value2;
				}
				this._Bajar = value;
				if (this._Bajar != null)
				{
					this._Bajar.Click += value2;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00005FC8 File Offset: 0x000043C8
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00005FDC File Offset: 0x000043DC
		internal virtual DataGridViewTextBoxColumn Ruta
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Ruta;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Ruta = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00005FE8 File Offset: 0x000043E8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00005FFC File Offset: 0x000043FC
		internal virtual DataGridViewTextBoxColumn indice
		{
			[DebuggerNonUserCode]
			get
			{
				return this._indice;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._indice = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00006008 File Offset: 0x00004408
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000601C File Offset: 0x0000441C
		internal virtual DataGridViewTextBoxColumn Nombre
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Nombre;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Nombre = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00006028 File Offset: 0x00004428
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000603C File Offset: 0x0000443C
		internal virtual Button CrearSwar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CrearSwar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AbrirSWAV_Click);
				if (this._CrearSwar != null)
				{
					this._CrearSwar.Click -= value2;
				}
				this._CrearSwar = value;
				if (this._CrearSwar != null)
				{
					this._CrearSwar.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00006088 File Offset: 0x00004488
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000609C File Offset: 0x0000449C
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000060A8 File Offset: 0x000044A8
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000060BC File Offset: 0x000044BC
		internal virtual Label Canales
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Canales;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Canales = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000060C8 File Offset: 0x000044C8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000060DC File Offset: 0x000044DC
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000060E8 File Offset: 0x000044E8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000060FC File Offset: 0x000044FC
		internal virtual Label Frecuencia
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Frecuencia;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Frecuencia = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006108 File Offset: 0x00004508
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000611C File Offset: 0x0000451C
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00006128 File Offset: 0x00004528
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000613C File Offset: 0x0000453C
		internal virtual Label TipoOnda
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TipoOnda;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TipoOnda = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00006148 File Offset: 0x00004548
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000615C File Offset: 0x0000455C
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00006168 File Offset: 0x00004568
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000617C File Offset: 0x0000457C
		internal virtual Button AbrirWav
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AbrirWav;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AbrirWav_Click);
				if (this._AbrirWav != null)
				{
					this._AbrirWav.Click -= value2;
				}
				this._AbrirWav = value;
				if (this._AbrirWav != null)
				{
					this._AbrirWav.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000061C8 File Offset: 0x000045C8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000061DC File Offset: 0x000045DC
		internal virtual TextBox NombreFichero
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NombreFichero;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NombreFichero = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000061E8 File Offset: 0x000045E8
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000061FC File Offset: 0x000045FC
		internal virtual OpenFileDialog ObjetoOpenFile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ObjetoOpenFile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ObjetoOpenFile = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006208 File Offset: 0x00004608
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000621C File Offset: 0x0000461C
		internal virtual SaveFileDialog ObjetoSaveFile
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ObjetoSaveFile;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ObjetoSaveFile = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006228 File Offset: 0x00004628
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000623C File Offset: 0x0000463C
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006248 File Offset: 0x00004648
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000625C File Offset: 0x0000465C
		internal virtual RadioButton PCM8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PCM8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PCM8 = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00006268 File Offset: 0x00004668
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000627C File Offset: 0x0000467C
		internal virtual RadioButton IMA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IMA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IMA = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006288 File Offset: 0x00004688
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000629C File Offset: 0x0000469C
		internal virtual RadioButton PCM16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PCM16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PCM16 = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000062A8 File Offset: 0x000046A8
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000062BC File Offset: 0x000046BC
		internal virtual Button CrearSwav
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CrearSwav;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CrearSwav_Click);
				if (this._CrearSwav != null)
				{
					this._CrearSwav.Click -= value2;
				}
				this._CrearSwav = value;
				if (this._CrearSwav != null)
				{
					this._CrearSwav.Click += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006308 File Offset: 0x00004708
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000631C File Offset: 0x0000471C
		internal virtual Button Ayuda
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Ayuda;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Ayuda_Click);
				if (this._Ayuda != null)
				{
					this._Ayuda.Click -= value2;
				}
				this._Ayuda = value;
				if (this._Ayuda != null)
				{
					this._Ayuda.Click += value2;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006368 File Offset: 0x00004768
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000637C File Offset: 0x0000477C
		internal virtual Button Abrir
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Abrir;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AbrirSWAV_Click);
				if (this._Abrir != null)
				{
					this._Abrir.Click -= value2;
				}
				this._Abrir = value;
				if (this._Abrir != null)
				{
					this._Abrir.Click += value2;
				}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000063C8 File Offset: 0x000047C8
		private void Principal_Load(object sender, EventArgs e)
		{
			if (!File.Exists(this.RutaPrograma + "waveconv.exe") & !File.Exists(this.RutaPrograma + "wav2swav.exe"))
			{
				this.Tab.TabPages.Remove(this.Tab2);
			}
			if (File.Exists(this.RutaPrograma + "waveconv.exe"))
			{
				this.conversorexe = "\\waveconv.exe";
			}
			if (File.Exists(this.RutaPrograma + "wav2swav.exe"))
			{
				this.conversorexe = "\\wav2swav.exe";
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006464 File Offset: 0x00004864
		private void ListaSwavs_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006480 File Offset: 0x00004880
		private void ListaSwavs_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string text in array)
			{
				string left = Strings.Right(text, 5).ToUpper();
				if (Operators.CompareString(left, ".SWAV", false) == 0)
				{
					this.AñadirElemento(text);
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000064E0 File Offset: 0x000048E0
		private void AbrirSWAV_Click(object sender, EventArgs e)
		{
			this.ObjetoOpenFile.Filter = "Swav Files|*.swav";
			this.ObjetoOpenFile.Title = "Select SWAVs files";
			this.ObjetoOpenFile.FileName = "";
			this.ObjetoOpenFile.Multiselect = true;
			if (this.ObjetoOpenFile.ShowDialog() == DialogResult.OK)
			{
				string[] fileNames = this.ObjetoOpenFile.FileNames;
				foreach (string text in fileNames)
				{
					string left = Strings.Right(text, 5).ToUpper();
					if (Operators.CompareString(left, ".SWAV", false) == 0)
					{
						this.AñadirElemento(text);
					}
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006580 File Offset: 0x00004980


		public void AñadirElemento(string rutatemp)
		{
			this.Grid1.Rows.Add(new object[]
			{
				rutatemp,
				this.Grid1.Rows.Count,
				0
			});
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000065DC File Offset: 0x000049DC
		private void Subir_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.Grid1.RowCount > 0)
				{
					int index = this.Grid1.CurrentRow.Index;
					if (index > 0)
					{
						string value = Conversions.ToString(this.Grid1.Rows[index - 1].Cells["Nombre"].Value);
						string value2 = Conversions.ToString(this.Grid1.Rows[index - 1].Cells["Ruta"].Value);
						this.Grid1.Rows[index - 1].Cells["Nombre"].Value = RuntimeHelpers.GetObjectValue(this.Grid1.Rows[index].Cells["Nombre"].Value);
						this.Grid1.Rows[index - 1].Cells["Ruta"].Value = RuntimeHelpers.GetObjectValue(this.Grid1.Rows[index].Cells["Ruta"].Value);
						this.Grid1.Rows[index].Cells["Nombre"].Value = value;
						this.Grid1.Rows[index].Cells["Ruta"].Value = value2;
						this.Grid1.CurrentCell = this.Grid1[1, index - 1];
					}
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006774 File Offset: 0x00004B74
		private void Bajar_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.Grid1.RowCount > 0)
				{
					int index = this.Grid1.CurrentRow.Index;
					if (index < this.Grid1.Rows.Count - 1)
					{
						string value = Conversions.ToString(this.Grid1.Rows[index + 1].Cells["Nombre"].Value);
						string value2 = Conversions.ToString(this.Grid1.Rows[index + 1].Cells["Ruta"].Value);
						this.Grid1.Rows[index + 1].Cells["Nombre"].Value = RuntimeHelpers.GetObjectValue(this.Grid1.Rows[index].Cells["Nombre"].Value);
						this.Grid1.Rows[index + 1].Cells["Ruta"].Value = RuntimeHelpers.GetObjectValue(this.Grid1.Rows[index].Cells["Ruta"].Value);
						this.Grid1.Rows[index].Cells["Nombre"].Value = value;
						this.Grid1.Rows[index].Cells["Ruta"].Value = value2;
						this.Grid1.CurrentCell = this.Grid1[1, index + 1];
					}
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006920 File Offset: 0x00004D20
		private void Grid1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			int num = 0;
			checked
			{
				int num2 = this.Grid1.Rows.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					this.Grid1.Rows[i].Cells["Indice"].Value = i;
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006978 File Offset: 0x00004D78
		private void CrearSwar_Click(string[] args)
		{
			checked
			{
				if (args.Length > 0)
				{
					bool flag = false;
					int num = 60;
					int num2 = this.CabeceraSwar.Length - 1 + 4 * (args.Length - 1);
					byte[] array = new byte[num2 + 1];
					Array.Copy(this.CabeceraSwar, array, this.CabeceraSwar.Length - 1);
					int num3 = num2 + 1;
					int num4 = 0;
					int num5 = args.Length - 2;
					for (int i = num4; i <= num5; i++)
					{
						byte[] array2 = MyProject.Computer.FileSystem.ReadAllBytes(args[i]);
						int num6 = array2.Length - 25;
						array = (byte[])Utils.CopyArray((Array)array, new byte[array.Length + num6 + 1]);
						byte[] bytes1 = BitConverter.GetBytes(num3);
						int num7 = 0;
						int num8 = bytes1.Length - 1;
						for (int j = num7; j <= num8; j++)
						{
							array[num + j] = bytes1[j];
						}
						num += 4;
						Array.Copy(array2, 24, array, num3, num6 + 1);
						num3 = array.Length;
					}
					byte[] bytes = BitConverter.GetBytes(array.Length);
					int num9 = 0;
					int num10 = bytes.Length - 1;
					for (int k = num9; k <= num10; k++)
					{
						array[8 + k] = bytes[k];
					}
					bytes = BitConverter.GetBytes(array.Length - 16);
					int num11 = 0;
					int num12 = bytes.Length - 1;
					for (int l = num11; l <= num12; l++)
					{
						array[20 + l] = bytes[l];
					}
					bytes = BitConverter.GetBytes(args.Length - 1);
					int num13 = 0;
					int num14 = bytes.Length - 1;
					for (int m = num13; m <= num14; m++)
					{
						array[56 + m] = bytes[m];
					}
					MyProject.Computer.FileSystem.WriteAllBytes(args[args.Length - 1], array, false);
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006C20 File Offset: 0x00005020
		private void AbrirWav_Click(object sender, EventArgs e)
		{
			this.ObjetoOpenFile.Filter = "wav File|*.wav";
			this.ObjetoOpenFile.Title = "Select WAV File";
			this.ObjetoOpenFile.FileName = "";
			this.ObjetoOpenFile.Multiselect = false;
			if (this.ObjetoOpenFile.ShowDialog() == DialogResult.OK)
			{
				this.CrearSwav.Enabled = true;
				this.RutaOrigen = this.ObjetoOpenFile.FileName;
				this.NombreFichero.Text = this.RutaOrigen;
				this.FicheroWav = new byte[1];
				this.FicheroWav = MyProject.Computer.FileSystem.ReadAllBytes(this.ObjetoOpenFile.FileName);
				if (this.FicheroWav[20] == 1)
				{
					this.TipoOnda.Text = "PCM-" + Conversions.ToString((int)BitConverter.ToInt16(this.FicheroWav, 34)) + "bits";
				}
				else
				{
					this.TipoOnda.Text = "Compressed (No Valid)";
				}
				this.Frecuencia.Text = Conversions.ToString(BitConverter.ToUInt32(this.FicheroWav, 24)) + "Hz";
				short num = checked((short)BitConverter.ToUInt16(this.FicheroWav, 22));
				if (num == 1)
				{
					this.Canales.Text = "1 (Mono)";
				}
				else if (num == 2)
				{
					this.Canales.Text = "2 (Stereo)";
				}
				else if (num > 2)
				{
					this.Canales.Text = Conversions.ToString((int)num) + " channels";
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006DA0 File Offset: 0x000051A0
		private void CrearSwav_Click(object sender, EventArgs e)
		{
			string text = "";
			char value = '"';
			this.ObjetoSaveFile.Filter = "swav file|*.swav";
			this.ObjetoSaveFile.Title = "Save SWAV File";
			this.ObjetoSaveFile.FileName = Strings.Left(this.RutaOrigen, checked(Strings.Len(this.RutaOrigen) - 3)) + "swav";
			this.ObjetoSaveFile.DefaultExt = ".swav";
			if (this.ObjetoSaveFile.ShowDialog() == DialogResult.OK)
			{
				if (this.IMA.Checked)
				{
					text = "-a ";
				}
				else if (this.PCM16.Checked)
				{
					text = "-s ";
				}
				else if (this.PCM8.Checked)
				{
					text = "-c ";
				}
				text = string.Concat(new string[]
				{
					text,
					"-o ",
					Conversions.ToString(value),
					this.ObjetoSaveFile.FileName,
					Conversions.ToString(value),
					" "
				});
				text = text + Conversions.ToString(value) + this.RutaOrigen;
				if (File.Exists(this.RutaPrograma + this.conversorexe))
				{
					Process.Start(this.RutaPrograma + this.conversorexe, text);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006EE8 File Offset: 0x000052E8
		private void Ayuda_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Help.Visible = true;
		}

		// Token: 0x0400000B RID: 11
		[AccessedThroughProperty("Tab")]
		private TabControl _Tab;

		// Token: 0x0400000C RID: 12
		[AccessedThroughProperty("Tab1")]
		private TabPage _Tab1;

		// Token: 0x0400000D RID: 13
		[AccessedThroughProperty("Tab2")]
		private TabPage _Tab2;

		// Token: 0x0400000E RID: 14
		[AccessedThroughProperty("Grid1")]
		private DataGridView _Grid1;

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("Subir")]
		private Button _Subir;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("Bajar")]
		private Button _Bajar;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("Ruta")]
		private DataGridViewTextBoxColumn _Ruta;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("indice")]
		private DataGridViewTextBoxColumn _indice;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("Nombre")]
		private DataGridViewTextBoxColumn _Nombre;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("CrearSwar")]
		private Button _CrearSwar;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("Canales")]
		private Label _Canales;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("Frecuencia")]
		private Label _Frecuencia;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("TipoOnda")]
		private Label _TipoOnda;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("AbrirWav")]
		private Button _AbrirWav;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("NombreFichero")]
		private TextBox _NombreFichero;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("ObjetoOpenFile")]
		private OpenFileDialog _ObjetoOpenFile;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("ObjetoSaveFile")]
		private SaveFileDialog _ObjetoSaveFile;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("PCM8")]
		private RadioButton _PCM8;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("IMA")]
		private RadioButton _IMA;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("PCM16")]
		private RadioButton _PCM16;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("CrearSwav")]
		private Button _CrearSwav;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("Ayuda")]
		private Button _Ayuda;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("Abrir")]
		private Button _Abrir;

		// Token: 0x04000027 RID: 39
		private string RutaPrograma;

		// Token: 0x04000028 RID: 40
		private string RutaOrigen;

		// Token: 0x04000029 RID: 41
		private string RutaDestino;

		// Token: 0x0400002A RID: 42
		private byte[] FicheroWav;

		// Token: 0x0400002B RID: 43
		private string conversorexe;

		// Token: 0x0400002C RID: 44
		private byte[] CabeceraSwar;
	}
}
