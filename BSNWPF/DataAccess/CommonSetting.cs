namespace BSNWPF.Back.DataAccess
{
    public class CommonSetting
    {
        public static string BSNConnectionString = string.Empty; 

        public static string PackageConnectionString = string.Empty;

        public static string LogOutPutDirectory = string.Empty;
        public static CommonLibrary.iLog Log { get; set; }
    }
}
