using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace tmeogsQOL
{
	public class Config : ModConfig
    {
	    public override ConfigScope Mode => ConfigScope.ServerSide;

		[DefaultValue(true)]
		[ReloadRequired]
		public bool GoodAxe { get; set; }

		[DefaultValue(1)]
		[Range(0f, 1f)]
		public float RespawnHP { get; set; }

		[DefaultValue(1)]
		[Range(0f, 1f)]
		public float RespawnMP { get; set; }

		[DefaultValue(20)]
		[ReloadRequired]
		public int PillarHP { get; set; }
	}
}