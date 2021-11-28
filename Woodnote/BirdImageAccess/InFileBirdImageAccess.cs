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
            var similarFiles = allFiles
                .Where(x => System.IO.Path.GetFileNameWithoutExtension(x).StartsWith(fileName));
            return similarFiles.FirstOrDefault();

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
            string path = _directory;

            for (int i = hierarchyElements.Count() - 2; i >= 0; i--)
            {
                Type type = hierarchyElements[i].GetType();
                string name = EnumsProcessor.GetName(type, hierarchyElements[i]);
                string temp = System.IO.Path.Combine(path, name);
                path = temp;
            }

            string orderName = EnumsProcessor.GetName(typeof(Order), birdOrder);
            string orderTemp = System.IO.Path.Combine(path, orderName);
            path = orderTemp;

            return path;
        }
    }
}
