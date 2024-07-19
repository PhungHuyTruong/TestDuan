using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Properties;

namespace GUI.FileManager
{
    public static class PicManager
    {
        public static string ImageFolderPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Avatars");

        public static string SaveAvatar(string sourceFilePath)
        {
            string fileName = $"avatar_{Guid.NewGuid()}{Path.GetExtension(sourceFilePath)}";
            string relativePath = Path.Combine("Images", "Avatars", fileName);
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            using (Image image = Image.FromFile(sourceFilePath))
            {
                // Optionally resize the image here if needed
                image.Save(fullPath);
            }

            return relativePath;
        }

        public static Image LoadAvatar(string avatarPath)
        {
            if (string.IsNullOrEmpty(avatarPath))
            {
                return GUI.Properties.Resource.avatarmacdinh;
            }

            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, avatarPath);

            if (!File.Exists(fullPath))
            {
                return GUI.Properties.Resource.avatarmacdinh;
            }

            using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(stream);
            }
        }

        public static void DeleteAvatar(string avatarPath)
        {
            if (!string.IsNullOrEmpty(avatarPath))
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, avatarPath);
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
            }
        }
    }
}
