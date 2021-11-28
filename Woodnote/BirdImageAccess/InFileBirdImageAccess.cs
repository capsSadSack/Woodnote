using BirdClassification.BiologyClassification;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Utils;

namespace BirdImageAccess
{
    public class InFileBirdImageAccess : IBirdImageAccess
    {
        private string _directory;
        private Hierarchy _hierarchy = new Hierarchy();

        public InFileBirdImageAccess(string directory)
        {
            _directory = directory;
        }


        public async Task<Bitmap> GetImageAsync(BirdDomain bird, Gender gender)
        {
            string filePath = GetFilePath(bird, gender);
            return await Task.Run(() => new Bitmap(filePath));
        }

        private string GetFilePath(BirdDomain bird, Gender gender)
        {
            string dir = GetDirectoryPath(bird.Order);
            string fileName = GetFileNameWithoutExtension(bird, gender);

            var allFiles = System.IO.Directory.GetFiles(dir);
            return allFiles
                .Where(x => System.IO.Path.GetFileNameWithoutExtension(x).StartsWith(fileName))
                .FirstOrDefault();
        }

        private string GetFileNameWithoutExtension(BirdDomain bird, Gender gender)
        {
            return bird.Name + "_" + GetGenderStr(gender);
        }

        private string GetGenderStr(Gender gender)
        {
            switch (gender)
            {
                case Gender.Female:
                    {
                        return "Female";
                    }
                case Gender.Male:
                    {
                        return "Male";
                    }
                default:
                    {
                        throw new InvalidOperationException();
                    }
            }
        }

        private string GetDirectoryPath(Order birdOrder)
        {
            var hierarchyElements = _hierarchy.GetUpperHierarchy(birdOrder);

            string path = null;

            for (int i = 0; i < hierarchyElements.Count(); i++)
            {
                string name = EnumsProcessor.GetName(hierarchyElements[i]);

                if (path != null)
                {
                    path = System.IO.Path.Combine(path, name);
                }
                else
                {
                    path = name;
                }
            }

            return path;
        }
    }
}
