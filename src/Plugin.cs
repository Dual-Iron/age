using BepInEx;
using System.Security.Permissions;

// Allows access to private members
#pragma warning disable CS0618
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
#pragma warning restore CS0618

namespace Age;

[BepInPlugin("com.dual.age", "Age", "1.0.0")]
sealed class Plugin : BaseUnityPlugin
{
    public void OnEnable()
    {
        Logger.LogDebug("h");
    }
}
