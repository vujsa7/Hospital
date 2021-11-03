﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Class_Library.Graphical_Editor.Interfaces;
using Hospital_Class_Library.Graphical_Editor.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Class_Library.Graphical_Editor.DAL.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly AppDbContext _context;
        public BuildingRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Building>> GetAllBuildings()
        {
            return await _context.Buildings.ToListAsync();
        }

        public async Task<Building> GetBuildingById(string id)
        {
            return await _context.Buildings.FindAsync(id);
        }

        public async Task<int> PutBuilding(string id, Building building)
        {
            _context.Entry(building).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildingExists(id))
                {
                    return -1;
                }

                throw;
            }

            return 0;
        }
        private bool BuildingExists(String id)
        {
            return _context.Buildings.Any(e => e.Id == id);
        }
    }
}
