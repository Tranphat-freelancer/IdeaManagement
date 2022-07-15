﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuanLySangKien.EntityFrameworkCore;

[DependsOn(
    typeof(QuanLySangKienDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class QuanLySangKienEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<QuanLySangKienDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
