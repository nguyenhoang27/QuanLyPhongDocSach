using System.Xml;
using System.Xml.Linq;

namespace QuanLiThuVien
{
    class Config
    {
        public static string ConfigFilePath = null;
        public static Config Instance = null;

        public string database;
        public string secret;
        public string username;

        private Config(string db, string se, string un)
        {
            database = db;
            secret = se;
            username = un;
        }

        public static void GetConfig()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(ConfigFilePath);
            XmlNode db = xml.DocumentElement.SelectSingleNode("/config/database");
            XmlNode se = xml.DocumentElement.SelectSingleNode("/config/secret");
            XmlNode username = xml.DocumentElement.SelectSingleNode("/config/username");

            Instance = new Config(db.InnerText.Trim(), se.InnerText.Trim(), username?.InnerText?.Trim());
        }

        public static void SetConfig()
        {
            new XDocument(
                new XElement("config",
                    new XElement("database", Instance.database),
                    new XElement("secret", Instance.secret),
                    new XElement("username", Instance.username)
                )
            ).Save("config.xml");
        }

    }
}
