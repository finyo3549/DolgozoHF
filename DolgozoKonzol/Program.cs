using System;
using System.Configuration;
using System.Text.Json;

namespace DolgozoKonzol
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string endPoint = ReadSetting("endpointUrl");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(endPoint))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string responseBody = await response.Content.ReadAsStringAsync();
                            Worker[] workers = JsonSerializer.Deserialize<Worker[]>(responseBody);
                            int elemekSzama = workers.Length;
                            Console.WriteLine("Az elemek száma: " + elemekSzama);
                            string legmagasabbFizetesu = legmagasabbFizetes(workers);
                            Console.WriteLine("A legmagasabb fizetésű dolgozó: " + legmagasabbFizetesu);
                            var munkakorok = Munkakor(workers);
                            foreach (var munkakor in  munkakorok)
                            {
                                Console.WriteLine($"Munkakör: {munkakor.Key}, dolgozók száma: {munkakor.Value}");
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            
        }

        private static String legmagasabbFizetes(Worker[] worker)
        {
            Worker legmagasabbFizetesuDolgozo = worker[0];
            foreach (var item in worker)
            {
                if(item.Salary > legmagasabbFizetesuDolgozo.Salary)
                {
                    legmagasabbFizetesuDolgozo = item;
                }
            }
            return legmagasabbFizetesuDolgozo.Name;
        }
       

        public static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        static Dictionary<string, int> Munkakor(Worker[] workers)
        {
            var szamol = new Dictionary<string, int>();

            foreach (var worker in workers)
            {
                if (!szamol.ContainsKey(worker.Position))
                {
                    szamol[worker.Position] = 0;
                }
                szamol[worker.Position]++;
            }

            return szamol;
        }
    }
}