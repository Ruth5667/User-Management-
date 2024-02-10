using AutoMapper;
using Subscribere_Core.DTO;
using Subscribere_Core.Response;
using Subscribere_Data.models;
using System.Runtime.Intrinsics.X86;

namespace ProjectRuth.Config
{
    public class ProjectRuthProfile : Profile
    {
        public ProjectRuthProfile()
        {
            CreateMap<CardDto, CardTable>().ReverseMap();
            //CreateMap<Student   , StudentDTO>();
            CreateMap<SubscriberDto, Subscriber>().ReverseMap();
            ///שינוי בין שמות פרמטרים במקרה וזה לא אותו שם
            CreateMap<BaseResponseGeneral<CardTable>, BaseResponseGeneral<CardDto>>();

            //CreateMap<Student, StudentDTO>().ForMember(sss => sss.FulName, m => m.MapFrom(source => source.FirstName + source.LastName));
        }
    }
}