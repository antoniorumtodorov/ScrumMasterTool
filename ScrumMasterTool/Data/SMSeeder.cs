using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using ScrumMasterTool.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumMasterTool.Data
{
    public class SMSeeder
    {
        private readonly ScrumToolContext _ctx;
        private readonly IWebHostEnvironment _hositng;

        public SMSeeder(ScrumToolContext ctx, IWebHostEnvironment hositng)
        {
            _ctx = ctx;
            _hositng = hositng;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();
            if (!_ctx.Members.Any())
            {
                var filepath = Path.Combine(_hositng.ContentRootPath, "Data/SeedData/Members.json");
                var json = File.ReadAllText(filepath);
                var members = JsonConvert.DeserializeObject<IEnumerable<Member>>(json);
                _ctx.Members.AddRange(members);

                _ctx.SaveChanges();
            }

            if (!_ctx.Skills.Any())
            {
                var filepath = Path.Combine(_hositng.ContentRootPath, "Data/SeedData/Skills.json");
                var json = File.ReadAllText(filepath);

                var skills = JsonConvert.DeserializeObject<IEnumerable<Skill>>(json);
                _ctx.Skills.AddRange(skills);

                _ctx.SaveChanges();

            }
        }
    }
}
