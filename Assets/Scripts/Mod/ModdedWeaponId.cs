using ColorlessOdyssey;

// A modder may change this namespace freely: the class is found by its name (ModdedWeaponId).
// "MyMod" becomes "my_mod", so "test_orb" ends up as "my_mod:test_orb" once the registry is initialized.
namespace MyMod
{
    public static class ModdedWeaponId
    {
        // Fields must not be readonly: the registry rewrites them with the namespaced id.
        public static WeaponId TheOrb = new("the_orb");
        public static WeaponId TheBeam = new("the_beam");
    }
}
