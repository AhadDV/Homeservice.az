using AutoMapper;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.MessageDto;
using HomeService.service.Dtos.TeamDto;
using HomeService.service.Dtos.TeamRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Profiles
{
   public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Setting, SettingGetDto>();
            CreateMap<Team, TeamGetDto>();
            CreateMap<TeamPostDto, Team>();
            CreateMap<MessagePostDto, Message>();
            CreateMap<Message, MessageGetDto>();
        }
    }
}
