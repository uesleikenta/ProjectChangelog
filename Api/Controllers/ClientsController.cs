using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChangelogProject.Infra.Data;
using ChangelogProject.Infra.Models;
using ChangelogProject.Infra.Repositories;

namespace ChangelogProject.Api.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class ClientsController : ControllerBase {
		private readonly ClientRepository _clientRepository;
		public ClientsController(ClientRepository clientRepository) {
			_clientRepository = clientRepository;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Client>>> GetClients() {
			var clients = await _clientRepository.GetAll();
			return Ok(clients);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Client>> GetClient(string id) {
			var client = await _clientRepository.GetById(id);
			if (client == null)
				return NotFound();

			return Ok(client);
		}

		[HttpPost]
		public async Task<ActionResult> CreateClient(Client createClientDto) {
			await _clientRepository.Create(createClientDto);
			return Ok(createClientDto);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> DeleteClient(string id) {
			await _clientRepository.Delete(id);
			return Ok();
		}

		[HttpPut("{id}")]
		public async Task<ActionResult> UpdateClient(string id, Client updateClientDto) {
			var client = await _clientRepository.GetById(id);
			if (client == null)
				return NotFound();

			await _clientRepository.Update(updateClientDto);
			return Ok(client);
		}
	}
}