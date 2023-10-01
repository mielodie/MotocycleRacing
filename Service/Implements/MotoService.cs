using MotorcycleRacing.AppDbContexts;
using MotorcycleRacing.Entities;
using MotorcycleRacing.Payloads.Converters;
using MotorcycleRacing.Payloads.DTOs;
using MotorcycleRacing.Payloads.Requests;
using MotorcycleRacing.Payloads.Responses;
using MotorcycleRacing.Service.Interfaces;

namespace MotorcycleRacing.Service.Implements
{
    public class MotoService : IMotoService
    {
        private readonly AppDbContext _context;
        private readonly ResponseObject<MotoDTO> _responseObject;
        private readonly MotoConverter _converter;

        public MotoService()
        {
            _context = new AppDbContext();
            _responseObject = new ResponseObject<MotoDTO>();
            _converter = new MotoConverter();
        }

        public ResponseObject<MotoDTO> AddData(MotoRequest request)
        {
            var moto = new MotoGP();
            moto.GBR = request.GBR;
            moto.ARG = request.ARG;
            moto.VAL = request.VAL;
            moto.QAT = request.QAT;
            moto.POR = request.POR;
            moto.CAT = request.CAT;
            moto.MAL = request.MAL;
            moto.GER = request.GER;
            moto.RSM = request.RSM;
            moto.SPA = request.SPA;
            moto.AME = request.AME;
            moto.ARA = request.ARA;
            moto.AUS = request.AUS;
            moto.AUT = request.AUT;
            moto.FRA = request.FRA;
            moto.INA = request.INA;
            moto.ITA = request.ITA;
            moto.Nationality = request.Nationality;
            moto.THA = request.THA;
            moto.NED = request.NED;
            moto.Rider = request.Rider;
            moto.JPN = request.JPN;
            moto.Previous = request.Previous;
            moto.Leader = request.Leader;
            _context.motos.Add(moto);
            _context.SaveChanges();
            moto.Point = request.QAT + request.INA + request.ARG + request.AME + request.POR + request.SPA + request.FRA + request.ITA + request.CAT
                        + request.GER + request.NED + request.GBR + request.AUT + request.RSM + request.ARA + request.JPN + request.THA + request.AUS + request.MAL + request.VAL;
            _context.motos.Update(moto);
            _context.SaveChanges();
            return _responseObject.ResponseSuccess("Them du lieu thanh cong", _converter.EntityToDTO(moto));
           
        }

        public IQueryable<MotoDTO> GetData()
        {
            return _context.motos.OrderByDescending(x => x.Point).Select(x => _converter.EntityToDTO(x));
        }
    }
}
