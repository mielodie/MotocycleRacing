using MotorcycleRacing.Payloads.DTOs;
using MotorcycleRacing.Payloads.Requests;
using MotorcycleRacing.Payloads.Responses;

namespace MotorcycleRacing.Service.Interfaces
{
    public interface IMotoService
    {
        ResponseObject<MotoDTO> AddData(MotoRequest request);
        IQueryable<MotoDTO> GetData();
    }
}
