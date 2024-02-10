using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.Core.Entities;
using SignalR.Core.Services;
using SignalR.Dto.AboutDto;
using SignalRApi.Mapper;

namespace SignalRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{

    private readonly IAboutService _aboutService;
    private readonly IMapper _mapper;
    public AboutController(IAboutService aboutService, IMapper mapper)
    {
        _aboutService = aboutService;
        _mapper = mapper;
    }


    [HttpGet]
    public async Task<IActionResult> AboutList()
    {
        var entities = await _aboutService.GetListAllAsync();
        return Ok(entities);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
    {
        var entity = _mapper.Map<About>(createAboutDto);
        await _aboutService.AddAsync(entity);
        return Ok("Created");
    }


    [HttpDelete]

    public async Task<IActionResult> DeleteAbout(int id)
    {
        var entity = await _aboutService.GetByIdAsync(id);

        if (entity is null)
            return NotFound("Id not found");
        await _aboutService.DeleteAsync(entity);
        return Ok("Deleted");

    }

    [HttpPut]
    public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        var entity = _mapper.Map<About>(updateAboutDto);
        await _aboutService.UpdateAsync(entity);

        return Ok("Updated");
    }

    [HttpGet("GetAbout")]
    public async Task<IActionResult> GetAbout(int id)
    {        
        var entity = await _aboutService.GetByIdAsync(id);

        return Ok(entity);

    }

}