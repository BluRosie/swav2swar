using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Swav2Swar.My.Resources
{
	// Token: 0x0200000A RID: 10
	[DebuggerNonUserCode]
	[StandardModule]
	[HideModuleName]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	internal sealed class Resources
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000465C File Offset: 0x00002A5C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Swav2Swar.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000469C File Offset: 0x00002A9C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000046B0 File Offset: 0x00002AB0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000032 RID: 50
		private static ResourceManager resourceMan;

		// Token: 0x04000033 RID: 51
		private static CultureInfo resourceCulture;
	}
}
