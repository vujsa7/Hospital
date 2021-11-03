﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital_Class_Library.Graphical_Editor.DAL;
using Hospital_Class_Library.Graphical_Editor.Interfaces;
using Hospital_Class_Library.Graphical_Editor.Models;

namespace Hospital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly IBuildingRepository _buildingsRepo;

        public BuildingsController(IBuildingRepository buildingsRepo)
        {
            _buildingsRepo = buildingsRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Building>>> GetBuildings()
        {
            return await _buildingsRepo.GetAllBuildings();
        }

        // GET: api/buildings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Building>> GetBuilding(String id)
        {
            var building = await _buildingsRepo.GetBuildingById(id);

            if (building == null)
            {
                return NotFound();
            }

            return building;
        }

        // PUT: api/buildings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuilding(String id, Building building)
        {
            if (id != building.Id)
            {
                return BadRequest();
            }

            if ((await _buildingsRepo.PutBuilding(id, building)) == -1)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
