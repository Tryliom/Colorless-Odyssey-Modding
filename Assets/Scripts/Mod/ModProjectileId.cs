using ColorlessOdyssey;

// A modder may change this namespace freely: the class is found by its name (ModdedProjectileId).
// "MyMod" becomes "my-mod", so "test-orb" ends up as "my-mod:test-orb" once the registry is initialized.
namespace MyMod
{
    public static class ModdedProjectileId
    {
        // Fields must not be readonly: the registry rewrites them with the namespaced id.
        public static ProjectileId TestOrb = new("test_orb");
        public static ProjectileId TestBeam = new("test_beam");
        public static ProjectileId TestSpiral = new("test_spiral");
    }
}
