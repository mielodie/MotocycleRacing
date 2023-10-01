using MotorcycleRacing.Entities;
using MotorcycleRacing.Payloads.DTOs;

namespace MotorcycleRacing.Payloads.Converters
{
    public class MotoConverter
    {
        public MotoDTO EntityToDTO(MotoGP motoGP)
        {
            return new MotoDTO
            {
                AME = motoGP.AME,
                ARA = motoGP.ARA,
                ARG = motoGP.ARG,
                AUS = motoGP.AUS,
                AUT = motoGP.AUT,
                CAT = motoGP.CAT,
                FRA = motoGP.FRA,
                INA = motoGP.INA,
                ITA = motoGP.ITA,
                MAL = motoGP.MAL,
                QAT = motoGP.QAT,
                SPA = motoGP.SPA,
                THA = motoGP.THA,
                VAL = motoGP.VAL,
                GBR = motoGP.GBR,
                GER = motoGP.GER,
                JPN = motoGP.JPN,
                Leader = motoGP.Leader,
                NED = motoGP.NED,
                Point = motoGP.Point,
                POR = motoGP.POR,
                Previous = motoGP.Previous,
                Rider = motoGP.Rider,
                RSM = motoGP.RSM,
                Nationality = motoGP.Nationality
            };
        }
    }
}
