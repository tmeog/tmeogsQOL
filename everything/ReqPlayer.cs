﻿using Terraria;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using tmeogsQOL.everything.items.FunStuff;
using System.Linq;

namespace tmeogsQOL.everything
{
	public class ReqPlayer : ModPlayer
	{
		List<Player> deadPlayers = new List<Player>();

		public override void OnEnterWorld()
		{
			Main.LocalPlayer.statLife = (int)Math.Round(Main.LocalPlayer.statLifeMax2 * ModContent.GetInstance<Config>().RespawnHP);
			Main.LocalPlayer.statMana = (int)Math.Round(Main.LocalPlayer.statManaMax2 * ModContent.GetInstance<Config>().RespawnMP);
			deadPlayers.Clear();
		}
		public override void UpdateDead()
		{
			bool BossAlive = false;
			foreach (NPC npc in Main.npc){
				if (npc.active && npc.boss){
					BossAlive = true;
				}
			}
			foreach (Player player in Main.player){
				if (player.dead && !deadPlayers.Contains(player)){
					deadPlayers.Add(player);
				}
				if (player.dead && player.respawnTimer > 60 && !BossAlive){
					player.respawnTimer = 60;
				}
			}
		}
		public override void OnRespawn(){
			foreach (Player player in Main.player){
				if (deadPlayers.Contains(player)){
					player.statLife = (int)Math.Round(player.statLifeMax2 * ModContent.GetInstance<Config>().RespawnHP);
					player.statMana = (int)Math.Round(player.statManaMax2 * ModContent.GetInstance<Config>().RespawnMP);
					deadPlayers.Remove(player);
				}
			}
		}

		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			if (Player.name == "RequiemTA")
			{
				return new[] 
				{
					new Item(ModContent.ItemType<SkullEmoji>())
				};
			} 
			else 
			{
				return Enumerable.Empty<Item>();
			}
		}
	}
}