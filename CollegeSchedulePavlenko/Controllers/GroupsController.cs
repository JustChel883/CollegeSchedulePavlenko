using CollegeSchedulePavlenko.DTO;
using CollegeSchedulePavlenko.Services;
using Microsoft.AspNetCore.Mvc;

namespace CollegeSchedule.Controllers
{
    [ApiController]
    [Route("api/groups")]
    public class GroupsController : ControllerBase
    {
        private readonly IScheduleService _service;

        public GroupsController(IScheduleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<GroupDto>>> GetAllGroups()
        {
            var groups = await _service.GetAllGroupsAsync();
            return Ok(groups);
        }
    }
}