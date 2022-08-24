using MoviesHome.Debugging;

namespace MoviesHome
{
    public class MoviesHomeConsts
    {
        public const string LocalizationSourceName = "MoviesHome";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "958f372df3e5496c9e848c9e7881a083";
    }
}
