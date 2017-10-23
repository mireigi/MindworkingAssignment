using Cv.Core.Data;
using Cv.Core.Models;
using Cv.GraphQL.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cv.GraphQL.Queries
{
    public class MultiQuery : ObjectGraphType
    {
        private readonly ISkillRepository _skillRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IEducationRepository _educationRepository;

        public MultiQuery(ISkillRepository skillRepository, ICompanyRepository companyRepository, IProjectRepository projectRepository, IEducationRepository educationRepository)
        {
            _skillRepository = skillRepository;
            _companyRepository = companyRepository;
            _projectRepository = projectRepository;
            _educationRepository = educationRepository;

            DefineFieldWithArgument<SkillType, Skill>("skill", _skillRepository.Get, "id");
            DefineFieldWithArgument<CompanyType, Company>("company", _companyRepository.Get, "id");
            DefineFieldWithArgument<ProjectType, Project>("project", _projectRepository.Get, "id");
            DefineFieldWithArgument<EducationType, Education>("education", _educationRepository.Get, "id");

            DefineListField<SkillType, Skill>("skills", _skillRepository.GetAll);
            DefineListField<CompanyType, Company>("companies", _companyRepository.GetAll);
            DefineListField<ProjectType, Project>("projects", _projectRepository.GetAll);
            DefineListField<EducationType, Education>("educations", _educationRepository.GetAll);
        }

        private void DefineListField<TGraphType, TType>(string queryName, Func<Task<List<TType>>> function)
            where TGraphType : ObjectGraphType<TType>
        {
            Field<ListGraphType<TGraphType>>(name: queryName, resolve: context => { return function(); });
        }

        private void DefineFieldWithArgument<TGraphType, TType>(string queryName, Func<int, Task<TType>> function, string argumentName)
            where TGraphType : ObjectGraphType<TType>
        {
            Field<TGraphType>(
                name: queryName,
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = argumentName }),
                resolve: context =>
                {
                    int argument = context.GetArgument<int>(argumentName);
                    return function(argument);
                });
        }
    }
}