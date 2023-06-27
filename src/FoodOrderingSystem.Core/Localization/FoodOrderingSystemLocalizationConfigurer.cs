using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FoodOrderingSystem.Localization
{
    public static class FoodOrderingSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FoodOrderingSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FoodOrderingSystemLocalizationConfigurer).GetAssembly(),
                        "FoodOrderingSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
