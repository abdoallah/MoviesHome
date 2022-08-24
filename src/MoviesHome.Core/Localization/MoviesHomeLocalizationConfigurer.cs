using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MoviesHome.Localization
{
    public static class MoviesHomeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MoviesHomeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MoviesHomeLocalizationConfigurer).GetAssembly(),
                        "MoviesHome.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
