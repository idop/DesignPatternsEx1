﻿namespace FacebookApp
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    public class UserSettings
    {
        private const string k_FileName = "settings.txt";

        public bool RememberMe { get; set; }
        public string LastUsedToken { get; set; }

        private static string FilePath 
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"\" + k_FileName;
            }
        }

        public void Save()
        {
            using (FileStream fileStream = File.Create(FilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                serializer.Serialize(fileStream,this);
                fileStream.Flush();
            }
        }

        public static UserSettings CreateFromFile()
        {
            UserSettings result = null;

            using (FileStream loadStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read)) 
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                result = (UserSettings)serializer.Deserialize(loadStream);
            }

            return result;
        }
    }
}