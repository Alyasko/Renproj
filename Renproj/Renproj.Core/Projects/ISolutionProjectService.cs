using System.Collections;
using System.Collections.Generic;

namespace Renproj.Core.Projects
{
    public interface ISolutionProjectService
    {
        IEnumerable<SolutionProject> GetProjects();
    }
}
