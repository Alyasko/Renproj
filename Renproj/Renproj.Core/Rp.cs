using Renproj.Core.Projects;

namespace Renproj.Core
{
    public class Rp
    {
        private readonly ISolutionProjectService _solutionProjectService;


        public Rp(ISolutionProjectService solutionProjectService)
        {
            _solutionProjectService = solutionProjectService;
        }

        public void Execute()
        {
            var projects = _solutionProjectService.GetProjects();
        }
    }
}
