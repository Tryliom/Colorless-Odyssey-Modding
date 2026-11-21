using ColorlessOdyssey;

// A modder may change this namespace freely: the class is found by its name (ModdedAoeId).
// "MyMod" becomes "my_mod", so "test_poison_pool" ends up as "my_mod:test_poison_pool" once the registry is initialized.
namespace MyMod
{
    public static class ModdedAoeId
    {
        // Fields must not be readonly: the registry rewrites them with the namespaced id.
        public static AoeId TestPoisonPool = new("test_poison_pool");
        public static AoeId TestCursedArea = new("test_cursed_area");
    }
}
