using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Log {
    public class LogManager {

        public void Save(string methodName, string type, object logData) {

            // Serializa o objeto recebido para uma string no formato JSON.
            string serializedData = Serializer.JsonSerialize(logData);

            DateTime actualTime = DateTime.UtcNow;
            string path = @"C:\logs\";
            string fileName = "porquinho_" + actualTime.ToString("dd-MM-yyyy") + ".log";
            string fullPath = Path.Combine(path, fileName);

            try {
                // Verifica se o diretório existe, caso não exista, um novo é criado.
                if (Directory.Exists(path) == false) {
                    Directory.CreateDirectory(path);
                }

                 // Verifica se o arquivo existe, caso não exista, um novo é criado.
                if (File.Exists(fullPath) == false) {
                    File.Create(fullPath).Dispose();
                }

                string data = string.Format("[{0}]: {1} | {2} | {3}{4}", actualTime, methodName, type, serializedData, Environment.NewLine);

                File.AppendAllText(fullPath, data);
            }
            catch (Exception Ex) {
                Console.WriteLine(Ex.ToString());
            }  

        }
    }
}


        
    

