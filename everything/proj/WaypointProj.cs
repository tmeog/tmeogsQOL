using Terraria;
using Terraria.ModLoader;

namespace tmeogsQOL.everything.proj
{
    public class WaypointProj : ModProjectile
    {
        float startScale = 1f;

        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 7;
        }
        public override void SetDefaults()
        {
            Projectile.width = 96;
            Projectile.height = 96;
            Projectile.aiStyle = -1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.timeLeft = 300;
        }

        public override bool? CanDamage()
        {
            return false;
        }

        public override void AI()
        {
            if (Projectile.timeLeft > 200)
            {
                Projectile.timeLeft = 300;
            }

            if (++Projectile.frameCounter >= 5)
            {
                Projectile.frameCounter = 0;
                if (++Projectile.frame >= Main.projFrames[Projectile.type])
                    Projectile.frame = 0;
            }
        }
    }
}
