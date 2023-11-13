using static bf3parse.BF3Util;
using Newtonsoft.Json;

namespace bf3parse
{
    public class Startup
    {
        public Startup(string[] args) { }

        public static async Task RunAsync(string[] args)
        {
            var startup = new Startup(args);
            await startup.RunAsync();
        }

        public async Task RunAsync()
        {
            await ProcessData();
            await Task.Delay(Timeout.Infinite);
        }

        public async Task ProcessData()
        {
            await Console.Out.WriteLineAsync("Enter the path to your JSON File:");
            string? pathResponse = await Console.In.ReadLineAsync();
        RESTART:
            await Console.Out.WriteLineAsync("Enter the Id or Username of the player you want to search for:");
            string? playerResponse = await Console.In.ReadLineAsync();
            string? jsonData = await File.ReadAllTextAsync(pathResponse);
            BF3Ext bf3 = new();
            Root bf3data = await bf3.LoadBF3Json(jsonData);

            //Team 1 - Username
            var bf3usernamet1 = bf3data.gameReport.players._1.Where(x => x.persona.user.username == playerResponse).FirstOrDefault();
            //Team 2 - Username
            var bf3usernamet2 = bf3data.gameReport.players._2.Where(x => x.persona.user.username == playerResponse).FirstOrDefault();

            //Team 1 - userId
            var bf3useridt1 = bf3data.gameReport.players._1.Where(x => x.persona.userId == playerResponse).FirstOrDefault();
            //Team 2 - userId
            var bf3useridt2 = bf3data.gameReport.players._2.Where(x => x.persona.userId == playerResponse).FirstOrDefault();



            if (bf3usernamet1 != null)
            {
                string json = await Task.Run(() => JsonConvert.SerializeObject(bf3usernamet1, Formatting.Indented));
                await Console.Out.WriteLineAsync(json);
                goto RESTART;
            }

            if (bf3usernamet2 != null)
            {
                string json = await Task.Run(() => JsonConvert.SerializeObject(bf3usernamet2, Formatting.Indented));
                await Console.Out.WriteLineAsync(json);
                goto RESTART;
            }


            if (bf3useridt1 != null)
            {
                string json = await Task.Run(() => JsonConvert.SerializeObject(bf3useridt1, Formatting.Indented));
                await Console.Out.WriteLineAsync(json);
                goto RESTART;
            }
            
            if (bf3useridt2 != null)
            {
                string json = await Task.Run(() => JsonConvert.SerializeObject(bf3useridt2, Formatting.Indented));
                await Console.Out.WriteLineAsync(json);
                goto RESTART;
            }
        }
    }
}