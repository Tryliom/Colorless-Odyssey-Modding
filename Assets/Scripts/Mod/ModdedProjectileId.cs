using ColorlessOdyssey;

// A modder may change this namespace freely: the class is found by its name (ModdedProjectileId).
// "MyMod" becomes "my_mod", so "test_orb" ends up as "my_mod:test_orb" once the registry is initialized.
namespace MyMod
{
    public static class ModdedProjectileId
    {
        // Fields must not be readonly: the registry rewrites them with the namespaced id.
        public static ProjectileId TestOrb = new("test_orb");
        [ProjectileFlags(ProjectileFlags.Enemy)]
        public static ProjectileId TestEnemyOrb = new("test_enemy_orb");
        
        [ProjectileFlags(ProjectileFlags.Melee)]
        public static ProjectileId TestMeleeStrike = new("test_melee_strike");
    }
}
