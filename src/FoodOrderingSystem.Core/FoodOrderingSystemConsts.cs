using FoodOrderingSystem.Debugging;

namespace FoodOrderingSystem
{
    public class FoodOrderingSystemConsts
    {
        public const string LocalizationSourceName = "FoodOrderingSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "92eb80c8defa49ebb227fedefdfea165";
    }
}
