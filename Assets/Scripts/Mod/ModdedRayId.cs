using ColorlessOdyssey;

// A modder may change this namespace freely: the class is found by its name (ModdedRayId).
// "MyMod" becomes "my_mod", so "test_beam" ends up as "my_mod:test_beam" once the registry is initialized.
namespace MyMod
{
    public static class ModdedRayId
    {
        // Fields must not be readonly: the registry rewrites them with the namespaced id.
        public static RayId TestBeam = new("test_beam");
        public static RayId TestEnemyBeam = new("test_enemy_beam");
    }
}
