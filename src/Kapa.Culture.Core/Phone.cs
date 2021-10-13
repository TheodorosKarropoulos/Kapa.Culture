﻿using System;
using System.Collections.Generic;

namespace Kapa.Culture
{
    public static class Phones
    {
        private static readonly IReadOnlyDictionary<string, List<string>> DialingCodesPerCountry =
            new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
            {
                {Countries.AfghanistanTwoLetterCode, new List<string> {"93"}},
                {Countries.AlandIslandsTwoLetterCode, new List<string> {"358 18"}},
                {Countries.AlbaniaTwoLetterCode, new List<string> {"355"}},
                {Countries.AlgeriaTwoLetterCode, new List<string> {"213"}},
                {Countries.AmericanSamoaTwoLetterCode, new List<string> {"1 684"}},
                {Countries.AndorraTwoLetterCode, new List<string> {"376"}},
                {Countries.AngolaTwoLetterCode, new List<string> {"244"}},
                {Countries.AnguillaTwoLetterCode, new List<string> {"1 264"}},
                {Countries.AntiguaAndBarbudaTwoLetterCode, new List<string> {"1 268"}},
                {Countries.ArgentinaTwoLetterCode, new List<string> {"54"}},
                {Countries.ArmeniaTwoLetterCode, new List<string> {"374"}},
                {Countries.ArubaTwoLetterCode, new List<string> {"297"}},
                {Countries.AustraliaTwoLetterCode, new List<string> {"61"}},
                {Countries.AustriaTwoLetterCode, new List<string> {"43"}},
                {Countries.AzerbaijanTwoLetterCode, new List<string> {"994"}},
                {Countries.BahamasTwoLetterCode, new List<string> {"1 242"}},
                {Countries.BahrainTwoLetterCode, new List<string> {"973"}},
                {Countries.BangladeshTwoLetterCode, new List<string> {"880"}},
                {Countries.BarbadosTwoLetterCode, new List<string> {"1 246"}},
                {Countries.BelarusTwoLetterCode, new List<string> {"375"}},
                {Countries.BelgiumTwoLetterCode, new List<string> {"32"}},
                {Countries.BelizeTwoLetterCode, new List<string> {"501"}},
                {Countries.BeninTwoLetterCode, new List<string> {"229"}},
                {Countries.BermudaTwoLetterCode, new List<string> {"1 441"}},
                {Countries.BhutanTwoLetterCode, new List<string> {"975"}},
                {Countries.BoliviaTwoLetterCode, new List<string> {"591"}},
                {Countries.BosniaAndHerzegovinaTwoLetterCode, new List<string> {"387"}},
                {Countries.BotswanaTwoLetterCode, new List<string> {"267"}},
                {Countries.BrazilTwoLetterCode, new List<string> {"55"}},
                {Countries.BritishIndianOceanTerritoryTwoLetterCode, new List<string> {"246"}},
                {Countries.BruneiDarussalamTwoLetterCode, new List<string> {"673"}},
                {Countries.BulgariaTwoLetterCode, new List<string> {"359"}},
                {Countries.BurkinaFasoTwoLetterCode, new List<string> {"226"}},
                {Countries.BurundiTwoLetterCode, new List<string> {"257"}},
                {Countries.CapeVerdeTwoLetterCode, new List<string> {"238"}},
                {Countries.CambodiaTwoLetterCode, new List<string> {"855"}},
                {Countries.CameroonTwoLetterCode, new List<string> {"237"}},
                {Countries.CanadaTwoLetterCode, new List<string> {"1"}},
                {Countries.CaribbeanNetherlandsTwoLetterCode, new List<string> {"599 3", "599 4", "599 7"}},
                {Countries.CaymanIslandsTwoLetterCode, new List<string> {"1 345"}},
                {Countries.CentralAfricanRepublicTwoLetterCode, new List<string> {"236"}},
                {Countries.ChadTwoLetterCode, new List<string> {"235"}},
                {Countries.ChileTwoLetterCode, new List<string> {"56"}},
                {Countries.ChinaTwoLetterCode, new List<string> {"86"}},
                {Countries.ChristmasIslandTwoLetterCode, new List<string> {"61 89164"}},
                {Countries.CocosKeelingIslandsTwoLetterCode, new List<string> {"61 89162"}},
                {Countries.ColombiaTwoLetterCode, new List<string> {"57"}},
                {Countries.ComorosTwoLetterCode, new List<string> {"269"}},
                {Countries.CongoTwoLetterCode, new List<string> {"242"}},
                {Countries.CongoDemocraticRepublicTwoLetterCode, new List<string> {"243"}},
                {Countries.CookIslandsTwoLetterCode, new List<string> {"682"}},
                {Countries.CostaRicaTwoLetterCode, new List<string> {"506"}},
                {Countries.CroatiaTwoLetterCode, new List<string> {"385"}},
                {Countries.CubaTwoLetterCode, new List<string> {"53"}},
                {Countries.CuracaoTwoLetterCode, new List<string> {"599 9"}},
                {Countries.CyprusTwoLetterCode, new List<string> {"357"}},
                {Countries.CzechiaTwoLetterCode, new List<string> {"420"}},
                {Countries.DenmarkTwoLetterCode, new List<string> {"45"}},
                {Countries.DjiboutiTwoLetterCode, new List<string> {"253"}},
                {Countries.DominicaTwoLetterCode, new List<string> {"1 767"}},
                {Countries.DominicanRepublicTwoLetterCode, new List<string> {"1 809", "1 829", "1 849"}},
                {Countries.EcuadorTwoLetterCode, new List<string> {"593"}},
                {Countries.EgyptTwoLetterCode, new List<string> {"20"}},
                {Countries.ElSalvadorTwoLetterCode, new List<string> {"503"}},
                {Countries.EquatorialGuineaTwoLetterCode, new List<string> {"240"}},
                {Countries.EritreaTwoLetterCode, new List<string> {"291"}},
                {Countries.EstoniaTwoLetterCode, new List<string> {"372"}},
                {Countries.EswatiniTwoLetterCode, new List<string> {"268"}},
                {Countries.EthiopiaTwoLetterCode, new List<string> {"251"}},
                {Countries.FalklandIslandsTwoLetterCode, new List<string> {"500"}},
                {Countries.FaroeIslandsTwoLetterCode, new List<string> {"298"}},
                {Countries.FijiTwoLetterCode, new List<string> {"679"}},
                {Countries.FinlandTwoLetterCode, new List<string> {"358"}},
                {Countries.FranceTwoLetterCode, new List<string> {"33"}},
                {Countries.FrenchGuianaTwoLetterCode, new List<string> {"594"}},
                {Countries.FrenchPolynesiaTwoLetterCode, new List<string> {"689"}},
                {Countries.GabonTwoLetterCode, new List<string> {"241"}},
                {Countries.GambiaTwoLetterCode, new List<string> {"220"}},
                {Countries.GeorgiaTwoLetterCode, new List<string> {"995"}},
                {Countries.GermanyTwoLetterCode, new List<string> {"49"}},
                {Countries.GhanaTwoLetterCode, new List<string> {"233"}},
                {Countries.GibraltarTwoLetterCode, new List<string> {"350"}},
                {Countries.GreeceTwoLetterCode, new List<string> {"30"}},
                {Countries.GreenlandTwoLetterCode, new List<string> {"299"}},
                {Countries.GrenadaTwoLetterCode, new List<string> {"1 473"}},
                {Countries.GuadeloupeTwoLetterCode, new List<string> {"590"}},
                {Countries.GuamTwoLetterCode, new List<string> {"1 671"}},
                {Countries.GuatemalaTwoLetterCode, new List<string> {"502"}},
                {Countries.GuernseyTwoLetterCode, new List<string> {"44 1481", "44 7781", "44 7839", "44 7911"}},
                {Countries.GuineaTwoLetterCode, new List<string> {"224"}},
                {Countries.GuineaBissauTwoLetterCode, new List<string> {"245"}},
                {Countries.GuyanaTwoLetterCode, new List<string> {"592"}},
                {Countries.HaitiTwoLetterCode, new List<string> {"509"}},
                {Countries.HolySeeTwoLetterCode, new List<string> { }},
                {Countries.HondurasTwoLetterCode, new List<string> {"504"}},
                {Countries.HongKongTwoLetterCode, new List<string> {"852"}},
                {Countries.HungaryTwoLetterCode, new List<string> {"36"}},
                {Countries.IcelandTwoLetterCode, new List<string> {"354"}},
                {Countries.IndiaTwoLetterCode, new List<string> {"91"}},
                {Countries.IndonesiaTwoLetterCode, new List<string> {"62"}},
                {Countries.IranTwoLetterCode, new List<string> {"98"}},
                {Countries.IraqTwoLetterCode, new List<string> {"964"}},
                {Countries.IrelandTwoLetterCode, new List<string> {"353"}},
                {Countries.IsleofManTwoLetterCode, new List<string> {"44 1624", "44 7524", "44 7624", "44 7924"}},
                {Countries.IsraelTwoLetterCode, new List<string> {"972"}},
                {Countries.ItalyTwoLetterCode, new List<string> {"39"}},
                {Countries.IvoryCoastTwoLetterCode, new List<string> {"225"}},
                {Countries.JamaicaTwoLetterCode, new List<string> {"1 658", "1 876"}},
                {Countries.JapanTwoLetterCode, new List<string> {"81"}},
                {Countries.JerseyTwoLetterCode, new List<string> {"44 1534"}},
                {Countries.JordanTwoLetterCode, new List<string> {"962"}},
                {Countries.KazakhstanTwoLetterCode, new List<string> {"7"}},
                {Countries.KenyaTwoLetterCode, new List<string> {"254"}},
                {Countries.KiribatiTwoLetterCode, new List<string> {"686"}},
                {Countries.KosovoTwoLetterCode, new List<string> {"383"}},
                {Countries.KuwaitTwoLetterCode, new List<string> {"965"}},
                {Countries.KyrgyzstanTwoLetterCode, new List<string> {"996"}},
                {Countries.LaosTwoLetterCode, new List<string> {"856"}},
                {Countries.LatviaTwoLetterCode, new List<string> {"371"}},
                {Countries.LebanonTwoLetterCode, new List<string> {"961"}},
                {Countries.LesothoTwoLetterCode, new List<string> {"266"}},
                {Countries.LiberiaTwoLetterCode, new List<string> {"231"}},
                {Countries.LibyaTwoLetterCode, new List<string> {"218"}},
                {Countries.LiechtensteinTwoLetterCode, new List<string> {"423"}},
                {Countries.LithuaniaTwoLetterCode, new List<string> {"370"}},
                {Countries.LuxembourgTwoLetterCode, new List<string> {"352"}},
                {Countries.MacauTwoLetterCode, new List<string> {"853"}},
                {Countries.MadagascarTwoLetterCode, new List<string> {"261"}},
                {Countries.MalawiTwoLetterCode, new List<string> {"265"}},
                {Countries.MalaysiaTwoLetterCode, new List<string> {"60"}},
                {Countries.MaldivesTwoLetterCode, new List<string> {"960"}},
                {Countries.MaliTwoLetterCode, new List<string> {"223"}},
                {Countries.MaltaTwoLetterCode, new List<string> {"356"}},
                {Countries.MarshallIslandsTwoLetterCode, new List<string> {"692"}},
                {Countries.MartiniqueTwoLetterCode, new List<string> {"596"}},
                {Countries.MauritaniaTwoLetterCode, new List<string> {"222"}},
                {Countries.MauritiusTwoLetterCode, new List<string> {"230"}},
                {Countries.MayotteTwoLetterCode, new List<string> {"262"}},
                {Countries.MexicoTwoLetterCode, new List<string> {"52"}},
                {Countries.MicronesiaTwoLetterCode, new List<string> {"691"}},
                {Countries.MoldovaTwoLetterCode, new List<string> {"373"}},
                {Countries.MonacoTwoLetterCode, new List<string> {"377"}},
                {Countries.MongoliaTwoLetterCode, new List<string> {"976"}},
                {Countries.MontenegroTwoLetterCode, new List<string> {"382"}},
                {Countries.MontserratTwoLetterCode, new List<string> {"1 664"}},
                {Countries.MoroccoTwoLetterCode, new List<string> {"212"}},
                {Countries.MozambiqueTwoLetterCode, new List<string> {"258"}},
                {Countries.MyanmarTwoLetterCode, new List<string> {"95"}},
                {Countries.NamibiaTwoLetterCode, new List<string> {"264"}},
                {Countries.NauruTwoLetterCode, new List<string> {"674"}},
                {Countries.NepalTwoLetterCode, new List<string> {"977"}},
                {Countries.NetherlandsTwoLetterCode, new List<string> {"31"}},
                {Countries.NewCaledoniaTwoLetterCode, new List<string> {"687"}},
                {Countries.NewZealandTwoLetterCode, new List<string> {"64"}},
                {Countries.NicaraguaTwoLetterCode, new List<string> {"505"}},
                {Countries.NigerTwoLetterCode, new List<string> {"227"}},
                {Countries.NigeriaTwoLetterCode, new List<string> {"234"}},
                {Countries.NiueTwoLetterCode, new List<string> {"683"}},
                {Countries.NorfolkIslandTwoLetterCode, new List<string> {"389"}},
                {Countries.NorthernMarianaIslandsTwoLetterCode, new List<string> {"1 670"}},
                {Countries.NorthKoreaTwoLetterCode, new List<string> {"850"}},
                {Countries.NorthMacedoniaTwoLetterCode, new List<string> {"389"}},
                {Countries.NorwayTwoLetterCode, new List<string> {"47"}},
                {Countries.OmanTwoLetterCode, new List<string> {"968"}},
                {Countries.PakistanTwoLetterCode, new List<string> {"92"}},
                {Countries.PalauTwoLetterCode, new List<string> {"680"}},
                {Countries.PalestineTwoLetterCode, new List<string> {"970"}},
                {Countries.PanamaTwoLetterCode, new List<string> {"507"}},
                {Countries.PapuaNewGuineaTwoLetterCode, new List<string> {"675"}},
                {Countries.ParaguayTwoLetterCode, new List<string> {"595"}},
                {Countries.PeruTwoLetterCode, new List<string> {"51"}},
                {Countries.PhilippinesTwoLetterCode, new List<string> {"63"}},
                {Countries.PitcairnTwoLetterCode, new List<string> {"64"}},
                {Countries.PolandTwoLetterCode, new List<string> {"48"}},
                {Countries.PortugalTwoLetterCode, new List<string> {"351"}},
                {Countries.PuertoRicoTwoLetterCode, new List<string> {"1 787", "1 939"}},
                {Countries.QatarTwoLetterCode, new List<string> {"974"}},
                {Countries.RomaniaTwoLetterCode, new List<string> {"40"}},
                {Countries.RussiaTwoLetterCode, new List<string> {"7"}},
                {Countries.RwandaTwoLetterCode, new List<string> {"250"}},
                {Countries.ReunionTwoLetterCode, new List<string> {"262"}},
                {Countries.SaintBarthelemyTwoLetterCode, new List<string> {"590"}},
                {Countries.SaintHelenaAscensionAndTristanDaCunhaTwoLetterCode, new List<string> {"290"}},
                {Countries.SaintKittsAndNevisTwoLetterCode, new List<string> {"1 869"}},
                {Countries.SaintLuciaTwoLetterCode, new List<string> {"1 758"}},
                {Countries.SaintMartinTwoLetterCode, new List<string> {"590"}},
                {Countries.SaintPierreAndMiquelonTwoLetterCode, new List<string> {"508"}},
                {Countries.SaintVincentAndTheGrenadinesTwoLetterCode, new List<string> {"1 784"}},
                {Countries.SamoaTwoLetterCode, new List<string> {"685"}},
                {Countries.SanMarinoTwoLetterCode, new List<string> {"378"}},
                {Countries.SaoTomeAndPrincipeTwoLetterCode, new List<string> {"239"}},
                {Countries.SaudiArabiaTwoLetterCode, new List<string> {"966"}},
                {Countries.SenegalTwoLetterCode, new List<string> {"221"}},
                {Countries.SerbiaTwoLetterCode, new List<string> {"381"}},
                {Countries.SeychellesTwoLetterCode, new List<string> {"248"}},
                {Countries.SierraLeoneTwoLetterCode, new List<string> {"232"}},
                {Countries.SingaporeTwoLetterCode, new List<string> {"65"}},
                {Countries.SintMaartenTwoLetterCode, new List<string> {"1 721"}},
                {Countries.SlovakiaTwoLetterCode, new List<string> {"421"}},
                {Countries.SloveniaTwoLetterCode, new List<string> {"386"}},
                {Countries.SolomonIslandsTwoLetterCode, new List<string> {"677"}},
                {Countries.SomaliaTwoLetterCode, new List<string> {"252"}},
                {Countries.SouthAfricaTwoLetterCode, new List<string> {"27"}},
                {Countries.SouthKoreaTwoLetterCode, new List<string> {"82"}},
                {Countries.SouthSudanTwoLetterCode, new List<string> {"211"}},
                {Countries.SpainTwoLetterCode, new List<string> {"34"}},
                {Countries.SriLankaTwoLetterCode, new List<string> {"94"}},
                {Countries.SudanTwoLetterCode, new List<string> {"249"}},
                {Countries.SurinameTwoLetterCode, new List<string> {"597"}},
                {Countries.SvalbardAndJanMayenTwoLetterCode, new List<string> {"47 79"}},
                {Countries.SwedenTwoLetterCode, new List<string> {"46"}},
                {Countries.SwitzerlandTwoLetterCode, new List<string> {"41"}},
                {Countries.SyrianArabRepublicTwoLetterCode, new List<string> {"963"}},
                {Countries.TaiwanTwoLetterCode, new List<string> {"886"}},
                {Countries.TajikistanTwoLetterCode, new List<string> {"992"}},
                {Countries.TanzaniaTwoLetterCode, new List<string> {"255"}},
                {Countries.ThailandTwoLetterCode, new List<string> {"66"}},
                {Countries.TimorLesteTwoLetterCode, new List<string> {"670"}},
                {Countries.TogoTwoLetterCode, new List<string> {"228"}},
                {Countries.TokelauTwoLetterCode, new List<string> {"690"}},
                {Countries.TongaTwoLetterCode, new List<string> {"676"}},
                {Countries.TrinidadAndTobagoTwoLetterCode, new List<string> {"1 868"}},
                {Countries.TunisiaTwoLetterCode, new List<string> {"216"}},
                {Countries.TurkeyTwoLetterCode, new List<string> {"90"}},
                {Countries.TurkmenistanTwoLetterCode, new List<string> {"993"}},
                {Countries.TurksAndCaicosIslandsTwoLetterCode, new List<string> {"1 649"}},
                {Countries.TuvaluTwoLetterCode, new List<string> {"688"}},
                {Countries.UgandaTwoLetterCode, new List<string> {"256"}},
                {Countries.UkraineTwoLetterCode, new List<string> {"380"}},
                {Countries.UnitedArabEmiratesTwoLetterCode, new List<string> {"971"}},
                {Countries.UnitedKingdomTwoLetterCode, new List<string> {"44"}},
                {Countries.UnitedStatesMinorOutlyingIslandsTwoLetterCode, new List<string> { }},
                {Countries.UnitedStatesOfAmericaTwoLetterCode, new List<string> {"1"}},
                {Countries.UruguayTwoLetterCode, new List<string> {"598"}},
                {Countries.UzbekistanTwoLetterCode, new List<string> {"998"}},
                {Countries.VanuatuTwoLetterCode, new List<string> {"678"}},
                {Countries.VenezuelaTwoLetterCode, new List<string> {"58"}},
                {Countries.VietnamTwoLetterCode, new List<string> {"84"}},
                {Countries.VirginIslandsBritishTwoLetterCode, new List<string> {"1 284"}},
                {Countries.VirginIslandsUSTwoLetterCode, new List<string> {"1 340"}},
                {Countries.WallisAndFutunaTwoLetterCode, new List<string> {"681"}},
                {Countries.YemenTwoLetterCode, new List<string> {"967"}},
                {Countries.ZambiaTwoLetterCode, new List<string> {"260"}},
                {Countries.ZimbabweTwoLetterCode, new List<string> {"263"}}
            };

        public static IEnumerable<string> GetDialingCodesFromTwoLetterCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return default;
            }

            return DialingCodesPerCountry.TryGetValue(code.Trim(), out var prefixes) ? prefixes : default;
        }
    }
}