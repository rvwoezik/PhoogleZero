using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PhoogleZero.Localization
{
    public static class PhoogleZeroLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    PhoogleZeroConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PhoogleZeroLocalizationConfigurer).GetAssembly(),
                        "PhoogleZero.Localization.PhoogleZero"
                    )
                )
            );
        }
    }
}