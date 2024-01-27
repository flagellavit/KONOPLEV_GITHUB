using AutoMapper;
using CLUB.API.Models;
using CLUB.API.ModelsRequest;
using CLUB.SERVICES.CONTRACTS.Interface;
using CLUB.SERVICES.CONTRACTS.ModelRequest;
using Microsoft.AspNetCore.Mvc;

namespace CLUB.API.Controllers
{
    /// <summary>
    /// CRUD контроллер по работы с ключами доступа
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(GroupName = "Client")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService сlientService;
        private readonly IMapper mapper;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ClientController"/>
        /// </summary>
        public ClientController(IClientService clientsService,
            IMapper mapper)
        {
            this.сlientService = clientsService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Получает список всех клиентов
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await сlientService.GetAllAsync(cancellationToken);
            return Ok(mapper.Map<IEnumerable<ClientResp>>(result));
        }

        /// <summary>
        /// Получает список клиента по Id
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await сlientService.GetByIdAsync(id, cancellationToken);
            if (item == null) return NotFound($"Не удалось найти ключ с идентификатором {id}");
            return Ok(mapper.Map<ClientResp>(item));
        }

        /// <summary>
        /// Создаёт нового клиента
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(ClientReqCreate request, CancellationToken cancellationToken)
        {

            var ClientReqModel = mapper.Map<ClientReq>(request);
            var result = await сlientService.AddAsync(ClientReqModel, cancellationToken);
            return Ok(mapper.Map<ClientResp>(result));
        }
        /// <summary>
        /// Редактирует существующего клиента
        /// </summary>
        [HttpPut]
        public async Task<IActionResult> Edit(ClientReqEdit request, CancellationToken cancellationToken)
        {
            var model = mapper.Map<ClientReq>(request);
            var result = await сlientService.EditAsync(model, cancellationToken);
            return Ok(mapper.Map<ClientResp>(result));
        }


        /// <summary>
        /// Удаляет существующего клиента
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            await сlientService.DeleteAsync(id, cancellationToken);
            return Ok();
        }
    }
}
