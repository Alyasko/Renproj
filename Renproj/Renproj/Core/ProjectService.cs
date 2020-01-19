using Renproj.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using Renproj.Utils;

namespace Renproj.Core
{
    public class ProjectService : ISolutionProjectService
    {
        public ProjectService()
        {
            
        }

        public IEnumerable<SolutionProject> GetProjects()
        {
            var projects = SolutionUtils.Projects();
            return projects.Select(x => new SolutionProject()
            {
                FilePath = x.FileName,
                Name = x.Name
            });
        }
    }
}
