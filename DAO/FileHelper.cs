using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAO
{
    public class FileHelper<T>
    {
        /// <summary>
        /// Reads the CSV file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public List<T> ReadCsvFile(string filePath)
        {
            List<T> records = new();
            try
            {
                if (!File.Exists(filePath))
                {
                    return records;
                }

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<T>().ToList();
                }
                return records;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error read data: " + ex.Message);
                return records;
            }
        }

        public void WriteCsvFile(string filePath, List<T> records)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        public void WriteJsonFile(string filePath, List<T> records)
        {
            try
            {
                string json = JsonSerializer.Serialize(records);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <param name="filePath">The file path</param>
        /// <returns>list data</returns>
        public List<T> ReadJsonFile(string filePath)
        {
            List<T> records = new();
            try
            {
                if (!File.Exists(filePath))
                {
                    return records;
                }

                var file = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error read data: " + ex.Message);
                return records;
            }
        }


        public List<T> ReadXMLFile(string filePath)
        {
            var records = new List<T>();
            try
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var reader = new StreamReader(filePath))
                {
                    records = (List<T>)serializer.Deserialize(reader);
                };

                return records;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error read data: " + ex.Message);
                return records;
            }
        }

        public void WriteXMLFile(string filePath, List<T> records)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, records);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving data: " + ex.Message);
            }
        }

        public string ReadTxtFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }

            return string.Empty;
        }

        public void Write(string filePath, string data)
        {
            File.WriteAllText(filePath, data);
        }
    }
}
