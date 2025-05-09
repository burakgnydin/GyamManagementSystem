using GymManagementSystem_API.DTO;
using GymManagementSystem_API.Entity;

namespace GymManagementSystem_API.Services.Abstracts
{
    public interface IMemberService
    {
        Task<EditMemberDTO> UpdateMember(EditMemberDTO member);
        Task<EditMemberInfoDTO> EditMemberInfo(EditMemberInfoDTO member);
        Task<ServiceResponse<List<EditAppointmentDTO>>> GetAllAppointmentsAsync();
        Task<EditAppointmentDTO> CreateAppointment(EditAppointmentDTO appointment);
        Task<bool> DeleteAppointmentAsync(GetAppointmentDto appointment);
        Task<UpdateWaterDTO> EditAmountOfWaterAsync(UpdateWaterDTO water);

        //yeni i�erik ve controller yap�lacak
        Task<ServiceResponse<List<Trainer>>> GetAllTrainersAsync();
        Task<ServiceResponse<bool>> ChooseTrainerAsync(GetAppointmentDto appointment); 
        Task<ServiceResponse<string>> GetBodyTypeAsync(GetMemberDto member);
        Task<EditMemberDTO> UpdateMemberInfoAsync(EditMemberDTO member);
    }
}
