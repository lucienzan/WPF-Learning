namespace WebAPI
{
    public class APISetting
    {
        public const string KEY_CONNECTSTR = "ConnectionString";

        public const string KEY_CONNECTSTR_PACKAGE = "PackageConnectionString";

        public const string KEY_LOGDIRECTORY = "LogDirectory";

        public const string APITOKEN = "APIToken";
        public static IConfiguration ? Configuration { get; set; }
    }
}
