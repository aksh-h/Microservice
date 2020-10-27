using System.Runtime.Serialization;

namespace Serbilis.Core.Helpers
{
    public enum ConnectionType
    {
        ProductionDatabase,
        HelpDeskDatabase,
        CRSVitalEventInfo,
        CivilRegistrySystem,
        VitalStatisticsDatabase,
        InfoImageConString
    }

    public enum CertificateType
    {
        [EnumMember]
        Birth,
        [EnumMember]
        Marriage,
        [EnumMember]
        Death,
        [EnumMember]
        CENOMAR,
        [EnumMember]
        CenoDeath,
        [EnumMember]
        EEBirth,
        [EnumMember]
        EEMarriage,
        [EnumMember]
        EEDeath,
    }
}
