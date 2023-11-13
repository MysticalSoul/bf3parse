using Newtonsoft.Json;

namespace bf3parse
{
    public class BF3Util
    {
        public class _1
        {
            public int initialTickets { get; set; }
            public int deaths { get; set; }
            public string userId { get; set; }
            public int rank { get; set; }
            public int killAssists { get; set; }
            public object skill { get; set; }
            public int heals { get; set; }
            public string personaId { get; set; }
            public bool dnf { get; set; }
            public object firstGrapplingHook { get; set; }
            public object revives { get; set; }
            public object commanderScore { get; set; }
            public object firstZipline { get; set; }
            public double accuracy { get; set; }
            public Persona persona { get; set; }
            public int kills { get; set; }
            public int team { get; set; }
            public User user { get; set; }
            public int killStreak { get; set; }
            public int combatScore { get; set; }
            public int squadId { get; set; }
            public int gunMasterLevel { get; set; }
            public object isCommander { get; set; }
            public object isSoldier { get; set; }
        }

        public class _2
        {
            public int initialTickets { get; set; }
            public int deaths { get; set; }
            public string userId { get; set; }
            public int rank { get; set; }
            public int killAssists { get; set; }
            public object skill { get; set; }
            public int heals { get; set; }
            public string personaId { get; set; }
            public bool dnf { get; set; }
            public object firstGrapplingHook { get; set; }
            public object revives { get; set; }
            public object commanderScore { get; set; }
            public object firstZipline { get; set; }
            public double accuracy { get; set; }
            public Persona persona { get; set; }
            public int kills { get; set; }
            public int team { get; set; }
            public User user { get; set; }
            public int killStreak { get; set; }
            public int combatScore { get; set; }
            public int squadId { get; set; }
            public int gunMasterLevel { get; set; }
            public object isCommander { get; set; }
            public object isSoldier { get; set; }
        }

        public class Accuracy
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class Assault
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class Awardscore
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class Engineer
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class GameReport
        {
            public string gameMode { get; set; }
            public TeamFactionMapping teamFactionMapping { get; set; }
            public Prizes prizes { get; set; }
            public int duration { get; set; }
            public MapModeResult mapModeResult { get; set; }
            public string id { get; set; }
            public int createdAt { get; set; }
            public object isFavorite { get; set; }
            public int platform { get; set; }
            public UnlocksAndAwards unlocksAndAwards { get; set; }
            public int winner { get; set; }
            public InitialMapValues initialMapValues { get; set; }
            public Players players { get; set; }
            public List<object> topScorers { get; set; }
            public GameServer gameServer { get; set; }
        }

        public class Games
        {
        }

        public class GameServer
        {
            public string map { get; set; }
            public object gameId { get; set; }
            public object gameExpansions { get; set; }
            public string mapMode { get; set; }
            public object ip { get; set; }
            public string matchId { get; set; }
            public string protocolVersionString { get; set; }
            public object extendedInfo { get; set; }
            public object game { get; set; }
            public bool ranked { get; set; }
            public bool online { get; set; }
            public object platform { get; set; }
            public int tickRateMax { get; set; }
            public object updatedAt { get; set; }
            public Slots slots { get; set; }
            public object guid { get; set; }
            public object port { get; set; }
            public bool punkbuster { get; set; }
            public object playlist { get; set; }
            public object gameExpansion { get; set; }
            public string name { get; set; }
            public Settings settings { get; set; }
            public object fairfight { get; set; }
            public object region { get; set; }
            public int mapVariant { get; set; }
            public int ping { get; set; }
            public int serverType { get; set; }
            public object experience { get; set; }
            public int tickRate { get; set; }
            public object hasPassword { get; set; }
            public object maps { get; set; }
            public object secret { get; set; }
            public int preset { get; set; }
            public object pingSite { get; set; }
            public string country { get; set; }
        }

        public class InitialMapValues
        {
            [JsonProperty("1")]
            public _1 _1 { get; set; }

            [JsonProperty("2")]
            public _2 _2 { get; set; }
        }

        public class Kills
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class MapModeResult
        {
            public Ticket ticket { get; set; }
        }

        public class OnlineGame
        {
            public int platform { get; set; }
            public int game { get; set; }
            public string personaId { get; set; }
        }

        public class Persona
        {
            public string picture { get; set; }
            public string userId { get; set; }
            public User user { get; set; }
            public int updatedAt { get; set; }
            public string firstPartyId { get; set; }
            public string personaId { get; set; }
            public string personaName { get; set; }
            public string gamesLegacy { get; set; }
            public string @namespace { get; set; }
            public string gamesJson { get; set; }
            public Games games { get; set; }
            public string clanTag { get; set; }
        }

        public class Players
        {
            [JsonProperty("1")]
            public List<_1> _1 { get; set; }

            [JsonProperty("2")]
            public List<_2> _2 { get; set; }
        }

        public class PlayingMp
        {
            public string gameId { get; set; }
            public List<int> gameExpansions { get; set; }
            public string gameMode { get; set; }
            public string serverGuid { get; set; }
            public int game { get; set; }
            public string levelName { get; set; }
            public string personaId { get; set; }
            public string serverName { get; set; }
            public int experience { get; set; }
            public int platform { get; set; }
            public int role { get; set; }
        }

        public class Presence
        {
            public string userId { get; set; }
            public int updatedAt { get; set; }
            public string presenceStates { get; set; }
            public bool? isOnline { get; set; }
            public OnlineGame onlineGame { get; set; }
            public PlayingMp playingMp { get; set; }
            public bool? isPlaying { get; set; }
        }

        public class Prizes
        {
            public Kills kills { get; set; }
            public Recon recon { get; set; }
            public Awardscore awardscore { get; set; }
            public Support support { get; set; }
            public Assault assault { get; set; }
            public Engineer engineer { get; set; }
            public Accuracy accuracy { get; set; }
        }

        public class Recon
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class Root
        {
            public bool isOwnBattleReport { get; set; }
            public GameReport gameReport { get; set; }
            public bool isBrokenBattleReport { get; set; }
            public bool isBRPremiumFeaturesEnabled { get; set; }
        }

        public class Settings
        {
        }

        public class Slots
        {
        }

        public class Support
        {
            public object squadId { get; set; }
            public string personaId { get; set; }
            public Persona persona { get; set; }
            public User user { get; set; }
            public object importance { get; set; }
            public string type { get; set; }
            public int score { get; set; }
            public string userId { get; set; }
            public object teamId { get; set; }
        }

        public class TeamFactionMapping
        {
            [JsonProperty("1")]
            public string _1 { get; set; }

            [JsonProperty("2")]
            public string _2 { get; set; }
        }

        public class Ticket
        {
            [JsonProperty("1")]
            public int _1 { get; set; }

            [JsonProperty("2")]
            public int _2 { get; set; }
        }

        public class UnlocksAndAwards
        {
        }

        public class User
        {
            public string username { get; set; }
            public object gravatarMd5 { get; set; }
            public string userId { get; set; }
            public int createdAt { get; set; }
            public Presence presence { get; set; }
        }
    }
}
