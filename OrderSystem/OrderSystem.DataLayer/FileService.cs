using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.DataLayer
{
    public class FileService
    {
        //private const string PathFiles = @"C:\Users\PC\Desktop\OrderSystem\OrderSystem.DataLayer\Data\";
        private const string PathFiles = @"C:\Users\PC\Desktop\OrderSystem\OrderSystem.Blazor\bin\Debug\net6.0\Data\";
        



        //Traer los datos del Archivo Json
        public (bool,string) GetDataFromFileJson(string FileName)
        {
            bool Success = true;
            string DataReturn = string.Empty;

            try
            {
                using (var reader = new StreamReader(PathFiles.Replace("/","") + FileName))
                {
                    DataReturn = reader.ReadToEnd();
                }
            }
            catch(Exception Ex)
            {
                Success = false;
                DataReturn = Ex.Message;
            }
            return (Success,DataReturn);
        }

        public bool SaveDataToFile(string JsonData, string FileName)
        {
            bool Success = false;
            FileName = PathFiles + FileName;

            if (File.Exists(FileName))
            {
                File.WriteAllText(FileName, JsonData);
                Success = true;
            }

            return Success;
        }

    }
}
