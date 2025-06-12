using System;
using System.ComponentModel;
using Terraria.ModLoader.Config;

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

        [DefaultValue(true)]
        [ReloadRequired]
        public bool DifficultyChangerAvailable { get; set; }
    }
}